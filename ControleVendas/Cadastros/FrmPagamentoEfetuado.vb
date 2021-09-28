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
        DataGrid.Columns(18).Visible = False
        DataGrid.Columns(21).Visible = False
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
        'DataGrid.Columns(18).HeaderText = "Status Nota"
        'DataGrid.Columns(19).HeaderText = "Cód. Reg. Entrada"
        DataGrid.Columns(20).HeaderText = "Portador"
        'DataGrid.Columns(20).HeaderText = "ID Portador"

        DataGrid.Columns(0).Width = 50
        DataGrid.Columns(2).Width = 50
        DataGrid.Columns(4).Width = 50
        DataGrid.Columns(3).Width = 150
        DataGrid.Columns(6).Width = 50
        DataGrid.Columns(7).Width = 150
        DataGrid.Columns(8).Width = 50
        DataGrid.Columns(5).Width = 100
        'DataGrid.Columns(18).Width = 90

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

        ' DataGrid.Columns(18).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        ' DataGrid.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


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
            'GBoxExluir.Visible = True
            BtnExcluir.Enabled = True

        End If

    End Sub

    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If e.RowIndex > -1 Then


            TxtIdReg.Text = DataGrid.CurrentRow.Cells(0).Value
            TxtIdRegDup.Text = DataGrid.CurrentRow.Cells(1).Value
            TxtNota.Text = DataGrid.CurrentRow.Cells(4).Value
            TxtParcela.Text = DataGrid.CurrentRow.Cells(8).Value
            TxtValorParcela.Text = DataGrid.CurrentRow.Cells(9).Value
            TxtValorPago.Text = DataGrid.CurrentRow.Cells(10).Value
            TxtFornecedor.Text = DataGrid.CurrentRow.Cells(3).Value
            TxtTotaVenda.Text = DataGrid.CurrentRow.Cells(5).Value
            TxtPortador.Text = DataGrid.CurrentRow.Cells(20).Value

        End If
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        'Stop
        Dim total As Double
        Dim parcela As Double
        Dim saldo As String

        If TxtIdReg.Text <> "" And TxtIdRegDup.Text <> "" Then

            If MsgBox("Deseja excluir registro?", vbYesNo, "Exclusão") = vbYes Then

                Try
                    Abrir()

                    'PROGRAMANDO EXCLUSÃO DE REGISTRO NO BANCO
                    Dim cmd As MySqlCommand
                    Dim sql As String

                    sql = "DELETE FROM mvto_pagamentos where id = '" & TxtIdReg.Text & "' "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()


                    'BUSCANDO TOTAL PAGO NO MVTO PAGAMENTOS
                    Dim cmd3 As MySqlCommand
                    Dim reader3 As MySqlDataReader
                    Dim sql3 As String
                    sql3 = "Select SUM(valor_pago) As valor_pago, valor_parcela FROM mvto_pagamentos WHERE id_duplicata = '" & TxtIdRegDup.Text & "' "
                    cmd3 = New MySqlCommand(sql3, con)
                    reader3 = cmd3.ExecuteReader

                    reader3.Read()

                    If Not IsDBNull(reader3("valor_pago")) Then

                        total = reader3("valor_pago")
                        parcela = reader3("valor_parcela")

                        reader3.Close()
                    Else
                        reader3.Close()
                        parcela = TxtValorParcela.Text
                    End If

                    saldo = parcela - total

                    'ATUALIZAR SALDO NA TABELA DUPLICATAS
                    Dim cmd1 As MySqlCommand
                    Dim sql1 As String
                    sql1 = "UPDATE duplicatas SET saldo_duplicata = '" & saldo.Replace(",", ".") & "' WHERE id = '" & TxtIdRegDup.Text & "' "
                    cmd1 = New MySqlCommand(sql1, con)
                    cmd1.ExecuteNonQuery()



                    Excluir_mvto_portador()

                    TxtIdReg.Text = ""
                    TxtIdRegDup.Text = ""
                    TxtNota.Text = ""
                    TxtParcela.Text = ""
                    TxtValorPago.Text = ""
                    TxtValorParcela.Text = ""

                    ListarTudo()


                    MsgBox("Registro excluído com Sucesso!!", MsgBoxStyle.Information, "Excluir Pagamento")

                Catch ex As Exception
                    MsgBox("Erro ao excluir!!" + ex.Message)
                End Try

            End If

        Else

            MsgBox("Selecione um registro para excluir!!", MsgBoxStyle.Information, "Exlusão")
        End If

    End Sub
    Sub Excluir_mvto_portador()
        'Stop
        Try
            Abrir()

            'ATUALIZAR MVTO PORTADOR
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim tipoMov As String
            tipoMov = "Saída"

            sql1 = "DELETE FROM mvto_portador WHERE tipo = '" & tipoMov & "' and id_duplicata =  '" & TxtIdRegDup.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao excluir mvto portador!!" + ex.Message)
        End Try
    End Sub
    Private Sub FrmPagamentoEfetuado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        statusBtn = ""
    End Sub

    Private Sub TxtPesquisar_TextChanged(sender As Object, e As EventArgs) Handles TxtPesquisar.TextChanged
        ListarFiltro()
    End Sub


End Class