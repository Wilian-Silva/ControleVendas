<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProdutos))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCodAuxiliar = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtLucro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMargemVenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GboxProduto = New System.Windows.Forms.GroupBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnSelecionarItem = New System.Windows.Forms.Button()
        Me.BtnCacelarConsulta = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.TxtSaldoEstoque = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GboxProduto.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxPesProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtSaldoEstoque)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtCodAuxiliar)
        Me.GroupBox3.Controls.Add(Me.TxtId)
        Me.GroupBox3.Controls.Add(Me.TxtLucro)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TxtNome)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtMargemVenda)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtPrecoVenda)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 86)
        Me.GroupBox3.TabIndex = 147
        Me.GroupBox3.TabStop = False
        '
        'TxtCodAuxiliar
        '
        Me.TxtCodAuxiliar.BackColor = System.Drawing.Color.White
        Me.TxtCodAuxiliar.Enabled = False
        Me.TxtCodAuxiliar.HideSelection = False
        Me.TxtCodAuxiliar.Location = New System.Drawing.Point(462, 18)
        Me.TxtCodAuxiliar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodAuxiliar.Name = "TxtCodAuxiliar"
        Me.TxtCodAuxiliar.Size = New System.Drawing.Size(94, 20)
        Me.TxtCodAuxiliar.TabIndex = 73
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.Color.White
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(119, 18)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(30, 20)
        Me.TxtId.TabIndex = 44
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLucro
        '
        Me.TxtLucro.BackColor = System.Drawing.Color.White
        Me.TxtLucro.Enabled = False
        Me.TxtLucro.Location = New System.Drawing.Point(393, 53)
        Me.TxtLucro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLucro.Name = "TxtLucro"
        Me.TxtLucro.Size = New System.Drawing.Size(60, 20)
        Me.TxtLucro.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(307, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Preço Venda:"
        '
        'TxtNome
        '
        Me.TxtNome.BackColor = System.Drawing.Color.White
        Me.TxtNome.Enabled = False
        Me.TxtNome.HideSelection = False
        Me.TxtNome.Location = New System.Drawing.Point(150, 18)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(218, 20)
        Me.TxtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Descrição Produto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Cód. Auxiliar"
        '
        'TxtMargemVenda
        '
        Me.TxtMargemVenda.BackColor = System.Drawing.Color.White
        Me.TxtMargemVenda.Enabled = False
        Me.TxtMargemVenda.Location = New System.Drawing.Point(251, 53)
        Me.TxtMargemVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMargemVenda.Name = "TxtMargemVenda"
        Me.TxtMargemVenda.Size = New System.Drawing.Size(40, 20)
        Me.TxtMargemVenda.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(189, 54)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "% Lucro:"
        '
        'TxtPrecoVenda
        '
        Me.TxtPrecoVenda.BackColor = System.Drawing.Color.White
        Me.TxtPrecoVenda.Enabled = False
        Me.TxtPrecoVenda.Location = New System.Drawing.Point(119, 53)
        Me.TxtPrecoVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPrecoVenda.Name = "TxtPrecoVenda"
        Me.TxtPrecoVenda.Size = New System.Drawing.Size(60, 20)
        Me.TxtPrecoVenda.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Preço de Compra:"
        '
        'GboxProduto
        '
        Me.GboxProduto.BackColor = System.Drawing.Color.Transparent
        Me.GboxProduto.Controls.Add(Me.BtnCancelar)
        Me.GboxProduto.Controls.Add(Me.BtnNovo)
        Me.GboxProduto.Controls.Add(Me.BtnSair)
        Me.GboxProduto.Controls.Add(Me.BtnExcluir)
        Me.GboxProduto.Controls.Add(Me.BtnLimpar)
        Me.GboxProduto.Controls.Add(Me.BtnSalvar)
        Me.GboxProduto.Controls.Add(Me.BtnEditar)
        Me.GboxProduto.Location = New System.Drawing.Point(302, 8)
        Me.GboxProduto.Name = "GboxProduto"
        Me.GboxProduto.Size = New System.Drawing.Size(296, 50)
        Me.GboxProduto.TabIndex = 146
        Me.GboxProduto.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.AccessibleDescription = ""
        Me.BtnCancelar.AccessibleName = "Adicionar"
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.Location = New System.Drawing.Point(130, 10)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCancelar.TabIndex = 155
        Me.BtnCancelar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.AccessibleDescription = ""
        Me.BtnNovo.AccessibleName = "Adicionar"
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatAppearance.BorderSize = 0
        Me.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNovo.Image = CType(resources.GetObject("BtnNovo.Image"), System.Drawing.Image)
        Me.BtnNovo.Location = New System.Drawing.Point(10, 10)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(35, 35)
        Me.BtnNovo.TabIndex = 151
        Me.BtnNovo.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnNovo, "Adicionar novo registro")
        Me.BtnNovo.UseVisualStyleBackColor = True
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
        Me.BtnSair.Location = New System.Drawing.Point(248, 9)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 154
        Me.BtnSair.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.AccessibleDescription = ""
        Me.BtnExcluir.AccessibleName = "Adicionar"
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.FlatAppearance.BorderSize = 0
        Me.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.ForeColor = System.Drawing.Color.Transparent
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(208, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 153
        Me.BtnExcluir.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnExcluir, "Excluir registro")
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.AccessibleDescription = ""
        Me.BtnLimpar.AccessibleName = "Adicionar"
        Me.BtnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLimpar.FlatAppearance.BorderSize = 0
        Me.BtnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnLimpar.Image = CType(resources.GetObject("BtnLimpar.Image"), System.Drawing.Image)
        Me.BtnLimpar.Location = New System.Drawing.Point(91, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(35, 35)
        Me.BtnLimpar.TabIndex = 152
        Me.BtnLimpar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnLimpar, "Limpar dados")
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.AccessibleDescription = ""
        Me.BtnSalvar.AccessibleName = "Adicionar"
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalvar.FlatAppearance.BorderSize = 0
        Me.BtnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalvar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSalvar.Image = CType(resources.GetObject("BtnSalvar.Image"), System.Drawing.Image)
        Me.BtnSalvar.Location = New System.Drawing.Point(169, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 151
        Me.BtnSalvar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar resgistro")
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.AccessibleDescription = ""
        Me.BtnEditar.AccessibleName = "Adicionar"
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.Location = New System.Drawing.Point(52, 10)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(35, 35)
        Me.BtnEditar.TabIndex = 150
        Me.BtnEditar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnEditar, "Editar registro")
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Pesq. Prod."
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.Location = New System.Drawing.Point(80, 19)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(93, 20)
        Me.TxtPesquisar.TabIndex = 111
        '
        'BtnSelecionarItem
        '
        Me.BtnSelecionarItem.AccessibleDescription = ""
        Me.BtnSelecionarItem.AccessibleName = "Adicionar"
        Me.BtnSelecionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSelecionarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelecionarItem.FlatAppearance.BorderSize = 0
        Me.BtnSelecionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSelecionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionarItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelecionarItem.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSelecionarItem.Image = CType(resources.GetObject("BtnSelecionarItem.Image"), System.Drawing.Image)
        Me.BtnSelecionarItem.Location = New System.Drawing.Point(187, 10)
        Me.BtnSelecionarItem.Name = "BtnSelecionarItem"
        Me.BtnSelecionarItem.Size = New System.Drawing.Size(35, 35)
        Me.BtnSelecionarItem.TabIndex = 150
        Me.BtnSelecionarItem.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSelecionarItem, "Selecionar ")
        Me.BtnSelecionarItem.UseVisualStyleBackColor = True
        Me.BtnSelecionarItem.Visible = False
        '
        'BtnCacelarConsulta
        '
        Me.BtnCacelarConsulta.AccessibleDescription = ""
        Me.BtnCacelarConsulta.AccessibleName = "Adicionar"
        Me.BtnCacelarConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCacelarConsulta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCacelarConsulta.FlatAppearance.BorderSize = 0
        Me.BtnCacelarConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCacelarConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCacelarConsulta.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCacelarConsulta.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCacelarConsulta.Image = CType(resources.GetObject("BtnCacelarConsulta.Image"), System.Drawing.Image)
        Me.BtnCacelarConsulta.Location = New System.Drawing.Point(227, 11)
        Me.BtnCacelarConsulta.Name = "BtnCacelarConsulta"
        Me.BtnCacelarConsulta.Size = New System.Drawing.Size(35, 35)
        Me.BtnCacelarConsulta.TabIndex = 151
        Me.BtnCacelarConsulta.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCacelarConsulta, "Cancelar")
        Me.BtnCacelarConsulta.UseVisualStyleBackColor = True
        Me.BtnCacelarConsulta.Visible = False
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
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
        Me.DataGrid.Location = New System.Drawing.Point(26, 156)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(570, 220)
        Me.DataGrid.TabIndex = 148
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.BtnCacelarConsulta)
        Me.GboxPesProd.Controls.Add(Me.BtnSelecionarItem)
        Me.GboxPesProd.Controls.Add(Me.Label5)
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisar)
        Me.GboxPesProd.Location = New System.Drawing.Point(27, 8)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(269, 50)
        Me.GboxPesProd.TabIndex = 149
        Me.GboxPesProd.TabStop = False
        '
        'TxtSaldoEstoque
        '
        Me.TxtSaldoEstoque.BackColor = System.Drawing.Color.White
        Me.TxtSaldoEstoque.Enabled = False
        Me.TxtSaldoEstoque.Location = New System.Drawing.Point(521, 53)
        Me.TxtSaldoEstoque.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSaldoEstoque.Name = "TxtSaldoEstoque"
        Me.TxtSaldoEstoque.Size = New System.Drawing.Size(35, 20)
        Me.TxtSaldoEstoque.TabIndex = 74
        Me.TxtSaldoEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(460, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Qtd. Est."
        '
        'FrmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(624, 401)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GboxProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Produtos"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GboxProduto.ResumeLayout(False)
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMargemVenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrecoVenda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GboxProduto As GroupBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents TxtLucro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnCacelarConsulta As Button
    Friend WithEvents BtnSelecionarItem As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtCodAuxiliar As TextBox
    Friend WithEvents TxtSaldoEstoque As TextBox
    Friend WithEvents Label7 As Label
End Class
