Imports System.Console
Module Module1
    Dim rmd As New Random
    Dim numeroaleatorio, n, tentativas As Integer
    Sub Main()


        numeroaleatorio = rmd.Next(1, 100)

        WriteLine("Jogo do Adivinha o Número 
        Tem 10 tentativas parar adivinhar o número, Insira um numero         tentativas = " & tentativas)
        n = ReadLine()
        tentativas = tentativas + 1
        For i = 1 To 10
            dica()
        Next


    End Sub
    Sub dica()

        If n < numeroaleatorio Then

            WriteLine(" O numero é maior do que o número inserido      tentativas = " & tentativas & " Insira outro número")
            n = ReadLine()
            tentativas = tentativas + 1

        ElseIf n > numeroaleatorio Then

            WriteLine(" O numero é menor do que o número inserido      tentativas = " & tentativas & " Insira outro número")
            n = ReadLine()
            tentativas = tentativas + 1

        Else WriteLine("O número introduzido é o número correto presse ENTER para recomeçar o jogo")
            ReadLine()
            Clear()
            Main()
        End If

        If tentativas = 10 And n <> numeroaleatorio Then

            WriteLine("PERDEU! O numero aleatório era " & numeroaleatorio & " presse ENTER para recomeçar o jogo")
            ReadLine()
            Clear()
            Main()
        End If
    End Sub
End Module


