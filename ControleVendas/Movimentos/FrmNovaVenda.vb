Imports MySql.Data.MySqlClient

Public Class FrmNovaVenda
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub


    Private mru As FrmVenda
    Public Sub New(ByVal multirows As FrmVenda)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.mru = multirows

    End Sub

    Private Sub BtnPesqCliente_Click(sender As Object, e As EventArgs) Handles BtnPesqCliente.Click
        pesquisarCliente = "True"
        Dim form = New FrmClientes
        form.ShowDialog()
    End Sub

    Private Sub BtnPesqProduto_Click(sender As Object, e As EventArgs) Handles BtnPesqProduto.Click
        pesquisarProduto = "True"
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub

    Private Sub FrmNovaVenda_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtCodCliente.Text = codCliente
        TxtCliente.Text = nomeCliente
        TxtCodProduto.Text = codProduto
        TxtProduto.Text = nomeProduto
        TxtValorUnit.Text = valorUnit
        TxtCustoUnitario.Text = custoUntario
    End Sub

    Private Sub TxtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantidade.TextChanged

        On Error Resume Next

        TxtValorTotal.Text = TxtQuantidade.Text * TxtValorUnit.Text
        TxtCustoTotal.Text = TxtQuantidade.Text * TxtCustoUnitario.Text

    End Sub

    Private Sub CbQtdDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbQtdDias.SelectedIndexChanged

        Dim dias As Integer
        Dim hoje As Date
        hoje = Now()
        dias = CbQtdDias.Text

        DataVencimento.Value = DateAdd("d", dias, hoje)

    End Sub
    Sub Limpar()
        TxtCodCliente.Text = ""
        TxtCliente.Text = ""
        CbFornecedor.Text = ""
        TxtCodProduto.Text = ""
        TxtProduto.Text = ""
        TxtQuantidade.Text = ""
        TxtValorUnit.Text = ""
        TxtValorTotal.Text = ""
        CbFormaPgto.Text = ""
        CbQtdDias.Text = ""
        DataVencimento.Value = Now()
        DataVenda.Value = Now()
        TxtCustoUnitario.Text = 0

    End Sub

    Private Sub FrmNovaVenda_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        codCliente = ""
        nomeCliente = ""
        codProduto = ""
        nomeProduto = ""
        valorUnit = ""
        novavenda = ""
        custoUntario = ""
        TxtCustoUnitario.Text = 0
    End Sub
    Sub GerarIdRegistro()

        Try
            Abrir()

            'VERIFICAR ULTIMO ID NO BANCO E GERAR PROXIMO
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim ultima As MySqlDataReader

            sql = "SELECT id_venda FROM venda_cabecalho WHERE id_venda=(SELECT MAX(id_venda) FROM venda_cabecalho) "
            cmd = New MySqlCommand(sql, con)
            ultima = cmd.ExecuteReader()

            If (ultima.Read()) Then
                TxtIdVenda.Text = ultima("id_venda") + 1
            Else
                TxtIdVenda.Text = 1

            End If

            ultima.Close()

        Catch ex As Exception
            MsgBox("Erro ao Salvar!! " + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalvarEdit.Click


        TxtValorTotal.BackColor = Color.White
        TxtCliente.BackColor = Color.White
        TxtProduto.BackColor = Color.White

        If TxtCodCliente.Text <> "" And TxtCodProduto.Text <> "" And TxtValorTotal.Text <> "" Then

            Try

                Abrir()

                'PROGRAMANDO EDIÇÃO DE REGISTRO NO BANCO
                Dim cmd As MySqlCommand
                Dim sql As String

                Dim data1 As String
                Dim data2 As String

                data1 = DataVenda.Value.ToString("yyyy-MM-dd")
                data2 = DataVencimento.Value.ToString("yyyy-MM-dd")


                sql = "INSERT INTO venda (id_venda, data_venda, cod_cliente, cliente, fornecedor, cod_produto, produto , quantidade, valor_unitario , valor_total, forma_pgto, data_vencimento, custo_total ) VALUES ( '" & TxtIdVenda.Text & "','" & data1 & "',  '" & TxtCodCliente.Text & "' ,'" & TxtCliente.Text & "', '" & CbFornecedor.Text & "' , '" & TxtCodProduto.Text & "', '" & TxtProduto.Text & "' , '" & TxtQuantidade.Text & "' , '" & TxtValorUnit.Text.Replace(",", ".") & "' , '" & TxtValorTotal.Text.Replace(",", ".") & "', '" & CbFormaPgto.Text & "', '" & data2 & "', '" & TxtCustoTotal.Text.Replace(",", ".") & "') "
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()


                'SALVAR REGISTRO NO ESTOQUE
                AtualizarEstoque()

                'SALVAR REGISTRO NO RESUMO DE VENDAS
                AtualizarResumoVenda()

                MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao incluir venda!!" + ex.Message)
            End Try


        Else
            TxtValorTotal.BackColor = Color.Salmon
            TxtCliente.BackColor = Color.Salmon
            TxtProduto.BackColor = Color.Salmon
            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Salvar")
            Exit Sub
        End If

    End Sub

    Private Sub FrmNovaVenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If editarVenda <> "Editar Venda" Then
            GerarIdRegistro()
        End If

    End Sub

    Sub AtualizarEstoque()
        'Stop
        Dim cmd As MySqlCommand
        Dim sql As String

        Dim data1 As String
        data1 = DataVenda.Value.ToString("yyyy-MM-dd")

        sql = "INSERT INTO estoque (data_registro , tipo, cod_produto, produto , quantidade, valor_unitario , valor_total,id_venda ) VALUES ( '" & data1 & "',  '" & "Saída" & "', '" & TxtCodProduto.Text & "', '" & TxtProduto.Text & "' , '" & -TxtQuantidade.Text & "' , '" & TxtValorUnit.Text.Replace(",", ".") & "' , '" & TxtValorTotal.Text.Replace(",", ".") & "','" & TxtIdVenda.Text & "') "
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()

    End Sub

    Sub AtualizarResumoVenda()

        Dim cmd As MySqlCommand
        Dim sql As String

        Dim data1 As String
        data1 = DataVenda.Value.ToString("yyyy-MM-dd")

        Dim data2 As String
        data2 = DataVencimento.Value.ToString("yyyy-MM-dd")

        sql = "INSERT INTO venda_cabecalho (id_venda, data_venda, cliente, valor_total , vencimento, valor_recebido, saldo_venda) VALUES ('" & TxtIdVenda.Text & "','" & data1 & "','" & TxtCliente.Text & "',  '" & TxtValorTotal.Text.Replace(",", ".") & "','" & data2 & "', '" & "0.00" & "' ,'" & TxtValorTotal.Text.Replace(",", ".") & "') "
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()

    End Sub



    Private Sub TxtValorUnit_TextChanged(sender As Object, e As EventArgs) Handles TxtValorUnit.TextChanged

        On Error Resume Next

        TxtValorTotal.Text = TxtQuantidade.Text * TxtValorUnit.Text
        TxtCustoTotal.Text = TxtQuantidade.Text * TxtCustoUnitario.Text
    End Sub
End Class