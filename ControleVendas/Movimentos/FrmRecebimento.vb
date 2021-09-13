Imports MySql.Data.MySqlClient

Public Class FrmRecebimento
    Private Sub BtnSair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnSair_Click_1(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnPesqNota_Click(sender As Object, e As EventArgs) Handles BtnPesqNota.Click
        Dim form = New FrmVendaCabecalho
        form.ShowDialog()

    End Sub

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

                sql = "SELECT v.id_venda, v.data_venda, v.cliente, p.produto, p.quantidade, p.valor_unitario, v.valor_total, v.vencimento, v.valor_recebido FROM venda_cabecalho as v INNER JOIN venda As p On v.id_venda = p.id_venda WHERE v.id_venda = '" & TxtIdNota.Text & "'"

                cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader


                If reader.Read = True Then

                    If reader(6) = reader(8) Then

                        MsgBox("Nota totalmente recebida!!", MsgBoxStyle.Information, "Recebimento")
                        reader.Close()
                        Exit Sub

                    End If

                    TxtNota.Text = reader(0)
                    DataVenda.Value = reader(1)
                    TxtCliente.Text = reader(2)
                    TxtProduto.Text = reader(3)
                    TxtQuantidade.Text = reader(4)
                    TxtValorUnit.Text = reader(5)
                    TxtValorTotal.Text = reader(6)
                    DataVencimento.Value = reader(7)
                    TxtTotalReceb.Text = reader(8)
                    TxtSaldoReceber.Text = reader(6) - reader(8)
                    TxtPrincipal.Text = TxtSaldoReceber.Text

                    reader.Close()
                End If


            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub FrmRecebimento_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtIdNota.Text = idNota
    End Sub

    Private Sub FrmRecebimento_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        idNota = ""
    End Sub

    Private Sub BtndAdicionarItem_Click(sender As Object, e As EventArgs) Handles BtndAdicionarItem.Click

        On Error Resume Next
        TxtTotalRecebido.Text = CDbl(TxtPrincipal.Text) + CDbl(TxtJuros.Text) - CDbl(TxtDesconto.Text)
        TxtSaldoNota.Text = CDbl(TxtSaldoReceber.Text) - CDbl(TxtPrincipal.Text)
        TxtTotal1_Total2.Text = CDbl(TxtTotalReceb.Text) + CDbl(TxtPrincipal.Text)
        BtnSalvar.Enabled = True
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If TxtIdNota.Text <> "" And TxtNota.Text <> "" Then
            Abrir()
            'PROGRAMANDO INSERÇÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sqls As String
            Dim data0 As String

            Dim data2 As String
            Dim data3 As String

            data0 = DataVenda.Value.ToString("yyyy-MM-dd")
            data2 = DataVencimento.Value.ToString("yyyy-MM-dd")
            data3 = DataPgto.Value.ToString("yyyy-MM-dd")

            sqls = "INSERT INTO mvto_recebimentos (data, id_nota, cliente, produto, quantidade, valor_unitario, valor_total, valorAreceber, data_vencimento, principal_recebido, data_recebimento, juros, descontos, total_recebido, saldo_venda) VALUES ('" & data0 & "', '" & TxtIdNota.Text & "', '" & TxtCliente.Text & "', '" & TxtProduto.Text & "', '" & TxtQuantidade.Text & "', '" & TxtValorUnit.Text.Replace(",", ".") & "', '" & TxtValorTotal.Text.Replace(",", ".") & "', '" & TxtSaldoReceber.Text.Replace(",", ".") & "', '" & data2 & "', '" & TxtPrincipal.Text.Replace(",", ".") & "', '" & data3 & "','" & TxtJuros.Text.Replace(",", ".") & "', '" & TxtDesconto.Text.Replace(",", ".") & "', '" & TxtTotalRecebido.Text.Replace(",", ".") & "', '" & TxtSaldoNota.Text.Replace(",", ".") & "')"
            cmd = New MySqlCommand(sqls, con)
            cmd.ExecuteNonQuery()
            'Stop
            'SALVAR SALDO DA NOTA NA TBL DE NOTA FISCAL
            Dim cmd1 As MySqlCommand
            Dim sqls1 As String


            sqls1 = "UPDATE venda_cabecalho SET valor_recebido = '" & TxtTotal1_Total2.Text.Replace(",", ".") & "', saldo_venda = '" & TxtSaldoNota.Text.Replace(",", ".") & "' WHERE id_venda = '" & TxtIdNota.Text & "'"
            cmd1 = New MySqlCommand(sqls1, con)
            cmd1.ExecuteNonQuery()

            LimparCampos()

            MsgBox("Cadastro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")
            Me.Close()
        Else
            MsgBox("Selecione registro para fazer recebimento!!", MsgBoxStyle.Information, "Recebimento")
        End If

    End Sub
    Sub LimparCampos()
        TxtIdNota.Text = ""
        TxtNota.Text = ""
        TxtCliente.Text = ""
        TxtProduto.Text = ""
        TxtQuantidade.Text = ""
        TxtValorUnit.Text = ""

        TxtValorTotal.Text = ""
        TxtTotalReceb.Text = ""
        TxtSaldoReceber.Text = ""
        TxtPrincipal.Text = ""
        TxtJuros.Text = ""
        TxtDesconto.Text = ""
        TxtTotalReceb.Text = ""
        TxtSaldoNota.Text = ""
    End Sub
End Class