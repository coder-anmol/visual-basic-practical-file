Imports System

Module Program

    Function MultiplyBy(ByVal number As Integer, Optional ByVal key As Integer = 2) As Integer
        Return number * key
    End Function
    Sub Main(args As String())
        Console.WriteLine(MultiplyBy(10))
        Console.WriteLine(MultiplyBy(10, 10))
    End Sub
End Module
