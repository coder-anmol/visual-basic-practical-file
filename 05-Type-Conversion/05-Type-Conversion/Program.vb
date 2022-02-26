Imports System

Module Program
    Sub Main()
        'Implicit Conversion: The compiler will make conversion for us without asking.
        'Example: Byte -> Short -> Integer -> Long -> Decimal -> Single -> Double

        Dim num1 As Integer = 100
        Dim num2 As Integer = 75
        Dim total As Long

        'In this the Integer values are implicitly converted to Long data type
        'you need not to tell compiler to do the conversion, it automatically does

        total = num1 + num2
        Console.WriteLine("Total is : " & total)

        'Explicit conversion: Here we specifically ask the compiler to convert the value into another data type.

        Dim num As Integer
        Dim marks As Decimal = 34.75
        'In this the Decimal values are explicitly converted to Integer data type with rounding the marks 35
        'you have to tell compiler to do the conversion, it uses casting
        num = CInt(marks)
        Console.WriteLine("Converted value is: " & num)

        ' Function Description
        ' CBool    to convert to Bool data type
        ' CByte    to convert to Byte data type
        ' CChar    to convert to Char data type
        ' CDate    to convert to Date type
        ' CDbl     to convert to Double data type
        ' CDec     to convert to Decimal data type
        ' CInt     to convert to Integer data type
        ' CLng     to convert to Long data type
        ' CObj     to convert to Object type
        ' CShort   to convert to Short data type
        ' CSng     to convert to Single data type
        ' CStr     to convert to String data type
        ' CUInt    to convert to UInteger data type
        ' CULng    to convert to ULong data type
        ' CUShort  to convert to UShort data type

    End Sub
End Module
