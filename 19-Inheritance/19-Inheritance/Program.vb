Imports System

Module Program
    Class Person
        Public name As String
        Public email As String
        Public address As String
    End Class

    Class User
        Inherits Person
        Public username As String
    End Class


    Sub Main(args As String())
        Dim user As User = New User()

        user.name = "John Doe"
        user.email = "john@doe.com"
        user.address = "Delhi, India"
        user.username = "johndoe2022"

        Console.WriteLine(user.name)
        Console.WriteLine(user.email)
        Console.WriteLine(user.address)
        Console.WriteLine(user.username)
    End Sub
End Module
