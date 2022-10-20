Imports System.Console
Module Module1
    Dim base1, base2 As Decimal
    Sub Main()
        WriteLine("insira a base")
        base1 = ReadLine()
        WriteLine("insira o expoente")
        base2 = ReadLine()


        WriteLine("a potencia dos seus numeros é " & base1 ^ base2)
        ReadLine()
    End Sub

End Module
