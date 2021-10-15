Imports MySql.Data.MySqlClient

Public Class FrmLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ' Stop
        Dim usuario As String
        Dim senha As String
        usuario = TxtUsuario.Text
        senha = TxtSenha.Text

        If usuario <> "" And senha <> "" Then
            Try
                Abrir()
                Dim cmd As MySqlCommand
                Dim reader As MySqlDataReader
                Dim sql As String

                sql = "SELECT * FROM usuarios where usuario = '" & TxtUsuario.Text & "' and senha = '" & TxtSenha.Text & "'  "
                cmd = New MySqlCommand(sql, con)
                reader = cmd.ExecuteReader


                If reader.Read = True Then

                    'RECUPERANDO O NOME DO FUNCIONÁRIO LOGADO
                    Dim esp As String
                    Dim nome As String
                    nome = reader(1)
                    esp = reader(6)

                    nomeFuncionario = nome
                    especialidade = esp
                    nivelAcesso = reader(8)

                    reader.Close()
                    MsgBox("Bem Vindo " + nome, MsgBoxStyle.Information, "Entrando no Sistema")
                    Dim form = New FrmTelaInicial
                    Me.Hide()
                    form.ShowDialog()

                Else
                    MsgBox("Usuário e senha incorretos!", MsgBoxStyle.Information, "Login")
                    TxtUsuario.Focus()
                End If
                reader.Close()

            Catch ex As Exception
                MsgBox("Erro ao Efetuar o Login! ", +ex.Message)
            End Try

        Else
            MsgBox("Usuário e senha em branco!", MsgBoxStyle.Information, "Login")
            TxtUsuario.Focus()
        End If


    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        Application.Exit()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
