Imports System.Deployment.Application
Imports MySql.Data.MySqlClient

Public Class FrmTelaInicial

    Dim CuRWidth As Integer = Me.Width
    Dim CuRHeight As Integer = Me.Height
    Sub AjustarTamahoComponentes()

        Dim RatioHeight As Double = (Me.Height - CuRHeight) / CuRHeight
        Dim RatioWidth As Double = (Me.Width - CuRWidth) / CuRWidth

        For Each Ctrl As Control In Controls
            Ctrl.Width += Ctrl.Width * RatioWidth
            Ctrl.Left += Ctrl.Left * RatioWidth
            Ctrl.Top += Ctrl.Top * RatioHeight
            Ctrl.Height += Ctrl.Height * RatioHeight
        Next
        CuRHeight = Me.Height
        CuRWidth = Me.Width

    End Sub
    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_01.Click
        Dim form = New FrmProdutos
        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_02.Click
        Dim form = New FrmClientes
        form.ShowDialog()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_01.Click
        Dim form = New FrmPedido
        form.ShowDialog()
    End Sub

    Private Sub SaidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_02.Click
        Dim form = New FrmEntrada
        form.ShowDialog()
    End Sub

    Private Sub RecebimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_04.Click
        Dim form = New FrmReceberTitulo
        form.ShowDialog()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_04.Click

        Dim form = New FrmUsuarios
        form.ShowDialog()

    End Sub



    Private Sub BtnCadProduto_Click(sender As Object, e As EventArgs) Handles CboxCad2_01.Click
        Dim form = New FrmProdutos
        form.ShowDialog()

    End Sub

    Private Sub BtnCadCliente_Click(sender As Object, e As EventArgs) Handles CboxCad2_02.Click
        Dim form = New FrmClientes
        form.ShowDialog()

    End Sub

    Private Sub BtnPedido_Click(sender As Object, e As EventArgs) Handles CboxMvto2_01.Click
        Dim form = New FrmPedido
        form.ShowDialog()

    End Sub

    Private Sub BtnEntrada_Click(sender As Object, e As EventArgs) Handles CboxMvto2_02.Click
        Dim form = New FrmEntrada
        form.ShowDialog()

    End Sub

    Private Sub BtnVenda_Click(sender As Object, e As EventArgs) Handles CboxMvto2_03.Click

        Dim form = New FrmVendaProdutos
        form.ShowDialog()
    End Sub

    Private Sub BtnSaisSistema_Click(sender As Object, e As EventArgs) Handles BtnSaisSistema.Click

        Dim form = New FrmBackup
        form.ShowDialog()


    End Sub

    Private Sub TimerData_Tick(sender As Object, e As EventArgs) Handles TimerData.Tick

        LblData.Text = Now().ToShortDateString
        LblHora.Text = Now().ToLongTimeString

    End Sub

    Sub FormatarGridTelaIncial()
        DataGrid_APagar.Columns(0).HeaderText = "Fornecedor"
        DataGrid_APagar.Columns(1).HeaderText = "NF"
        DataGrid_APagar.Columns(2).HeaderText = "Parcela"
        DataGrid_APagar.Columns(3).HeaderText = "Vencimento"
        DataGrid_APagar.Columns(4).HeaderText = "Valor Parcela"
        DataGrid_APagar.Columns(5).HeaderText = "Saldo Parcela"
        DataGrid_APagar.Columns(6).HeaderText = "Observação"
        DataGrid_APagar.Columns(4).DefaultCellStyle.Format = "c"
        DataGrid_APagar.Columns(5).DefaultCellStyle.Format = "c"
        DataGrid_APagar.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGrid_APagar.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_APagar.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_APagar.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_APagar.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid_APagar.Columns(0).Width = 122
        DataGrid_APagar.Columns(2).Width = 50
        DataGrid_APagar.Columns(1).Width = 80

        DataGrid_APagar.Columns(3).Width = 75
        DataGrid_APagar.Columns(4).Width = 75
        DataGrid_APagar.Columns(5).Width = 75
        DataGrid_APagar.Columns(6).Width = 200


        DataGrid_Vencidos.Columns(0).HeaderText = "Cliente"
        DataGrid_Vencidos.Columns(1).HeaderText = "Nº Venda"
        DataGrid_Vencidos.Columns(2).HeaderText = "Duplicata"
        DataGrid_Vencidos.Columns(3).HeaderText = "Vencimento"
        DataGrid_Vencidos.Columns(4).HeaderText = "Parcela"
        DataGrid_Vencidos.Columns(5).HeaderText = "Valor Parcela"
        DataGrid_Vencidos.Columns(6).HeaderText = "Saldo Parcela"
        DataGrid_Vencidos.Columns(7).HeaderText = "Observação"
        DataGrid_Vencidos.Columns(5).DefaultCellStyle.Format = "c"
        DataGrid_Vencidos.Columns(6).DefaultCellStyle.Format = "c"

        DataGrid_Vencidos.Columns(0).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGrid_Vencidos.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_Vencidos.Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_Vencidos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_Vencidos.Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid_Vencidos.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_Vencidos.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid_Vencidos.Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGrid_Vencidos.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGrid_Vencidos.Columns(0).Width = 122
        DataGrid_Vencidos.Columns(2).Width = 50
        DataGrid_Vencidos.Columns(1).Width = 50

        DataGrid_Vencidos.Columns(3).Width = 75
        DataGrid_Vencidos.Columns(5).Width = 75
        DataGrid_Vencidos.Columns(4).Width = 45
        DataGrid_Vencidos.Columns(6).Width = 75
        DataGrid_Vencidos.Columns(7).Width = 250


    End Sub


    Private Sub FrmTelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TotalTitulos()

        FormatarGridTelaIncial()

        'CarregarAcessos()

        ' CarergarAcessoAtalhos()

        VersaoSistema()

        LblUsuario.Text = nomeFuncionario

    End Sub


    Sub VersaoSistema()
        Dim myVersion As Version

        If ApplicationDeployment.IsNetworkDeployed Then
            myVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion
            LblVersao.Text = String.Concat("Versão: ", myVersion)
        End If

    End Sub
    Sub CarergarAcessoAtalhos()

        Dim btn As Button
        Dim status As String
        Dim nome As String

        For Each btn In PanelEsquerda.Controls 'GbBtnAtalhos.Controls

            nome = btn.Tag


            Dim cmd As MySqlCommand
            Dim reader As MySqlDataReader
            Dim sql As String

            sql = "SELECT *FROM controle_acesso where rotina =  '" & nome & "' "

            cmd = New MySqlCommand(sql, con)
            reader = cmd.ExecuteReader

            If reader.Read = True Then

                'vericando o nivel de acesso do usuário no banco nivel1, nivel2 ou nivel3
                If nivelAcesso = 1 Then
                    status = reader("nivel1")
                Else
                    If nivelAcesso = 2 Then
                        status = reader("nivel2")
                    Else
                        If nivelAcesso = 3 Then
                            status = reader("nivel3")
                        End If
                    End If
                End If

                reader.Close()

