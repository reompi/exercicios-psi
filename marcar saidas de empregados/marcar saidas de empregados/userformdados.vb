Public Class userformdados
    Private Sub userformdados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim diferencamin As Integer
        Dim difencahoras As Integer
        Dim diferencatotal As Integer


        For x = 26 To 31
            If empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, x) <= empregados(usernumero).quandosaiominutos(DateTime.Now.Month, x) Then
                diferencamin = empregados(usernumero).quandosaiominutos(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, x)
                difencahoras = empregados(usernumero).quandosaiohoras(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, x)
            Else
                diferencamin = (empregados(usernumero).quandosaiominutos(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouminutos(DateTime.Now.Month, x)) * -1
                difencahoras = empregados(usernumero).quandosaiohoras(DateTime.Now.Month, x) - empregados(usernumero).quandoentrouhoras(DateTime.Now.Month, x) - 1
            End If
            diferencatotal = difencahoras + diferencamin / 100


            Me.Chart1.Series("tempo").Points.AddXY(x, diferencatotal)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        userform.Show()
    End Sub
End Class