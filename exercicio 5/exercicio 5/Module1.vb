Imports System.Console
Module Module1
    Dim num1 As Decimal
    Sub Main()
        WriteLine("insira graus celsius")
        num1 = ReadLine()

        WriteLine("graus em fahrenheit " & (num1 * 1.8 + 32))
        ReadLine()
    End Sub

End Module
