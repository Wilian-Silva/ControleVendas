<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportCompras
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportCompras))
        Me.DataTableEntradaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_ReportCompras = New ControleVendas.DataSet_ReportCompras()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnPesquisarNota = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.TxtPedido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataTableEntradaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableEntradaTableAdapter = New ControleVendas.DataSet_ReportComprasTableAdapters.DataTableEntradaTableAdapter()
        CType(Me.DataTableEntradaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_ReportCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableEntradaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTableEntradaBindingSource1
        '
        Me.DataTableEntradaBindingSource1.DataMember = "DataTableEntrada"
        Me.DataTableEntradaBindingSource1.DataSource = Me.DataSet_ReportCompras
        '
        'DataSet_ReportCompras
        '
        Me.DataSet_ReportCompras.DataSetName = "DataSet_ReportCompras"
        Me.DataSet_ReportCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetCompra"
        ReportDataSource1.Value = Me.DataTableEntradaBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportCompras.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 42)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(846, 759)
        Me.ReportViewer1.TabIndex = 0
        '
        'BtnPesquisarNota
        '
        Me.BtnPesquisarNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPesquisarNota.FlatAppearance.BorderSize = 0
        Me.BtnPesquisarNota.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnPesquisarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisarNota.ForeColor = System.Drawing.Color.Transparent
        Me.BtnPesquisarNota.Image = CType(resources.GetObject("BtnPesquisarNota.Image"), System.Drawing.Image)
        Me.BtnPesquisarNota.Location = New System.Drawing.Point(260, 4)
        Me.BtnPesquisarNota.Name = "BtnPesquisarNota"
        Me.BtnPesquisarNota.Size = New System.Drawing.Size(25, 25)
        Me.BtnPesquisarNota.TabIndex = 159
        Me.ToolTip1.SetToolTip(Me.BtnPesquisarNota, "Pesquisar Pedido")
        Me.BtnPesquisarNota.UseVisualStyleBackColor = True
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
        Me.BtnCarregar.Location = New System.Drawing.Point(303, -1)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 169
        Me.BtnCarregar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnCarregar, "Carregar Relatório")
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'TxtPedido
        '
        Me.TxtPedido.BackColor = System.Drawing.Color.White
        Me.TxtPedido.Location = New System.Drawing.Point(132, 7)
        Me.TxtPedido.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPedido.Name = "TxtPedido"
        Me.TxtPedido.Size = New System.Drawing.Size(116, 20)
        Me.TxtPedido.TabIndex = 160
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 16)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Pesq. Compra:"
        '
        'DataTableEntradaBindingSource
        '
        Me.DataTableEntradaBindingSource.DataMember = "DataTableEntrada"
        Me.DataTableEntradaBindingSource.DataSource = Me.DataSet_ReportCompras
        '
        'DataTableEntradaTableAdapter
        '
        Me.DataTableEntradaTableAdapter.ClearBeforeFill = True
        '
        'FrmReportCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 799)
        Me.Controls.Add(Me.BtnCarregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPedido)
        Me.Controls.Add(Me.BtnPesquisarNota)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReportCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Compras"
        CType(Me.DataTableEntradaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_ReportCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableEntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTableEntradaBindingSource As BindingSource
    Friend WithEvents DataSet_ReportCompras As DataSet_ReportCompras
    Friend WithEvents DataTableEntradaTableAdapter As DataSet_ReportComprasTableAdapters.DataTableEntradaTableAdapter
    Friend WithEvents DataTableEntradaBindingSource1 As BindingSource
    Friend WithEvents BtnPesquisarNota As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TxtPedido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCarregar As Button
End Class
