<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits XtraFormTemp

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grp_Options = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_DestPath = New DevExpress.XtraEditors.ButtonEdit()
        Me.txt_Console = New System.Windows.Forms.TextBox()
        Me.prog_Status = New DevExpress.XtraEditors.ProgressBarControl()
        Me.grp_Months = New DevExpress.XtraEditors.GroupControl()
        Me.Months = New DevExpress.XtraEditors.CheckedListBoxControl()
        Me.grp_Jobs = New DevExpress.XtraEditors.GroupControl()
        Me.Jobs = New DevExpress.XtraEditors.RadioGroup()
        Me.btn_Stop = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Continue = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_Password = New DevExpress.XtraEditors.TextEdit()
        Me.txt_LoginID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_Start = New DevExpress.XtraEditors.SimpleButton()
        Me.LoginWorker = New System.ComponentModel.BackgroundWorker()
        Me.LoginWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.FolderBrowserDlg = New System.Windows.Forms.FolderBrowserDialog()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        CType(Me.grp_Options, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Options.SuspendLayout()
        CType(Me.txt_DestPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prog_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Months, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Months.SuspendLayout()
        CType(Me.Months, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grp_Jobs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Jobs.SuspendLayout()
        CType(Me.Jobs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LoginID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'grp_Options
        '
        Me.grp_Options.Controls.Add(Me.LabelControl3)
        Me.grp_Options.Controls.Add(Me.txt_DestPath)
        Me.grp_Options.Controls.Add(Me.txt_Console)
        Me.grp_Options.Controls.Add(Me.prog_Status)
        Me.grp_Options.Controls.Add(Me.grp_Months)
        Me.grp_Options.Controls.Add(Me.grp_Jobs)
        Me.grp_Options.Controls.Add(Me.btn_Stop)
        Me.grp_Options.Controls.Add(Me.btn_Continue)
        Me.grp_Options.Controls.Add(Me.txt_Password)
        Me.grp_Options.Controls.Add(Me.txt_LoginID)
        Me.grp_Options.Controls.Add(Me.LabelControl2)
        Me.grp_Options.Controls.Add(Me.LabelControl1)
        Me.grp_Options.Controls.Add(Me.btn_Start)
        Me.grp_Options.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_Options.Location = New System.Drawing.Point(0, 0)
        Me.grp_Options.Name = "grp_Options"
        Me.grp_Options.Size = New System.Drawing.Size(270, 554)
        Me.grp_Options.TabIndex = 5
        Me.grp_Options.Text = "Controls"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 383)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Save Files to :"
        '
        'txt_DestPath
        '
        Me.txt_DestPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DestPath.EditValue = ""
        Me.txt_DestPath.Location = New System.Drawing.Point(79, 380)
        Me.txt_DestPath.Name = "txt_DestPath"
        Me.txt_DestPath.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txt_DestPath.Properties.ReadOnly = True
        Me.txt_DestPath.Size = New System.Drawing.Size(186, 20)
        Me.txt_DestPath.TabIndex = 14
        '
        'txt_Console
        '
        Me.txt_Console.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Console.BackColor = System.Drawing.Color.Black
        Me.txt_Console.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txt_Console.Location = New System.Drawing.Point(5, 407)
        Me.txt_Console.Multiline = True
        Me.txt_Console.Name = "txt_Console"
        Me.txt_Console.ShortcutsEnabled = False
        Me.txt_Console.Size = New System.Drawing.Size(260, 142)
        Me.txt_Console.TabIndex = 13
        Me.txt_Console.WordWrap = False
        '
        'prog_Status
        '
        Me.prog_Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.prog_Status.Location = New System.Drawing.Point(5, 356)
        Me.prog_Status.Name = "prog_Status"
        Me.prog_Status.Size = New System.Drawing.Size(260, 18)
        Me.prog_Status.TabIndex = 12
        '
        'grp_Months
        '
        Me.grp_Months.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Months.Controls.Add(Me.Months)
        Me.grp_Months.Location = New System.Drawing.Point(5, 167)
        Me.grp_Months.Name = "grp_Months"
        Me.grp_Months.Size = New System.Drawing.Size(260, 183)
        Me.grp_Months.TabIndex = 10
        Me.grp_Months.Text = "Months"
        '
        'Months
        '
        Me.Months.Cursor = System.Windows.Forms.Cursors.Default
        Me.Months.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Months.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("April", "April"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("May", "May"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("June", "June"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("July", "July"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("August"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("September", "September"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("October", "October"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("November", "November"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "December", "December"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem(Nothing, "January", "January"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("February", "February"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("March", "March")})
        Me.Months.Location = New System.Drawing.Point(2, 20)
        Me.Months.Name = "Months"
        Me.Months.Size = New System.Drawing.Size(256, 161)
        Me.Months.TabIndex = 9
        '
        'grp_Jobs
        '
        Me.grp_Jobs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Jobs.Controls.Add(Me.Jobs)
        Me.grp_Jobs.Location = New System.Drawing.Point(5, 80)
        Me.grp_Jobs.Name = "grp_Jobs"
        Me.grp_Jobs.Size = New System.Drawing.Size(179, 81)
        Me.grp_Jobs.TabIndex = 8
        Me.grp_Jobs.Text = "Job"
        '
        'Jobs
        '
        Me.Jobs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Jobs.EditValue = 0
        Me.Jobs.Location = New System.Drawing.Point(2, 20)
        Me.Jobs.Name = "Jobs"
        Me.Jobs.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Generate Download"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Download File")})
        Me.Jobs.Size = New System.Drawing.Size(175, 59)
        Me.Jobs.TabIndex = 0
        '
        'btn_Stop
        '
        Me.btn_Stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Stop.Location = New System.Drawing.Point(190, 138)
        Me.btn_Stop.Name = "btn_Stop"
        Me.btn_Stop.Size = New System.Drawing.Size(75, 23)
        Me.btn_Stop.TabIndex = 7
        Me.btn_Stop.Text = "Stop"
        Me.btn_Stop.Visible = False
        '
        'btn_Continue
        '
        Me.btn_Continue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Continue.Location = New System.Drawing.Point(190, 109)
        Me.btn_Continue.Name = "btn_Continue"
        Me.btn_Continue.Size = New System.Drawing.Size(75, 23)
        Me.btn_Continue.TabIndex = 7
        Me.btn_Continue.Text = "Continue"
        Me.btn_Continue.Visible = False
        '
        'txt_Password
        '
        Me.txt_Password.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Password.EditValue = ""
        Me.txt_Password.Location = New System.Drawing.Point(79, 54)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.Properties.UseSystemPasswordChar = True
        Me.txt_Password.Size = New System.Drawing.Size(186, 20)
        Me.txt_Password.TabIndex = 6
        '
        'txt_LoginID
        '
        Me.txt_LoginID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_LoginID.EditValue = ""
        Me.txt_LoginID.Location = New System.Drawing.Point(79, 26)
        Me.txt_LoginID.Name = "txt_LoginID"
        Me.txt_LoginID.Size = New System.Drawing.Size(186, 20)
        Me.txt_LoginID.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Password :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "GST Login ID :"
        '
        'btn_Start
        '
        Me.btn_Start.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Start.Location = New System.Drawing.Point(190, 80)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(75, 23)
        Me.btn_Start.TabIndex = 0
        Me.btn_Start.Text = "Start"
        '
        'LoginWorker
        '
        Me.LoginWorker.WorkerSupportsCancellation = True
        '
        'LoginWorker2
        '
        Me.LoginWorker2.WorkerSupportsCancellation = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.Filter = "*.zip"
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 554)
        Me.Controls.Add(Me.grp_Options)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(280, 2500)
        Me.MinimumSize = New System.Drawing.Size(280, 586)
        Me.Name = "frm_Main"
        Me.Text = "GSTR 2A Returns Downloader"
        CType(Me.grp_Options, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Options.ResumeLayout(False)
        Me.grp_Options.PerformLayout()
        CType(Me.txt_DestPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prog_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Months, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Months.ResumeLayout(False)
        CType(Me.Months, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grp_Jobs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Jobs.ResumeLayout(False)
        CType(Me.Jobs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LoginID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents grp_Options As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_Start As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Continue As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_LoginID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_Stop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LoginWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents LoginWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents grp_Months As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Months As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents grp_Jobs As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Jobs As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents prog_Status As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents txt_Console As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_DestPath As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents FolderBrowserDlg As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher

End Class
