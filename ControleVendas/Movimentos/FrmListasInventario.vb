Imports MySql.Data.MySqlClient

Public Class FrmListasInventario
    Private Sub FrmListasInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Sub Listar()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "Select DISTINCT id_inventario, descricao, data_inventario FROM tbl_inventario order by data_inventario desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            DataGrid.Columns(0).HeaderText = "Nº Lista"
            DataGrid.Columns(1).HeaderText = "Descrição"
            DataGrid.Columns(2).HeaderText = "Data Inventário"

        Catch ex As Exception
            MsgBox("Erro ao Listar dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pesqListaInvetario = ""
        Me.Close()
    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        If DataGrid.SelectedRows.Count = 1 Then
            listaInvet = DataGrid.CurrentRow.Cells(0).Value
            nomeLista = DataGrid.CurrentRow.Cells(1).Value
            dataInvent = DataGrid.CurrentRow.Cells(2).Value
            Me.Close()
        End If

    End Sub
End Class