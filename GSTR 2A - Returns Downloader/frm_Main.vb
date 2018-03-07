Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.IE
Imports OpenQA.Selenium.Support.UI
Public Class frm_Main
    Dim driver As IWebDriver
    Dim driver_path As String = IO.Path.Combine(Application.StartupPath, "webdrivers")
    Dim driver_path_x64 As String = IO.Path.Combine(Application.StartupPath, "webdrivers", "x64")
    Dim TempDir As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, "GSTR2A_" & (New Random).Next(111111, 999999))
    Dim StoreDir As String
    Dim Files2Move As New List(Of File)
    Dim CurrentMonth As String = ""
    Private Sub frm_Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If driver IsNot Nothing Then
                driver.Close()
            End If
        Catch ex As Exception

        End Try
        KillProcesses()
    End Sub
    Sub KillProcesses()
        For Each i As Process In Process.GetProcessesByName("geckodriver")
            Try
                i.Kill()
            Catch ex As Exception

            End Try
        Next
    End Sub
    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        txt_DestPath.EditValue = My.Settings.LastPath
        Me.Size = My.Settings.LastSize
        Me.Location = My.Settings.LastLoc
        KillProcesses()
    End Sub
    Sub DisableControls()
        Me.TopMost = True
        Me.btn_Start.Enabled = False
        Me.btn_Stop.Visible = True
        Me.btn_Continue.Visible = True
        Me.txt_LoginID.Enabled = False
        Me.txt_Password.Enabled = False
        prog_Status.EditValue = 0
        Me.txt_DestPath.Enabled = False
    End Sub
    Sub EnableControls()
        Me.TopMost = False
        Me.btn_Start.Enabled = True
        Me.btn_Stop.Visible = False
        Me.btn_Continue.Visible = False
        Me.txt_LoginID.Enabled = True
        Me.txt_Password.Enabled = True
        prog_Status.EditValue = 0
        Me.txt_DestPath.Enabled = True
    End Sub
    Private Sub btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click
        DisableControls()
        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Me.Width, My.Computer.Screen.WorkingArea.Height - Me.Height)
        LoginWorker.RunWorkerAsync()
        StoreDir = txt_DestPath.EditValue
        If My.Computer.FileSystem.DirectoryExists(StoreDir) = False Then
            My.Computer.FileSystem.CreateDirectory(StoreDir)
        End If
    End Sub
    Sub StartDriver()
        If driver IsNot Nothing Then
            Try
                driver.Close()
            Catch ex As Exception

            End Try
        End If
        My.Computer.FileSystem.CreateDirectory(TempDir)
        Dim FirefoxOpt As New FirefoxOptions
        FirefoxOpt.Profile = New FirefoxProfile
        FirefoxOpt.Profile.AcceptUntrustedCertificates = True
        FirefoxOpt.Profile.SetPreference("browser.download.folderList", 2)
        FirefoxOpt.Profile.SetPreference("browser.download.dir", TempDir)
        FirefoxOpt.Profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/zip")
        FirefoxOpt.AcceptInsecureCertificates = True
        Dim driverservice As FirefoxDriverService
        If Environment.Is64BitOperatingSystem Then
            driverservice = FirefoxDriverService.CreateDefaultService(driver_path_x64)
        Else
            driverservice = FirefoxDriverService.CreateDefaultService(driver_path)
        End If
        driverservice.HideCommandPromptWindow = True
        driver = New FirefoxDriver(driverservice, FirefoxOpt, New TimeSpan(1, 0, 0, 0))
    End Sub

    Private Sub LoginWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles LoginWorker.DoWork
        StartDriver()
        driver.Navigate().GoToUrl("https://services.gst.gov.in/services/login")
        WaitForLoad()
        driver.FindElement(By.Id("username")).SendKeys(txt_LoginID.EditValue)
        driver.FindElement(By.Id("user_pass")).SendKeys(txt_Password.EditValue)
    End Sub
    Sub WaitForLoad()
        driver.Manage.Timeouts.ImplicitWait = New TimeSpan(0, 0, 5)
        Dim wait As WebDriverWait = New WebDriverWait(driver, New TimeSpan(10000))
        Dim Func As System.Func(Of IWebDriver, Boolean) = AddressOf CheckPageLoaded
        wait.Until(Func)
    End Sub
    Function CheckPageLoaded(ByVal Driver As IWebDriver) As Boolean
        Return CType(Driver, IJavaScriptExecutor).ExecuteScript("return document.readyState").Equals("complete")
    End Function

    Private Sub LoginWorker2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles LoginWorker2.DoWork
        ClickButtonByText("LOGIN")
        WaitForLoad()
        Threading.Thread.Sleep(3000)
        ClickButtonByText("RETURN DASHBOARD")
        WaitForLoad()
        If Jobs.EditValue = 0 Then
            prog_Status.Properties.Maximum = Months.CheckedItems.Count
            prog_Status.EditValue = 0
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Months.Items
                If i.CheckState = CheckState.Checked Then
                    prog_Status.EditValue += 1
                    RequestGSTR(i.ToString)
                End If
            Next
        ElseIf Jobs.EditValue = 1 Then
            FileSystemWatcher1.Path = TempDir
            FileSystemWatcher1.EnableRaisingEvents = True
            prog_Status.Properties.Maximum = Months.CheckedItems.Count
            prog_Status.EditValue = 0
            For Each i As DevExpress.XtraEditors.Controls.CheckedListBoxItem In Months.Items
                If i.CheckState = CheckState.Checked Then
                    prog_Status.EditValue += 1
                    CurrentMonth = i.ToString
                    DownloadGSTR(i.ToString)
                End If
            Next
        End If
        driver.Navigate().GoToUrl("https://services.gst.gov.in/services/logout")
        FileSystemWatcher1.EnableRaisingEvents = False
        Threading.Thread.Sleep(5000)
        For Each i As File In Files2Move
            i.Move()
        Next
        EnableControls()
        MsgBox("Process Completed... :-)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done")
    End Sub
    Sub DownloadGSTR(ByVal Mon As String)
        Threading.Thread.Sleep(3000)
        Dim Month = driver.FindElement(By.Name("mon"))
        Month.SendKeys(Mon)
        ClickButtonByText("SEARCH")
        Threading.Thread.Sleep(2000)
        ClickButtonByText("DOWNLOAD")
        WaitForLoad()
        Threading.Thread.Sleep(2000)
        ClickButtonByText("GENERATE FILE")
        Threading.Thread.Sleep(3000)
        For Each i As IWebElement In driver.FindElements(By.TagName("alert-message"))
            If i.GetAttribute("ng-show") = "showMsg" Then
                If i.Text.Contains("Your request for generation has been accepted kindly wait for") Then
                    txt_Console.Focus()
                    txt_Console.AppendText(Mon & " - File not generated. Generation Requested." & vbNewLine)
                ElseIf i.Text.Contains("File Generation is in progress, please try after sometime..") Then
                    txt_Console.Focus()
                    txt_Console.AppendText(Mon & " - Generation is in progress" & vbNewLine)
                ElseIf i.Text.Contains("click on generate file again") Then
                    For Each link As IWebElement In driver.FindElements(By.TagName("a"))
                        If link.Text.Contains("Click here to download - File 1") Then
                            txt_Console.Focus()
                            txt_Console.AppendText(Mon & " - File Found. Downloading." & vbNewLine)
                            link.Click()
                        End If
                    Next
                End If
            End If
        Next
        Threading.Thread.Sleep(2000)
        ClickButtonByText("BACK")
        Threading.Thread.Sleep(3000)
    End Sub
    Sub RequestGSTR(ByVal Mon As String)
        Threading.Thread.Sleep(3000)
        Dim Month = driver.FindElement(By.Name("mon"))
        Month.SendKeys(Mon)
        ClickButtonByText("SEARCH")
        Threading.Thread.Sleep(2000)
        ClickButtonByText("DOWNLOAD")
        WaitForLoad()
        Threading.Thread.Sleep(2000)
        ClickButtonByText("GENERATE FILE")
        Threading.Thread.Sleep(3000)
        For Each i As IWebElement In driver.FindElements(By.TagName("alert-message"))
            If i.GetAttribute("ng-show") = "showMsg" Then
                If i.Text.Contains("Your request for generation has been accepted kindly wait for") Then
                    txt_Console.Focus()
                    txt_Console.AppendText(Mon & " - Success" & vbNewLine)
                ElseIf i.Text.Contains("File Generation is in progress, please try after sometime..") Then
                    txt_Console.Focus()
                    txt_Console.AppendText(Mon & " - Generation is in progress" & vbNewLine)
                ElseIf i.Text.Contains("click on generate file again") Then
                    txt_Console.Focus()
                    txt_Console.AppendText(Mon & " - Old Generation Found. Generating New." & vbNewLine)
                    ClickButtonByText("GENERATE FILE")
                End If
            End If
        Next
        Threading.Thread.Sleep(2000)
        ClickButtonByText("BACK")
        Threading.Thread.Sleep(3000)
    End Sub
    Sub ClickButtonByText(ByVal BtnName As String)
        For Each i As IWebElement In driver.FindElements(By.TagName("button"))
            If i.Text = BtnName Then
                Dim tries As Integer = 0
