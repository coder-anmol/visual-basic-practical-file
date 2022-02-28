Imports System

Module Program

    ' Access Modifier	   Description
    ' Public               It Is used To specifies that access Is Not restricted.
    ' Private              It Is used To specifies that access Is limited To the containing type.
    ' Protected            It Is used To specifies that the access Is limited To the containing type Or types derived from the containing Class.
    ' Friend (internal)	   It Is used to specifies that access Is limited to the current assembly.
    ' Protected Friend     It Is used To specifies that access Is limited To the current assembly Or types derived from the containing Class.
    Class User
        Public name As String
        Private role As String
        Protected isWinner As Boolean
        Friend isLooser As Boolean
        Protected Friend email As String

        Public Sub New()
            ' private
            Me.role = "Editor"

            Console.WriteLine("(Private) role: {0}", Me.role)
        End Sub
    End Class

    Class Winner
        Inherits User

        Public Sub New(ByVal name As String, ByVal isWinner As Boolean, ByVal email As String)
            'Public
            Me.name = name

            'Protected
            Me.isWinner = isWinner

            'Protected Friend
            Me.email = email

            Console.WriteLine("(Public) name: {0}", Me.name)
            Console.WriteLine("(Protected) isWinner: {0}", Me.isWinner)
            Console.WriteLine("(Protected Friend) Email: {0}", Me.email)
            Console.WriteLine()
        End Sub
    End Class

    Class Looser
        Sub FriendAccess()
            Dim user As New User
            'Friend
            user.isLooser = True

            'Protected Friend
            user.email = "test@email.com"

            Console.WriteLine("(Friend) isLooser: {0}", user.isLooser)
            Console.WriteLine("(Protected Friend) Email: {0}", user.email)
            Console.WriteLine()
        End Sub
    End Class

    Sub Main(args As String())
        Dim winner As Winner = New Winner("John", True, "winner@john.com")
        Dim looser As Looser = New Looser()

        looser.FriendAccess()
    End Sub
End Module
