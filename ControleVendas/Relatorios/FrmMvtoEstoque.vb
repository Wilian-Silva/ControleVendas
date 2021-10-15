Public Class FrmMvtoEstoque
    Private Sub FrmMvtoEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Abrir_Relatorio()

    End Sub

    Sub Abrir_Relatorio()

        'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSetEstoque.estoque_data'. Você pode movê-la ou removê-la conforme necessário.
        Me.estoque_dataTableAdapter.Fill(Me.controle_vendasDataSetEstoque.estoque_data, dataInicial, dataFinal)

        Me.ReportViewer1.RefreshReport()
    End Sub



End Class