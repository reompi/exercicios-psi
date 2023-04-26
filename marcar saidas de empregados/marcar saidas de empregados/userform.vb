
Public Class userform
    Dim dianterior As Integer
    Dim ticker, ticker2 As Integer
    Dim flag As Boolean = True
    Private Sub entradasbutao_Click(sender As Object, e As EventArgs) Handles entradasbutao.Click

        If flag = False And dianterior = DateTime.Now.Day Then
            Exit Sub
        End If

        dianterior = DateTime.Now.Day


        If ticker Mod 2 = 0 Then
            Label1.Text = ("saída")
            entradasbutao.Image = My.Resources.poweroff
            empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Hours
            empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Minutes
            Label2.Text = empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, DateTime.Now.Day).ToString & " : " & empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, DateTime.Now.Day)
            Timer1.Start()
            ticker2 = 0
            flag = True
        Else
            Label1.Text = ("entrada")
            entradasbutao.Image = My.Resources.poweron
            empregados(usernumero).quandosaiohoras(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Hours
            empregados(usernumero).quandosaiominutos(DateTime.Now.Month, DateTime.Now.Day) = DateTime.Now.TimeOfDay.Minutes
            Label2.Text = empregados(usernumero).quandosaiohoras(DateTime.Now.Month, DateTime.Now.Day).ToString & " : " & empregados(usernumero).quandosaiominutos(DateTime.Now.Month, DateTime.Now.Day)
            Timer1.Start()
            ticker2 = 0
            flag = False

        End If
        ticker += 1
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ticker2 += 1
        If ticker2 = 15 Then
            Timer1.Stop()
            Label2.Text = ""
        End If
    End Sub

    Private Sub userform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim Preserve empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, 31)
        ReDim Preserve empregados(usernumero).quandosaiominutos(DateTime.Now.Month, 31)
        ReDim Preserve empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, 31)
        ReDim Preserve empregados(usernumero).quandosaiohoras(DateTime.Now.Month, 31)
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        userformdados.Show()
    End Sub


End Class