Public Class adicionarusersform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each empregado As empregado In empregados

            If nome.Text = empregado.nome Then
                MessageBox.Show("nome já utilizado")
                Exit Sub
            End If
            If passe.Text <> confirmarpasse.Text Then
                MessageBox.Show("palavras passes diferentes")
                Exit Sub
            End If
        Next
        ReDim Preserve empregados(UBound(empregados) + 1)

        ReDim Preserve empregados(UBound(empregados)).quandoentrouhoras(DateTime.Now.Month, 31)
            ReDim Preserve empregados(UBound(empregados)).quandosaiominutos(DateTime.Now.Month, 31)
            ReDim Preserve empregados(UBound(empregados)).quandoentrouminutos(DateTime.Now.Month, 31)
            ReDim Preserve empregados(UBound(empregados)).quandosaiohoras(DateTime.Now.Month, 31)


            empregados(UBound(empregados)).nome = nome.Text

            empregados(UBound(empregados)).palavrapasse = passe.Text


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        eliminarusersform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        adminform.Show()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        login.Show()
    End Sub


End Class