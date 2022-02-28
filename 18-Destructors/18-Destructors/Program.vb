Imports System

Module Program

    Public Class User
        Public email As String
        Public userName As String
        Public password As String

        Public Sub New(ByVal email As String, ByVal userName As String, ByVal password As String)
            Me.email = email
            Me.userName = userName
            Me.password = password
        End Sub

        ' I don't know why it does n't works but on page: it will :kek:
        Protected Overrides Sub Finalize()
            Console.WriteLine("Destructor is called now")
        End Sub

        Public Sub ShowData()
            Console.WriteLine("Username: {0}", Me.userName)
            Console.WriteLine("Email: {0}", Me.email)
            Console.WriteLine("Password: {0}", Me.password)
        End Sub
    End Class

    Sub Test()
        Dim user As User = New User("test@user.com", "John Doe", "Test@123")
        user.ShowData()
        ' destructor gets called automatically
    End Sub

    Sub Main(args As String())
        Test()
        Console.ReadLine()
    End Sub
End Module
