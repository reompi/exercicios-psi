Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2, num3 As Decimal
        WriteLine("insira o 1º valor")
        num1 = ReadLine()
        WriteLine("insira o 2º valor")
        num2 = ReadLine()
        WriteLine("insira o 3º valor")
        num2 = ReadLine()


        If num1 > num2 And num1 > num3 Then
            WriteLine("o valor maior é " & num1)
        ElseIf num2 > num1 And num2 > num3 Then
            WriteLine("o valor maior é " & num2)
        ElseIf num3 > num1 And num3 > num2 Then
            WriteLine("o valor maior é " & num3)
        End If

        ReadLine()

    End Sub

End Module
