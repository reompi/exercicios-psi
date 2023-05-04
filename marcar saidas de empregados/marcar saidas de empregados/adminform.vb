Public Class adminform
    Dim ticker As Integer

    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()

        For Each contasempregados As empregado In empregados
            Try
                ListBox1.Items.Add(contasempregados.nome)
            Catch

            End Try
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ticker = 0
        For Each contasempregados As empregado In empregados
            If contasempregados.nome = ListBox1.SelectedItem Then
                usernumero = ticker
                Me.Close()
                adminformuser.Show()
            End If
            ticker += 1

        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        adicionarusersform.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        eliminarusersform.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        login.Show()
    End Sub


End Class