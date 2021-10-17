<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPesqCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdVenda = New System.Windows.Forms.TextBox()
        Me.BtnPesquisarNota = New System.Windows.Forms.Button()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGerar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DataInicio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.DataFim)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtIdVenda)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisarNota)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 114)
        Me.GroupBox1.TabIndex = 181
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Cliente:"
        '
        'TxtIdVenda
        '
        Me.TxtIdVenda.BackColor = System.Drawing.Color.White
        Me.TxtIdVenda.Enabled = False
        Me.TxtIdVenda.Location = New System.Drawing.Point(95, 33)
        Me.TxtIdVenda.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdVenda.Name = "TxtIdVenda"
        Me.TxtIdVenda.Size = New System.Drawing.Size(37, 20)
        Me.TxtIdVenda.TabIndex = 164
        Me.TxtIdVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnPesquisarNota
        '
        Me.BtnPesquisarNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisarNota.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarNota.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarNota.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarNota.Image = CType(resources.GetObject("BtnPesquisarNota.Image"), System.Drawing.Image)
        Me.BtnPesquisarNota.Location = New System.Drawing.Point(336, 30)
        Me.BtnPesquisarNota.Name = "BtnPesquisarNota"
        Me.BtnPesquisarNota.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisarNota.TabIndex = 162
        Me.BtnPesquisarNota.UseVisualStyleBackColor = True
        '
        'TxtCliente
        '
        Me.TxtCliente.BackColor = System.Drawing.Color.White
        Me.TxtCliente.Enabled = False
        Me.TxtCliente.Location = New System.Drawing.Point(134, 33)
        Me.TxtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(195, 20)
        Me.TxtCliente.TabIndex = 163
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnGerar)
        Me.GroupBox2.Controls.Add(Me.BtnCancelar)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(393, 52)
        Me.GroupBox2.TabIndex = 180
        Me.GroupBox2.TabStop = False
        '
        'BtnGerar
        '
        Me.BtnGerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGerar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnGerar.Location = New System.Drawing.Point(178, 14)
        Me.BtnGerar.Name = "BtnGerar"
        Me.BtnGerar.Size = New System.Drawing.Size(90, 30)
        Me.BtnGerar.TabIndex = 168
        Me.BtnGerar.TabStop = False
        Me.BtnGerar.Text = "Imprimir"
        Me.BtnGerar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnCancelar.Location = New System.Drawing.Point(282, 14)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.BtnCancelar.TabIndex = 167
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'DataInicio
        '
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(95, 69)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(97, 20)
        Me.DataInicio.TabIndex = 183
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 73)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 184
        Me.Label10.Text = "Data Inicial:"
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(264, 69)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(97, 20)
        Me.DataFim.TabIndex = 185
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 186
        Me.Label5.Text = "Data Final:"
        '
        'FrmPesqCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(419, 198)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPesqCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda por Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdVenda As TextBox
    Friend WithEvents BtnPesquisarNota As Button
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnGerar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents Label5 As Label
End Class
