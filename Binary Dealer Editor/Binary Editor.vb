Imports System.IO
Imports System.Text.RegularExpressions
Public Class Editor_Main
    Dim FileOpened As String
    Dim AutoReadOnly As Boolean = False
    Dim AutoSwitchConverMode As Boolean = False
    Dim start As Integer = 0
    Dim indexOfSeachText As Integer = 0
    Public Sub SearchRTB(ByVal SearchText As String, Direction As String, Finds As RichTextBoxFinds)
        Dim Pause As Boolean = False
        Dim textEnd As Integer = Pad.TextLength
        Dim index As Integer = 0
        Dim lastindex As Integer = Pad.Text.LastIndexOf(SearchText)
        While index < lastindex And Pause = False
            Pad.Find(SearchText, index, textEnd, Finds)
            Pad.SelectionColor = Color.Blue
            index = Pad.Text.IndexOf(SearchText, index) + 1
        End While
    End Sub
    Sub Editor_load()
        If System.IO.File.Exists(Application.StartupPath & "\config.ini") Then
            'app default built-in settings
            Pad.WordWrap = False
            Pad.DetectUrls = False
            AutoReadOnly = False
            AutoSwitchConverMode = False
            'end of settings
            Dim sr As New StreamReader(Application.StartupPath & "\config.ini")
            While Not sr.EndOfStream
                Dim inLine = sr.ReadLine
                If inLine <> "File_History:" And InStr(inLine, "Save History") = False _
                    And inLine <> "AutoClipboard = True" And inLine <> "AutoConvertMode = True" _
                    And inLine <> "WordWrap = True" And inLine <> "Detect Urs = True" _
                    And inLine <> "AutoReadOnly = True" And inLine <> Nothing _
                    And InStr(inLine, "Default Input Mode = ") = False Then
                ElseIf InStr(inLine, "WordWrap = True") Then
                    Pad.WordWrap = True
                ElseIf InStr(inLine, "Detect Urs = True") Then
                    Pad.DetectUrls = True
                ElseIf InStr(inLine, "AutoReadOnly = True") Then
                    AutoReadOnly = True
                ElseIf InStr(inLine, "AutoConvertMode = True") Then
                    AutoSwitchConverMode = True
                End If
            End While
            sr.Dispose()
        Else
            Pad.WordWrap = True
            Pad.DetectUrls = True
            AutoReadOnly = False
            AutoSwitchConverMode = False
        End If
    End Sub
    Sub Print(ByVal Text As String)
        If Text = Nothing Then
            Exit Sub
        Else
            Dim Document As New TextPrint(Text)
            Document.Font = Pad.Font
            Document.DocumentName = "New DBE Document"
            If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Document.PrinterSettings = PrintDialog.PrinterSettings
                Document.DefaultPageSettings = PageSetupDialog.PageSettings
                Try
                    Document.Print()
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Sub Args_Handler()
        Dim arg As String = Nothing
        For Each Agr In My.Application.CommandLineArgs
            arg = Agr
        Next
        If File.Exists(arg) Then
            Dim sr As New StreamReader(arg)
            FileOpened = arg
            Pad.Text = sr.ReadToEnd
            sr.Dispose()
            Me.Text = Me.Text & " - " & Path.GetFileName(arg)
        Else
            Me.Text = Me.Text & " - " & "New BDE Document"
        End If
    End Sub
    Private Sub Editor_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TSmodeCombo.Text = TSmodeCombo.Items.Item(1)
        Call Args_Handler()
        Call Editor_load()
        Dim file As String = Environment.ExpandEnvironmentVariables("%userprofile%").ToString
        Dim dirCreate = file & "\AppData\Local\J.C.P Laboratory\Binary Dealer\"
        file = file & "\AppData\Local\J.C.P Laboratory\Binary Dealer\User.bde"
        If System.IO.File.Exists(file) Then
            Dim sr As New StreamReader(file)
            If InStr(sr.ReadToEnd, "Registered GNU V2") = False Then
                If License_Dialog.ShowDialog = Windows.Forms.DialogResult.Yes Then
                    sr.Close()
                    Try
                        Dim sw As New StreamWriter(file)
                        sw.Write("")
                        sw.WriteLine("Registered GNU V2")
                        sw.Dispose()
                    Catch ex As Exception
                    End Try
                Else
                    Application.Exit()
                End If
            End If
        Else
            If License_Dialog.ShowDialog = Windows.Forms.DialogResult.Yes Then
                Try
                    IO.Directory.CreateDirectory(dirCreate)
                    Dim sw As New StreamWriter(file)
                    sw.Write("")
                    sw.WriteLine("Registered GNU V2")
                    sw.Dispose()
                Catch ex As Exception
                End Try
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Pad_DragDrop(sender As Object, e As DragEventArgs) Handles Pad.DragDrop

    End Sub

    Private Sub Pad_TextChanged(sender As Object, e As EventArgs) Handles Pad.TextChanged
        lblStat.Text = "Line(s): " & Pad.Lines.Length.ToString
    End Sub

    Private Sub cmdConvert_Click(sender As Object, e As EventArgs) Handles cmdConvert.Click
        If Pad.Text <> Nothing Then
            If TSmodeCombo.Text = "ASCII to Binary" Then
                If IsASCII(Pad.Text) Then
                    Pad.Text = ASCIItoBin(Pad.Text)
                Else
                    TSmodeCombo.Text = TSmodeCombo.Items.Item(0)
                    cmdConvert.PerformClick()
                End If
            Else
                If IsASCII(Pad.Text) = False Then
                    Pad.Text = BinToASCII(Pad.Text)
                Else
                        TSmodeCombo.Text = TSmodeCombo.Items.Item(1)
                        cmdConvert.PerformClick()
                End If
            End If
        End If

    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked = True Then
            Pad.WordWrap = True
        Else
            Pad.WordWrap = False
        End If
    End Sub
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog.ShowDialog()
        Pad.Font = FontDialog.Font
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Print(Pad.Text)
    End Sub

    Private Sub CVerifier_Tick(sender As Object, e As EventArgs) Handles CVerifier.Tick
        If Pad.WordWrap = True Then
            WordWrapToolStripMenuItem.Checked = True
        Else
            WordWrapToolStripMenuItem.Checked = False
        End If
        If Pad.Text <> Nothing Then
            cmdPrint.Enabled = True
            CopyToClipboardToolStripMenuItem.Enabled = True
            SaveToolStripMenuItem.Enabled = True
            SaveToolStripMenuItem1.Enabled = True
            SaveAsToolStripMenuItem.Enabled = True
            SaveAsToolStripMenuItem1.Enabled = True
            PrintToolStripMenuItem.Enabled = True
        Else
            cmdPrint.Enabled = False
            CopyToClipboardToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem1.Enabled = False
            SaveAsToolStripMenuItem.Enabled = False
            SaveAsToolStripMenuItem1.Enabled = False
            PrintToolStripMenuItem.Enabled = False
        End If
        If Pad.ReadOnly = True Then
            cmdEdit.Enabled = True
            EditToolStripMenuItem.Enabled = True
        Else
            cmdEdit.Enabled = False
            EditToolStripMenuItem.Enabled = False
        End If
        If FileOpened <> Nothing Then
            Dim file As String = Path.GetExtension(FileOpened)
            If file = ".txt" Or file = ".bde" Then
                SwitchToEditorViewToolStripMenuItem.Enabled = True
            Else
                SwitchToEditorViewToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If FileOpened <> Nothing Then
            Dim msg = MsgBox("Do you want to overwrite existing file?", vbQuestion + vbYesNo)
            If msg = vbYes Then
                Dim sw As New StreamWriter(FileOpened)
                sw.Write("")
                sw.Write(Pad.Text)
                sw.Dispose()
            End If
        Else
            SaveAsToolStripMenuItem.PerformClick()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveDialog As New SaveFileDialog
        SaveDialog.FileName = Nothing
        SaveDialog.Filter = "Text Document (*.txt)|*.txt|Binary Dealer Document (*.bde)|*.bde|All files|*.*"
        If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sw As New StreamWriter(SaveDialog.FileName)
            sw.Write(Pad.Text)
            sw.Dispose()
        End If

    End Sub

    Private Sub CopyToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToClipboardToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(Pad.Text)
        MsgBox("Content was successfully copied to Clipboard.", vbInformation, "Binary Dealer - Content Copied")

    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        SaveToolStripMenuItem.PerformClick()
    End Sub

    Private Sub TextDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextDocumentToolStripMenuItem.Click
        SaveAsToolStripMenuItem.PerformClick()
    End Sub

    Private Sub CopyToClipboardToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToClipboardToolStripMenuItem1.Click
        CopyToClipboardToolStripMenuItem.PerformClick()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Print(Pad.Text)
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Dim OpenDialog As New OpenFileDialog
        OpenDialog.FileName = Nothing
        OpenDialog.Filter = "Text Document (*.txt)|*.txt|Binary Dealer Document (*.bde)|*.bde|All Files|*.*"
        OpenDialog.Multiselect = False
        If OpenDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileOpened = OpenDialog.FileName
            Dim sr As New StreamReader(OpenDialog.FileName)
            Me.Text = "Binary Dealer ASCII/Binary Editor" & " - " & Path.GetFileName(FileOpened)
            Pad.Text = sr.ReadToEnd
            sr.Dispose()
        End If
    End Sub

    Private Sub ASCIIToBinaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASCIIToBinaryToolStripMenuItem.Click
        TSmodeCombo.Text = TSmodeCombo.Items.Item(1)
    End Sub

    Private Sub BinaryToASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryToASCIIToolStripMenuItem.Click
        TSmodeCombo.Text = TSmodeCombo.Items.Item(0)
    End Sub

    Private Sub TextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextFileToolStripMenuItem.Click
        If FileOpened <> Nothing Then
            Dim msg = MsgBox("Do you want to overwrite existing file?", vbQuestion + vbYesNoCancel)
            If msg = vbYes Then
                Dim sw As New StreamWriter(FileOpened)
                sw.Write("")
                sw.Write(Pad.Text)
                sw.Dispose()
                Pad.Clear()
                Me.Text = "Binary Dealer ASCII/Binary Editor" & " - " & "New BDE Document"
                FileOpened = Nothing
            ElseIf msg = vbNo Then
                Pad.Clear()
                Me.Text = "Binary Dealer ASCII/Binary Editor" & " - " & "New BDE Document"
                FileOpened = Nothing
            End If
        Else
            If Pad.Text <> Nothing Then
                Dim msg = MsgBox("Do you want to save New BDE Document?", vbQuestion + vbYesNoCancel)
                If msg = vbYes Then
                    Dim SaveDialog As New SaveFileDialog
                    SaveDialog.FileName = Nothing
                    SaveDialog.Filter = "Text Document (*.txt)|*.txt|Binary Dealer Document (*.bde)|*.bde|All files|*.*"
                    If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        Dim sw As New StreamWriter(SaveDialog.FileName)
                        sw.Write(Pad.Text)
                        sw.Dispose()
                        Pad.Clear()
                        Me.Text = "Binary Dealer ASCII/Binary Editor" & " - " & "New BDE Document"
                    End If
                ElseIf msg = vbNo Then
                    Pad.Clear()
                    Me.Text = "Binary Dealer ASCII/Binary Editor" & " - " & "New BDE Document"
                End If
            End If
        End If
    End Sub

    Private Sub NewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileToolStripMenuItem.Click
        cmdNewDocument.DropDownItems.Item(0).PerformClick()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        EditToolStripMenuItem.PerformClick()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        If Pad.ReadOnly = True Then
            Dim msg = MsgBox("Are you sure you want to edit this document?", vbQuestion + vbYesNo)
            If msg = vbYes Then
                Pad.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub SwitchToEditorViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchToEditorViewToolStripMenuItem.Click
        Dim WinMn As New ProcessStartInfo
        WinMn.FileName = Application.StartupPath & "\binary_dealer.exe"
        FileOpened = Convert.ToString(FileOpened)
        If File.Exists(FileOpened) Then
            WinMn.Arguments = """" & FileOpened & """"
        End If
        Try
            Process.Start(WinMn)
        Catch ex As Exception
            MsgBox("File " & """" & "binary_dealer.exe" & """" & " was not found. Check the file consistency then try again.", vbCritical)
        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Try
            Dim Main As New ProcessStartInfo
            Main.FileName = Application.StartupPath & "\binary_dealer.exe"
            Main.Arguments = "Settings"
            Process.Start(Main).WaitForExit()
            Call Editor_load()
        Catch ex As Exception
            MsgBox("File " & """" & "binary_dealer.exe" & """" & " was not found. Check the file consistency then try again.", vbCritical)
        End Try
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        Dim Document As New TextPrint(Pad.Text)
        PageSetupDialog.PrinterSettings = PrintDialog.PrinterSettings
        PageSetupDialog.PageSettings = Document.DefaultPageSettings
        PageSetupDialog.ShowDialog()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmFind.Show()
    End Sub

    Private Sub Editor_Main_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus

    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pad.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pad.Cut()
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pad.Paste()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pad.Copy()
    End Sub
End Class
