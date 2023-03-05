Public Class Form1
    Dim fotos(30) As PictureBox
    Dim verde As Color = Color.FromArgb(51, 205, 51)
    Dim azul As Color = Color.FromArgb(126, 254, 212)
    Dim vermelho As Color = Color.FromArgb(255, 0, 0)
    Dim branco As Color = Color.FromArgb(255, 255, 255)
    Dim brancoback As Color = Color.FromArgb(240, 240, 240)
    Dim random As New Random
    Dim cor As Color
    Dim posicao(4, 6) As Color
    Dim posicaoplayer(4, 6) As Color
    Dim n, ticker, nivel As Integer
    Dim flag As Boolean = True
    Dim apagar As Boolean = True
    Dim tentativas As Integer = 3

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fotos = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10,
    PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20,
     PictureBox21, PictureBox22, PictureBox23, PictureBox24, PictureBox25, PictureBox26, PictureBox27, PictureBox28, PictureBox29, PictureBox30}
        For Each pb As Control In Me.Controls
            If TypeOf pb Is PictureBox Then
                If pb IsNot PictureBox1 And pb IsNot PictureBox2 And pb IsNot PictureBox3 And pb IsNot PictureBox4 And pb IsNot PictureBox5 Then
                    pb.Hide()
                End If
            End If
        Next
        For y = 0 To nivel
            For x = 0 To 4
                n = random.Next(1, 5)
                Select Case n
                    Case 1
                        posicao(x, y) = verde
                    Case 2
                        posicao(x, y) = azul
                    Case 3
                        posicao(x, y) = vermelho
                    Case 4
                        posicao(x, y) = branco
                End Select
                fotos(ticker).BackColor = posicao(x, y)
                ticker += 1
            Next
        Next
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For y = 0 To nivel
            For x = 0 To 4
                If posicao(x, y) <> posicaoplayer(x, y) Then
                    flag = False
                End If
            Next
        Next
        If flag = False Then
            If tentativas = 1 Then
                Me.Hide()
                Form2.Show()
                ticker = 0
                tentativas = 3
                nivel = 0
                ReDim posicao(4, 6)
                ReDim posicaoplayer(4, 6)
                For Each pb As Control In Me.Controls
                    If TypeOf pb Is PictureBox Then
                        If pb IsNot PictureBox1 And pb IsNot PictureBox2 And pb IsNot PictureBox3 And pb IsNot PictureBox4 And pb IsNot PictureBox5 Then
                            pb.Hide()
                        End If
                    End If
                Next

            Else
                tentativas -= 1


            End If
            Label2.Text = tentativas
            flag = True
        Else
            nivel += 1
            Select Case nivel
                Case 1
                    PictureBox6.Show()
                    PictureBox7.Show()
                    PictureBox8.Show()
                    PictureBox9.Show()
                    PictureBox10.Show()
                Case 2
                    PictureBox11.Show()
                    PictureBox12.Show()
                    PictureBox13.Show()
                    PictureBox14.Show()
                    PictureBox15.Show()
                Case 3
                    PictureBox16.Show()
                    PictureBox17.Show()
                    PictureBox18.Show()
                    PictureBox19.Show()
                    PictureBox20.Show()
                Case 4
                    PictureBox21.Show()
                    PictureBox22.Show()
                    PictureBox23.Show()
                    PictureBox24.Show()
                    PictureBox25.Show()
                Case 5
                    PictureBox26.Show()
                    PictureBox27.Show()
                    PictureBox28.Show()
                    PictureBox29.Show()
                    PictureBox30.Show()
                Case 6
                    Me.Hide()
                    Form3.Show()
                    ticker = 0
                    tentativas = 3
                    nivel = 0
                    ReDim posicao(4, 6)
                    ReDim posicaoplayer(4, 6)
                    Label2.Text = tentativas
                    flag = True
                    For Each pb As Control In Me.Controls
                        If TypeOf pb Is PictureBox Then
                            If pb IsNot PictureBox1 And pb IsNot PictureBox2 And pb IsNot PictureBox3 And pb IsNot PictureBox4 And pb IsNot PictureBox5 Then
                                pb.Hide()
                            End If
                        End If
                    Next
            End Select

        End If
        ticker = 0
        For y = 0 To nivel
            For x = 0 To 4
                n = random.Next(1, 5)
                Select Case n
                    Case 1
                        posicao(x, y) = verde
                    Case 2
                        posicao(x, y) = azul
                    Case 3
                        posicao(x, y) = vermelho
                    Case 4
                        posicao(x, y) = branco
                End Select
                fotos(ticker).BackColor = posicao(x, y)
                ticker += 1
            Next
        Next

        apagar = True
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
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox1.BackColor = cor
        posicaoplayer(0,0) = cor
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox2.BackColor = cor
        posicaoplayer(1, 0) = cor
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox3.BackColor = cor
        posicaoplayer(2, 0) = cor
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox4.BackColor = cor
        posicaoplayer(3, 0) = cor
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox5.BackColor = cor
        posicaoplayer(4, 0) = cor
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox6.BackColor = cor
        posicaoplayer(0, 1) = cor
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox7.BackColor = cor
        posicaoplayer(1, 1) = cor
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox8.BackColor = cor
        posicaoplayer(2, 1) = cor
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox9.BackColor = cor
        posicaoplayer(3, 1) = cor
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox10.BackColor = cor
        posicaoplayer(4, 1) = cor
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox11.BackColor = cor
        posicaoplayer(0, 2) = cor
    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox12.BackColor = cor
        posicaoplayer(1, 2) = cor
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox13.BackColor = cor
        posicaoplayer(2, 2) = cor
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox14.BackColor = cor
        posicaoplayer(3, 2) = cor
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox15.BackColor = cor
        posicaoplayer(4, 2) = cor
    End Sub
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox16.BackColor = cor
        posicaoplayer(0, 3) = cor
    End Sub
    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
                apagar = False
            Next
        End If
        PictureBox17.BackColor = cor
        posicaoplayer(1, 3) = cor
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox18.BackColor = cor
        posicaoplayer(2, 3) = cor
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox19.BackColor = cor
        posicaoplayer(3, 3) = cor
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox20.BackColor = cor
        posicaoplayer(4, 3) = cor
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox21.BackColor = cor
        posicaoplayer(0, 4) = cor
    End Sub
    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox22.BackColor = cor
        posicaoplayer(1, 4) = cor
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox23.BackColor = cor
        posicaoplayer(2, 4) = cor
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox24.BackColor = cor
        posicaoplayer(3, 4) = cor
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox25.BackColor = cor
        posicaoplayer(4, 4) = cor
    End Sub
    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox26.BackColor = cor
        posicaoplayer(0, 5) = cor
    End Sub
    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox27.BackColor = cor
        posicaoplayer(1, 5) = cor
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox28.BackColor = cor
        posicaoplayer(2, 5) = cor
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox29.BackColor = cor
        posicaoplayer(3, 5) = cor
    End Sub


    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        PictureBox30.BackColor = cor
        posicaoplayer(4, 5) = cor
    End Sub

End Class
