Imports Binary_Dealer_Editor.Editor_Main
Public Class frmFind

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim findrtb As RichTextBoxFinds
        If chkMatchCase.Checked = True Then
            findrtb = RichTextBoxFinds.MatchCase
        End If
        Editor_Main.SearchRTB(txtFind.Text, "Up", findrtb)
    End Sub

    Private Sub frmFind_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class