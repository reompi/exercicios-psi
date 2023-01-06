Public Class Form1
    Dim rmd As New Random
    Dim numero1, numero2, numero3, numero4, certo, pcerto, tentativas As String

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBox3.MaxLength = 1
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.MaxLength = 1
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TextBox4.MaxLength = 1
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.MaxLength = 1
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tentativas < 10 Then

            tentativas += 1
            Label3.Text = "tentativas : " & tentativas & " / 10"
            certo = 0
            pcerto = 0
            If TextBox1.Text = numero1 Or numero1 = TextBox2.Text Or numero1 = TextBox3.Text Or numero1 = TextBox4.Text Then
                certo += 1
            End If
            If TextBox1.Text = numero2 Or numero2 = TextBox2.Text Or numero2 = TextBox3.Text Or numero2 = TextBox4.Text Then
                certo += 1
            End If
            If TextBox1.Text = numero3 Or numero3 = TextBox2.Text Or numero3 = TextBox3.Text Or numero3 = TextBox4.Text Then
                certo += 1
            End If
            If TextBox1.Text = numero4 Or numero4 = TextBox2.Text Or numero4 = TextBox3.Text Or numero4 = TextBox4.Text Then
                certo += 1
            End If
            If TextBox1.Text = numero1 Then
                pcerto += 1
            End If
            If TextBox4.Text = numero2 Then
                pcerto += 1
            End If
            If TextBox3.Text = numero3 Then
                pcerto += 1
            End If
            If TextBox2.Text = numero4 Then
                pcerto += 1
            End If
            If pcerto = 4 Then
                Label1.Text = "Ganhou! Acertou os 4 números na posição correta"
            Else
                Label1.Text = certo & " número/s corretos e " & pcerto & " número/s na posição certa"
            End If
        Else
            Label1.Text = "Perdeu! acabaram as 10 tentativas"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do
            numero1 = rmd.Next(1, 10)
        Loop Until numero1 <> numero2 And numero1 <> numero3 And numero1 <> numero4
        Do
            numero2 = rmd.Next(1, 10)
        Loop Until numero2 <> numero1 And numero2 <> numero3 And numero2 <> numero4
        Do
            numero3 = rmd.Next(1, 10)
        Loop Until numero3 <> numero2 And numero3 <> numero1 And numero3 <> numero4
        Do
            numero4 = rmd.Next(1, 10)
        Loop Until numero4 <> numero3 And numero4 <> numero2 And numero4 <> numero1
        Label2.Text = numero4 + numero3 * 10 + numero2 * 100 + numero1 * 1000
        Label3.Text = "tentativas : 0 / 10"
        '  Panel1.Hide()
    End Sub
End Class
