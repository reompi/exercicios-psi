Public Class Form1
    Dim speed As Integer = 5
    Dim direita As Boolean = False
    Dim esquerda As Boolean = True
    Dim up As Boolean = False
    Dim down As Boolean = False
    Dim obstaculos As Boolean = True
    Dim movimento As Boolean = True
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If movimento = True Then
            If e.KeyCode = Keys.Down Then
                down = True
                PictureBox1.Top += speed

            End If
            If e.KeyCode = Keys.Up Then
                up = True
                PictureBox1.Top -= speed

            End If
            If e.KeyCode = Keys.Left Then
                esquerda = True
                PictureBox1.Left -= speed

            End If
            If e.KeyCode = Keys.Right Then
                direita = True
                PictureBox1.Left += speed

            End If
            If down = True And direita = True Then
                PictureBox1.Top += speed
                PictureBox1.Left += speed
            End If
            If down = True And esquerda = True Then
                PictureBox1.Top += speed
                PictureBox1.Left -= speed
            End If
            If up = True And direita = True Then
                PictureBox1.Top -= speed
                PictureBox1.Left += speed
            End If
            If up = True And esquerda = True Then
                PictureBox1.Top -= speed
                PictureBox1.Left -= speed
            End If
        End If
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then
            esquerda = False
        End If
        If e.KeyCode = Keys.Right Then
            direita = False
        End If
        If e.KeyCode = Keys.Up Then
            up = False
        End If
        If e.KeyCode = Keys.Down Then
            down = False
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If obstaculos = True Then
            PictureBox2.Left -= 7
            PictureBox4.Left -= 7
            PictureBox3.Left += 7
            PictureBox8.Left += 7
        End If
        If obstaculos = False Then
            PictureBox2.Left += 7
            PictureBox4.Left += 7
            PictureBox3.Left -= 7
            PictureBox8.Left -= 7
        End If
        If PictureBox2.Location.X > 486 Then
            obstaculos = True
        End If
        If PictureBox2.Location.X < 208 Then
            obstaculos = False
        End If
        For Each picturebox In Me.Controls
            If picturebox IsNot PictureBox1 And picturebox.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                PictureBox1.Location = New Point(123, 280)
            End If
        Next
        If PictureBox1.Bounds.IntersectsWith(Panel1.Bounds) Then
            PictureBox1.Location = New Point(123, 280)
            MessageBox.Show("The Dev Codes is awesome.")
        End If
        For Each panel In Me.Controls
            If PictureBox1.Bounds.IntersectsWith(panel.Bounds) Then
                movimento = False
            Else movimento = True
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
