Imports MySql.Data.MySqlClient

Public Class FrmAddItemVenda
    Dim total As String

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



    Private Sub FrmAddItemPedido_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If pesquisarProduto = "True" Then
            TxtCodProduto.Text = codProduto
            TxtProduto.Text = nomeProduto
            TxtValorUnit.Text = valorUnit
            TxtSaldoEstoque.Text = saldoEstoque
            pesquisarProduto = ""
            saldoEstoque = Nothing
        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'Stop

        If TxtQuantidade.Text > TxtSaldoEstoque.Text Then

            MsgBox("Saldo em estoque insuficiente!", MsgBoxStyle.Information, "Saldo estoque")

            Exit Sub
        End If

        TxtQuantidade.BackColor = Color.White
        TxtProduto.BackColor = Color.White

        If TxtQuantidade.Text <> "" And TxtValorUnit.Text <> "" Then

            If MsgBox("Deseja incluir o item " + TxtItem.Text + " na venda " + TxtIdRegistro.Text + "?", vbYesNo, "Venda Produtos") = vbYes Then

                Inserir_venda()

                Atualizar_venda_cabecalho()

                Inserir_Saida_Estoque()

                SalvarSaldoItem()

                MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar Registro")

                Me.Close()

            End If
        Else

            TxtQuantidade.BackColor = Color.Salmon
            TxtProduto.BackColor = Color.Salmon

            MsgBox("Campos vazio ou em branco!!", MsgBoxStyle.Information, "Campos vazios")

        End If
    End Sub
    Private Sub SalvarSaldoItem()
        'Stop
        Try
            Abrir()

            Dim cmd As MySqlCommand
            Dim sql As String

            Dim saldoItem As Integer
            Dim codItem As Integer
            Dim qtd As Integer
            Dim saldoEstoque As Integer

            Dim dbl1 As Double = 0
            Dim dbl2 As Double = 0

            Double.TryParse(TxtQtdOriginal.Text, dbl1)
            Double.TryParse(TxtQuantidade.Text, dbl2)

            qtd = (dbl1 - dbl2).ToString("n")

            codItem = TxtCodProduto.Text

            Dim cmdp As MySqlCommand
            Dim sqlp As String
            Dim ultima As MySqlDataReader

            sqlp = "SELECT saldo_estoque FROM produtos WHERE id= '" & codItem & "'"
            cmdp = New MySqlCommand(sqlp, con)
            ultima = cmdp.ExecuteReader()

            If (ultima.Read()) Then
                saldoEstoque = ultima("saldo_estoque")
                ultima.Close()
            Else
                ultima.Close()
            End If

            saldoItem = saldoEstoque + qtd

            sql = "UPDATE produtos SET saldo_estoque = '" & saldoItem & "' WHERE id = '" & codItem & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try


    End Sub
    Sub Atualisar_Saida_Estoque()
        'Stop
        Try
            Abrir()
            Dim tipomov As String
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            tipomov = "Saída"
            sql1 = "UPDATE estoque SET quantidade ='" & TxtQuantidade.Text & "', valor_unitario = '" & TxtValorUnit.Text.Replace(",", ".") & "', valor_total = '" & TxtValorTotal.Text.Replace(",", ".") & "' WHERE id_venda =  '" & TxtIdRegistro.Text & "' AND item =  '" & TxtItem.Text & "' and tipo = '" & tipomov & "'"
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Sub Inserir_Saida_Estoque()
        'Stop
        Try
            Abrir()

            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim data1 As String
            data1 = Now().ToString("yyyy-MM-dd")

            Dim tipomvto As String
            tipomvto = "Saída"

            sql1 = "INSERT INTO estoque (data_registro, tipo, cod_produto, produto, quantidade, valor_unitario, valor_total, id_venda, item) VALUES ('" & data1 & "', '" & tipomvto & "', '" & TxtCodProduto.Text & "','" & TxtProduto.Text & "', '" & TxtQuantidade.Text & "', '" & TxtValorUnit.Text.Replace(",", ".") & "', '" & TxtValorTotal.Text.Replace(",", ".") & "', '" & TxtIdRegistro.Text & "', '" & TxtItem.Text & "')"
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try
    End Sub
    Sub Inserir_venda()
        'Stop

        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim data1 As String
            data1 = DataVenda.Value.ToString("yyyy-MM-dd")


            sql = "INSERT INTO venda (id_venda, item, data_venda, cod_cliente, cliente, cod_produto, produto, quantidade, valor_unitario, valor_total) " _
                & " VALUES ('" & TxtIdRegistro.Text & "', '" & TxtItem.Text & "', '" & data1 & "','" & TxtCodCliente.Text & "','" & TxtCliente.Text & "','" & TxtCodProduto.Text & "','" & TxtProduto.Text & "','" & TxtQuantidade.Text & "','" & TxtValorUnit.Text.Replace(",", ".") & "' ,'" & TxtValorTotal.Text.Replace(",", ".") & "')"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

            MsgBox("Erro ao Salvar!!" + ex.Message)
        End Try

    End Sub

    Sub Atualizar_venda_cabecalho()
        'Stop
        Try
            '.....................................................................................                   
            'CONSULTAR TOTAL NA TABELA VENDA
            Abrir()
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String

            sql3 = "SELECT SUM(valor_total) as valor_tota FROM venda WHERE id_venda =  '" & TxtIdRegistro.Text & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            reader3.Read()

            If Not IsDBNull(reader3("valor_tota")) Then
                total = reader3("valor_tota")
                reader3.Close()
            Else
                reader3.Close()
            End If

            'ATUALIZAR TOTAL VENDA_CABECALHO
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            sql1 = "UPDATE venda_cabecalho SET valor_total= '" & total.Replace(",", ".") & "', saldo_venda = '" & total.Replace(",", ".") & "' WHERE id_venda =  '" & TxtIdRegistro.Text & "' "
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao editar!!" + ex.Message)
        End Try

    End Sub

    Private Sub BtnPesqProduto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPesqProduto_Click_1(sender As Object, e As EventArgs) Handles BtnPesqProduto.Click
        pesquisarProduto = "True"
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub


End Class