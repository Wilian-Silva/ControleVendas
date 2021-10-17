<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRelVendaCliente
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRelVendaCliente))
        Me.venda_cliente_dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasPorCliente = New ControleVendas.controle_vendasPorCliente()
        Me.duplicatas_cliente_dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.venda_cliente_dataTableAdapter = New ControleVendas.controle_vendasPorClienteTableAdapters.venda_cliente_dataTableAdapter()
        Me.duplicatas_cliente_dataTableAdapter = New ControleVendas.controle_vendasPorClienteTableAdapters.duplicatas_cliente_dataTableAdapter()
        CType(Me.venda_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasPorCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duplicatas_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'venda_cliente_dataBindingSource
        '
        Me.venda_cliente_dataBindingSource.DataMember = "venda_cliente_data"
        Me.venda_cliente_dataBindingSource.DataSource = Me.controle_vendasPorCliente
        '
        'controle_vendasPorCliente
        '
        Me.controle_vendasPorCliente.DataSetName = "controle_vendasPorCliente"
        Me.controle_vendasPorCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'duplicatas_cliente_dataBindingSource
        '
        Me.duplicatas_cliente_dataBindingSource.DataMember = "duplicatas_cliente_data"
        Me.duplicatas_cliente_dataBindingSource.DataSource = Me.controle_vendasPorCliente
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetVendasCliente"
        ReportDataSource1.Value = Me.venda_cliente_dataBindingSource
        ReportDataSource2.Name = "DataSetDuplicatasCliente"
        ReportDataSource2.Value = Me.duplicatas_cliente_dataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportVendaCliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(871, 637)
        Me.ReportViewer1.TabIndex = 188
        '
        'venda_cliente_dataTableAdapter
        '
        Me.venda_cliente_dataTableAdapter.ClearBeforeFill = True
        '
        'duplicatas_cliente_dataTableAdapter
        '
        Me.duplicatas_cliente_dataTableAdapter.ClearBeforeFill = True
        '
        'FrmRelVendaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 637)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRelVendaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Vendas por Cliente"
        CType(Me.venda_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasPorCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duplicatas_cliente_dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents venda_cliente_dataBindingSource As BindingSource
    Friend WithEvents controle_vendasPorCliente As controle_vendasPorCliente
    Friend WithEvents duplicatas_cliente_dataBindingSource As BindingSource
    Friend WithEvents venda_cliente_dataTableAdapter As controle_vendasPorClienteTableAdapters.venda_cliente_dataTableAdapter
    Friend WithEvents duplicatas_cliente_dataTableAdapter As controle_vendasPorClienteTableAdapters.duplicatas_cliente_dataTableAdapter
End Class
