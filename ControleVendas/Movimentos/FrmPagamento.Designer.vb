<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagamento))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataVencimento = New System.Windows.Forms.DateTimePicker()
        Me.DataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TxtValorNota = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.BtnPesqNota = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtJuros = New System.Windows.Forms.TextBox()
        Me.TxtTotalPago = New System.Windows.Forms.TextBox()
        Me.DataPgto = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPrincipal = New System.Windows.Forms.TextBox()
        Me.TxtSaldoNota = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDesconto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtndAdicionarItem = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtIdNota = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DataVencimento)
        Me.GroupBox3.Controls.Add(Me.DataEmissao)
        Me.GroupBox3.Controls.Add(Me.TxtPedido)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TxtFornecedor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtNota)
        Me.GroupBox3.Controls.Add(Me.TxtValorNota)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 223)
        Me.GroupBox3.TabIndex = 140
        Me.GroupBox3.TabStop = False
        '
        'DataVencimento
        '
        Me.DataVencimento.Enabled = False
        Me.DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVencimento.Location = New System.Drawing.Point(154, 145)
        Me.DataVencimento.Name = "DataVencimento"
        Me.DataVencimento.Size = New System.Drawing.Size(95, 20)
        Me.DataVencimento.TabIndex = 145
        '
        'DataEmissao
        '
        Me.DataEmissao.Enabled = False
        Me.DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEmissao.Location = New System.Drawing.Point(154, 114)
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.Size = New System.Drawing.Size(95, 20)
        Me.DataEmissao.TabIndex = 144
        '
        'TxtPedido
        '
        Me.TxtPedido.Location = New System.Drawing.Point(154, 83)
        Me.TxtPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.ReadOnly = True
        Me.TxtPedido.Size = New System.Drawing.Size(94, 20)
        Me.TxtPedido.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 85)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 16)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "Nº Pedido:"
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.Location = New System.Drawing.Point(154, 53)
        Me.TxtFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.ReadOnly = True
        Me.TxtFornecedor.Size = New System.Drawing.Size(149, 20)
        Me.TxtFornecedor.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Nota Fiscal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 149)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Vecimento:"
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(154, 20)
        Me.TxtNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.ReadOnly = True
        Me.TxtNota.Size = New System.Drawing.Size(94, 20)
        Me.TxtNota.TabIndex = 1
        '
        'TxtValorNota
        '
        Me.TxtValorNota.Location = New System.Drawing.Point(154, 178)
        Me.TxtValorNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorNota.Name = "TxtValorNota"
        Me.TxtValorNota.ReadOnly = True
        Me.TxtValorNota.Size = New System.Drawing.Size(94, 20)
        Me.TxtValorNota.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 55)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Fornecedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Saldo Nota:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 117)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Data Emissão:"
        '
        'BtnCarregar
        '
        Me.BtnCarregar.AccessibleDescription = ""
        Me.BtnCarregar.AccessibleName = "Adicionar"
        Me.BtnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnCarregar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarregar.Image = CType(resources.GetObject("BtnCarregar.Image"), System.Drawing.Image)
        Me.BtnCarregar.Location = New System.Drawing.Point(382, 15)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCarregar.TabIndex = 141
        Me.ToolTip.SetToolTip(Me.BtnCarregar, "Carregar dados do titulo")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'BtnPesqNota
        '
        Me.BtnPesqNota.Image = CType(resources.GetObject("BtnPesqNota.Image"), System.Drawing.Image)
        Me.BtnPesqNota.Location = New System.Drawing.Point(355, 15)
        Me.BtnPesqNota.Name = "BtnPesqNota"
        Me.BtnPesqNota.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesqNota.TabIndex = 140
        Me.ToolTip.SetToolTip(Me.BtnPesqNota, "Pesquisar Título")
        Me.BtnPesqNota.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtJuros)
        Me.GroupBox1.Controls.Add(Me.TxtTotalPago)
        Me.GroupBox1.Controls.Add(Me.DataPgto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtPrincipal)
        Me.GroupBox1.Controls.Add(Me.TxtSaldoNota)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtDesconto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(386, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 223)
        Me.GroupBox1.TabIndex = 141
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 143)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Valor Total Pago:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(35, 21)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 16)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Data Pagamento:"
        '
        'TxtJuros
        '
        Me.TxtJuros.Location = New System.Drawing.Point(154, 84)
        Me.TxtJuros.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtJuros.Name = "TxtJuros"
        Me.TxtJuros.Size = New System.Drawing.Size(94, 20)
        Me.TxtJuros.TabIndex = 9
        Me.TxtJuros.Text = "0,00"
        '
        'TxtTotalPago
        '
        Me.TxtTotalPago.Enabled = False
        Me.TxtTotalPago.Location = New System.Drawing.Point(154, 144)
        Me.TxtTotalPago.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalPago.Name = "TxtTotalPago"
        Me.TxtTotalPago.Size = New System.Drawing.Size(94, 20)
        Me.TxtTotalPago.TabIndex = 11
        '
        'DataPgto
        '
        Me.DataPgto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPgto.Location = New System.Drawing.Point(153, 19)
        Me.DataPgto.Name = "DataPgto"
        Me.DataPgto.Size = New System.Drawing.Size(95, 20)
        Me.DataPgto.TabIndex = 137
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Principal:"
        '
        'TxtPrincipal
        '
        Me.TxtPrincipal.Location = New System.Drawing.Point(154, 53)
        Me.TxtPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrincipal.Name = "TxtPrincipal"
        Me.TxtPrincipal.Size = New System.Drawing.Size(94, 20)
        Me.TxtPrincipal.TabIndex = 8
        Me.TxtPrincipal.Text = "0,00"
        '
        'TxtSaldoNota
        '
        Me.TxtSaldoNota.Enabled = False
        Me.TxtSaldoNota.Location = New System.Drawing.Point(154, 175)
        Me.TxtSaldoNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoNota.Name = "TxtSaldoNota"
        Me.TxtSaldoNota.Size = New System.Drawing.Size(94, 20)
        Me.TxtSaldoNota.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 86)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Multa/Juros:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 177)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Saldo do Título:"
        '
        'TxtDesconto
        '
        Me.TxtDesconto.Location = New System.Drawing.Point(154, 114)
        Me.TxtDesconto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDesconto.Name = "TxtDesconto"
        Me.TxtDesconto.Size = New System.Drawing.Size(94, 20)
        Me.TxtDesconto.TabIndex = 10
        Me.TxtDesconto.Text = "0,00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 116)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Descontos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtndAdicionarItem)
        Me.GroupBox2.Controls.Add(Me.BtnSair)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Location = New System.Drawing.Point(469, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 50)
        Me.GroupBox2.TabIndex = 142
        Me.GroupBox2.TabStop = False
        '
        'BtndAdicionarItem
        '
        Me.BtndAdicionarItem.AccessibleDescription = ""
        Me.BtndAdicionarItem.AccessibleName = "Adicionar"
        Me.BtndAdicionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtndAdicionarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtndAdicionarItem.Enabled = False
        Me.BtndAdicionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtndAdicionarItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtndAdicionarItem.Image = CType(resources.GetObject("BtndAdicionarItem.Image"), System.Drawing.Image)
        Me.BtndAdicionarItem.Location = New System.Drawing.Point(137, 10)
        Me.BtndAdicionarItem.Name = "BtndAdicionarItem"
        Me.BtndAdicionarItem.Size = New System.Drawing.Size(35, 35)
        Me.BtndAdicionarItem.TabIndex = 113
        Me.ToolTip.SetToolTip(Me.BtndAdicionarItem, "Confirmar valores")
        Me.BtndAdicionarItem.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleDescription = ""
        Me.BtnSair.AccessibleName = "Adicionar"
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSair.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        Me.BtnSair.Location = New System.Drawing.Point(218, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 57
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.Enabled = False
        Me.BtnSalvar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(178, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 54
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar registro")
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtIdNota)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.BtnCarregar)
        Me.GroupBox4.Controls.Add(Me.BtnPesqNota)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(423, 50)
        Me.GroupBox4.TabIndex = 143
        Me.GroupBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 18)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 16)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Cod. Registro Nota Fiscal:"
        '
        'TxtIdNota
        '
        Me.TxtIdNota.Enabled = False
        Me.TxtIdNota.Location = New System.Drawing.Point(166, 17)
        Me.TxtIdNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdNota.Name = "TxtIdNota"
        Me.TxtIdNota.Size = New System.Drawing.Size(58, 20)
        Me.TxtIdNota.TabIndex = 111
        Me.TxtIdNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(246, 18)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Pesquisar Título:"
        '
        'FrmPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(754, 316)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPagamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamento Fornecedores"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtFornecedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents TxtValorNota As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents BtnPesqNota As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtJuros As TextBox
    Friend WithEvents TxtTotalPago As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPrincipal As TextBox
    Friend WithEvents TxtSaldoNota As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDesconto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtndAdicionarItem As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtIdNota As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPedido As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DataPgto As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents DataEmissao As DateTimePicker
    Friend WithEvents DataVencimento As DateTimePicker
    Friend WithEvents Label14 As Label
End Class
