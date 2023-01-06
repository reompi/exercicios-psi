Imports System.Console
Module Module1

    'Email slicer

    Dim email, emailslicer, endereço, username As String
    Dim arroba, final, inicio As Integer
    Dim contador As Integer = 0

    Sub Main()
        WriteLine("##### EMAIL SLICER #####
Introduza o email para receber o resultado sem o enderesso")
        email = ReadLine()
        arroba = InStr(email, "@")


        Validor()
        email = email.Replace(" ", "")

        final = Len(email)
        inicio = 1




        emailslicer = Mid(email, inicio, arroba)
        username = emailslicer.Replace("@", "")
        endereço = Mid(email, arroba, final)

        Clear()
        WriteLine("USERNAME = " & username & "          ENDEREÇO = " & endereço & "   presse ENTER para recomeçar o programa")

        ReadLine()
        Clear()
        Main()
    End Sub




    Sub Validor()

        For i = 0 To final - 1
            If email(i) = "@" Then
                contador += 1
            End If

        Next
        If contador = 0 Or contador > 1 Then
            Do
                contador = 0

                Clear()
                WriteLine("Email inválido, Insira um email válido com 1 arroba")
                email = ReadLine()


                For i = 0 To final - 1
                    If email(i) = "@" Then
                        contador += 1
                    End If
                Next
            Loop While arroba = 0 Or contador > 1
            arroba = InStr(email, "@")
        End If
    End Sub
End Module
