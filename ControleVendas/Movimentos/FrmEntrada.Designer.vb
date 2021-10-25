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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnIncluir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnPesqPedido = New System.Windows.Forms.Button()
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnAtualizar = New System.Windows.Forms.Button()
        Me.BtnPesquisarNota = New System.Windows.Forms.Button()
        Me.TxtNotaFiscal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescPed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalNota = New System.Windows.Forms.TextBox()
        Me.TxtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtFornecedor = New System.Windows.Forms.TextBox()
        Me.TxtCodPedido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataEmissao = New System.Windows.Forms.DateTimePicker()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPageDuplicatas = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalDuplicatas = New System.Windows.Forms.TextBox()
        Me.DataGridDuplicatas = New System.Windows.Forms.DataGridView()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        Me.GBoxFornecedor = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPageDuplicatas.SuspendLayout()
        CType(Me.DataGridDuplicatas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GboxPesProd.SuspendLayout()
        Me.GBoxFornecedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(107, 216)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEliminar.TabIndex = 162
        Me.BtnEliminar.Text = "Eliminar"
        Me.ToolTip.SetToolTip(Me.BtnEliminar, "Excluir parcela")
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
        Me.ToolTip.SetToolTip(Me.BtnIncluir, "Incluir duplicata")
        Me.BtnIncluir.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnEditar.Location = New System.Drawing.Point(206, 216)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(100, 30)
        Me.BtnEditar.TabIndex = 166
        Me.BtnEditar.Text = "Editar"
        Me.ToolTip.SetToolTip(Me.BtnEditar, "Editar registro")
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnPesqPedido
        '
        Me.BtnPesqPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesqPedido.Enabled = False
        Me.BtnPesqPedido.FlatAppearance.BorderSize = 0
        Me.BtnPesqPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesqPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesqPedido.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesqPedido.Image = CType(resources.GetObject("BtnPesqPedido.Image"), System.Drawing.Image)
        Me.BtnPesqPedido.Location = New System.Drawing.Point(423, 16)
        Me.BtnPesqPedido.Name = "BtnPesqPedido"
        Me.BtnPesqPedido.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesqPedido.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.BtnPesqPedido, "Consultar Pedido")
        Me.BtnPesqPedido.UseVisualStyleBackColor = True
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
        Me.BtnProximo.Location = New System.Drawing.Point(85, 16)
        Me.BtnProximo.Name = "BtnProximo"
        Me.BtnProximo.Size = New System.Drawing.Size(25, 25)
        Me.BtnProximo.TabIndex = 156
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
        Me.BtnAnterior.Location = New System.Drawing.Point(52, 16)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(25, 25)
        Me.BtnAnterior.TabIndex = 155
        Me.ToolTip.SetToolTip(Me.BtnAnterior, "Anterior")
        Me.BtnAnterior.UseVisualStyleBackColor = True
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.BackColor = System.Drawing.Color.White
        Me.TxtPesquisar.Location = New System.Drawing.Point(117, 20)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(27, 20)
        Me.TxtPesquisar.TabIndex = 152
        Me.ToolTip.SetToolTip(Me.TxtPesquisar, "Pesquisar nome fantasia")
        Me.TxtPesquisar.Visible = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(90, 10)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCancelar.TabIndex = 162
        Me.BtnCancelar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnCancelar, "Cancelar")
        Me.BtnCancelar.UseVisualStyleBackColor = False
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
        Me.BtnSalvar.Location = New System.Drawing.Point(132, 10)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 158
        Me.BtnSalvar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSalvar, "Salvar resgistro")
        Me.BtnSalvar.UseVisualStyleBackColor = False
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
        Me.BtnNovo.Location = New System.Drawing.Point(6, 10)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(35, 35)
        Me.BtnNovo.TabIndex = 157
        Me.BtnNovo.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnNovo, "Adicionar novo registro")
        Me.BtnNovo.UseVisualStyleBackColor = False
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
        Me.BtnSair.Location = New System.Drawing.Point(210, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 161
        Me.BtnSair.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = False
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
        Me.BtnLimpar.Location = New System.Drawing.Point(46, 10)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(35, 35)
        Me.BtnLimpar.TabIndex = 159
        Me.BtnLimpar.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnLimpar, "Limpar dados")
        Me.BtnLimpar.UseVisualStyleBackColor = False
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
        Me.BtnExcluir.Location = New System.Drawing.Point(172, 10)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 160
        Me.BtnExcluir.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnExcluir, "Excluir registro")
        Me.BtnExcluir.UseVisualStyleBackColor = False
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnAtualizar.Location = New System.Drawing.Point(305, 216)
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(100, 30)
        Me.BtnAtualizar.TabIndex = 169
        Me.BtnAtualizar.Text = "Atualizar"
        Me.ToolTip.SetToolTip(Me.BtnAtualizar, "Atualizar DataGrid")
        Me.BtnAtualizar.UseVisualStyleBackColor = True
        '
        'BtnPesquisarNota
        '
        Me.BtnPesquisarNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisarNota.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarNota.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarNota.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarNota.Image = CType(resources.GetObject("BtnPesquisarNota.Image"), System.Drawing.Image)
        Me.BtnPesquisarNota.Location = New System.Drawing.Point(12, 16)
        Me.BtnPesquisarNota.Name = "BtnPesquisarNota"
        Me.BtnPesquisarNota.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisarNota.TabIndex = 158
        Me.ToolTip.SetToolTip(Me.BtnPesquisarNota, "Perquisar nota fiscal")
        Me.BtnPesquisarNota.UseVisualStyleBackColor = True
        '
        'TxtNotaFiscal
        '
        Me.TxtNotaFiscal.Enabled = False
        Me.TxtNotaFiscal.Location = New System.Drawing.Point(97, 16)
        Me.TxtNotaFiscal.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNotaFiscal.Name = "TxtNotaFiscal"
        Me.TxtNotaFiscal.Size = New System.Drawing.Size(115, 20)
        Me.TxtNotaFiscal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Nº Nfe:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TxtIdRegistro)
        Me.GroupBox3.Controls.Add(Me.BtnPesqPedido)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtDescPed)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TxtTotalNota)
        Me.GroupBox3.Controls.Add(Me.TxtNomeFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtFornecedor)
        Me.GroupBox3.Controls.Add(Me.TxtCodPedido)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DataEmissao)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtNotaFiscal)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 92)
        Me.GroupBox3.TabIndex = 126
        Me.GroupBox3.TabStop = False
        '
        'TxtIdRegistro
        '
        Me.TxtIdRegistro.Enabled = False
        Me.TxtIdRegistro.Location = New System.Drawing.Point(578, 17)
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
        Me.Label4.Location = New System.Drawing.Point(502, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Id Registro:"
        '
        'TxtDescPed
        '
        Me.TxtDescPed.Enabled = False
        Me.TxtDescPed.Location = New System.Drawing.Point(308, 17)
        Me.TxtDescPed.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescPed.Name = "TxtDescPed"
        Me.TxtDescPed.Size = New System.Drawing.Size(108, 20)
        Me.TxtDescPed.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(488, 60)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 16)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "Total:"
        '
        'TxtTotalNota
        '
        Me.TxtTotalNota.Enabled = False
        Me.TxtTotalNota.Location = New System.Drawing.Point(532, 58)
        Me.TxtTotalNota.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalNota.Name = "TxtTotalNota"
        Me.TxtTotalNota.Size = New System.Drawing.Size(83, 20)
        Me.TxtTotalNota.TabIndex = 142
        Me.TxtTotalNota.Text = "0"
        '
        'TxtNomeFornecedor
        '
        Me.TxtNomeFornecedor.Enabled = False
        Me.TxtNomeFornecedor.Location = New System.Drawing.Point(309, 56)
        Me.TxtNomeFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNomeFornecedor.Name = "TxtNomeFornecedor"
        Me.TxtNomeFornecedor.Size = New System.Drawing.Size(166, 20)
        Me.TxtNomeFornecedor.TabIndex = 130
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.Enabled = False
        Me.TxtFornecedor.Location = New System.Drawing.Point(275, 56)
        Me.TxtFornecedor.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(32, 20)
        Me.TxtFornecedor.TabIndex = 129
        Me.TxtFornecedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCodPedido
        '
        Me.TxtCodPedido.Enabled = False
        Me.TxtCodPedido.Location = New System.Drawing.Point(274, 17)
        Me.TxtCodPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodPedido.Name = "TxtCodPedido"
        Me.TxtCodPedido.Size = New System.Drawing.Size(32, 20)
        Me.TxtCodPedido.TabIndex = 145
        Me.TxtCodPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 57)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Fornec."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Emisão NFe:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(220, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "Pedido:"
        '
        'DataEmissao
        '
        Me.DataEmissao.Enabled = False
        Me.DataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEmissao.Location = New System.Drawing.Point(97, 56)
        Me.DataEmissao.Name = "DataEmissao"
        Me.DataEmissao.Size = New System.Drawing.Size(97, 20)
        Me.DataEmissao.TabIndex = 4
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.White
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 3)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle21.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(626, 245)
        Me.DataGrid.TabIndex = 154
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPageDuplicatas)
        Me.TabControl1.Location = New System.Drawing.Point(27, 157)
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
        Me.TabPageDuplicatas.Controls.Add(Me.BtnAtualizar)
        Me.TabPageDuplicatas.Controls.Add(Me.Label6)
        Me.TabPageDuplicatas.Controls.Add(Me.TxtTotalDuplicatas)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(433, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 168
        Me.Label6.Text = "Total Duplicatas:"
        '
        'TxtTotalDuplicatas
        '
        Me.TxtTotalDuplicatas.Enabled = False
        Me.TxtTotalDuplicatas.Location = New System.Drawing.Point(540, 222)
        Me.TxtTotalDuplicatas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTotalDuplicatas.Name = "TxtTotalDuplicatas"
        Me.TxtTotalDuplicatas.Size = New System.Drawing.Size(83, 20)
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
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridDuplicatas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridDuplicatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridDuplicatas.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataGridDuplicatas.EnableHeadersVisualStyles = False
        Me.DataGridDuplicatas.Location = New System.Drawing.Point(8, 6)
        Me.DataGridDuplicatas.MultiSelect = False
        Me.DataGridDuplicatas.Name = "DataGridDuplicatas"
        Me.DataGridDuplicatas.ReadOnly = True
        Me.DataGridDuplicatas.RowHeadersVisible = False
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle24.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGridDuplicatas.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridDuplicatas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridDuplicatas.Size = New System.Drawing.Size(615, 210)
        Me.DataGridDuplicatas.TabIndex = 165
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSaldo.ForeColor = System.Drawing.Color.Brown
        Me.LblSaldo.Location = New System.Drawing.Point(288, 437)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(375, 15)
        Me.LblSaldo.TabIndex = 156
        Me.LblSaldo.Text = "Valor total das duplicatas diferente do valor total da Nota!"
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.BtnPesquisarNota)
        Me.GboxPesProd.Controls.Add(Me.BtnProximo)
        Me.GboxPesProd.Controls.Add(Me.BtnAnterior)
        Me.GboxPesProd.Controls.Add(Me.TxtPesquisar)
        Me.GboxPesProd.Location = New System.Drawing.Point(27, 4)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(164, 50)
        Me.GboxPesProd.TabIndex = 157
        Me.GboxPesProd.TabStop = False
        '
        'GBoxFornecedor
        '
        Me.GBoxFornecedor.BackColor = System.Drawing.Color.Transparent
        Me.GBoxFornecedor.Controls.Add(Me.BtnCancelar)
        Me.GBoxFornecedor.Controls.Add(Me.BtnSalvar)
        Me.GBoxFornecedor.Controls.Add(Me.BtnNovo)
        Me.GBoxFornecedor.Controls.Add(Me.BtnSair)
        Me.GBoxFornecedor.Controls.Add(Me.BtnLimpar)
        Me.GBoxFornecedor.Controls.Add(Me.BtnExcluir)
        Me.GBoxFornecedor.Location = New System.Drawing.Point(407, 5)
        Me.GBoxFornecedor.Name = "GBoxFornecedor"
        Me.GBoxFornecedor.Size = New System.Drawing.Size(257, 50)
        Me.GBoxFornecedor.TabIndex = 158
        Me.GBoxFornecedor.TabStop = False
        '
        'FrmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(694, 462)
        Me.Controls.Add(Me.GBoxFornecedor)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.LblSaldo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Nota Fiscal"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPageDuplicatas.ResumeLayout(False)
        Me.TabPageDuplicatas.PerformLayout()
        CType(Me.DataGridDuplicatas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GboxPesProd.ResumeLayout(False)
        Me.GboxPesProd.PerformLayout()
        Me.GBoxFornecedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents TxtNotaFiscal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataEmissao As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdRegistro As TextBox
    Friend WithEvents Label4 As Label
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
    Friend WithEvents TxtTotalDuplicatas As TextBox
    Friend WithEvents LblSaldo As Label
    Friend WithEvents TxtCodPedido As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDescPed As TextBox
    Friend WithEvents BtnPesqPedido As Button
    Friend WithEvents GboxPesProd As GroupBox
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents GBoxFornecedor As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnAtualizar As Button
    Friend WithEvents BtnPesquisarNota As Button
End Class
