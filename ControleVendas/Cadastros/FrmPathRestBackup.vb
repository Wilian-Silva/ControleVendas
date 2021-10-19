Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class FrmPathRestBackup
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        If BackgroundWorker1.IsBusy Then

            MsgBox("Aguarde até que o processo de restauração de backup esteja concluído!!!", MsgBoxStyle.Information, "Backup Banco de Dados")

            Exit Sub
        Else
            Me.Close()
        End If


    End Sub

    Private Sub BtnCaminhoBakcup_Click(sender As Object, e As EventArgs) Handles BtnCaminhoBakcup.Click

        OpenFileDialog1.Filter = "sql files | *.sql"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TxtCaminhoBackup.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click

        If TxtCaminhoBackup.Text <> "" Then

            If MsgBox("Deseja restaurar backup do banco de dados?", vbYesNo, "Backup Banco de Dados") = vbYes Then

                If Not BackgroundWorker1.IsBusy Then

                    ProgressBar1.Visible = True
                    ProgressBar1.Style = ProgressBarStyle.Marquee
                    ProgressBar1.MarqueeAnimationSpeed = 4
                    Label4.Text = "Processando..."

                    BackgroundWorker1.RunWorkerAsync()

                End If

            End If
        Else
            MsgBox("Arquivo não selecionado!!!", MsgBoxStyle.Information, "Backup Banco de Dados")

        End If

    End Sub


    Private Sub RestaurarBackup()
        If MsgBox("Deseja restaurar backup do banco de dados?", vbYesNo, "Backup Banco de Dados") = vbYes Then

            Try
                Dim caminho As String
                caminho = TxtCaminhoBackup.Text
                Abrir()
                Dim cmd As New MySqlCommand
                cmd.Connection = con
                Dim mb As New MySqlBackup(cmd)
                mb.ImportFromFile(caminho)

                MsgBox("Backup restaurado com sucesso!!!", MsgBoxStyle.Information, "Backup Banco de Dados")

                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao fazer backup " + ex.Message)
            End Try

        End If
    End Sub

    Private Sub FrmPathRestBackup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ProgressBar1.Visible = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        BackgroundWorker1.WorkerSupportsCancellation = True

        Try
            Dim caminho As String
            caminho = TxtCaminhoBackup.Text
            Abrir()
            Dim cmd As New MySqlCommand
            cmd.Connection = con
            Dim mb As New MySqlBackup(cmd)
            mb.ImportFromFile(caminho)
        Catch ex As Exception
            MsgBox("Erro ao fazer backup " + ex.Message)
        End Try



    End Sub


    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted



        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Value = 100
        Label3.Text = "100%"
        Label4.Text = ""
        Label2.Text = "Backup restaurado com sucesso!!!"

    End Sub


End Class