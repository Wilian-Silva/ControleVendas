<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMvtoEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMvtoEstoque))
        Me.estoque_dataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSetEstoque = New ControleVendas.controle_vendasDataSetEstoque()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.estoque_dataTableAdapter = New ControleVendas.controle_vendasDataSetEstoqueTableAdapters.estoque_dataTableAdapter()
        CType(Me.estoque_dataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSetEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'estoque_dataBindingSource
        '
        Me.estoque_dataBindingSource.DataMember = "estoque_data"
        Me.estoque_dataBindingSource.DataSource = Me.controle_vendasDataSetEstoque
        '
        'controle_vendasDataSetEstoque
        '
        Me.controle_vendasDataSetEstoque.DataSetName = "controle_vendasDataSetEstoque"
        Me.controle_vendasDataSetEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetMvtoEstoque"
        ReportDataSource1.Value = Me.estoque_dataBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportMvtoEstoque.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1053, 568)
        Me.ReportViewer1.TabIndex = 0
        '
        'estoque_dataTableAdapter
        '
        Me.estoque_dataTableAdapter.ClearBeforeFill = True
        '
        'FrmMvtoEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 568)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMvtoEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Movimento Estoque"
        CType(Me.estoque_dataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSetEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents estoque_dataBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSetEstoque As controle_vendasDataSetEstoque
    Friend WithEvents estoque_dataTableAdapter As controle_vendasDataSetEstoqueTableAdapters.estoque_dataTableAdapter
End Class
