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
        Me.EntradasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.controle_vendasDataSet5 = New ControleVendas.controle_vendasDataSet5()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.entradasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.entradasTableAdapter = New ControleVendas.controle_vendasDataSet5TableAdapters.entradasTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.BtnSair = New System.Windows.Forms.Button()
        CType(Me.EntradasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controle_vendasDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.entradasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EntradasBindingSource1
        '
        Me.EntradasBindingSource1.DataMember = "entradas"
        Me.EntradasBindingSource1.DataSource = Me.controle_vendasDataSet5
        '
        'controle_vendasDataSet5
        '
        Me.controle_vendasDataSet5.DataSetName = "controle_vendasDataSet5"
        Me.controle_vendasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetCompras"
        ReportDataSource1.Value = Me.EntradasBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportCompras.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 47)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(809, 718)
        Me.ReportViewer1.TabIndex = 0
        '
        'entradasBindingSource
        '
        Me.entradasBindingSource.DataMember = "entradas"
        Me.entradasBindingSource.DataSource = Me.controle_vendasDataSet5
        '
        'entradasTableAdapter
        '
        Me.entradasTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Data Final:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Data Incial:"
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(283, 12)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(105, 20)
        Me.DataFim.TabIndex = 10
        '
        'DataInicio
        '
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(78, 12)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(105, 20)
        Me.DataInicio.TabIndex = 9
        '
        'BtnSair
        '
        Me.BtnSair.AccessibleDescription = ""
        Me.BtnSair.AccessibleName = "Adicionar"
        Me.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.BtnSair.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSair.Image = CType(resources.GetObject("BtnSair.Image"), System.Drawing.Image)
        Me.BtnSair.Location = New System.Drawing.Point(743, 5)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(35, 35)
        Me.BtnSair.TabIndex = 60
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'FrmReportCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 765)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataFim)
        Me.Controls.Add(Me.DataInicio)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmReportCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Compras"
        CType(Me.EntradasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controle_vendasDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.entradasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents entradasBindingSource As BindingSource
    Friend WithEvents controle_vendasDataSet5 As controle_vendasDataSet5
    Friend WithEvents entradasTableAdapter As controle_vendasDataSet5TableAdapters.entradasTableAdapter
    Friend WithEvents EntradasBindingSource1 As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents BtnSair As Button
End Class
