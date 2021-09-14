<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntrada))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.BtnPesqPedido = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtStatusPedido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdPedido = New System.Windows.Forms.TextBox()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNotaFiscal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalNota = New System.Windows.Forms.TextBox()
        Me.TxtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPageDuplicatas = New System.Windows.Forms.TabPage()
        Me.DataGridDuplicatas = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPageDuplicatas.SuspendLayout()
        CType(Me.DataGridDuplicatas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnNovo)
        Me.GroupBox2.Controls.Add(Me.BtnSair)
        Me.GroupBox2.Controls.Add(Me.BtnSalvar)
        Me.GroupBox2.Location = New System.Drawing.Point(533, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 50)
        Me.GroupBox2.TabIndex = 124
        Me.GroupBox2.TabStop = False
        '
        'BtnNovo
        '
        Me.BtnNovo.AccessibleDescription = ""
        Me.BtnNovo.AccessibleName = ""
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnNovo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.Image = CType(resources.GetObject("BtnNovo.Image"), System.Drawing.Image)
        Me.BtnNovo.Location = New System.Drawing.Point(5, 11)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(35, 35)
        Me.BtnNovo.TabIndex = 58
        Me.ToolTip.SetToolTip(Me.BtnNovo, "Incluir novo registro")
        Me.BtnNovo.UseVisualStyleBackColor = True
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
        Me.BtnSair.Location = New System.Drawing.Point(83, 11)
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
        Me.BtnSalvar.Location = New System.Drawing.Point(43, 11)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 54
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar registro")
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.AccessibleDescription = ""
        Me.BtnPesquisar.AccessibleName = "Adicionar"
        Me.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPesquisar.Enabled = False
        Me.BtnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPesquisar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.Location = New System.Drawing.Point(234, 17)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesquisar.TabIndex = 139
        Me.ToolTip.SetToolTip(Me.BtnPesquisar, "Carregar dados do pedido")
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'BtnPesqPedido
        '
        Me.BtnPesqPedido.Enabled = False
        Me.BtnPesqPedido.Image = CType(resources.GetObject("BtnPesqPedido.Image"), System.Drawing.Image)
        Me.BtnPesqPedido.Location = New System.Drawing.Point(210, 17)
        Me.BtnPesqPedido.Name = "BtnPesqPedido"
        Me.BtnPesqPedido.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqPedido.TabIndex = 136
        Me.ToolTip.SetToolTip(Me.BtnPesqPedido, "Consultar Pedido")
        Me.BtnPesqPedido.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(206, 216)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEliminar.TabIndex = 162
        Me.BtnEliminar.Text = "Eliminar"
        Me.ToolTip.SetToolTip(Me.BtnEliminar, "Eliminar item do pedido")
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnIncluir
        '
        Me.BtnIncluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnIncluir.Location = New System.Drawing.Point(8, 216)
        Me.BtnIncluir.Name = "BtnIncluir"
        Me.BtnIncluir.Size = New System.Drawing.Size(100, 30)
        Me.BtnIncluir.TabIndex = 164
        Me.BtnIncluir.Text = "Incluir"
        Me.ToolTip.SetToolTip(Me.BtnIncluir, "Incluir novo pedido")
        Me.BtnIncluir.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEditar.Location = New System.Drawing.Point(107, 216)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEditar.TabIndex = 166
        Me.BtnEditar.Text = "Alterar"
        Me.ToolTip.SetToolTip(Me.BtnEditar, "Editar registro")
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtStatusPedido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TxtIdPedido)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisar)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisar)
        Me.GroupBox1.Controls.Add(Me.BtnPesqPedido)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 50)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
        '
        'TxtStatusPedido
        '
        Me.TxtStatusPedido.Enabled = False
        Me.TxtStatusPedido.Location = New System.Drawing.Point(315, 18)
        Me.TxtStatusPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatusPedido.Name = "TxtStatusPedido"
        Me.TxtStatusPedido.Size = New System.Drawing.Size(57, 20)
        Me.TxtStatusPedido.TabIndex = 142
        Me.TxtStatusPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 16)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Status:"
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.Enabled = False
        Me.TxtIdPedido.Location = New System.Drawing.Point(81, 18)
        Me.TxtIdPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.Size = New System.Drawing.Size(29, 20)
        Me.TxtIdPedido.TabIndex = 140
        Me.TxtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.Enabled = False
        Me.TxtPesquisar.Location = New System.Drawing.Point(111, 18)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(97, 20)
        Me.TxtPesquisar.TabIndex = 111
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Id/Pedido:"
        '
        'TxtNotaFiscal
        '
        Me.TxtNotaFiscal.Enabled = False
        Me.TxtNotaFiscal.Location = New System.Drawing.Point(111, 50)
        Me.TxtNotaFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNotaFiscal.Name = "TxtNotaFiscal"
        Me.TxtNotaFiscal.Size = New System.Drawing.Size(83, 20)
        Me.TxtNotaFiscal.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nota Fiscal:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtTotalNota)
        Me.GroupBox3.Controls.Add(Me.TxtNomeFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtFornecedor)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.DataEmissao)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtNotaFiscal)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 92)
        Me.GroupBox3.TabIndex = 126
        Me.GroupBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 16)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Valor Total:"
        '
        'TxtTotalNota
        '
        Me.TxtTotalNota.Location = New System.Drawing.Point(493, 52)
        Me.TxtTotalNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalNota.Name = "TxtTotalNota"
        Me.TxtTotalNota.Size = New System.Drawing.Size(83, 20)
        Me.TxtTotalNota.TabIndex = 142
        '
        'TxtNomeFornecedor
        '
        Me.TxtNomeFornecedor.Enabled = False
        Me.TxtNomeFornecedor.Location = New System.Drawing.Point(145, 19)
        Me.TxtNomeFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomeFornecedor.Name = "TxtNomeFornecedor"
        Me.TxtNomeFornecedor.Size = New System.Drawing.Size(341, 20)
        Me.TxtNomeFornecedor.TabIndex = 130
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.Enabled = False
        Me.TxtFornecedor.Location = New System.Drawing.Point(111, 19)
        Me.TxtFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(32, 20)
        Me.TxtFornecedor.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Fornecedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Data Emisão:"
        '
        'DataEmissao
        '
        Me.DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEmissao.Location = New System.Drawing.Point(295, 52)
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.Size = New System.Drawing.Size(97, 20)
        Me.DataEmissao.TabIndex = 124
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(108, 50)
        Me.GroupBox4.TabIndex = 139
        Me.GroupBox4.TabStop = False
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(61, 16)
        Me.TxtIdRegistro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdRegistro.Name = "TxtIdRegistro"
        Me.TxtIdRegistro.Size = New System.Drawing.Size(37, 20)
        Me.TxtIdRegistro.TabIndex = 129
        Me.TxtIdRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Id Reg."
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
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
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 3)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(626, 245)
        Me.DataGrid.TabIndex = 154
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPageDuplicatas)
        Me.TabControl1.Location = New System.Drawing.Point(27, 156)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(640, 277)
        Me.TabControl1.TabIndex = 155
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.DataGrid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(632, 251)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Itens"
        '
        'TabPageDuplicatas
        '
        Me.TabPageDuplicatas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPageDuplicatas.Controls.Add(Me.Label6)
        Me.TabPageDuplicatas.Controls.Add(Me.BtnEditar)
        Me.TabPageDuplicatas.Controls.Add(Me.DataGridDuplicatas)
        Me.TabPageDuplicatas.Controls.Add(Me.BtnIncluir)
        Me.TabPageDuplicatas.Controls.Add(Me.BtnEliminar)
        Me.TabPageDuplicatas.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDuplicatas.Name = "TabPageDuplicatas"
        Me.TabPageDuplicatas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDuplicatas.Size = New System.Drawing.Size(632, 251)
        Me.TabPageDuplicatas.TabIndex = 1
        Me.TabPageDuplicatas.Text = "Duplicatas"
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDuplicatas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridDuplicatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridDuplicatas.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridDuplicatas.EnableHeadersVisualStyles = False
        Me.DataGridDuplicatas.Location = New System.Drawing.Point(8, 6)
        Me.DataGridDuplicatas.MultiSelect = False
        Me.DataGridDuplicatas.Name = "DataGridDuplicatas"
        Me.DataGridDuplicatas.ReadOnly = True
        Me.DataGridDuplicatas.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGridDuplicatas.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridDuplicatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDuplicatas.Size = New System.Drawing.Size(615, 210)
        Me.DataGridDuplicatas.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(331, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(289, 13)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Valor total da duplicata diferente do valor total da nota fiscal"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(690, 454)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Nota Fiscal"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPageDuplicatas.ResumeLayout(False)
        Me.TabPageDuplicatas.PerformLayout()
        CType(Me.DataGridDuplicatas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents BtnPesqPedido As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtNotaFiscal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataEmissao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnNovo As Button
    Friend WithEvents TxtIdPedido As TextBox
    Friend WithEvents TxtStatusPedido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPageDuplicatas As TabPage
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnIncluir As Button
    Friend WithEvents DataGridDuplicatas As DataGridView
    Friend WithEvents BtnEditar As Button
    Friend WithEvents TxtNomeFornecedor As TextBox
    Friend WithEvents TxtFornecedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotalNota As TextBox
    Friend WithEvents Label6 As Label
End Class
