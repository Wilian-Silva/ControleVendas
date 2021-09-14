Imports MySql.Data.MySqlClient

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
        If editarDuplicata = "True" Then Exit Sub
        TxtParcela.Text = parcela + 1
        parcela = TxtParcela.Text
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        If editarDuplicata = "Inserir" Then

            'SALVAR ALTERAÇÃO DIRETAMENTE NO BANCO DE DADOS

            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim emissao As String
            Dim vencimento As String

            emissao = DataEmissao.Value.ToString("yyyy-MM-dd")
            vencimento = DataVencimento.Value.ToString("yyyy-MM-dd")

            sqls = "INSERT INTO duplicatas (parcela, documento, data_emissao, data_vencimento, valor_parcela, observacao) VALUES ('" & TxtParcela.Text & "','" & TxtNotaFiscal.Text & "',  '" & emissao & "','" & vencimento & "', '" & TxtTotalDuplicata.Text.Replace(",", ".") & "', '" & TxtObs.Text & "')"
            cmd = New MySqlCommand(sqls, con)
            cmd.ExecuteNonQuery()

            Me.Close()

            Exit Sub
        End If


        If editarDuplicata = "True" Then

            'SALVAR UPDATE DIRETAMENTE NO BANCO DE DADOS
            Dim cmd1 As MySqlCommand
            Dim sqls1 As String
            Dim vencimento As String

            vencimento = DataVencimento.Value.ToString("yyyy-MM-dd")

            sqls1 = "UPDATE duplicatas SET data_vencimento = '" & vencimento & "', valor_parcela = '" & TxtTotalDuplicata.Text.Replace(",", ".") & "', observacao = '" & TxtObs.Text & "' WHERE id = '" & TxtIdREg.Text & "'"
            cmd1 = New MySqlCommand(sqls1, con)
            cmd1.ExecuteNonQuery()

            TxtParcela.Enabled = True
            Me.Close()
            Exit Sub

        End If




        TxtParcela.BackColor = Color.White
        TxtTotalDuplicata.BackColor = Color.White

        If TxtParcela.Text <> "" And TxtTotalDuplicata.Text <> "" Then

                If FrmEntrada.DataGridDuplicatas.Rows.Count < 1 Then

                    Table1Duplicatas.Columns.Add("Id. Reg.")
                    Table1Duplicatas.Columns.Add("Parcela")
                    Table1Duplicatas.Columns.Add("Documento")
                    Table1Duplicatas.Columns.Add("Data Emissão")
                    Table1Duplicatas.Columns.Add("Data Vencimento")
                    Table1Duplicatas.Columns.Add("Valor Parcela")
                    Table1Duplicatas.Columns.Add("Observação")

                    Dim bs As New BindingSource()
                    bs.DataSource = Table1Duplicatas

                    FrmEntrada.DataGridDuplicatas.DataSource = bs

                    Table1Duplicatas.Rows.Add("", TxtParcela.Text, TxtNotaFiscal.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text)
                    Me.Close()

                FrmEntrada.BtnEditar.Enabled = False
                FrmEntrada.BtnEliminar.Enabled = True
                FrmEntrada.BtnEditar.Enabled = True

            Else
                    Table1Duplicatas.Rows.Add("", TxtParcela.Text, TxtNotaFiscal.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text)
                    Me.Close()
                End If
            Else

                TxtParcela.BackColor = Color.Salmon
                TxtTotalDuplicata.BackColor = Color.Salmon
                MsgBox("Campos em branco ou vazios", MsgBoxStyle.Information, "Adicionar duplicatas")
            End If



    End Sub
End Class