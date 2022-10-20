Imports System.Console


Module Module1


    Sub Main()
        Dim valor, soma, vezes, positivo, negativo As Decimal



        WriteLine(" Indique 0 para fazer a média dos numeros válidos entre 0 e 20  ")
        Do
            valor = ReadLine()

            If valor >= 0 And valor <= 20 Then
                soma = soma + valor And
                vezes = vezes + 1
            End If

            If valor >= 10 And valor <= 20 Then
                positivo = positivo + 1
            ElseIf valor >= 0 And valor < 10 Then
                negativo = negativo + 1
            End If




        Loop Until valor = 0




        WriteLine(" A média é " & soma / vezes &
                  "; as positivas são " & positivo &
                  ";  as negativas são " & negativo)
        ReadLine()
    End Sub

End Module
