Imports System.Console
Module Module1

    Sub Main()
        Dim total, valor As Integer
        Dim rmd As New Random
        Dim contador As Integer


        contador = contador + 1



        WriteLine("Jogo dos 31; Insira um dos valor 1; 2 ou 3")

        Do While total <= 28
            Do
                valor = ReadLine()
            Loop Until valor >= 1 And valor <= 3
            total = valor + total
                contador = contador + 1

                WriteLine(" valor desta rodada = " & valor & " valor total = " & total & "   próxima jogador = jogador2")

                valor = rmd.Next(1, 4)
                total = valor + total
                contador = contador + 1
                WriteLine(" 
valor desta rodada = " & valor & " valor total = " & total & "   próxima jogador = jogador1  vezes jogadas = " & contador)
            Loop




        If contador Mod 2 = 0 And total = 28 Then
            valor = 2
            total = valor + total
            contador = contador + 1
            WriteLine(" 
valor desta rodada = " & valor & " valor total = " & total & "   próxima jogador = jogador1   vezes jogadas = " & contador)

            Do
                valor = ReadLine()
            Loop Until valor >= 1 And valor <= 3
            total = valor + total
            contador = contador + 1
            WriteLine(" valor desta rodada = " & valor & " valor total = " & total & " 
                 O JOGDOR NUMERO 2 VENCEU")


        ElseIf contador Mod 2 = 0 And total = 29 Then
            valor = 1
            total = valor + total
            contador = contador + 1
            WriteLine(" 
valor desta rodada = " & valor & " valor total = " & total & "   próxima jogador = jogador1   vezes jogadas = " & contador)

            Do
                valor = ReadLine()
            Loop Until valor >= 1 And valor <= 3
            total = valor + total
            contador = contador + 1
            WriteLine(" valor desta rodada = " & valor & " valor total = " & total & " 
                 O JOGDOR NUMERO 2 VENCEU")


        ElseIf contador Mod 2 = 0 And total = 30 Then
            valor = 1
            total = valor + total
            contador = contador + 1
            WriteLine(" 
valor desta rodada = " & valor & " valor total = " & total & " vezes jogadas = " & contador)


            WriteLine(" 
                 O JOGDOR NUMERO 2 VENCEU")

        Else
            Do
                valor = ReadLine()
            Loop Until valor >= 1 And valor <= 3
            total = valor + total
            contador = contador + 1
            WriteLine(" valor desta rodada = " & valor & " valor total = " & total & "   próxima jogador = jogador2")
            valor = 1
            total = valor + total
            contador = contador + 1
            WriteLine(" valor desta rodada = " & valor & " valor total = " & total)
            If total = 31 Then
                WriteLine("O JOGADOR NÚMERO 1 GANHOU")
            End If
            Do
                valor = ReadLine()
            Loop Until valor >= 1 And valor <= 3
            total = valor + total
            contador = contador + 1
            WriteLine(" valor desta rodada = " & valor & " valor total = " & total)
            WriteLine("O JOGADOR NÚMERO 2 GANHOU")
        End If


    End Sub

End Module
