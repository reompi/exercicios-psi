Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2 As Decimal
        Dim simb As Char
        WriteLine("introduza o numero a calcular")
        num1 = ReadLine()
        WriteLine("introduza o simbol um dos sinais de operação 'x' ou ':' ou '+' ou '-'")
        simb = ReadLine()
        WriteLine("introduza o 2º numero a calcular")
        num2 = ReadLine()

        If simb = "x" Then
            WriteLine("o resultado é " & num1 * num2)

        ElseIf simb = ":" Then
            WriteLine("o resultado é " & num1 / num2)

        ElseIf simb = "+" Then
            WriteLine("o resultado é " & num1 + num2)

        ElseIf simb = "-" Then
            WriteLine("o resultado é " & num1 - num2)

        Else WriteLine("o carácter que introduzio não tem suporte")

        End If
        ReadLine()


    End Sub

End Module
