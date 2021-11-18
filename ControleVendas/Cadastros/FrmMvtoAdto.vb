Imports MySql.Data.MySqlClient

Public Class FrmMvtoAdto
    Private Sub FrmMvtoAdto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Sub Pesquisar()
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "select a.id, a.id_duplicata, a.cod_cliente, c.nome, a.id_venda, a.data_pagamento, a.id_portador, p.nome, " _
            & " a.valor_adto, a.valor_comp_adto from tbl_adto as a INNER JOIN portador as p ON a.id_portador = p.id INNER JOIN clientes as c on a.cod_cliente = c.id where c.nome like '" & TxtPesquisar.Text & "%' order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub
    Sub Listar()


        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "select a.id, a.id_duplicata, a.cod_cliente, c.nome, a.id_venda, a.data_pagamento, a.id_portador, p.nome, " _
            & " a.valor_adto, a.valor_comp_adto from tbl_adto as a INNER JOIN portador as p ON a.id_portador = p.id INNER JOIN clientes as c on a.cod_cliente = c.id  order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub FormatarGrid()
        DataGrid.Columns(0).HeaderText = "Cód."
        DataGrid.Columns(1).HeaderText = "Nº Duplicata"
        DataGrid.Columns(2).HeaderText = "Cód Cliente"
        DataGrid.Columns(3).HeaderText = "Cliente"
        DataGrid.Columns(4).HeaderText = "Nº Venda"
        DataGrid.Columns(5).HeaderText = "Data"
        DataGrid.Columns(6).HeaderText = "Nº Portador"
        DataGrid.Columns(7).HeaderText = "Portador"
        DataGrid.Columns(8).HeaderText = "Adto Recebido"
        DataGrid.Columns(9).HeaderText = "Adto Compensado"

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


        DataGrid.Columns(0).Width = 40
        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(3).Width = 180
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(5).Width = 80
        DataGrid.Columns(6).Width = 50

        DataGrid.Columns(8).DefaultCellStyle.Format = "c"
        DataGrid.Columns(9).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If DataGrid.SelectedRows.Count = 1 Then

            If MsgBox("Deseja excluir esse resgistro?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    Dim idadto As Integer
                    idadto = DataGrid.CurrentRow.Cells(0).Value
                    'ATUALIZAR MVTO PORTADOR
                    Dim cmd1 As MySqlCommand
                    Dim sql1 As String

                    sql1 = "DELETE FROM tbl_adto WHERE id =  '" & idadto & "' "
                    cmd1 = New MySqlCommand(sql1, con)
                    cmd1.ExecuteNonQuery()

                    Listar()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Excluir Adiantamento")

                Catch ex As Exception
                    MsgBox("Erro ao Excluir_tbl_adto!!" + ex.Message)
                End Try
            End If
        End If


    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        Pesquisar()
    End Sub
End Class