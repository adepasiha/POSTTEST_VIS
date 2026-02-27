<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtIPSemester = New TextBox()
        txtIPKumulatif = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblPredikat = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.Location = New Point(283, 85)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(241, 31)
        txtIPSemester.TabIndex = 0
        txtIPSemester.Text = "1"
        ' 
        ' txtIPKumulatif
        ' 
        txtIPKumulatif.Location = New Point(283, 213)
        txtIPKumulatif.Name = "txtIPKumulatif"
        txtIPKumulatif.ReadOnly = True
        txtIPKumulatif.Size = New Size(241, 31)
        txtIPKumulatif.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(283, 148)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(412, 148)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(373, 304)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(76, 25)
        lblPredikat.TabIndex = 4
        lblPredikat.Text = "Predikat"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(159, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 5
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(157, 219)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 6
        Label2.Text = "IP Kumulatif"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(907, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblPredikat)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPKumulatif)
        Controls.Add(txtIPSemester)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents txtIPKumulatif As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblPredikat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
