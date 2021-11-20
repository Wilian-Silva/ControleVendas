Imports MySql.Data.MySqlClient

Public Class FrmVendaCabecalho

    Private Sub FrmNotasEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Stop
        If pesquisarDuplicata = "True" Then
            GboxPesquisar.Visible = True
            Listar_Duplicas_Receber()
            Exit Sub

        End If

        If cumpomPesquisar = "True" Then
            GboxPesquisar.Visible = True
        End If

        ListarTudo()
    End Sub
    Sub ListarTudo()
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT id, id_venda, parcela , valor_parcela, data_venda, data_vencimento, cod_cliente, cliente, saldo_duplicata, observacao  FROM duplicatas_receber order by id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub Listar_Duplicas_Receber()
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT id, id_venda, parcela , valor_parcela, data_venda, data_vencimento, cod_cliente, cliente, saldo_duplicata, observacao  FROM duplicatas_receber WHERE saldo_duplicata > 0 order by id_venda desc"
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

            sql = "SELECT id, id_venda, parcela , valor_parcela, data_venda, data_vencimento, cod_cliente, cliente, saldo_duplicata, observacao  FROM duplicatas_receber order by id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "cod_cliente = " & TxtPesquisa.Text
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "cliente LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbVenda.Checked = True Then
                If TxtPesquisa.Text <> "" Then
                    dt.DefaultView.RowFilter = "id_venda = " & TxtPesquisa.Text
                    DataGrid.DataSource = dt
                End If
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Sub FiltroDataGrid_DuplicatasAbertas()


        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT id, id_venda, parcela , valor_parcela, data_venda, data_vencimento, cod_cliente, cliente, saldo_duplicata, observacao  FROM duplicatas_receber  WHERE saldo_duplicata > 0  order by id_venda desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "cod_cliente = " & TxtPesquisa.Text
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "cliente LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbVenda.Checked = True Then
                If TxtPesquisa.Text <> "" Then
                    dt.DefaultView.RowFilter = "id_venda = " & TxtPesquisa.Text
                    DataGrid.DataSource = dt
                End If
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid()
        ' DataGrid.Columns(11).Visible = False

        DataGrid.Columns(0).HeaderText = "Nº Dupl."
        DataGrid.Columns(1).HeaderText = "Nº Venda"
        DataGrid.Columns(2).HeaderText = "Parcela"
        DataGrid.Columns(3).HeaderText = "Valor"
        DataGrid.Columns(4).HeaderText = "Data Venda"
        DataGrid.Columns(5).HeaderText = "Data Vencimento"
        DataGrid.Columns(6).HeaderText = "Cód. Cliente"
        DataGrid.Columns(7).HeaderText = "Cliente"
        DataGrid.Columns(8).HeaderText = "Saldo"
        DataGrid.Columns(9).HeaderText = "Observação"

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(6).Width = 50
        DataGrid.Columns(7).Width = 150
        DataGrid.Columns(9).Width = 150

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"


    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        pesquisarDuplicata = ""
        Me.Close()
    End Sub



    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then
            On Error Resume Next

            TxtRegVenda.Text = DataGrid.CurrentRow.Cells(1).Value
            TxtCliente.Text = DataGrid.CurrentRow.Cells(7).Value
            TxtParcela.Text = DataGrid.CurrentRow.Cells(2).Value
            TxtSaldo_venda.Text = DataGrid.CurrentRow.Cells(8).Value
        End If

    End Sub

    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged

        If pesquisarDuplicata = "True" Then

            FiltroDataGrid_DuplicatasAbertas()
        Else

            FiltroDataGrid()

        End If



    End Sub

    Private Sub BtnCacelarConsulta_Click(sender As Object, e As EventArgs) Handles BtnCacelarConsulta.Click
        pesquisarDuplicata = ""
        Me.Close()
    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        'Stop
        If DataGrid.RowCount > 0 Then

            IdDuplicata = DataGrid.CurrentRow.Cells(1).Value
            IdDuplicata2 = DataGrid.CurrentRow.Cells(0).Value

            If cumpomPesquisar = "True" Then
                nomeCliente = DataGrid.CurrentRow.Cells(7).Value
                idVenda = DataGrid.CurrentRow.Cells(1).Value
            End If

            Me.Close()
        Else
            MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub

End Class