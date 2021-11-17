Public Class ReportVendasPortador

    Sub Abrir_Relatorio()

        'TODO: esta linha de código carrega dados na tabela 'controle_vendasDataSet_Portador.duplicatas_receber_portador'. Você pode movê-la ou removê-la conforme necessário.
        Me.duplicatas_receber_portadorTableAdapter.Fill(Me.controle_vendasDataSet_Portador.duplicatas_receber_portador, dataInicial, dataFinal, IdPortador)

        Me.ReportViewer1.RefreshReport()

    End Sub


    Private Sub ReportVendasPortador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abrir_Relatorio()

    End Sub
End Class