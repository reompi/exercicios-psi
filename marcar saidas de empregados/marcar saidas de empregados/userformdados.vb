Public Class userformdados
    Private Sub userformdados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim diferencamin As Integer
        Dim diferencahoras As Integer
        Dim diferencatotal As Integer


        For x = 4 To 31

            ReDim Preserve empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, 31)

            ReDim Preserve empregados(usernumero).quandosaiohoras(DateTime.Now.Month, 31)

            ReDim Preserve empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, 31)

            ReDim Preserve empregados(usernumero).quandosaiominutos(DateTime.Now.Month, 31)

            If empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, x) <= empregados(usernumero).quandosaiominutos(DateTime.Now.Month, x) Then
                diferencamin = empregados(usernumero).quandosaiominutos(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, x)
                diferencahoras = empregados(usernumero).quandosaiohoras(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, x)
            Else
                diferencamin = (empregados(usernumero).quandosaiominutos(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, x)) * -1
                diferencahoras = empregados(usernumero).quandosaiohoras(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, x) - 1
            End If
            diferencatotal = 60 * diferencahoras + diferencamin

            If diferencahoras = 0 Then
                If diferencamin < 0 Then
                    Me.Chart1.Series("minutos").Points.AddXY(x, DateTime.Now.TimeOfDay.Minutes - diferencamin)
                Else
                    Me.Chart1.Series("minutos").Points.AddXY(x, diferencamin)
                End If

            Else
                Me.Chart1.Series("minutos").Points.AddXY(x, diferencatotal)
            End If
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        userform.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        login.Show()
    End Sub
End Class