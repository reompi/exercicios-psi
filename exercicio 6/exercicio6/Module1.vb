Imports System.Console
Module Module1

    Sub Main()
        Dim num1, num2 As Decimal
        WriteLine("insira o valor")
        num1 = ReadLine()
        WriteLine("insira o segundo valor")
        num2 = ReadLine()


        If num1 < num2 Then
            WriteLine("o valor maior é " & num2)
        ElseIf num1 > num2 Then
            WriteLine("o valor maior é " & num1)

        End If

        ReadLine()

    End Sub

End Module
