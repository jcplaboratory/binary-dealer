<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmdRestore = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DefInput = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AutoConvertMode = New System.Windows.Forms.CheckBox()
        Me.AutoClipboard = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RDOnly = New System.Windows.Forms.CheckBox()
        Me.DetectUrs = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FTBrowser = New System.Windows.Forms.Button()
        Me.txtFont = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Wwrap = New System.Windows.Forms.CheckBox()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.cmdApply = New System.Windows.Forms.Button()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.Terminator = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(357, 299)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(349, 273)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdRestore)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 174)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(330, 93)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Default Settings"
        '
        'cmdRestore
        '
        Me.cmdRestore.Location = New System.Drawing.Point(6, 38)
        Me.cmdRestore.Name = "cmdRestore"
        Me.cmdRestore.Size = New System.Drawing.Size(318, 23)
        Me.cmdRestore.TabIndex = 0
        Me.cmdRestore.Text = "&Restore Default Settings"
        Me.cmdRestore.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DefInput)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input method"
        '
        'DefInput
        '
        Me.DefInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DefInput.FormattingEnabled = True
        Me.DefInput.Items.AddRange(New Object() {"Text Document", "Input String"})
        Me.DefInput.Location = New System.Drawing.Point(122, 37)
        Me.DefInput.Name = "DefInput"
        Me.DefInput.Size = New System.Drawing.Size(208, 21)
        Me.DefInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Default Input Method:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AutoConvertMode)
        Me.GroupBox1.Controls.Add(Me.AutoClipboard)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conversion"
        '
        'AutoConvertMode
        '
        Me.AutoConvertMode.AutoSize = True
        Me.AutoConvertMode.Location = New System.Drawing.Point(6, 42)
        Me.AutoConvertMode.Name = "AutoConvertMode"
        Me.AutoConvertMode.Size = New System.Drawing.Size(169, 17)
        Me.AutoConvertMode.TabIndex = 1
        Me.AutoConvertMode.Text = "Auto Switch Conversion Mode"
        Me.AutoConvertMode.UseVisualStyleBackColor = True
        '
        'AutoClipboard
        '
        Me.AutoClipboard.AutoSize = True
        Me.AutoClipboard.Location = New System.Drawing.Point(6, 19)
        Me.AutoClipboard.Name = "AutoClipboard"
        Me.AutoClipboard.Size = New System.Drawing.Size(134, 17)
        Me.AutoClipboard.TabIndex = 0
        Me.AutoClipboard.Text = "Auto Copy to Clipboard"
        Me.AutoClipboard.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(349, 273)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editor Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RDOnly)
        Me.GroupBox4.Controls.Add(Me.DetectUrs)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 154)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "General"
        '
        'RDOnly
        '
        Me.RDOnly.AutoSize = True
        Me.RDOnly.Location = New System.Drawing.Point(7, 44)
        Me.RDOnly.Name = "RDOnly"
        Me.RDOnly.Size = New System.Drawing.Size(179, 17)
        Me.RDOnly.TabIndex = 1
        Me.RDOnly.Text = "Read Only if text is in binary form"
        Me.RDOnly.UseVisualStyleBackColor = True
        '
        'DetectUrs
        '
        Me.DetectUrs.AutoSize = True
        Me.DetectUrs.Location = New System.Drawing.Point(7, 20)
        Me.DetectUrs.Name = "DetectUrs"
        Me.DetectUrs.Size = New System.Drawing.Size(79, 17)
        Me.DetectUrs.TabIndex = 0
        Me.DetectUrs.Text = "Detect Urls"
        Me.DetectUrs.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FTBrowser)
        Me.GroupBox3.Controls.Add(Me.txtFont)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Wwrap)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(336, 99)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Format"
        '
        'FTBrowser
        '
        Me.FTBrowser.Location = New System.Drawing.Point(292, 56)
        Me.FTBrowser.Name = "FTBrowser"
        Me.FTBrowser.Size = New System.Drawing.Size(38, 21)
        Me.FTBrowser.TabIndex = 2
        Me.FTBrowser.Text = "..."
        Me.FTBrowser.UseVisualStyleBackColor = True
        '
        'txtFont
        '
        Me.txtFont.BackColor = System.Drawing.Color.White
        Me.txtFont.Location = New System.Drawing.Point(7, 56)
        Me.txtFont.Name = "txtFont"
        Me.txtFont.ReadOnly = True
        Me.txtFont.Size = New System.Drawing.Size(279, 20)
        Me.txtFont.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select Font:"
        '
        'Wwrap
        '
        Me.Wwrap.AutoSize = True
        Me.Wwrap.Location = New System.Drawing.Point(7, 20)
        Me.Wwrap.Name = "Wwrap"
        Me.Wwrap.Size = New System.Drawing.Size(81, 17)
        Me.Wwrap.TabIndex = 0
        Me.Wwrap.Text = "Word Wrap"
        Me.Wwrap.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Location = New System.Drawing.Point(213, 317)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(75, 23)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "&OK"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(294, 317)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 2
        Me.cmdApply.Text = "&Apply"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'FontDialog
        '
        Me.FontDialog.AllowScriptChange = False
        Me.FontDialog.ShowEffects = False
        '
        'Terminator
        '
        Me.Terminator.Enabled = True
        Me.Terminator.Interval = 1
        '
        'Settings
        '
        Me.AcceptButton = Me.cmdOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 352)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Binary Dealer - Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents cmdApply As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AutoClipboard As System.Windows.Forms.CheckBox
    Friend WithEvents AutoConvertMode As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DefInput As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents FTBrowser As System.Windows.Forms.Button
    Friend WithEvents txtFont As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Wwrap As System.Windows.Forms.CheckBox
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DetectUrs As System.Windows.Forms.CheckBox
    Friend WithEvents RDOnly As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRestore As System.Windows.Forms.Button
    Friend WithEvents Terminator As System.Windows.Forms.Timer
End Class
