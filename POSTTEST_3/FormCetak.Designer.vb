<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        picFoto = New PictureBox()
        BtnBrowse = New Button()
        Nama = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtTelepon = New TextBox()
        txtAlamat = New TextBox()
        rbLaki = New RadioButton()
        rbPerempuan = New RadioButton()
        cbMembaca = New CheckBox()
        cbGaming = New CheckBox()
        cbOlahraga = New CheckBox()
        cbMusik = New CheckBox()
        cbTraveling = New CheckBox()
        cbFotografi = New CheckBox()
        cbMemasak = New CheckBox()
        cbMenulis = New CheckBox()
        cbFilm = New CheckBox()
        cbCoding = New CheckBox()
        dtTanggalLAhir = New DateTimePicker()
        GrpHobby = New GroupBox()
        btnCetak = New Button()
        GroupBox1 = New GroupBox()
        picLogo = New PictureBox()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        GrpHobby.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picFoto
        ' 
        picFoto.Image = My.Resources.Resources.patrick
        picFoto.Location = New Point(22, 64)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(260, 297)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' BtnBrowse
        ' 
        BtnBrowse.Font = New Font("Showcard Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnBrowse.Location = New Point(66, 407)
        BtnBrowse.Name = "BtnBrowse"
        BtnBrowse.Size = New Size(112, 34)
        BtnBrowse.TabIndex = 1
        BtnBrowse.Text = "Browse"
        BtnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.Font = New Font("Stencil", 9.0F)
        Nama.Location = New Point(304, 68)
        Nama.Name = "Nama"
        Nama.Size = New Size(58, 21)
        Nama.TabIndex = 3
        Nama.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Stencil", 9.0F)
        Label2.Location = New Point(307, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 21)
        Label2.TabIndex = 4
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 9.0F)
        Label3.Location = New Point(307, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(153, 21)
        Label3.TabIndex = 5
        Label3.Text = "Nomor Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Stencil", 9.0F)
        Label4.Location = New Point(307, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 21)
        Label4.TabIndex = 6
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Stencil", 9.0F)
        Label5.Location = New Point(307, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 21)
        Label5.TabIndex = 7
        Label5.Text = "Tanggal Lahir"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(476, 71)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(265, 31)
        txtNama.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(476, 109)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(265, 31)
        txtUmur.TabIndex = 9
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(476, 146)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(265, 31)
        txtTelepon.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(476, 220)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(265, 31)
        txtAlamat.TabIndex = 11
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(21, 44)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(134, 24)
        rbLaki.TabIndex = 12
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(21, 79)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(138, 24)
        rbPerempuan.TabIndex = 13
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(6, 42)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(122, 24)
        cbMembaca.TabIndex = 14
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(6, 77)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(103, 24)
        cbGaming.TabIndex = 15
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(4, 112)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(132, 24)
        cbOlahraga.TabIndex = 16
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(148, 77)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(87, 24)
        cbMusik.TabIndex = 17
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbTraveling
        ' 
        cbTraveling.AutoSize = True
        cbTraveling.Location = New Point(148, 147)
        cbTraveling.Name = "cbTraveling"
        cbTraveling.Size = New Size(131, 24)
        cbTraveling.TabIndex = 18
        cbTraveling.Text = "Traveling"
        cbTraveling.UseVisualStyleBackColor = True
        ' 
        ' cbFotografi
        ' 
        cbFotografi.AutoSize = True
        cbFotografi.Location = New Point(148, 182)
        cbFotografi.Name = "cbFotografi"
        cbFotografi.Size = New Size(130, 24)
        cbFotografi.TabIndex = 19
        cbFotografi.Text = "Fotografi"
        cbFotografi.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(6, 182)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(122, 24)
        cbMemasak.TabIndex = 20
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbMenulis
        ' 
        cbMenulis.AutoSize = True
        cbMenulis.Location = New Point(148, 112)
        cbMenulis.Name = "cbMenulis"
        cbMenulis.Size = New Size(107, 24)
        cbMenulis.TabIndex = 21
        cbMenulis.Text = "Menulis"
        cbMenulis.UseVisualStyleBackColor = True
        ' 
        ' cbFilm
        ' 
        cbFilm.AutoSize = True
        cbFilm.Location = New Point(148, 42)
        cbFilm.Name = "cbFilm"
        cbFilm.Size = New Size(74, 24)
        cbFilm.TabIndex = 22
        cbFilm.Text = "Film"
        cbFilm.UseVisualStyleBackColor = True
        ' 
        ' cbCoding
        ' 
        cbCoding.AutoSize = True
        cbCoding.Location = New Point(6, 147)
        cbCoding.Name = "cbCoding"
        cbCoding.Size = New Size(96, 24)
        cbCoding.TabIndex = 23
        cbCoding.Text = "Coding"
        cbCoding.UseVisualStyleBackColor = True
        ' 
        ' dtTanggalLAhir
        ' 
        dtTanggalLAhir.Location = New Point(476, 183)
        dtTanggalLAhir.Name = "dtTanggalLAhir"
        dtTanggalLAhir.Size = New Size(300, 31)
        dtTanggalLAhir.TabIndex = 24
        ' 
        ' GrpHobby
        ' 
        GrpHobby.Controls.Add(cbMembaca)
        GrpHobby.Controls.Add(cbGaming)
        GrpHobby.Controls.Add(cbOlahraga)
        GrpHobby.Controls.Add(cbMenulis)
        GrpHobby.Controls.Add(cbFilm)
        GrpHobby.Controls.Add(cbMemasak)
        GrpHobby.Controls.Add(cbCoding)
        GrpHobby.Controls.Add(cbFotografi)
        GrpHobby.Controls.Add(cbMusik)
        GrpHobby.Controls.Add(cbTraveling)
        GrpHobby.Font = New Font("Algerian", 9.0F)
        GrpHobby.Location = New Point(620, 288)
        GrpHobby.Name = "GrpHobby"
        GrpHobby.Size = New Size(305, 211)
        GrpHobby.TabIndex = 25
        GrpHobby.TabStop = False
        GrpHobby.Text = "Hobby"
        ' 
        ' btnCetak
        ' 
        btnCetak.Font = New Font("Showcard Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(931, 465)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(112, 34)
        btnCetak.TabIndex = 26
        btnCetak.Text = "Cetak"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbLaki)
        GroupBox1.Controls.Add(rbPerempuan)
        GroupBox1.Font = New Font("Algerian", 9.0F)
        GroupBox1.Location = New Point(316, 288)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(254, 175)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' picLogo
        ' 
        picLogo.Image = My.Resources.Resources.Logo_eneh
        picLogo.Location = New Point(782, 8)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(356, 274)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 27
        picLogo.TabStop = False
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1142, 587)
        Controls.Add(picLogo)
        Controls.Add(btnCetak)
        Controls.Add(GrpHobby)
        Controls.Add(dtTanggalLAhir)
        Controls.Add(txtAlamat)
        Controls.Add(txtTelepon)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Nama)
        Controls.Add(BtnBrowse)
        Controls.Add(picFoto)
        Controls.Add(GroupBox1)
        Name = "FormCetak"
        Text = "Form2"
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        GrpHobby.ResumeLayout(False)
        GrpHobby.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents Nama As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbTraveling As CheckBox
    Friend WithEvents cbFotografi As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbMenulis As CheckBox
    Friend WithEvents cbFilm As CheckBox
    Friend WithEvents cbCoding As CheckBox
    Friend WithEvents dtTanggalLAhir As DateTimePicker
    Friend WithEvents GrpHobby As GroupBox
    Friend WithEvents btnCetak As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picLogo As PictureBox
End Class
