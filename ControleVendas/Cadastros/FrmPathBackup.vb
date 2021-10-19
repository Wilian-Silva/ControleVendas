Imports MySql.Data.MySqlClient

Public Class FrmPathBackup
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click

        If MsgBox("Deseja efetuar bakcup do banco de dados?", vbYesNo, "Backup Banco de Dados") = vbYes Then

            Try
                Dim caminho As String

                ' caminho = Application.ExecutablePath
                caminho = TxtCaminhoBackup.Text
                Abrir()
                Dim cmd As New MySqlCommand
                cmd.Connection = con
                Dim mb As New MySqlBackup(cmd)

                mb.ExportToFile(caminho + "\Backup.sql")

                MsgBox("Backup efetuado com sucesso!!!", MsgBoxStyle.Information, "Backup Banco de Dados")
            Catch ex As Exception
                MsgBox("Erro ao fazer backup " + ex.Message)
            End Try

        End If
    End Sub

    Private Sub BtnCaminhoBakcup_Click(sender As Object, e As EventArgs) Handles BtnCaminhoBakcup.Click

        FolderBrowserDialog1.ShowDialog()

        If DialogResult.OK Then
            TxtCaminhoBackup.Text = FolderBrowserDialog1.SelectedPath

        End If


    End Sub


End Class