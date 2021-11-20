Imports MySql.Data.MySqlClient

Public Class FrmLucroRetirar
    Private Sub FrmLucroRetirar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListarTudo()
    End Sub


    Sub ListarTudo()
        Try
            'Stop
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter
            Dim saldoRetirar As Decimal

            sql = "Select id_entrada, documento, sum(valor_parcela) As Total_Entrada, coalesce((select sum(total_pago) from mvto_recebimentos where id_nfe = id_entrada),0) Total_Recebido, " _
            & "coalesce((select sum(valor_retirada) from tbl_retiradas where id_entrada_nfe= id_entrada),0) Total_Retiradas From duplicatas Group By documento order by id_entrada desc"

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt


            dt.Columns.Add("Lucro a Retirar")
            For i = 0 To DataGrid.Rows.Count - 1

                saldoRetirar = (Convert.ToDouble(DataGrid.Rows(i).Cells(3).Value) - Convert.ToDouble(DataGrid.Rows(i).Cells(4).Value) - (Convert.ToDouble(DataGrid.Rows(i).Cells(2).Value)))
                DataGrid.Rows(i).Cells(5).Value = Format(saldoRetirar, "R$ #,###0.00")
            Next


            ' DataGrid.DataSource = dt

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Private Sub FormatarGrid()

        DataGrid.Columns(0).HeaderText = "Id Nfe"
        DataGrid.Columns(1).HeaderText = "Documento"
        DataGrid.Columns(2).HeaderText = "Dup. a Pagar"
        DataGrid.Columns(3).HeaderText = "Dup. Recebidas"
        DataGrid.Columns(4).HeaderText = "Retiradas de Lucro"

        DataGrid.Columns(0).Width = 90
        DataGrid.Columns(1).Width = 100
        DataGrid.Columns(2).Width = 150
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(4).Width = 150
        DataGrid.Columns(5).Width = 150

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).DefaultCellStyle.Format = "c"
        DataGrid.Columns(3).DefaultCellStyle.Format = "c"
        DataGrid.Columns(4).DefaultCellStyle.Format = "c"
        'DataGrid.Columns(5).DefaultCellStyle.Format = "c"

    End Sub
End Class