Public Class Binary_Calculator

    Private Sub Binary_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If txt1stInput.Text.Length = 8 And txt2ndInput.Text.Length = 8 Then
            Dim input As Integer = Bin_To_Dec(txt1stInput.Text)
            Dim input2 As Integer = Bin_To_Dec(txt2ndInput.Text)
            Dim res As Integer = input + input2
            Dim out As String = Dec_To_Bin(res)
            txtOutput.Text = out
        Else
            MsgBox("Invalid binary values. Each number must be represented by a group of eight bits (1 Byte).", vbExclamation)
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If txt1stInput.Text.Length = 8 And txt2ndInput.Text.Length = 8 Then
            Dim input As Integer = Bin_To_Dec(txt1stInput.Text)
            Dim input2 As Integer = Bin_To_Dec(txt2ndInput.Text)
            If Not input < input2 Then
                Dim res As Integer = input - input2
                Dim out As String = Dec_To_Bin(res)
                txtOutput.Text = out
            Else
                MsgBox("First input cannot be number less than second input.", vbCritical)
            End If
        Else
            MsgBox("Invalid binary values. Each number must be represented by a group of eight bits (1 Byte).", vbExclamation)
        End If
    End Sub

    Private Sub btnMul_Click(sender As Object, e As EventArgs) Handles btnMul.Click
        If txt1stInput.Text.Length = 8 And txt2ndInput.Text.Length = 8 Then
            Dim input As Integer = Bin_To_Dec(txt1stInput.Text)
            Dim input2 As Integer = Bin_To_Dec(txt2ndInput.Text)
            Dim res As Integer = input * input2
            Dim out As String = Dec_To_Bin(res)
            txtOutput.Text = out
        Else
            MsgBox("Invalid binary values. Each number must be represented by a group of eight bits (1 Byte).", vbExclamation)

        End If
    End Sub

    Private Sub btnDIV_Click(sender As Object, e As EventArgs) Handles btnDIV.Click
        If txt1stInput.Text.Length = 8 And txt2ndInput.Text.Length = 8 Then
            Dim input As Integer = Bin_To_Dec(txt1stInput.Text)
            Dim input2 As Integer = Bin_To_Dec(txt2ndInput.Text)
            Dim res As Integer = input / input2
            Dim out As String = Dec_To_Bin(res)
            txtOutput.Text = out
        Else
            MsgBox("Invalid binary values. Each number must be represented by a group of eight bits (1 Byte).", vbExclamation)

        End If
    End Sub
End Class