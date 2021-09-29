Public Class FrmReportCompras


    Private Sub BtnPesquisarNota_Click(sender As Object, e As EventArgs) Handles BtnPesquisarNota.Click

        pesquisarDuplicata = "True"

        Dim form = New FrmNotasEntrada
        form.ShowDialog()
    End Sub

    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click

        Carregar_realatorio()
        pesquisarDuplicata = ""
        PedidoRelCompra = ""

    End Sub
    Sub Carregar_realatorio()
        Me.DataTableEntradaTableAdapter.Fill(Me.DataSet_ReportCompras.DataTableEntrada, TxtPedido.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub FrmReportCompras_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarDuplicata = "True" Then
            TxtPedido.Text = PedidoRelCompra
        End If

    End Sub
End Class