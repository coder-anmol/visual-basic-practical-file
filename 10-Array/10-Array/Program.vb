Imports System

Module Program
    Sub Main(args As String())
        ' Array of strings
        Dim colors(3) As String
        colors(0) = "Red"
        colors(1) = "Green"
        colors(2) = "Blue"
        For Each color As String In colors
            Console.WriteLine(color)
        Next


        ' Array of objects
        Dim elements() As Object = {"Hi!", 100, 99.9, True}
        For Each element As Object In elements
            Console.WriteLine(element)
        Next
        Console.WriteLine()


        ' Array of integers
        Dim numbers() As Integer = {1, 2, 3, 4, 5}
        For i As Integer = 0 To numbers.Length - 1 Step 1
            Console.WriteLine(numbers(i))
        Next

    End Sub
End Module
