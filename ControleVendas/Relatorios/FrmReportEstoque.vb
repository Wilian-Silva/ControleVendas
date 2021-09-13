Public Class FrmReportEstoque
    Private Sub FrmReportEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSetEstoque.SaldoEstoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.SaldoEstoqueTableAdapter.Fill(Me.DataSetEstoque.SaldoEstoque)
        'TODO: esta linha de código carrega dados na tabela 'DataSetEstoque.estoque'. Você pode movê-la ou removê-la conforme necessário.
        Me.estoqueTableAdapter.Fill(Me.DataSetEstoque.estoque)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub
End Class