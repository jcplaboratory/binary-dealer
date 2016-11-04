Imports System.IO
Module Notepad_Replacer
    Dim arg As String = Nothing
    Function arg_handler() As String
        For Each item As String In My.Application.CommandLineArgs
            arg = item
        Next
        Return arg
    End Function
    Sub Main()
        Dim filePath As String = arg_handler()
        Dim main As New ProcessStartInfo
        Dim locPg As String = Environment.ExpandEnvironmentVariables("%programfiles%") & "\Binary Dealer\bd_editor.exe"
        main.FileName = locPg
        main.Arguments = """" & filePath & """"
        Try
            Process.Start(main)
        Catch ex As Exception

        End Try
        Application.Exit()
    End Sub
End Module
