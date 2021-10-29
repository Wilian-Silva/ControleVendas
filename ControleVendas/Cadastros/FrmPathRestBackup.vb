Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FrmPathRestBackup
    Dim caminho2 As String
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        If BackgroundWorker1.IsBusy Then

            MsgBox("Aguarde até que o processo de restauração de backup esteja concluído!!!", MsgBoxStyle.Information, "Backup Banco de Dados")

            Exit Sub
        Else
            Me.Close()
        End If


    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click

        Dim openFileDialog1 As New OpenFileDialog
        openFileDialog1.Filter = "Ficheiros sql (*.sql)|*.sql"

        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            caminho2 = openFileDialog1.FileName

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
            MsgBox("Restauração de Backup cancelada.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub FrmPathRestBackup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ProgressBar1.Visible = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        BackgroundWorker1.WorkerSupportsCancellation = True

        Try
            Dim caminhodump As String
            caminhodump = Application.StartupPath

            Dim myProcess As New Process()
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "c:\"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine(caminhodump & "\mysql.exe --host=localhost --user=root --password=  controle_vendas < " & caminho2 & " ")

            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()

        Catch ex As Exception

            MsgBox("Erro ao restaurar a base de dados.", MsgBoxStyle.Critical, "Erro")

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