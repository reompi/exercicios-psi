Imports System.Console
Module Module1
    Dim num1, num2, num3 As Decimal
    Sub Main()
        WriteLine("insira um numero")
        num1 = ReadLine()
        WriteLine("insira um numero")
        num2 = ReadLine()
        WriteLine("insira um numero")
        num3 = ReadLine()

        WriteLine("a media dos seus numeros é " & (num1 + num2 + num3) / 3)
        ReadLine()
    End Sub

End Module
