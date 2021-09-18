<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPedido
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalPedido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCodFornecedor = New System.Windows.Forms.TextBox()
        Me.BtnPesqFornecedor = New System.Windows.Forms.Button()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtCodProduto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnPesqProduto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DataPed = New System.Windows.Forms.DateTimePicker()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtQuantidade = New System.Windows.Forms.TextBox()
        Me.TxtValorUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnCacelar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TxtNumPedido = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnExcluirItemPedido = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnPesqPedido = New System.Windows.Forms.Button()
        Me.Controle_vendasDataSet = New ControleVendas.Controle_vendasDataSet3()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PedidosTableAdapter = New ControleVendas.Controle_vendasDataSet3TableAdapters.pedidosTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.TxtStatusPedido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Controle_vendasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtStatusPedido)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtTotalPedido)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtCodFornecedor)
        Me.GroupBox3.Controls.Add(Me.BtnPesqFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtItem)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtCodProduto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.BtnPesqProduto)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtPedido)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DataPed)
        Me.GroupBox3.Controls.Add(Me.TxtProduto)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtValorTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtQuantidade)
        Me.GroupBox3.Controls.Add(Me.TxtValorUnit)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(683, 132)
        Me.GroupBox3.TabIndex = 134
        Me.GroupBox3.TabStop = False
        '
        'TxtTotalPedido
        '
        Me.TxtTotalPedido.BackColor = System.Drawing.Color.White
        Me.TxtTotalPedido.Enabled = False
        Me.TxtTotalPedido.Location = New System.Drawing.Point(468, 95)
        Me.TxtTotalPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalPedido.Name = "TxtTotalPedido"
        Me.TxtTotalPedido.Size = New System.Drawing.Size(84, 20)
        Me.TxtTotalPedido.TabIndex = 142
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 143
        Me.Label9.Text = "Total Pedido:"
        '
        'TxtCodFornecedor
        '
        Me.TxtCodFornecedor.BackColor = System.Drawing.Color.White
        Me.TxtCodFornecedor.Enabled = False
        Me.TxtCodFornecedor.Location = New System.Drawing.Point(82, 55)
        Me.TxtCodFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodFornecedor.Name = "TxtCodFornecedor"
        Me.TxtCodFornecedor.Size = New System.Drawing.Size(41, 20)
        Me.TxtCodFornecedor.TabIndex = 141
        Me.TxtCodFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPesqFornecedor
        '
        Me.BtnPesqFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqFornecedor.Enabled = False
        Me.BtnPesqFornecedor.FlatAppearance.BorderSize = 0
        Me.BtnPesqFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqFornecedor.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqFornecedor.Image = CType(resources.GetObject("BtnPesqFornecedor.Image"), System.Drawing.Image)
        Me.BtnPesqFornecedor.Location = New System.Drawing.Point(261, 55)
        Me.BtnPesqFornecedor.Name = "BtnPesqFornecedor"
        Me.BtnPesqFornecedor.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqFornecedor.TabIndex = 140
        Me.ToolTip.SetToolTip(Me.BtnPesqFornecedor, "Consultar Fornecedor")
        Me.BtnPesqFornecedor.UseVisualStyleBackColor = True
        '
        'TxtItem
        '
        Me.TxtItem.Enabled = False
        Me.TxtItem.Location = New System.Drawing.Point(170, 18)
        Me.TxtItem.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(40, 20)
        Me.TxtItem.TabIndex = 139
        Me.TxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(133, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Item"
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(82, 18)
        Me.TxtIdRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRegistro.Name = "TxtIdRegistro"
        Me.TxtIdRegistro.Size = New System.Drawing.Size(45, 20)
        Me.TxtIdRegistro.TabIndex = 129
        Me.TxtIdRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 16)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Nº Pedido:"
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.BackColor = System.Drawing.Color.White
        Me.TxtFornecedor.Enabled = False
        Me.TxtFornecedor.Location = New System.Drawing.Point(124, 55)
        Me.TxtFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(135, 20)
        Me.TxtFornecedor.TabIndex = 4
        '
        'TxtCodProduto
        '
        Me.TxtCodProduto.BackColor = System.Drawing.Color.White
        Me.TxtCodProduto.Enabled = False
        Me.TxtCodProduto.Location = New System.Drawing.Point(388, 55)
        Me.TxtCodProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodProduto.Name = "TxtCodProduto"
        Me.TxtCodProduto.Size = New System.Drawing.Size(41, 20)
        Me.TxtCodProduto.TabIndex = 137
        Me.TxtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 16)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Fornecedor:"
        '
        'BtnPesqProduto
        '
        Me.BtnPesqProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqProduto.Enabled = False
        Me.BtnPesqProduto.FlatAppearance.BorderSize = 0
        Me.BtnPesqProduto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqProduto.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqProduto.Image = CType(resources.GetObject("BtnPesqProduto.Image"), System.Drawing.Image)
        Me.BtnPesqProduto.Location = New System.Drawing.Point(644, 54)
        Me.BtnPesqProduto.Name = "BtnPesqProduto"
        Me.BtnPesqProduto.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqProduto.TabIndex = 136
        Me.ToolTip.SetToolTip(Me.BtnPesqProduto, "Consultar Produto")
        Me.BtnPesqProduto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Desc. Pedido:"
        '
        'TxtPedido
        '
        Me.TxtPedido.BackColor = System.Drawing.Color.White
        Me.TxtPedido.Enabled = False
        Me.TxtPedido.Location = New System.Drawing.Point(310, 18)
        Me.TxtPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.Size = New System.Drawing.Size(155, 20)
        Me.TxtPedido.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(473, 20)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 16)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Data Emissão:"
        '
        'DataPed
        '
        Me.DataPed.Enabled = False
        Me.DataPed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataPed.Location = New System.Drawing.Point(565, 18)
        Me.DataPed.Name = "DataPed"
        Me.DataPed.Size = New System.Drawing.Size(103, 20)
        Me.DataPed.TabIndex = 1
        '
        'TxtProduto
        '
        Me.TxtProduto.BackColor = System.Drawing.Color.White
        Me.TxtProduto.Enabled = False
        Me.TxtProduto.Location = New System.Drawing.Point(430, 55)
        Me.TxtProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(207, 20)
        Me.TxtProduto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Cód./Produto:"
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.BackColor = System.Drawing.Color.White
        Me.TxtValorTotal.Enabled = False
        Me.TxtValorTotal.Location = New System.Drawing.Point(297, 95)
        Me.TxtValorTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.Size = New System.Drawing.Size(83, 20)
        Me.TxtValorTotal.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Qtd."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(217, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Valor Total:"
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.BackColor = System.Drawing.Color.White
        Me.TxtQuantidade.Enabled = False
        Me.TxtQuantidade.Location = New System.Drawing.Point(41, 95)
        Me.TxtQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(42, 20)
        Me.TxtQuantidade.TabIndex = 6
        Me.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtValorUnit
        '
        Me.TxtValorUnit.BackColor = System.Drawing.Color.White
        Me.TxtValorUnit.Enabled = False
        Me.TxtValorUnit.Location = New System.Drawing.Point(152, 95)
        Me.TxtValorUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorUnit.Name = "TxtValorUnit"
        Me.TxtValorUnit.Size = New System.Drawing.Size(59, 20)
        Me.TxtValorUnit.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(92, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Vlr. Unit."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 20)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Nº Pedido:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnCacelar)
        Me.GroupBox2.Controls.Add(Me.BtnLimpar)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Controls.Add(Me.BtnSair)
        Me.GroupBox2.Controls.Add(Me.BtnExcluir)
        Me.GroupBox2.Location = New System.Drawing.Point(483, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(219, 50)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        '
        'BtnCacelar
        '
        Me.BtnCacelar.AccessibleDescription = ""
        Me.BtnCacelar.AccessibleName = "Adicionar"
        Me.BtnCacelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCacelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCacelar.FlatAppearance.BorderSize = 0
        Me.BtnCacelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCacelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCacelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCacelar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCacelar.Image = CType(resources.GetObject("BtnCacelar.Image"), System.Drawing.Image)
        Me.BtnCacelar.Location = New System.Drawing.Point(52, 9)
        Me.BtnCacelar.Name = "BtnCacelar"
        Me.BtnCacelar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCacelar.TabIndex = 169
        Me.BtnCacelar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCacelar, "Cancelar")
        Me.BtnCacelar.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.AccessibleDescription = ""
        Me.BtnLimpar.AccessibleName = "Adicionar"
        Me.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpar.FlatAppearance.BorderSize = 0
        Me.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(8, 9)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(35, 35)
        Me.BtnLimpar.TabIndex = 168
        Me.BtnLimpar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnLimpar, "Limpar registros")
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.AccessibleDescription = ""
        Me.BtnSalvar.AccessibleName = "Adicionar"
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(94, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 166
        Me.BtnSalvar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar Pedido")
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleDescription = ""
        Me.BtnSair.AccessibleName = "Adicionar"
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.FlatAppearance.BorderSize = 0
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSair.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        Me.BtnSair.Location = New System.Drawing.Point(175, 9)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 165
        Me.BtnSair.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.AccessibleDescription = ""
        Me.BtnExcluir.AccessibleName = "Adicionar"
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.FlatAppearance.BorderSize = 0
        Me.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(137, 8)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 164
        Me.BtnExcluir.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnExcluir, "Excluir pedido ")
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TxtNumPedido
        '
        Me.TxtNumPedido.Location = New System.Drawing.Point(83, 19)
        Me.TxtNumPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNumPedido.Name = "TxtNumPedido"
        Me.TxtNumPedido.Size = New System.Drawing.Size(44, 20)
        Me.TxtNumPedido.TabIndex = 116
        Me.TxtNumPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnNovo
        '
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnNovo.Location = New System.Drawing.Point(19, 393)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(100, 30)
        Me.BtnNovo.TabIndex = 156
        Me.BtnNovo.Text = "Novo"
        Me.ToolTip.SetToolTip(Me.BtnNovo, "Incluir novo pedido")
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEditar.Location = New System.Drawing.Point(217, 393)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEditar.TabIndex = 157
        Me.BtnEditar.Text = "Alterar"
        Me.ToolTip.SetToolTip(Me.BtnEditar, "Editar registro")
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnExcluirItemPedido
        '
        Me.BtnExcluirItemPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluirItemPedido.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExcluirItemPedido.Location = New System.Drawing.Point(316, 393)
        Me.BtnExcluirItemPedido.Name = "BtnExcluirItemPedido"
        Me.BtnExcluirItemPedido.Size = New System.Drawing.Size(100, 30)
        Me.BtnExcluirItemPedido.TabIndex = 158
        Me.BtnExcluirItemPedido.Text = "Eliminar"
        Me.ToolTip.SetToolTip(Me.BtnExcluirItemPedido, "Eliminar item do pedido")
        Me.BtnExcluirItemPedido.UseVisualStyleBackColor = True
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
        Me.BtnAnterior.Location = New System.Drawing.Point(168, 12)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(30, 30)
        Me.BtnAnterior.TabIndex = 141
        Me.ToolTip.SetToolTip(Me.BtnAnterior, "Anterior")
        Me.BtnAnterior.UseVisualStyleBackColor = True
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
        Me.BtnProximo.Location = New System.Drawing.Point(202, 12)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(30, 30)
        Me.BtnProximo.TabIndex = 142
        Me.ToolTip.SetToolTip(Me.BtnProximo, "Próximo")
        Me.BtnProximo.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnOk.Location = New System.Drawing.Point(118, 393)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(100, 30)
        Me.BtnOk.TabIndex = 159
        Me.BtnOk.Text = "OK"
        Me.ToolTip.SetToolTip(Me.BtnOk, "Adicionar item")
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BtnPesqPedido
        '
        Me.BtnPesqPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqPedido.FlatAppearance.BorderSize = 0
        Me.BtnPesqPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqPedido.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqPedido.Image = CType(resources.GetObject("BtnPesqPedido.Image"), System.Drawing.Image)
        Me.BtnPesqPedido.Location = New System.Drawing.Point(129, 13)
        Me.BtnPesqPedido.Name = "BtnPesqPedido"
        Me.BtnPesqPedido.Size = New System.Drawing.Size(30, 30)
        Me.BtnPesqPedido.TabIndex = 140
        Me.ToolTip.SetToolTip(Me.BtnPesqPedido, "Consultar Produto")
        Me.BtnPesqPedido.UseVisualStyleBackColor = True
        '
        'Controle_vendasDataSet
        '
        Me.Controle_vendasDataSet.DataSetName = "controle_vendasDataSet"
        Me.Controle_vendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
        Me.PedidosBindingSource.DataSource = Me.Controle_vendasDataSet
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnProximo)
        Me.GroupBox1.Controls.Add(Me.BtnAnterior)
        Me.GroupBox1.Controls.Add(Me.BtnPesqPedido)
        Me.GroupBox1.Controls.Add(Me.TxtNumPedido)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(237, 50)
        Me.GroupBox1.TabIndex = 136
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(19, 203)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(683, 190)
        Me.DataGrid.TabIndex = 166
        '
        'TxtStatusPedido
        '
        Me.TxtStatusPedido.BackColor = System.Drawing.Color.White
        Me.TxtStatusPedido.Enabled = False
        Me.TxtStatusPedido.Location = New System.Drawing.Point(611, 96)
        Me.TxtStatusPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatusPedido.Name = "TxtStatusPedido"
        Me.TxtStatusPedido.Size = New System.Drawing.Size(55, 20)
        Me.TxtStatusPedido.TabIndex = 144
        Me.TxtStatusPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(560, 98)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Status:"
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnIncluir.Location = New System.Drawing.Point(415, 393)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(100, 30)
        Me.BtnIncluir.TabIndex = 167
        Me.BtnIncluir.Text = "Incluir"
        Me.ToolTip.SetToolTip(Me.BtnIncluir, "Eliminar item do pedido")
        Me.BtnIncluir.UseVisualStyleBackColor = True
        '
        'FrmPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(725, 451)
        Me.Controls.Add(Me.BtnIncluir)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.BtnExcluirItemPedido)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Pedido de Compra"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Controle_vendasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPedido As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataPed As DateTimePicker
    Friend WithEvents TxtFornecedor As TextBox
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtValorTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtQuantidade As TextBox
    Friend WithEvents TxtValorUnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents BtnPesqProduto As Button
    Friend WithEvents Controle_vendasDataSet As Controle_vendasDataSet3
    Friend WithEvents PedidosBindingSource As BindingSource
    Friend WithEvents PedidosTableAdapter As Controle_vendasDataSet3TableAdapters.pedidosTableAdapter
    Friend WithEvents TxtNumPedido As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCodProduto As TextBox
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnPesqFornecedor As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnExcluirItemPedido As Button
    Friend WithEvents TxtCodFornecedor As TextBox
    Friend WithEvents TxtTotalPedido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnCacelar As Button
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents BtnPesqPedido As Button
    Friend WithEvents TxtStatusPedido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnIncluir As Button
End Class
