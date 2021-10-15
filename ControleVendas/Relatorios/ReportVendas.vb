Public Class ReportVendas

    Sub Abrir_Relatorio()


        'TODO: esta linha de código carrega dados na tabela 'DataSet_ReportVendas.DataSet_venda'. Você pode movê-la ou removê-la conforme necessário.
        Me.DataSet_vendaTableAdapter.Fill(Me.DataSet_ReportVendas.DataSet_venda, dataInicial, dataFinal)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abrir_Relatorio()
    End Sub
End Class