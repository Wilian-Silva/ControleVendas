<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceberTitulo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceberTitulo))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTotalPago = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtDescontos = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtJurosMultas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSaldoTitulo = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPortador = New System.Windows.Forms.TextBox()
        Me.TxtObeservacao = New System.Windows.Forms.TextBox()
        Me.TxtRegRecebimento = New System.Windows.Forms.TextBox()
        Me.LblRegPgto = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtStatusTitulo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt_venda = New System.Windows.Forms.TextBox()
        Me.TxtParcela = New System.Windows.Forms.TextBox()
        Me.BtnBaixarTitulo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.TxtIdPesquisar = New System.Windows.Forms.TextBox()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtValorPago = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtTotalTitulo = New System.Windows.Forms.TextBox()
        Me.TxtNomeCliente = New System.Windows.Forms.TextBox()
        Me.TxtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtId_duplicata = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblDataPagamento = New System.Windows.Forms.Label()
        Me.DataPagamento = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataVencimento = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtValorParcela = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GboxPesProd.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.TxtTotalPago)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtDescontos)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TxtJurosMultas)
        Me.GroupBox4.Location = New System.Drawing.Point(263, 142)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox4.TabIndex = 163
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Despesas Financeiras"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "Total Pago:"
        '
        'TxtTotalPago
        '
        Me.TxtTotalPago.Enabled = False
        Me.TxtTotalPago.Location = New System.Drawing.Point(108, 84)
        Me.TxtTotalPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalPago.Name = "TxtTotalPago"
        Me.TxtTotalPago.Size = New System.Drawing.Size(97, 20)
        Me.TxtTotalPago.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(35, 55)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 147
        Me.Label14.Text = "Descontos:"
        '
        'TxtDescontos
        '
        Me.TxtDescontos.Enabled = False
        Me.TxtDescontos.Location = New System.Drawing.Point(108, 53)
        Me.TxtDescontos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescontos.Name = "TxtDescontos"
        Me.TxtDescontos.Size = New System.Drawing.Size(97, 20)
        Me.TxtDescontos.TabIndex = 146
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 26)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Multas/Juros"
        '
        'TxtJurosMultas
        '
        Me.TxtJurosMultas.Enabled = False
        Me.TxtJurosMultas.Location = New System.Drawing.Point(108, 24)
        Me.TxtJurosMultas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtJurosMultas.Name = "TxtJurosMultas"
        Me.TxtJurosMultas.Size = New System.Drawing.Size(97, 20)
        Me.TxtJurosMultas.TabIndex = 144
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 86)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Valor Saldo:"
        '
        'TxtSaldoTitulo
        '
        Me.TxtSaldoTitulo.Enabled = False
        Me.TxtSaldoTitulo.Location = New System.Drawing.Point(108, 84)
        Me.TxtSaldoTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoTitulo.Name = "TxtSaldoTitulo"
        Me.TxtSaldoTitulo.Size = New System.Drawing.Size(105, 20)
        Me.TxtSaldoTitulo.TabIndex = 148
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.TxtPortador)
        Me.GroupBox5.Controls.Add(Me.TxtObeservacao)
        Me.GroupBox5.Location = New System.Drawing.Point(263, 271)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox5.TabIndex = 164
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Inf. Comp."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 150
        Me.Label5.Text = "Observação"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 16)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Portador"
        '
        'TxtPortador
        '
        Me.TxtPortador.Enabled = False
        Me.TxtPortador.Location = New System.Drawing.Point(75, 18)
        Me.TxtPortador.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPortador.Name = "TxtPortador"
        Me.TxtPortador.Size = New System.Drawing.Size(130, 20)
        Me.TxtPortador.TabIndex = 148
        '
        'TxtObeservacao
        '
        Me.TxtObeservacao.Enabled = False
        Me.TxtObeservacao.Location = New System.Drawing.Point(29, 77)
        Me.TxtObeservacao.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtObeservacao.Multiline = True
        Me.TxtObeservacao.Name = "TxtObeservacao"
        Me.TxtObeservacao.Size = New System.Drawing.Size(176, 39)
        Me.TxtObeservacao.TabIndex = 145
        '
        'TxtRegRecebimento
        '
        Me.TxtRegRecebimento.Enabled = False
        Me.TxtRegRecebimento.Location = New System.Drawing.Point(435, 14)
        Me.TxtRegRecebimento.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRegRecebimento.Name = "TxtRegRecebimento"
        Me.TxtRegRecebimento.Size = New System.Drawing.Size(33, 20)
        Me.TxtRegRecebimento.TabIndex = 149
        Me.TxtRegRecebimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtRegRecebimento.Visible = False
        '
        'LblRegPgto
        '
        Me.LblRegPgto.AutoSize = True
        Me.LblRegPgto.BackColor = System.Drawing.Color.Transparent
        Me.LblRegPgto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegPgto.Location = New System.Drawing.Point(362, 16)
        Me.LblRegPgto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRegPgto.Name = "LblRegPgto"
        Me.LblRegPgto.Size = New System.Drawing.Size(73, 16)
        Me.LblRegPgto.TabIndex = 148
        Me.LblRegPgto.Text = "Último Rec."
        Me.LblRegPgto.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(327, 51)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 147
        Me.Label16.Text = "Situação:"
        '
        'TxtStatusTitulo
        '
        Me.TxtStatusTitulo.Enabled = False
        Me.TxtStatusTitulo.Location = New System.Drawing.Point(392, 49)
        Me.TxtStatusTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatusTitulo.Name = "TxtStatusTitulo"
        Me.TxtStatusTitulo.Size = New System.Drawing.Size(76, 20)
        Me.TxtStatusTitulo.TabIndex = 146
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(18, 18)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 16)
        Me.Label17.TabIndex = 145
        Me.Label17.Text = "Nº Dupl."
        '
        'Txt_venda
        '
        Me.Txt_venda.Enabled = False
        Me.Txt_venda.Location = New System.Drawing.Point(76, 49)
        Me.Txt_venda.Margin = New System.Windows.Forms.Padding(4)
        Me.Txt_venda.Name = "Txt_venda"
        Me.Txt_venda.Size = New System.Drawing.Size(43, 20)
        Me.Txt_venda.TabIndex = 144
        Me.Txt_venda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtParcela
        '
        Me.TxtParcela.Enabled = False
        Me.TxtParcela.Location = New System.Drawing.Point(107, 24)
        Me.TxtParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtParcela.Name = "TxtParcela"
        Me.TxtParcela.Size = New System.Drawing.Size(25, 20)
        Me.TxtParcela.TabIndex = 152
        '
        'BtnBaixarTitulo
        '
        Me.BtnBaixarTitulo.AccessibleDescription = ""
        Me.BtnBaixarTitulo.AccessibleName = "Adicionar"
        Me.BtnBaixarTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBaixarTitulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBaixarTitulo.FlatAppearance.BorderSize = 0
        Me.BtnBaixarTitulo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnBaixarTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaixarTitulo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBaixarTitulo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnBaixarTitulo.Image = CType(resources.GetObject("BtnBaixarTitulo.Image"), System.Drawing.Image)
        Me.BtnBaixarTitulo.Location = New System.Drawing.Point(278, 10)
        Me.BtnBaixarTitulo.Name = "BtnBaixarTitulo"
        Me.BtnBaixarTitulo.Size = New System.Drawing.Size(35, 35)
        Me.BtnBaixarTitulo.TabIndex = 157
        Me.BtnBaixarTitulo.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnBaixarTitulo, "Baixar título")
        Me.BtnBaixarTitulo.UseVisualStyleBackColor = False
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleDescription = ""
        Me.BtnSair.AccessibleName = "Adicionar"
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.FlatAppearance.BorderSize = 0
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSair.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        Me.BtnSair.Location = New System.Drawing.Point(433, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 161
        Me.BtnSair.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = False
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.BtnPesquisar)
        Me.GboxPesProd.Controls.Add(Me.TxtIdPesquisar)
        Me.GboxPesProd.Controls.Add(Me.BtnProximo)
        Me.GboxPesProd.Controls.Add(Me.BtnCarregar)
        Me.GboxPesProd.Controls.Add(Me.BtnAnterior)
        Me.GboxPesProd.Controls.Add(Me.BtnBaixarTitulo)
        Me.GboxPesProd.Controls.Add(Me.BtnSair)
        Me.GboxPesProd.Location = New System.Drawing.Point(17, 4)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(483, 50)
        Me.GboxPesProd.TabIndex = 165
        Me.GboxPesProd.TabStop = False
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisar.FlatAppearance.BorderSize = 0
        Me.BtnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.Location = New System.Drawing.Point(89, 16)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisar.TabIndex = 164
        Me.ToolTip.SetToolTip(Me.BtnPesquisar, "Consultar Pedido")
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'TxtIdPesquisar
        '
        Me.TxtIdPesquisar.Location = New System.Drawing.Point(144, 20)
        Me.TxtIdPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdPesquisar.Name = "TxtIdPesquisar"
        Me.TxtIdPesquisar.Size = New System.Drawing.Size(28, 20)
        Me.TxtIdPesquisar.TabIndex = 163
        Me.TxtIdPesquisar.Visible = False
        '
        'BtnProximo
        '
        Me.BtnProximo.AccessibleDescription = ""
        Me.BtnProximo.AccessibleName = "Adicionar"
        Me.BtnProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnProximo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProximo.FlatAppearance.BorderSize = 0
        Me.BtnProximo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProximo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProximo.Image = CType(resources.GetObject("BtnProximo.Image"), System.Drawing.Image)
        Me.BtnProximo.Location = New System.Drawing.Point(48, 10)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(35, 35)
        Me.BtnProximo.TabIndex = 156
        Me.ToolTip.SetToolTip(Me.BtnProximo, "Próximo")
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnCarregar
        '
        Me.BtnCarregar.AccessibleDescription = ""
        Me.BtnCarregar.AccessibleName = "Adicionar"
        Me.BtnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCarregar.FlatAppearance.BorderSize = 0
        Me.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarregar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarregar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCarregar.Image = CType(resources.GetObject("BtnCarregar.Image"), System.Drawing.Image)
        Me.BtnCarregar.Location = New System.Drawing.Point(238, 10)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 162
        Me.BtnCarregar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCarregar, "Atualizar")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'BtnAnterior
        '
        Me.BtnAnterior.AccessibleDescription = ""
        Me.BtnAnterior.AccessibleName = "Adicionar"
        Me.BtnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnterior.FlatAppearance.BorderSize = 0
        Me.BtnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnterior.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnterior.Image = CType(resources.GetObject("BtnAnterior.Image"), System.Drawing.Image)
        Me.BtnAnterior.Location = New System.Drawing.Point(11, 10)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(35, 35)
        Me.BtnAnterior.TabIndex = 155
        Me.ToolTip.SetToolTip(Me.BtnAnterior, "Anterior")
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 55)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 16)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Valor Pago:"
        '
        'TxtValorPago
        '
        Me.TxtValorPago.Enabled = False
        Me.TxtValorPago.Location = New System.Drawing.Point(108, 53)
        Me.TxtValorPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorPago.Name = "TxtValorPago"
        Me.TxtValorPago.Size = New System.Drawing.Size(105, 20)
        Me.TxtValorPago.TabIndex = 146
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtRegRecebimento)
        Me.GroupBox3.Controls.Add(Me.LblRegPgto)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.TxtTotalTitulo)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TxtNomeCliente)
        Me.GroupBox3.Controls.Add(Me.TxtStatusTitulo)
        Me.GroupBox3.Controls.Add(Me.TxtCodCliente)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtId_duplicata)
        Me.GroupBox3.Controls.Add(Me.Txt_venda)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(483, 80)
        Me.GroupBox3.TabIndex = 160
        Me.GroupBox3.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(145, 50)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 16)
        Me.Label19.TabIndex = 152
        Me.Label19.Text = "Total Venda"
        '
        'TxtTotalTitulo
        '
        Me.TxtTotalTitulo.Enabled = False
        Me.TxtTotalTitulo.Location = New System.Drawing.Point(227, 47)
        Me.TxtTotalTitulo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalTitulo.Name = "TxtTotalTitulo"
        Me.TxtTotalTitulo.Size = New System.Drawing.Size(64, 20)
        Me.TxtTotalTitulo.TabIndex = 151
        '
        'TxtNomeCliente
        '
        Me.TxtNomeCliente.Enabled = False
        Me.TxtNomeCliente.Location = New System.Drawing.Point(206, 14)
        Me.TxtNomeCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomeCliente.Name = "TxtNomeCliente"
        Me.TxtNomeCliente.Size = New System.Drawing.Size(146, 20)
        Me.TxtNomeCliente.TabIndex = 130
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.Enabled = False
        Me.TxtCodCliente.Location = New System.Drawing.Point(180, 14)
        Me.TxtCodCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.Size = New System.Drawing.Size(25, 20)
        Me.TxtCodCliente.TabIndex = 129
        Me.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Cliente"
        '
        'TxtId_duplicata
        '
        Me.TxtId_duplicata.Enabled = False
        Me.TxtId_duplicata.Location = New System.Drawing.Point(76, 17)
        Me.TxtId_duplicata.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId_duplicata.Name = "TxtId_duplicata"
        Me.TxtId_duplicata.Size = New System.Drawing.Size(43, 20)
        Me.TxtId_duplicata.TabIndex = 97
        Me.TxtId_duplicata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nº Venda"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LblDataPagamento)
        Me.GroupBox1.Controls.Add(Me.DataPagamento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DataVencimento)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DataEmissao)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datas"
        '
        'LblDataPagamento
        '
        Me.LblDataPagamento.AutoSize = True
        Me.LblDataPagamento.BackColor = System.Drawing.Color.Transparent
        Me.LblDataPagamento.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDataPagamento.Location = New System.Drawing.Point(12, 87)
        Me.LblDataPagamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDataPagamento.Name = "LblDataPagamento"
        Me.LblDataPagamento.Size = New System.Drawing.Size(85, 16)
        Me.LblDataPagamento.TabIndex = 147
        Me.LblDataPagamento.Text = "Último Pagto:"
        Me.LblDataPagamento.Visible = False
        '
        'DataPagamento
        '
        Me.DataPagamento.Enabled = False
        Me.DataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPagamento.Location = New System.Drawing.Point(100, 86)
        Me.DataPagamento.Name = "DataPagamento"
        Me.DataPagamento.Size = New System.Drawing.Size(97, 20)
        Me.DataPagamento.TabIndex = 146
        Me.DataPagamento.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Vencimento:"
        '
        'DataVencimento
        '
        Me.DataVencimento.Enabled = False
        Me.DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVencimento.Location = New System.Drawing.Point(100, 53)
        Me.DataVencimento.Name = "DataVencimento"
        Me.DataVencimento.Size = New System.Drawing.Size(97, 20)
        Me.DataVencimento.TabIndex = 144
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 125
        Me.Label10.Text = "Emisão:"
        '
        'DataEmissao
        '
        Me.DataEmissao.Enabled = False
        Me.DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEmissao.Location = New System.Drawing.Point(100, 22)
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.Size = New System.Drawing.Size(97, 20)
        Me.DataEmissao.TabIndex = 124
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtParcela)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtSaldoTitulo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtValorPago)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtValorParcela)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 123)
        Me.GroupBox2.TabIndex = 162
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Parc./Valor:"
        '
        'TxtValorParcela
        '
        Me.TxtValorParcela.Enabled = False
        Me.TxtValorParcela.Location = New System.Drawing.Point(133, 24)
        Me.TxtValorParcela.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorParcela.Name = "TxtValorParcela"
        Me.TxtValorParcela.Size = New System.Drawing.Size(80, 20)
        Me.TxtValorParcela.TabIndex = 144
        '
        'FrmReceberTitulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(521, 407)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReceberTitulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Titulo do Contas a Rebecer"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtTotalPago As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtDescontos As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtJurosMultas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSaldoTitulo As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtRegRecebimento As TextBox
    Friend WithEvents LblRegPgto As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtStatusTitulo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Txt_venda As TextBox
    Friend WithEvents TxtParcela As TextBox
    Friend WithEvents BtnBaixarTitulo As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents BtnSair As Button
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents TxtIdPesquisar As TextBox
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtValorPago As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtTotalTitulo As TextBox
    Friend WithEvents TxtNomeCliente As TextBox
    Friend WithEvents TxtCodCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId_duplicata As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblDataPagamento As Label
    Friend WithEvents DataPagamento As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DataVencimento As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DataEmissao As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtValorParcela As TextBox
    Friend WithEvents TxtObeservacao As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPortador As TextBox
End Class
