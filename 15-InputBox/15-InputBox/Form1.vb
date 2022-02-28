Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim input As String = Nothing
        input = InputBox("Enter your name: ")

        If input <> "" Then
            MsgBox("Hello! " & input)
        Else
            MsgBox("No input given")
        End If

        Me.Close()
    End Sub
End Class
