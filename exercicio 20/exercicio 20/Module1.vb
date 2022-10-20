Imports System.Console


Module Module1


    Sub Main()
        Dim n, t, v As Decimal



        WriteLine(" Indique 0 para fazer a média dos numeros válidos entre 0 e 20  ")
        Do
            n = ReadLine()

            If n >= 0 And n <= 20 Then
                t = t + n
                v = v + 1
            End If






        Loop Until n = 0

        WriteLine(" A média é " & t / v)
        ReadLine()
    End Sub

End Module
