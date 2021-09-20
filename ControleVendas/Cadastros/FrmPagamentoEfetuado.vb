Imports MySql.Data.MySqlClient

Public Class FrmPagamentoEfetuado
    Sub ListarTudo()

        'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM mvto_pagamentos order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Sub ListarFiltro()


        Try
            Abrir()

            Dim sql As String
            Dim dt As New DataTable
            Dim da As MySqlDataAdapter

            sql = "SELECT * FROM mvto_pagamentos order by id desc"
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid.DataSource = dt

            FormatarGrid()

            If RbPedido.Checked = True Then

                dt.DefaultView.RowFilter = "descricao_pedido LIKE " & "'%" & TxtPesquisar.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbFornecedor.Checked = True Then
                dt.DefaultView.RowFilter = "fornecedor LIKE " & "'%" & TxtPesquisar.Text & "%'"
                DataGrid.DataSource = dt
            End If

            If RbNota.Checked = True Then
                dt.DefaultView.RowFilter = "titulo LIKE " & "'%" & TxtPesquisar.Text & "%'"
                DataGrid.DataSource = dt
            End If

        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try

    End Sub
    Private Sub FormatarGrid()
        'DataGrid.Columns(0).Visible = False
        DataGrid.Columns(1).Visible = False
        DataGrid.Columns(19).Visible = False
        'DataGrid.Columns(5).Visible = False
        'DataGrid.Columns(8).Visible = False
        'DataGrid.Columns(9).Visible = False

        DataGrid.Columns(0).HeaderText = "Id Pgto."
        ' DataGrid.Columns(1).HeaderText = "Id. Duplicata"
        DataGrid.Columns(2).HeaderText = "Cod. Fornec."
        DataGrid.Columns(3).HeaderText = "Fornec."
        DataGrid.Columns(4).HeaderText = "Nº Nota"
        DataGrid.Columns(5).HeaderText = "Total Nota"
        DataGrid.Columns(6).HeaderText = "Cod Pedido"
        DataGrid.Columns(7).HeaderText = "Desc. Pedido"
        DataGrid.Columns(8).HeaderText = "Nº Parcela"
        DataGrid.Columns(9).HeaderText = "Valor Parcela"
        DataGrid.Columns(10).HeaderText = "Valor Pago"
        DataGrid.Columns(11).HeaderText = "Saldo"
        DataGrid.Columns(12).HeaderText = "Juros/Multa"
        DataGrid.Columns(13).HeaderText = "Descontos"
        DataGrid.Columns(14).HeaderText = "Total Pago"
        DataGrid.Columns(15).HeaderText = "Data Emissão"
        DataGrid.Columns(16).HeaderText = "Data Vencimento"
        DataGrid.Columns(17).HeaderText = "Data Pagamento"
        DataGrid.Columns(18).HeaderText = "Status Nota"
        'DataGrid.Columns(19).HeaderText = "Cód. Reg. Entrada"

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(6).Width = 50
        DataGrid.Columns(7).Width = 150
        DataGrid.Columns(8).Width = 50
        DataGrid.Columns(5).Width = 100
        DataGrid.Columns(18).Width = 90

        DataGrid.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(8).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(15).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(16).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(17).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid.Columns(18).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


        DataGrid.Columns(5).DefaultCellStyle.Format = "c"
        DataGrid.Columns(9).DefaultCellStyle.Format = "c"
        DataGrid.Columns(10).DefaultCellStyle.Format = "c"
        DataGrid.Columns(11).DefaultCellStyle.Format = "c"
        DataGrid.Columns(12).DefaultCellStyle.Format = "c"
        DataGrid.Columns(13).DefaultCellStyle.Format = "c"
        DataGrid.Columns(14).DefaultCellStyle.Format = "c"

    End Sub


    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub


    Private Sub FrmPagamentoEfetuado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListarTudo()

        If statusBtn = "Visible" Then
            GBoxExluir.Visible = True

            'TxtIdReg.Text = DataGrid.CurrentRow.Cells(0).Value
            ' TxtIdRegDup.Text = DataGrid.CurrentRow.Cells(1).Value
        End If

    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then

            If statusBtn = "Visible" Then

                TxtIdReg.Text = DataGrid.CurrentRow.Cells(0).Value
                TxtIdRegDup.Text = DataGrid.CurrentRow.Cells(1).Value


            End If
        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If TxtIdReg.Text <> "" And TxtIdRegDup.Text <> "" Then


            Dim linhaPed As Integer
            Try
                Abrir()
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader


                sql = "SELECT MAX(id) AS Id FROM mvto_pagamentos WHERE id_duplicata = '" & TxtIdRegDup.Text & "' "

                cmdp = New MySqlCommand(sql, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
                    linhaPed = ultima("id")
                    ultima.Close()
                Else
                    ultima.Close()
                End If

            Catch ex As Exception
                MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
            End Try


            If TxtIdReg.Text = linhaPed Then


                If MsgBox("Deseja excluir registro?", vbYesNo, "Exclusão") = vbYes Then

                    Try
                        Abrir()

                        'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                        Dim cmd As MySqlCommand
                        Dim sql As String

                        sql = "DELETE FROM mvto_pagamentos where id = '" & TxtIdReg.Text & "' "
                        cmd = New MySqlCommand(sql, con)
                        cmd.ExecuteNonQuery()

                        TxtIdReg.Text = ""
                        MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Exlusão")

                    Catch ex As Exception
                        MsgBox("Erro ao excluir!!" + ex.Message)
                    End Try

                End If


            Else
                MsgBox("Duplicata possui mais de um registro de pagamento, é necessário primeiro excluir o último pagamento dessa duplicata para prosseguir!!", MsgBoxStyle.Information, "Exluir pagamento")

                Exit Sub
            End If
        Else

            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Exlusão")
        End If

    End Sub

    Private Sub FrmPagamentoEfetuado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        BtnExcluir.Visible = False
        TxtIdReg.Visible = False
        LblId.Visible = False
        statusBtn = ""
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        ListarFiltro()
    End Sub


End Class