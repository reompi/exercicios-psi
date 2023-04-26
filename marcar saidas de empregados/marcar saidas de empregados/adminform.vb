Public Class adminform
    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each contasempregados As empregado In empregados
            ListBox1.Items.Add(contasempregados.nome)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class