Imports System

Module Test
    Public globalScope As String = "Global Scope"
End Module
Module Program

    Dim moduleScope As String = "Module Scope"
    Sub ProcedureScope()
        Dim var As String = "Procedure Scope"
        Console.WriteLine(var)
        Console.WriteLine(moduleScope)
    End Sub
    Sub Main()
        Console.WriteLine(moduleScope)
        Console.WriteLine()

        ProcedureScope()

        Console.WriteLine()
        Console.WriteLine(globalScope)
    End Sub
End Module
