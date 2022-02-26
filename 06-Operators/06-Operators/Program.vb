Imports System.Text.RegularExpressions

Module Program
    Sub Main()
        'Arithmetic Operators
        Console.WriteLine("2 ^ 4 is " & 2 ^ 4)
        Console.WriteLine("2 + 4 is " & 2 + 4)
        Console.WriteLine("2 * 4 is " & 2 * 4)
        Console.WriteLine("20 / 5 is " & 20 / 5)
        Console.WriteLine("21 Mod 2 is " & 21 Mod 2)
        Console.WriteLine()

        'Comparison Operators
        Console.WriteLine("5 is equal to 5 ? {0}", 5 = 5)
        Console.WriteLine("5 is not equal to 5 ? {0}", 5 <> 5)
        Console.WriteLine("5 is less than 8 ? {0}", 5 < 8)
        Console.WriteLine("5 is greater than 8 ? {0}", 5 > 8)
        Console.WriteLine()

        'Comparing object reference
        Dim obj1 As Stack = New Stack(10)
        Dim obj2 As Stack = obj1
        Console.WriteLine("Obj1 is same as Obj2: {0}", obj1 Is obj2)
        Console.WriteLine("Obj1 is not same as Obj2: {0}", obj1 IsNot obj2)
        Console.WriteLine()

        'Logical Operators
        Console.WriteLine("True And True: {0}", True And True)
        Console.WriteLine("True And False: {0}", True And False)
        Console.WriteLine("True Or True: {0}", True Or True)
        Console.WriteLine("True Or False: {0}", True Or False)
        Console.WriteLine("Not True: {0}", Not True)
        Console.WriteLine("Not False: {0}", Not False)

        'pattern matching
        Dim color As String = "red"
        Console.WriteLine("Is red is like red : {0}", color Like "red")
        '"^[0-9]{6,6}$"
        Console.WriteLine("Test Pincode: {0}", Regex.IsMatch("180001", "^[0-9]{6,6}$"))

    End Sub
End Module
