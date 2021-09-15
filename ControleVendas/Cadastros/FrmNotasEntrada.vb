Imports MySql.Data.MySqlClient

Public Class FrmNotasEntrada

    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data1 As String
            Dim data2 As String
            data1 = DataInicial.Value.ToString("yyyy-MM-dd")
            data2 = DataFinal.Value.ToString("yyyy-MM-dd")

            sql = "SELECT * FROM entrada WHERE data_registro >= '" & data1 & "' AND data_registro <= '" & data2 & "'order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            If DataGrid.Rows.Count > 0 Then
                FormatarGrid()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub ListarPorNota()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM entrada WHERE nota LIKE '" & TxtPesquisar.Text & "%' order by data_registro desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            If DataGrid.Rows.Count > 0 Then
                FormatarGrid()
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub ListarTudo()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT d.id_entrada,  d.documento, d.data_emissao, f.nome_fantasia, d.parcela, d.data_vencimento, d.valor_parcela, d.saldo_duplicata, e.id_pedido, e.descricao, d.observacao FROM duplicatas as d INNER JOIN fornecedor as f ON d.cod_fornecedor = f.id INNER JOIN entrada as e ON d.id_entrada = e.id  order by d.documento desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Private Sub FormatarGrid()
        'DataGrid.Columns(0).Visible = False

        DataGrid.Columns(0).HeaderText = "Reg. Entrada"
        DataGrid.Columns(1).HeaderText = "Nota Fiscal"
        DataGrid.Columns(2).HeaderText = "Data Emissão"
        DataGrid.Columns(3).HeaderText = "Fornecedor"
        DataGrid.Columns(4).HeaderText = "Parcela"
        DataGrid.Columns(5).HeaderText = "Vencimento"
        DataGrid.Columns(6).HeaderText = "Valor Nota"
        DataGrid.Columns(7).HeaderText = "Saldo"
        DataGrid.Columns(8).HeaderText = "Pedido"
        DataGrid.Columns(9).HeaderText = "Descrição"
        DataGrid.Columns(10).HeaderText = "Observação"


        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 60
        DataGrid.Columns(2).Width = 90
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(5).Width = 90
        DataGrid.Columns(8).Width = 50
        DataGrid.Columns(9).Width = 150
        DataGrid.Columns(10).Width = 150

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

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        Listar()
        FormatarGrid()
    End Sub

    Private Sub BtnListarTudo_Click(sender As Object, e As EventArgs) Handles BtnListarTudo.Click
        ListarTudo()
        FormatarGrid()
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click

        Me.Close()
    End Sub

    Private Sub FrmNotasEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If statusBtn = "Visible" Then
            BtnExcluir.Visible = True
            TxtId.Visible = True
            LblId.Visible = True
            TxtIdPedido.Visible = True
            LblIdPedido.Visible = True
        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtId.Text <> "" Then

            'PESQUISAR SE A NOTA JA NÃO FOI PAGA
            Dim cmd1 As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql1 As String

            sql1 = "SELECT * FROM mvto_pagamentos where id_nota = '" & TxtId.Text & "' "
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

                    ExcluirRegistroEstoque()

                    AtualizarPedido_ExclusaoNota()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    TxtId.Text = ""
                    TxtIdPedido.Text = ""

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try

            End If
        Else
            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Id Registro Vazio")
        End If

    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then
            On Error Resume Next

            TxtId.Text = DataGrid.CurrentRow.Cells(0).Value
            TxtIdPedido.Text = DataGrid.CurrentRow.Cells(3).Value

        End If

    End Sub

    Private Sub FrmNotasEntrada_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        BtnExcluir.Visible = False
        TxtId.Visible = False
        LblId.Visible = False
        statusBtn = ""
    End Sub
    Sub ExcluirRegistroEstoque()

        'PROMAGAMANDO EXCLUSÃO NO ESTOQUE
        Abrir()
        Dim cmd As MySqlCommand
        Dim sql As String

        sql = "DELETE FROM estoque where id_nota = '" & TxtId.Text & "' "
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()
    End Sub
    Sub AtualizarPedido_ExclusaoNota()

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

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        ListarPorNota()
    End Sub
End Class