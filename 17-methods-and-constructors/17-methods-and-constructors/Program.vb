Imports System

Module Program

    Class Car
        Public name As String
        Public model As String
        Public year As String
        Public brand As String
        Public price As Double

        ' Constructor
        Public Sub New(ByVal name As String, ByVal model As String, ByVal year As String, ByVal brand As String, ByVal price As Double)
            Me.name = name
            Me.model = model
            Me.year = year
            Me.brand = brand
            Me.price = price
        End Sub

        ' Methods
        Public Sub ShowDetails()
            Console.WriteLine("Car Name: {0}", Me.name)
            Console.WriteLine("Car Model: {0}", Me.model)
            Console.WriteLine("Car Year: {0}", Me.year)
            Console.WriteLine("Car Brand: {0}", Me.brand)
            Console.WriteLine("Car Price: ${0}", Me.price)
        End Sub

    End Class
    Sub Main(args As String())
        Dim maruti As Car = New Car("Alto", "Vxi", "2022", "Maruti Suzuki", 10000.99)

        maruti.ShowDetails()
    End Sub
End Module
