<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLucroNfe
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLucroNfe))
        Me.DataGridApagar = New System.Windows.Forms.DataGridView()
        Me.DataGridRecebidos = New System.Windows.Forms.DataGridView()
        Me.TxtIdNfeEntrada = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNfeEntrada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApagar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRecebidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtRetiradas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtRetirar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridRetiradas = New System.Windows.Forms.DataGridView()
        Me.BtnPortador = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        CType(Me.DataGridApagar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridRecebidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridRetiradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridApagar
        '
        Me.DataGridApagar.AllowUserToAddRows = False
        Me.DataGridApagar.AllowUserToDeleteRows = False
        Me.DataGridApagar.AllowUserToResizeColumns = False
        Me.DataGridApagar.AllowUserToResizeRows = False
        Me.DataGridApagar.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridApagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridApagar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridApagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridApagar.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridApagar.EnableHeadersVisualStyles = False
        Me.DataGridApagar.Location = New System.Drawing.Point(16, 18)
        Me.DataGridApagar.MultiSelect = False
        Me.DataGridApagar.Name = "DataGridApagar"
        Me.DataGridApagar.ReadOnly = True
        Me.DataGridApagar.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGridApagar.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridApagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridApagar.Size = New System.Drawing.Size(605, 99)
        Me.DataGridApagar.TabIndex = 152
        '
        'DataGridRecebidos
        '
        Me.DataGridRecebidos.AllowUserToAddRows = False
        Me.DataGridRecebidos.AllowUserToDeleteRows = False
        Me.DataGridRecebidos.AllowUserToResizeColumns = False
        Me.DataGridRecebidos.AllowUserToResizeRows = False
        Me.DataGridRecebidos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridRecebidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRecebidos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridRecebidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRecebidos.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridRecebidos.EnableHeadersVisualStyles = False
        Me.DataGridRecebidos.Location = New System.Drawing.Point(16, 21)
        Me.DataGridRecebidos.MultiSelect = False
        Me.DataGridRecebidos.Name = "DataGridRecebidos"
        Me.DataGridRecebidos.ReadOnly = True
        Me.DataGridRecebidos.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGridRecebidos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridRecebidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRecebidos.Size = New System.Drawing.Size(605, 99)
        Me.DataGridRecebidos.TabIndex = 153
        '
        'TxtIdNfeEntrada
        '
        Me.TxtIdNfeEntrada.Location = New System.Drawing.Point(48, 18)
        Me.TxtIdNfeEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdNfeEntrada.Name = "TxtIdNfeEntrada"
        Me.TxtIdNfeEntrada.ReadOnly = True
        Me.TxtIdNfeEntrada.Size = New System.Drawing.Size(43, 20)
        Me.TxtIdNfeEntrada.TabIndex = 161
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 169
        Me.Label1.Text = "Nfe:"
        '
        'TxtNfeEntrada
        '
        Me.TxtNfeEntrada.Location = New System.Drawing.Point(92, 18)
        Me.TxtNfeEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNfeEntrada.Name = "TxtNfeEntrada"
        Me.TxtNfeEntrada.ReadOnly = True
        Me.TxtNfeEntrada.Size = New System.Drawing.Size(117, 20)
        Me.TxtNfeEntrada.TabIndex = 170
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "Total a Pagar:"
        '
        'TxtApagar
        '
        Me.TxtApagar.BackColor = System.Drawing.Color.White
        Me.TxtApagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtApagar.Location = New System.Drawing.Point(124, 21)
        Me.TxtApagar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApagar.Name = "TxtApagar"
        Me.TxtApagar.ReadOnly = True
        Me.TxtApagar.Size = New System.Drawing.Size(113, 23)
        Me.TxtApagar.TabIndex = 172
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(355, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 17)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Total Recebidos:"
        '
        'TxtRecebidos
        '
        Me.TxtRecebidos.BackColor = System.Drawing.Color.White
        Me.TxtRecebidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtRecebidos.Location = New System.Drawing.Point(485, 21)
        Me.TxtRecebidos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRecebidos.Name = "TxtRecebidos"
        Me.TxtRecebidos.ReadOnly = True
        Me.TxtRecebidos.Size = New System.Drawing.Size(111, 23)
        Me.TxtRecebidos.TabIndex = 174
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Retiradas:"
        '
        'TxtRetiradas
        '
        Me.TxtRetiradas.BackColor = System.Drawing.Color.White
        Me.TxtRetiradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtRetiradas.Location = New System.Drawing.Point(124, 57)
        Me.TxtRetiradas.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRetiradas.Name = "TxtRetiradas"
        Me.TxtRetiradas.ReadOnly = True
        Me.TxtRetiradas.Size = New System.Drawing.Size(113, 23)
        Me.TxtRetiradas.TabIndex = 176
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(355, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 17)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "Saldo a Retirar:"
        '
        'TxtRetirar
        '
        Me.TxtRetirar.BackColor = System.Drawing.Color.White
        Me.TxtRetirar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRetirar.ForeColor = System.Drawing.Color.Black
        Me.TxtRetirar.Location = New System.Drawing.Point(485, 57)
        Me.TxtRetirar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtRetirar.Name = "TxtRetirar"
        Me.TxtRetirar.ReadOnly = True
        Me.TxtRetirar.Size = New System.Drawing.Size(111, 22)
        Me.TxtRetirar.TabIndex = 178
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridApagar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 137)
        Me.GroupBox1.TabIndex = 182
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Valores a Pagar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridRecebidos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 139)
        Me.GroupBox2.TabIndex = 183
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valores Recebidos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtApagar)
        Me.GroupBox3.Controls.Add(Me.TxtRecebidos)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtRetirar)
        Me.GroupBox3.Controls.Add(Me.TxtRetiradas)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 498)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(641, 102)
        Me.GroupBox3.TabIndex = 184
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridRetiradas)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 351)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(641, 139)
        Me.GroupBox4.TabIndex = 185
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Retiradas"
        '
        'DataGridRetiradas
        '
        Me.DataGridRetiradas.AllowUserToAddRows = False
        Me.DataGridRetiradas.AllowUserToDeleteRows = False
        Me.DataGridRetiradas.AllowUserToResizeColumns = False
        Me.DataGridRetiradas.AllowUserToResizeRows = False
        Me.DataGridRetiradas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridRetiradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRetiradas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridRetiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRetiradas.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridRetiradas.EnableHeadersVisualStyles = False
        Me.DataGridRetiradas.Location = New System.Drawing.Point(16, 21)
        Me.DataGridRetiradas.MultiSelect = False
        Me.DataGridRetiradas.Name = "DataGridRetiradas"
        Me.DataGridRetiradas.ReadOnly = True
        Me.DataGridRetiradas.RowHeadersVisible = False
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.DataGridRetiradas.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridRetiradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRetiradas.Size = New System.Drawing.Size(605, 99)
        Me.DataGridRetiradas.TabIndex = 153
        '
        'BtnPortador
        '
        Me.BtnPortador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnPortador.Location = New System.Drawing.Point(210, 17)
        Me.BtnPortador.Name = "BtnPortador"
        Me.BtnPortador.Size = New System.Drawing.Size(25, 22)
        Me.BtnPortador.TabIndex = 186
        Me.BtnPortador.Text = "..."
        Me.BtnPortador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnPortador.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnPortador.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.BtnSair)
        Me.GroupBox5.Controls.Add(Me.TxtIdNfeEntrada)
        Me.GroupBox5.Controls.Add(Me.BtnPortador)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.TxtNfeEntrada)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(641, 52)
        Me.GroupBox5.TabIndex = 187
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pesquisar Documento"
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
        Me.BtnSair.Location = New System.Drawing.Point(600, 10)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 187
        Me.BtnSair.TabStop = False
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'FrmLucroNfe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 608)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmLucroNfe"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultado por Nfe"
        CType(Me.DataGridApagar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridRecebidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridRetiradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridApagar As DataGridView
    Friend WithEvents DataGridRecebidos As DataGridView
    Friend WithEvents TxtIdNfeEntrada As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNfeEntrada As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApagar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRecebidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtRetiradas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtRetirar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridRetiradas As DataGridView
    Friend WithEvents BtnPortador As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnSair As Button
End Class