#Disable Warning BC42104 ' A variável é usada antes de receber um valor
                If status = 1 Then
#Enable Warning BC42104 ' A variável é usada antes de receber um valor
                    btn.Enabled = True
                Else
                    If status = 0 Then
                        btn.Enabled = False
                    End If
                End If

            Else
                reader.Close()

            End If


        Next
    End Sub


    Sub CarregarAcessos()
        'Stop
        Dim tool As ToolStripMenuItem
        Dim nome As String
        Dim cmd As MySqlCommand
        Dim reader As MySqlDataReader
        Dim sql As String
        Dim status As String
        Dim menu As ToolStripMenuItem

        Abrir()
        Try
            For Each menu In MenuStrip1.Items

                For Each tool In menu.DropDownItems

                    nome = tool.Name

                    sql = "SELECT *FROM controle_acesso where rotina =  '" & nome & "' "

                    cmd = New MySqlCommand(sql, con)
                    reader = cmd.ExecuteReader
                    If reader.Read = True Then

                        'vericando o nivel de acesso do usuário no banco nivel1, nivel2 ou nivel3
                        If nivelAcesso = 1 Then
                            status = reader("nivel1")
                        Else
                            If nivelAcesso = 2 Then
                                status = reader("nivel2")
                            Else
                                If nivelAcesso = 3 Then
                                    status = reader("nivel3")
                                End If
                            End If
                        End If

