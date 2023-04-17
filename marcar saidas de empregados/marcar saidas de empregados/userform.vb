Public Class userform
    Dim ticker, ticker2 As Integer
    Private Sub entradasbutao_Click(sender As Object, e As EventArgs) Handles entradasbutao.Click
        ticker += 1
        If ticker Mod 2 = 0 Then
            Label1.Text = ("entrada")
            entradasbutao.Image = My.Resources.poweron
            empregados(uesrnumero).quandoentrou(empregados(uesrnumero).dia) = DateTime.Now.ToString
            Label2.Text = empregados(uesrnumero).quandoentrou(empregados(uesrnumero).dia)
            Timer1.Start()
            Label2.Text = ""
        Else
            Label1.Text = ("saída")
            entradasbutao.Image = My.Resources.poweroff
            empregados(uesrnumero).quandosaio(empregados(uesrnumero).dia) = DateTime.Now.ToString
            Label2.Text = empregados(uesrnumero).quandosaio(empregados(uesrnumero).dia)
            Timer1.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ticker2 += 1
        If ticker2 = 30 Then
            Timer1.Stop()
            Label2.Text = ""
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        userformdados.Show()
    End Sub


End Class