Imports MySql.Data.MySqlClient

Public Class FrmEntradas
    Private Sub FrmEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTudo()
    End Sub
    Sub ListarTudo()
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * from  entrada order by data_registro desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Private Sub FormatarGrid()


        DataGrid.Columns(0).HeaderText = "Reg. Entrada"
        DataGrid.Columns(1).HeaderText = "Nota Fiscal"
        DataGrid.Columns(2).HeaderText = "Cod Fornec."
        DataGrid.Columns(3).HeaderText = "Fornecedor"
        DataGrid.Columns(4).HeaderText = "Pedido"
        DataGrid.Columns(5).HeaderText = "Descrição"
        DataGrid.Columns(6).HeaderText = "Data Registro"
        DataGrid.Columns(7).HeaderText = "Emissão NF"
        DataGrid.Columns(8).HeaderText = "Valor"

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(1).Width = 100
        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(5).Width = 120
        DataGrid.Columns(6).Width = 90
        DataGrid.Columns(7).Width = 90
        DataGrid.Columns(8).Width = 100

        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).DefaultCellStyle.Format = "c"


    End Sub

    Private Sub TxtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisa.TextChanged
        FiltroDataGrid()
    End Sub
    Sub FiltroDataGrid()
        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            'Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * from  entrada order by data_registro desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "descricao LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "fornecedor LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbNota.Checked = True Then
                'dt.DefaultView.RowFilter = "documento =" & TxtPesquisa.Text
                dt.DefaultView.RowFilter = "nota LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGrid.DataSource = dt
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnCacelarConsulta_Click(sender As Object, e As EventArgs) Handles BtnCacelarConsulta.Click
        pesquisarNotaEntrada = ""
        Me.Close()
    End Sub

    Private Sub BtnSelecionarItem_Click(sender As Object, e As EventArgs) Handles BtnSelecionarItem.Click
        If DataGrid.SelectedRows.Count = 1 Then

            nfeIdNotaEntrada = DataGrid.CurrentRow.Cells(0).Value
            nfeNotaEntrada = DataGrid.CurrentRow.Cells(1).Value
            nfeFornecedor = DataGrid.CurrentRow.Cells(3).Value

            Me.Close()
        Else
            MsgBox("Selecione um registro!!", MsgBoxStyle.Information, "Registro não selecionado")
        End If
    End Sub
End Class