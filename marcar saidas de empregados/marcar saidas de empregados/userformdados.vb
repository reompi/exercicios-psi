Public Class userformdados
    Private Sub userformdados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim diferencamin As Integer
        Dim diferencahoras As Integer
        Dim diferencatotal As Integer


        For x = 1 To 31

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


            If empregados(usernumero).quandosaiohoras(DateTime.Now.Month, x) = 0 And empregados(usernumero).quandosaiominutos(DateTime.Now.Month, x) = 0 Then
                If empregados(usernumero).flag = True And x = Today.Day Then
                    diferencatotal = 60 * DateTime.Now.TimeOfDay.Hours + DateTime.Now.TimeOfDay.Minutes - empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, x) * 60 - empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, x)

                    If diferencatotal < 1440 Then
                        Me.Chart1.Series("minutos").Points.AddXY(x, diferencatotal)
                    Else
                        Me.Chart1.Series("minutos").Points.AddXY(x, 1440)
                    End If
                Else
                    diferencatotal = 60 * diferencahoras + diferencamin
                    Me.Chart1.Series("minutos").Points.AddXY(x, diferencatotal)
                End If
            Else
                If empregados(usernumero).quandosaiohoras(DateTime.Now.Month, x) = 0 Then
                    Me.Chart1.Series("minutos").Points.AddXY(x, diferencamin)
                Else
                    diferencatotal = diferencahoras * 60 + diferencamin
                    Me.Chart1.Series("minutos").Points.AddXY(x, diferencatotal)
                End If


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