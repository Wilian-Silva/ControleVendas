<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecebimentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRecebimentos))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BtnCarregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataFim = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataInicio = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSetRecebimentos = New ControleVendas.DataSetRecebimentos()
        Me.mvto_recebimentos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mvto_recebimentos1TableAdapter = New ControleVendas.DataSetRecebimentosTableAdapters.mvto_recebimentos1TableAdapter()
        CType(Me.DataSetRecebimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mvto_recebimentos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCarregar
        '
        Me.BtnCarregar.AccessibleDescription = ""
        Me.BtnCarregar.AccessibleName = "Adicionar"
        Me.BtnCarregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCarregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCarregar.FlatAppearance.BorderSize = 0
        Me.BtnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCarregar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCarregar.ForeColor = System.Drawing.Color.Transparent
        Me.BtnCarregar.Image = CType(resources.GetObject("BtnCarregar.Image"), System.Drawing.Image)
        Me.BtnCarregar.Location = New System.Drawing.Point(368, 4)
        Me.BtnCarregar.Name = "BtnCarregar"
        Me.BtnCarregar.Size = New System.Drawing.Size(35, 35)
        Me.BtnCarregar.TabIndex = 173
        Me.BtnCarregar.TabStop = False
        Me.BtnCarregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(194, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 172
        Me.Label5.Text = "Data Final:"
        '
        'DataFim
        '
        Me.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataFim.Location = New System.Drawing.Point(256, 12)
        Me.DataFim.Name = "DataFim"
        Me.DataFim.Size = New System.Drawing.Size(97, 20)
        Me.DataFim.TabIndex = 171
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 170
        Me.Label10.Text = "Data Inicial:"
        '
        'DataInicio
        '
        Me.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataInicio.Location = New System.Drawing.Point(83, 12)
        Me.DataInicio.Name = "DataInicio"
        Me.DataInicio.Size = New System.Drawing.Size(97, 20)
        Me.DataInicio.TabIndex = 169
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSetRecebimentos"
        ReportDataSource1.Value = Me.mvto_recebimentos1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ControleVendas.ReportRecebimentos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-4, 45)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1151, 592)
        Me.ReportViewer1.TabIndex = 174
        '
        'DataSetRecebimentos
        '
        Me.DataSetRecebimentos.DataSetName = "DataSetRecebimentos"
        Me.DataSetRecebimentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mvto_recebimentos1BindingSource
        '
        Me.mvto_recebimentos1BindingSource.DataMember = "mvto_recebimentos1"
        Me.mvto_recebimentos1BindingSource.DataSource = Me.DataSetRecebimentos
        '
        'mvto_recebimentos1TableAdapter
        '
        Me.mvto_recebimentos1TableAdapter.ClearBeforeFill = True
        '
        'FrmRecebimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 633)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.BtnCarregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataFim)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmRecebimentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recebimentos "
        CType(Me.DataSetRecebimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mvto_recebimentos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCarregar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataFim As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents DataInicio As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mvto_recebimentos1BindingSource As BindingSource
    Friend WithEvents DataSetRecebimentos As DataSetRecebimentos
    Friend WithEvents mvto_recebimentos1TableAdapter As DataSetRecebimentosTableAdapters.mvto_recebimentos1TableAdapter
End Class
