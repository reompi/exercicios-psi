Imports System.Console

Module Module1

    Sub Main()
        Dim n As Decimal = -1

        While n <= 0 Or n >= 20

            WriteLine(" Escreva um número válido entre 0 e 20  ")
            n = ReadLine()
        End While
        WriteLine("     " & n & " é um numero válido ")
        ReadLine()
    End Sub

End Module

