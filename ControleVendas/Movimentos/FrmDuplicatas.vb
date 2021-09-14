Public Class FrmDuplicatas


    Private Sub BtnEditar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CbQtdDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbQtdDias.SelectedIndexChanged
        Dim dias As Integer
        Dim hoje As Date
        hoje = DataEmissao.Value
        dias = CbQtdDias.Text

        DataVencimento.Value = DateAdd("d", dias, hoje)

    End Sub

    Private Sub FrmDuplicatas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtParcela.Text = parcela + 1
        parcela = TxtParcela.Text
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        'Stop


        TxtParcela.BackColor = Color.White
        TxtTotalDuplicata.BackColor = Color.White

        If TxtParcela.Text <> "" And TxtTotalDuplicata.Text <> "" Then

            If FrmEntrada.DataGridDuplicatas.Rows.Count < 1 Then


                Table1Duplicatas.Columns.Add("Parcela.")
                Table1Duplicatas.Columns.Add("Nota Fiscal")
                Table1Duplicatas.Columns.Add("Data Emissão")
                Table1Duplicatas.Columns.Add("Data Vencimento")
                Table1Duplicatas.Columns.Add("Total Duplicata")
                Table1Duplicatas.Columns.Add("Observação")

                Dim bs As New BindingSource()
                bs.DataSource = Table1Duplicatas

                FrmEntrada.DataGridDuplicatas.DataSource = bs

                Table1Duplicatas.Rows.Add(TxtParcela.Text, TxtNotaFiscal.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text)

            Else
                Table1Duplicatas.Rows.Add(TxtParcela.Text, TxtNotaFiscal.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text)

            End If
        Else

            TxtParcela.BackColor = Color.Salmon
            TxtTotalDuplicata.BackColor = Color.Salmon
            MsgBox("Campos em branco ou vazios", MsgBoxStyle.Information, "Adicionar duplicatas")
        End If

    End Sub
End Class