﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNotasEntrada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNotasEntrada))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataFinal = New System.Windows.Forms.DateTimePicker()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.DataInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.BtnListarTudo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtIdPedido = New System.Windows.Forms.TextBox()
        Me.LblIdPedido = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataFinal
        '
        Me.DataFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFinal.Location = New System.Drawing.Point(270, 19)
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
        Me.BtnPesquisar.FlatAppearance.BorderSize = 0
        Me.BtnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.Location = New System.Drawing.Point(371, 15)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisar.TabIndex = 138
        Me.ToolTip.SetToolTip(Me.BtnPesquisar, "Filtrar por data")
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'DataInicial
        '
        Me.DataInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicial.Location = New System.Drawing.Point(80, 19)
        Me.DataInicial.Name = "DataInicial"
        Me.DataInicial.Size = New System.Drawing.Size(95, 20)
        Me.DataInicial.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Data Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Data Inicial:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtPesquisar)
        Me.GroupBox2.Controls.Add(Me.BtnListarTudo)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 50)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesquisar"
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.BackColor = System.Drawing.Color.White
        Me.TxtPesquisar.Location = New System.Drawing.Point(16, 19)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(90, 20)
        Me.TxtPesquisar.TabIndex = 157
        Me.ToolTip.SetToolTip(Me.TxtPesquisar, "Pesquisar por nota fiscal")
        '
        'BtnListarTudo
        '
        Me.BtnListarTudo.AccessibleDescription = ""
        Me.BtnListarTudo.AccessibleName = "Adicionar"
        Me.BtnListarTudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnListarTudo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnListarTudo.FlatAppearance.BorderSize = 0
        Me.BtnListarTudo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnListarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnListarTudo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnListarTudo.ForeColor = System.Drawing.Color.Transparent
        Me.BtnListarTudo.Image = CType(resources.GetObject("BtnListarTudo.Image"), System.Drawing.Image)
        Me.BtnListarTudo.Location = New System.Drawing.Point(121, 10)
        Me.BtnListarTudo.Name = "BtnListarTudo"
        Me.BtnListarTudo.Size = New System.Drawing.Size(35, 35)
        Me.BtnListarTudo.TabIndex = 156
        Me.BtnListarTudo.TabStop = False
        Me.ToolTip.SetToolTip(Me.BtnListarTudo, "Listar tudo")
        Me.BtnListarTudo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataFinal)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisar)
        Me.GroupBox1.Controls.Add(Me.DataInicial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(195, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 50)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar por data registro"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnSair)
        Me.GroupBox3.Controls.Add(Me.BtnExcluir)
        Me.GroupBox3.Location = New System.Drawing.Point(746, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(72, 50)
        Me.GroupBox3.TabIndex = 144
        Me.GroupBox3.TabStop = False
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
        Me.BtnSair.Location = New System.Drawing.Point(30, 9)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 165
        Me.BtnSair.TabStop = False
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
        Me.BtnExcluir.Location = New System.Drawing.Point(0, 9)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(35, 35)
        Me.BtnExcluir.TabIndex = 164
        Me.BtnExcluir.TabStop = False
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'TxtId
        '
        Me.TxtId.Enabled = False
        Me.TxtId.Location = New System.Drawing.Point(9, 22)
        Me.TxtId.Multiline = True
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(34, 20)
        Me.TxtId.TabIndex = 145
        Me.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtId.Visible = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.BackColor = System.Drawing.Color.Transparent
        Me.LblId.Location = New System.Drawing.Point(6, 7)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(45, 13)
        Me.LblId.TabIndex = 146
        Me.LblId.Text = "Id. Reg."
        Me.LblId.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TxtIdPedido)
        Me.GroupBox4.Controls.Add(Me.LblIdPedido)
        Me.GroupBox4.Controls.Add(Me.TxtId)
        Me.GroupBox4.Controls.Add(Me.LblId)
        Me.GroupBox4.Location = New System.Drawing.Point(608, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(132, 50)
        Me.GroupBox4.TabIndex = 147
        Me.GroupBox4.TabStop = False
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.Enabled = False
        Me.TxtIdPedido.Location = New System.Drawing.Point(80, 22)
        Me.TxtIdPedido.Multiline = True
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdPedido.TabIndex = 147
        Me.TxtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtIdPedido.Visible = False
        '
        'LblIdPedido
        '
        Me.LblIdPedido.AutoSize = True
        Me.LblIdPedido.BackColor = System.Drawing.Color.Transparent
        Me.LblIdPedido.Location = New System.Drawing.Point(71, 8)
        Me.LblIdPedido.Name = "LblIdPedido"
        Me.LblIdPedido.Size = New System.Drawing.Size(55, 13)
        Me.LblIdPedido.TabIndex = 148
        Me.LblIdPedido.Text = "Id. Pedido"
        Me.LblIdPedido.Visible = False
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
        Me.DataGrid.Location = New System.Drawing.Point(24, 68)
        Me.DataGrid.MultiSelect = False
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.ReadOnly = True
        Me.DataGrid.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.DataGrid.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGrid.Size = New System.Drawing.Size(649, 284)
        Me.DataGrid.TabIndex = 148
        '
        'FrmNotasEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(829, 382)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmNotasEntrada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Notas de Entrada"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataFinal As DateTimePicker
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents DataInicial As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtIdPedido As TextBox
    Friend WithEvents LblIdPedido As Label
    Friend WithEvents DataGrid As DataGridView
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnListarTudo As Button
    Friend WithEvents TxtPesquisar As TextBox
End Class
