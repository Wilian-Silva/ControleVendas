Imports MySql.Data.MySqlClient

Public Class FrmDuplReceber

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CbQtdDias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbQtdDias.SelectedIndexChanged
        Dim dias As Integer
        Dim hoje As Date
        hoje = DataEmissao.Value
        dias = CbQtdDias.Text

        DataVencimento.Value = DateAdd("d", dias, hoje)

    End Sub

    Private Sub FrmDuplicatas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtParcela.Focus()



        Dim linhaPed As Integer

        If editarDuplicata = "True" Then
            BtnSalvar.Enabled = True
            BtnOk.Enabled = False
            Exit Sub
        End If

        If novaVenda = "True" Then
            BtnOk.Enabled = True
            BtnSalvar.Enabled = False
            TxtParcela.Text = parcela + 1
            parcela = TxtParcela.Text

        Else

            Try
                Abrir()
                Dim cmdp As MySqlCommand
                Dim sql As String
                Dim ultima As MySqlDataReader

                sql = "SELECT MAX(parcela) AS Item FROM duplicatas_receber WHERE id_venda = '" & TxtNum_venda.Text & "' "

                cmdp = New MySqlCommand(sql, con)
                ultima = cmdp.ExecuteReader()
                ultima.Read()

                If Not IsDBNull(ultima("Item")) Then

                    linhaPed = ultima("Item")
                    ultima.Close()
                Else
                    ultima.Close()
                End If



                TxtParcela.Text = linhaPed + 1

            Catch ex As Exception
                MsgBox("Erro ao buscar ultimo parcela!! ---- " + ex.Message)
            End Try


        End If

    End Sub

    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click

        TxtParcela.BackColor = Color.White
        TxtTotalDuplicata.BackColor = Color.White
        TxtNum_venda.BackColor = Color.White

        If TxtParcela.Text <> "" And TxtTotalDuplicata.Text <> "" And TxtNum_venda.Text <> "" Then

            If Table1DuplicatasReceber.Columns.Count < 1 Then
                Table1DuplicatasReceber.Columns.Add("Id. Dup.")
                Table1DuplicatasReceber.Columns.Add("Parcela")
                Table1DuplicatasReceber.Columns.Add("Documento")
                Table1DuplicatasReceber.Columns.Add("Data Emissão")
                Table1DuplicatasReceber.Columns.Add("Data Vencimento")
                Table1DuplicatasReceber.Columns.Add("Valor Parcela")
                Table1DuplicatasReceber.Columns.Add("Observação")
                Table1DuplicatasReceber.Columns.Add("Id Portador")

                bsd.DataSource = Table1DuplicatasReceber

                Table1DuplicatasReceber.Rows.Add("", TxtParcela.Text, TxtNum_venda.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text, TxtIdportador.Text)
                Me.Close()

            Else
                Table1DuplicatasReceber.Rows.Add("", TxtParcela.Text, TxtNum_venda.Text, DataEmissao.Value.ToShortDateString, DataVencimento.Value.ToShortDateString, TxtTotalDuplicata.Text, TxtObs.Text, TxtIdportador.Text)

                Me.Close()
            End If
        Else

            TxtParcela.BackColor = Color.Salmon
            TxtNum_venda.BackColor = Color.Salmon
            TxtTotalDuplicata.BackColor = Color.Salmon
            MsgBox("Campos em branco ou vazios", MsgBoxStyle.Information, "Adicionar duplicatas")
        End If

    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'Stop
        TxtParcela.BackColor = Color.White
        TxtTotalDuplicata.BackColor = Color.White
        TxtNum_venda.BackColor = Color.White

        If TxtParcela.Text <> "" And TxtTotalDuplicata.Text <> "" And TxtNum_venda.Text <> "" Then
            If MsgBox("Deseja salvar alterações ?", vbYesNo, "Editar duplicatas") = vbYes Then

                If editarDuplicata = "True" Then

                    'SALVAR UPDATE DIRETAMENTE NO BANCO DE DADOS
                    Dim cmd1 As MySqlCommand
                    Dim sqls1 As String
                    Dim vencimento1 As String

                    vencimento1 = DataVencimento.Value.ToString("yyyy-MM-dd")

                    sqls1 = "UPDATE duplicatas_receber SET data_vencimento = '" & vencimento1 & "', valor_parcela = '" & TxtTotalDuplicata.Text.Replace(",", ".") & "', observacao = '" & TxtObs.Text & "' , saldo_duplicata = '" & TxtTotalDuplicata.Text.Replace(",", ".") & "' , id_portador = '" & TxtIdportador.Text & "' WHERE id = '" & TxtId_Reg.Text & "'"
                    cmd1 = New MySqlCommand(sqls1, con)
                    cmd1.ExecuteNonQuery()

                    editarDuplicata = ""
                    Me.Close()
                    Exit Sub

                Else

                    Dim cmd As MySqlCommand
                    Dim sqls As String
                    Dim emissao As String
                    Dim vencimento As String

                    emissao = DataEmissao.Value.ToString("yyyy-MM-dd")
                    vencimento = DataVencimento.Value.ToString("yyyy-MM-dd")

                    sqls = "INSERT INTO duplicatas_receber (parcela, id_venda, data_venda, data_vencimento, valor_parcela, observacao, cod_cliente, cliente, saldo_duplicata, id_portador) VALUES ('" & TxtParcela.Text & "','" & TxtNum_venda.Text & "',  '" & emissao & "','" & vencimento & "', '" & TxtTotalDuplicata.Text.Replace(",", ".") & "', '" & TxtObs.Text & "' ,'" & TxtIdCliente.Text & "', '" & TxtCliente.Text & "', '" & TxtTotalDuplicata.Text.Replace(",", ".") & "', '" & TxtIdportador.Text & "')"
                    cmd = New MySqlCommand(sqls, con)
                    cmd.ExecuteNonQuery()

                    Me.Close()

                    Exit Sub

                End If


            End If

        Else

            TxtParcela.BackColor = Color.Salmon
            TxtNum_venda.BackColor = Color.Salmon
            TxtTotalDuplicata.BackColor = Color.Salmon
            MsgBox("Campos em branco ou vazios", MsgBoxStyle.Information, "Adicionar duplicatas")
        End If
    End Sub

    Private Sub TxtParcela_Enter(sender As Object, e As EventArgs) Handles TxtParcela.Enter
        CorTxtBox(TxtParcela, "Am")
    End Sub

    Private Sub TxtParcela_Leave(sender As Object, e As EventArgs) Handles TxtParcela.Leave
        CorTxtBox(TxtParcela, "Br")
    End Sub

    Private Sub TxtTotalDuplicata_Enter(sender As Object, e As EventArgs) Handles TxtTotalDuplicata.Enter
        CorTxtBox(TxtTotalDuplicata, "Am")
    End Sub

    Private Sub TxtTotalDuplicata_Leave(sender As Object, e As EventArgs) Handles TxtTotalDuplicata.Leave
        CorTxtBox(TxtTotalDuplicata, "Br")
    End Sub

    Private Sub CbPortador_Enter(sender As Object, e As EventArgs)
        CorTxtBox(CbPortador, "Am")
    End Sub

    Private Sub CbPortador_Leave(sender As Object, e As EventArgs)
        CorTxtBox(CbPortador, "Br")
    End Sub

    Private Sub TxtObs_Enter(sender As Object, e As EventArgs) Handles TxtObs.Enter
        CorTxtBox(TxtObs, "Am")
    End Sub

    Private Sub TxtObs_Leave(sender As Object, e As EventArgs) Handles TxtObs.Leave
        CorTxtBox(TxtObs, "Br")
    End Sub

    Private Sub BtnPortador_Click(sender As Object, e As EventArgs) Handles BtnPortador.Click
        PesquisarPortador = "True"
        Dim frm As New FrmPortador
        frm.ShowDialog()
    End Sub

    Private Sub FrmDuplReceber_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TxtIdportador.Text = IdPortador
        CbPortador.Text = CodPortador
    End Sub
End Class