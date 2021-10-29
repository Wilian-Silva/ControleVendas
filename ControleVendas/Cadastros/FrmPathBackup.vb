Imports MySql.Data.MySqlClient

Public Class FrmPathBackup
    Dim caminho1 As String
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If BackgroundWorker1.IsBusy Then

            MsgBox("Aguarde até que o processo de restauração de backup esteja concluído!!!", MsgBoxStyle.Information, "Backup Banco de Dados")

            Exit Sub
        Else
            Me.Close()
        End If

    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click

        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "Ficheiros sql (*.sql)|*.sql"

        If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            caminho1 = saveFileDialog1.FileName

            If Not BackgroundWorker1.IsBusy Then

                ProgressBar1.Visible = True
                ProgressBar1.Style = ProgressBarStyle.Marquee
                ProgressBar1.MarqueeAnimationSpeed = 4
                Label7.Text = "Processando..."
                BackgroundWorker1.RunWorkerAsync()

            End If


        Else
            MsgBox("Backup cancelado.", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub FrmPathBackup_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ProgressBar1.Visible = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        BackgroundWorker1.WorkerSupportsCancellation = True
        Try
            Dim caminhodump As String
            caminhodump = Application.StartupPath
            Dim ProcessProperties As New ProcessStartInfo
            ProcessProperties.FileName = caminhodump & "\mysqldump.exe"
            ProcessProperties.Arguments = "--user=root --password= --host=localhost --databases controle_vendas > -r " & caminho1 & " "
            ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden
            Dim myProcess As Process = Process.Start(ProcessProperties)

        Catch ex As Exception

            MsgBox("Erro ao fazer cópia de segurança.Tente novamente.", MsgBoxStyle.Critical, "Erro")

        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Style = ProgressBarStyle.Blocks
        ProgressBar1.Value = 100
        Label8.Text = "100%"
        Label7.Text = ""
        Label9.Text = "Backup realizado com sucesso!!!"
    End Sub
End Class