#Disable Warning BC42104 ' A variável é usada antes de receber um valor
                        If status = 1 Then
#Enable Warning BC42104 ' A variável é usada antes de receber um valor
                            tool.Enabled = True
                        Else
                            tool.Enabled = False
                        End If
                        reader.Close()
                    Else
                        reader.Close()
                    End If



                    If nome = "CboxCad1_01" Then
                        If status = 1 Then
                            CboxCad2_01.Enabled = True
                        Else
                            CboxCad2_01.Enabled = False
                        End If

                    End If



                Next tool

            Next menu
        Catch ex As Exception
            MsgBox("Erro ao carregar acessos! ", +ex.Message)
        End Try
    End Sub
    Sub TotalTitulos()
        'Stop
        Abrir()
        Try
            Dim data As Date
            Dim data0 As Date
            Dim data2 As String
            Dim dataFormatada As String

            data = Date.Now().AddDays(30)
            dataFormatada = data.ToString("yyyy-MM-dd")
            data2 = Now.ToString("yyyy-MM-dd")

            'CONSULTA DE TITULOS A VENCER EM 30 DIAS
            Dim cmd As MySqlCommand
            Dim sql As String
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable


            sql = "SELECT f.nome_fantasia, d.documento, d.parcela, d.data_vencimento, d.valor_parcela, d.saldo_duplicata, d.observacao FROM duplicatas as d inner join fornecedor as f on d.cod_fornecedor = f.id  WHERE d.data_vencimento  <= '" & data2 & "' and d.saldo_duplicata >0 "
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            DataGrid_APagar.DataSource = dt

            'CONSULTA DE TITULOS A VENCER EM -30 DIAS
            Dim cmd1 As MySqlCommand
            Dim sql1 As String
            Dim da1 As MySqlDataAdapter
            Dim dt1 As New DataTable

            Dim dataFormatada2 As String
            data0 = Date.Now().AddDays(-30)
            dataFormatada2 = data0.ToString("yyyy-MM-dd")

            sql1 = "SELECT cliente, id_venda, id, data_vencimento, parcela, valor_parcela, saldo_duplicata, observacao FROM duplicatas_receber WHERE data_vencimento  <= '" & data2 & "' and saldo_duplicata >0 "
            cmd1 = New MySqlCommand(sql1, con)
            cmd1.ExecuteNonQuery()
            da1 = New MySqlDataAdapter(sql1, con)
            da1.Fill(dt1)
            DataGrid_Vencidos.DataSource = dt1


        Catch ex As Exception
            MsgBox("Erro ao Mostrar os dados no grid!! ---- " + ex.Message)
        End Try


    End Sub
    Sub TOTAL()
        Dim linha As DataGridViewRow
        Dim linha2 As DataGridViewRow
        Dim valor As Decimal
        Dim valor2 As Decimal
        For Each linha In DataGrid_APagar.Rows
            valor += linha.Cells(4).Value
        Next
        LblAVencer.Text = valor
        LblAVencer.Text = Format(valor, "R$ 00.00")
        ' MsgBox(valor)
        For Each linha2 In DataGrid_Vencidos.Rows
            valor2 += linha2.Cells(5).Value
        Next

        LblVencidos.Text = valor2
        LblVencidos.Text = Format(valor2, "R$ 00.00")
    End Sub
    Private Sub BtnContasPagar_Click(sender As Object, e As EventArgs) Handles CboxMvto2_05.Click
        Dim form = New FrmPagarTitulo
        form.ShowDialog()
    End Sub

    Private Sub PagamentosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxMvto1_05.Click
        Dim form = New FrmPagarTitulo
        form.ShowDialog()

    End Sub

    Private Sub NotasEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_01.Click
        Dim form = New FrmNotasEntrada
        form.ShowDialog()
    End Sub

    Private Sub PagamentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxCons1_02.Click
        Dim form = New FrmPagamentoEfetuado
        form.ShowDialog()

    End Sub
    Private Sub SaidaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxMvto1_03.Click
        Dim form = New FrmVendaProdutos
        form.ShowDialog()
    End Sub

    Private Sub PedidoDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_04.Click
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()
    End Sub

    Private Sub ExcluirPagamentoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_03.Click
        statusBtn = "Visible"
        Dim form = New FrmPagamentoEfetuado
        form.ShowDialog()
    End Sub

    Private Sub ExcluirPedidoDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_01.Click
        statusBtn = "Visible"
        Dim form = New FrmPedidoCabecalho
        form.ShowDialog()
    End Sub

    Private Sub VendasRegistradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_05.Click
        Dim form = New FrmVendaCabecalho
        form.ShowDialog()
    End Sub

    Private Sub BtnContasReceber_Click(sender As Object, e As EventArgs) Handles CboxMvto2_04.Click
        Dim form = New FrmReceberTitulo
        form.ShowDialog()
    End Sub

    Private Sub RecebimentosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CboxCons1_03.Click
        Dim form = New FrmRecebimentosEfetuados
        form.ShowDialog()
    End Sub

    Private Sub ExcluirRecebimentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxExcluir1_05.Click
        statusBtn = "Visible"
        Dim form = New FrmRecebimentosEfetuados
        form.ShowDialog()
    End Sub

    Private Sub BtnEstoque_Click(sender As Object, e As EventArgs) Handles CboxRel2_06.Click
        Dim form = New FrmRelSaldoEstoque
        form.ShowDialog()
    End Sub

    Private Sub SaldoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_06.Click
        Dim form = New FrmSaldoEstoque
        form.ShowDialog()
    End Sub


    Private Sub FrmTelaInicial_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TotalTitulos()
        TOTAL()
    End Sub



    Private Sub NivelDeAcessoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxConfig_01.Click
        Dim form = New FrmNivelAcesso
        form.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_03.Click
        Dim form = New FrmFornecedor
        form.ShowDialog()
    End Sub
    Private Sub PortadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCad1_05.Click
        Dim form = New FrmPortador
        form.ShowDialog()
    End Sub

    Private Sub SaldoPortadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxCons1_07.Click
        Dim form = New FrmSaldoPortador
        form.ShowDialog()
    End Sub

    Private Sub PortadorToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CboxMvto1_06.Click
        statusBtn = "Visible"
        Dim form = New FrmSaldoPortador
        form.ShowDialog()
    End Sub

    Private Sub CboxRel1_01_Click(sender As Object, e As EventArgs) Handles CboxRel1_01.Click

        relatorio = "Rel.Vendas"
        Dim form = New FrmDataInicialFinal
        form.ShowDialog()

    End Sub

    Private Sub BtnRelVendas_Click(sender As Object, e As EventArgs) Handles CboxRel2_01.Click
        relatorio = "Rel.Vendas"
        Dim form = New FrmDataInicialFinal
        form.ShowDialog()
    End Sub

    Private Sub CboxRel1_05_Click(sender As Object, e As EventArgs) Handles CboxRel1_05.Click
        Dim form = New FrmRelPedido
        form.ShowDialog()
    End Sub

    Private Sub CboxRel1_06_Click(sender As Object, e As EventArgs) Handles CboxRel1_06.Click
        Dim form = New FrmRelSaldoEstoque
        form.ShowDialog()
    End Sub

    Private Sub CboxRel1_04_Click(sender As Object, e As EventArgs) Handles CboxRel1_04.Click
        Dim form = New FrmTituloVencidos
        form.ShowDialog()
    End Sub

    Private Sub CboxRel1_03_Click(sender As Object, e As EventArgs) Handles CboxRel1_03.Click
        Dim form = New FrmContasReceber
        form.ShowDialog()

    End Sub

    Private Sub CboxRel1_02_Click(sender As Object, e As EventArgs) Handles CboxRel1_02.Click

        relatorio = "Rel.Recebimentos"
        Dim form = New FrmDataInicialFinal
        form.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CboxRel2_02.Click
        relatorio = "Rel.Recebimentos"
        Dim form = New FrmDataInicialFinal
        form.ShowDialog()
    End Sub

    Private Sub CboxRel1_07_Click(sender As Object, e As EventArgs) Handles CboxRel1_07.Click

        relatorio = "Rel.Resultado Periodo"
        Dim form = New FrmDataInicialFinal
        form.ShowDialog()

    End Sub

    Private Sub BtnLogoff_Click(sender As Object, e As EventArgs) Handles CboxRel2_08.Click
        Dim form = New FrmPesqCupom
        form.ShowDialog()
    End Sub

    Private Sub CboxRel1_08_Click(sender As Object, e As EventArgs) Handles CboxRel1_08.Click
        Dim form = New FrmPesqCupom
        form.ShowDialog()
    End Sub

    Private Sub CboxMvto1_07_Click(sender As Object, e As EventArgs) Handles CboxMvto1_07.Click
        Dim form = New FrmRelMvtoEstoque
        form.ShowDialog()
    End Sub

    Private Sub ContasAPagarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CboxRel1_09.Click
        Dim form = New FrmContasPagar
        form.ShowDialog()
    End Sub

    Private Sub MovimentaçãoEstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimentaçãoEstoqueToolStripMenuItem.Click
        relatorio = "Rel.Mvto Estoque"
        Dim form = New FrmDataInicialFinal
        form.ShowDialog()

    End Sub

    Private Sub CtasReceberPortadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CtasReceberPortadorToolStripMenuItem.Click
        Dim form = New FrmPesqPortador
        form.ShowDialog()
    End Sub

    Private Sub VendasPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasPorClienteToolStripMenuItem.Click
        Dim form = New FrmPesqCliente
        form.ShowDialog()
    End Sub

    Private Sub BackupDoBancoDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDoBancoDadosToolStripMenuItem.Click

        Dim form = New FrmPathBackup
        form.ShowDialog()


    End Sub

    Private Sub RestarurarBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestarurarBackupToolStripMenuItem.Click

        MsgBox("Cuidado: Essa rotina pode causar perda de dados!!! ", MsgBoxStyle.Exclamation, "ATENÇÃO")

        Dim form = New FrmPathRestBackup
        form.ShowDialog()
    End Sub

    Private Sub FrmTelaInicial_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'AjustarTamahoComponentes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        MessageBox.Show("Testando o novo recurso : ClickOnce...", "ClickOnce", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub VerificarAtualizaçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerificarAtualizaçõesToolStripMenuItem.Click

        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("A nova versão do sistema não pode ser baixada agora. " + ControlChars.Lf & ControlChars.Lf & "Por favor, verifique sua conexão ou tente novamente mais tarde. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("O sistema não pode ser atualizado. Provavelmente não é um aplicação ClickOnce. Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("Uma nova atualiação está diponível. Deseja fazer atualizção do sistema agora?", "Atualização dispnível", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show("O sistema identificou uma atualização obrigtória para a sua atual versão " &
                        "version to version " & info.MinimumRequiredVersion.ToString() &
                        ". O Sistema irá instalar a atualização e reiniciar.",
                        "Atualização dispnível", MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        MessageBox.Show("O sistema foi atualizado e será reiniciado.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show("Não foi possível instalar a última versão do sistema. " & ControlChars.Lf & ControlChars.Lf & "Por favor, verifique sua conexão ou tente novamente mais tarde.")
                        Return
                    End Try
                End If
            End If

        End If


    End Sub

    Private Sub DataGrid_Vencidos_DoubleClick(sender As Object, e As EventArgs) Handles DataGrid_Vencidos.DoubleClick

        PesqTituloTelaIncial = "True"
        PesqTituloidVenda = DataGrid_Vencidos.CurrentRow.Cells(1).Value
        PesqidDuplicata = DataGrid_Vencidos.CurrentRow.Cells(2).Value
        Dim form = New FrmReceberTitulo
        form.ShowDialog()
    End Sub

End Class