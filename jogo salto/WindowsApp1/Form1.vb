Public Class Form1
    Public personagem As New player
    Public x As Integer = 644
    Public y As Integer = 642
    Public movedirection As String = ""
    Public salto As Boolean

    Dim conteiro As Integer = 70
    Public Class player

        Sub move()



            Select Case Form1.movedirection

                Case "right"
                    Form1.x = Form1.x + 50
                    If Form1.salto = True Then
                        Form1.jump.Start()
                    End If
                Case "left"
                    Form1.x = Form1.x - 50
                    If Form1.salto = True Then
                        Form1.jump.Start()
                    End If
            End Select
            Form1.PictureBox1.Location = New Point(Form1.x, Form1.y)


        End Sub
    End Class

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        personagem.move()
        conteiro = conteiro - 1
        Label1.Text = conteiro
        'If conteiro < 1 Then
        '    '  Me.Hide()
        '    'form2.show
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conteiro As Integer = 70
        Timer1.Start()
        '  StartGameLoop()
    End Sub

    'Sub StartGameLoop()
    '    '    Application.DoEvents()

    '    Do
    '        personagem.move()
    'End Sub
    '    Loop

    Private Sub jump_Tick(sender As Object, e As EventArgs) Handles jump.Tick
        Dim conteiro As Integer = 0
        conteiro = conteiro + 1
        If movedirection = "Right" Then
            If conteiro <= 8 Then
                y = y + 400
                x = x + 100
            ElseIf conteiro > 8 And conteiro <= 16 Then
                y = y - 400
                x = x - 100
            Else
                jump.Stop()
            End If
        End If
        PictureBox1.Location = New Point(x, y)

    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                movedirection = "Right"


            Case Keys.Left
                movedirection = "Left"

            Case Keys.W
                salto = True
        End Select
    End Sub
    Sub checkCollisions()

    End Sub
End Class

