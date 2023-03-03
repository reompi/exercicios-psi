Public Class Form1
    Dim verde As Color = Color.FromArgb(51, 205, 51)
    Dim azul As Color = Color.FromArgb(126, 254, 212)
    Dim vermelho As Color = Color.FromArgb(255, 0, 0)
    Dim branco As Color = Color.FromArgb(224, 224, 225)
    Dim random As New Random
    Dim cor As Color
    Dim nivel As Integer = 1
    Dim n As Integer
    Dim tentativas As Integer = 3
    Dim posicao(4, 6) As Color
    Dim posicaoplayer(4, 6) As Color
    Dim jogavel, flag, flag2 As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = tentativas
        jogavel = False
        For Each Bullet As Control In Me.Controls
            If TypeOf Bullet Is PictureBox Then
                If Bullet IsNot PictureBox1 And Bullet IsNot PictureBox2 And Bullet IsNot PictureBox3 And Bullet IsNot PictureBox4 And Bullet IsNot PictureBox5 Then
                    Bullet.Hide()
                End If
            End If
        Next
        For y = 0 To nivel
            For x = 0 To 5
                n = random.Next(1, 5)
                Select Case n
                    Case 1
                        cor = verde
                    Case 2
                        cor = azul
                    Case 3
                        cor = vermelho
                    Case 4
                        cor = branco
                End Select
                posicao(x, y) = cor

                For Each Bullet As Control In Me.Controls
                    If TypeOf Bullet Is PictureBox Then
                        If Bullet.Text = "picturebox" & (y + 1) * 5 - 5 + (x + 1) Then
                            Bullet.BackColor = cor
                        End If
                    End If
                Next
            Next
        Next
        cor = branco
        jogavel = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For y = 0 To nivel
            For x = 0 To 5
                If posicao(x, y) <> posicaoplayer(x, y) Then
                    flag2 = False
                End If
            Next
        Next
        If flag2 = True Then
            nivel += 1
            jogavel = False
            If nivel = 2 Then
                PictureBox6.Show()
                PictureBox7.Show()
                PictureBox8.Show()
                PictureBox9.Show()
                PictureBox10.Show()
            ElseIf nivel = 3 Then
                PictureBox11.Show()
                PictureBox12.Show()
                PictureBox13.Show()
                PictureBox14.Show()
                PictureBox15.Show()
            ElseIf nivel = 4 Then
                PictureBox16.Show()
                PictureBox17.Show()
                PictureBox18.Show()
                PictureBox19.Show()
                PictureBox20.Show()
            ElseIf nivel = 5 Then
                PictureBox21.Show()
                PictureBox22.Show()
                PictureBox23.Show()
                PictureBox24.Show()
                PictureBox25.Show()
            ElseIf nivel = 6 Then
                PictureBox26.Show()
                PictureBox27.Show()
                PictureBox28.Show()
                PictureBox29.Show()
                PictureBox30.Show()
            ElseIf nivel = 7 Then
                Me.Hide()
                Form2.Show()

                For y = 0 To nivel
                    For x = 0 To 5
                        n = random.Next(1, 5)
                        Select Case n
                            Case 1
                                cor = verde
                            Case 2
                                cor = azul
                            Case 3
                                cor = vermelho
                            Case 4
                                cor = branco
                        End Select
                        posicao(x, y) = cor

                        For Each Bullet As Control In Me.Controls
                            If TypeOf Bullet Is PictureBox Then
                                If Bullet.Text = "picturebox" & (y + 1) * 5 - 5 + (x + 1) Then
                                    Bullet.BackColor = cor
                                End If
                            End If
                        Next
                    Next
                Next
                cor = branco
                jogavel = True
            End If

        Else
            tentativas -= 1

        End If
        flag2 = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cor = verde
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cor = azul
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cor = vermelho
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cor = branco
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If flag = False Then

        End If
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(4, 2) = cor
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(4, 0) = cor
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(1, 1) = cor
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(2, 1) = cor
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(3, 1) = cor
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(4, 1) = cor
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 1) = cor
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(2, 0) = cor
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If jogavel = True Then
            PictureBox4.BackColor = cor
            posicaoplayer(3, 0) = cor
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If jogavel = True Then
            PictureBox2.BackColor = cor
            posicaoplayer(1, 0) = cor
        End If
    End Sub



    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        If jogavel = True Then
            PictureBox1.BackColor = cor
            posicaoplayer(0, 0) = cor
        End If
    End Sub
End Class
