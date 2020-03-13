<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cPACIENTE_FECHA_NAC = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAno = New System.Windows.Forms.TextBox()
        Me.TxtMes = New System.Windows.Forms.TextBox()
        Me.TxtDia = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioB_F = New System.Windows.Forms.RadioButton()
        Me.RadioB_M = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cMaterno = New System.Windows.Forms.TextBox()
        Me.cPaterno = New System.Windows.Forms.TextBox()
        Me.cNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PCATESTADOSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatEstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cat_Estados = New CARGA_LOCAL_BIOGENICA.Cat_Estados()
        Me.PCAT_ESTADOS_BTableAdapter = New CARGA_LOCAL_BIOGENICA.Cat_EstadosTableAdapters.pCAT_ESTADOS_BTableAdapter()
        Me.cbbEstado = New DevExpress.XtraEditors.LookUpEdit()
        Me.cbbMunicipio = New DevExpress.XtraEditors.LookUpEdit()
        Me.PCATMUNICIPIOSBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatMunicipiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cat_Municipios = New CARGA_LOCAL_BIOGENICA.Cat_Municipios()
        Me.PCAT_MUNICIPIOS_BTableAdapter = New CARGA_LOCAL_BIOGENICA.Cat_MunicipiosTableAdapters.pCAT_MUNICIPIOS_BTableAdapter()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CATPACIENTESBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CATPACIENTESBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CAT_PACIENTES_B = New CARGA_LOCAL_BIOGENICA.CAT_PACIENTES_B()
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
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.CAT_PACIENTES_BTableAdapter = New CARGA_LOCAL_BIOGENICA.CAT_PACIENTES_BTableAdapters.CAT_PACIENTES_BTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatEstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbbMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCATMUNICIPIOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat_Municipios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATPACIENTESBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CATPACIENTESBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CAT_PACIENTES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cPACIENTE_FECHA_NAC)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtAno)
        Me.GroupBox2.Controls.Add(Me.TxtMes)
        Me.GroupBox2.Controls.Add(Me.TxtDia)
        Me.GroupBox2.Location = New System.Drawing.Point(415, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 121)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edad Paciente * :"
        '
        'cPACIENTE_FECHA_NAC
        '
        Me.cPACIENTE_FECHA_NAC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cPACIENTE_FECHA_NAC.Location = New System.Drawing.Point(90, 20)
        Me.cPACIENTE_FECHA_NAC.Name = "cPACIENTE_FECHA_NAC"
        Me.cPACIENTE_FECHA_NAC.Size = New System.Drawing.Size(121, 21)
        Me.cPACIENTE_FECHA_NAC.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(164, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dias"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Meses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Años"
        '
        'TxtAno
        '
        Me.TxtAno.Location = New System.Drawing.Point(11, 79)
        Me.TxtAno.Name = "TxtAno"
        Me.TxtAno.Size = New System.Drawing.Size(49, 21)
        Me.TxtAno.TabIndex = 9
        '
        'TxtMes
        '
        Me.TxtMes.Location = New System.Drawing.Point(90, 79)
        Me.TxtMes.Name = "TxtMes"
        Me.TxtMes.Size = New System.Drawing.Size(49, 21)
        Me.TxtMes.TabIndex = 10
        '
        'TxtDia
        '
        Me.TxtDia.Location = New System.Drawing.Point(167, 79)
        Me.TxtDia.Name = "TxtDia"
        Me.TxtDia.Size = New System.Drawing.Size(49, 21)
        Me.TxtDia.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioB_F)
        Me.GroupBox1.Controls.Add(Me.RadioB_M)
        Me.GroupBox1.Location = New System.Drawing.Point(415, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 54)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEXO"
        '
        'RadioB_F
        '
        Me.RadioB_F.AutoSize = True
        Me.RadioB_F.Location = New System.Drawing.Point(117, 27)
        Me.RadioB_F.Name = "RadioB_F"
        Me.RadioB_F.Size = New System.Drawing.Size(71, 17)
        Me.RadioB_F.TabIndex = 1
        Me.RadioB_F.TabStop = True
        Me.RadioB_F.Text = "Femenino"
        Me.RadioB_F.UseVisualStyleBackColor = True
        '
        'RadioB_M
        '
        Me.RadioB_M.AutoSize = True
        Me.RadioB_M.Location = New System.Drawing.Point(17, 27)
        Me.RadioB_M.Name = "RadioB_M"
        Me.RadioB_M.Size = New System.Drawing.Size(71, 17)
        Me.RadioB_M.TabIndex = 0
        Me.RadioB_M.TabStop = True
        Me.RadioB_M.Text = "Masculino"
        Me.RadioB_M.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(437, 78)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 15
        '
        'cMaterno
        '
        Me.cMaterno.Location = New System.Drawing.Point(92, 161)
        Me.cMaterno.Name = "cMaterno"
        Me.cMaterno.Size = New System.Drawing.Size(290, 21)
        Me.cMaterno.TabIndex = 14
        '
        'cPaterno
        '
        Me.cPaterno.Location = New System.Drawing.Point(92, 119)
        Me.cPaterno.Name = "cPaterno"
        Me.cPaterno.Size = New System.Drawing.Size(290, 21)
        Me.cPaterno.TabIndex = 13
        '
        'cNombre
        '
        Me.cNombre.Location = New System.Drawing.Point(92, 81)
        Me.cNombre.Name = "cNombre"
        Me.cNombre.Size = New System.Drawing.Size(290, 21)
        Me.cNombre.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "A. Manerto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "A. Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Estado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Municipio"
        '
        'PCATESTADOSBBindingSource
        '
        Me.PCATESTADOSBBindingSource.DataMember = "pCAT_ESTADOS_B"
        Me.PCATESTADOSBBindingSource.DataSource = Me.CatEstadosBindingSource
        '
        'CatEstadosBindingSource
        '
        Me.CatEstadosBindingSource.DataSource = Me.Cat_Estados
        Me.CatEstadosBindingSource.Position = 0
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
        'cbbEstado
        '
        Me.cbbEstado.Location = New System.Drawing.Point(92, 259)
        Me.cbbEstado.Name = "cbbEstado"
        Me.cbbEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbEstado.Properties.DataSource = Me.PCATESTADOSBBindingSource
        Me.cbbEstado.Properties.DisplayMember = "DESCRIPCION"
        Me.cbbEstado.Properties.ValueMember = "CVE_ESTADO"
        Me.cbbEstado.Size = New System.Drawing.Size(290, 20)
        Me.cbbEstado.TabIndex = 22
        '
        'cbbMunicipio
        '
        Me.cbbMunicipio.Location = New System.Drawing.Point(92, 297)
        Me.cbbMunicipio.Name = "cbbMunicipio"
        Me.cbbMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbMunicipio.Properties.DataSource = Me.PCATMUNICIPIOSBBindingSource
        Me.cbbMunicipio.Properties.DisplayMember = "DESCRIPCION"
        Me.cbbMunicipio.Properties.ValueMember = "CVE_MUNICIPIO"
        Me.cbbMunicipio.Size = New System.Drawing.Size(290, 20)
        Me.cbbMunicipio.TabIndex = 23
        '
        'PCATMUNICIPIOSBBindingSource
        '
        Me.PCATMUNICIPIOSBBindingSource.DataMember = "pCAT_MUNICIPIOS_B"
        Me.PCATMUNICIPIOSBBindingSource.DataSource = Me.CatMunicipiosBindingSource
        '
        'CatMunicipiosBindingSource
        '
        Me.CatMunicipiosBindingSource.DataSource = Me.Cat_Municipios
        Me.CatMunicipiosBindingSource.Position = 0
        '
        'Cat_Municipios
        '
        Me.Cat_Municipios.DataSetName = "Cat_Municipios"
        Me.Cat_Municipios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCAT_MUNICIPIOS_BTableAdapter
        '
        Me.PCAT_MUNICIPIOS_BTableAdapter.ClearBeforeFill = True
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.CATPACIENTESBBindingSource1
        Me.GridControl1.Location = New System.Drawing.Point(3, 356)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(684, 262)
        Me.GridControl1.TabIndex = 24
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CATPACIENTESBBindingSource1
        '
        Me.CATPACIENTESBBindingSource1.DataMember = "CAT_PACIENTES_B"
        Me.CATPACIENTESBBindingSource1.DataSource = Me.CATPACIENTESBBindingSource
        '
        'CATPACIENTESBBindingSource
        '
        Me.CATPACIENTESBBindingSource.DataSource = Me.CAT_PACIENTES_B
        Me.CATPACIENTESBBindingSource.Position = 0
        '
        'CAT_PACIENTES_B
        '
        Me.CAT_PACIENTES_B.DataSetName = "CAT_PACIENTES_B"
        Me.CAT_PACIENTES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnombre, Me.GridColumn1, Me.GridColumn2, Me.coledad, Me.colESTADO, Me.colMUNICIPIO, Me.colsexo, Me.colCARGA_MUESTRA, Me.colasistencia, Me.colFECHA, Me.GridColumn3})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colnombre
        '
        Me.colnombre.FieldName = "nombre"
        Me.colnombre.Name = "colnombre"
        Me.colnombre.Visible = True
        Me.colnombre.VisibleIndex = 1
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "A.P"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "CARGA_MUESTRA"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        '
        'coledad
        '
        Me.coledad.FieldName = "edad"
        Me.coledad.Name = "coledad"
        Me.coledad.Visible = True
        Me.coledad.VisibleIndex = 4
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.Visible = True
        Me.colESTADO.VisibleIndex = 5
        '
        'colMUNICIPIO
        '
        Me.colMUNICIPIO.FieldName = "MUNICIPIO"
        Me.colMUNICIPIO.Name = "colMUNICIPIO"
        Me.colMUNICIPIO.Visible = True
        Me.colMUNICIPIO.VisibleIndex = 6
        '
        'colsexo
        '
        Me.colsexo.FieldName = "sexo"
        Me.colsexo.Name = "colsexo"
        Me.colsexo.Visible = True
        Me.colsexo.VisibleIndex = 7
        '
        'colCARGA_MUESTRA
        '
        Me.colCARGA_MUESTRA.FieldName = "CARGA_MUESTRA"
        Me.colCARGA_MUESTRA.Name = "colCARGA_MUESTRA"
        Me.colCARGA_MUESTRA.Visible = True
        Me.colCARGA_MUESTRA.VisibleIndex = 8
        '
        'colasistencia
        '
        Me.colasistencia.FieldName = "asistencia"
        Me.colasistencia.Name = "colasistencia"
        Me.colasistencia.Visible = True
        Me.colasistencia.VisibleIndex = 9
        '
        'colFECHA
        '
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 10
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "EDITAR"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'CAT_PACIENTES_BTableAdapter
        '
        Me.CAT_PACIENTES_BTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 21)
        Me.TextBox1.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "ID"
        '
        'Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cbbMunicipio)
        Me.Controls.Add(Me.cbbEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cMaterno)
        Me.Controls.Add(Me.cPaterno)
        Me.Controls.Add(Me.cNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Consultar"
        Me.Size = New System.Drawing.Size(701, 645)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatEstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbbMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCATMUNICIPIOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatMunicipiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat_Municipios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATPACIENTESBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CATPACIENTESBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CAT_PACIENTES_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAno As TextBox
    Friend WithEvents TxtMes As TextBox
    Friend WithEvents TxtDia As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioB_F As RadioButton
    Friend WithEvents RadioB_M As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cMaterno As TextBox
    Friend WithEvents cPaterno As TextBox
    Friend WithEvents cNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cPACIENTE_FECHA_NAC As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PCATESTADOSBBindingSource As BindingSource
    Friend WithEvents CatEstadosBindingSource As BindingSource
    Friend WithEvents Cat_Estados As Cat_Estados
    Friend WithEvents PCAT_ESTADOS_BTableAdapter As Cat_EstadosTableAdapters.pCAT_ESTADOS_BTableAdapter
    Friend WithEvents cbbEstado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cbbMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PCATMUNICIPIOSBBindingSource As BindingSource
    Friend WithEvents CatMunicipiosBindingSource As BindingSource
    Friend WithEvents Cat_Municipios As Cat_Municipios
    Friend WithEvents PCAT_MUNICIPIOS_BTableAdapter As Cat_MunicipiosTableAdapters.pCAT_MUNICIPIOS_BTableAdapter
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CATPACIENTESBBindingSource1 As BindingSource
    Friend WithEvents CATPACIENTESBBindingSource As BindingSource
    Friend WithEvents CAT_PACIENTES_B As CAT_PACIENTES_B
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
    Friend WithEvents CAT_PACIENTES_BTableAdapter As CAT_PACIENTES_BTableAdapters.CAT_PACIENTES_BTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
End Class
