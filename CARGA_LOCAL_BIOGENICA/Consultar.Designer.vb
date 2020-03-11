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
        Me.cbbMunicipio = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.Cat_Estados = New CARGA_LOCAL_BIOGENICA.Cat_Estados()
        Me.CatEstadosBindingSource = New System.Windows.Forms.BindingSource()
        Me.PCATESTADOSBBindingSource = New System.Windows.Forms.BindingSource()
        Me.PCAT_ESTADOS_BTableAdapter = New CARGA_LOCAL_BIOGENICA.Cat_EstadosTableAdapters.pCAT_ESTADOS_BTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbbMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatEstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Location = New System.Drawing.Point(415, 243)
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
        Me.GroupBox1.Location = New System.Drawing.Point(415, 168)
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(437, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 15
        '
        'cMaterno
        '
        Me.cMaterno.Location = New System.Drawing.Point(92, 193)
        Me.cMaterno.Name = "cMaterno"
        Me.cMaterno.Size = New System.Drawing.Size(290, 21)
        Me.cMaterno.TabIndex = 14
        '
        'cPaterno
        '
        Me.cPaterno.Location = New System.Drawing.Point(92, 151)
        Me.cPaterno.Name = "cPaterno"
        Me.cPaterno.Size = New System.Drawing.Size(290, 21)
        Me.cPaterno.TabIndex = 13
        '
        'cNombre
        '
        Me.cNombre.Location = New System.Drawing.Point(92, 113)
        Me.cNombre.Name = "cNombre"
        Me.cNombre.Size = New System.Drawing.Size(290, 21)
        Me.cNombre.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "A. Manerto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "A. Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Estado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Municipio"
        '
        'cbbMunicipio
        '
        Me.cbbMunicipio.Location = New System.Drawing.Point(92, 281)
        Me.cbbMunicipio.Name = "cbbMunicipio"
        Me.cbbMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbbMunicipio.Size = New System.Drawing.Size(290, 20)
        Me.cbbMunicipio.TabIndex = 23
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.Location = New System.Drawing.Point(92, 243)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DataSource = Me.PCATESTADOSBBindingSource
        Me.LookUpEdit1.Properties.DisplayMember = "DESCRIPCION"
        Me.LookUpEdit1.Properties.ValueMember = "CVE_ESTADO"
        Me.LookUpEdit1.Size = New System.Drawing.Size(290, 20)
        Me.LookUpEdit1.TabIndex = 24
        '
        'Cat_Estados
        '
        Me.Cat_Estados.DataSetName = "Cat_Estados"
        Me.Cat_Estados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CatEstadosBindingSource
        '
        Me.CatEstadosBindingSource.DataSource = Me.Cat_Estados
        Me.CatEstadosBindingSource.Position = 0
        '
        'PCATESTADOSBBindingSource
        '
        Me.PCATESTADOSBBindingSource.DataMember = "pCAT_ESTADOS_B"
        Me.PCATESTADOSBBindingSource.DataSource = Me.CatEstadosBindingSource
        '
        'PCAT_ESTADOS_BTableAdapter
        '
        Me.PCAT_ESTADOS_BTableAdapter.ClearBeforeFill = True
        '
        'Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Me.cbbMunicipio)
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
        Me.Size = New System.Drawing.Size(701, 402)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbbMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cat_Estados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatEstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCATESTADOSBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbbMunicipio As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PCATESTADOSBBindingSource As BindingSource
    Friend WithEvents CatEstadosBindingSource As BindingSource
    Friend WithEvents Cat_Estados As Cat_Estados
    Friend WithEvents PCAT_ESTADOS_BTableAdapter As Cat_EstadosTableAdapters.pCAT_ESTADOS_BTableAdapter
End Class
