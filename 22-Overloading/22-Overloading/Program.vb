Imports System

Module Program

    Class Rectangle
        Public length As Double
        Public breadth As Double

        Public Sub New()
            Me.length = 0.0
            Me.breadth = 0.0
        End Sub
        Public Sub New(ByVal length As Double, ByVal breadth As Double)
            Me.length = length
            Me.breadth = breadth
        End Sub

        Public Sub Area()
            Dim area As Double

            area = Me.length * Me.breadth
            Console.WriteLine("Area of the rectangle is: {0}", area)
        End Sub

    End Class
    Sub Main(args As String())
        Dim rectangle1 As Rectangle = New Rectangle()
        Dim rectangle2 As Rectangle = New Rectangle(10.5, 5.7)

        rectangle1.length = 22.3
        rectangle1.breadth = 11.6
        rectangle1.Area()

        rectangle2.Area()
    End Sub
End Module
