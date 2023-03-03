Public Class Form1
    Dim cores(4, 6) As Color
    Dim cor As Color
    Dim verde As Color = Color.FromArgb(51, 205, 51)
    Dim azul As Color = Color.FromArgb(126, 254, 212)
    Dim vermelho As Color = Color.FromArgb(255, 0, 0)
    Dim branco As Color = Color.FromArgb(224, 224, 225)
    Dim random As New Random
    Dim x, y As Integer
    Dim nivel As Integer = 4
    Public Shared Function FromArgb(alpha As Integer, red As Integer, green As Integer, blue As Integer) As Color
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cor = verde
    End Sub
    Public Sub FromArgb1(sender As Object, e As EventArgs) Handles Button4.Click

        cor = azul
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        cor = vermelho
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cor = branco
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox5.Hide()
        'PictureBox6.Hide()
        'PictureBox7.Hide()
        'PictureBox8.Hide()
        'PictureBox9.Hide()
        'PictureBox10.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox1.Hide()
        'PictureBox(nivel).hi

        For Each Bullet As Control In Me.Controls
            If TypeOf Bullet Is PictureBox Then
                Bullet.Hide()
            End If
        Next
        x = random.Next(0, 4)

        Select Case x
                    Case 0
                        cor = verde
                    Case 1
                        cor = azul
                    Case 2
                        cor = vermelho
                    Case 3
                        cor = branco
                End Select



    End Sub
End Class
