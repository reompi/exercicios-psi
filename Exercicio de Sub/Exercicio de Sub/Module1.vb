Imports System.Console
Module Module1
    Dim valor1, valor2 As Decimal
    Sub Main()

        WriteLine("Insire 2 valores")
        valor1 = ReadLine()
        valor2 = ReadLine()
        Soma(valor1, valor2, 0)
        ReadLine()
    End Sub
    Sub Soma(n1 As Decimal, n2 As Decimal, n As Decimal)
        n = n1 + n2
        WriteLine(n)

    End Sub

End Module
