<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSaldoEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSaldoEstoque))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnProximo = New System.Windows.Forms.Button()
        Me.BtnAnterior = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtSaldoEstoque = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCodAuxiliar = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.TxtLucro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMargemVenda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.TxtPesquisa = New System.Windows.Forms.TextBox()
        Me.RbDescricao = New System.Windows.Forms.RadioButton()
        Me.RbCodAux = New System.Windows.Forms.RadioButton()
        Me.GboxPesProd = New System.Windows.Forms.GroupBox()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GboxPesProd.SuspendLayout()
        Me.SuspendLayout()
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
        Me.BtnProximo.Location = New System.Drawing.Point(429, 14)
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
        Me.BtnAnterior.Location = New System.Drawing.Point(398, 14)
        Me.BtnAnterior.Name = "BtnAnterior"
        Me.BtnAnterior.Size = New System.Drawing.Size(25, 25)
        Me.BtnAnterior.TabIndex = 155
        Me.ToolTip.SetToolTip(Me.BtnAnterior, "Anterior")
        Me.BtnAnterior.UseVisualStyleBackColor = True
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
        Me.DataGrid.Location = New System.Drawing.Point(20, 154)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(570, 218)
        Me.DataGrid.TabIndex = 154
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
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtMargemVenda)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.TxtPrecoVenda)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(570, 86)
        Me.GroupBox3.TabIndex = 155
        Me.GroupBox3.TabStop = False
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(379, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Cód. Auxiliar"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Preço de Compra:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnProximo)
        Me.GroupBox1.Controls.Add(Me.BtnAnterior)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisa)
        Me.GroupBox1.Controls.Add(Me.RbDescricao)
        Me.GroupBox1.Controls.Add(Me.RbCodAux)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 50)
        Me.GroupBox1.TabIndex = 161
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar"
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
        Me.BtnSair.Location = New System.Drawing.Point(35, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 164
        Me.BtnSair.TabStop = False
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'TxtPesquisa
        '
        Me.TxtPesquisa.Location = New System.Drawing.Point(182, 19)
        Me.TxtPesquisa.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisa.Name = "TxtPesquisa"
        Me.TxtPesquisa.Size = New System.Drawing.Size(208, 20)
        Me.TxtPesquisa.TabIndex = 160
        '
        'RbDescricao
        '
        Me.RbDescricao.AutoSize = True
        Me.RbDescricao.Checked = True
        Me.RbDescricao.Location = New System.Drawing.Point(20, 20)
        Me.RbDescricao.Name = "RbDescricao"
        Me.RbDescricao.Size = New System.Drawing.Size(73, 17)
        Me.RbDescricao.TabIndex = 159
        Me.RbDescricao.TabStop = True
        Me.RbDescricao.Text = "Descrição"
        Me.RbDescricao.UseVisualStyleBackColor = True
        '
        'RbCodAux
        '
        Me.RbCodAux.AutoSize = True
        Me.RbCodAux.Location = New System.Drawing.Point(102, 20)
        Me.RbCodAux.Name = "RbCodAux"
        Me.RbCodAux.Size = New System.Drawing.Size(71, 17)
        Me.RbCodAux.TabIndex = 158
        Me.RbCodAux.Text = "Cód. Aux."
        Me.RbCodAux.UseVisualStyleBackColor = True
        '
        'GboxPesProd
        '
        Me.GboxPesProd.BackColor = System.Drawing.Color.Transparent
        Me.GboxPesProd.Controls.Add(Me.BtnSair)
        Me.GboxPesProd.Location = New System.Drawing.Point(506, 3)
        Me.GboxPesProd.Name = "GboxPesProd"
        Me.GboxPesProd.Size = New System.Drawing.Size(84, 50)
        Me.GboxPesProd.TabIndex = 165
        Me.GboxPesProd.TabStop = False
        '
        'FrmSaldoEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(614, 397)
        Me.Controls.Add(Me.GboxPesProd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmSaldoEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Saldo Estoque"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GboxPesProd.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtSaldoEstoque As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCodAuxiliar As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtLucro As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMargemVenda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrecoVenda As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPesquisa As TextBox
    Friend WithEvents RbDescricao As RadioButton
    Friend WithEvents RbCodAux As RadioButton
    Friend WithEvents BtnSair As Button
    Friend WithEvents GboxPesProd As GroupBox
End Class
