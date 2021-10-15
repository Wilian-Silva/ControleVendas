<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelSaldoEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelSaldoEstoque))
        Me.ProdutosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_saldoestoque = New ControleVendas.DataSet_saldoestoque()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.produtosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.produtosTableAdapter = New ControleVendas.DataSet_saldoestoqueTableAdapters.produtosTableAdapter()
        CType(Me.ProdutosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_saldoestoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProdutosBindingSource1
        '
        Me.ProdutosBindingSource1.DataMember = "produtos"
        Me.ProdutosBindingSource1.DataSource = Me.DataSet_saldoestoque
        '
        'DataSet_saldoestoque
        '
        Me.DataSet_saldoestoque.DataSetName = "DataSet_saldoestoque"
        Me.DataSet_saldoestoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetSaldoEstoque"
        ReportDataSource1.Value = Me.ProdutosBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportSaldoEstoque.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(703, 564)
        Me.ReportViewer1.TabIndex = 0
        '
        'produtosBindingSource
        '
        Me.produtosBindingSource.DataMember = "produtos"
        Me.produtosBindingSource.DataSource = Me.DataSet_saldoestoque
        '
        'produtosTableAdapter
        '
        Me.produtosTableAdapter.ClearBeforeFill = True
        '
        'FrmRelSaldoEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 564)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRelSaldoEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo Estoque"
        CType(Me.ProdutosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_saldoestoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.produtosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents produtosBindingSource As BindingSource
    Friend WithEvents DataSet_saldoestoque As DataSet_saldoestoque
    Friend WithEvents produtosTableAdapter As DataSet_saldoestoqueTableAdapters.produtosTableAdapter
    Friend WithEvents ProdutosBindingSource1 As BindingSource
End Class
