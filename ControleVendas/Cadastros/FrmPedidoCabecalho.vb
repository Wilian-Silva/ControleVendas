Imports MySql.Data.MySqlClient

Public Class FrmPedidoCabecalho


    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            Dim data1 As String

            data1 = DataInicial.Value.ToString("yyyy-MM-dd")


            sql = "SELECT * FROM pedido_cabecalho WHERE data = '" & data1 & "' order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt


            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub ListarPorFornecedor()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM pedido_cabecalho WHERE fornecedor LIKE '" & TxtPesquisar.Text & "%' order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt


            FormatarGrid()


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub

    Sub ListarPorPedido()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM pedido_cabecalho WHERE pedido LIKE '" & TxtPesqPedido.Text & "%' order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt


            FormatarGrid()


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

            sql = "SELECT * FROM pedido_cabecalho order by id desc"
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

        DataGrid.Columns(0).HeaderText = "Nº Pedido"
        DataGrid.Columns(1).HeaderText = "Desc. Pedido"
        DataGrid.Columns(2).HeaderText = "Cód. Fornecedor"
        DataGrid.Columns(3).HeaderText = "Fornecedor"
        DataGrid.Columns(4).HeaderText = "Data Pedido"
        DataGrid.Columns(5).HeaderText = "Valor Total"
        DataGrid.Columns(6).HeaderText = "Status Pedido"

        DataGrid.Columns(0).Width = 75
        DataGrid.Columns(2).Width = 75
        DataGrid.Columns(1).Width = 110
        DataGrid.Columns(3).Width = 140
        DataGrid.Columns(5).Width = 100

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Format = "c"

    End Sub


    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmPedidoCabecalho_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pedidoPesquisar = "True" Then

            GboxPesPed.Visible = True

        End If

        ListarTudo()

        FormatarGrid()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then

            TxtIdPedido.Text = DataGrid.CurrentRow.Cells(0).Value
        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtIdPedido.Text = "" Then
            MsgBox("Selecione um registro para excluir!", MsgBoxStyle.Information, "Excluir")
            Exit Sub
        End If
        'CONSULTAR DE PEDIDO JA FOI USADO PARA ENTRADA DA NOTA FISCAL
        Abrir()
            Dim cmd2 As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql2 As String
            Dim idped As Integer
            idped = TxtIdPedido.Text

            sql2 = "SELECT * FROM entrada WHERE id_pedido = '" & idped & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader = cmd2.ExecuteReader

            If reader.Read = True Then

                If reader(3) = idped Then

                    MsgBox("Pedido já utilizado, não pode ser excluído!!", MsgBoxStyle.Information, "Pedido Fechado")

                    reader.Close()
                    Exit Sub

                End If
            Else
                reader.Close()

            End If

            'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
            If MsgBox("Deseja excluir registro?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'EXCLUIR NA TEBELA CABEÇALHO
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    sql = "DELETE FROM pedido_cabecalho where id = '" & TxtIdPedido.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    'EXCLUIR NA TABELA PEDIDOS
                    Dim cmd1 As MySqlCommand
                    Dim sql1 As String
                    sql1 = "DELETE FROM pedidos where id = '" & TxtIdPedido.Text & "' "
                    cmd1 = New MySqlCommand(sql1, con)
                    cmd1.ExecuteNonQuery()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")
                    TxtIdPedido.Text = ""

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try
            End If


    End Sub

    Private Sub FrmPedidoCabecalho_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed


    End Sub

    Private Sub DataInicial_ValueChanged(sender As Object, e As EventArgs) Handles DataInicial.ValueChanged
        Listar()
        FormatarGrid()
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        ListarPorFornecedor()
    End Sub

    Private Sub TxtPesqPedido_TextChanged(sender As Object, e As EventArgs) Handles TxtPesqPedido.TextChanged
        ListarPorPedido()
    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        If DataGrid.RowCount > 0 Then
            If DataGrid.CurrentRow.Cells(6).Value = "Fechado" Then
                MsgBox("Pedido fechado, não pode ser utilizado!!", MsgBoxStyle.Information, "Pedido Fechado")
                Exit Sub
            End If

            numeroPedido = DataGrid.CurrentRow.Cells(0).Value
            nomePedido = DataGrid.CurrentRow.Cells(1).Value
            codFornecedor = DataGrid.CurrentRow.Cells(2).Value
            nomeFornecedor = DataGrid.CurrentRow.Cells(3).Value
            totalPedido = DataGrid.CurrentRow.Cells(5).Value

            Me.Close()
            Else
                MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub

    Private Sub BtnCacelarConsulta_Click(sender As Object, e As EventArgs) Handles BtnCacelarConsulta.Click
        pedidoPesquisar = ""
        Me.Close()
    End Sub


End Class