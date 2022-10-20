
Imports System.Console
Module Module1

        Sub Main()
        Dim n, s, p As Decimal
        WriteLine("Intrroduza 20 numeros")
        s = 1
        For i = 1 To 20
            n = ReadLine()
            s = s * n


        Next

        WriteLine(s)
        ReadLine()
        End Sub

    End Module


