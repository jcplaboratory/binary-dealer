Imports System.IO
Public Class Choose_Conversion_Mode

    Private Sub Choose_Conversion_Mode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboMode.Text = ComboMode.Items.Item(0)
    End Sub

    Private Sub ComboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMode.SelectedIndexChanged
        If ComboMode.Text = "ASCII to Binary" Then
            ASCII_Main.TSmodeCombo.Text = ASCII_Main.TSmodeCombo.Items(1)
        Else
            ASCII_Main.TSmodeCombo.Text = ASCII_Main.TSmodeCombo.Items(0)
        End If
    End Sub

    Private Sub cmdOK_Click(sender As Object, e As EventArgs) Handles cmdOK.Click
        ASCII_Main.OpenTextFile.ShowDialog()
        GroupBox1.Enabled = False
        Dim found As Boolean = False
        For Each path In ASCII_Main.ComboPath.Items
            If path = ASCII_Main.OpenTextFile.FileName Then
                found = True
            End If
        Next
        If ASCII_Main.OpenTextFile.FileName <> Nothing And found = False Then
            ASCII_Main.ComboPath.Items.Add(ASCII_Main.OpenTextFile.FileName)
            ASCII_Main.ComboPath.Text = ASCII_Main.OpenTextFile.FileName
            If ASCII_Main.CHKSaveHistory.Checked = True Then
                Dim sw As New StreamWriter(Application.StartupPath & "\config.ini")
                sw.WriteLine("File_History:" & vbNewLine & "Save History = True")
                For Each Item In ASCII_Main.ComboPath.Items
                    sw.WriteLine(Item)
                Next
                sw.Dispose()
            End If
            ASCII_Main.cmdConvert.PerformClick()
        ElseIf found = True Then
            ASCII_Main.ComboPath.Text = ASCII_Main.OpenTextFile.FileName
            ASCII_Main.cmdConvert.PerformClick()
        End If
        GroupBox1.Enabled = True
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
End Class