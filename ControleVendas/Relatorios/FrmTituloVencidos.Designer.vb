<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTituloVencidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTituloVencidos))
        Me.TitulosVencidosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportTitulosVencidos = New ControleVendas.ReportTitulosVencidos()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.titulosVencidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.titulosVencidosTableAdapter = New ControleVendas.ReportTitulosVencidosTableAdapters.titulosVencidosTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        CType(Me.TitulosVencidosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportTitulosVencidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.titulosVencidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitulosVencidosBindingSource1
        '
        Me.TitulosVencidosBindingSource1.DataMember = "titulosVencidos"
        Me.TitulosVencidosBindingSource1.DataSource = Me.ReportTitulosVencidos
        '
        'ReportTitulosVencidos
        '
        Me.ReportTitulosVencidos.DataSetName = "ReportTitulosVencidos"
        Me.ReportTitulosVencidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetTitulosVencidos"
        ReportDataSource1.Value = Me.TitulosVencidosBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportTitulosVencidos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 47)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(871, 754)
        Me.ReportViewer1.TabIndex = 0
        '
        'titulosVencidosBindingSource
        '
        Me.titulosVencidosBindingSource.DataMember = "titulosVencidos"
        Me.titulosVencidosBindingSource.DataSource = Me.ReportTitulosVencidos
        '
        'titulosVencidosTableAdapter
        '
        Me.titulosVencidosTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Data Base:"
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(89, 12)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(97, 20)
        Me.DataFim.TabIndex = 168
        '
        'FrmTituloVencidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 799)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataFim)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmTituloVencidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Títulos Vencidos"
        CType(Me.TitulosVencidosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportTitulosVencidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.titulosVencidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents titulosVencidosBindingSource As BindingSource
    Friend WithEvents ReportTitulosVencidos As ReportTitulosVencidos
    Friend WithEvents titulosVencidosTableAdapter As ReportTitulosVencidosTableAdapters.titulosVencidosTableAdapter
    Friend WithEvents TitulosVencidosBindingSource1 As BindingSource
    Friend WithEvents Label5 As Label
    Friend WithEvents DataFim As DateTimePicker
End Class
