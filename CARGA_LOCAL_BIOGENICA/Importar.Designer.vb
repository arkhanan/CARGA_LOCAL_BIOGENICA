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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DEFecha = New DevExpress.XtraEditors.DateEdit()
        Me.TEProcesando = New DevExpress.XtraEditors.TextEdit()
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
        Me.CATPACIENTESBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAT_PACIENTES_B = New CARGA_LOCAL_BIOGENICA.CAT_PACIENTES_B()
        Me.PCAT_ESTADOS_BTableAdapter = New CARGA_LOCAL_BIOGENICA.Cat_EstadosTableAdapters.pCAT_ESTADOS_BTableAdapter()
        Me.PCAT_MUNICIPIOS_BTableAdapter = New CARGA_LOCAL_BIOGENICA.Cat_MunicipiosTableAdapters.pCAT_MUNICIPIOS_BTableAdapter()
        Me.CAT_PACIENTES_BTableAdapter = New CARGA_LOCAL_BIOGENICA.CAT_PACIENTES_BTableAdapters.CAT_PACIENTES_BTableAdapter()
        Me.DxErrorProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coledad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMUNICIPIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCARGA_MUESTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colasistencia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DEFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DEFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEProcesando.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TECarga.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUEMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCATMUNICIPIOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat_Municipios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LUEEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATPACIENTESBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAT_PACIENTES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DEFecha)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TEProcesando)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1354, 689)
        Me.SplitContainer1.SplitterDistance = 124
        Me.SplitContainer1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Fecha"
        '
        'DEFecha
        '
        Me.DEFecha.EditValue = Nothing
        Me.DEFecha.Location = New System.Drawing.Point(428, 62)
        Me.DEFecha.Name = "DEFecha"
        Me.DEFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DEFecha.Size = New System.Drawing.Size(255, 20)
        Me.DEFecha.TabIndex = 11
        '
        'TEProcesando
        '
        Me.TEProcesando.Location = New System.Drawing.Point(733, 30)
        Me.TEProcesando.Name = "TEProcesando"
        Me.TEProcesando.Properties.Appearance.BackColor = System.Drawing.Color.Gray
        Me.TEProcesando.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEProcesando.Properties.Appearance.Options.UseBackColor = True
        Me.TEProcesando.Properties.Appearance.Options.UseFont = True
        Me.TEProcesando.Size = New System.Drawing.Size(258, 48)
        Me.TEProcesando.TabIndex = 10
        '
        'TECarga
        '
        Me.TECarga.Location = New System.Drawing.Point(6, 30)
        Me.TECarga.Name = "TECarga"
        Me.TECarga.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TECarga.Properties.Appearance.Options.UseFont = True
        Me.TECarga.Size = New System.Drawing.Size(324, 48)
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
        Me.Label1.Location = New System.Drawing.Point(372, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Estados"
        '
        'LUEMunicipio
        '
        Me.LUEMunicipio.Location = New System.Drawing.Point(428, 36)
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
        Me.Label2.Location = New System.Drawing.Point(372, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Municipio"
        '
        'LUEEstado
        '
        Me.LUEEstado.Location = New System.Drawing.Point(428, 10)
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
        'CATPACIENTESBBindingSource
        '
        Me.CATPACIENTESBBindingSource.DataMember = "CAT_PACIENTES_B"
        Me.CATPACIENTESBBindingSource.DataSource = Me.CAT_PACIENTES_B
        '
        'CAT_PACIENTES_B
        '
        Me.CAT_PACIENTES_B.DataSetName = "CAT_PACIENTES_B"
        Me.CAT_PACIENTES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCAT_ESTADOS_BTableAdapter
        '
        Me.PCAT_ESTADOS_BTableAdapter.ClearBeforeFill = True
        '
        'PCAT_MUNICIPIOS_BTableAdapter
        '
        Me.PCAT_MUNICIPIOS_BTableAdapter.ClearBeforeFill = True
        '
        'CAT_PACIENTES_BTableAdapter
        '
        Me.CAT_PACIENTES_BTableAdapter.ClearBeforeFill = True
        '
        'DxErrorProvider1
        '
        Me.DxErrorProvider1.ContainerControl = Me
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CATPACIENTESBBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1354, 561)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnombre, Me.GridColumn1, Me.GridColumn2, Me.coledad, Me.colESTADO, Me.colMUNICIPIO, Me.colsexo, Me.colCARGA_MUESTRA, Me.colasistencia, Me.colFECHA})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colnombre
        '
        Me.colnombre.Caption = "NOMBRE"
        Me.colnombre.FieldName = "nombre"
        Me.colnombre.Name = "colnombre"
        Me.colnombre.Visible = True
        Me.colnombre.VisibleIndex = 2
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "A.P"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 3
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "A.M"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 4
        '
        'coledad
        '
        Me.coledad.Caption = "EDAD"
        Me.coledad.FieldName = "edad"
        Me.coledad.Name = "coledad"
        Me.coledad.Visible = True
        Me.coledad.VisibleIndex = 5
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 6
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 7
        '
        'colsexo
        '
        Me.colsexo.Caption = "SEXO"
        Me.colsexo.FieldName = "sexo"
        Me.colsexo.Name = "colsexo"
        Me.colsexo.Visible = True
        Me.colsexo.VisibleIndex = 8
        '
        'colCARGA_MUESTRA
        '
        Me.colCARGA_MUESTRA.FieldName = "CARGA_MUESTRA"
        Me.colCARGA_MUESTRA.Name = "colCARGA_MUESTRA"
        Me.colCARGA_MUESTRA.Visible = True
        Me.colCARGA_MUESTRA.VisibleIndex = 0
        '
        'colasistencia
        '
        Me.colasistencia.Caption = "ASISTENCIA"
        Me.colasistencia.FieldName = "asistencia"
        Me.colasistencia.Name = "colasistencia"
        '
        'colFECHA
        '
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 9
        '
        'Importar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Importar"
        Me.Size = New System.Drawing.Size(1354, 689)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DEFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DEFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEProcesando.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TECarga.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUEMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCATMUNICIPIOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat_Municipios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LUEEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATPACIENTESBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAT_PACIENTES_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DxErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents CATPACIENTESBBindingSource As BindingSource
    Friend WithEvents CAT_PACIENTES_B As CAT_PACIENTES_B
    Friend WithEvents CAT_PACIENTES_BTableAdapter As CAT_PACIENTES_BTableAdapters.CAT_PACIENTES_BTableAdapter
    Friend WithEvents TEProcesando As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DxErrorProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents DEFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coledad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMUNICIPIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCARGA_MUESTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colasistencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
End Class
