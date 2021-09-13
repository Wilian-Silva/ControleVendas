Public Class FrmNivelAcesso
    Private Sub BtnNivel1_Click(sender As Object, e As EventArgs) Handles BtnNivel1.Click
        Dim form = New FrmNivel1
        form.ShowDialog()
    End Sub

    Private Sub BtnNivel2_Click(sender As Object, e As EventArgs) Handles BtnNivel2.Click
        Dim form = New FrmNivel2
        form.ShowDialog()
    End Sub

    Private Sub BtnNivel3_Click(sender As Object, e As EventArgs) Handles BtnNivel3.Click
        Dim form = New FrmNivel3
        form.ShowDialog()
    End Sub
End Class