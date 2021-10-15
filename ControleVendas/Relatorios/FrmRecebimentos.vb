Public Class FrmRecebimentos


    Sub Abrir_Relatorio()

        'TODO: esta linha de código carrega dados na tabela 'DataSetRecebimentos.mvto_recebimentos1'. Você pode movê-la ou removê-la conforme necessário.
        Me.mvto_recebimentos1TableAdapter.Fill(Me.DataSetRecebimentos.mvto_recebimentos1, dataInicial, dataFinal)

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub FrmRecebimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Abrir_Relatorio()

    End Sub
End Class