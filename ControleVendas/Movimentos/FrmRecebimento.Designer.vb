<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecebimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecebimento))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.BtnPesqNota = New System.Windows.Forms.Button()
        Me.BtndAdicionarItem = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotal1_Total2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtJuros = New System.Windows.Forms.TextBox()
        Me.TxtTotalRecebido = New System.Windows.Forms.TextBox()
        Me.DataPgto = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSaldoReceber = New System.Windows.Forms.TextBox()
        Me.TxtSaldoNota = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDesconto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalReceb = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtValorUnit = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataVencimento = New System.Windows.Forms.DateTimePicker()
        Me.DataVenda = New System.Windows.Forms.DateTimePicker()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TxtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtIdNota = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BtnCarregar.Location = New System.Drawing.Point(361, 15)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCarregar.TabIndex = 141
        Me.ToolTip.SetToolTip(Me.BtnCarregar, "Carregar dados do titulo")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'BtnPesqNota
        '
        Me.BtnPesqNota.Image = CType(resources.GetObject("BtnPesqNota.Image"), System.Drawing.Image)
        Me.BtnPesqNota.Location = New System.Drawing.Point(329, 15)
        Me.BtnPesqNota.Name = "BtnPesqNota"
        Me.BtnPesqNota.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesqNota.TabIndex = 140
        Me.ToolTip.SetToolTip(Me.BtnPesqNota, "Pesquisar Título")
        Me.BtnPesqNota.UseVisualStyleBackColor = True
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
        Me.BtndAdicionarItem.Location = New System.Drawing.Point(310, 10)
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
        Me.BtnSair.Location = New System.Drawing.Point(391, 10)
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
        Me.BtnSalvar.Location = New System.Drawing.Point(351, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 54
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar registro")
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtTotal1_Total2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TxtPrincipal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TxtJuros)
        Me.GroupBox1.Controls.Add(Me.TxtTotalRecebido)
        Me.GroupBox1.Controls.Add(Me.DataPgto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtSaldoReceber)
        Me.GroupBox1.Controls.Add(Me.TxtSaldoNota)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtDesconto)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(471, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 241)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        '
        'TxtTotal1_Total2
        '
        Me.TxtTotal1_Total2.Location = New System.Drawing.Point(292, 198)
        Me.TxtTotal1_Total2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotal1_Total2.Name = "TxtTotal1_Total2"
        Me.TxtTotal1_Total2.ReadOnly = True
        Me.TxtTotal1_Total2.Size = New System.Drawing.Size(94, 20)
        Me.TxtTotal1_Total2.TabIndex = 151
        Me.TxtTotal1_Total2.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(4, 64)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(117, 16)
        Me.Label18.TabIndex = 141
        Me.Label18.Text = "Principal Recebido:"
        '
        'TxtPrincipal
        '
        Me.TxtPrincipal.Location = New System.Drawing.Point(124, 62)
        Me.TxtPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrincipal.Name = "TxtPrincipal"
        Me.TxtPrincipal.Size = New System.Drawing.Size(94, 20)
        Me.TxtPrincipal.TabIndex = 140
        Me.TxtPrincipal.Text = "0,00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 16)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Total Recebido:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(240, 64)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "Data Receb."
        '
        'TxtJuros
        '
        Me.TxtJuros.Location = New System.Drawing.Point(124, 103)
        Me.TxtJuros.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtJuros.Name = "TxtJuros"
        Me.TxtJuros.Size = New System.Drawing.Size(94, 20)
        Me.TxtJuros.TabIndex = 9
        Me.TxtJuros.Text = "0,00"
        '
        'TxtTotalRecebido
        '
        Me.TxtTotalRecebido.Enabled = False
        Me.TxtTotalRecebido.Location = New System.Drawing.Point(124, 149)
        Me.TxtTotalRecebido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalRecebido.Name = "TxtTotalRecebido"
        Me.TxtTotalRecebido.Size = New System.Drawing.Size(94, 20)
        Me.TxtTotalRecebido.TabIndex = 11
        '
        'DataPgto
        '
        Me.DataPgto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPgto.Location = New System.Drawing.Point(320, 62)
        Me.DataPgto.Name = "DataPgto"
        Me.DataPgto.Size = New System.Drawing.Size(95, 20)
        Me.DataPgto.TabIndex = 137
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Saldo a Receber:"
        '
        'TxtSaldoReceber
        '
        Me.TxtSaldoReceber.Location = New System.Drawing.Point(125, 20)
        Me.TxtSaldoReceber.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoReceber.Name = "TxtSaldoReceber"
        Me.TxtSaldoReceber.ReadOnly = True
        Me.TxtSaldoReceber.Size = New System.Drawing.Size(94, 20)
        Me.TxtSaldoReceber.TabIndex = 8
        Me.TxtSaldoReceber.Text = "0,00"
        '
        'TxtSaldoNota
        '
        Me.TxtSaldoNota.Enabled = False
        Me.TxtSaldoNota.Location = New System.Drawing.Point(125, 196)
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
        Me.Label6.Location = New System.Drawing.Point(42, 108)
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
        Me.Label7.Location = New System.Drawing.Point(24, 198)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 16)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Saldo do Título:"
        '
        'TxtDesconto
        '
        Me.TxtDesconto.Location = New System.Drawing.Point(322, 103)
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
        Me.Label10.Location = New System.Drawing.Point(248, 105)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Descontos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtTotalReceb)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TxtValorUnit)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TxtQuantidade)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.DataVencimento)
        Me.GroupBox3.Controls.Add(Me.DataVenda)
        Me.GroupBox3.Controls.Add(Me.TxtProduto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.TxtCliente)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtNota)
        Me.GroupBox3.Controls.Add(Me.TxtValorTotal)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 70)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(423, 242)
        Me.GroupBox3.TabIndex = 142
        Me.GroupBox3.TabStop = False
        '
        'TxtTotalReceb
        '
        Me.TxtTotalReceb.Location = New System.Drawing.Point(293, 196)
        Me.TxtTotalReceb.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalReceb.Name = "TxtTotalReceb"
        Me.TxtTotalReceb.ReadOnly = True
        Me.TxtTotalReceb.Size = New System.Drawing.Size(94, 20)
        Me.TxtTotalReceb.TabIndex = 150
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(211, 198)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 151
        Me.Label17.Text = "Total Receb."
        '
        'TxtValorUnit
        '
        Me.TxtValorUnit.Location = New System.Drawing.Point(293, 103)
        Me.TxtValorUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorUnit.Name = "TxtValorUnit"
        Me.TxtValorUnit.ReadOnly = True
        Me.TxtValorUnit.Size = New System.Drawing.Size(94, 20)
        Me.TxtValorUnit.TabIndex = 147
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 104)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 16)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Qtd."
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.Location = New System.Drawing.Point(99, 103)
        Me.TxtQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.ReadOnly = True
        Me.TxtQuantidade.Size = New System.Drawing.Size(60, 20)
        Me.TxtQuantidade.TabIndex = 146
        Me.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(200, 105)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 16)
        Me.Label16.TabIndex = 149
        Me.Label16.Text = "Valor Unitário:"
        '
        'DataVencimento
        '
        Me.DataVencimento.Enabled = False
        Me.DataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVencimento.Location = New System.Drawing.Point(292, 149)
        Me.DataVencimento.Name = "DataVencimento"
        Me.DataVencimento.Size = New System.Drawing.Size(95, 20)
        Me.DataVencimento.TabIndex = 145
        '
        'DataVenda
        '
        Me.DataVenda.Enabled = False
        Me.DataVenda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVenda.Location = New System.Drawing.Point(98, 149)
        Me.DataVenda.Name = "DataVenda"
        Me.DataVenda.Size = New System.Drawing.Size(95, 20)
        Me.DataVenda.TabIndex = 144
        '
        'TxtProduto
        '
        Me.TxtProduto.Location = New System.Drawing.Point(98, 62)
        Me.TxtProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.ReadOnly = True
        Me.TxtProduto.Size = New System.Drawing.Size(289, 20)
        Me.TxtProduto.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(37, 63)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 16)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "Produto:"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(227, 20)
        Me.TxtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.ReadOnly = True
        Me.TxtCliente.Size = New System.Drawing.Size(160, 20)
        Me.TxtCliente.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 21)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Nº Venda:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(215, 151)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Vecimento:"
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(98, 20)
        Me.TxtNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.ReadOnly = True
        Me.TxtNota.Size = New System.Drawing.Size(61, 20)
        Me.TxtNota.TabIndex = 1
        Me.TxtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.Location = New System.Drawing.Point(98, 198)
        Me.TxtValorTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.ReadOnly = True
        Me.TxtValorTotal.Size = New System.Drawing.Size(94, 20)
        Me.TxtValorTotal.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Valor Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 150)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Data Venda:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtIdNota)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.BtnCarregar)
        Me.GroupBox4.Controls.Add(Me.BtnPesqNota)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(423, 50)
        Me.GroupBox4.TabIndex = 145
        Me.GroupBox4.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 19)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 16)
        Me.Label14.TabIndex = 142
        Me.Label14.Text = "Cod. Venda:"
        '
        'TxtIdNota
        '
        Me.TxtIdNota.Enabled = False
        Me.TxtIdNota.Location = New System.Drawing.Point(101, 18)
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
        Me.Label11.Location = New System.Drawing.Point(220, 19)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Pesquisar Título:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtndAdicionarItem)
        Me.GroupBox2.Controls.Add(Me.BtnSair)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Location = New System.Drawing.Point(471, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 50)
        Me.GroupBox2.TabIndex = 144
        Me.GroupBox2.TabStop = False
        '
        'FrmRecebimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(925, 349)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRecebimento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebimento de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtJuros As TextBox
    Friend WithEvents TxtTotalRecebido As TextBox
    Friend WithEvents DataPgto As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSaldoReceber As TextBox
    Friend WithEvents TxtSaldoNota As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDesconto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataVencimento As DateTimePicker
    Friend WithEvents DataVenda As DateTimePicker
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents TxtValorTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtIdNota As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents BtnPesqNota As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtndAdicionarItem As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents TxtValorUnit As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtQuantidade As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtTotalReceb As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtPrincipal As TextBox
    Friend WithEvents TxtTotal1_Total2 As TextBox
End Class
