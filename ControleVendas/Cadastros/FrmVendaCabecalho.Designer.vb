<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendaCabecalho
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendaCabecalho))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblIdPedido = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtIdVenda = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnListarTudo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataFinal = New System.Windows.Forms.DateTimePicker()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.DataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblIdPedido
        '
        Me.LblIdPedido.AutoSize = True
        Me.LblIdPedido.BackColor = System.Drawing.Color.Transparent
        Me.LblIdPedido.Location = New System.Drawing.Point(11, 10)
        Me.LblIdPedido.Name = "LblIdPedido"
        Me.LblIdPedido.Size = New System.Drawing.Size(53, 13)
        Me.LblIdPedido.TabIndex = 148
        Me.LblIdPedido.Text = "Id. Venda"
        Me.LblIdPedido.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtIdVenda)
        Me.GroupBox4.Controls.Add(Me.LblIdPedido)
        Me.GroupBox4.Location = New System.Drawing.Point(559, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(71, 50)
        Me.GroupBox4.TabIndex = 152
        Me.GroupBox4.TabStop = False
        '
        'TxtIdVenda
        '
        Me.TxtIdVenda.Enabled = False
        Me.TxtIdVenda.Location = New System.Drawing.Point(20, 24)
        Me.TxtIdVenda.Multiline = True
        Me.TxtIdVenda.Name = "TxtIdVenda"
        Me.TxtIdVenda.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdVenda.TabIndex = 147
        Me.TxtIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtIdVenda.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnExcluir)
        Me.GroupBox3.Controls.Add(Me.BtnSair)
        Me.GroupBox3.Location = New System.Drawing.Point(660, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(90, 50)
        Me.GroupBox3.TabIndex = 151
        Me.GroupBox3.TabStop = False
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.Location = New System.Drawing.Point(10, 8)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 58
        Me.ToolTip.SetToolTip(Me.BtnExcluir, "Excluir resgistro")
        Me.BtnExcluir.UseVisualStyleBackColor = True
        Me.BtnExcluir.Visible = False
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
        Me.BtnSair.Location = New System.Drawing.Point(48, 9)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 57
        Me.ToolTip.SetToolTip(Me.BtnSair, "Sair")
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'BtnListarTudo
        '
        Me.BtnListarTudo.AccessibleDescription = ""
        Me.BtnListarTudo.AccessibleName = "Adicionar"
        Me.BtnListarTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnListarTudo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnListarTudo.FlatAppearance.BorderSize = 0
        Me.BtnListarTudo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnListarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListarTudo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListarTudo.Image = CType(resources.GetObject("BtnListarTudo.Image"), System.Drawing.Image)
        Me.BtnListarTudo.Location = New System.Drawing.Point(7, 14)
        Me.BtnListarTudo.Name = "BtnListarTudo"
        Me.BtnListarTudo.Size = New System.Drawing.Size(40, 30)
        Me.BtnListarTudo.TabIndex = 139
        Me.ToolTip.SetToolTip(Me.BtnListarTudo, "Carregar todos os dados")
        Me.BtnListarTudo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnListarTudo)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(60, 50)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listar"
        '
        'DataFinal
        '
        Me.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFinal.Location = New System.Drawing.Point(267, 19)
        Me.DataFinal.Name = "DataFinal"
        Me.DataFinal.Size = New System.Drawing.Size(95, 20)
        Me.DataFinal.TabIndex = 135
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.AccessibleDescription = ""
        Me.BtnPesquisar.AccessibleName = "Adicionar"
        Me.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPesquisar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.Location = New System.Drawing.Point(369, 18)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(22, 22)
        Me.BtnPesquisar.TabIndex = 138
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'DataInicial
        '
        Me.DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicial.Location = New System.Drawing.Point(77, 19)
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.Size = New System.Drawing.Size(95, 20)
        Me.DataInicial.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Data Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Data Inicial:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataFinal)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisar)
        Me.GroupBox1.Controls.Add(Me.DataInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(118, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 50)
        Me.GroupBox1.TabIndex = 149
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por data venda"
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
        Me.DataGrid.Location = New System.Drawing.Point(22, 86)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(728, 289)
        Me.DataGrid.TabIndex = 153
        '
        'FrmVendaCabecalho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(778, 403)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmVendaCabecalho"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas Efetuadas"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblIdPedido As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtIdVenda As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnListarTudo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataFinal As DateTimePicker
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents DataInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGrid As DataGridView
End Class
