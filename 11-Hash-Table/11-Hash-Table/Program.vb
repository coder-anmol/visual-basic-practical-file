Imports System

Module Program
    Sub Main(args As String())
        'Collections: Stack,Queue, ArrayList, Hash Table
        Dim table As Hashtable = New Hashtable()

        table.Add("0", "Ram")
        table.Add("1", "Sham")
        table.Add("2", "Shubham")
        table.Add("3", "Harry")
        table.Add("4", "Hardeep")

        For Each key As String In table.Keys
            Console.WriteLine("{0} : {1}", key, table(key))
        Next
    End Sub
End Module
