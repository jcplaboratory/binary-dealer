<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASCII_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ASCII_Main))
        Me.RTBOutput = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextFileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAsTextDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryCalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwitchToEditorViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversionModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASCIIToBinaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryToASCIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputMethodToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdNewdoc = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSmodeCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.TScomboInput = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProgBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CHKSaveHistory = New System.Windows.Forms.CheckBox()
        Me.ComboPath = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenTextFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ContentVerifier = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatSave = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RTBOutput
        '
        Me.RTBOutput.Location = New System.Drawing.Point(15, 250)
        Me.RTBOutput.Name = "RTBOutput"
        Me.RTBOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RTBOutput.Size = New System.Drawing.Size(605, 186)
        Me.RTBOutput.TabIndex = 2
        Me.RTBOutput.Text = ""
        Me.RTBOutput.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Conversion Output:"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MenuToolStripMenuItem, Me.WindowToolStripMenuItem, Me.OptionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 4
        Me.MenuStrip.Text = "MainStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.NewFileToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveToolStripMenuItem1, Me.SaveAsToolStripMenuItem1, Me.ToolStripSeparator4, Me.PrintSetupToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.o
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.OpenFileToolStripMenuItem.Text = "&Open File"
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextFileToolStripMenuItem1})
        Me.NewFileToolStripMenuItem.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.edit_ico
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewFileToolStripMenuItem.Text = "&New File"
        '
        'TextFileToolStripMenuItem1
        '
        Me.TextFileToolStripMenuItem1.Name = "TextFileToolStripMenuItem1"
        Me.TextFileToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.TextFileToolStripMenuItem1.Text = "Text File"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(129, 6)
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.Save_icon
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.SaveToolStripMenuItem1.Text = "&Save"
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAsTextDocumentToolStripMenuItem})
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.SaveAsToolStripMenuItem1.Text = "Save &As"
        '
        'ExportAsTextDocumentToolStripMenuItem
        '
        Me.ExportAsTextDocumentToolStripMenuItem.Name = "ExportAsTextDocumentToolStripMenuItem"
        Me.ExportAsTextDocumentToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExportAsTextDocumentToolStripMenuItem.Text = "&Text Document"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(129, 6)
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PrintSetupToolStripMenuItem.Text = "Print &Setup"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.Print_Ico
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinaryCalculatorToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'BinaryCalculatorToolStripMenuItem
        '
        Me.BinaryCalculatorToolStripMenuItem.Name = "BinaryCalculatorToolStripMenuItem"
        Me.BinaryCalculatorToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.BinaryCalculatorToolStripMenuItem.Text = "&Binary Calculator"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwitchToEditorViewToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'SwitchToEditorViewToolStripMenuItem
        '
        Me.SwitchToEditorViewToolStripMenuItem.Name = "SwitchToEditorViewToolStripMenuItem"
        Me.SwitchToEditorViewToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SwitchToEditorViewToolStripMenuItem.Text = "&Open With: BD Editor"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConversionModeToolStripMenuItem, Me.InputMethodToolStripMenuItem, Me.ToolStripSeparator5, Me.SettingsToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "&Option"
        '
        'ConversionModeToolStripMenuItem
        '
        Me.ConversionModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASCIIToBinaryToolStripMenuItem, Me.BinaryToASCIIToolStripMenuItem})
        Me.ConversionModeToolStripMenuItem.Name = "ConversionModeToolStripMenuItem"
        Me.ConversionModeToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ConversionModeToolStripMenuItem.Text = "Conversion mode"
        '
        'ASCIIToBinaryToolStripMenuItem
        '
        Me.ASCIIToBinaryToolStripMenuItem.Name = "ASCIIToBinaryToolStripMenuItem"
        Me.ASCIIToBinaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ASCIIToBinaryToolStripMenuItem.Text = "ASCII to Binary"
        '
        'BinaryToASCIIToolStripMenuItem
        '
        Me.BinaryToASCIIToolStripMenuItem.Name = "BinaryToASCIIToolStripMenuItem"
        Me.BinaryToASCIIToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BinaryToASCIIToolStripMenuItem.Text = "Binary to ASCII"
        '
        'InputMethodToolStripMenuItem
        '
        Me.InputMethodToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextDocumentToolStripMenuItem, Me.InputStringToolStripMenuItem})
        Me.InputMethodToolStripMenuItem.Name = "InputMethodToolStripMenuItem"
        Me.InputMethodToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.InputMethodToolStripMenuItem.Text = "Input method"
        '
        'TextDocumentToolStripMenuItem
        '
        Me.TextDocumentToolStripMenuItem.Name = "TextDocumentToolStripMenuItem"
        Me.TextDocumentToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TextDocumentToolStripMenuItem.Text = "Text Document"
        '
        'InputStringToolStripMenuItem
        '
        Me.InputStringToolStripMenuItem.Name = "InputStringToolStripMenuItem"
        Me.InputStringToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.InputStringToolStripMenuItem.Text = "Input String"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(165, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.AdminTools
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.Binary_Dealer
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewdoc, Me.ToolStripDropDownButton1, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.TSmodeCombo, Me.ToolStripLabel2, Me.TScomboInput, Me.ToolStripSeparator2, Me.ProgBar})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip.TabIndex = 5
        Me.ToolStrip.Text = "MainToolstrip"
        '
        'cmdNewdoc
        '
        Me.cmdNewdoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNewdoc.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextFileToolStripMenuItem})
        Me.cmdNewdoc.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.edit_ico
        Me.cmdNewdoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewdoc.Name = "cmdNewdoc"
        Me.cmdNewdoc.Size = New System.Drawing.Size(29, 22)
        Me.cmdNewdoc.Text = "Create a new file"
        '
        'TextFileToolStripMenuItem
        '
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TextFileToolStripMenuItem.Text = "&Text File"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.CopyToClipboardToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.Save_icon
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "Save Conversion"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SaveAsToolStripMenuItem.Text = "&Save As"
        '
        'CopyToClipboardToolStripMenuItem
        '
        Me.CopyToClipboardToolStripMenuItem.Name = "CopyToClipboardToolStripMenuItem"
        Me.CopyToClipboardToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CopyToClipboardToolStripMenuItem.Text = "&Copy to Clipboard"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(104, 22)
        Me.ToolStripLabel1.Text = "Conversion Mode:"
        '
        'TSmodeCombo
        '
        Me.TSmodeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TSmodeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TSmodeCombo.Items.AddRange(New Object() {"Binary to ASCII", "ASCII to Binary"})
        Me.TSmodeCombo.Name = "TSmodeCombo"
        Me.TSmodeCombo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripLabel2.Text = "Input Mode:"
        '
        'TScomboInput
        '
        Me.TScomboInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TScomboInput.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.TScomboInput.Items.AddRange(New Object() {"Text Document", "Input String"})
        Me.TScomboInput.Name = "TScomboInput"
        Me.TScomboInput.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProgBar
        '
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(112, 22)
        Me.ProgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CHKSaveHistory)
        Me.GroupBox1.Controls.Add(Me.ComboPath)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 76)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Text File Conversion"
        '
        'CHKSaveHistory
        '
        Me.CHKSaveHistory.AutoSize = True
        Me.CHKSaveHistory.Location = New System.Drawing.Point(9, 50)
        Me.CHKSaveHistory.Name = "CHKSaveHistory"
        Me.CHKSaveHistory.Size = New System.Drawing.Size(124, 17)
        Me.CHKSaveHistory.TabIndex = 6
        Me.CHKSaveHistory.Text = "Save location history"
        Me.CHKSaveHistory.UseVisualStyleBackColor = True
        '
        'ComboPath
        '
        Me.ComboPath.FormattingEnabled = True
        Me.ComboPath.Location = New System.Drawing.Point(63, 23)
        Me.ComboPath.Name = "ComboPath"
        Me.ComboPath.Size = New System.Drawing.Size(503, 21)
        Me.ComboPath.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(572, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "File path:"
        '
        'OpenTextFile
        '
        Me.OpenTextFile.Filter = "Text files (*.txt)|*.txt|Binary Dealer Document (*.bde)|*.bde"
        Me.OpenTextFile.InitialDirectory = "%userprofile%"
        Me.OpenTextFile.Title = "Open Text File "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtinput)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(605, 76)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "String Conversion"
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(9, 41)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(590, 20)
        Me.txtinput.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Text to convert:"
        '
        'ContentVerifier
        '
        Me.ContentVerifier.Enabled = True
        Me.ContentVerifier.Interval = 1
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatSave})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 439)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.Stretch = False
        Me.StatusStrip.TabIndex = 8
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'StatSave
        '
        Me.StatSave.Name = "StatSave"
        Me.StatSave.Size = New System.Drawing.Size(0, 17)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(461, 444)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 14)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "© 2008 - 2013 J.C.P Laboratory"
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        Me.PrintDocument.DocumentName = "Document"
        '
        'cmdConvert
        '
        Me.cmdConvert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConvert.Image = Global.ASCII_Binary_Translator.My.Resources.Resources.reload
        Me.cmdConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdConvert.Location = New System.Drawing.Point(545, 221)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(75, 23)
        Me.cmdConvert.TabIndex = 0
        Me.cmdConvert.Text = "Convert"
        Me.cmdConvert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdConvert.UseVisualStyleBackColor = False
        '
        'ASCII_Main
        '
        Me.AcceptButton = Me.cmdConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RTBOutput)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "ASCII_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "J.C.P Laboratory - Binary Dealer (ASCII/Binary Converter)"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RTBOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSmodeCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CHKSaveHistory As System.Windows.Forms.CheckBox
    Friend WithEvents ComboPath As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenTextFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TScomboInput As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtinput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents cmdNewdoc As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentVerifier As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProgBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents BinaryCalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversionModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ASCIIToBinaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BinaryToASCIIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputMethodToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputStringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SwitchToEditorViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAsTextDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents StatSave As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextFileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
End Class
