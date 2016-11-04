<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Binary_Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Binary_Calculator))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDIV = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt2ndInput = New System.Windows.Forms.TextBox()
        Me.txt1stInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOutput)
        Me.GroupBox1.Controls.Add(Me.btnDIV)
        Me.GroupBox1.Controls.Add(Me.btnMul)
        Me.GroupBox1.Controls.Add(Me.btnMinus)
        Me.GroupBox1.Controls.Add(Me.btnPlus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt2ndInput)
        Me.GroupBox1.Controls.Add(Me.txt1stInput)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 210)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculator"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(6, 114)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(266, 20)
        Me.txtOutput.TabIndex = 4
        '
        'btnDIV
        '
        Me.btnDIV.Location = New System.Drawing.Point(210, 140)
        Me.btnDIV.Name = "btnDIV"
        Me.btnDIV.Size = New System.Drawing.Size(62, 58)
        Me.btnDIV.TabIndex = 3
        Me.btnDIV.Text = "/"
        Me.btnDIV.UseVisualStyleBackColor = True
        '
        'btnMul
        '
        Me.btnMul.Location = New System.Drawing.Point(142, 140)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(62, 58)
        Me.btnMul.TabIndex = 3
        Me.btnMul.Text = "*"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(74, 140)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(62, 58)
        Me.btnMinus.TabIndex = 3
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(6, 140)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(62, 58)
        Me.btnPlus.TabIndex = 3
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Second Binary input:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Binary input:"
        '
        'txt2ndInput
        '
        Me.txt2ndInput.Location = New System.Drawing.Point(6, 77)
        Me.txt2ndInput.MaxLength = 8
        Me.txt2ndInput.Name = "txt2ndInput"
        Me.txt2ndInput.Size = New System.Drawing.Size(266, 20)
        Me.txt2ndInput.TabIndex = 1
        '
        'txt1stInput
        '
        Me.txt1stInput.Location = New System.Drawing.Point(6, 37)
        Me.txt1stInput.MaxLength = 8
        Me.txt1stInput.Name = "txt1stInput"
        Me.txt1stInput.Size = New System.Drawing.Size(266, 20)
        Me.txt1stInput.TabIndex = 0
        '
        'Binary_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 234)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Binary_Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Binary Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnDIV As System.Windows.Forms.Button
    Friend WithEvents btnMul As System.Windows.Forms.Button
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt2ndInput As System.Windows.Forms.TextBox
    Friend WithEvents txt1stInput As System.Windows.Forms.TextBox
End Class
