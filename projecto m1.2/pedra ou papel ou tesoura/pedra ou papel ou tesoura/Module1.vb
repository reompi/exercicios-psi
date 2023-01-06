''' <summary>
''' Pedra ou papel ou tesoura
''' </summary>

Imports System.Console
Module Module1

    Dim robo, mododejogo, numero As Integer
    Dim rmd As New Random

    Dim usuarioppt, roboppt As String
    Sub Main()



        WriteLine("PEDRA PAPEL OU TESOURA")
        WriteLine("Selecione o modo de jogo introduzindo um dos dois números")
        WriteLine("1- Jogo      2-regras")
        mododejogo = ReadLine()

        If mododejogo > 2 Or mododejogo < 1 Then
            Do
                WriteLine("O numero " & mododejogo & " é inválido indroduza um numero válido 1 ou 2")
                WriteLine("Selecione o modo de jogo introduzindo um dos dois números")
                WriteLine("1- Jogo      2-regras")
                mododejogo = ReadLine()
            Loop While mododejogo > 2 Or mododejogo < 1
        End If
        Select Case mododejogo
            Case 1
                Clear()
                WriteLine("introduza o número que quer para jogar")
                WriteLine(" sendo :")
                WriteLine(" 1 - pedra   |   2- papel   |   3 - tesoura  ")

                numero = ReadLine()
                ramdom()
                validor()
                robodados()
                jogadordados()
                qualificado()




            Case 2
                Clear()
                WriteLine("Regras do jogo")
                WriteLine()
                writeline("O jogador insere um dos números entre 1 a 3 sendo 1 - pedra 2- papel 3 - tesoura       ")
                WriteLine("Caso ambos os jogadores insiram o mesmo número é impate, caso seja pedra contra papel o papel ganha, caso tesoura contra pedra a pedra ganha, caso tesoura contra papel a tesoura ganha")
                WriteLine("pressione ENTER para voltar ao menu")
                ReadLine()
                Clear()
                Main()



        End Select



    End Sub

    Sub qualificado()
        If numero = 1 And robo = 1 Or numero = 2 And robo = 2 Or numero = 3 And robo = 3 Then
            Do
                Clear()
                WriteLine("Empataste ! Empataste o outro jogador selecionou " & roboppt & " e tu inseriste " & usuarioppt & " Insira denovo um número para tentar desenpatar           sendo 1 - pedra 2- papel 3 - tesoura  ")
                numero = ReadLine()
                ramdom()
                validor()
                robodados()
                jogadordados()

            Loop While numero = 1 And robo = 1 Or numero = 2 And robo = 2 Or numero = 3 And robo = 3

            qualificado()

        ElseIf numero = 1 And robo = 2 Or numero = 2 And robo = 3 Or numero = 3 And robo = 1 Then
            Clear()
            WriteLine(" Perdeste ! perdeste o outro jogador selecionou " & roboppt & " e tu inseriste " & usuarioppt)
            WriteLine("pressione ENTER para voltar ao menu")
            ReadLine()
            Clear()
            Main()

        Else
            Clear()
            WriteLine(" Ganhaste ! ganhaste o outro jogador selecionou " & roboppt & " e tu inseriste " & usuarioppt)
            WriteLine("pressione ENTER para voltar ao menu")
            ReadLine()
            Clear()
            Main()

        End If

    End Sub

    Sub validor()
        If numero > 3 Or numero < 1 Then
            Do
                WriteLine("O numero " & numero & " é inválido indroduza um numero válido entre 1 a 3           sendo 1 - pedra 2- papel 3 - tesoura")
                numero = ReadLine()

            Loop While numero > 3 Or numero < 1
        End If
    End Sub

    Sub jogadordados()
        Select Case numero
            Case 1
                usuarioppt = " pedra "
            Case 2
                usuarioppt = "papel "
            Case 3
                usuarioppt = " tesoura "

        End Select

    End Sub

    Sub robodados()
        Select Case robo
            Case 1
                roboppt = " pedra "
            Case 2
                roboppt = "papel "
            Case 3
                roboppt = " tesoura "

        End Select
    End Sub
    Sub ramdom()
        robo = rmd.Next(1, 4)
    End Sub
End Module
