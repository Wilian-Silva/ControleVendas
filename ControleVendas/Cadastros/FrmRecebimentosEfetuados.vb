Imports MySql.Data.MySqlClient

Public Class FrmRecebimentosEfetuados
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

            sql = "SELECT * FROM mvto_recebimentos WHERE data_recebimento >= '" & data1 & "' AND data_recebimento <= '" & data2 & "'order by id_nota desc"
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

            sql = "SELECT * FROM mvto_recebimentos order by id_nota desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Private Sub FormatarGrid()
        DataGrid.Columns(0).Visible = False
        'DataGrid.Columns(1).Visible = False

        ' DataGrid.Columns(4).Visible = False
        'DataGrid.Columns(5).Visible = False
        'DataGrid.Columns(8).Visible = False

        DataGrid.Columns(1).HeaderText = "Data Venda"
        DataGrid.Columns(2).HeaderText = "Nº Venda"
        DataGrid.Columns(3).HeaderText = "Cliente"
        DataGrid.Columns(4).HeaderText = "Produto"
        DataGrid.Columns(5).HeaderText = "Qtd."
        DataGrid.Columns(6).HeaderText = "Vlr. Unit."
        DataGrid.Columns(7).HeaderText = "Vlr. Total"
        DataGrid.Columns(8).HeaderText = "Vlr. a Receber"
        DataGrid.Columns(9).HeaderText = "Vencimento"
        DataGrid.Columns(10).HeaderText = "Principal Recebido"
        DataGrid.Columns(11).HeaderText = "Data Recebimento"
        DataGrid.Columns(12).HeaderText = "Juros/Multa"
        DataGrid.Columns(13).HeaderText = "Descontos"
        DataGrid.Columns(14).HeaderText = "Total Recebido"
        DataGrid.Columns(15).HeaderText = "Saldo"

        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(3).Width = 90
        DataGrid.Columns(5).Width = 50
        DataGrid.Columns(4).Width = 150
        DataGrid.Columns(1).Width = 80
        DataGrid.Columns(9).Width = 80
        DataGrid.Columns(11).Width = 80

        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(10).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(11).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(14).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(15).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).DefaultCellStyle.Format = "c"
        DataGrid.Columns(7).DefaultCellStyle.Format = "c"
        DataGrid.Columns(8).DefaultCellStyle.Format = "c"
        DataGrid.Columns(10).DefaultCellStyle.Format = "c"
        DataGrid.Columns(12).DefaultCellStyle.Format = "c"
        DataGrid.Columns(13).DefaultCellStyle.Format = "c"
        DataGrid.Columns(14).DefaultCellStyle.Format = "c"
        DataGrid.Columns(15).DefaultCellStyle.Format = "c"


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


    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then
            TxtId.Text = DataGrid.CurrentRow.Cells(0).Value

        End If

    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click

        If TxtId.Text <> "" Then

            If MsgBox("Deseja excluir registro?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM mvto_recebimentos where id = '" & TxtId.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    TxtId.Text = ""
                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try

            End If
        Else
            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Id Registro Vazio")
        End If

    End Sub

    Private Sub FrmRecebimentoEfetuados_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        BtnExcluir.Visible = False
        TxtId.Visible = False
        LblId.Visible = False
        statusBtn = ""
    End Sub

    Private Sub FrmRecebimentosEfetuados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If statusBtn = "Visible" Then
            BtnExcluir.Visible = True
            TxtId.Visible = True
            LblId.Visible = True
        End If
    End Sub
End Class