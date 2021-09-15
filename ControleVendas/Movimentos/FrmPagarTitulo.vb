Public Class FrmPagarTitulo
    Private Sub BtnBaixarTitulo_Click(sender As Object, e As EventArgs) Handles BtnBaixarTitulo.Click
        Dim form = New FrmVlrPgto
        form.ShowDialog()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmPagarTitulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDadosTitulo

    End Sub

    Private Sub CarregarDadosTitulo()

    End Sub
End Class