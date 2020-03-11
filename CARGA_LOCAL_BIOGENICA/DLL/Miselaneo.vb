Imports System.IO
Imports System.IO.Ports
Imports System.Management
Imports System.Security.Cryptography
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGauges.Win.Gauges.State
Imports System.Data.OleDb

Imports EXCEL = Microsoft.Office.Interop.Excel

Public Class Miselaneo
    Public Delegate Sub dlgUpdateUI(ByVal rtb As RichTextBox, ByVal text As String, ByVal col As Color)
    Public Delegate Sub dlgUpdateUIY(ByVal rtb As RichTextBox)
    Public Delegate Sub dlgUpdateUIX(ByVal GRID As DataGridView, DT As DataTable)
    Sub RegistryKey_Guardar(EQUIPO As Integer, ByVal sVariable As String, ByVal sValor As String)
        Dim key As Microsoft.Win32.RegistryKey
        If EQUIPO = 0 Then
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\SISLABV2_INTERFAZ\TIPOCONEXION")
        Else
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\SISLABV2_INTERFAZ\EQUIPO")

        End If

        Try
            key.SetValue(sVariable, sValor)
        Finally
            key.Close()
        End Try
    End Sub
    ''funcion para borrar datos en el regedit del equipo de computo
    Sub RegistryKey_Borrar(EQUIPO As Integer, ByVal sVariable As String, ByVal sValor As String)
        Dim key As Microsoft.Win32.RegistryKey
        If EQUIPO = 0 Then
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\SISLABV2_INTERFAZ\TIPOCONEXION")
        Else
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\SISLABV2_INTERFAZ\EQUIPO")

        End If
        Try
            key.DeleteValue(sVariable)
        Finally
            key.Close()
        End Try
    End Sub
    ''funcion para leer datos en el regedit del equipo de computo
    Function RegistryKey_Leer(EQUIPOS As Integer, Optional ByVal sCadenahaObtener As String = "CADENACONEXION") As String
        Dim sCadenaDevuelta As String = Nothing
        Dim key As Microsoft.Win32.RegistryKey
        If EQUIPOS = 0 Then
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\SISLABV2_INTERFAZ\TIPOCONEXION")
        Else
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\SISLABV2_INTERFAZ\EQUIPO")
        End If

        If Not key Is Nothing Then
            Try
                Dim sValueKey As String = key.GetValue(sCadenahaObtener, "").ToString()
                If sValueKey <> "" And Not sValueKey Is Nothing Then
                    sCadenaDevuelta = sValueKey
                End If
            Finally
                key.Close()
            End Try
        End If
        Return sCadenaDevuelta
    End Function

    Public Function Encriptar(ByVal Input As String) As String
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("saxsoft9") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("ccInterfaz/sislabOprogramacionCC") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))
    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("saxsoft9") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("ccInterfaz/sislabOprogramacionCC") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Sub LIMPIAR(GC As DevExpress.XtraEditors.GroupControl, Optional ByVal B As Boolean = False)
        For Each CTRL In GC.Controls
            If TypeOf CTRL Is DevExpress.XtraEditors.TextEdit Then
                If CTRL.Enabled = True Then
                    CTRL.TEXT = Nothing
                End If

            End If

            If TypeOf CTRL Is DevExpress.XtraEditors.ComboBoxEdit Then
                If CTRL.Enabled = True Then
                    CTRL.SelectedIndex = -1
                End If

            End If
            If B = False Then
                If TypeOf CTRL Is DevExpress.XtraEditors.LookUpEdit Then
                    If CTRL.Enabled = True Then
                        CTRL.EditValue = Nothing
                    End If

                End If
            End If


            If TypeOf CTRL Is RadioButton Then
                If CTRL.Enabled = True Then
                    CTRL.cHECKED = False
                End If

            End If

            If TypeOf CTRL Is DevExpress.XtraEditors.CheckButton Then
                If CTRL.Enabled = True Then
                    CTRL.cHECKED = False
                End If

            End If
        Next
    End Sub

    Public Sub updateRichTextBox(ByVal rtb As RichTextBox, ByVal text As String, Optional ByVal c As Color = Nothing, Optional ByVal NO_SALTO As Boolean = False)
        Try

            If rtb.InvokeRequired = True Then
                Dim d As New dlgUpdateUI(AddressOf updateRichTextBox)
                rtb.Invoke(d, rtb, text, c)
            Else
                If c = Nothing Then
                    c = Color.Black
                End If

                With rtb
                    If NO_SALTO = False Then
                        .SelectionStart = .TextLength
                        .SelectionLength = 0
                        .SelectionColor = c
                        .AppendText(text)
                        .SelectedText = String.Empty
                        .ScrollToCaret()

                    Else
                        .AppendText(text)
                    End If

                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub clearrtb(ByVal rtb As RichTextBox)
        If rtb.InvokeRequired = True Then
            Dim d As New dlgUpdateUIY(AddressOf clearrtb)
            rtb.Invoke(d, rtb)
        Else

            rtb.Clear()


        End If
    End Sub
    Public Sub GRDID_UPDATE(ByVal gRID As DataGridView, DT As DataTable)
        If gRID.InvokeRequired = True Then
            Dim d As New dlgUpdateUIX(AddressOf GRDID_UPDATE)
            gRID.Invoke(d, gRID, DT)
        Else
            'gRID.Rows.Clear()
            gRID.DataSource = DT
            gRID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            gRID.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End If
    End Sub
    Function Dll(equipo As String)
        Try
            Directory.CreateDirectory(Application.StartupPath & "\EQUIPOS\")


            Dim TI As Integer
            Dim MI As Integer
            Dim asm As System.Reflection.Assembly
            Dim t As Type()
            Dim TY As Type
            Dim MIF As Reflection.MethodInfo()
            Dim MM As Reflection.MethodInfo
            Dim O As Object
            Dim path As String
            path = Application.StartupPath & "\EQUIPOS\" & equipo & ".dll"
            asm = System.Reflection.Assembly.LoadFrom(path)
            t = asm.GetTypes
            For i As Integer = 0 To t.Length - 1
                If t(i).Name = "DIVISION_TRATAMIENTO" Then
                    TI = i
                    Exit For
                End If
            Next
            TY = asm.GetType(t(TI).FullName)
            MIF = TY.GetMethods
            For J As Integer = 0 To MIF.Length - 1
                If MIF(J).Name = "DIVISION" Then
                    MI = J
                    Exit For
                End If
            Next
            MM = TY.GetMethod(MIF(MI).Name)
            O = Activator.CreateInstance(TY)
            DLL_INSTANCIA.Add(equipo, O)
            DLL_METODO.Add(equipo, MM)
            Return "OK"
        Catch ex As Exception
            Return "dll No Encontrado"
        End Try



    End Function


    Public Sub msgSuccess(ByVal rtbLog As RichTextBox, ByVal folio As String, ByVal suc As String, ByVal estudio As String, ByVal resultado As String, ByVal cve_equipo As String)
        'If rtbLog.TextLength > 1500 Then
        '    rtbLog.Clear()
        'End If
        Dim S As String
        S = "Equipo: " & cve_equipo & "/" & "Ensayo: " & estudio & "/" & "Resultado: " & resultado
        'updateRichTextBox(rtbLog, "Status: El folio " & folio & " ha sido guardado correctamente" & vbCrLf, Color.Green)
        updateRichTextBox(rtbLog, S & vbCrLf, Color.Green)
        updateRichTextBox(rtbLog, StrDup(30, "-") & vbCrLf)

    End Sub
    ''' <summary>
    ''' retorna mensaje de error en rtblog color rojo
    ''' </summary>
    ''' <param name="rtbLog"></param>
    ''' <param name="folio"></param>
    ''' <param name="suc"></param>
    ''' <param name="estudio"></param>
    ''' <param name="resultado"></param>
    ''' <param name="cve_equipo"></param>
    Public Sub msgAlert(ByVal rtbLog As RichTextBox, ByVal folio As String, ByVal suc As String, ByVal estudio As String, ByVal resultado As String, ByVal cve_equipo As String)
        'If rtbLog.TextLength > 1500 Then
        '    rtbLog.Clear()
        'End If
        Dim S As String
        S = "Equipo: " & cve_equipo & "/" & "Ensayo: " & estudio & "/" & "Resultado: " & resultado
        updateRichTextBox(rtbLog, S & vbCrLf)
        updateRichTextBox(rtbLog, "Error al guardar el folio " & folio & vbCrLf, Color.Red)
        updateRichTextBox(rtbLog, StrDup(30, "-") & vbCrLf)
    End Sub
    ''' <summary>
    ''' Reotrna mensjae de info en rtblog color azul
    ''' </summary>
    ''' <param name="rtbLog"></param>
    ''' <param name="folio"></param>
    ''' <param name="suc"></param>
    ''' <param name="estudio"></param>
    ''' <param name="resultado"></param>
    ''' <param name="cve_equipo"></param>
    Public Sub msgInfo(ByVal rtbLog As RichTextBox, ByVal folio As String, ByVal suc As String, ByVal estudio As String, ByVal resultado As String, ByVal cve_equipo As String)
        'If rtbLog.TextLength > 1500 Then
        '    rtbLog.Clear()
        'End If
        Dim S As String
        S = "Equipo: " & cve_equipo & "/" & "Ensayo: " & estudio & "/" & "Resultado: " & resultado
        updateRichTextBox(rtbLog, S & vbCrLf)
        updateRichTextBox(rtbLog, "El folio " & folio & " tiene el ensayo " & estudio & " que aún no esta asociado." & vbCrLf, Color.Blue)
        updateRichTextBox(rtbLog, "Para poder guardarlo debe solicitarlo con el administrador del sistema." & vbCrLf, Color.Blue)
        updateRichTextBox(rtbLog, StrDup(30, "-") & vbCrLf)
    End Sub

    Public Sub msgAlert2(ByVal rtbLog As RichTextBox, msj As String, ByVal cve_equipo As String)
        'If rtbLog.TextLength > 1500 Then
        '    rtbLog.Clear()
        'End If
        Dim S As String
        S = "Equipo: " & cve_equipo & "/" & msj
        updateRichTextBox(rtbLog, S & vbCrLf)
        updateRichTextBox(rtbLog, "Comunicacion perdida servidor " & vbCrLf, Color.Red)
        updateRichTextBox(rtbLog, StrDup(30, "-") & vbCrLf)
    End Sub

    'Function hddID() As String
    '    Try
    '        Dim strSN As String = ""
    '        Dim strQuery As String = "SELECT * FROM Win32_PhysicalMedia"
    '        Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
    '        Dim i As Integer = 0

    '        For Each mo As ManagementObject In query.[Get]()


    '            If mo("SerialNumber") IsNot Nothing Then
    '                '    strSN = strSN & " " & "N/A Serial"
    '                'Else
    '                strSN = strSN & "" & mo("SerialNumber").ToString()
    '            End If
    '            i += 1
    '        Next

    '        Return Trim(strSN)

    '    Catch ex As Exception
    '        Return ""
    '    End Try
    'End Function

    Public Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " & "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then cpu_ids = cpu_ids.Substring(2)
        Return cpu_ids
    End Function

    Public Function GetDriveSerialNumber() As String
        Dim DriveSerial As Integer
        'Create a FileSystemObject object
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        Return DriveSerial.ToString("X2")
    End Function

    Public Function ID_UNICO_PC()
        Dim ID_CPU As String = CpuId()
        Dim ID_HDD As String = GetDriveSerialNumber()
        Dim SERIAL_UNICA_PC As String
        SERIAL_UNICA_PC = ID_CPU & ID_HDD
        Return SERIAL_UNICA_PC.ToString
    End Function

    Public Function creacion_codigo(str As String, rt As Boolean)
        Dim Codigo As String
        Codigo = str & vbCrLf
        If rt = True Then
            Return Codigo
        End If
    End Function






    'Shared Sub Main(ByVal args() As String)
    '    Dim workbook As New Workbook()
    '    workbook.LoadFromFile("..\ExceltoCSV.xls ")
    '    Dim sheet As Worksheet = workbook.Worksheets(0)
    '    sheet.SaveToFile("sample.csv", ",", Encoding.UTF8)

    'End Sub

    Public Sub ExcelToCSV(sourceFile As String, destinationFile As String)
        Dim officeType As Type = Type.GetTypeFromProgID("Excel.Application")
        If officeType Is Nothing Then
        Else
            Dim app As New Excel.Application()
            app.DisplayAlerts = False
            ' Open Excel Workbook for conversion.
            Dim excelWorkbook As Excel.Workbook = app.Workbooks.Open(sourceFile)
            ' Save file as CSV file.
            excelWorkbook.SaveAs(destinationFile, EXCEL.XlFileFormat.xlCSV)

            ' Close the Workbook.
            excelWorkbook.Close()
            ' Quit Excel Application.
            app.Quit()
        End If
    End Sub


    Public Function Read_CSV(ByVal FileName As String, ByVal FilePath As String) As DataTable
        '----------------------------------------------------
        'Reads a csv file into a datatable, with the first row as column headers

        Dim myFile As String = FilePath & "\" & FileName
        Dim myTable As DataTable = New DataTable("MyTable")
        Dim i As Integer
        Dim myRow As DataRow
        Dim myColumn As DataColumn
        Dim MyType As String
        Dim fieldValues As String()

        Dim ColumnNames As String()
        Dim ColumnTypes As String()
        Dim myReader As New StreamReader(myFile)
        Try

            'Open file and read first two lines
            ColumnNames = myReader.ReadLine().Split(",")

            'Create data columns named according to first line of data, with type according to second line
            For i = 0 To ColumnNames.Length() - 1
                myColumn = New DataColumn()
                'MyType = "System." & ColumnTypes(i)
                'myColumn.DataType = System.Type.GetType(MyType)

                myColumn.ColumnName = ColumnNames(i)
                myTable.Columns.Add(myColumn)
            Next

            'Read the body of the data to data table
            While myReader.Peek() <> -1
                fieldValues = myReader.ReadLine().Split(",")
                myRow = myTable.NewRow
                For i = 0 To fieldValues.Length() - 1
                    myRow.Item(i) = fieldValues(i).ToString
                Next
                myTable.Rows.Add(myRow)
            End While
        Catch ex As Exception
            MsgBox("Error building datatable: " & ex.Message)
            Return New DataTable("Empty")
        Finally
            myReader.Close()
        End Try

        Return myTable
    End Function

End Class
