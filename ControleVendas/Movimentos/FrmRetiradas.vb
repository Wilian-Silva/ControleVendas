Imports MySql.Data.MySqlClient

Public Class FrmRetiradas
    Dim IdRetirada As Integer
    Private Sub FrmRetiradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNfeEntrada.Focus()
        TxtNfeEntrada.Select()
    End Sub

    Sub Limpar_Campos()
        TxtIdNfeEntrada.Text = ""
        TxtIdNfeEntrada.Text = ""
        TxtFornecedor.Text = ""
        TxtIdportador.Text = ""
        TxtPortador.Text = ""
        TxtValor.Text = ""
    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        'Stop
        TxtNfeEntrada.BackColor = Color.White
        TxtValor.BackColor = Color.White
        TxtPortador.BackColor = Color.White

        If TxtIdNfeEntrada.Text <> "" And TxtValor.Text <> "" And TxtIdportador.Text <> "" Then


            If MsgBox("Deseja salvar esse registro?", vbYesNo, "Salvar") = vbYes Then

                Dim data1 As String
                data1 = DataMvto.Value.ToString("yyyy-MM-dd")
                'BUSCAR INFORMAÇÕES DA TABELA E MOSTRAR NO DATAGRID
                Try
                    Abrir()

                    Dim sql As String
                    Dim cmd As MySqlCommand

                    sql = "INSERT INTO tbl_retiradas (id_entrada_nfe, nota, tipo, id_portador, portador, valor_retirada, data_registro) VALUES ( '" & TxtIdNfeEntrada.Text & "', '" & TxtNfeEntrada.Text & "', '" & TxtTipoMvto.Text & "' , '" & TxtIdportador.Text & "', '" & TxtPortador.Text & "', '" & TxtValor.Text.Replace(",", ".") & "', '" & data1 & "' ) "
                    cmd = New MySqlCommand(sql, con)
                    cmd.ExecuteNonQuery()

                    Pesquisar_Id_Retirada()

                    Salvar_Portador()

                    Limpar_Campos()

                    MsgBox("Registro salvo com Sucesso!!", MsgBoxStyle.Information, "Salvar")

                    Me.Close()

                Catch ex As Exception
                    MsgBox("Erro ao salvar Retirada Lucro:  " + ex.Message)
                End Try
            End If
        Else

            TxtNfeEntrada.BackColor = Color.Salmon
            TxtValor.BackColor = Color.Salmon
            TxtPortador.BackColor = Color.Salmon

            MsgBox("Campos vazios!!", MsgBoxStyle.Information, "Salvar")
        End If

    End Sub

    Sub Pesquisar_Id_Retirada()
        Try
            Dim cmd3 As MySqlCommand
            Dim reader3 As MySqlDataReader
            Dim sql3 As String

            sql3 = "Select MAX(id) as id FROM tbl_retiradas "
            cmd3 = New MySqlCommand(sql3, con)
            reader3 = cmd3.ExecuteReader
            reader3.Read()
            If Not IsDBNull(reader3("id")) Then

                IdRetirada = reader3("id")
                reader3.Close()

            Else
                reader3.Close()

            End If

        Catch ex As Exception
            MsgBox("Erro ao Consultar_retirada!!" + ex.Message)
        End Try

    End Sub
    Sub Salvar_Portador()

        Dim data1 As String
        data1 = DataMvto.Value.ToString("yyyy-MM-dd")

        Try

            Dim sql As String
            Dim cmd As MySqlCommand

            sql = "INSERT INTO mvto_portador (id_portador, nome, tipo, data, valor, id_duplicata, pagador_recebedor, id_retirada) VALUES ('" & TxtIdportador.Text & "', '" & TxtPortador.Text & "' , '" & TxtTipoMvto.Text & "', '" & data1 & "' , '" & TxtValor.Text.Replace(",", ".") & "' ,'" & TxtNfeEntrada.Text & "', '" & TxtFornecedor.Text & "', '" & IdRetirada & "' ) "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao salvar Portador:  " + ex.Message)
        End Try


    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub TxtValor_Enter(sender As Object, e As EventArgs) Handles TxtValor.Enter
        CorTxtBox(TxtValor, "Am")
    End Sub

    Private Sub TxtValor_Leave(sender As Object, e As EventArgs) Handles TxtValor.Leave
        CorTxtBox(TxtValor, "Br")
    End Sub

    Private Sub BtnPortador_Click(sender As Object, e As EventArgs) Handles BtnPortador.Click
        PesquisarPortador = "True"
        Dim frm As New FrmPortador
        frm.ShowDialog()
    End Sub

    Private Sub FrmRetiradas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If PesquisarPortador = "True" Then
            TxtIdportador.Text = IdPortador
            TxtPortador.Text = CodPortador
        End If

        If pesquisarNotaEntrada = "True" Then
            TxtIdNfeEntrada.Text = nfeIdNotaEntrada
            TxtNfeEntrada.Text = nfeNotaEntrada
            TxtFornecedor.Text = nfeFornecedor

        End If
    End Sub

    Private Sub BtnNfe_Click(sender As Object, e As EventArgs) Handles BtnNfe.Click
        pesquisarNotaEntrada = "True"
        Dim frm As New FrmEntradas
        frm.ShowDialog()
    End Sub

    Private Sub FrmRetiradas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        nfeNotaEntrada = ""
        nfeIdNotaEntrada = ""
        nfeFornecedor = ""
        IdPortador = ""
        CodPortador = ""
        pesquisarNotaEntrada = ""
        PesquisarPortador = ""
    End Sub
End Class