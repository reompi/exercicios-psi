Public Class userformdados
    Private Sub userformdados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim diferenca As Integer


        For x = 21 To 31
            diferenca = empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, x) - empregados(usernumero).quandosaiohoras(DateTime.Now.Month, x)
            Me.Chart1.Series("tempo").Points.AddXY(x, diferenca)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        userform.Show()
    End Sub
End Class