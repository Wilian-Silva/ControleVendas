<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmContasPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContasPagar))
        Me.DuplicatasReceberBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSet2 = New ControleVendas.controle_vendasDataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.duplicatasReceberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.duplicatasReceberTableAdapter = New ControleVendas.controle_vendasDataSet2TableAdapters.duplicatasReceberTableAdapter()
        CType(Me.DuplicatasReceberBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duplicatasReceberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DuplicatasReceberBindingSource1
        '
        Me.DuplicatasReceberBindingSource1.DataMember = "duplicatasReceber"
        Me.DuplicatasReceberBindingSource1.DataSource = Me.controle_vendasDataSet2
        '
        'controle_vendasDataSet2
        '
        Me.controle_vendasDataSet2.DataSetName = "controle_vendasDataSet2"
        Me.controle_vendasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetContasPagar"
        ReportDataSource1.Value = Me.DuplicatasReceberBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportContasPagar.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(929, 522)
        Me.ReportViewer1.TabIndex = 0
        '
        'duplicatasReceberBindingSource
        '
        Me.duplicatasReceberBindingSource.DataMember = "duplicatasReceber"
        Me.duplicatasReceberBindingSource.DataSource = Me.controle_vendasDataSet2
        '
        'duplicatasReceberTableAdapter
        '
        Me.duplicatasReceberTableAdapter.ClearBeforeFill = True
        '
        'FrmContasPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 522)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmContasPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas a Pagar"
        CType(Me.DuplicatasReceberBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duplicatasReceberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents duplicatasReceberBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet2 As controle_vendasDataSet2
    Friend WithEvents duplicatasReceberTableAdapter As controle_vendasDataSet2TableAdapters.duplicatasReceberTableAdapter
    Friend WithEvents DuplicatasReceberBindingSource1 As BindingSource
End Class
