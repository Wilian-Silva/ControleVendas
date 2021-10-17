<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPesqCupom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPesqCupom))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdVenda = New System.Windows.Forms.TextBox()
        Me.BtnPesquisarNota = New System.Windows.Forms.Button()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGerar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtIdVenda)
        Me.GroupBox1.Controls.Add(Me.BtnPesquisarNota)
        Me.GroupBox1.Controls.Add(Me.TxtCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 82)
        Me.GroupBox1.TabIndex = 179
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar Venda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "Nº Venda:"
        '
        'TxtIdVenda
        '
        Me.TxtIdVenda.BackColor = System.Drawing.Color.White
        Me.TxtIdVenda.Enabled = False
        Me.TxtIdVenda.Location = New System.Drawing.Point(78, 33)
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
        Me.BtnPesquisarNota.Location = New System.Drawing.Point(302, 30)
        Me.BtnPesquisarNota.Name = "BtnPesquisarNota"
        Me.BtnPesquisarNota.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisarNota.TabIndex = 162
        Me.BtnPesquisarNota.UseVisualStyleBackColor = True
        '
        'TxtCliente
        '
        Me.TxtCliente.BackColor = System.Drawing.Color.White
        Me.TxtCliente.Enabled = False
        Me.TxtCliente.Location = New System.Drawing.Point(117, 33)
        Me.TxtCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(176, 20)
        Me.TxtCliente.TabIndex = 163
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnGerar)
        Me.GroupBox2.Controls.Add(Me.BtnCancelar)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(20, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 52)
        Me.GroupBox2.TabIndex = 178
        Me.GroupBox2.TabStop = False
        '
        'BtnGerar
        '
        Me.BtnGerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGerar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnGerar.Location = New System.Drawing.Point(129, 12)
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
        Me.BtnCancelar.Location = New System.Drawing.Point(233, 12)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 30)
        Me.BtnCancelar.TabIndex = 167
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmPesqCupom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(395, 179)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPesqCupom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Recibo Venda"
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
End Class
