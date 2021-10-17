<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCupomVenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCupomVenda))
        Me.cumpoVendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetCupomVenda = New ControleVendas.DataSetCupomVenda()
        Me.CupomCompraV2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CumpoVendaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cumpoVendaTableAdapter = New ControleVendas.DataSetCupomVendaTableAdapters.cumpoVendaTableAdapter()
        Me.CupomCompraV2TableAdapter = New ControleVendas.DataSetCupomVendaTableAdapters.CupomCompraV2TableAdapter()
        CType(Me.cumpoVendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCupomVenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CupomCompraV2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CumpoVendaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cumpoVendaBindingSource
        '
        Me.cumpoVendaBindingSource.DataMember = "cumpoVenda"
        Me.cumpoVendaBindingSource.DataSource = Me.DataSetCupomVenda
        '
        'DataSetCupomVenda
        '
        Me.DataSetCupomVenda.DataSetName = "DataSetCupomVenda"
        Me.DataSetCupomVenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CupomCompraV2BindingSource
        '
        Me.CupomCompraV2BindingSource.DataMember = "CupomCompraV2"
        Me.CupomCompraV2BindingSource.DataSource = Me.DataSetCupomVenda
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetVenda"
        ReportDataSource1.Value = Me.cumpoVendaBindingSource
        ReportDataSource2.Name = "DataSetTeste"
        ReportDataSource2.Value = Me.CupomCompraV2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportCupomVenda.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(735, 656)
        Me.ReportViewer1.TabIndex = 174
        '
        'CumpoVendaBindingSource1
        '
        Me.CumpoVendaBindingSource1.DataMember = "cumpoVenda"
        Me.CumpoVendaBindingSource1.DataSource = Me.DataSetCupomVenda
        '
        'cumpoVendaTableAdapter
        '
        Me.cumpoVendaTableAdapter.ClearBeforeFill = True
        '
        'CupomCompraV2TableAdapter
        '
        Me.CupomCompraV2TableAdapter.ClearBeforeFill = True
        '
        'FrmCupomVenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 656)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCupomVenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emissão Cupom Venda"
        CType(Me.cumpoVendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCupomVenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CupomCompraV2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CumpoVendaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cumpoVendaBindingSource As BindingSource
    Friend WithEvents DataSetCupomVenda As DataSetCupomVenda
    Friend WithEvents cumpoVendaTableAdapter As DataSetCupomVendaTableAdapters.cumpoVendaTableAdapter
    Friend WithEvents CumpoVendaBindingSource1 As BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CupomCompraV2BindingSource As BindingSource
    Friend WithEvents CupomCompraV2TableAdapter As DataSetCupomVendaTableAdapters.CupomCompraV2TableAdapter
End Class
