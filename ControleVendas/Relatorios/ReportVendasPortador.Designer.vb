<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportVendasPortador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportVendasPortador))
        Me.duplicatas_receber_portadorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSet_Portador = New ControleVendas.controle_vendasDataSet_Portador()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.duplicatas_receber_portadorTableAdapter = New ControleVendas.controle_vendasDataSet_PortadorTableAdapters.duplicatas_receber_portadorTableAdapter()
        CType(Me.duplicatas_receber_portadorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSet_Portador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'duplicatas_receber_portadorBindingSource
        '
        Me.duplicatas_receber_portadorBindingSource.DataMember = "duplicatas_receber_portador"
        Me.duplicatas_receber_portadorBindingSource.DataSource = Me.controle_vendasDataSet_Portador
        '
        'controle_vendasDataSet_Portador
        '
        Me.controle_vendasDataSet_Portador.DataSetName = "controle_vendasDataSet_Portador"
        Me.controle_vendasDataSet_Portador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetArPortador"
        ReportDataSource1.Value = Me.duplicatas_receber_portadorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportArPortador.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(961, 504)
        Me.ReportViewer1.TabIndex = 187
        '
        'duplicatas_receber_portadorTableAdapter
        '
        Me.duplicatas_receber_portadorTableAdapter.ClearBeforeFill = True
        '
        'ReportVendasPortador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 504)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportVendasPortador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas por Portador"
        CType(Me.duplicatas_receber_portadorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSet_Portador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents duplicatas_receber_portadorBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet_Portador As controle_vendasDataSet_Portador
    Friend WithEvents duplicatas_receber_portadorTableAdapter As controle_vendasDataSet_PortadorTableAdapters.duplicatas_receber_portadorTableAdapter
End Class
