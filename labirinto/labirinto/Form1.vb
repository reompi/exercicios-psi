Public Class Form1
    Dim m As Integer
    Dim randomNumber As Random
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create new maze
        Dim grid As Object

        For c As Integer = 0 To m - 1
            ReDim grid.Cells(c)(m - 1)
        Next

        For c As Integer = 0 To grid.Cells.GetUpperBound(0)
            For r As Integer = 0 To grid.Cells(0).GetUpperBound(0)
                grid.Cells(c)(r).visited = False
                grid.Cells(c)(r).NorthWall = True
                grid.Cells(c)(r).SouthWall = True
                grid.Cells(c)(r).WestWall = True
                grid.Cells(c)(r).EastWall = True
            Next
        Next

        'Stop

        Dim maze As New List(Of Point)

        Dim unvisited As Integer = m ^ 2

        grid.startPoint = New Point(randomNumber.Next(0, m), m - 1)

        grid.Cells(grid.startPoint.X)(m - 1).SouthWall = False
        maze.Add(New Point(grid.startPoint.X, m - 1))
        unvisited -= 1

        While unvisited > 0
            Dim p As Point = maze(randomNumber.Next(0, maze.Count))
            Dim choice As New List(Of Point)
            If p.X > 0 And p.X < m - 1 Then 'c
                If p.Y > 0 And p.Y < m - 1 Then 'r
                    choice.AddRange(New Point() {New Point(p.X - 1, p.Y), New Point(p.X, p.Y - 1), New Point(p.X + 1, p.Y), New Point(p.X, p.Y + 1)}) 'l,t,r,b
                ElseIf p.Y = 0 Then
                    choice.AddRange(New Point() {New Point(p.X - 1, p.Y), New Point(p.X + 1, p.Y), New Point(p.X, p.Y + 1)}) 'l,r,b
                ElseIf p.Y = m - 1 Then
                    choice.AddRange(New Point() {New Point(p.X - 1, p.Y), New Point(p.X, p.Y - 1), New Point(p.X + 1, p.Y)}) 'l,t,r
                End If
            ElseIf p.X = 0 Then 'c
                If p.Y > 0 And p.Y < m - 1 Then 'c
                    choice.AddRange(New Point() {New Point(p.X, p.Y - 1), New Point(p.X + 1, p.Y), New Point(p.X, p.Y + 1)}) 't,r,b
                ElseIf p.Y = 0 Then
                    choice.AddRange(New Point() {New Point(p.X + 1, p.Y), New Point(p.X, p.Y + 1)}) 'r,b
                ElseIf p.Y = m - 1 Then
                    choice.AddRange(New Point() {New Point(p.X, p.Y - 1), New Point(p.X + 1, p.Y)}) 't,r
                End If
            ElseIf p.X = m - 1 Then 'c
                If p.Y > 0 And p.Y < m - 1 Then
                    choice.AddRange(New Point() {New Point(p.X - 1, p.Y), New Point(p.X, p.Y - 1), New Point(p.X, p.Y + 1)}) 'l,t,b
                ElseIf p.Y = 0 Then
                    choice.AddRange(New Point() {New Point(p.X - 1, p.Y), New Point(p.X, p.Y + 1)}) 'l,b
                ElseIf p.Y = m - 1 Then
                    choice.AddRange(New Point() {New Point(p.X - 1, p.Y), New Point(p.X, p.Y - 1)}) 'l,t
                End If

            End If
            choice.RemoveAll(Function(pt) grid.Cells(pt.X)(pt.Y).visited)


            If choice.Count = 0 Then Continue While
            Dim p2 As Point = choice(randomNumber.Next(0, choice.Count))
            If p.X = p2.X And p2.Y < p.Y Then
                If grid.Cells(p.X)(p.Y).NorthWall Then
                    grid.Cells(p.X)(p.Y).NorthWall = False
                    grid.Cells(p2.X)(p2.Y).SouthWall = False
                    grid.Cells(p2.X)(p2.Y).visited = True
                    unvisited -= 1
                    maze.Add(New Point(p2.X, p2.Y))
                Else
                    Continue While
                End If
            ElseIf p.X = p2.X And p2.Y > p.Y Then
                If grid.Cells(p.X)(p.Y).SouthWall Then
                    grid.Cells(p.X)(p.Y).SouthWall = False
                    grid.Cells(p2.X)(p2.Y).NorthWall = False
                    grid.Cells(p2.X)(p2.Y).visited = True
                    unvisited -= 1
                    maze.Add(p2)
                Else
                    Continue While
                End If
            ElseIf p.X > p2.X And p2.Y = p.Y Then
                If grid.Cells(p.X)(p.Y).WestWall Then
                    grid.Cells(p.X)(p.Y).WestWall = False
                    grid.Cells(p2.X)(p2.Y).EastWall = False
                    grid.Cells(p2.X)(p2.Y).visited = True
                    unvisited -= 1
                    maze.Add(p2)
                Else
                    Continue While
                End If
            ElseIf p.X < p2.X And p2.Y = p.Y Then
                If grid.Cells(p.X)(p.Y).EastWall Then
                    grid.Cells(p.X)(p.Y).EastWall = False
                    grid.Cells(p2.X)(p2.Y).WestWall = False
                    grid.Cells(p2.X)(p2.Y).visited = True
                    unvisited -= 1
                    maze.Add(p2)
                Else
                    Continue While
                End If
            End If

        End While
    End Sub

End Class
