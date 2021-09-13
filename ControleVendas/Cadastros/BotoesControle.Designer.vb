<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BotoesControle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BotoesControle))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnCacelar = New System.Windows.Forms.Button()
        Me.BtnSelecionarItem = New System.Windows.Forms.Button()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtndAdicionarItem = New System.Windows.Forms.Button()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEndereco = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Controle_vendasDataSet1 = New ControleVendas.controle_vendasDataSet()
        Me.TxtSequencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Controle_vendasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BtnCacelar.Location = New System.Drawing.Point(494, 53)
        Me.BtnCacelar.Name = "BtnCacelar"
        Me.BtnCacelar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCacelar.TabIndex = 158
        Me.BtnCacelar.TabStop = False
        Me.BtnCacelar.UseVisualStyleBackColor = True
        Me.BtnCacelar.Visible = False
        '
        'BtnSelecionarItem
        '
        Me.BtnSelecionarItem.AccessibleDescription = ""
        Me.BtnSelecionarItem.AccessibleName = "Adicionar"
        Me.BtnSelecionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSelecionarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelecionarItem.FlatAppearance.BorderSize = 0
        Me.BtnSelecionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSelecionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionarItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSelecionarItem.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSelecionarItem.Image = CType(resources.GetObject("BtnSelecionarItem.Image"), System.Drawing.Image)
        Me.BtnSelecionarItem.Location = New System.Drawing.Point(453, 53)
        Me.BtnSelecionarItem.Name = "BtnSelecionarItem"
        Me.BtnSelecionarItem.Size = New System.Drawing.Size(35, 35)
        Me.BtnSelecionarItem.TabIndex = 156
        Me.BtnSelecionarItem.TabStop = False
        Me.BtnSelecionarItem.UseVisualStyleBackColor = True
        Me.BtnSelecionarItem.Visible = False
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
        Me.BtnCarregar.Location = New System.Drawing.Point(412, 54)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 155
        Me.BtnCarregar.TabStop = False
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.AccessibleDescription = ""
        Me.BtnNovo.AccessibleName = "Adicionar"
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatAppearance.BorderSize = 0
        Me.BtnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNovo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnNovo.Image = CType(resources.GetObject("BtnNovo.Image"), System.Drawing.Image)
        Me.BtnNovo.Location = New System.Drawing.Point(164, 53)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(35, 35)
        Me.BtnNovo.TabIndex = 159
        Me.BtnNovo.TabStop = False
        Me.BtnNovo.UseVisualStyleBackColor = True
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
        Me.BtnSair.Location = New System.Drawing.Point(363, 54)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 163
        Me.BtnSair.TabStop = False
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
        Me.BtnExcluir.Location = New System.Drawing.Point(328, 54)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 162
        Me.BtnExcluir.TabStop = False
        Me.BtnExcluir.UseVisualStyleBackColor = True
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
        Me.BtnLimpar.Location = New System.Drawing.Point(252, 54)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(35, 35)
        Me.BtnLimpar.TabIndex = 161
        Me.BtnLimpar.TabStop = False
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
        Me.BtnSalvar.Location = New System.Drawing.Point(293, 55)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(35, 35)
        Me.BtnSalvar.TabIndex = 160
        Me.BtnSalvar.TabStop = False
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.AccessibleDescription = ""
        Me.BtnEditar.AccessibleName = "Adicionar"
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.Location = New System.Drawing.Point(211, 53)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(35, 35)
        Me.BtnEditar.TabIndex = 157
        Me.BtnEditar.TabStop = False
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtndAdicionarItem
        '
        Me.BtndAdicionarItem.AccessibleDescription = ""
        Me.BtndAdicionarItem.AccessibleName = "Adicionar"
        Me.BtndAdicionarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtndAdicionarItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtndAdicionarItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtndAdicionarItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtndAdicionarItem.Image = CType(resources.GetObject("BtndAdicionarItem.Image"), System.Drawing.Image)
        Me.BtndAdicionarItem.Location = New System.Drawing.Point(60, 55)
        Me.BtndAdicionarItem.Name = "BtndAdicionarItem"
        Me.BtndAdicionarItem.Size = New System.Drawing.Size(35, 35)
        Me.BtndAdicionarItem.TabIndex = 164
        Me.BtndAdicionarItem.UseVisualStyleBackColor = True
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGrid.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(60, 182)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(548, 160)
        Me.DataGrid.TabIndex = 165
        '
        'TxtNome
        '
        Me.TxtNome.BackColor = System.Drawing.Color.White
        Me.TxtNome.Location = New System.Drawing.Point(185, 120)
        Me.TxtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(179, 20)
        Me.TxtNome.TabIndex = 166
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Nome Cliente:"
        '
        'TxtEndereco
        '
        Me.TxtEndereco.BackColor = System.Drawing.Color.White
        Me.TxtEndereco.Location = New System.Drawing.Point(460, 120)
        Me.TxtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtEndereco.Name = "TxtEndereco"
        Me.TxtEndereco.Size = New System.Drawing.Size(177, 20)
        Me.TxtEndereco.TabIndex = 167
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(147, 120)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(30, 20)
        Me.TxtId.TabIndex = 168
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(391, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Endereço:"
        '
        'Controle_vendasDataSet1
        '
        Me.Controle_vendasDataSet1.DataSetName = "controle_vendasDataSet"
        Me.Controle_vendasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtSequencia
        '
        Me.TxtSequencia.Location = New System.Drawing.Point(147, 148)
        Me.TxtSequencia.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSequencia.Name = "TxtSequencia"
        Me.TxtSequencia.Size = New System.Drawing.Size(30, 20)
        Me.TxtSequencia.TabIndex = 171
        Me.TxtSequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Item:"
        '
        'BotoesControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSequencia)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtEndereco)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.BtndAdicionarItem)
        Me.Controls.Add(Me.BtnCacelar)
        Me.Controls.Add(Me.BtnSelecionarItem)
        Me.Controls.Add(Me.BtnCarregar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Name = "BotoesControle"
        Me.Text = "BotoesControle"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Controle_vendasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCacelar As Button
    Friend WithEvents BtnSelecionarItem As Button
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtndAdicionarItem As Button
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEndereco As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Controle_vendasDataSet1 As controle_vendasDataSet
    Friend WithEvents TxtSequencia As TextBox
    Friend WithEvents Label1 As Label
End Class
