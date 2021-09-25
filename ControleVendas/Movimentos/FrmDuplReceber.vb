Imports MySql.Data.MySqlClient

Public Class FrmDuplReceber


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
        If editarDuplicata = "True" Then
            BtnSalvar.Enabled = True
            BtnOk.Enabled = False
            Exit Sub
        End If

        If novaEntrada = "True" Then
            BtnOk.Enabled = True
            BtnSalvar.Enabled = False
            TxtParcela.Text = parcela + 1
            parcela = TxtParcela.Text
        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        TxtParcela.BackColor = Color.White
        TxtTotalDuplicata.BackColor = Color.White
        TxtNotaFiscal.BackColor = Color.White

        If TxtParcela.Text <> "" And TxtTotalDuplicata.Text <> "" And TxtNotaFiscal.Text <> "" Then

            'If FrmEntrada.DataGridDuplicatas.Rows.Count < 1 Then
            If Table1DuplicatasReceber.Columns.Count < 1 Then
                Table1DuplicatasReceber.Columns.Add("Id. Dup.")
                Table1DuplicatasReceber.Columns.Add("Parcela")
                Table1DuplicatasReceber.Columns.Add("Documento")
                Table1DuplicatasReceber.Columns.Add("Data Emissão")
                Table1DuplicatasReceber.Columns.Add("Data Vencimento")
                Table1DuplicatasReceber.Columns.Add("Valor Parcela")
                Table1DuplicatasReceber.Columns.Add("Observação")

                'Dim bs As New BindingSource()
                bs.DataSource = Table1Duplicatas

                'FrmEntrada.DataGridDuplicatas.DataSource = bs

                Table1DuplicatasReceber.Rows.Add("", TxtParcela.Text, TxtNotaFiscal.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text)
                Me.Close()

            Else
                Table1DuplicatasReceber.Rows.Add("", TxtParcela.Text, TxtNotaFiscal.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text)

                Me.Close()
            End If
        Else

            TxtParcela.BackColor = Color.Salmon
            TxtNotaFiscal.BackColor = Color.Salmon
            TxtTotalDuplicata.BackColor = Color.Salmon
            MsgBox("Campos em branco ou vazios", MsgBoxStyle.Information, "Adicionar duplicatas")
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'Stop
        TxtParcela.BackColor = Color.White
        TxtTotalDuplicata.BackColor = Color.White
        TxtNotaFiscal.BackColor = Color.White

        If TxtParcela.Text <> "" And TxtTotalDuplicata.Text <> "" And TxtNotaFiscal.Text <> "" Then
            If MsgBox("Deseja salvar alterações ?", vbYesNo, "Editar duplicatas") = vbYes Then

                If editarDuplicata = "True" Then

                    'SALVAR UPDATE DIRETAMENTE NO BANCO DE DADOS
                    Dim cmd1 As MySqlCommand
                    Dim sqls1 As String
                    Dim vencimento1 As String

                    vencimento1 = DataVencimento.Value.ToString("yyyy-MM-dd")

                    sqls1 = "UPDATE duplicatas SET data_vencimento = '" & vencimento1 & "', valor_parcela = '" & TxtTotalDuplicata.Text.Replace(",", ".") & "', observacao = '" & TxtObs.Text & "' , saldo_duplicata = '" & TxtTotalDuplicata.Text.Replace(",", ".") & "' WHERE id = '" & TxtIdREg.Text & "'"
                    cmd1 = New MySqlCommand(sqls1, con)
                    cmd1.ExecuteNonQuery()


                    editarDuplicata = ""
                    Me.Close()
                    Exit Sub

                Else

                    Dim cmd As MySqlCommand
                    Dim sqls As String
                    Dim emissao As String
                    Dim vencimento As String

                    emissao = DataEmissao.Value.ToString("yyyy-MM-dd")
                    vencimento = DataVencimento.Value.ToString("yyyy-MM-dd")

                    sqls = "INSERT INTO duplicatas (parcela, documento, data_emissao, data_vencimento, valor_parcela, observacao, id_entrada, cod_fornecedor, saldo_duplicata) VALUES ('" & TxtParcela.Text & "','" & TxtNotaFiscal.Text & "',  '" & emissao & "','" & vencimento & "', '" & TxtTotalDuplicata.Text.Replace(",", ".") & "', '" & TxtObs.Text & "' ,'" & TxtIdREg.Text & "', '" & TxtIdFornecedor.Text & "', '" & TxtTotalDuplicata.Text.Replace(",", ".") & "')"
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Me.Close()

                    Exit Sub

                End If


            End If

        Else

            TxtParcela.BackColor = Color.Salmon
            TxtNotaFiscal.BackColor = Color.Salmon
            TxtTotalDuplicata.BackColor = Color.Salmon
            MsgBox("Campos em branco ou vazios", MsgBoxStyle.Information, "Adicionar duplicatas")
        End If
    End Sub
End Class