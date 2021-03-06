Imports MySql.Data.MySqlClient

Public Class FrmPedidoCabecalho

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
        DataGrid.Columns(1).HeaderText = "Desc.Pedido"
        DataGrid.Columns(2).HeaderText = "Cód. Fornec."
        DataGrid.Columns(3).HeaderText = "Fornecedor"
        DataGrid.Columns(4).HeaderText = "Data Pedido"
        DataGrid.Columns(5).HeaderText = "Valor Total"
        DataGrid.Columns(6).HeaderText = "Status Pedido"

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(1).Width = 125
        DataGrid.Columns(3).Width = 140
        DataGrid.Columns(4).Width = 90
        DataGrid.Columns(5).Width = 100
        DataGrid.Columns(6).Width = 80

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).DefaultCellStyle.Format = "c"

    End Sub


    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        pedidoPesquisar = ""
        Me.Close()

    End Sub

    Private Sub FrmPedidoCabecalho_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If pedidoPesquisar = "True" Then

            GboxPesPed.Visible = True

        End If

        If utilizarPedido = "True" Then

            GboxPesPed.Visible = True

        End If

        If statusBtn = "Visible" Then

            BtnExcluir.Enabled = True

        End If

        ListarTudo()

        FormatarGrid()
    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then

            TxtIdPedido.Text = DataGrid.CurrentRow.Cells(0).Value
            TxtDescPedido.Text = DataGrid.CurrentRow.Cells(1).Value
            TxtFornecedor.Text = DataGrid.CurrentRow.Cells(3).Value
            TxtStatus.Text = DataGrid.CurrentRow.Cells(6).Value
        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtIdPedido.Text = "" Then
            MsgBox("Selecione um registro para excluir!", MsgBoxStyle.Information, "Excluir")
            Exit Sub
        End If
        If TxtStatus.Text = "Fechado" Then
            MsgBox("Pedido já utilizado, não pode ser excluído!!", MsgBoxStyle.Information, "Pedido Fechado")
            Exit Sub
        End If


        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
        If MsgBox("Deseja excluir pedido de compra?", vbYesNo, "Excluir Pedido") = vbYes Then

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
                sql1 = "DELETE FROM pedidos where pedido = '" & TxtIdPedido.Text & "' "
                cmd1 = New MySqlCommand(sql1, con)
                cmd1.ExecuteNonQuery()

                MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                TxtIdPedido.Text = ""
                TxtDescPedido.Text = ""
                TxtFornecedor.Text = ""
                TxtStatus.Text = ""

                ListarTudo()

            Catch ex As Exception
                MsgBox("Erro ao excluir!!" + ex.Message)
            End Try
        End If


    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click

        If utilizarPedido = "True" Then
            If DataGrid.CurrentRow.Cells(6).Value = "Fechado" Then

                MsgBox("Pedido fechado, não pode ser utilizado!!", MsgBoxStyle.Information, "Pedido fechado")
                Exit Sub
            End If
        End If


        If DataGrid.RowCount > 0 Then

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

    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged
        FiltroDataGrid()
    End Sub
    Sub FiltroDataGrid()

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

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "pedido LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "fornecedor LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbStatus.Checked = True Then
                'dt.DefaultView.RowFilter = "documento =" & TxtPesquisa.Text
                dt.DefaultView.RowFilter = "status LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub FrmPedidoCabecalho_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        statusBtn = ""
    End Sub
End Class