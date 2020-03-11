<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Importar
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TECarga = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LUEMunicipio = New DevExpress.XtraEditors.LookUpEdit()
        Me.PCATMUNICIPIOSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cat_Municipios = New CARGA_LOCAL_BIOGENICA.Cat_Municipios()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LUEEstado = New DevExpress.XtraEditors.LookUpEdit()
        Me.PCATESTADOSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cat_Estados = New CARGA_LOCAL_BIOGENICA.Cat_Estados()
        Me.PCAT_ESTADOS_BTableAdapter = New CARGA_LOCAL_BIOGENICA.Cat_EstadosTableAdapters.pCAT_ESTADOS_BTableAdapter()
        Me.PCAT_MUNICIPIOS_BTableAdapter = New CARGA_LOCAL_BIOGENICA.Cat_MunicipiosTableAdapters.pCAT_MUNICIPIOS_BTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TECarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUEMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCATMUNICIPIOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat_Municipios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUEEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(993, 561)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TECarga)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LUEMunicipio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LUEEstado)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GridControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(993, 689)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.TabIndex = 8
        '
        'TECarga
        '
        Me.TECarga.Location = New System.Drawing.Point(6, 30)
        Me.TECarga.Name = "TECarga"
        Me.TECarga.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TECarga.Properties.Appearance.Options.UseFont = True
        Me.TECarga.Size = New System.Drawing.Size(404, 48)
        Me.TECarga.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Clave de la carga"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(465, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Estados"
        '
        'LUEMunicipio
        '
        Me.LUEMunicipio.Location = New System.Drawing.Point(521, 62)
        Me.LUEMunicipio.Name = "LUEMunicipio"
        Me.LUEMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUEMunicipio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Municipio")})
        Me.LUEMunicipio.Properties.DataSource = Me.PCATMUNICIPIOSBBindingSource
        Me.LUEMunicipio.Properties.DisplayMember = "DESCRIPCION"
        Me.LUEMunicipio.Properties.ValueMember = "CVE_MUNICIPIO"
        Me.LUEMunicipio.Size = New System.Drawing.Size(255, 20)
        Me.LUEMunicipio.TabIndex = 4
        '
        'PCATMUNICIPIOSBBindingSource
        '
        Me.PCATMUNICIPIOSBBindingSource.DataMember = "pCAT_MUNICIPIOS_B"
        Me.PCATMUNICIPIOSBBindingSource.DataSource = Me.Cat_Municipios
        '
        'Cat_Municipios
        '
        Me.Cat_Municipios.DataSetName = "Cat_Municipios"
        Me.Cat_Municipios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Municipio"
        '
        'LUEEstado
        '
        Me.LUEEstado.Location = New System.Drawing.Point(521, 30)
        Me.LUEEstado.Name = "LUEEstado"
        Me.LUEEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUEEstado.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", "Descripcion")})
        Me.LUEEstado.Properties.DataSource = Me.PCATESTADOSBBindingSource
        Me.LUEEstado.Properties.DisplayMember = "DESCRIPCION"
        Me.LUEEstado.Properties.ValueMember = "CVE_ESTADO"
        Me.LUEEstado.Size = New System.Drawing.Size(255, 20)
        Me.LUEEstado.TabIndex = 3
        '
        'PCATESTADOSBBindingSource
        '
        Me.PCATESTADOSBBindingSource.DataMember = "pCAT_ESTADOS_B"
        Me.PCATESTADOSBBindingSource.DataSource = Me.Cat_Estados
        '
        'Cat_Estados
        '
        Me.Cat_Estados.DataSetName = "Cat_Estados"
        Me.Cat_Estados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCAT_ESTADOS_BTableAdapter
        '
        Me.PCAT_ESTADOS_BTableAdapter.ClearBeforeFill = True
        '
        'PCAT_MUNICIPIOS_BTableAdapter
        '
        Me.PCAT_MUNICIPIOS_BTableAdapter.ClearBeforeFill = True
        '
        'Importar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Importar"
        Me.Size = New System.Drawing.Size(993, 689)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TECarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUEMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCATMUNICIPIOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat_Municipios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUEEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TECarga As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LUEMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents LUEEstado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PCATESTADOSBBindingSource As BindingSource
    Friend WithEvents Cat_Estados As Cat_Estados
    Friend WithEvents PCAT_ESTADOS_BTableAdapter As Cat_EstadosTableAdapters.pCAT_ESTADOS_BTableAdapter
    Friend WithEvents PCATMUNICIPIOSBBindingSource As BindingSource
    Friend WithEvents Cat_Municipios As Cat_Municipios
    Friend WithEvents PCAT_MUNICIPIOS_BTableAdapter As Cat_MunicipiosTableAdapters.pCAT_MUNICIPIOS_BTableAdapter
End Class
