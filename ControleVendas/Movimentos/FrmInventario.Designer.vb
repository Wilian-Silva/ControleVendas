<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventario
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnInventario = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnExcluirLista = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnAtualizarestqoue = New System.Windows.Forms.Button()
        Me.Btnconferncia = New System.Windows.Forms.Button()
        Me.BtnSalvarContagem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataInventario = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.TxtCodInventario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridCopy = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridCopy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid
        '
        Me.DataGrid.AllowUserToAddRows = False
        Me.DataGrid.AllowUserToDeleteRows = False
        Me.DataGrid.AllowUserToResizeColumns = False
        Me.DataGrid.AllowUserToResizeRows = False
        Me.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid.EnableHeadersVisualStyles = False
        Me.DataGrid.Location = New System.Drawing.Point(3, 16)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGrid.Size = New System.Drawing.Size(841, 542)
        Me.DataGrid.TabIndex = 149
        '
        'BtnInventario
        '
        Me.BtnInventario.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInventario.Location = New System.Drawing.Point(347, 19)
        Me.BtnInventario.Name = "BtnInventario"
        Me.BtnInventario.Size = New System.Drawing.Size(150, 28)
        Me.BtnInventario.TabIndex = 158
        Me.BtnInventario.Text = "GERAR NOVA LISTA"
        Me.ToolTip.SetToolTip(Me.BtnInventario, "Gerar nova lista de inventário")
        Me.BtnInventario.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(503, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 28)
        Me.Button2.TabIndex = 161
        Me.Button2.Text = "GERAR DIFERENÇAS"
        Me.ToolTip.SetToolTip(Me.Button2, "Comparar saldo atual em estoque com contagem fisica")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnExcluirLista
        '
        Me.BtnExcluirLista.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExcluirLista.Location = New System.Drawing.Point(503, 53)
        Me.BtnExcluirLista.Name = "BtnExcluirLista"
        Me.BtnExcluirLista.Size = New System.Drawing.Size(150, 28)
        Me.BtnExcluirLista.TabIndex = 163
        Me.BtnExcluirLista.Text = "EXCLUIR LISTA"
        Me.ToolTip.SetToolTip(Me.BtnExcluirLista, "Excluir lista de inventário")
        Me.BtnExcluirLista.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(347, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 28)
        Me.Button1.TabIndex = 164
        Me.Button1.Text = "PESQUISAR LISTA"
        Me.ToolTip.SetToolTip(Me.Button1, "`Pesquisar lista de inventário")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnAtualizarestqoue
        '
        Me.BtnAtualizarestqoue.Font = New System.Drawing.Font("Segoe UI", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAtualizarestqoue.Location = New System.Drawing.Point(672, 19)
        Me.BtnAtualizarestqoue.Name = "BtnAtualizarestqoue"
        Me.BtnAtualizarestqoue.Size = New System.Drawing.Size(144, 60)
        Me.BtnAtualizarestqoue.TabIndex = 165
        Me.BtnAtualizarestqoue.Text = "ATUALIZAR SALDO ESTOQUE "
        Me.ToolTip.SetToolTip(Me.BtnAtualizarestqoue, "Atualizar estoque com os saldos da contagem")
        Me.BtnAtualizarestqoue.UseVisualStyleBackColor = True
        '
        'Btnconferncia
        '
        Me.Btnconferncia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnconferncia.Location = New System.Drawing.Point(672, 92)
        Me.Btnconferncia.Name = "Btnconferncia"
        Me.Btnconferncia.Size = New System.Drawing.Size(144, 28)
        Me.Btnconferncia.TabIndex = 166
        Me.Btnconferncia.Text = "GERAR CONFERENCIA"
        Me.ToolTip.SetToolTip(Me.Btnconferncia, "Compara a lista digitado com o saldo em estoque")
        Me.Btnconferncia.UseVisualStyleBackColor = True
        '
        'BtnSalvarContagem
        '
        Me.BtnSalvarContagem.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalvarContagem.Location = New System.Drawing.Point(503, 21)
        Me.BtnSalvarContagem.Name = "BtnSalvarContagem"
        Me.BtnSalvarContagem.Size = New System.Drawing.Size(150, 28)
        Me.BtnSalvarContagem.TabIndex = 167
        Me.BtnSalvarContagem.Text = "SALVAR CONTAGEM "
        Me.ToolTip.SetToolTip(Me.BtnSalvarContagem, "Salvar lista com contagem parcial")
        Me.BtnSalvarContagem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 16)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Data Iventário:"
        '
        'DataInventario
        '
        Me.DataInventario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInventario.Location = New System.Drawing.Point(133, 61)
        Me.DataInventario.Name = "DataInventario"
        Me.DataInventario.Size = New System.Drawing.Size(97, 20)
        Me.DataInventario.TabIndex = 153
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Descrição:"
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Enabled = False
        Me.TxtDescricao.Location = New System.Drawing.Point(133, 97)
        Me.TxtDescricao.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(198, 20)
        Me.TxtDescricao.TabIndex = 152
        '
        'TxtCodInventario
        '
        Me.TxtCodInventario.Enabled = False
        Me.TxtCodInventario.Location = New System.Drawing.Point(133, 24)
        Me.TxtCodInventario.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCodInventario.Name = "TxtCodInventario"
        Me.TxtCodInventario.Size = New System.Drawing.Size(51, 20)
        Me.TxtCodInventario.TabIndex = 157
        Me.TxtCodInventario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "Nº Inventário:"
        '
        'DataGridCopy
        '
        Me.DataGridCopy.AllowUserToAddRows = False
        Me.DataGridCopy.AllowUserToDeleteRows = False
        Me.DataGridCopy.AllowUserToResizeColumns = False
        Me.DataGridCopy.AllowUserToResizeRows = False
        Me.DataGridCopy.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridCopy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridCopy.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridCopy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridCopy.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridCopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridCopy.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridCopy.EnableHeadersVisualStyles = False
        Me.DataGridCopy.Location = New System.Drawing.Point(240, 14)
        Me.DataGridCopy.MultiSelect = False
        Me.DataGridCopy.Name = "DataGridCopy"
        Me.DataGridCopy.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.DataGridCopy.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridCopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridCopy.Size = New System.Drawing.Size(76, 65)
        Me.DataGridCopy.TabIndex = 159
        Me.DataGridCopy.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSalvarContagem)
        Me.GroupBox1.Controls.Add(Me.Btnconferncia)
        Me.GroupBox1.Controls.Add(Me.BtnAtualizarestqoue)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BtnInventario)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DataInventario)
        Me.GroupBox1.Controls.Add(Me.DataGridCopy)
        Me.GroupBox1.Controls.Add(Me.BtnExcluirLista)
        Me.GroupBox1.Controls.Add(Me.TxtDescricao)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCodInventario)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 128)
        Me.GroupBox1.TabIndex = 164
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGrid)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(847, 561)
        Me.GroupBox2.TabIndex = 165
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 689)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(847, 80)
        Me.Panel1.TabIndex = 166
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(841, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "LEGENDA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(565, 32)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(20, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(272, 31)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(20, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(14, 32)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(20, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(587, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contagem maior que o saldo do sistema"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(295, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contagem menor que o saldo do sistema"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Contagem igual ao saldo do sistema"
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 769)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "FrmInventario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventário"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridCopy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents DataInventario As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDescricao As TextBox
    Friend WithEvents TxtCodInventario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnInventario As Button
    Friend WithEvents DataGridCopy As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnExcluirLista As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnAtualizarestqoue As Button
    Friend WithEvents Btnconferncia As Button
    Friend WithEvents BtnSalvarContagem As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
End Class
