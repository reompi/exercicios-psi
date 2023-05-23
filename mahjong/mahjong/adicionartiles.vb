Public Class adicionartiles

    Dim tiles(9, 7) As PictureBox
    Sub criarpicturebox()
        ReDim tiles(9, 7)
        Dim ticker As Integer = 0

        For y As Integer = 0 To 7
            For x As Integer = 0 To 9
                Me.tiles(x, y) = New PictureBox()
                With Me.tiles(x, y)
                    .Top = (135 + y * 50)
                    .Left = (60 + x * 100)
                    .Name = "PictureBox" & ticker
                    .Size = New System.Drawing.Size(100, 50)
                    .TabIndex = 0
                    .TabStop = False
                End With

                Form1.Controls.Add(tiles(x, y))
                ticker += 1
            Next
        Next

    End Sub

End Class
