<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GboxNivelAcesso = New System.Windows.Forms.GroupBox()
        Me.RbNivel2 = New System.Windows.Forms.RadioButton()
        Me.RbNivel3 = New System.Windows.Forms.RadioButton()
        Me.RbNivel1 = New System.Windows.Forms.RadioButton()
        Me.GboxProduto = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxNivelAcesso.SuspendLayout()
        Me.GboxProduto.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtPesquisar)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 50)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 16)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Pesquisar Usuário:"
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.Location = New System.Drawing.Point(133, 17)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(142, 20)
        Me.TxtPesquisar.TabIndex = 113
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(76, 24)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(30, 20)
        Me.TxtId.TabIndex = 1
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtNome)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtId)
        Me.GroupBox1.Controls.Add(Me.TxtEndereco)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtCPF)
        Me.GroupBox1.Controls.Add(Me.TxtTelefone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 181)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Cadastrais"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.White
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Location = New System.Drawing.Point(75, 141)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(221, 20)
        Me.TxtEmail.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Email:"
        '
        'TxtNome
        '
        Me.TxtNome.BackColor = System.Drawing.Color.White
        Me.TxtNome.Enabled = False
        Me.TxtNome.Location = New System.Drawing.Point(107, 24)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(189, 20)
        Me.TxtNome.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nome:"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.BackColor = System.Drawing.Color.White
        Me.TxtEndereco.Enabled = False
        Me.TxtEndereco.Location = New System.Drawing.Point(76, 60)
        Me.TxtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(220, 20)
        Me.TxtEndereco.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 61)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 102)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "CPF:"
        '
        'TxtCPF
        '
        Me.TxtCPF.BackColor = System.Drawing.Color.White
        Me.TxtCPF.Enabled = False
        Me.TxtCPF.Location = New System.Drawing.Point(76, 100)
        Me.TxtCPF.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCPF.Mask = "000,000,000-00"
        Me.TxtCPF.Name = "TxtCPF"
        Me.TxtCPF.Size = New System.Drawing.Size(108, 20)
        Me.TxtCPF.TabIndex = 4
        '
        'TxtTelefone
        '
        Me.TxtTelefone.BackColor = System.Drawing.Color.White
        Me.TxtTelefone.Enabled = False
        Me.TxtTelefone.Location = New System.Drawing.Point(509, 14)
        Me.TxtTelefone.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelefone.Mask = "(00)00000-0000"
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(108, 20)
        Me.TxtTelefone.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(435, 17)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Telefone:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.White
        Me.TxtUsuario.Enabled = False
        Me.TxtUsuario.Location = New System.Drawing.Point(78, 25)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(140, 20)
        Me.TxtUsuario.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Usuário:"
        '
        'TxtSenha
        '
        Me.TxtSenha.BackColor = System.Drawing.Color.White
        Me.TxtSenha.Enabled = False
        Me.TxtSenha.Location = New System.Drawing.Point(78, 55)
        Me.TxtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(140, 20)
        Me.TxtSenha.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Senha:"
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
        Me.BtnCancelar.Location = New System.Drawing.Point(123, 10)
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
        Me.BtnNovo.Location = New System.Drawing.Point(9, 9)
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
        Me.BtnSair.Location = New System.Drawing.Point(232, 9)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 154
        Me.BtnSair.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = False
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
        Me.BtnExcluir.Location = New System.Drawing.Point(198, 10)
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
        Me.BtnLimpar.Location = New System.Drawing.Point(85, 10)
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
        Me.BtnSalvar.Location = New System.Drawing.Point(160, 10)
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
        Me.BtnEditar.Location = New System.Drawing.Point(48, 10)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(35, 35)
        Me.BtnEditar.TabIndex = 150
        Me.BtnEditar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnEditar, "Editar registro")
        Me.BtnEditar.UseVisualStyleBackColor = True
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
        Me.DataGrid.Location = New System.Drawing.Point(25, 259)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(603, 209)
        Me.DataGrid.TabIndex = 149
        '
        'GboxNivelAcesso
        '
        Me.GboxNivelAcesso.BackColor = System.Drawing.Color.Transparent
        Me.GboxNivelAcesso.Controls.Add(Me.RbNivel2)
        Me.GboxNivelAcesso.Controls.Add(Me.RbNivel3)
        Me.GboxNivelAcesso.Controls.Add(Me.RbNivel1)
        Me.GboxNivelAcesso.Controls.Add(Me.TxtUsuario)
        Me.GboxNivelAcesso.Controls.Add(Me.Label8)
        Me.GboxNivelAcesso.Controls.Add(Me.Label9)
        Me.GboxNivelAcesso.Controls.Add(Me.TxtSenha)
        Me.GboxNivelAcesso.Location = New System.Drawing.Point(361, 72)
        Me.GboxNivelAcesso.Name = "GboxNivelAcesso"
        Me.GboxNivelAcesso.Size = New System.Drawing.Size(267, 181)
        Me.GboxNivelAcesso.TabIndex = 2
        Me.GboxNivelAcesso.TabStop = False
        Me.GboxNivelAcesso.Text = "Dados de Login"
        '
        'RbNivel2
        '
        Me.RbNivel2.AutoSize = True
        Me.RbNivel2.Enabled = False
        Me.RbNivel2.Location = New System.Drawing.Point(78, 117)
        Me.RbNivel2.Name = "RbNivel2"
        Me.RbNivel2.Size = New System.Drawing.Size(98, 17)
        Me.RbNivel2.TabIndex = 156
        Me.RbNivel2.Text = "Acesso Nível 2"
        Me.RbNivel2.UseVisualStyleBackColor = True
        '
        'RbNivel3
        '
        Me.RbNivel3.AutoSize = True
        Me.RbNivel3.Enabled = False
        Me.RbNivel3.Location = New System.Drawing.Point(78, 146)
        Me.RbNivel3.Name = "RbNivel3"
        Me.RbNivel3.Size = New System.Drawing.Size(98, 17)
        Me.RbNivel3.TabIndex = 155
        Me.RbNivel3.Text = "Acesso Nível 3"
        Me.RbNivel3.UseVisualStyleBackColor = True
        '
        'RbNivel1
        '
        Me.RbNivel1.AutoSize = True
        Me.RbNivel1.Enabled = False
        Me.RbNivel1.Location = New System.Drawing.Point(78, 89)
        Me.RbNivel1.Name = "RbNivel1"
        Me.RbNivel1.Size = New System.Drawing.Size(98, 17)
        Me.RbNivel1.TabIndex = 154
        Me.RbNivel1.Text = "Acesso Nível 1"
        Me.RbNivel1.UseVisualStyleBackColor = True
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
        Me.GboxProduto.Location = New System.Drawing.Point(361, 9)
        Me.GboxProduto.Name = "GboxProduto"
        Me.GboxProduto.Size = New System.Drawing.Size(269, 50)
        Me.GboxProduto.TabIndex = 147
        Me.GboxProduto.TabStop = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(653, 488)
        Me.Controls.Add(Me.GboxProduto)
        Me.Controls.Add(Me.GboxNivelAcesso)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuários"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxNivelAcesso.ResumeLayout(False)
        Me.GboxNivelAcesso.PerformLayout()
        Me.GboxProduto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCPF As MaskedTextBox
    Friend WithEvents TxtTelefone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GboxNivelAcesso As GroupBox
    Friend WithEvents RbNivel2 As RadioButton
    Friend WithEvents RbNivel3 As RadioButton
    Friend WithEvents RbNivel1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents GboxProduto As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnEditar As Button
End Class
