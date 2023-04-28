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

            ReDim Preserve empregados(UBound(empregados) + 1)

            empregados(UBound(empregados)).nome = nome.Text

            empregados(UBound(empregados)).palavrapasse = passe.Text

        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

End Class