Click:
                tries += 1
                Try
                    i.Click()
                Catch ex As InvalidOperationException
                    If tries < 11 Then
                        Threading.Thread.Sleep(1000)
                        GoTo Click
                    End If
                End Try
                Exit For
            End If
        Next
    End Sub
    Private Sub btn_Continue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Continue.Click
        Me.btn_Continue.Visible = False
        LoginWorker2.RunWorkerAsync()
    End Sub

    Private Sub btn_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Stop.Click
        EnableControls()
        If LoginWorker.IsBusy Then
            LoginWorker.CancelAsync()
        End If
        If LoginWorker2.IsBusy Then
            LoginWorker2.CancelAsync()
        End If
        driver.Close()
    End Sub

    Private Sub txt_DestPath_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_DestPath.ButtonClick
        FolderBrowserDlg.SelectedPath = txt_DestPath.EditValue
        If FolderBrowserDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_DestPath.EditValue = FolderBrowserDlg.SelectedPath
            My.Settings.LastPath = FolderBrowserDlg.SelectedPath
            My.Settings.Save()
        End If
    End Sub

    Private Sub txt_LoginID_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles txt_LoginID.EditValueChanged
        If txt_LoginID.EditValue.ToString.Contains(vbTab) Then
            Dim s As String() = txt_LoginID.EditValue.ToString.Split(vbTab)
            txt_LoginID.EditValue = s(0)
            txt_Password.EditValue = s(1)
            txt_LoginID.Refresh()
        End If
    End Sub

    Private Sub FileSystemWatcher1_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FileSystemWatcher1.Created
        Dim S As String() = IO.Path.GetFileNameWithoutExtension(e.FullPath).Split("_")
        Dim DestName As String = String.Format("{0}_{1}_{2}_{3}_{4}.zip", S(0), S(1), S(2), S(3), CurrentMonth.Substring(0, 3).ToUpper)
        txt_Console.Focus()
        txt_Console.AppendText(CurrentMonth & " - File Found." & IO.Path.GetFileName(e.FullPath) & vbNewLine)
        txt_Console.AppendText("Will move File to " & DestName & vbNewLine)
        Files2Move.Add(New File(e.FullPath, IO.Path.Combine(StoreDir, DestName)))
    End Sub
End Class
Public Class File
    Sub New(ByVal src As String, ByVal dest As String)
        Me.SourceFile = src
        Me.DestFile = dest
    End Sub
    Property SourceFile As String
    Property DestFile As String
    Sub Move()
        My.Computer.FileSystem.MoveFile(SourceFile, DestFile)
    End Sub
End Class