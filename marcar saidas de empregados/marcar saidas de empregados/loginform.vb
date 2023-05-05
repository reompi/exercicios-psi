Public Class login
    Dim flag As Boolean
    Dim ticker As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        flag = True
        ticker = 0
        For Each contasempregados As empregado In empregados

            If contasempregados.nome = utilizador.Text And contasempregados.palavrapasse = password.Text Then
                usernumero = ticker
                Me.Hide()
                userform.Show()
                flag = False
            End If
            ticker += 1
        Next
        For Each contasadmin As admins In admin
            If contasadmin.nome = utilizador.Text And contasadmin.palavrapasse = password.Text Then
                usernumero = ticker
                Me.Hide()
                adminform.Show()
                flag = False
            End If
            ticker += 1
        Next
        If flag = True Then
            MessageBox.Show("nome de utilizador ou palavrapasse inválida")

        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case DateTime.Now.Month
            Case 1
                quantosdiastemes = 31
            Case 2
                quantosdiastemes = 28
            Case 3
                quantosdiastemes = 31
            Case 4
                quantosdiastemes = 30
            Case 5
                quantosdiastemes = 31
            Case 6
                quantosdiastemes = 30
            Case 7
                quantosdiastemes = 31
            Case 8
                quantosdiastemes = 31
            Case 9
                quantosdiastemes = 30
            Case 10
                quantosdiastemes = 31
            Case 11
                quantosdiastemes = 30
            Case 12
                quantosdiastemes = 31

        End Select
        ReDim empregados(0)
        ReDim admin(0)

        empregados(0).nome = ("joao")
        empregados(0).palavrapasse = ("oreo")

        admin(0).nome = "maria"
        admin(0).palavrapasse = "pintas"

        For Each empregado As empregado In empregados
            ReDim Preserve empregado.quandoentrouhoras(DateTime.Now.Month, quantosdiastemes)
            ReDim Preserve empregado.quandoentrouhoras(DateTime.Now.Month, quantosdiastemes)
            ReDim Preserve empregado.quandosaiominutos(DateTime.Now.Month, quantosdiastemes)
            ReDim Preserve empregado.quandoentrouminutos(DateTime.Now.Month, quantosdiastemes)
            ReDim Preserve empregado.quandosaiohoras(DateTime.Now.Month, quantosdiastemes)
        Next

    End Sub



End Class