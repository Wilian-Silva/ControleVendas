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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetCompra"
        ReportDataSource1.Value = Me.DataTableEntradaBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportCompras.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(918, 799)
        Me.ReportViewer1.TabIndex = 0
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
        Me.ClientSize = New System.Drawing.Size(918, 799)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReportCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedido de Compra"
        CType(Me.DataTableEntradaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_ReportCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableEntradaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTableEntradaBindingSource As BindingSource
    Friend WithEvents DataSet_ReportCompras As DataSet_ReportCompras
    Friend WithEvents DataTableEntradaTableAdapter As DataSet_ReportComprasTableAdapters.DataTableEntradaTableAdapter
    Friend WithEvents DataTableEntradaBindingSource1 As BindingSource
    Friend WithEvents ToolTip1 As ToolTip
End Class
