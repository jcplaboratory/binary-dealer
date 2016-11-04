Public Class License_Dialog

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Editor_Main.Close()
        Application.Exit()
    End Sub
End Class