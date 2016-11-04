<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor_Main))
        Me.lblStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.cmdNewDocument = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdConvert = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TSmodeCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.BinaryToASCIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog = New System.Windows.Forms.FontDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ASCIIToBinaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pad = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToClipboardToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditDocumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FomatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwitchToEditorViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConversionModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTextFile = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.CVerifier = New System.Windows.Forms.Timer(Me.components)
        Me.PageSetupDialog = New System.Windows.Forms.PageSetupDialog()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStat
        '
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(54, 17)
        Me.lblStat.Text = "Line(s): 0"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(165, 6)
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
        Me.AboutToolStripMenuItem.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.bd_editor1
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdNewDocument, Me.ToolStripDropDownButton1, Me.ToolStripSeparator6, Me.cmdEdit, Me.ToolStripSeparator1, Me.cmdConvert, Me.ToolStripSeparator2, Me.cmdPrint, Me.ToolStripSeparator7, Me.ToolStripLabel1, Me.TSmodeCombo})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(742, 25)
        Me.ToolStrip.TabIndex = 11
        Me.ToolStrip.Text = "MainToolstrip"
        '
        'cmdNewDocument
        '
        Me.cmdNewDocument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNewDocument.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextFileToolStripMenuItem})
        Me.cmdNewDocument.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.edit_ico
        Me.cmdNewDocument.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNewDocument.Name = "cmdNewDocument"
        Me.cmdNewDocument.Size = New System.Drawing.Size(29, 22)
        Me.cmdNewDocument.Text = "Create a new file"
        '
        'TextFileToolStripMenuItem
        '
        Me.TextFileToolStripMenuItem.Name = "TextFileToolStripMenuItem"
        Me.TextFileToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.TextFileToolStripMenuItem.Text = "&Text Document"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.CopyToClipboardToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.Save_icon
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'cmdEdit
        '
        Me.cmdEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEdit.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(23, 22)
        Me.cmdEdit.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdConvert
        '
        Me.cmdConvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdConvert.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.convert
        Me.cmdConvert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(23, 22)
        Me.cmdConvert.Text = "Convert"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmdPrint
        '
        Me.cmdPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdPrint.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.Print_Ico
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(23, 22)
        Me.cmdPrint.Text = "Print"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
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
        'BinaryToASCIIToolStripMenuItem
        '
        Me.BinaryToASCIIToolStripMenuItem.Name = "BinaryToASCIIToolStripMenuItem"
        Me.BinaryToASCIIToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BinaryToASCIIToolStripMenuItem.Text = "Binary to ASCII"
        '
        'FontDialog
        '
        Me.FontDialog.AllowScriptChange = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 485)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(742, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ASCIIToBinaryToolStripMenuItem
        '
        Me.ASCIIToBinaryToolStripMenuItem.Name = "ASCIIToBinaryToolStripMenuItem"
        Me.ASCIIToBinaryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ASCIIToBinaryToolStripMenuItem.Text = "ASCII to Binary"
        '
        'Pad
        '
        Me.Pad.AcceptsTab = True
        Me.Pad.AccessibleRole = System.Windows.Forms.AccessibleRole.Document
        Me.Pad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pad.AutoWordSelection = True
        Me.Pad.EnableAutoDragDrop = True
        Me.Pad.HideSelection = False
        Me.Pad.Location = New System.Drawing.Point(0, 52)
        Me.Pad.Name = "Pad"
        Me.Pad.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.Pad.Size = New System.Drawing.Size(742, 430)
        Me.Pad.TabIndex = 10
        Me.Pad.Text = ""
        Me.Pad.WordWrap = False
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem1, Me.FomatToolStripMenuItem, Me.WindowToolStripMenuItem, Me.OptionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(742, 24)
        Me.MenuStrip.TabIndex = 9
        Me.MenuStrip.Text = "MainStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileToolStripMenuItem, Me.NewFileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveToolStripMenuItem1, Me.SaveAsToolStripMenuItem1, Me.ToolStripSeparator4, Me.PageSetupToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.o
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.OpenFileToolStripMenuItem.Text = "&Open File"
        '
        'NewFileToolStripMenuItem
        '
        Me.NewFileToolStripMenuItem.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.edit_ico
        Me.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem"
        Me.NewFileToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.NewFileToolStripMenuItem.Text = "&New File"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(130, 6)
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.Save_icon
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.SaveToolStripMenuItem1.Text = "&Save"
        '
        'SaveAsToolStripMenuItem1
        '
        Me.SaveAsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextDocumentToolStripMenuItem, Me.CopyToClipboardToolStripMenuItem1})
        Me.SaveAsToolStripMenuItem1.Name = "SaveAsToolStripMenuItem1"
        Me.SaveAsToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.SaveAsToolStripMenuItem1.Text = "Save &As"
        '
        'TextDocumentToolStripMenuItem
        '
        Me.TextDocumentToolStripMenuItem.Name = "TextDocumentToolStripMenuItem"
        Me.TextDocumentToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TextDocumentToolStripMenuItem.Text = "Text Document"
        '
        'CopyToClipboardToolStripMenuItem1
        '
        Me.CopyToClipboardToolStripMenuItem1.Name = "CopyToClipboardToolStripMenuItem1"
        Me.CopyToClipboardToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.CopyToClipboardToolStripMenuItem1.Text = "&Copy To Clipboard"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(130, 6)
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PageSetupToolStripMenuItem.Text = "P&age Setup"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.Print_Ico
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditDocumentToolStripMenuItem})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem1.Text = "&Edit"
        '
        'EditDocumentToolStripMenuItem
        '
        Me.EditDocumentToolStripMenuItem.Name = "EditDocumentToolStripMenuItem"
        Me.EditDocumentToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.EditDocumentToolStripMenuItem.Text = "Edit Document"
        '
        'FomatToolStripMenuItem
        '
        Me.FomatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordWrapToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.FomatToolStripMenuItem.Name = "FomatToolStripMenuItem"
        Me.FomatToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FomatToolStripMenuItem.Text = "&Fomat"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.CheckOnClick = True
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
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
        Me.SwitchToEditorViewToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.SwitchToEditorViewToolStripMenuItem.Text = "&Open With: BD Converter"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConversionModeToolStripMenuItem, Me.ToolStripSeparator5, Me.SettingsToolStripMenuItem})
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
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.Binary_Dealer_Editor.My.Resources.Resources.AdminTools
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'OpenTextFile
        '
        Me.OpenTextFile.Filter = "Text files (*.txt)|*.txt"
        Me.OpenTextFile.InitialDirectory = "%userprofile%"
        Me.OpenTextFile.Title = "Open Text File "
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'CVerifier
        '
        Me.CVerifier.Enabled = True
        Me.CVerifier.Interval = 1
        '
        'Editor_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 507)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Pad)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(376, 380)
        Me.Name = "Editor_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Binary Dealer ASCII/Binary Editor"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdNewDocument As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents TextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdConvert As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TSmodeCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents BinaryToASCIIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ASCIIToBinaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FomatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordWrapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SwitchToEditorViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConversionModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Pad As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenTextFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CVerifier As System.Windows.Forms.Timer
    Friend WithEvents TextDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToClipboardToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageSetupDialog As System.Windows.Forms.PageSetupDialog
    Friend WithEvents EditDocumentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
