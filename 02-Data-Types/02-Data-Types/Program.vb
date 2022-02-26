Imports System

Module Program
    Sub Main(args As String())

        Dim byteVar As Byte
        Dim integerVar As Integer
        Dim singleVar As Single
        Dim doubleVar As Double
        Dim dateVar As Date
        Dim charVar As Char
        Dim stringVar As String
        Dim booleanVar As Boolean

        byteVar = 1
        integerVar = 1234567
        singleVar = 0.12345678901234566
        doubleVar = 0.12345678901234566
        dateVar = Today
        charVar = "A"c
        stringVar = "Visual Basic"
        booleanVar = True

        Console.WriteLine(byteVar)
        Console.WriteLine(integerVar)
        Console.WriteLine(singleVar)
        Console.WriteLine(doubleVar)
        Console.WriteLine(dateVar)
        Console.WriteLine(charVar)
        Console.WriteLine(stringVar)
        Console.WriteLine(booleanVar)

    End Sub
End Module
