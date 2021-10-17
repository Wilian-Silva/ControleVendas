Public Class FrmCupomVenda
    Sub Carregar_relatorio()

        'TODO: esta linha de código carrega dados na tabela 'DataSetCupomVenda.cumpoVenda'. Você pode movê-la ou removê-la conforme necessário.
        Me.cumpoVendaTableAdapter.Fill(Me.DataSetCupomVenda.cumpoVenda, idVenda)
        'TODO: esta linha de código carrega dados na tabela 'DataSetCupomVenda.CupomCompraV2'. Você pode movê-la ou removê-la conforme necessário.
        Me.CupomCompraV2TableAdapter.Fill(Me.DataSetCupomVenda.CupomCompraV2, idVenda)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub FrmCupomVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Carregar_relatorio()
    End Sub
End Class