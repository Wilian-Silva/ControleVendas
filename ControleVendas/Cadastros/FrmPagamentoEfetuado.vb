Imports MySql.Data.MySqlClient

Public Class FrmPagamentoEfetuado



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

            sql = "SELECT * FROM mvto_pagamentos WHERE data_registro >= '" & data1 & "' AND data_pagamento <= '" & data2 & "'order by data_pagamento desc"
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

            sql = "SELECT * FROM mvto_pagamentos order by data_pagamento desc"
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

            sql = "SELECT * FROM mvto_pagamentos WHERE nota LIKE '" & TxtPesquisar.Text & "%' order by data_registro desc"
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
    Private Sub FormatarGrid()
        'DataGrid.Columns(0).Visible = False
        DataGrid.Columns(3).Visible = False
        DataGrid.Columns(4).Visible = False
        DataGrid.Columns(5).Visible = False
        DataGrid.Columns(8).Visible = False
        DataGrid.Columns(9).Visible = False

        DataGrid.Columns(0).HeaderText = "Id. Reg."
        DataGrid.Columns(1).HeaderText = "Nota Fiscal"
        DataGrid.Columns(2).HeaderText = "Fornecedor"
        DataGrid.Columns(6).HeaderText = "Vencimento"
        DataGrid.Columns(7).HeaderText = "Valor Nota"
        DataGrid.Columns(9).HeaderText = "Data Pagamento"
        DataGrid.Columns(10).HeaderText = "Principal Pago"
        DataGrid.Columns(11).HeaderText = "Juros/Multa"
        DataGrid.Columns(12).HeaderText = "Descontos"
        DataGrid.Columns(13).HeaderText = "Total Pago"
        DataGrid.Columns(14).HeaderText = "Saldo Nota"

        DataGrid.Columns(1).Width = 50
        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(2).Width = 80
        'DataGrid.Columns(4).Width = 80
        'DataGrid.Columns(5).Width = 80
        'DataGrid.Columns(6).Width = 80

        DataGrid.Columns(9).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(7).DefaultCellStyle.Format = "c"
        DataGrid.Columns(10).DefaultCellStyle.Format = "c"
        DataGrid.Columns(11).DefaultCellStyle.Format = "c"
        DataGrid.Columns(12).DefaultCellStyle.Format = "c"
        DataGrid.Columns(13).DefaultCellStyle.Format = "c"
        DataGrid.Columns(14).DefaultCellStyle.Format = "c"

    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        Listar()
        FormatarGrid()
    End Sub

    Private Sub BtnListarTudo_Click(sender As Object, e As EventArgs) Handles BtnListarTudo.Click
        ListarTudo()
        FormatarGrid()
    End Sub



    Private Sub DataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellDoubleClick
        If e.RowIndex > -1 Then

            If statusBtn = "" Then
                On Error Resume Next
                numeroNota = DataGrid.CurrentRow.Cells(1).Value
                idNota = DataGrid.CurrentRow.Cells(0).Value
                Me.Close()
            End If
        End If


    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click

        Me.Close()
    End Sub


    Private Sub FrmPagamentoEfetuado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If statusBtn = "Visible" Then
            BtnExcluir.Visible = True
            TxtId.Visible = True
            LblId.Visible = True
        End If

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

                    sql = "DELETE FROM mvto_pagamentos where id = '" & TxtId.Text & "' "
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

    Private Sub FrmPagamentoEfetuado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        BtnExcluir.Visible = False
        TxtId.Visible = False
        LblId.Visible = False
        statusBtn = ""
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        ListarPorNota()
    End Sub
End Class