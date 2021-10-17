Public Class FrmPesqCupom
    Private Sub BtnGerar_Click(sender As Object, e As EventArgs) Handles BtnGerar.Click
        Dim form = New FrmCupomVenda
        form.ShowDialog()
    End Sub

    Private Sub FrmPesqCupom_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If cumpomPesquisar = "True" Then
            TxtCliente.Text = nomeCliente
            TxtIdVenda.Text = idVenda
            cumpomPesquisar = ""

        End If
    End Sub

    Private Sub BtnPesquisarNota_Click(sender As Object, e As EventArgs) Handles BtnPesquisarNota.Click
        cumpomPesquisar = "True"

        Dim form = New FrmVendaCabecalho
        form.ShowDialog()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class