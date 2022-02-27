Imports System

Module Program
    ' Sub Procedures
    Sub PrintSquareOfNumber(ByVal number As Integer)
        Console.WriteLine("Square of {0} is: {1}", number, number ^ 2)
    End Sub
    Sub Main(args As String())
        PrintSquareOfNumber(9)
    End Sub
End Module
