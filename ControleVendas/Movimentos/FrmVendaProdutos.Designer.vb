<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendaProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendaProdutos))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.BtnIncluirItem_venda = New System.Windows.Forms.Button()
        Me.BtnPesqPedido = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.BtnExcluirItem_venda = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCacelar = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnAtualizar_duplicata = New System.Windows.Forms.Button()
        Me.BtnEditar_duplicata = New System.Windows.Forms.Button()
        Me.BtnIncluir_duplicata = New System.Windows.Forms.Button()
        Me.BtnEliminar_duplicata = New System.Windows.Forms.Button()
        Me.BtnPesqProduto = New System.Windows.Forms.Button()
        Me.BtnPesqCliente = New System.Windows.Forms.Button()
        Me.BtnNova_venda = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.TxtSaldoEstoque = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtTotalVenda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.TabPageDuplicatas = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalDuplicatas = New System.Windows.Forms.TextBox()
        Me.DataGridDuplicatas = New System.Windows.Forms.DataGridView()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtValorUnit = New System.Windows.Forms.TextBox()
        Me.TxtQuantidade = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtValorTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProduto = New System.Windows.Forms.TextBox()
        Me.DataVenda = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCodProduto = New System.Windows.Forms.TextBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.TxtCodCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnNotaEntrada = New System.Windows.Forms.Button()
        Me.TxtNfeEntrada = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIdNfeEntrada = New System.Windows.Forms.TextBox()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDuplicatas.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridDuplicatas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "pedidos"
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
        Me.BtnCarregar.Location = New System.Drawing.Point(161, 8)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 99
        Me.BtnCarregar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCarregar, "Atualizar")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'BtnIncluirItem_venda
        '
        Me.BtnIncluirItem_venda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIncluirItem_venda.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnIncluirItem_venda.Location = New System.Drawing.Point(202, 13)
        Me.BtnIncluirItem_venda.Name = "BtnIncluirItem_venda"
        Me.BtnIncluirItem_venda.Size = New System.Drawing.Size(99, 30)
        Me.BtnIncluirItem_venda.TabIndex = 13
        Me.BtnIncluirItem_venda.Text = "Incluir"
        Me.ToolTip.SetToolTip(Me.BtnIncluirItem_venda, "Inlcuir item a venda")
        Me.BtnIncluirItem_venda.UseVisualStyleBackColor = True
        '
        'BtnPesqPedido
        '
        Me.BtnPesqPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqPedido.FlatAppearance.BorderSize = 0
        Me.BtnPesqPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqPedido.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqPedido.Image = CType(resources.GetObject("BtnPesqPedido.Image"), System.Drawing.Image)
        Me.BtnPesqPedido.Location = New System.Drawing.Point(12, 12)
        Me.BtnPesqPedido.Name = "BtnPesqPedido"
        Me.BtnPesqPedido.Size = New System.Drawing.Size(30, 30)
        Me.BtnPesqPedido.TabIndex = 99
        Me.ToolTip.SetToolTip(Me.BtnPesqPedido, "Pesquisar venda")
        Me.BtnPesqPedido.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnOk.Location = New System.Drawing.Point(6, 13)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(99, 30)
        Me.BtnOk.TabIndex = 11
        Me.BtnOk.Text = "OK"
        Me.ToolTip.SetToolTip(Me.BtnOk, "Adicionar item")
        Me.BtnOk.UseVisualStyleBackColor = True
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
        Me.BtnProximo.Location = New System.Drawing.Point(82, 13)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(30, 30)
        Me.BtnProximo.TabIndex = 142
        Me.ToolTip.SetToolTip(Me.BtnProximo, "Próximo")
        Me.BtnProximo.UseVisualStyleBackColor = True
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
        Me.BtnAnterior.Location = New System.Drawing.Point(48, 13)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(30, 30)
        Me.BtnAnterior.TabIndex = 99
        Me.ToolTip.SetToolTip(Me.BtnAnterior, "Anterior")
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'BtnExcluirItem_venda
        '
        Me.BtnExcluirItem_venda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluirItem_venda.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExcluirItem_venda.Location = New System.Drawing.Point(104, 13)
        Me.BtnExcluirItem_venda.Name = "BtnExcluirItem_venda"
        Me.BtnExcluirItem_venda.Size = New System.Drawing.Size(99, 30)
        Me.BtnExcluirItem_venda.TabIndex = 12
        Me.BtnExcluirItem_venda.Text = "Eliminar"
        Me.ToolTip.SetToolTip(Me.BtnExcluirItem_venda, "Eliminar item da venda")
        Me.BtnExcluirItem_venda.UseVisualStyleBackColor = True
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
        Me.BtnCacelar.Location = New System.Drawing.Point(519, 9)
        Me.BtnCacelar.Name = "BtnCacelar"
        Me.BtnCacelar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCacelar.TabIndex = 99
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
        Me.BtnLimpar.Location = New System.Drawing.Point(475, 9)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(35, 35)
        Me.BtnLimpar.TabIndex = 99
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
        Me.BtnSalvar.Location = New System.Drawing.Point(561, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 99
        Me.BtnSalvar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar ")
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
        Me.BtnSair.Location = New System.Drawing.Point(642, 9)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 99
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
        Me.BtnExcluir.Location = New System.Drawing.Point(604, 8)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 99
        Me.BtnExcluir.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnExcluir, "Excluir ")
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnAtualizar_duplicata
        '
        Me.BtnAtualizar_duplicata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAtualizar_duplicata.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAtualizar_duplicata.Location = New System.Drawing.Point(303, 12)
        Me.BtnAtualizar_duplicata.Name = "BtnAtualizar_duplicata"
        Me.BtnAtualizar_duplicata.Size = New System.Drawing.Size(100, 30)
        Me.BtnAtualizar_duplicata.TabIndex = 169
        Me.BtnAtualizar_duplicata.Text = "Atualizar"
        Me.ToolTip.SetToolTip(Me.BtnAtualizar_duplicata, "Atualizar DataGrid")
        Me.BtnAtualizar_duplicata.UseVisualStyleBackColor = True
        '
        'BtnEditar_duplicata
        '
        Me.BtnEditar_duplicata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar_duplicata.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEditar_duplicata.Location = New System.Drawing.Point(204, 12)
        Me.BtnEditar_duplicata.Name = "BtnEditar_duplicata"
        Me.BtnEditar_duplicata.Size = New System.Drawing.Size(100, 30)
        Me.BtnEditar_duplicata.TabIndex = 166
        Me.BtnEditar_duplicata.Text = "Editar"
        Me.ToolTip.SetToolTip(Me.BtnEditar_duplicata, "Editar registro")
        Me.BtnEditar_duplicata.UseVisualStyleBackColor = True
        '
        'BtnIncluir_duplicata
        '
        Me.BtnIncluir_duplicata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIncluir_duplicata.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnIncluir_duplicata.Location = New System.Drawing.Point(6, 12)
        Me.BtnIncluir_duplicata.Name = "BtnIncluir_duplicata"
        Me.BtnIncluir_duplicata.Size = New System.Drawing.Size(100, 30)
        Me.BtnIncluir_duplicata.TabIndex = 164
        Me.BtnIncluir_duplicata.Text = "Incluir"
        Me.ToolTip.SetToolTip(Me.BtnIncluir_duplicata, "Incluir duplicata")
        Me.BtnIncluir_duplicata.UseVisualStyleBackColor = True
        '
        'BtnEliminar_duplicata
        '
        Me.BtnEliminar_duplicata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar_duplicata.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEliminar_duplicata.Location = New System.Drawing.Point(105, 12)
        Me.BtnEliminar_duplicata.Name = "BtnEliminar_duplicata"
        Me.BtnEliminar_duplicata.Size = New System.Drawing.Size(100, 30)
        Me.BtnEliminar_duplicata.TabIndex = 162
        Me.BtnEliminar_duplicata.Text = "Eliminar"
        Me.ToolTip.SetToolTip(Me.BtnEliminar_duplicata, "Excluir parcela")
        Me.BtnEliminar_duplicata.UseVisualStyleBackColor = True
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
        Me.BtnPesqProduto.Location = New System.Drawing.Point(398, 49)
        Me.BtnPesqProduto.Name = "BtnPesqProduto"
        Me.BtnPesqProduto.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqProduto.TabIndex = 7
        Me.ToolTip.SetToolTip(Me.BtnPesqProduto, "Consultar Produto")
        Me.BtnPesqProduto.UseVisualStyleBackColor = True
        '
        'BtnPesqCliente
        '
        Me.BtnPesqCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqCliente.Enabled = False
        Me.BtnPesqCliente.FlatAppearance.BorderSize = 0
        Me.BtnPesqCliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqCliente.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqCliente.Image = CType(resources.GetObject("BtnPesqCliente.Image"), System.Drawing.Image)
        Me.BtnPesqCliente.Location = New System.Drawing.Point(663, 16)
        Me.BtnPesqCliente.Name = "BtnPesqCliente"
        Me.BtnPesqCliente.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqCliente.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.BtnPesqCliente, "Consultar Fornecedor")
        Me.BtnPesqCliente.UseVisualStyleBackColor = True
        '
        'BtnNova_venda
        '
        Me.BtnNova_venda.AccessibleDescription = ""
        Me.BtnNova_venda.AccessibleName = "Adicionar"
        Me.BtnNova_venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNova_venda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNova_venda.FlatAppearance.BorderSize = 0
        Me.BtnNova_venda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNova_venda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNova_venda.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNova_venda.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNova_venda.Image = CType(resources.GetObject("BtnNova_venda.Image"), System.Drawing.Image)
        Me.BtnNova_venda.Location = New System.Drawing.Point(434, 10)
        Me.BtnNova_venda.Name = "BtnNova_venda"
        Me.BtnNova_venda.Size = New System.Drawing.Size(35, 35)
        Me.BtnNova_venda.TabIndex = 99
        Me.BtnNova_venda.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnNova_venda, "Adicionar nova venda")
        Me.BtnNova_venda.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtPesquisar)
        Me.GroupBox1.Controls.Add(Me.TxtSaldoEstoque)
        Me.GroupBox1.Controls.Add(Me.BtnNova_venda)
        Me.GroupBox1.Controls.Add(Me.BtnCacelar)
        Me.GroupBox1.Controls.Add(Me.BtnCarregar)
        Me.GroupBox1.Controls.Add(Me.BtnLimpar)
        Me.GroupBox1.Controls.Add(Me.BtnProximo)
        Me.GroupBox1.Controls.Add(Me.BtnSalvar)
        Me.GroupBox1.Controls.Add(Me.BtnSair)
        Me.GroupBox1.Controls.Add(Me.BtnAnterior)
        Me.GroupBox1.Controls.Add(Me.BtnExcluir)
        Me.GroupBox1.Controls.Add(Me.BtnPesqPedido)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 50)
        Me.GroupBox1.TabIndex = 169
        Me.GroupBox1.TabStop = False
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.BackColor = System.Drawing.Color.White
        Me.TxtPesquisar.Location = New System.Drawing.Point(119, 19)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(27, 20)
        Me.TxtPesquisar.TabIndex = 99
        Me.TxtPesquisar.Visible = False
        '
        'TxtSaldoEstoque
        '
        Me.TxtSaldoEstoque.BackColor = System.Drawing.Color.White
        Me.TxtSaldoEstoque.Enabled = False
        Me.TxtSaldoEstoque.Location = New System.Drawing.Point(203, 19)
        Me.TxtSaldoEstoque.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoEstoque.Name = "TxtSaldoEstoque"
        Me.TxtSaldoEstoque.Size = New System.Drawing.Size(32, 20)
        Me.TxtSaldoEstoque.TabIndex = 99
        Me.TxtSaldoEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtSaldoEstoque.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPageDuplicatas)
        Me.TabControl1.Location = New System.Drawing.Point(21, 178)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(694, 285)
        Me.TabControl1.TabIndex = 176
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.DataGrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(686, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Itens"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtTotalVenda)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.BtnOk)
        Me.GroupBox4.Controls.Add(Me.BtnIncluirItem_venda)
        Me.GroupBox4.Controls.Add(Me.BtnExcluirItem_venda)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 200)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(665, 50)
        Me.GroupBox4.TabIndex = 179
        Me.GroupBox4.TabStop = False
        '
        'TxtTotalVenda
        '
        Me.TxtTotalVenda.BackColor = System.Drawing.Color.White
        Me.TxtTotalVenda.Enabled = False
        Me.TxtTotalVenda.Location = New System.Drawing.Point(543, 19)
        Me.TxtTotalVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalVenda.Name = "TxtTotalVenda"
        Me.TxtTotalVenda.Size = New System.Drawing.Size(119, 20)
        Me.TxtTotalVenda.TabIndex = 178
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(473, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "Total Venda:"
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(8, 5)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(665, 195)
        Me.DataGrid.TabIndex = 154
        '
        'TabPageDuplicatas
        '
        Me.TabPageDuplicatas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageDuplicatas.Controls.Add(Me.GroupBox2)
        Me.TabPageDuplicatas.Controls.Add(Me.DataGridDuplicatas)
        Me.TabPageDuplicatas.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDuplicatas.Name = "TabPageDuplicatas"
        Me.TabPageDuplicatas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDuplicatas.Size = New System.Drawing.Size(686, 259)
        Me.TabPageDuplicatas.TabIndex = 1
        Me.TabPageDuplicatas.Text = "Duplicatas"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BtnAtualizar_duplicata)
        Me.GroupBox2.Controls.Add(Me.TxtTotalDuplicatas)
        Me.GroupBox2.Controls.Add(Me.BtnIncluir_duplicata)
        Me.GroupBox2.Controls.Add(Me.BtnEliminar_duplicata)
        Me.GroupBox2.Controls.Add(Me.BtnEditar_duplicata)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 50)
        Me.GroupBox2.TabIndex = 178
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(464, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Total Duplicatas:"
        '
        'TxtTotalDuplicatas
        '
        Me.TxtTotalDuplicatas.Enabled = False
        Me.TxtTotalDuplicatas.Location = New System.Drawing.Point(555, 18)
        Me.TxtTotalDuplicatas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalDuplicatas.Name = "TxtTotalDuplicatas"
        Me.TxtTotalDuplicatas.Size = New System.Drawing.Size(106, 20)
        Me.TxtTotalDuplicatas.TabIndex = 167
        Me.TxtTotalDuplicatas.Text = "0"
        '
        'DataGridDuplicatas
        '
        Me.DataGridDuplicatas.AllowUserToAddRows = False
        Me.DataGridDuplicatas.AllowUserToDeleteRows = False
        Me.DataGridDuplicatas.AllowUserToResizeColumns = False
        Me.DataGridDuplicatas.AllowUserToResizeRows = False
        Me.DataGridDuplicatas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridDuplicatas.BackgroundColor = System.Drawing.Color.White
        Me.DataGridDuplicatas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDuplicatas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridDuplicatas.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridDuplicatas.EnableHeadersVisualStyles = False
        Me.DataGridDuplicatas.Location = New System.Drawing.Point(8, 6)
        Me.DataGridDuplicatas.MultiSelect = False
        Me.DataGridDuplicatas.Name = "DataGridDuplicatas"
        Me.DataGridDuplicatas.ReadOnly = True
        Me.DataGridDuplicatas.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGridDuplicatas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridDuplicatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDuplicatas.Size = New System.Drawing.Size(665, 195)
        Me.DataGridDuplicatas.TabIndex = 165
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaldo.ForeColor = System.Drawing.Color.Brown
        Me.LblSaldo.Location = New System.Drawing.Point(323, 466)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(383, 15)
        Me.LblSaldo.TabIndex = 177
        Me.LblSaldo.Text = "Valor total das duplicatas diferente do valor total da venda!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(518, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Vlr. Unit."
        '
        'TxtValorUnit
        '
        Me.TxtValorUnit.BackColor = System.Drawing.Color.White
        Me.TxtValorUnit.Enabled = False
        Me.TxtValorUnit.Location = New System.Drawing.Point(573, 51)
        Me.TxtValorUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorUnit.Name = "TxtValorUnit"
        Me.TxtValorUnit.Size = New System.Drawing.Size(83, 20)
        Me.TxtValorUnit.TabIndex = 9
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.BackColor = System.Drawing.Color.White
        Me.TxtQuantidade.Enabled = False
        Me.TxtQuantidade.Location = New System.Drawing.Point(466, 52)
        Me.TxtQuantidade.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(32, 20)
        Me.TxtQuantidade.TabIndex = 8
        Me.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(473, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(433, 54)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Qtd."
        '
        'TxtValorTotal
        '
        Me.TxtValorTotal.BackColor = System.Drawing.Color.White
        Me.TxtValorTotal.Enabled = False
        Me.TxtValorTotal.Location = New System.Drawing.Point(519, 81)
        Me.TxtValorTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtValorTotal.Name = "TxtValorTotal"
        Me.TxtValorTotal.Size = New System.Drawing.Size(137, 20)
        Me.TxtValorTotal.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Produto:"
        '
        'TxtProduto
        '
        Me.TxtProduto.BackColor = System.Drawing.Color.White
        Me.TxtProduto.Enabled = False
        Me.TxtProduto.Location = New System.Drawing.Point(116, 51)
        Me.TxtProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtProduto.Name = "TxtProduto"
        Me.TxtProduto.Size = New System.Drawing.Size(281, 20)
        Me.TxtProduto.TabIndex = 6
        '
        'DataVenda
        '
        Me.DataVenda.Enabled = False
        Me.DataVenda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataVenda.Location = New System.Drawing.Point(294, 17)
        Me.DataVenda.Name = "DataVenda"
        Me.DataVenda.Size = New System.Drawing.Size(103, 20)
        Me.DataVenda.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(218, 19)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 16)
        Me.Label12.TabIndex = 95
        Me.Label12.Text = "Data Venda"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Cliente:"
        '
        'TxtCodProduto
        '
        Me.TxtCodProduto.BackColor = System.Drawing.Color.White
        Me.TxtCodProduto.Enabled = False
        Me.TxtCodProduto.Location = New System.Drawing.Point(82, 51)
        Me.TxtCodProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodProduto.Name = "TxtCodProduto"
        Me.TxtCodProduto.Size = New System.Drawing.Size(34, 20)
        Me.TxtCodProduto.TabIndex = 5
        Me.TxtCodProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCliente
        '
        Me.TxtCliente.BackColor = System.Drawing.Color.White
        Me.TxtCliente.Enabled = False
        Me.TxtCliente.Location = New System.Drawing.Point(489, 16)
        Me.TxtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(171, 20)
        Me.TxtCliente.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Nº Venda:"
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(82, 18)
        Me.TxtIdRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRegistro.Name = "TxtIdRegistro"
        Me.TxtIdRegistro.Size = New System.Drawing.Size(40, 20)
        Me.TxtIdRegistro.TabIndex = 99
        Me.TxtIdRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(134, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 138
        Me.Label10.Text = "Item"
        '
        'TxtItem
        '
        Me.TxtItem.Enabled = False
        Me.TxtItem.Location = New System.Drawing.Point(171, 18)
        Me.TxtItem.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(40, 20)
        Me.TxtItem.TabIndex = 99
        Me.TxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCodCliente
        '
        Me.TxtCodCliente.BackColor = System.Drawing.Color.White
        Me.TxtCodCliente.Enabled = False
        Me.TxtCodCliente.Location = New System.Drawing.Point(466, 16)
        Me.TxtCodCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodCliente.Name = "TxtCodCliente"
        Me.TxtCodCliente.Size = New System.Drawing.Size(23, 20)
        Me.TxtCodCliente.TabIndex = 2
        Me.TxtCodCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtIdNfeEntrada)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.BtnNotaEntrada)
        Me.GroupBox3.Controls.Add(Me.TxtNfeEntrada)
        Me.GroupBox3.Controls.Add(Me.TxtCodCliente)
        Me.GroupBox3.Controls.Add(Me.BtnPesqCliente)
        Me.GroupBox3.Controls.Add(Me.TxtItem)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtCliente)
        Me.GroupBox3.Controls.Add(Me.TxtCodProduto)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.BtnPesqProduto)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DataVenda)
        Me.GroupBox3.Controls.Add(Me.TxtProduto)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtValorTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtQuantidade)
        Me.GroupBox3.Controls.Add(Me.TxtValorUnit)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(690, 119)
        Me.GroupBox3.TabIndex = 168
        Me.GroupBox3.TabStop = False
        '
        'BtnNotaEntrada
        '
        Me.BtnNotaEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNotaEntrada.Enabled = False
        Me.BtnNotaEntrada.FlatAppearance.BorderSize = 0
        Me.BtnNotaEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNotaEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotaEntrada.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNotaEntrada.Image = CType(resources.GetObject("BtnNotaEntrada.Image"), System.Drawing.Image)
        Me.BtnNotaEntrada.Location = New System.Drawing.Point(287, 81)
        Me.BtnNotaEntrada.Name = "BtnNotaEntrada"
        Me.BtnNotaEntrada.Size = New System.Drawing.Size(22, 22)
        Me.BtnNotaEntrada.TabIndex = 140
        Me.ToolTip.SetToolTip(Me.BtnNotaEntrada, "Consultar Produto")
        Me.BtnNotaEntrada.UseVisualStyleBackColor = True
        '
        'TxtNfeEntrada
        '
        Me.TxtNfeEntrada.BackColor = System.Drawing.Color.White
        Me.TxtNfeEntrada.Enabled = False
        Me.TxtNfeEntrada.Location = New System.Drawing.Point(118, 82)
        Me.TxtNfeEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNfeEntrada.Name = "TxtNfeEntrada"
        Me.TxtNfeEntrada.Size = New System.Drawing.Size(165, 20)
        Me.TxtNfeEntrada.TabIndex = 139
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 82)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Nfe Entrada:"
        '
        'TxtIdNfeEntrada
        '
        Me.TxtIdNfeEntrada.BackColor = System.Drawing.Color.White
        Me.TxtIdNfeEntrada.Enabled = False
        Me.TxtIdNfeEntrada.Location = New System.Drawing.Point(84, 82)
        Me.TxtIdNfeEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdNfeEntrada.Name = "TxtIdNfeEntrada"
        Me.TxtIdNfeEntrada.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdNfeEntrada.TabIndex = 142
        Me.TxtIdNfeEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmVendaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(730, 494)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVendaProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda de Produtos"
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDuplicatas.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridDuplicatas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PedidosBindingSource As BindingSource

    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents BtnIncluirItem_venda As Button
    Friend WithEvents BtnPesqPedido As Button
    Friend WithEvents BtnOk As Button
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents BtnExcluirItem_venda As Button

    Friend WithEvents BtnCacelar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents TabPageDuplicatas As TabPage
    Friend WithEvents BtnAtualizar_duplicata As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalDuplicatas As TextBox
    Friend WithEvents BtnEditar_duplicata As Button
    Friend WithEvents DataGridDuplicatas As DataGridView
    Friend WithEvents BtnIncluir_duplicata As Button
    Friend WithEvents BtnEliminar_duplicata As Button
    Friend WithEvents LblSaldo As Label
    Friend WithEvents TxtTotalVenda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtValorUnit As TextBox
    Friend WithEvents TxtQuantidade As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtValorTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtProduto As TextBox
    Friend WithEvents DataVenda As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnPesqProduto As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCodProduto As TextBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtItem As TextBox
    Friend WithEvents BtnPesqCliente As Button
    Friend WithEvents TxtCodCliente As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnNova_venda As Button
    Friend WithEvents TxtSaldoEstoque As TextBox
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnNotaEntrada As Button
    Friend WithEvents TxtNfeEntrada As TextBox
    Friend WithEvents TxtIdNfeEntrada As TextBox
End Class
