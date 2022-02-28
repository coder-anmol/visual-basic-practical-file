Imports System

Module Program

    Class Box
        Public length As Double
        Public breadth As Double
        Public height As Double
    End Class
    Sub Main(args As String())
        ' Classes and Objects

        Dim Box As Box = New Box()

        Box.length = 12.5
        Box.breadth = 10.2
        Box.height = 9.9

        Dim volume As Double = 0.0

        volume = Box.length * Box.breadth * Box.height
        Console.WriteLine("Volume of the box is: {0}", volume)
    End Sub
End Module
