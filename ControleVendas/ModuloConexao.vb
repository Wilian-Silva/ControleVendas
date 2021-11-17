Imports MySql.Data.MySqlClient

Module ModuloConexao

    'Public con As New MySqlConnection("server=localhost; userid=root; password=; database=controle_vendas_oficial; port=;")
    Public con As New MySqlConnection("server=localhost; userid=root; password=; database=controle_vendas; port=; SslMode=none;")
    'Public con As New MySqlConnection("server=mysql746.umbler.com; userid=xufu; password=EZBjW9LtUscBmb; database=controle_vendas; port=41890;")

    Sub Abrir()
        'Stop
        If con.State = 0 Then
            con.Open()
        End If

    End Sub

    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub

    'DECLAÇÃO DE VARIAVEIS GLOBAIS
    Public bs As New BindingSource() 'Tabela duplicatas a pagar
    Public bsd As New BindingSource() 'Tabela duplicatas a receber

    Public Table1Duplicatas As New DataTable("MyTable")

    Public Table1DuplicatasReceber As New DataTable("MyTable")

    Public dgStatus As String

    Public novoProduto As String

    Public relatorio As String

    Public ValorUntPedido As String

    Public editarMvtoPortador As String

    Public PedidoRelCompra As String

    Public parcela As Integer

    Public saldoEstoque As Integer

    Public IdDuplicata2 As Integer
    Public utilizarPedido As String

    Public nomeFuncionario As String
    Public especialidade As String

    Public codCliente As String
    Public nomeCliente As String

    Public cumpomPesquisar As String
    Public idVenda As String

    Public codFornecedor As String
    Public nomeFornecedor As String

    Public nomeProduto As String
    Public codProduto As String

    Public numeroPedido As String
    Public nomePedido As String
    Public totalPedido As String

    Public novaEntrada As String
    Public novaVenda As String
    Public editarVenda As String

    Public IdPedido As String
    Public StatusPedido As String

    Public IncluirPedido As String

    Public numeroNota As String
    Public valorUnit As String
    Public idNota As String
    Public statusBtn As String

    Public index As Integer

    Public pesquisarDuplicata As String
    Public IdDuplicata As String
    Public IdPortador As String
    Public CodPortador As String
    Public PesquisarPortador As String

    Public custoUntario As String
    Public pesquisarCliente As String
    Public pesquisarProduto As String
    Public nivelAcesso As String
    Public editarpedido As String
    Public pedidoPesquisar As String
    Public editarFornecedor As String
    Public novoFonecedor As String
    Public pesquisarFornecedor As String
    Public editarDuplicata As String

    Public dataInicial As Date
    Public dataFinal As Date


    Public PesqTituloTelaIncial As String
    Public PesqTituloidVenda As Integer
    Public PesqidDuplicata As Integer



    Public Sub LimparVariaveisGlobais()

        PedidoRelCompra = "'"
        editarMvtoPortador = ""
        saldoEstoque = Nothing
        utilizarPedido = ""
        totalPedido = ""
        nomePedido = ""
        pesquisarDuplicata = ""
        IdDuplicata = ""
        nomeFuncionario = ""
        especialidade = ""
        codCliente = ""
        nomeCliente = ""
        nomeProduto = ""
        codProduto = ""
        numeroPedido = ""
        nomeFornecedor = ""
        numeroNota = ""
        valorUnit = ""
        idNota = ""
        statusBtn = ""
        editarVenda = ""
        index = Nothing
        IdPedido = ""
        StatusPedido = ""
        novaVenda = ""
        custoUntario = ""
        pesquisarCliente = ""
        pesquisarProduto = ""
        editarpedido = ""
        pedidoPesquisar = ""
        editarFornecedor = ""
        novoFonecedor = ""
        pesquisarFornecedor = ""
        nomeFornecedor = ""
        codFornecedor = ""
    End Sub

    Public Function Func_Ultimo_Dia_Mes(paramDataX As Date) As Date
        Func_Ultimo_Dia_Mes = DateAdd("m", 1, DateSerial(Year(paramDataX), Month(paramDataX), 1))
        Func_Ultimo_Dia_Mes = DateAdd("d", -1, Func_Ultimo_Dia_Mes)
    End Function

    Public Function CorTxtBox(nomeCampo As Control, codCor As String)

        If codCor = "Am" Then
            nomeCampo.BackColor = Color.LightGoldenrodYellow
        ElseIf codCor = "Br" Then
            nomeCampo.BackColor = Color.White
        Else
            nomeCampo.BackColor = Color.White
        End If
#Disable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código
    End Function
#Enable Warning BC42105 ' A função não retorna um valor em todos os caminhos de código

End Module
