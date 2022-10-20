Imports System.Console
Module Module1

    Sub Main()
        Dim c, v As Integer
        Dim l As Char
        WriteLine("Introduza 20 letras")

        For i = 1 To 20
            l = ReadLine()

            Select Case l
                Case "a"
                    v = v + 1

                Case "A"
                    v = v + 1
                Case "e"
                    v = v + 1
                Case "E"
                    v = v + 1
                Case "O"
                    v = v + 1
                Case "o"
                    v = v + 1
                Case "I"
                    v = v + 1
                Case "i"
                    v = v + 1
                Case "u"
                    v = v + 1
                Case "U"
                    v = v + 1
                Case Else
                    c = c + 1
            End Select
        Next
        WriteLine(c & " consoantes " & v & " vogais")

        ReadLine()
    End Sub

End Module
