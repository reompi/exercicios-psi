Public Class calculadora
    Dim numero1 As String = "."
    Dim numero2 As String = "."
    Dim op As Char
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text &= "5"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        op = "+"
        numero1 = TextBox2.Text

        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = TextBox2.Text + "7"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = TextBox2.Text + "1"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox2.Text = TextBox2.Text + "2"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text = TextBox2.Text + "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text &= "4"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox2.Text &= "6"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text &= "8"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox2.Text &= "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox2.Text &= "0"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        op = "-"
        numero1 = TextBox2.Text

        TextBox2.Clear()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        op = "x"
        numero1 = TextBox2.Text

        TextBox2.Clear()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        op = ":"
        numero1 = TextBox2.Text

        TextBox2.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        numero1 = TextBox2.Text


        Select Case op
            Case "+"
                TextBox2.Clear()
                numero1 = numero1 ^ 2
                TextBox2.Text = numero1 + numero2 ^ 2
            Case "x"
                TextBox2.Clear()
                numero1 = numero1 ^ 2
                TextBox2.Text = numero1 * numero2 ^ 2
            Case ":"
                TextBox2.Clear()
                numero1 = numero1 ^ 2
                TextBox2.Text = numero1 / numero2 ^ 2
            Case "-"
                TextBox2.Clear()
                numero1 = numero1 ^ 2
                TextBox2.Text = numero1 - numero2 ^ 2
            Case Else
                TextBox2.Clear()
                numero1 = numero1 ^ 2
                TextBox2.Text = numero1 ^ 2
        End Select


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        numero2 = TextBox2.Text
        Select Case op
            Case "+"
                TextBox2.Text = numero1 + numero2
            Case "x"
                TextBox2.Text = numero1 * numero2
            Case ":"
                TextBox2.Text = numero1 / numero2
            Case "-"
                TextBox2.Text = numero1 - numero2

            Case Else
                numero1 = "."
                numero2 = "."
        End Select
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Clear()
    End Sub
End Class
