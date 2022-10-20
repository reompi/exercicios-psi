Imports System.Console
Module Module1

    Sub Main()
        Dim n, p, im As Integer

        WriteLine("Introduza 20 numeros")

        For i = 1 To 20
            n = ReadLine()

            If n Mod 2 = 0 Then
                p = p + 1

            Else im = im + 1
            End If

        Next

        WriteLine(im & " impar/es " & p & " par/es")

        ReadLine()
    End Sub

End Module
