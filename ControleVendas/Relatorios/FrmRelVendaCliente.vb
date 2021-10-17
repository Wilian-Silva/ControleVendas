Public Class FrmRelVendaCliente

    Private Sub FrmRelVendaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarRelatorio()
    End Sub

    Sub CarregarRelatorio()

        'TODO: esta linha de código carrega dados na tabela 'controle_vendasPorCliente.venda_cliente_data'. Você pode movê-la ou removê-la conforme necessário.
        Me.venda_cliente_dataTableAdapter.Fill(Me.controle_vendasPorCliente.venda_cliente_data, codCliente, dataInicial, dataFinal)
        'TODO: esta linha de código carrega dados na tabela 'controle_vendasPorCliente.duplicatas_cliente_data'. Você pode movê-la ou removê-la conforme necessário.
        Me.duplicatas_cliente_dataTableAdapter.Fill(Me.controle_vendasPorCliente.duplicatas_cliente_data, codCliente, dataInicial, dataFinal)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class