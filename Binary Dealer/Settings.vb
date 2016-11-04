Imports System.IO
Public Class Settings

    Private Sub FTBrowser_Click(sender As Object, e As EventArgs) Handles FTBrowser.Click
        FontDialog.ShowDialog()
        txtFont.Text = FontDialog.Font.ToString
        ASCII_Main.RTBOutput.Font = FontDialog.Font
    End Sub
    Function RestoreDefaultSettings() As String
        Try
            Dim settings As String = "Default Input Mode = 0" & vbNewLine & "WordWrap = True" & vbNewLine & "Detect Urs = True"
            Dim config As String = Application.StartupPath & "\config.ini"
            Dim temp As String = "File_History:" & vbNewLine & "Save History = True"
            If File.Exists(config) Then
                Dim sr As New StreamReader(config)
                While Not sr.EndOfStream
                    Dim inline = sr.ReadLine
                    If File.Exists(inline) Then
                        temp = temp & vbNewLine & inline
                    End If
                End While
                sr.Close()
                Kill(config)
                Dim sw As New StreamWriter(config)
                sw.WriteLine(settings)
                sw.WriteLine(temp)
                sw.Dispose()
            Else
                Dim sw As New StreamWriter(config)
                sw.WriteLine("Save History = True")
                sw.Write(settings)
                sw.Dispose()
            End If
        Catch ex As Exception
            Return ex.ToString
        End Try
        Return True
    End Function
    Sub Initialization()
        txtFont.Text = ASCII_Main.RTBOutput.Font.ToString
        Dim Confile As String = Application.StartupPath & "\config.ini"
        If File.Exists(Confile) Then
            AutoClipboard.Checked = False
            AutoConvertMode.Checked = False
            Wwrap.Checked = False
            DetectUrs.Checked = False
            RDOnly.Checked = False
            Dim sr As New StreamReader(Confile)
            Dim file As String = sr.ReadToEnd
            sr.Dispose()
            If InStr(file, "AutoClipboard = True") Then
                AutoClipboard.Checked = True
            End If
            If InStr(file, "AutoConvertMode = True") Then
                AutoConvertMode.Checked = True
            End If
            If InStr(file, "WordWrap = True") Then
                Wwrap.Checked = True
            End If
            If InStr(file, "Detect Urs = True") Then
                DetectUrs.Checked = True
            End If
            If InStr(file, "AutoReadOnly = True") Then
                RDOnly.Checked = True
            End If
            If InStr(file, "Default Input Mode = ") Then
                If InStr(file, "Default Input Mode = 0") Then
                    DefInput.Text = DefInput.Items.Item(0)
                ElseIf InStr(file, "Default Input Mode = 1") Then
                    DefInput.Text = DefInput.Items.Item(1)
                ElseIf InStr(file, "Default Input Mode = 2") Then
                    DefInput.Text = DefInput.Items.Item(2)
                End If
            End If
        Else
            Wwrap.Checked = True
            DetectUrs.Checked = True
            DefInput.Text = DefInput.Items.Item(0)
        End If
    End Sub
    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        Dim file As String
        Dim temp As String = Nothing
        file = Application.StartupPath & "\config.ini"
        If System.IO.File.Exists(file) Then
            Dim sr As New StreamReader(file)
            While Not sr.EndOfStream
                Dim inline = sr.ReadLine
                If InStr(inline, "File_History:") Or InStr(inline, "Save History") Then
                    If temp = Nothing Then
                        temp = inline
                    Else
                        temp = temp & vbNewLine & inline
                    End If
                ElseIf System.IO.File.Exists(inline) Then
                    If temp = Nothing Then
                        temp = inline
                    Else
                        temp = temp & vbNewLine & inline
                    End If
                End If
            End While
            sr.Close()
            Kill(file)
        End If
        Dim sw As New StreamWriter(file)
        Dim Setting(5) As String
        Setting.Initialize()
        If AutoClipboard.Checked = True Then
            Setting(0) = "AutoClipboard = True"
        End If
        If AutoConvertMode.Checked = True Then
            Setting(1) = "AutoConvertMode = True"
        End If
        Setting(2) = "Default Input Mode = " & DefInput.SelectedIndex
        If Wwrap.Checked = True Then
            Setting(3) = "WordWrap = True"
        End If
        If DetectUrs.Checked = True Then
            Setting(4) = "Detect Urs = True"
        End If
        If RDOnly.Checked = True Then
            Setting(5) = "AutoReadOnly = True"
        End If
        For Settings = 0 To 5
            sw.WriteLine(Setting(Settings))
        Next
        sw.WriteLine(temp)
        sw.Dispose()
        Call Initialization()
    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        DialogResult = Windows.Forms.DialogResult.OK
        ASCII_Main.ComboPath.Items.Clear()
        Call ASCII_Main.ASCII_Form_Load()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Initialization()
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        cmdApply.PerformClick()
        Me.Close()
    End Sub

    Private Sub Terminator_Tick(sender As Object, e As EventArgs) Handles Terminator.Tick
        If ASCII_Main.Visible = False Then
            Me.Close()
        End If
    End Sub

    Private Sub cmdRestore_Click(sender As Object, e As EventArgs) Handles cmdRestore.Click
        Dim msg = MsgBox("Are you sure to restore the application's default settings?", vbQuestion + vbYesNo)
        If msg = vbYes Then
            If RestoreDefaultSettings() = True Then
                MsgBox("Settings was successfully restored.", vbInformation)
            Else
                MsgBox("Could not restore default settings." & vbNewLine & vbNewLine & RestoreDefaultSettings())
            End If
            Call Initialization()
        End If
    End Sub
End Class