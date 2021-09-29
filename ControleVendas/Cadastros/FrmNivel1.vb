Imports MySql.Data.MySqlClient

Public Class FrmNivel1


    Private Sub CboxAll_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAllCadastros.CheckedChanged

        If CboxAllCadastros.Checked = True Then
            CboxCad1_01.Checked = True
            CboxCad1_02.Checked = True
            CboxCad1_03.Checked = True
            CboxCad1_04.Checked = True
            CboxCad1_05.Checked = True
        Else
            CboxCad1_01.Checked = False
            CboxCad1_02.Checked = False
            CboxCad1_03.Checked = False
            CboxCad1_04.Checked = False
            CboxCad1_05.Checked = False

        End If

    End Sub

    Private Sub CboxAllConsultas_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAllConsultas.CheckedChanged

        If CboxAllConsultas.Checked = True Then
            CboxCons1_07.Checked = True
            CboxCons1_06.Checked = True
            CboxCons1_05.Checked = True
            CboxCons1_04.Checked = True
            CboxCons1_03.Checked = True
            CboxCons1_02.Checked = True
            CboxCons1_01.Checked = True
        Else
            CboxCons1_07.Checked = False
            CboxCons1_06.Checked = False
            CboxCons1_05.Checked = False
            CboxCons1_04.Checked = False
            CboxCons1_03.Checked = False
            CboxCons1_02.Checked = False
            CboxCons1_01.Checked = False

        End If

    End Sub

    Private Sub CboxAllMvto_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAllMvto.CheckedChanged

        If CboxAllMvto.Checked = True Then
            CboxMvto1_01.Checked = True
            CboxMvto1_02.Checked = True
            CboxMvto1_03.Checked = True
            CboxMvto1_04.Checked = True
            CboxMvto1_05.Checked = True
            CboxMvto1_06.Checked = True
        Else
            CboxMvto1_01.Checked = False
            CboxMvto1_02.Checked = False
            CboxMvto1_03.Checked = False
            CboxMvto1_04.Checked = False
            CboxMvto1_05.Checked = False
            CboxMvto1_06.Checked = False

        End If

    End Sub

    Private Sub CboxAllExcluir_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAllExcluir.CheckedChanged

        If CboxAllExcluir.Checked = True Then
            CboxExcluir1_01.Checked = True

            CboxExcluir1_03.Checked = True

            CboxExcluir1_05.Checked = True
            CboxExcluir1_06.Checked = True
        Else
            CboxExcluir1_01.Checked = False

            CboxExcluir1_03.Checked = False

            CboxExcluir1_05.Checked = False
            CboxExcluir1_06.Checked = False

        End If
    End Sub

    Private Sub CboxAllRel_CheckedChanged(sender As Object, e As EventArgs) Handles CboxAllRel.CheckedChanged

        If CboxAllRel.Checked = True Then
            CboxRel1_01.Checked = True
            CboxRel1_02.Checked = True
            CboxRel1_03.Checked = True
            CboxRel1_04.Checked = True
            CboxRel1_05.Checked = True
            CboxRel1_06.Checked = True
            CboxRel1_07.Checked = True

        Else
            CboxRel1_01.Checked = False
            CboxRel1_02.Checked = False
            CboxRel1_03.Checked = False
            CboxRel1_04.Checked = False
            CboxRel1_05.Checked = False
            CboxRel1_06.Checked = False
            CboxRel1_07.Checked = False


        End If
    End Sub

    Private Sub FrmNivel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarNivelAcesso()
    End Sub

    Sub AtualizarNivelAcesso()

        Abrir()
        Dim cmd As MySqlCommand
        Dim sql As String
        Dim status As Integer
        Dim chk As CheckBox
        Dim nome As String

        For Each chk In GboxNivel1.Controls

            status = chk.CheckState
            nome = chk.Name

            sql = "Update controle_acesso Set nivel1 = Case rotina When '" & nome & "' then '" & status & "' end where rotina In ('" & nome & "')"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()

        Next chk

    End Sub

    Sub CarregarNivelAcesso()
        Try
            Abrir()
            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String
            Dim status As String
            Dim chk As CheckBox
            Dim nome As String

            For Each chk In GboxNivel1.Controls

                nome = chk.Name
                sql = "SELECT *FROM controle_acesso where rotina =  '" & nome & "' "

                cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader
                If reader.Read = True Then
                    status = reader(3)
                    chk.CheckState = status
                    reader.Close()
                Else
                    reader.Close()
                End If

            Next chk
        Catch ex As Exception
            MsgBox("Erro ao carregar nivel de acesso! ", +ex.Message)
        End Try
    End Sub

    Private Sub FrmNivel1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        If MsgBox("Deseja salvar alterações?", vbYesNo, "Nivel Acesso 1") = vbYes Then
            AtualizarNivelAcesso()
        End If
    End Sub
End Class