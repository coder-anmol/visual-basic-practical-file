Imports System

Module Program
    Sub Main(args As String())
        ' Loops : Exit and continue statement

        ' While loop
        Dim i As Integer = 1
        While i <= 5
            Console.WriteLine("{0}. Hello", i)
            i += 1
        End While
        Console.WriteLine()


        ' Do while loop
        i = 1
        Do
            Console.WriteLine("{0}. Hello", i)
            i += 1
        Loop While i <= 5
        Console.WriteLine()


        ' For Next loop
        For i = 1 To 20 Step 2
            ' using loop control statements

            ' Exit
            If i = 19 Then
                Exit For
            End If

            ' Continue
            If i = 3 Then
                Continue For
            End If

            Console.WriteLine("i = {0}", i)
        Next
        Console.WriteLine()


        ' For Each loop: used over a collection
        For Each number As Integer In {1, 2, 3, 4, 5}
            Console.WriteLine("Number: {0}", number)
        Next


    End Sub
End Module
