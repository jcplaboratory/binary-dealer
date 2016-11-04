Public Class AboutBox
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("mailto://support@jcplaboratory.org")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.jcplaboratory.org")
    End Sub

    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class