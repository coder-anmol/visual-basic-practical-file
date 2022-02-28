Imports System

Module Program
    ' Multi level inheritance
    Class Person
        Public name As String
    End Class

    Class User
        Inherits Person
        Public email As String
    End Class

    Class Student
        Inherits User
        Public collegeName As String

        Public Sub PrintDetails()
            Console.WriteLine("Name: {0}", Me.name)
            Console.WriteLine("Email: {0}", Me.email)
            Console.WriteLine("College: {0}", Me.collegeName)
        End Sub
    End Class

    Sub Main(args As String())
        Dim student As Student = New Student()

        student.name = "John Doe"
        student.email = "test@john.com"
        student.collegeName = "MIT, California USA"

        student.PrintDetails()
    End Sub
End Module
