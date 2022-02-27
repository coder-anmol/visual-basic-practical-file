Imports System

Module Program
    Sub Main(args As String())
        ' Exception handling
        Try
            For i As Integer = 0 To 5 Step 1
                If i = 5 Then
                    ' creating custom exception
                    Throw New Exception("i is greater than 4")
                End If
                Console.WriteLine("Value of i is: " & i)
            Next
        Catch ex As Exception
            ' handling exception
            Console.WriteLine("Exception: {0}", ex.Message)
        Finally
            ' this block will run every time
            Console.WriteLine("Ok! Finally")
        End Try
    End Sub
End Module
