
Imports System.Console
Module Module1

    Sub Main()
        Dim n, ne As Integer
        WriteLine("Intrroduza 20 numeros")

        For i = 1 To 20
            n = ReadLine()
            If n < 0 Then
                ne = ne + 1
            End If

        Next

        WriteLine(ne & " numero/s negativos")
        ReadLine()
    End Sub

End Module


