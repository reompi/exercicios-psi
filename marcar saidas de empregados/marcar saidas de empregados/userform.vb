
Public Class userform
    Dim dianterior As Integer
    Dim ticker, ticker2 As Integer
    Dim flag As Boolean
    Private Sub entradasbutao_Click(sender As Object, e As EventArgs) Handles entradasbutao.Click

        If flag = False And dianterior = DateTime.Now.Day Then
            Exit Sub
        End If

        dianterior = DateTime.Now.Day
        ReDim Preserve empregados(usernumero).quandoentrou(DateTime.Now.Month, DateTime.Now.Day)
        ReDim Preserve empregados(usernumero).quandosaio(DateTime.Now.Month, DateTime.Now.Day)
        ticker += 1
        If ticker Mod 2 = 0 Then
            Label1.Text = ("entrada")
            entradasbutao.Image = My.Resources.poweron
            empregados(usernumero).quandoentrou(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.ToString
            Label2.Text = empregados(usernumero).quandoentrou(DateTime.Now.Month, DateTime.Now.Day)
            Timer1.Start()
            ticker2 = 0
            flag = True
        Else
            Label1.Text = ("saída")
            entradasbutao.Image = My.Resources.poweroff
            empregados(usernumero).quandosaio(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.ToString
            Label2.Text = empregados(usernumero).quandosaio(DateTime.Now.Month, DateTime.Now.Day)
            Timer1.Start()
            ticker2 = 0
            flag = False

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ticker2 += 1
        If ticker2 = 15 Then
            Timer1.Stop()
            Label2.Text = ""
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        userformdados.Show()
    End Sub


End Class