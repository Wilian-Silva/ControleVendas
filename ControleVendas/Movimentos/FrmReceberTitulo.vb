Imports MySql.Data.MySqlClient

Public Class FrmReceberTitulo



    Dim proximo As Integer
    Dim anterior As Integer
    Dim maximo As Integer

    Private Sub BtnBaixarTitulo_Click(sender As Object, e As EventArgs) Handles BtnBaixarTitulo.Click

        If TxtStatusTitulo.Text = "Pgto. Total" Then

            MsgBox("Título totalmente baixado!!", MsgBoxStyle.Information, "Baixar Título")

            Exit Sub
        End If

        Dim TotalAdto As String = 0
        Dim compensarAdto As String = ""

        If TxtCodCliente.Text <> "" Then
            Dim cliente As String
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            cliente = TxtCodCliente.Text

            sql3 = "Select SUM(adto) as adto FROM mvto_recebimentos WHERE cod_cliente = '" & cliente & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            reader3.Read()
            If Not IsDBNull(reader3("adto")) Then

                TotalAdto = reader3("adto") * -1
                reader3.Close()

                If TotalAdto > 0 Or TotalAdto < 0 Then

                    If MsgBox("Cliente: " & TxtNomeCliente.Text & " possui R$ " & TotalAdto & " de adiantamento, Deseja compensar no título " & Txt_venda.Text & " Parcela " & TxtParcela.Text & "?", vbYesNo, "Recebimento") = vbYes Then

                        compensarAdto = "Yes"
                    Else
                        compensarAdto = "No"
                    End If
                End If

            Else
                reader3.Close()
                TxtAdto.Text = 0
            End If
        End If

        If MsgBox("Deseja baixar o título " & Txt_venda.Text & " Parcela " & TxtParcela.Text & "?", vbYesNo, "Recebimento") = vbYes Then

            Dim form = New FrmVlrReceb()

            If compensarAdto = "Yes" Then
                form.TxtCompAdto.Text = TotalAdto
            End If

            form.TxtNotaFiscal.Text = Txt_venda.Text
            form.TxtParcela.Text = TxtParcela.Text
            form.TxtCodCliente.Text = TxtCodCliente.Text
            form.TxtNomeCliente.Text = TxtNomeCliente.Text
            form.DataEmissao.Text = DataEmissao.Text
            form.DataVencimento.Text = DataVencimento.Text
            form.TxtValorOriginal.Text = TxtTotalTitulo.Text
            form.TxtSaldoAbertoParcela.Text = TxtSaldoTitulo.Text
            form.TxtRegPagamento.Text = TxtRegRecebimento.Text
            form.TxtValorParcela.Text = TxtValorParcela.Text
            form.TxtIdDuplicata.Text = TxtId_duplicata.Text
            form.TxtRegPagamento.Text = TxtRegRecebimento.Text
            form.TxtStatusTitulo.Text = TxtStatusTitulo.Text
            form.TxtIdportador.Text = TxtIdPortador.Text
            form.CbPortador.Text = TxtPortador.Text
            form.TxtIdNfeEntrada.Text = TxtIdNfeEntrada.Text
            form.TxtNfeEntrada.Text = TxtNfeEntrada.Text

            form.TxtValorPago.Text = CDbl(TxtSaldoTitulo.Text) - CDbl(TotalAdto)

            form.ShowDialog()
        End If

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Me.Close()
    End Sub

    Private Sub FrmPagarTitulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If PesqTituloTelaIncial = "True" Then

            CarregarDadosTitulo()
        Else
            Ultimo_Titulo()
            CarregarDadosTitulo()
        End If


    End Sub

    Sub Ultimo_Titulo()
        Try
            ' Stop
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "Select * FROM duplicatas_receber WHERE id=(Select MAX(id) FROM duplicatas_receber) "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                PesqTituloidVenda = reader("id_venda")
                PesqidDuplicata = reader("id")
                reader.Close()
            Else
                reader.Close()
            End If

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
        End Try
    End Sub

    Private Sub CarregarDadosTitulo()


        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT  d.id_venda, d.id, d.cod_cliente, d.cliente, d.parcela, d.valor_parcela, d.saldo_duplicata, d.data_venda, d.data_vencimento, d.observacao, d.id_portador, p.nome, v.id_nfe, v.nfe " _
            & "FROM duplicatas_receber as d INNER JOIN portador as p ON d.id_portador = p.id INNER JOIN venda as v ON d.id_venda = v.id_venda WHERE d.id= '" & PesqidDuplicata & "' "

            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                Txt_venda.Text = reader("id_venda")
                TxtId_duplicata.Text = reader("id")
                TxtCodCliente.Text = reader("cod_cliente")
                TxtNomeCliente.Text = reader("cliente")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_venda")
                DataVencimento.Text = reader("data_vencimento")
                TxtObeservacao.Text = reader("observacao")
                TxtIdPortador.Text = reader("id_portador")
                TxtPortador.Text = reader("nome")

                TxtIdNfeEntrada.Text = reader("id_nfe")
                TxtNfeEntrada.Text = reader("nfe")

                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "SELECT * FROM venda_cabecalho WHERE id_venda= '" & PesqTituloidVenda & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtTotalTitulo.Text = reader2("valor_total")
                reader2.Close()
            Else
                reader2.Close()
            End If

            ' Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "Select MAX(id) As id , SUM(valor_pago) As valor_pago , SUM(juros_multa) As juros_multa , SUM(descontos) As descontos, SUM(total_pago) As total_pago, data_pagamento, MAX(status_nota) As status_nota, portador , SUM(adto) as adto FROM mvto_recebimentos WHERE id_duplicata = '" & PesqidDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegRecebimento.Visible = True
                LblRegPgto.Visible = True

                TxtRegRecebimento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                TxtAdto.Text = reader3("adto")
                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtAdto.Text = 0

            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try

    End Sub

    Private Sub CarregarDadosPesquisaDuplicata()
        Dim idVenda As Integer
        Dim idDuplicata As Integer


        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT  d.id_venda, d.id, d.cod_cliente, d.cliente, d.parcela, d.valor_parcela, d.saldo_duplicata, d.data_venda, d.data_vencimento, d.observacao, d.id_portador, p.nome, v.id_nfe, v.nfe " _
            & "FROM duplicatas_receber as d INNER JOIN portador as p ON d.id_portador = p.id INNER JOIN venda as v ON d.id_venda = v.id_venda WHERE d.id= '" & TxtIdPesquisar.Text & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                Txt_venda.Text = reader("id_venda")
                TxtId_duplicata.Text = reader("id")
                TxtCodCliente.Text = reader("cod_cliente")
                TxtNomeCliente.Text = reader("cliente")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_venda")
                DataVencimento.Text = reader("data_vencimento")
                TxtObeservacao.Text = reader("observacao")
                TxtIdPortador.Text = reader("id_portador")
                TxtPortador.Text = reader("nome")
                idVenda = reader("id_venda")
                idDuplicata = reader("id")
                TxtIdNfeEntrada.Text = reader("id_nfe")
                TxtNfeEntrada.Text = reader("nfe")
                reader.Close()


            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "SELECT * FROM venda_cabecalho WHERE id_venda= '" & idVenda & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtTotalTitulo.Text = reader2("valor_total")
                reader2.Close()
            Else
                reader2.Close()
            End If

            ' Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "Select MAX(id) As id , SUM(valor_pago) As valor_pago , SUM(juros_multa) As juros_multa , SUM(descontos) As descontos, SUM(total_pago) As total_pago, data_pagamento, MAX(status_nota) As status_nota, portador, SUM(adto) as adto FROM mvto_recebimentos WHERE id_duplicata = '" & idDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegRecebimento.Visible = True
                LblRegPgto.Visible = True

                TxtRegRecebimento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                TxtAdto.Text = reader3("adto")

                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegRecebimento.Visible = False
                LblRegPgto.Visible = False
                TxtAdto.Text = 0

            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If

        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
        ListarPedidoAnterior()
    End Sub

    Sub ListarPedidoAnterior()

        Try
            If TxtId_duplicata.Text <> "" Then
                anterior = TxtId_duplicata.Text - 1
            Else
                anterior = 1
            End If
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sqlp As String
Line1:
            If anterior = 0 Then
                Exit Sub
            End If

            sqlp = "SELECT * FROM duplicatas_receber WHERE id = '" & anterior & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                RegistroAnterior()

                Exit Sub
            Else
                reader.Close()
                anterior -= 1
                GoTo Line1
            End If



        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try



    End Sub

    Sub RegistroAnterior()
        Dim idDuplicata As Integer
        Dim idVenda As Integer
        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT  d.id_venda, d.id, d.cod_cliente, d.cliente, d.parcela, d.valor_parcela, d.saldo_duplicata, d.data_venda, d.data_vencimento, d.observacao, d.id_portador, p.nome, v.id_nfe, v.nfe " _
            & "FROM duplicatas_receber as d INNER JOIN portador as p ON d.id_portador = p.id INNER JOIN venda as v ON d.id_venda = v.id_venda WHERE d.id=  '" & anterior & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                Txt_venda.Text = reader("id_venda")
                TxtId_duplicata.Text = reader("id")
                TxtCodCliente.Text = reader("cod_cliente")
                TxtNomeCliente.Text = reader("cliente")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_venda")
                DataVencimento.Text = reader("data_vencimento")
                TxtObeservacao.Text = reader("observacao")
                TxtIdPortador.Text = reader("id_portador")
                TxtPortador.Text = reader("nome")
                TxtIdNfeEntrada.Text = reader("id_nfe")
                TxtNfeEntrada.Text = reader("nfe")
                idVenda = reader("id_venda")
                idDuplicata = reader("id")
                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "SELECT * FROM venda_cabecalho WHERE id_venda= '" & idVenda & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtTotalTitulo.Text = reader2("valor_total")
                reader2.Close()
            Else
                reader2.Close()
            End If

            ' Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "Select MAX(id) As id , SUM(valor_pago) As valor_pago , SUM(juros_multa) As juros_multa , SUM(descontos) As descontos, SUM(total_pago) As total_pago, data_pagamento, MAX(status_nota) As status_nota, portador ,SUM(adto) as adto FROM mvto_recebimentos WHERE id_duplicata = '" & idDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegRecebimento.Visible = True
                LblRegPgto.Visible = True

                TxtRegRecebimento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                TxtAdto.Text = reader3("adto")
                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0


                TxtAdto.Text = 0
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegRecebimento.Visible = False
                LblRegPgto.Visible = False

            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub BtnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click
        ListarProximoPedido()
    End Sub
    Sub ListarProximoPedido()
        'Stop
        Try

            Try
                Abrir()

                'VERIFICAR ULTIMO ID NO BANCO 
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader

                sql = "SELECT * FROM duplicatas_receber WHERE id =(SELECT MAX(id) FROM duplicatas_receber) "
                cmdp = New MySqlCommand(sql, con)
                ultima = cmdp.ExecuteReader()

                If (ultima.Read()) Then
                    maximo = ultima("id")
                    ultima.Close()
                Else
                    ultima.Close()
                End If


            Catch ex As Exception
                MsgBox("Erro ao Salvar!! " + ex.Message)
            End Try
            '.........................................................................................................

            If TxtId_duplicata.Text <> "" Then
                proximo = TxtId_duplicata.Text + 1
            Else
                proximo = 1
            End If

            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sqlp As String

