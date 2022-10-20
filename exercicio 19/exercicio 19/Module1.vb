Imports System.Console


Module Module1


    Sub Main()
        Dim n, t, v As Decimal



        WriteLine(" Indique 20 números para fazer a média dos numeros válidos entre 0 e 20  ")
        For i = 1 To 20
            n = ReadLine()

            If n >= 0 And n <= 20 Then
                t = t + n
                v = v + 1
            End If






        Next

        WriteLine(" A média é " & t / v)
        ReadLine()
    End Sub

End Module
