<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        picFotoHasil = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTelepon = New Label()
        lblGender = New Label()
        lblTanggal = New Label()
        lblAlamat = New Label()
        lblHobby = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        picLogo = New PictureBox()
        CType(picFotoHasil, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFotoHasil
        ' 
        picFotoHasil.Location = New Point(77, 45)
        picFotoHasil.Name = "picFotoHasil"
        picFotoHasil.Size = New Size(218, 292)
        picFotoHasil.SizeMode = PictureBoxSizeMode.StretchImage
        picFotoHasil.TabIndex = 0
        picFotoHasil.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Algerian", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(431, 45)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(61, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Font = New Font("Algerian", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUmur.Location = New Point(434, 81)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(55, 20)
        lblUmur.TabIndex = 2
        lblUmur.Text = "Umur"
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.Font = New Font("Algerian", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTelepon.Location = New Point(431, 118)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(84, 20)
        lblTelepon.TabIndex = 3
        lblTelepon.Text = "Telepon"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Algerian", 9.0F)
        lblGender.Location = New Point(431, 154)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(76, 20)
        lblGender.TabIndex = 4
        lblGender.Text = "Gender"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.Font = New Font("Algerian", 9.0F)
        lblTanggal.Location = New Point(431, 197)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(92, 20)
        lblTanggal.TabIndex = 5
        lblTanggal.Text = "Tanggal"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Algerian", 9.0F)
        lblAlamat.Location = New Point(432, 286)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(84, 20)
        lblAlamat.TabIndex = 6
        lblAlamat.Text = "Alamat"
        ' 
        ' lblHobby
        ' 
        lblHobby.AutoSize = True
        lblHobby.Font = New Font("Algerian", 9.0F)
        lblHobby.Location = New Point(431, 242)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(67, 20)
        lblHobby.TabIndex = 7
        lblHobby.Text = "Hobby"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bell MT", 9.0F)
        Label1.Location = New Point(324, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 22)
        Label1.TabIndex = 8
        Label1.Text = "Nama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Bell MT", 9.0F)
        Label2.Location = New Point(324, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 22)
        Label2.TabIndex = 9
        Label2.Text = "Umur :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Bell MT", 9.0F)
        Label3.Location = New Point(324, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 22)
        Label3.TabIndex = 10
        Label3.Text = "Tanggal :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Bell MT", 9.0F)
        Label4.Location = New Point(324, 242)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 22)
        Label4.TabIndex = 11
        Label4.Text = "Hobby :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Bell MT", 9.0F)
        Label5.Location = New Point(324, 286)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 22)
        Label5.TabIndex = 12
        Label5.Text = "Alamat :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Bell MT", 9.0F)
        Label6.Location = New Point(324, 154)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 22)
        Label6.TabIndex = 13
        Label6.Text = "Gender :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Bell MT", 9.0F)
        Label7.Location = New Point(324, 118)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 22)
        Label7.TabIndex = 14
        Label7.Text = "Telepon :"
        ' 
        ' picLogo
        ' 
        picLogo.Image = My.Resources.Resources.Logo_eneh
        picLogo.Location = New Point(521, 12)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(334, 257)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 28
        picLogo.TabStop = False
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(picLogo)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblHobby)
        Controls.Add(lblAlamat)
        Controls.Add(lblTanggal)
        Controls.Add(lblGender)
        Controls.Add(lblTelepon)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(picFotoHasil)
        Name = "FormHasil"
        Text = "Form2"
        CType(picFotoHasil, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFotoHasil As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents picLogo As PictureBox
End Class
