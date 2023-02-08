Public Class Form1
    Dim playerX As Integer = 10
    Dim playerY As Integer = 10
    Dim playerSize As Integer = 20
    Dim maze(20, 20) As Integer '2-dimensional array to represent the maze
    '0 = empty space, 1 = wall, 2 = goal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        'Initialize the maze
        For i As Integer = 0 To 19
            For j As Integer = 0 To 19
                If i = 0 Or i = 19 Or j = 0 Or j = 19 Then
                    maze(i, j) = 1 'set outer walls
                Else
                    maze(i, j) = 0 'set empty space
                End If
            Next
        Next
        'Add the goal to the maze
        maze(5, 5) = 2
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        For i As Integer = 0 To 19
            For j As Integer = 0 To 19
                If maze(i, j) = 0 Then
                    e.Graphics.FillRectangle(Brushes.White, i * 20, j * 20, 20, 20)
                ElseIf maze(i, j) = 1 Then
                    e.Graphics.FillRectangle(Brushes.Black, i * 20, j * 20, 20, 20)
                ElseIf maze(i, j) = 2 Then
                    e.Graphics.FillRectangle(Brushes.Green, i * 20, j * 20, 20, 20)
                End If
            Next
        Next
        'draw the player
        e.Graphics.FillEllipse(Brushes.Red, playerX, playerY, playerSize, playerSize)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'handle player movement
        If e.KeyCode = Keys.Up Then
            playerY -= 5
        End If
        If e.KeyCode = Keys.Down Then
            playerY += 5
        End If
        If e.KeyCode = Keys.Left Then
            playerX -= 5
        End If
        If e.KeyCode = Keys.Right Then
            playerX += 5
        End If
        If maze((playerX + playerSize / 2) \ 20, (playerY + playerSize / 2) \ 20) = 2 Then
            'show a message box or transition to the next level
            MessageBox.Show("Congratulations! You have reached the end of the maze.")
        End If
    End Sub
End Class