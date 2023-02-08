Imports System.ComponentModel
Imports System.Drawing

Public Class Form1

    Dim GR As System.Random = New System.Random
    Dim G As Graphics
    Dim BBG As Graphics
    Dim BB As Bitmap
    Dim r As Rectangle
    Dim ts As Integer = 28
    Dim P1 As New Player


    Dim isGameOver As Boolean = False
    Dim score As Integer = 0

    'is running
    Dim isRunning As Boolean = True
    'fps
    Dim tSec As Integer = TimeOfDay.Second
    Dim tTicks As Integer = 60
    Dim maxTicks As Integer = 60

    'food
    Dim foodx As Integer
    Dim foody As Integer

    Public Class Player
        Public x As Integer
        Public y As Integer
        Public moveDirection As String
        Private canChangeDirection As Boolean
        Dim Generator As System.Random = New System.Random()
        Public snakeParts As New LinkedList(Of SnakePart)

        Sub New()
            setRandomPosition()
            moveDirection = "stop"
            canChangeDirection = True
        End Sub


        Sub setRandomPosition()
            Dim randomX As Integer = generateRandomNumber(1, 14) * 30
            Dim randomY As Integer = generateRandomNumber(1, 14) * 30
            x = randomX
            y = randomY
        End Sub

        Sub Draw(ByVal G As Graphics)
            G.FillRectangle(Brushes.DarkGreen, Me.x, Me.y, 28, 28)
            For Each sp In snakeParts
                G.FillRectangle(Brushes.Green, sp.X, sp.Y, 28, 28)
            Next sp

        End Sub

        Public Function generateRandomNumber(ByVal a As Integer, ByVal b As Integer) As Integer
            Return Generator.Next(a, b + 1)
        End Function

        Sub Move()

            Select Case moveDirection
                Case "up"
                    y = y - 30
                Case "down"
                    y = y + 30
                Case "right"
                    x = x + 30
                Case "left"
                    x = x - 30

            End Select



            For Each sp In snakeParts
                Select Case sp.direction
                    Case "up"
                        sp.Y = sp.Y - 30
                    Case "down"
                        sp.Y = sp.Y + 30
                    Case "right"
                        sp.X = sp.X + 30
                    Case "left"
                        sp.X = sp.X - 30

                End Select
            Next sp


            canChangeDirection = True
            'change directions

            Dim cur As LinkedListNode(Of SnakePart) = snakeParts.Last
            If cur IsNot Nothing Then
                Do Until cur.Previous Is Nothing
                    cur.Value.direction = cur.Previous.Value.direction
                    cur = cur.Previous
                Loop
            End If

            Dim frst As LinkedListNode(Of SnakePart) = snakeParts.First
            If frst IsNot Nothing Then
                frst.Value.direction = moveDirection
            End If


        End Sub

        Sub changeDirection(ByVal d As String)

            If canChangeDirection = True Then
                canChangeDirection = False
                moveDirection = d

            End If

        End Sub

    End Class

    Public Class SnakePart
        Public direction As String = "stop"
        Public X As Integer
        Public Y As Integer
        Sub New(ByVal d As String, ByVal x As Integer, ByVal y As Integer)
            Me.direction = d
            Me.X = x
            Me.Y = y
        End Sub

    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Show()
        Me.Focus()

        G = Me.CreateGraphics
        BBG = Me.CreateGraphics
        BB = New Bitmap(Me.Width, Me.Height)


        spawnFood()

        StartGameLoop()


    End Sub

    Private Sub StartGameLoop()
        Dim t2 As Integer = 0
        Do While isRunning = True
            Application.DoEvents()
            If isGameOver = False Then
                DrawGraphics()
                checkCollisions()
                t2 = t2 + 1
                If t2 > (maxTicks / 6) Then
                    P1.Move()
                    t2 = 0
                End If
            Else
                DrawGraphics()

                If MessageBox.Show("GameOver", "deseja continuar", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    restartGame()


                Else
                    isRunning = False
                    Me.Close()
                End If

            End If

                tickCounter()
        Loop
    End Sub

    Private Sub DrawGraphics()
        'draw blocks
        For x As Integer = 0 To 480 Step 30
            For y As Integer = 0 To 480 Step 30
                If x = 0 Or y = 0 Or x = 480 Or y = 480 Then
                    G.FillRectangle(Brushes.Silver, x, y, ts, ts)
                Else
                    G.FillRectangle(Brushes.LightGreen, x, y, ts, ts)
                End If

            Next y
        Next x

        P1.Draw(G)

        G.FillRectangle(Brushes.OrangeRed, foodx, foody, ts, ts)
        G.DrawString("pontos: " & score.ToString, Me.Font, Brushes.Green, 550, 10)
        If isGameOver = True Then

            G.DrawString("O JOGO ACABOU!", Me.Font, Brushes.Red, 550, 40)
        End If
        G = Graphics.FromImage(BB)

        BBG.DrawImage(BB, 0, 0, Me.Width, Me.Height)
        'clear
        G.Clear(Color.White)
    End Sub

    Private Sub spawnFood()
        Dim randomx As Integer = P1.generateRandomNumber(1, 14) * 30
        Dim randomy As Integer = P1.generateRandomNumber(1, 14) * 30
        For Each p In P1.snakeParts
            If (p.X = randomx And p.Y = randomy) Or (P1.x = randomx And P1.y = randomy) Then
                spawnFood()
                Return
            End If
        Next p
        foodx = randomx
        foody = randomy

    End Sub

    Private Sub checkCollisions()
        For Each part In P1.snakeParts
            If P1.x = part.X And P1.y = part.Y Then
                isGameOver = True
            End If
        Next part

        If P1.x < 30 Or P1.x > 450 Or P1.y < 30 Or P1.y > 450 Then
            isGameOver = True
        End If

        If P1.x = foodx And P1.y = foody Then
            score = score + 1
            spawnFood()
            Dim newPartX As Integer
            Dim newPartY As Integer
            Dim lastPartX As Integer = P1.x
            Dim lastPartY As Integer = P1.y
            Dim lastDirection As String = P1.moveDirection
            If P1.snakeParts.Count > 0 Then
                lastPartX = P1.snakeParts.Last.Value.X
                lastPartY = P1.snakeParts.Last.Value.Y
                lastDirection = P1.snakeParts.Last.Value.direction
            End If


            Select Case lastDirection
                Case "up"
                    newPartX = lastPartX
                    newPartY = lastPartY + 30
                Case "down"
                    newPartX = lastPartX
                    newPartY = lastPartY - 30
                Case "left"
                    newPartX = lastPartX + 30
                    newPartY = lastPartY
                Case "right"
                    newPartX = lastPartX - 30
                    newPartY = lastPartY

            End Select
            Dim sp As New SnakePart(lastDirection, newPartX, newPartY)
            P1.snakeParts.AddLast(sp)

        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If P1.moveDirection <> "down" Then
                    P1.changeDirection("up")
                End If
            Case Keys.Down
                If P1.moveDirection <> "up" Then
                    P1.changeDirection("down")
                End If
            Case Keys.Left
                If P1.moveDirection <> "right" Then
                    P1.changeDirection("left")
                End If
            Case Keys.Right
                If P1.moveDirection <> "left" Then
                    P1.changeDirection("right")
                End If
            Case Keys.F1
                restartGame()
            Case Keys.Escape
                isRunning = False
        End Select
    End Sub

    Private Sub restartGame()
        score = 0
        P1.moveDirection = "stop"
        P1.snakeParts.Clear()
        P1.setRandomPosition()

        isGameOver = False
    End Sub

    Private Sub tickCounter()
        If tSec = TimeOfDay.Second And isRunning = True Then
            tTicks = tTicks + 1
        Else
            maxTicks = tTicks
            tTicks = 0
            tSec = TimeOfDay.Second
        End If
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        G.Dispose()
        BBG.Dispose()
        BB.Dispose()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If isRunning = True Then
            isRunning = False
            e.Cancel = True

        End If
    End Sub
End Class