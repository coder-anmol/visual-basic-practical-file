Imports System.IO
Imports System.Text

Module Program
    Sub Main(args As String())
        ' File Handling
        Dim path As String = "C:\Users\anmol\Desktop\Created Files\myFirstFile.txt"

        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("This is my first file created using code")
        fs.Write(info, 0, info.Length)
        fs.Close()

        ' Reading file
        Dim fileReader As String
        fileReader = File.ReadAllText(path)
        Console.WriteLine(fileReader)

    End Sub
End Module
