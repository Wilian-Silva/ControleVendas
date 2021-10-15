Public Class FrmRelPedido
    Private Sub BtnPesquisarNota_Click(sender As Object, e As EventArgs) Handles BtnPesquisarNota.Click
        pedidoPesquisar = "True"

        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()
    End Sub

    Private Sub FrmRelPedido_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pedidoPesquisar = "True" Then
            TxtPedido.Text = nomePedido
            TxtCodPedido.Text = numeroPedido
            pedidoPesquisar = ""
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnGerar_Click(sender As Object, e As EventArgs) Handles BtnGerar.Click

        Dim form = New FrmReportCompras
        form.ShowDialog()

    End Sub


End Class