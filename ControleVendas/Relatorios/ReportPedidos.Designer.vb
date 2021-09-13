<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportPedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportPedidos))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ConsultapedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSet6 = New ControleVendas.controle_vendasDataSet6()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.TxtIdPedido = New System.Windows.Forms.TextBox()
        Me.TxtPesquisar = New System.Windows.Forms.TextBox()
        Me.BtnPesqPedido = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.consulta_pedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.consulta_pedidosTableAdapter = New ControleVendas.controle_vendasDataSet6TableAdapters.consulta_pedidosTableAdapter()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ConsultapedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.consulta_pedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultapedidosBindingSource
        '
        Me.ConsultapedidosBindingSource.DataMember = "consulta_pedidos"
        Me.ConsultapedidosBindingSource.DataSource = Me.controle_vendasDataSet6
        '
        'controle_vendasDataSet6
        '
        Me.controle_vendasDataSet6.DataSetName = "controle_vendasDataSet6"
        Me.controle_vendasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnPesquisar)
        Me.GroupBox1.Controls.Add(Me.TxtIdPedido)
        Me.GroupBox1.Controls.Add(Me.TxtPesquisar)
        Me.GroupBox1.Controls.Add(Me.BtnPesqPedido)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 50)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisar Pedido"
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
        Me.BtnPesquisar.Location = New System.Drawing.Point(295, 15)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisar.TabIndex = 143
        Me.ToolTip1.SetToolTip(Me.BtnPesquisar, "Carregar Pedido")
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'TxtIdPedido
        '
        Me.TxtIdPedido.Enabled = False
        Me.TxtIdPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdPedido.Location = New System.Drawing.Point(119, 15)
        Me.TxtIdPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIdPedido.Multiline = True
        Me.TxtIdPedido.Name = "TxtIdPedido"
        Me.TxtIdPedido.Size = New System.Drawing.Size(29, 25)
        Me.TxtIdPedido.TabIndex = 140
        Me.TxtIdPedido.Text = "0"
        Me.TxtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPesquisar
        '
        Me.TxtPesquisar.Enabled = False
        Me.TxtPesquisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPesquisar.Location = New System.Drawing.Point(149, 15)
        Me.TxtPesquisar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPesquisar.Multiline = True
        Me.TxtPesquisar.Name = "TxtPesquisar"
        Me.TxtPesquisar.Size = New System.Drawing.Size(112, 25)
        Me.TxtPesquisar.TabIndex = 111
        Me.TxtPesquisar.Text = "Sem Pedido"
        '
        'BtnPesqPedido
        '
        Me.BtnPesqPedido.Image = CType(resources.GetObject("BtnPesqPedido.Image"), System.Drawing.Image)
        Me.BtnPesqPedido.Location = New System.Drawing.Point(268, 15)
        Me.BtnPesqPedido.Name = "BtnPesqPedido"
        Me.BtnPesqPedido.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesqPedido.TabIndex = 136
        Me.ToolTip1.SetToolTip(Me.BtnPesqPedido, "Pesquisar Pedido de Compra")
        Me.BtnPesqPedido.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(37, 18)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Nº/Pedido:"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetPedidos"
        ReportDataSource1.Value = Me.ConsultapedidosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportPedidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 68)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(750, 699)
        Me.ReportViewer1.TabIndex = 139
        '
        'consulta_pedidosBindingSource
        '
        Me.consulta_pedidosBindingSource.DataMember = "consulta_pedidos"
        Me.consulta_pedidosBindingSource.DataSource = Me.controle_vendasDataSet6
        '
        'consulta_pedidosTableAdapter
        '
        Me.consulta_pedidosTableAdapter.ClearBeforeFill = True
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
        Me.BtnSair.Location = New System.Drawing.Point(694, 20)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 140
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'ReportPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 766)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReportPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos de Compra"
        CType(Me.ConsultapedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.consulta_pedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtIdPedido As TextBox
    Friend WithEvents TxtPesquisar As TextBox
    Friend WithEvents BtnPesqPedido As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents consulta_pedidosBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet6 As controle_vendasDataSet6
    Friend WithEvents consulta_pedidosTableAdapter As controle_vendasDataSet6TableAdapters.consulta_pedidosTableAdapter
    Friend WithEvents ConsultapedidosBindingSource As BindingSource
    Friend WithEvents BtnSair As Button
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
