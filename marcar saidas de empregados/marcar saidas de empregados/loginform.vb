Public Class login
    Dim flag As Boolean
    Dim ticker As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        flag = True
        ticker = 0
        For Each contasempregados As empregado In empregados

            If contasempregados.nome = utilizador.Text And contasempregados.palavrapasse = password.Text Then
                usernumero = ticker
                Me.Hide()
                userform.Show()
                flag = False
            End If
            ticker += 1
        Next
        For Each contasadmin As admins In admin
            If contasadmin.nome = utilizador.Text And contasadmin.palavrapasse = password.Text Then
                usernumero = ticker
                Me.Hide()
                adminform.Show()
                flag = False
            End If
            ticker += 1
        Next
        If flag = True Then
            MessageBox.Show("nome de utilizador ou palavrapasse inválida")

        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empregados(0).nome = ("joao")
        empregados(0).palavrapasse = ("oreo")

        admin(0).nome = "maria"
        admin(0).palavrapasse = "pintas"
    End Sub
End Class
