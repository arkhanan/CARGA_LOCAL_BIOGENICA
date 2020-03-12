Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars.Docking2010

Partial Public Class Form1
    Dim Exportar As Exportar
    'Dim Consultar As Consultar
    Dim Importar As Importar
    Dim sql As New SQL
    'Dim test As Tester
    'Dim test As Tester
    Dim FORMULARIO As String
    Public CVE_EQUIPO As String
    Public Event CERRADO()

    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub WindowsUIButtonPanel2_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles WindowsUIButtonPanel2.ButtonClick
        Dim btn As WindowsUIButton = TryCast(e.Button, WindowsUIButton)
        Select Case btn.Tag
            Case "BTEtiqueta"
                Select Case FORMULARIO
                    Case "EXPORTAR"

                    Case "CONSULTAR"
                End Select

            Case "BTProcesar"
                Select Case FORMULARIO
                    Case "Importar"
                        Importar.SimpleButton1_Click()
                    Case "CONSULTAR"
                End Select

            Case "BTPaciente"


                Select Case FORMULARIO

                    Case "CONSULTAR"

                        'Consultar.Guardar()

                End Select

            Case "BTExportar"



                Select Case FORMULARIO
                    Case "EXPORTAR"
                    Case "CONSULTAR"

                End Select





        End Select
    End Sub

    Private Sub WindowsUIButtonPanel1_ButtonClick(sender As Object, e As ButtonEventArgs) Handles WindowsUIButtonPanel1.ButtonClick
        Dim btn As WindowsUIButton = TryCast(e.Button, WindowsUIButton)
        For Each ITEM In Me.Controls
            If TypeOf ITEM Is Panel Then
                ITEM.Dispose()
            End If
        Next
        Dim panel As New Panel
        Me.Controls.Add(panel)
        panel.Dock = DockStyle.Fill
        Select Case btn.Tag
            Case "BTExportar"
                Exportar = New Exportar
                Exportar.Dock = DockStyle.Fill
                panel.Controls.Add(Exportar)
                FORMULARIO = "Exportar"

                WindowsUIButtonPanel2.Buttons(0).Properties.Visible = False
                WindowsUIButtonPanel2.Buttons(1).Properties.Visible = True
                WindowsUIButtonPanel2.Buttons(2).Properties.Visible = False

            'Case "BTConsultar"
            '    Consultar = New Consultar
            '    Consultar.Dock = DockStyle.Fill
            '    panel.Controls.Add(Consultar)
            '    FORMULARIO = "Consultar"
            '    WindowsUIButtonPanel2.Buttons(0).Properties.Visible = True
            '    WindowsUIButtonPanel2.Buttons(1).Properties.Visible = False
            '    WindowsUIButtonPanel2.Buttons(2).Properties.Visible = True

            Case "BTImportar"
                Importar = New Importar
                Importar.Dock = DockStyle.Fill
                panel.Controls.Add(Importar)
                FORMULARIO = "Importar"

                WindowsUIButtonPanel2.Buttons(0).Properties.Visible = False
                WindowsUIButtonPanel2.Buttons(1).Properties.Visible = True
                WindowsUIButtonPanel2.Buttons(2).Properties.Visible = False
            Case "BTSalir"
                Me.Close()

        End Select
        panel.BringToFront()
    End Sub



    Private Sub Equipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "Darkroom"
        'Consultar = New Consultar
        'Consultar.Dock = DockStyle.Fill
        ''Consultar.CVE_EQUIPO = CVE_EQUIPO
        'Dim panel As New Panel
        'Me.Controls.Add(panel)
        'panel.Dock = DockStyle.Fill
        'panel.Controls.Add(Consultar)
        'FORMULARIO = "CONSULTAR"
        'WindowsUIButtonPanel2.Buttons(0).Properties.Visible = True
        'WindowsUIButtonPanel2.Buttons(1).Properties.Visible = False
        'WindowsUIButtonPanel2.Buttons(2).Properties.Visible = True

        'Panel.BringToFront()
        'Try
        '    sql.Conectar()
        'Catch ex As Exception
        '    MsgBox("Error")
        'End Try



    End Sub


End Class
