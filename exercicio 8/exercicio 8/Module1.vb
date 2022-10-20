Imports System.Console
Module Module1

    Sub Main()
        Dim caract As Char
        WriteLine("escreva o caracter")
        caract = ReadLine()


        If caract = "a" Or caract = "e" Or caract = "i" Or caract = "o" Or caract = "u" Then
            WriteLine("o caracter " & caract & " é uma vogal")
        Else WriteLine("o caracter" & caract & "não é uma vogal")

        End If


        ReadLine()

    End Sub

End Module
