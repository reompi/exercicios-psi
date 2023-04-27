Public Class adminform
    Public nomeuserselecicionado As String
    Private Sub adminform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each contasempregados As empregado In empregados
            ListBox1.Items.Add(contasempregados.nome)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        For Each contasempregados As empregado In empregados
            If contasempregados.nome = ... Then
                nomeuserselecicionado = contasempregados.nome
            End If
        Next

    End Sub
End Class