Line1:
            If proximo > maximo Then
                Exit Sub
            End If

            sqlp = "SELECT * FROM duplicatas_receber WHERE id  = '" & proximo & "' "
            cmd = New MySqlCommand(sqlp, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then
                reader.Close()

                ProximoRegistro()

                Exit Sub
            Else
                reader.Close()
                proximo += 1
                GoTo Line1
            End If


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try
    End Sub

    Private Sub ProximoRegistro()
        'Stop
        Dim idVenda As Integer
        Dim idDuplicata As Integer
        Try
            Abrir()

            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT  d.id_venda, d.id, d.cod_cliente, d.cliente, d.parcela, d.valor_parcela, d.saldo_duplicata, d.data_venda, d.data_vencimento, d.observacao, d.id_portador, p.nome, v.id_nfe, v.nfe " _
            & "FROM duplicatas_receber as d INNER JOIN portador as p ON d.id_portador = p.id INNER JOIN venda as v ON d.id_venda = v.id_venda WHERE d.id= '" & proximo & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                Txt_venda.Text = reader("id_venda")
                TxtId_duplicata.Text = reader("id")
                TxtCodCliente.Text = reader("cod_cliente")
                TxtNomeCliente.Text = reader("cliente")
                TxtParcela.Text = reader("parcela")
                TxtValorParcela.Text = reader("valor_parcela")
                TxtSaldoTitulo.Text = reader("saldo_duplicata")
                DataEmissao.Text = reader("data_venda")
                DataVencimento.Text = reader("data_vencimento")
                TxtObeservacao.Text = reader("observacao")
                TxtIdPortador.Text = reader("id_portador")
                TxtPortador.Text = reader("nome")
                TxtIdNfeEntrada.Text = reader("id_nfe")
                TxtNfeEntrada.Text = reader("nfe")
                idVenda = reader("id_venda")
                idDuplicata = reader("id")
                reader.Close()
            Else
                reader.Close()
            End If
            '.....................................................................................
            'BUSCANDO DADOS NA TBL ENTRADA
            Dim cmd2 As MySqlCommand
            Dim reader2 As MySqlDataReader
            Dim sql2 As String
            sql2 = "SELECT * FROM venda_cabecalho WHERE id_venda= '" & idVenda & "' "
            cmd2 = New MySqlCommand(sql2, con)
            reader2 = cmd2.ExecuteReader
            If reader2.Read = True Then

                TxtTotalTitulo.Text = reader2("valor_total")
                reader2.Close()
            Else
                reader2.Close()
            End If

            ' Stop
            '....................................................................................
            'BUSCANDO DADOS NA TBL MVTO_PAGAMENTOS
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "Select MAX(id) As id , SUM(valor_pago) As valor_pago , SUM(juros_multa) As juros_multa , SUM(descontos) As descontos, SUM(total_pago) As total_pago, data_pagamento, MAX(status_nota) As status_nota, portador, SUM(adto) as adto  FROM mvto_recebimentos WHERE id_duplicata = '" & idDuplicata & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegRecebimento.Visible = True
                LblRegPgto.Visible = True

                TxtRegRecebimento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                TxtAdto.Text = reader3("adto")

                reader3.Close()
            Else


                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0

                TxtAdto.Text = 0
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegRecebimento.Visible = False
                LblRegPgto.Visible = False

            End If


            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try

    End Sub
    Sub Atualizar_Pagina()
        'Stop
        Try
            'BUSCANDO DADOS NA TBL DUPLICATAS
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            sql = "SELECT * FROM duplicatas_receber WHERE id = '" & TxtId_duplicata.Text & "' "
            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader
            If reader.Read = True Then
                TxtSaldoTitulo.Text = reader("saldo_duplicata")

                reader.Close()
            Else
                reader.Close()
            End If



            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String
            sql3 = "Select MAX(id) As id , SUM(valor_pago) As valor_pago , SUM(juros_multa) As juros_multa , SUM(descontos) As descontos, SUM(total_pago) As total_pago, data_pagamento, MAX(status_nota) As status_nota , portador , SUM(adto) as adto FROM mvto_recebimentos WHERE id_duplicata = '" & TxtId_duplicata.Text & "' "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader

            reader3.Read()

            If Not IsDBNull(reader3("id")) Then

                DataPagamento.Visible = True
                LblDataPagamento.Visible = True
                TxtRegRecebimento.Visible = True
                LblRegPgto.Visible = True

                TxtRegRecebimento.Text = reader3("id")
                TxtValorPago.Text = reader3("valor_pago")
                TxtJurosMultas.Text = reader3("juros_multa")
                TxtDescontos.Text = reader3("descontos")
                TxtTotalPago.Text = reader3("total_pago")
                DataPagamento.Text = reader3("data_pagamento")
                TxtAdto.Text = reader3("adto")


                reader3.Close()
            Else

                reader3.Close()
                TxtValorPago.Text = 0
                TxtJurosMultas.Text = 0
                TxtDescontos.Text = 0
                TxtTotalPago.Text = 0
                TxtAdto.Text = 0
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
                TxtRegRecebimento.Visible = False
                LblRegPgto.Visible = False

            End If

            If TxtValorPago.Text = "0" Then
                TxtStatusTitulo.Text = "Aberto"
                DataPagamento.Visible = False
                LblDataPagamento.Visible = False
            Else

                If TxtSaldoTitulo.Text = "0,00" Then
                    TxtStatusTitulo.Text = "Pgto. Total"
                Else

                    TxtStatusTitulo.Text = "Pgto. Parcial"
                End If
            End If


        Catch ex As Exception
            MsgBox("Erro ao carregar dados!! ---- " + ex.Message)
        End Try
    End Sub
    Private Sub BtnCarregar_Click(sender As Object, e As EventArgs) Handles BtnCarregar.Click
        Atualizar_Pagina()
    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click

        pesquisarDuplicata = "True"

        Dim form = New FrmVendaCabecalho
        form.ShowDialog()
    End Sub

    Private Sub FrmPagarTitulo_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        If pesquisarDuplicata = "True" Then

            TxtIdPesquisar.Text = IdDuplicata2

            If TxtIdPesquisar.Text <> "" Then

                CarregarDadosPesquisaDuplicata()
            Else

                Exit Sub
            End If
        Else
            Atualizar_Pagina()
        End If

    End Sub

    Private Sub FrmPagarTitulo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        pesquisarDuplicata = ""
        PesqTituloTelaIncial = ""
        PesqTituloidVenda = 0
        PesqidDuplicata = 0
    End Sub
End Class