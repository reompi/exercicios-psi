Imports System.Console
Module Module1

    Sub Main()
        WriteLine("Inira um número caso ele seja entre 0 e 99 ele é válido")
        Dim numero As Integer
        numero = ReadLine()
        If numero <= 0 Or numero >= 99 Then
            WriteLine("O Número " & numero & "é inválido ")
            ReadLine()
            Clear()
            Main()
        End If
        Dim n10, n1 As Decimal
        n10 = numero \ 10
        n1 = numero Mod 10
        Dim nextenso1, nextenso10 As String
        nextenso1 = ""
        nextenso10 = ""


        Select Case n10
            Case 2
                nextenso10 = "vinte"
            Case 3
                nextenso10 = "trinta"
            Case 4
                nextenso10 = "quarenta"
            Case 5
                nextenso10 = "cinquenta"
            Case = 6
                nextenso10 = "Sessenta"
            Case = 7
                nextenso10 = "setenta"
            Case = 8
                nextenso10 = "oitenta"
            Case = 9
                nextenso10 = "noventa"


        End Select
        Select Case n1
            Case 0
                nextenso10 = ""
            Case 1
                nextenso1 = "um"
            Case 2
                nextenso1 = "dois"
            Case 3
                nextenso1 = "trez"
            Case 4
                nextenso1 = "quatro"
            Case 5
                nextenso1 = "cinco"
            Case 6
                nextenso1 = "Seis"
            Case 7
                nextenso1 = "sete"
            Case 8
                nextenso1 = "oito"
            Case 9
                nextenso1 = "nove"


        End Select
        Dim nextenso As String
        If n10 = 0 Then
            nextenso = nextenso1
        End If
        If n10 = 0 And n1 = 0 Then
            nextenso = "zero"
        End If

        If n10 = 2 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 2 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If

        If n10 = 3 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 3 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If
        If n10 = 4 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 4 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If
        If n10 = 5 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 5 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If
        If n10 = 6 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 6 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If
        If n10 = 7 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 7 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If
        If n10 = 8 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 8 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If
        If n10 = 9 Then
            nextenso = nextenso10 + " e " + nextenso1
            If n10 = 9 And n1 = 0 Then
                nextenso = nextenso10
            End If
        End If
        If n10 = 1 And n1 = 0 Then
            nextenso = "dez"
        End If
        If n10 = 1 And n1 = 1 Then
            nextenso = "onze"
        End If
        If n10 = 1 And n1 = 2 Then
            nextenso = "doze"
        End If
        If n10 = 1 And n1 = 3 Then
            nextenso = "treze"
        End If
        If n10 = 1 And n1 = 4 Then
            nextenso = "quatorze"
        End If
        If n10 = 1 And n1 = 5 Then
            nextenso = "quinze"
        End If
        If n10 = 1 And n1 = 6 Then
            nextenso = "dezesseis"
        End If
        If n10 = 1 And n1 = 7 Then
            nextenso = "dezassete"
        End If
        If n10 = 1 And n1 = 8 Then
            nextenso = "dezoito"
        End If
        If n10 = 1 And n1 = 9 Then
            nextenso = "dezanove"
        End If

        WriteLine("o número " & nextenso & " é válido")
        ReadLine()
    End Sub

End Module
