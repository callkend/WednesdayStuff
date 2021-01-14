Option Compare Text


Module Operators

    Sub Main()

        Console.WriteLine(2 + 2)

        Console.WriteLine(9 / 3)    'Regualar Division
        Console.WriteLine(9 \ 3)    'Interger
        Console.WriteLine(9 Mod 3)  'Divison that returns only the remainder

        Console.WriteLine(5 ^ 5)

        Console.WriteLine("Got " & "Good")

        'compare stuff
        Console.WriteLine(3 > 4)
        Console.WriteLine(3 < 4)
        Console.WriteLine(3 = 4)
        Console.WriteLine(3 <> 4)

        Console.WriteLine("A" < "B")    'compares the ascii values of strings
        Console.WriteLine("AAB" = "BAA") ' looks for the at the highest order and compares"

        Console.WriteLine("abc" = "ABC")



        Console.ReadLine()

    End Sub

End Module
