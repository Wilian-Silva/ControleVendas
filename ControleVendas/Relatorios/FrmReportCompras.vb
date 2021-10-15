Public Class FrmReportCompras

    Sub Carregar_realatorio()
        Me.DataTableEntradaTableAdapter.Fill(Me.DataSet_ReportCompras.DataTableEntrada, nomePedido)
        Me.ReportViewer1.RefreshReport()

    End Sub
    Private Sub FrmReportCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Carregar_realatorio()
        nomePedido = ""
        numeroPedido = ""
    End Sub
End Class