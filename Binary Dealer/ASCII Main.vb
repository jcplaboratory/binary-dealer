Imports System.IO
Imports System.Drawing.Printing
Public Class ASCII_Main
    Dim OpenFile As String = Nothing
    Dim AutoCopyClipboard As Boolean = False
    Dim AutoReadOnly As Boolean = False
    Dim AutoSwitchConverMode As Boolean = False
    Dim checkPrint As Integer
    Dim InInitializisation As Boolean = False
    Sub SaveFileHistory()
        If CHKSaveHistory.Checked = True Then
            Dim file As String
            Dim temp As String = Nothing
            file = Application.StartupPath & "\config.ini"
            If System.IO.File.Exists(file) Then
                Dim sr As New StreamReader(file)
                While Not sr.EndOfStream
                    Dim inline = sr.ReadLine
                    If InStr(inline, "File_History:") = False And InStr(inline, "Save History") = False Then
                        If System.IO.File.Exists(inline) = False Then
                            If temp = Nothing Then
                                temp = inline
                            Else
                                temp = temp & vbNewLine & inline
                            End If
                        End If
                    End If
                End While
                sr.Close()
                Kill(file)
                Dim sw As New StreamWriter(file)
                sw.WriteLine(temp)
                sw.WriteLine("File_History:" & vbNewLine & "Save History = True")
                For Each Item In ComboPath.Items
                    sw.WriteLine(Item)
                Next
                sw.Dispose()
            Else
                Dim sw As New StreamWriter(Application.StartupPath & "\config.ini")
                sw.WriteLine("File_History:" & vbNewLine & "Save History = True")
                For Each Item In ComboPath.Items
                    sw.WriteLine(Item)
                Next
                sw.Dispose()
            End If
        End If
    End Sub
    Sub Print(ByVal Text As String)
        If Text = Nothing Then
            Exit Sub
        Else
            Dim Document As New TextPrint(Text)
            Document.Font = RTBOutput.Font
            Document.DocumentName = "New DBE Document"
            If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                Document.PrinterSettings = PrintDialog.PrinterSettings
                Try
                    Document.Print()
                Catch ex As Exception
                End Try
            End If
            End If
    End Sub
    Sub Args_Handler()
        'the command-line/argument file handler codes..
        Dim ParseCommandLineArgs As String = Nothing
        For Each Args In My.Application.CommandLineArgs
            ParseCommandLineArgs = Args
        Next
        If File.Exists(ParseCommandLineArgs) Then
            Dim ArgFile As String = ParseCommandLineArgs
            If Path.GetExtension(ArgFile).ToLower = ".txt" Or Path.GetExtension(ParseCommandLineArgs).ToLower = ".bde" Then
                Dim found As Boolean = False
                For Each item As String In ComboPath.Items
                    If ArgFile = item Then
                        found = True
                    End If
                Next
                If found = False Then
                    ComboPath.Items.Add(ArgFile)
                    ComboPath.Text = ArgFile
                    If CHKSaveHistory.Checked = True Then
                        Dim file As String
                        Dim temp As String = Nothing
                        file = Application.StartupPath & "\config.ini"
                        If System.IO.File.Exists(file) Then
                            Dim sr As New StreamReader(file)
                            While Not sr.EndOfStream
                                Dim inline = sr.ReadLine
                                If InStr(inline, "File_History:") = False And InStr(inline, "Save History") = False Then
                                    If System.IO.File.Exists(inline) = False Then
                                        If temp = Nothing Then
                                            temp = inline
                                        Else
                                            temp = temp & vbNewLine & inline
                                        End If
                                    End If
                                End If
                            End While
                            sr.Close()
                            Kill(file)
                            Dim sw As New StreamWriter(file)
                            sw.WriteLine(temp)
                            sw.WriteLine("File_History:" & vbNewLine & "Save History = True")
                            For Each Item In ComboPath.Items
                                sw.WriteLine(Item)
                            Next
                            sw.Dispose()
                        Else
                            Dim sw As New StreamWriter(Application.StartupPath & "\config.ini")
                            sw.WriteLine("File_History:" & vbNewLine & "Save History = True")
                            For Each Item In ComboPath.Items
                                sw.WriteLine(Item)
                            Next
                            sw.Dispose()
                        End If
                    End If
                End If
                ComboPath.Text = ArgFile
                cmdConvert.PerformClick()
                If ProgBar.Value = 100 Then
                    MsgBox("Conversion successful.", vbInformation)
                End If
            Else
                Dim msg = MsgBox("Unrecognized file format! Would you like to open this file with BD Editor?", vbExclamation + vbYesNoCancel, "Binary Dealer - File not recognized")
                If msg = vbYes Then
                    Dim EdtApp As New ProcessStartInfo
                    EdtApp.FileName = Application.StartupPath & "\bd_editor.exe"
                    EdtApp.Arguments = """" & ParseCommandLineArgs & """"
                    Try
                        Process.Start(EdtApp)
                    Catch ex As Exception
                        MsgBox("File " & """" & "bd_editor" & """" & " was not found. Please check the file for consistency.", vbCritical)
                    End Try
                    Me.Close()
                    Application.Exit()
                ElseIf msg = vbNo Or msg = vbCancel Then
                    Me.Close()
                    Application.Exit()
                End If
            End If
        ElseIf ParseCommandLineArgs = "Settings" Then
            Settings.TabControl1.SelectTab(1)
            Settings.AutoClipboard.Enabled = False
            Settings.DefInput.Enabled = False
            Settings.RDOnly.Enabled = False
            Settings.AutoConvertMode.Checked = True
            Settings.AutoConvertMode.Enabled = False
            If Settings.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.Close()
                Application.Exit()
            End If
        End If
    End Sub
    Sub ASCII_Form_Load()
        InInitializisation = True
        TSmodeCombo.Text = TSmodeCombo.Items.Item(1)
        If System.IO.File.Exists(Application.StartupPath & "\config.ini") Then
            'app default built-in settings
            RTBOutput.WordWrap = False
            TScomboInput.Text = TScomboInput.Items.Item(0)
            RTBOutput.DetectUrls = False
            AutoCopyClipboard = False
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
                    If File.Exists(inLine) Then
                        ComboPath.Items.Add(inLine)
                    End If
                ElseIf InStr(inLine, "Save History", CompareMethod.Text) Then
                    If InStr(inLine, "True") Then
                        CHKSaveHistory.Checked = True
                    End If
                ElseIf InStr(inLine, "Default Input Mode = 0") Then
                    TScomboInput.Text = TScomboInput.Items.Item(0)
                ElseIf InStr(inLine, "Default Input Mode = 1") Then
                    TScomboInput.Text = TScomboInput.Items.Item(1)
                ElseIf InStr(inLine, "WordWrap = True") Then
                    RTBOutput.WordWrap = True
                ElseIf InStr(inLine, "Detect Urs = True") Then
                    RTBOutput.DetectUrls = True
                ElseIf InStr(inLine, "AutoClipboard = True") Then
                    AutoCopyClipboard = True
                ElseIf InStr(inLine, "AutoReadOnly = True") Then
                    AutoReadOnly = True
                ElseIf InStr(inLine, "AutoConvertMode = True") Then
                    AutoSwitchConverMode = True
                End If
            End While
            sr.Dispose()
        Else
            Call Settings.RestoreDefaultSettings()
            TScomboInput.Text = TScomboInput.Items.Item(0)
            RTBOutput.WordWrap = True
            CHKSaveHistory.Checked = True
            RTBOutput.DetectUrls = True
            AutoCopyClipboard = False
            AutoReadOnly = False
            AutoSwitchConverMode = False
        End If
        InInitializisation = False
    End Sub
    Private Sub cmdConvert_Click(sender As Object, e As EventArgs) Handles cmdConvert.Click
        'clear the status bar contents
        StatSave.Text = Nothing
        'end
        Select Case TScomboInput.Text
            Case "Input String"
                If txtinput.Text <> Nothing Then
                    If TSmodeCombo.Text = "ASCII to Binary" Then
                        If IsASCII(txtinput.Text) Then
                            RTBOutput.Text = Nothing
                            RTBOutput.Text = ASCIItoBin(txtinput.Text)
                            If AutoCopyClipboard = True Then
                                CopyToClipboardToolStripMenuItem.PerformClick()
                            End If
                        Else
                            Dim msg
                            If AutoSwitchConverMode = True Then
                                msg = vbYes
                            Else
                                msg = MsgBox("The text string contains binary values. Would you like to switch from current conversion mode to Binary to ASCII?", vbInformation + vbYesNo, "Binary Dealer - Improper conversion mode")
                            End If
                            If msg = vbYes Then
                                TSmodeCombo.Text = TSmodeCombo.Items.Item(0)
                                cmdConvert.PerformClick()
                            Else
                                RTBOutput.Text = Nothing
                                Obsolete_ASCIItoBinary(txtinput.Text, Len(txtinput.Text))
                                If AutoCopyClipboard = True Then
                                    CopyToClipboardToolStripMenuItem.PerformClick()
                                End If
                            End If
                        End If
                    Else
                        If IsASCII(txtinput.Text) = False Then
                            RTBOutput.Text = Nothing
                            RTBOutput.Text = BinToASCII(txtinput.Text)
                            If AutoCopyClipboard = True Then
                                CopyToClipboardToolStripMenuItem.PerformClick()
                            End If
                        Else
                            Dim msg
                            If AutoSwitchConverMode = True Then
                                msg = vbYes
                            Else
                                msg = MsgBox("The text string contains ASCII Characters. Would you like to switch from current conversion mode to ASCII to Binary?", vbInformation + vbYesNo, "Binary Dealer - Improper conversion mode")
                            End If
                            If msg = vbYes Then
                                TSmodeCombo.Text = TSmodeCombo.Items.Item(1)
                                cmdConvert.PerformClick()
                            Else
                                RTBOutput.Text = Nothing
                                BinToASCII(txtinput.Text)
                                If AutoCopyClipboard = True Then
                                    CopyToClipboardToolStripMenuItem.PerformClick()
                                End If
                            End If
                        End If
                    End If
                End If
            Case "Text Document"
                If ComboPath.Text <> Nothing Then
                    If System.IO.Path.GetExtension(ComboPath.Text).ToLower = ".txt" Or Path.GetExtension(ComboPath.Text).ToLower = ".bde" Then
                        If TSmodeCombo.Text = "ASCII to Binary" Then

                            If System.IO.File.Exists(ComboPath.Text) Then
                                Dim sr As New StreamReader(ComboPath.Text)
                                Dim input As String = sr.ReadToEnd
                                sr.Dispose()
                                If IsASCII(input) Then
                                    OpenFile = ComboPath.Text
                                    RTBOutput.Text = Nothing
                                    RTBOutput.Text = ASCIItoBin(input)
                                    If AutoCopyClipboard = True Then
                                        CopyToClipboardToolStripMenuItem.PerformClick()
                                    End If
                                Else
                                    Dim msg
                                    If AutoSwitchConverMode = True Then
                                        msg = vbYes
                                    Else
                                        msg = MsgBox("The text document contains binary values. Would you like to switch from current conversion mode to Binary to ASCII?", vbInformation + vbYesNo, "Binary Dealer - Improper conversion mode")
                                    End If
                                    If msg = vbYes Then
                                        TSmodeCombo.Text = TSmodeCombo.Items.Item(0)
                                        cmdConvert.PerformClick()
                                    Else
                                        OpenFile = ComboPath.Text
                                        RTBOutput.Text = Nothing
                                        Obsolete_ASCIItoBinary(input, Len(input))
                                        If AutoCopyClipboard = True Then
                                            CopyToClipboardToolStripMenuItem.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                                MsgBox("Invalid file path. Whether the file does not exist or the path is in an Invalid format.", vbCritical, "Binary Dealer - Incorrect Path")
                            End If
                        Else
                            If System.IO.File.Exists(ComboPath.Text) Then
                                Dim sr As New StreamReader(ComboPath.Text)
                                Dim input As String = sr.ReadToEnd
                                sr.Dispose()
                                If IsASCII(input) = False Then
                                    OpenFile = ComboPath.Text
                                    RTBOutput.Text = Nothing
                                    RTBOutput.Text = BinToASCII(input)
                                    If AutoCopyClipboard = True Then
                                        CopyToClipboardToolStripMenuItem.PerformClick()
                                    End If
                                Else
                                    Dim msg
                                    If AutoSwitchConverMode = True Then
                                        msg = vbYes
                                    Else
                                        msg = MsgBox("The text document contains ASCII Characters. Would you like to switch from current conversion mode to ASCII to Binary?", vbInformation + vbYesNo, "Binary Dealer - Improper conversion mode")
                                    End If
                                    If msg = vbYes Then
                                        TSmodeCombo.Text = TSmodeCombo.Items.Item(1)
                                        cmdConvert.PerformClick()
                                    Else
                                        OpenFile = ComboPath.Text
                                        RTBOutput.Text = Nothing
                                        RTBOutput.Text = BinToASCII(input)
                                        If AutoCopyClipboard = True Then
                                            CopyToClipboardToolStripMenuItem.PerformClick()
                                        End If
                                    End If
                                End If
                            Else
                                MsgBox("No text file has been specified.", vbCritical, "Binary Dealer - Missing Input File")
                            End If
                        End If
                    Else
                        MsgBox("Invalid file format. Please check the file and try again.", vbCritical, "Binary Dealer - Invalid file")
                    End If
                Else
                    MsgBox("No text file has been specified.", vbCritical, "Binary Dealer - Missing Input File")
                End If
        End Select
    End Sub

    Private Sub ASCII_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
    End Sub

    Private Sub ASCII_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ASCII_Form_Load()
        Call Args_Handler()
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
        'Dim LicKey As Microsoft.Win32.RegistryKey
        ' Dim LicReg = Nothing
        ' Try
        'LicKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\J.C.P Laboratory\Binary Dealer Editor")
        'LicReg = LicKey.GetValue("First RUN")
        'LicKey.Close()
        'Catch ex As Exception
        'End Try
        'If LicReg <> 1 Then
        'If License_Dialog.ShowDialog = Windows.Forms.DialogResult.Yes Then
        ' Dim SaveKey As Microsoft.Win32.RegistryKey
        ' SaveKey = My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\J.C.P Laboratory\Binary Dealer Editor")
        ' SaveKey.SetValue("First RUN", 1)
        ' Else
        'Application.Exit()
        ' End If
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenTextFile.ShowDialog()
        Dim found As Boolean = False
        For Each path In ComboPath.Items
            If path = OpenTextFile.FileName Then
                found = True
            End If
        Next
        If OpenTextFile.FileName <> Nothing And found = False Then
            ComboPath.Items.Add(OpenTextFile.FileName)
            ComboPath.Text = OpenTextFile.FileName
            Call SaveFileHistory()
        ElseIf found = True Then
            ComboPath.Text = OpenTextFile.FileName
        End If

    End Sub

    Private Sub CHKSaveHistory_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSaveHistory.CheckedChanged
        If CHKSaveHistory.Checked = False Then
            Dim file As String
            Dim temp As String = Nothing
            file = Application.StartupPath & "\config.ini"
            If System.IO.File.Exists(file) Then
                Dim sr As New StreamReader(file)
                While Not sr.EndOfStream
                    Dim inline = sr.ReadLine
                    If System.IO.File.Exists(inline) = False Then
                        If InStr(inline, "File_History:") = False And InStr(inline, "Save History") = False Then
                            temp = temp & vbNewLine & inline
                        End If
                    End If
                End While
                sr.Close()
                ComboPath.Items.Clear()
                Kill(file)
                Dim sw As New StreamWriter(file)
                sw.Write(temp)
                sw.Dispose()
            End If
        Else
            If InInitializisation = False Then
                Call SaveFileHistory()
            End If
        End If
    End Sub

    Private Sub TScomboInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TScomboInput.SelectedIndexChanged
        If TScomboInput.Text = "Text Document" Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = False
            SaveToolStripMenuItem.Enabled = True
        ElseIf TScomboInput.Text = "Input String" Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = True
            SaveToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim msg = MsgBox("Do you want to overwrite existing file?", vbQuestion + vbYesNo, "Binary Dealer - Confirm Action")
        If msg = vbYes Then
            Try
                Dim save As New StreamWriter(OpenFile)
                save.Write(RTBOutput.Text)
                save.Dispose()
                StatSave.Text = "Saved: " & Path.GetFileName(OpenFile)
            Catch ex As Exception
                MsgBox("Failed to save the file. May be the file is Read-Only or you don't have sufficient privileges to edit this file.", vbCritical, "Binary Dealer - Could not save file")
            End Try
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveDialog As New SaveFileDialog
        SaveDialog.Title = "Save conversion to file"
        SaveDialog.Filter = "Text File (*.txt)|*.txt|All file (*.*)|*.*"
        SaveDialog.FileName = ""
        SaveDialog.ShowDialog()
        Dim location As String = SaveDialog.FileName
        If File.Exists(location) Then
            Kill(location)
        End If
        If location <> Nothing Then
            Dim sw As New StreamWriter(location)
            sw.Write(RTBOutput.Text)
            sw.Dispose()
        End If
    End Sub

    Private Sub ContentVerifier_Tick(sender As Object, e As EventArgs) Handles ContentVerifier.Tick
        If RTBOutput.Text <> "" Then
            If TScomboInput.Text = "Text Document" Then
                If OpenFile <> Nothing Then
                    SaveToolStripMenuItem.Enabled = True
                    SaveToolStripMenuItem1.Enabled = True
                    PrintToolStripMenuItem.Enabled = True
                End If
            Else
                PrintToolStripMenuItem.Enabled = False
                SaveToolStripMenuItem.Enabled = False
                SaveToolStripMenuItem1.Enabled = False
            End If
            PrintToolStripMenuItem.Enabled = True
            SaveAsToolStripMenuItem.Enabled = True
            SaveAsToolStripMenuItem1.Enabled = True
            CopyToClipboardToolStripMenuItem.Enabled = True
        Else
            PrintToolStripMenuItem.Enabled = False
            SaveAsToolStripMenuItem1.Enabled = False
            SaveToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem1.Enabled = False
            SaveAsToolStripMenuItem.Enabled = False
            CopyToClipboardToolStripMenuItem.Enabled = False
        End If

        If TSmodeCombo.Text = "ASCII to Binary" Then
            Label4.Text = "Enter text to convert:"
        Else
            Label4.Text = "Enter binary value(s) to convert:"
        End If

        If AutoReadOnly = True Then
            RTBOutput.BackColor = Color.White
            If IsASCII(RTBOutput.Text) = False Then
                RTBOutput.ReadOnly = True
            Else
                RTBOutput.ReadOnly = False
            End If
        Else
            RTBOutput.ReadOnly = False
            RTBOutput.BackColor = Color.White
        End If
        If OpenFile <> Nothing Then
            SwitchToEditorViewToolStripMenuItem.Enabled = True
        Else
            SwitchToEditorViewToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub CopyToClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToClipboardToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(RTBOutput.Text)
        MsgBox("Content was successfully copied to Clipboard.", vbInformation, "Binary Dealer - Content Copied")
    End Sub

    Private Sub TextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextFileToolStripMenuItem.Click
        Dim edtor As New Process
        edtor.StartInfo.FileName = "bd_editor.exe"
        Try
            edtor.Start()
        Catch ex As Exception
            MsgBox("File " & """" & "bd_editor.exe" & " was not found. Please check the file for consistency", vbCritical)
        End Try
    End Sub
    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        Choose_Conversion_Mode.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub ASCIIToBinaryToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ASCIIToBinaryToolStripMenuItem.Click
        TSmodeCombo.Text = TSmodeCombo.Items.Item(1)
    End Sub

    Private Sub BinaryToASCIIToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BinaryToASCIIToolStripMenuItem.Click
        TSmodeCombo.Text = TSmodeCombo.Items.Item(0)
    End Sub

    Private Sub TextDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextDocumentToolStripMenuItem.Click
        TScomboInput.Text = TScomboInput.Items.Item(0)
    End Sub

    Private Sub InputStringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputStringToolStripMenuItem.Click
        TScomboInput.Text = TScomboInput.Items.Item(1)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Print(RTBOutput.Text)
    End Sub

    Private Sub SwitchToEditorViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchToEditorViewToolStripMenuItem.Click
        Dim edtApp As New ProcessStartInfo
        edtApp.FileName = Application.StartupPath & "\bd_editor.exe"
        edtApp.Arguments = """" & OpenFile & """"
        Try
            Process.Start(edtApp)
        Catch ex As Exception
            MsgBox("File " & """" & "bd_editor.exe" & " was not found. Please check the file for consistency", vbCritical)
        End Try
    End Sub

    Private Sub BinaryCalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryCalculatorToolStripMenuItem.Click
        Binary_Calculator.Show()
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        SaveToolStripMenuItem.PerformClick()
    End Sub

    Private Sub ExportAsTextDocumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAsTextDocumentToolStripMenuItem.Click
        SaveAsToolStripMenuItem.PerformClick()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub SaveAsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem1.Click

    End Sub

    Private Sub PrintSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSetupToolStripMenuItem.Click
        Dim Document As New TextPrint(RTBOutput.Text)
        PageSetupDialog.PrinterSettings = PrintDialog.PrinterSettings
        PageSetupDialog.PageSettings = Document.DefaultPageSettings
        PageSetupDialog.ShowDialog()
    End Sub

    Private Sub TextFileToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TextFileToolStripMenuItem1.Click
        cmdNewdoc.DropDownItems.Item(0).PerformClick()
    End Sub
End Class