Public Class Form1
    Dim pic(29) As PictureBox
    Dim piclocalizaçaox(29) As Integer
    Dim piclocalizaçaoy(29) As Integer
    Dim verde As Color = Color.FromArgb(51, 205, 51)
    Dim azul As Color = Color.FromArgb(126, 254, 212)
    Dim vermelho As Color = Color.FromArgb(255, 0, 0)
    Dim branco As Color = Color.FromArgb(255, 255, 255)
    Dim brancoback As Color = Color.FromArgb(240, 240, 240)
    Dim random As New Random
    Dim cor As Color
    Dim posicao(4, 5) As Color
    Dim posicaoplayer(4, 5) As Color
    Dim n, ticker, nivel As Integer
    Dim flag As Boolean = True
    Dim apagar As Boolean = True
    Dim tentativas As Integer = 3

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pic = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10,
    PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20,
     PictureBox21, PictureBox22, PictureBox23, PictureBox24, PictureBox25, PictureBox26, PictureBox27, PictureBox28, PictureBox29, PictureBox30}
        For Each pb As Control In Me.Controls
            If TypeOf pb Is PictureBox Then
                If pb IsNot pic(1) And pb IsNot pic(2) And pb IsNot pic(3) And pb IsNot pic(4) And pb IsNot pic(0) Then
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
                pic(ticker).BackColor = posicao(x, y)
                piclocalizaçaox(ticker) = x
                piclocalizaçaoy(ticker) = y
                ticker += 1
            Next
        Next
        For i = 0 To 29
            AddHandler pic(i).Click, AddressOf pic_Click
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
                        If pb IsNot pic(1) And pb IsNot pic(2) And pb IsNot pic(3) And pb IsNot pic(4) And pb IsNot pic(0) Then
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
                    For k = 5 To 9
                        pic(k).Show()
                    Next
                Case 2
                    For k = 10 To 14
                        pic(k).Show()
                    Next
                Case 3
                    For k = 15 To 19
                        pic(k).Show()
                    Next
                Case 4
                    For k = 20 To 24
                        pic(k).Show()
                    Next
                Case 5
                    For k = 15 To 29
                        pic(k).Show()
                    Next
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
                            If pb IsNot pic(1) And pb IsNot pic(2) And pb IsNot pic(3) And pb IsNot pic(4) And pb IsNot pic(0) Then
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
                pic(ticker).BackColor = posicao(x, y)
                ticker += 1
            Next
        Next

        apagar = True
    End Sub
    Private Sub pic_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim pict As PictureBox = DirectCast(sender, PictureBox)
        If apagar = True Then
            ReDim posicaoplayer(4, 6)
            For Each pb As Control In Me.Controls
                If TypeOf pb Is PictureBox Then
                    pb.BackColor = brancoback
                End If
            Next
            apagar = False
        End If
        pict.BackColor = cor
        For y = 0 To 29
            If pict.Name = pic(y).Name Then
                posicaoplayer(piclocalizaçaox(y), piclocalizaçaoy(y)) = cor
            End If

        Next

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


End Class
