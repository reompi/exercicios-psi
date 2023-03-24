Public Class Form1
    Dim pic(29) As PictureBox
    Dim posicao(4, 5) As PictureBox
    Dim butoes(4) As Button
    Dim ticker1, ticker2, jogadas, n, y, x As Integer
    Dim cor1 As Color = ColorTranslator.FromHtml("#fc9402")
    Dim cor2 As Color = ColorTranslator.FromHtml("#02fcf4")
    Dim branco As Color = ColorTranslator.FromHtml("#fcfffe")
    Public cor As Color

    Private Sub butoes_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim butao As Button = DirectCast(sender, Button)
        For k = 0 To 4
            If butao.Name = butoes(k).Name Then
                n = k
            End If
        Next
        jogadas += 1
        If jogadas Mod 2 = 0 Then
            cor = cor2
        Else cor = cor1
        End If
        Select Case n
            Case 0
                posic(0)
                avaliar()
            Case 1
                posic(1)
                avaliar()
            Case 2
                posic(2)
                avaliar()
            Case 3
                posic(3)
                avaliar()
            Case 4
                posic(4)
                avaliar()
        End Select
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ticker1 = 0
        ticker2 = 4
        For Each x As Control In Me.Controls
            If TypeOf x Is PictureBox Then
                pic(ticker1) = x
                ticker1 += 1
                x.BackColor = branco
            End If

            If TypeOf x Is Button Then
                butoes(ticker2) = x
                ticker2 -= 1
                AddHandler x.Click, AddressOf butoes_Click
            End If
        Next
        ticker1 = 0
        For y = 0 To 5
            For i = 0 To 4
                posicao(i, y) = pic(ticker1)
                ticker1 += 1
            Next
        Next
    End Sub
    Sub avaliar()
        ' vertical
        ticker1 = 0
        Do
            For i = 0 To 3
                If posicao(x, ticker1 + i).BackColor <> cor Then
                    Exit For
                ElseIf i = 3 Then
                    venceucor()
                End If
            Next
            ticker1 += 1
        Loop Until ticker1 = 3

        'horizontal
        ticker1 = 0
        Do
            For i = 0 To 3
                If posicao(ticker1 + i, y).BackColor <> cor Then
                    Exit For
                ElseIf i = 3 Then
                    venceucor()
                End If
            Next
            ticker1 += 1
        Loop Until ticker1 = 2

        'diagonal esquerda para direita

        ticker1 = x + 1
        ticker2 = y + 1
        Do
            ticker1 -= 1
            ticker2 -= 1
        Loop Until ticker1 = 0 Or ticker2 = 0
        Do
            For i = 0 To 3
                Try
                    If posicao(ticker1 + i, ticker2 + i).BackColor <> cor Then
                        Exit For
                    ElseIf i = 3 Then
                        venceucor()
                    End If

                Catch
                    Exit For

                End Try
            Next
            ticker1 += 1
            ticker2 += 1
        Loop Until ticker1 = 5 Or ticker2 = 6


        '  diagonal direita para esquerda

        ticker1 = x - 1
        ticker2 = y + 1
        Do

            ticker1 += 1
            ticker2 -= 1
        Loop Until ticker1 = 5 Or ticker2 = 0

        Do
            For i = 0 To 3
                Try
                    If posicao(ticker1 - i, ticker2 + i).BackColor <> cor Then
                        Exit For
                    ElseIf i = 3 Then
                        venceucor()
                    End If
                Catch
                    Exit For

                End Try
            Next
            ticker1 -= 1
            ticker2 += 1
        Loop Until ticker1 <= 0



    End Sub
    Sub posic(coluna As Integer)
        For i = 0 To 5
            If posicao(coluna, i).BackColor = branco Then
                posicao(coluna, i).BackColor = cor
                x = coluna
                y = i
                Exit Sub
            End If
        Next
    End Sub

    Sub venceucor()
        Form2.Show()
        Me.Hide()


    End Sub


End Class
