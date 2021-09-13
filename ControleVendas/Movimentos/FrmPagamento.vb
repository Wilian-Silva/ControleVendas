Imports MySql.Data.MySqlClient

Public Class FrmPagamento
    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        BuscarNota()
        If TxtIdNota.Text <> "" Then
            BtndAdicionarItem.Enabled = True
        End If
    End Sub

    Sub BuscarNota()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            If TxtIdNota.Text <> "" Then
                Abrir()

                Dim cmd As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql As String
                Dim saldo As Decimal
                sql = "SELECT * FROM entrada WHERE id = '" & TxtIdNota.Text & "' "
                cmd = New MySqlCommand(Sql, con)
                reader = cmd.ExecuteReader

                If reader.Read = True Then

                    If reader(8) <= 0 Then

                        MsgBox("Nota totalmente paga!!", MsgBoxStyle.Information, "Pagamento")
                        reader.Close()
                        Exit Sub

                    End If

                    TxtNota.Text = reader(1)
                    TxtFornecedor.Text = reader(2)
                    TxtPedido.Text = reader(3)
                    DataEmissao.Value = reader(5)
                    DataVencimento.Value = reader(6)
                    TxtValorNota.Text = reader(8)
                    TxtPrincipal.Text = reader(8)
                    saldo = reader(8)
                    reader.Close()
                End If


            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub BtnPesqNota_Click(sender As Object, e As EventArgs) Handles BtnPesqNota.Click
        Dim form = New FrmNotasEntrada
        form.ShowDialog()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmPagamento_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtIdNota.Text = idNota
    End Sub

    Private Sub FrmPagamento_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        idNota = ""
    End Sub

    Private Sub BtndAdicionarItem_Click(sender As Object, e As EventArgs) Handles BtndAdicionarItem.Click


        On Error Resume Next

        TxtTotalPago.Text = CDbl(TxtPrincipal.Text) + CDbl(TxtJuros.Text) - CDbl(TxtDesconto.Text)
        TxtSaldoNota.Text = CDbl(TxtValorNota.Text) - CDbl(TxtPrincipal.Text)
        BtnSalvar.Enabled = True
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click


        If TxtIdNota.Text <> "" And TxtNota.Text <> "" And TxtPrincipal.Text <> "0" Then
            Abrir()
            'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim data0 As String
            Dim data1 As String
            Dim data2 As String
            Dim data3 As String

            data0 = Now().ToString("yyyy-MM-dd")
            data1 = DataEmissao.Value.ToString("yyyy-MM-dd")
            data2 = DataVencimento.Value.ToString("yyyy-MM-dd")
            data3 = DataPgto.Value.ToString("yyyy-MM-dd")

            sqls = "INSERT INTO mvto_pagamentos (nota, fornecedor, pedido, data_registro, emissao, vencimento, valor, id_nota, data_pagamento, principal, juros_multa, descontos, total_pago, saldo_nota  ) VALUES ('" & TxtNota.Text & "', '" & TxtFornecedor.Text & "', '" & TxtPedido.Text & "', '" & data0 & "', '" & data1 & "', '" & data2 & "', '" & TxtValorNota.Text.Replace(",", ".") & "', '" & TxtIdNota.Text & "', '" & data3 & "', '" & TxtPrincipal.Text.Replace(",", ".") & "', '" & TxtJuros.Text.Replace(",", ".") & "', '" & TxtDesconto.Text.Replace(",", ".") & "', '" & TxtTotalPago.Text.Replace(",", ".") & "', '" & TxtSaldoNota.Text.Replace(",", ".") & "')"
            cmd = New MySqlCommand(sqls, con)
            cmd.ExecuteNonQuery()


            'SALVAR SALDO DA NOTA NA TBL DE NOTA FISCAL
            Dim cmd1 As MySqlCommand
            Dim sqls1 As String
            sqls1 = "UPDATE entrada SET saldo = '" & TxtSaldoNota.Text.Replace(",", ".") & "' WHERE id = '" & TxtIdNota.Text & "'"
            cmd1 = New MySqlCommand(sqls1, con)
            cmd1.ExecuteNonQuery()


            LimparCampos()
            MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")
            Me.Close()
        Else
            MsgBox("Selecione uma nota para pagamento!!", MsgBoxStyle.Information, "Pagamento")
        End If

    End Sub

    Sub LimparCampos()
        TxtIdNota.Text = ""
        TxtNota.Text = ""
        TxtFornecedor.Text = ""
        TxtPedido.Text = ""
        TxtValorNota.Text = ""
        TxtPrincipal.Text = ""
        TxtJuros.Text = ""
        TxtDesconto.Text = ""
        TxtTotalPago.Text = ""
        TxtSaldoNota.Text = ""

    End Sub
End Class