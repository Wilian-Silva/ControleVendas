Imports MySql.Data.MySqlClient

Public Class FrmNotasEntrada

    Sub ListarTudo()
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT d.id_entrada,  d.documento, d.data_emissao, f.nome_fantasia, d.parcela, d.data_vencimento, d.valor_parcela, d.saldo_duplicata, e.id_pedido, e.descricao, d.observacao, d.id FROM duplicatas as d INNER JOIN fornecedor as f ON d.cod_fornecedor = f.id INNER JOIN entrada as e ON d.id_entrada = e.id  order by d.documento desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Sub FiltroDataGrid()


        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT d.id_entrada,  d.documento, d.data_emissao, f.nome_fantasia, d.parcela, d.data_vencimento, d.valor_parcela, d.saldo_duplicata, e.id_pedido, e.descricao, d.observacao, d.id FROM duplicatas as d INNER JOIN fornecedor as f ON d.cod_fornecedor = f.id INNER JOIN entrada as e ON d.id_entrada = e.id  order by d.documento desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "descricao LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "nome_fantasia LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbNota.Checked = True Then
                'dt.DefaultView.RowFilter = "documento =" & TxtPesquisa.Text
                dt.DefaultView.RowFilter = "documento LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid()
        DataGrid.Columns(11).Visible = False

        DataGrid.Columns(0).HeaderText = "Reg. Entrada"
        DataGrid.Columns(1).HeaderText = "Nota Fiscal"
        DataGrid.Columns(2).HeaderText = "Data Emissão"
        DataGrid.Columns(3).HeaderText = "Fornecedor"
        DataGrid.Columns(4).HeaderText = "Parcela"
        DataGrid.Columns(5).HeaderText = "Vencimento"
        DataGrid.Columns(6).HeaderText = "Valor Parcela"
        DataGrid.Columns(7).HeaderText = "Saldo"
        DataGrid.Columns(8).HeaderText = "Pedido"
        DataGrid.Columns(9).HeaderText = "Descrição"
        DataGrid.Columns(10).HeaderText = "Observação"
        ' DataGrid.Columns(11).HeaderText = "Reg. Duplicata"


        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 60
        DataGrid.Columns(2).Width = 90
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(5).Width = 90
        DataGrid.Columns(8).Width = 50
        DataGrid.Columns(9).Width = 150
        DataGrid.Columns(10).Width = 150
        'DataGrid.Columns(11).Width = 50

        'DataGrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ' DataGrid.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).DefaultCellStyle.Format = "c"
        DataGrid.Columns(7).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        pesquisarDuplicata = ""
        Me.Close()
    End Sub

    Private Sub FrmNotasEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If statusBtn = "Visible" Then
            BtnExcluir.Enabled = True
        End If
        If pesquisarDuplicata = "True" Then
            GboxPesquisar.Visible = True
        End If
        ListarTudo()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtId.Text <> "" Then

            'PESQUISAR SE A NOTA JA NÃO FOI PAGA
            Dim cmd1 As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql1 As String

            sql1 = "SELECT * FROM mvto_pagamentos where id_entrada = '" & TxtId.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            reader = cmd1.ExecuteReader

            If reader.Read = True Then

                MsgBox("Documento não pode ser excluido, já foi pago!!", MsgBoxStyle.Information, "Excluir Documento")
                reader.Close()
                Exit Sub
            Else
                reader.Close()
            End If


            'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
            If MsgBox("Deseja excluir registro?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM entrada where id = '" & TxtId.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    Excluir_Estoque()

                    Atualizar_Saldo_Estoque()

                    Exluir_Duplicatas()

                    Atualizar_PedidoStatus()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    TxtId.Text = ""
                    TxtIdPedido.Text = ""

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try

            End If
        Else
            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Registro Vazio")
        End If

    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then
            On Error Resume Next

            TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
            TxtNota.Text = DataGrid.CurrentRow.Cells(1).Value
            TxtFornecedor.Text = DataGrid.CurrentRow.Cells(3).Value
            TxtIdPedido.Text = DataGrid.CurrentRow.Cells(8).Value

        End If

    End Sub

    Private Sub Atualizar_Saldo_Estoque()
        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            Dim saldoItem As Integer
            Dim codItem As Integer
            Dim qtd As Integer
            Dim saldoEstoque As Integer


            For i = 0 To DataGrid.RowCount - 1

                codItem = CInt(DataGrid.Rows(i).Cells(1).Value.ToString)
                qtd = CInt(DataGrid.Rows(i).Cells(3).Value.ToString)

                Dim cmdp As MySqlCommand
                Dim sqlp As String
                Dim ultima As MySqlDataReader

                sqlp = "SELECT saldo_estoque FROM produtos WHERE id= '" & codItem & "'"
                cmdp = New MySqlCommand(sqlp, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
                    saldoEstoque = ultima("saldo_estoque")
                    ultima.Close()
                Else
                    ultima.Close()
                End If

                saldoItem = saldoEstoque - qtd

                sql = "UPDATE produtos SET saldo_estoque = '" & saldoItem & "' WHERE id = '" & codItem & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()

            Next

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try

    End Sub
    Private Sub Exluir_Duplicatas()
        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            sql = "DELETE FROM duplicatas where id_entrada = '" & TxtId.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try

    End Sub
    Sub Excluir_Estoque()

        'PROMAGAMANDO EXCLUSÃO NO ESTOQUE
        Abrir()
        Dim cmd As MySqlCommand
        Dim sql As String

        sql = "DELETE FROM estoque where id_entrada = '" & TxtId.Text & "' "
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()
    End Sub
    Sub Atualizar_PedidoStatus()

        'PROMAGAMANDO ATUALIZAÇÃO STATUS DO PEDIDO
        Abrir()
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim stpedido As String
        stpedido = "Aberto"

        sql = "UPDATE pedido_cabecalho SET status = '" & stpedido & "' WHERE id = '" & TxtIdPedido.Text & "'"
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()

    End Sub
    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged
        FiltroDataGrid()
    End Sub

    Private Sub BtnCacelarConsulta_Click(sender As Object, e As EventArgs) Handles BtnCacelarConsulta.Click
        pesquisarDuplicata = ""
        Me.Close()
    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        'Stop
        If DataGrid.RowCount > 0 Then

            IdDuplicata = DataGrid.CurrentRow.Cells(11).Value
            IdDuplicata2 = DataGrid.CurrentRow.Cells(0).Value

            Me.Close()
        Else
            MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub


End Class