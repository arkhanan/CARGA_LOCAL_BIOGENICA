Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.WindowsUIButtonPanel1 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.WindowsUIButtonPanel2 = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowsUIButtonPanel1
        '
        Me.WindowsUIButtonPanel1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton(), New DevExpress.XtraBars.Docking2010.WindowsUIButton()})
        Me.WindowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowsUIButtonPanel1.Location = New System.Drawing.Point(0, 0)
        Me.WindowsUIButtonPanel1.Name = "WindowsUIButtonPanel1"
        Me.WindowsUIButtonPanel1.Size = New System.Drawing.Size(382, 100)
        Me.WindowsUIButtonPanel1.TabIndex = 0
        Me.WindowsUIButtonPanel1.Text = "WindowsUIButtonPanel1"
        '
        'WindowsUIButtonPanel2
        '
        Me.WindowsUIButtonPanel2.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton(), New DevExpress.XtraBars.Docking2010.WindowsUIButton()})
        Me.WindowsUIButtonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowsUIButtonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.WindowsUIButtonPanel2.Name = "WindowsUIButtonPanel2"
        Me.WindowsUIButtonPanel2.Size = New System.Drawing.Size(632, 100)
        Me.WindowsUIButtonPanel2.TabIndex = 1
        Me.WindowsUIButtonPanel2.Text = "WindowsUIButtonPanel2"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.WindowsUIButtonPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.WindowsUIButtonPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1018, 100)
        Me.SplitContainer1.SplitterDistance = 382
        Me.SplitContainer1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 622)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents WindowsUIButtonPanel1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents WindowsUIButtonPanel2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents SplitContainer1 As SplitContainer

#End Region

End Class
