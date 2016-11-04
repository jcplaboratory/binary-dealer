<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chkMatchCase = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbDown = New System.Windows.Forms.RadioButton()
        Me.rbUp = New System.Windows.Forms.RadioButton()
        Me.Front = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find what:"
        '
        'txtFind
        '
        Me.txtFind.Location = New System.Drawing.Point(75, 10)
        Me.txtFind.Name = "txtFind"
        Me.txtFind.Size = New System.Drawing.Size(187, 20)
        Me.txtFind.TabIndex = 1
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(268, 7)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "&Find Next"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(268, 38)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chkMatchCase
        '
        Me.chkMatchCase.AutoSize = True
        Me.chkMatchCase.Location = New System.Drawing.Point(12, 58)
        Me.chkMatchCase.Name = "chkMatchCase"
        Me.chkMatchCase.Size = New System.Drawing.Size(82, 17)
        Me.chkMatchCase.TabIndex = 4
        Me.chkMatchCase.Text = "Match case"
        Me.chkMatchCase.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "More settings >>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbDown)
        Me.GroupBox1.Controls.Add(Me.rbUp)
        Me.GroupBox1.Location = New System.Drawing.Point(149, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(113, 47)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Direction"
        '
        'rbDown
        '
        Me.rbDown.AutoSize = True
        Me.rbDown.Location = New System.Drawing.Point(53, 20)
        Me.rbDown.Name = "rbDown"
        Me.rbDown.Size = New System.Drawing.Size(53, 17)
        Me.rbDown.TabIndex = 1
        Me.rbDown.TabStop = True
        Me.rbDown.Text = "&Down"
        Me.rbDown.UseVisualStyleBackColor = True
        '
        'rbUp
        '
        Me.rbUp.AutoSize = True
        Me.rbUp.Location = New System.Drawing.Point(7, 20)
        Me.rbUp.Name = "rbUp"
        Me.rbUp.Size = New System.Drawing.Size(39, 17)
        Me.rbUp.TabIndex = 0
        Me.rbUp.TabStop = True
        Me.rbUp.Text = "&Up"
        Me.rbUp.UseVisualStyleBackColor = True
        '
        'Front
        '
        Me.Front.Enabled = True
        Me.Front.Interval = 1
        '
        'frmFind
        '
        Me.AcceptButton = Me.btnFind
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 108)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkMatchCase)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFind)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFind"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chkMatchCase As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbDown As System.Windows.Forms.RadioButton
    Friend WithEvents rbUp As System.Windows.Forms.RadioButton
    Friend WithEvents Front As System.Windows.Forms.Timer
End Class
