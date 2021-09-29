Public Class FrmRelSaldoEstoque
    Private Sub FrmRelSaldoEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DataSet_saldoestoque.produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.produtosTableAdapter.Fill(Me.DataSet_saldoestoque.produtos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class