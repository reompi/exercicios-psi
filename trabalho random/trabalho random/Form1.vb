Public Class Form1
    Dim rmd As New Random
    Dim numero As Integer
    Dim total, max, min, media As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        min = 101
        max = 0
        total = 0
        media = 0
        For i = 1 To 100

            numero = rmd.Next(1, 101)
            total += numero
            If max < numero Then
                max = numero
            End If
            If min > numero Then
                min = numero
            End If
            media = total / 100
            TextBox1.Text &= i & " - " & numero & vbNewLine
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Totalbutao.Checked Then
            TextBox2.Text &= "total - " & total & vbNewLine
        End If
        If CheckBox1.Checked Then
            TextBox2.Text &= "minimo - " & min & vbNewLine
        End If
        If CheckBox2.Checked Then
            TextBox2.Text &= "maximo - " & max & vbNewLine
        End If
        If CheckBox3.Checked Then
            TextBox2.Text &= "media - " & media & vbNewLine
        End If

    End Sub
End Class
