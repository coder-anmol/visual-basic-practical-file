Imports System

Module Program
    Interface IUser
        Sub SetName(ByVal name As String)
        Sub PrintName()
    End Interface

    Class User
        Implements IUser

        Public name As String

        Public Sub SetName(ByVal name As String) Implements IUser.SetName
            Me.name = name
        End Sub

        Public Sub PrintName() Implements IUser.PrintName
            Console.WriteLine("Name of user is: {0}", Me.name)
        End Sub


    End Class
    Sub Main(args As String())
        Dim user As User = New User()

        user.SetName("John Doe")
        user.PrintName()
    End Sub
End Module
