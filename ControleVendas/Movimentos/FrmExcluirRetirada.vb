Imports MySql.Data.MySqlClient

Public Class FrmExcluirRetirada
    Private Sub FrmExcluirRetirada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Retiradas()
    End Sub

    Sub Listar_Retiradas()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM TBL_RETIRADAS  ORDER BY ID DESC"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridRetiradas.DataSource = dt

            FormatarGrid_Retiradas()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid_Retiradas()
        'DataGridRetiradas.Columns(1).Visible = False
        'DataGridRetiradas.Columns(0).Visible = False
        ' DataGridRetiradas.Columns(5).Visible = False

        DataGridRetiradas.Columns(0).HeaderText = "Cod. Retirada"
        DataGridRetiradas.Columns(1).HeaderText = "Id Nfe"
        DataGridRetiradas.Columns(2).HeaderText = "Documento"
        DataGridRetiradas.Columns(3).HeaderText = "Movimento"
        DataGridRetiradas.Columns(4).HeaderText = "Cód Portador"
        DataGridRetiradas.Columns(5).HeaderText = "Portador"
        DataGridRetiradas.Columns(6).HeaderText = "Valor"
        DataGridRetiradas.Columns(7).HeaderText = "Data"

        DataGridRetiradas.Columns(0).Width = 50
        DataGridRetiradas.Columns(1).Width = 70
        DataGridRetiradas.Columns(2).Width = 90
        DataGridRetiradas.Columns(3).Width = 110
        DataGridRetiradas.Columns(4).Width = 50
        DataGridRetiradas.Columns(5).Width = 100
        DataGridRetiradas.Columns(6).Width = 90
        DataGridRetiradas.Columns(7).Width = 80

        DataGridRetiradas.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridRetiradas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridRetiradas.Columns(6).DefaultCellStyle.Format = "c"

    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtId.Text <> "" Then

            If MsgBox("Deseja excluir registro " & TxtId.Text & " ?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM tbl_retiradas where id = '" & TxtId.Text & "'  ORDER BY ID DESC "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    Excluir_Mvto_Portador()

                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    TxtId.Text = ""
                    Listar_Retiradas()

                Catch ex As Exception
                    MsgBox("Erro ao excluir retiradas!!" + ex.Message)
                End Try
            End If
        Else

            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Exlusão")

        End If
    End Sub
    Sub Excluir_Mvto_Portador()
        Try
            'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
            Dim cmd As MySqlCommand
            Dim sql As String
            sql = "DELETE FROM mvto_portador where id_retirada = '" & TxtId.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro Excluir_Mvto_Portador !!" + ex.Message)
        End Try
    End Sub

    Private Sub DataGridRetiradas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRetiradas.CellClick
        If e.RowIndex > -1 Then

            TxtId.Text = DataGridRetiradas.CurrentRow.Cells(0).Value

        End If
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

            sql = "SELECT * FROM TBL_RETIRADAS  ORDER BY ID "

            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGridRetiradas.DataSource = dt

            FormatarGrid()

            If RbNfe.Checked = True Then

                dt.DefaultView.RowFilter = "nota LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGridRetiradas.DataSource = dt
            End If

            If RbPortador.Checked = True Then
                dt.DefaultView.RowFilter = "portador LIKE " & "'%" & TxtPesquisa.Text & "%'"
                DataGridRetiradas.DataSource = dt
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub FormatarGrid()

    End Sub
End Class