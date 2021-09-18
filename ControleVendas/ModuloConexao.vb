Imports MySql.Data.MySqlClient

Module ModuloConexao

    Public con As New MySqlConnection("server=localhost; userid=root; password=; database=controle_vendas; port=;")
    'Public con As New MySqlConnection("server=mysql746.umbler.com; userid=xufu; password=EZBjW9LtUscBmb; database=controle_vendas; port=41890;")

    Sub Abrir()

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
    Public bs As New BindingSource()

    Public Table1Duplicatas As New DataTable("MyTable")
    Public parcela As Integer

    Public IdDuplicata2 As Integer
    Public utilizarPedido As String

    Public nomeFuncionario As String
    Public especialidade As String

    Public codCliente As String
    Public nomeCliente As String

    Public codFornecedor As String
    Public nomeFornecedor As String

    Public nomeProduto As String
    Public codProduto As String

    Public numeroPedido As String
    Public nomePedido As String
    Public totalPedido As String

    Public novaEntrada As String

    Public IdPedido As String
    Public StatusPedido As String

    Public IncluirPedido As String

    Public numeroNota As String
    Public valorUnit As String
    Public idNota As String
    Public statusBtn As String
    Public editarVenda As String
    Public index As Integer

    Public pesquisarDuplicata As String
    Public IdDuplicata As String

    Public novavenda As String
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



    Public Sub LimparVariaveisGlobais()
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
        novavenda = ""
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

End Module
