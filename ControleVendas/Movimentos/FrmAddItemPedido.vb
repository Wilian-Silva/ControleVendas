Imports MySql.Data.MySqlClient

Public Class FrmAddItemPedido
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantidade.TextChanged

        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtValorUnit.Text, dbl1)
        Double.TryParse(TxtQuantidade.Text, dbl2)

        TxtValorTotal.Text = (dbl1 * dbl2).ToString("n")

    End Sub

    Private Sub TxtValorUnit_TextChanged(sender As Object, e As EventArgs) Handles TxtValorUnit.TextChanged
        Dim dbl1 As Double = 0
        Dim dbl2 As Double = 0
        Double.TryParse(TxtValorUnit.Text, dbl1)
        Double.TryParse(TxtQuantidade.Text, dbl2)

        TxtValorTotal.Text = (dbl1 * dbl2).ToString("n")
    End Sub

    Private Sub BtnPesqProduto_Click(sender As Object, e As EventArgs) Handles BtnPesqProduto.Click
        pesquisarProduto = "True"
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub

    Private Sub FrmAddItemPedido_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarProduto = "True" Then
            TxtCodProduto.Text = codProduto
            TxtProduto.Text = nomeProduto
            TxtValorUnit.Text = valorUnit
            pesquisarProduto = ""
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        TxtQuantidade.BackColor = Color.White
        TxtValorUnit.BackColor = Color.White

        If TxtQuantidade.Text <> "" And TxtValorUnit.Text <> "" Then


            If MsgBox("Deseja incluir o item " + TxtItem.Text + " no pedido" + TxtIdRegistro.Text + "?", vbYesNo, "Pedido") = vbYes Then

                Try
                    Abrir()
                    Dim cmd As MySqlCommand
                    Dim sql As String
                    Dim data1 As String
                    data1 = DataPed.Value.ToString("yyyy-MM-dd")

                    sql = "INSERT INTO pedidos (pedido, item, descricao, data_emissao, cod_fornecedor, fornecedor, cod_produto, produto, quantidade, valor_unitario, valor_total) " _
                        & " VALUES ('" & TxtIdRegistro.Text & "', '" & TxtItem.Text & "', '" & TxtPedido.Text & "','" & data1 & "','" & TxtCodFornecedor.Text & "','" & TxtFornecedor.Text & "','" & TxtCodProduto.Text & "','" & TxtProduto.Text & "','" & TxtQuantidade.Text & "','" & TxtValorUnit.Text.Replace(",", ".") & "' ,'" & TxtValorTotal.Text.Replace(",", ".") & "')"
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    '.....................................................................................
                    'CONSULTAR TOTAL NA TABELA PEDIDOS
                    Dim dg As New DataGridView
                    Dim da As MySqlDataAdapter
                    Dim sql2 As String
                    Dim dt As New DataTable
                    Dim total As String

                    sql2 = "SELECT SUM(valor_total) as TOTAL FROM pedidos WHERE pedido =  '" & TxtIdRegistro.Text & "' "
                    da = New MySqlDataAdapter(sql2, con)
                    da.Fill(dt)
                    total = dt.Rows(0)("TOTAL").ToString()

                    '............................................................................
                    'ATUALIZAR TOTAL PEDIDO
                    Dim cmd1 As MySqlCommand
                    Dim sql1 As String
                    sql1 = "UPDATE pedido_cabecalho SET total= '" & total & "' WHERE id =  '" & TxtIdRegistro.Text & "' "
                    cmd1 = New MySqlCommand(sql1, con)
                    cmd1.ExecuteNonQuery()

                    MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar Pagamento")

                    Me.Close()

                Catch ex As Exception
                    MsgBox("Erro ao editar!!" + ex.Message)
                End Try

            End If
        Else

            TxtQuantidade.BackColor = Color.Salmon
            TxtValorUnit.BackColor = Color.Salmon

            MsgBox("Campos vazio ou em branco!!", MsgBoxStyle.Information, "Campos vazios")

        End If
    End Sub
End Class