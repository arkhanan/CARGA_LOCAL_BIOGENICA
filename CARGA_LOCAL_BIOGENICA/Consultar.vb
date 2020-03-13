Public Class Consultar
    Dim SQL As New SQL
    Dim Varios As New Miselaneo
    Dim bEsNuevo As Boolean
    Public IsSelected As Boolean = False
    Public bguardo As Boolean = False




    Sub consultar()

        ReDim SQL.ParametersX_Global(3)
        SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@Paterno", cPaterno.Text)
        SQL.ParametersX_Global(1) = New SqlClient.SqlParameter("@Materno", cMaterno.Text)
        SQL.ParametersX_Global(2) = New SqlClient.SqlParameter("@Nombre", cNombre.Text)
        SQL.dataset(CAT_PACIENTES_B._CAT_PACIENTES_B, "CAT_PACIENTES_B", SQL.ParametersX_Global)


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        consultar()

    End Sub



    Function fCalcular_FechaNacimiento() As DateTime
        Dim nFecha As DateTime
        If CDbl(TxtAno.Text) <> 0 And TxtAno.Text <> "" Then
            nFecha = DateAdd(DateInterval.Year, -(CDbl(TxtAno.Text)), Now)

        ElseIf TxtMes.Text <> 0 And TxtMes.Text <> "" Then
            nFecha = DateAdd(DateInterval.Month, -(Val(TxtMes.Text)), Now)

        ElseIf CDbl(TxtDia.Text) <> 0 And TxtDia.Text <> "" Then
            nFecha = DateAdd(DateInterval.Day, -(CDbl(TxtDia.Text)), Now)

        End If
        If CDbl(TxtAno.Text) = 0 And CDbl(TxtMes.Text) = 0 And CDbl(TxtDia.Text) = 0 And TxtAno.Text <> "" And TxtMes.Text <> "" And TxtDia.Text <> "" Then
            nFecha = Now

        End If
        Return nFecha
    End Function

    Private Sub Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbbEstado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        cbbMunicipio.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup



        SQL.dataset(Cat_Estados.pCAT_ESTADOS_B, "pCAT_ESTADOS_B")




    End Sub


    Private Sub cbbEstado_EditValueChanged(sender As Object, e As EventArgs) Handles cbbEstado.EditValueChanged


        If cbbEstado.SelectedText <> Nothing Then Exit Sub


        ReDim SQL.ParametersX_Global(0)
        SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Estado", cbbEstado.EditValue)
        SQL.dataset(Cat_Municipios.pCAT_MUNICIPIOS_B, "pCAT_MUNICIPIOS_B", SQL.ParametersX_Global)


    End Sub









    Private Sub cPACIENTE_FECHA_NAC_LostFocus(sender As Object, e As EventArgs) Handles cPACIENTE_FECHA_NAC.LostFocus
        calcular_edad_datetime()
    End Sub


    Sub calcular_edad_datetime()
        Try
            Dim ldtFecha1 As Date
            Dim ldtFecha2 As Date
            Dim ldtMesAnterior As Date
            Dim liDias As Integer
            Dim liMeses As Integer
            Dim liAños As Integer
            '
            ldtFecha1 = Now
            ldtMesAnterior = DateAdd("M", -1, ldtFecha1)
            ldtFecha2 = Date.Parse(cPACIENTE_FECHA_NAC.Value)
            '
            liAños = DatePart("yyyy", ldtFecha1) - DatePart("yyyy", ldtFecha2)
            liMeses = DatePart("m", ldtFecha1) - DatePart("m", ldtFecha2)
            liDias = DatePart("d", ldtFecha1) - DatePart("d", ldtFecha2)
            Do While liDias < 0
                If liMeses = 0 Then
                    liDias = liDias + DateAndTime.Day(DateSerial(Year(ldtFecha1), Month(ldtFecha1) + 1, 0)) - 1
                Else
                    liDias = liDias + DateAndTime.Day(DateSerial(Year(ldtMesAnterior), Month(ldtMesAnterior) + 1, 0))
                End If
                liMeses = liMeses - 1
                ldtMesAnterior = DateAdd("M", -1, ldtMesAnterior)
            Loop
            If liMeses < 0 Then
                liMeses = liMeses + 12
                liAños = liAños - 1
            End If





            TxtAno.Text = liAños
            TxtMes.Text = liMeses
            TxtDia.Text = liDias

        Catch ex As Exception

        End Try
    End Sub





    Sub Guardar()


        Dim sDevuelveId As String

        Try
            ReDim SQL.ParametersX_Global(13)
            '------------------------------------
            If Trim(Me.Tag) = Nothing Then
                SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@EsNuevo", 1)
                SQL.ParametersX_Global(1) = New SqlClient.SqlParameter("@Nombre", Me.cNombre.Text)
                SQL.ParametersX_Global(2) = New SqlClient.SqlParameter("@Paterno", cPaterno.Text)
                SQL.ParametersX_Global(3) = New SqlClient.SqlParameter("@Materno", cMaterno.Text)
                SQL.ParametersX_Global(4) = New SqlClient.SqlParameter("@Cve_Estado", cbbEstado.EditValue)
                SQL.ParametersX_Global(5) = New SqlClient.SqlParameter("@Cve_Municipio", Me.cbbMunicipio.EditValue)
                SQL.ParametersX_Global(6) = New SqlClient.SqlParameter("@Fecha_Nacimiento", TxtAno.Text)

                If RadioB_M.Checked = True Then
                    SQL.ParametersX_Global(7) = New SqlClient.SqlParameter("@Sexo", "MASCULINO")
                Else
                    SQL.ParametersX_Global(7) = New SqlClient.SqlParameter("@Sexo", "FEMENINO")
                End If


                bEsNuevo = True
            Else
                SQL.ParametersX_Global(0) = New SqlClient.SqlParameter("@EsNuevo", 0)
                SQL.ParametersX_Global(1) = New SqlClient.SqlParameter("@Nombre", Me.cNombre.Text)
                SQL.ParametersX_Global(2) = New SqlClient.SqlParameter("@Paterno", cPaterno.Text)
                SQL.ParametersX_Global(3) = New SqlClient.SqlParameter("@Materno", cMaterno.Text)
                SQL.ParametersX_Global(4) = New SqlClient.SqlParameter("@Cve_Estado", cbbEstado.EditValue)
                SQL.ParametersX_Global(5) = New SqlClient.SqlParameter("@Cve_Municipio", Me.cbbMunicipio.EditValue)
                SQL.ParametersX_Global(6) = New SqlClient.SqlParameter("@Fecha_Nacimiento", TxtAno.Text)

                If RadioB_M.Checked = True Then
                    SQL.ParametersX_Global(7) = New SqlClient.SqlParameter("@Sexo", "MASCULINO")
                Else
                    SQL.ParametersX_Global(7) = New SqlClient.SqlParameter("@Sexo", "FEMENINO")
                End If

            End If



            sDevuelveId = SQL.fGuardar_O_EliminarXProcedure_DevuelveId("pCAT_PACIENTES_G", "@Parametro", SQL.ParametersX_Global)




            If Trim(sDevuelveId) <> Nothing And Trim(sDevuelveId) <> "0" Then

                Me.Tag = sDevuelveId

                MessageBox.Show("Expediente actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bguardo = True


            Else

                MessageBox.Show("Este registro 'NO' se guardo, satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                bguardo = False
            End If

            '-------------------------------------

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        limpiar()
    End Sub


    Sub limpiar()

        cNombre.Text = Nothing
        cPaterno.Text = Nothing
        cMaterno.Text = Nothing
        TxtAno.Text = Nothing
        TxtMes.Text = Nothing
        TxtDia.Text = Nothing
        RadioB_M.Checked = Nothing
        RadioB_F.Checked = Nothing
        cbbEstado.EditValue = 0
        cbbMunicipio.EditValue = 0




    End Sub

    Private Sub TxtAno_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtAno.KeyUp
        Dim aa = e.KeyValue


        If aa = 13 Then

            Calcular_Edad()


        End If
    End Sub

    Private Sub TxtMes_Enter(sender As Object, e As EventArgs) Handles TxtMes.Enter
        Calcular_Edad()
    End Sub

    Private Sub TxtDia_Enter(sender As Object, e As EventArgs) Handles TxtDia.Enter
        Calcular_Edad()
    End Sub


    Private Sub TxtAno_LostFocus(sender As Object, e As EventArgs) Handles TxtAno.LostFocus
        Calcular_Edad()
    End Sub

    Private Sub TxtMes_LostFocus(sender As Object, e As EventArgs) Handles TxtMes.LostFocus
        Calcular_Edad()
    End Sub

    Private Sub TxtDia_LostFocus(sender As Object, e As EventArgs) Handles TxtDia.LostFocus
        Calcular_Edad()
    End Sub



    Private Sub TxtAno_Click(sender As Object, e As EventArgs) Handles TxtAno.Click
        TxtAno.SelectAll()
    End Sub

    Private Sub TxtMes_GotFocus(sender As Object, e As EventArgs) Handles TxtMes.GotFocus
        TxtMes.SelectAll()
    End Sub

    Private Sub TxtDia_GotFocus(sender As Object, e As EventArgs) Handles TxtDia.GotFocus
        TxtDia.SelectAll()
    End Sub


    Sub Calcular_Edad()
        Dim n As Double
        Dim s As Date
        Dim fecha_a As Date = Now
        Dim mes As Boolean = False
        Dim Dia As Boolean = False
        Dim year As Boolean = False
        If TxtAno.Text <> "0" And TxtAno.Text <> Nothing Then
            year = True
            n = Val(TxtAno.Text)
            s = DateAdd(DateInterval.Year, -n, fecha_a)
        End If
        If TxtMes.Text <> "0" And TxtMes.Text <> Nothing Then
            'If year = False Then
            mes = True
            'Else
            '    mes = False
            'End If
            n = Val(TxtMes.Text)
            s = DateAdd(DateInterval.Month, -n, IIf(year, s, fecha_a))
        End If
        If TxtDia.Text <> "0" And TxtDia.Text <> Nothing Then
            'If year = False Then
            '    Dia = True
            'Else
            '    Dia = False
            'End If
            n = Val(TxtDia.Text)
            s = DateAdd(DateInterval.Day, -n, IIf(year, s, IIf(mes, s, fecha_a)))
        End If
        If s <> Nothing Then
            cPACIENTE_FECHA_NAC.Value = s
        Else
            cPACIENTE_FECHA_NAC.Value = Now
        End If
        IsSelected = True
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick




        Dim nombre = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "nombre")
        Dim PATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "A.P")
        Dim MATERNO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "A.M")
        Dim EDAD = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "EDAD")
        Dim ESTADO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "ESTADO")
        Dim MUNICIPIO = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "MUNICIPIO")
        Dim FNAC = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "")

        '    Dim result As Integer = MessageBox.Show("Esta Seguro de Eliminar" & vbCrLf & "Equipo: " & equipo & vbCrLf & "Elemento: " & elemento, "Advertencia", MessageBoxButtons.YesNo)


        cNombre.Text = nombre

    End Sub
End Class
