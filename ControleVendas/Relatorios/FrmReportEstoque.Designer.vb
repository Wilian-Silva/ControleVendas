<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportEstoque
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportEstoque))
        Me.SaldoEstoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetEstoque = New ControleVendas.DataSetEstoque()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.estoqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.estoqueTableAdapter = New ControleVendas.DataSetEstoqueTableAdapters.estoqueTableAdapter()
        Me.SaldoEstoqueTableAdapter = New ControleVendas.DataSetEstoqueTableAdapters.SaldoEstoqueTableAdapter()
        CType(Me.SaldoEstoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.estoqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaldoEstoqueBindingSource
        '
        Me.SaldoEstoqueBindingSource.DataMember = "SaldoEstoque"
        Me.SaldoEstoqueBindingSource.DataSource = Me.DataSetEstoque
        '
        'DataSetEstoque
        '
        Me.DataSetEstoque.DataSetName = "DataSetEstoque"
        Me.DataSetEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataEstoque"
        ReportDataSource1.Value = Me.SaldoEstoqueBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportEstoque.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(673, 745)
        Me.ReportViewer1.TabIndex = 0
        '
        'estoqueBindingSource
        '
        Me.estoqueBindingSource.DataMember = "estoque"
        Me.estoqueBindingSource.DataSource = Me.DataSetEstoque
        '
        'estoqueTableAdapter
        '
        Me.estoqueTableAdapter.ClearBeforeFill = True
        '
        'SaldoEstoqueTableAdapter
        '
        Me.SaldoEstoqueTableAdapter.ClearBeforeFill = True
        '
        'FrmReportEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 745)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReportEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo Estoque"
        CType(Me.SaldoEstoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.estoqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents estoqueBindingSource As BindingSource
    Friend WithEvents DataSetEstoque As DataSetEstoque
    Friend WithEvents estoqueTableAdapter As DataSetEstoqueTableAdapters.estoqueTableAdapter
    Friend WithEvents SaldoEstoqueBindingSource As BindingSource
    Friend WithEvents SaldoEstoqueTableAdapter As DataSetEstoqueTableAdapters.SaldoEstoqueTableAdapter
End Class
