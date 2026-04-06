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
        components = New System.ComponentModel.Container()
        Me.menuStripMain = New MenuStrip()
        Me.menuInputData = New ToolStripMenuItem()
        Me.menuViewCard = New ToolStripMenuItem()
        Me.menuSaveData = New ToolStripMenuItem()
        Me.menuOpenData = New ToolStripMenuItem()
        Me.menuExit = New ToolStripMenuItem()

        Me.lblTitle = New Label()
        Me.pbLogo = New PictureBox()

        Me.tabControlMain = New TabControl()
        Me.tabDataUtama = New TabPage()
        Me.tabKontakInfo = New TabPage()
        Me.tabProfilAktivitas = New TabPage()

        ' Tab1 controls
        Me.lblNama = New Label()
        Me.txtNama = New TextBox()
        Me.lblID = New Label()
        Me.txtID = New TextBox()
        Me.lblTanggalLahir = New Label()
        Me.dtpTanggalLahir = New DateTimePicker()
        Me.gbGender = New GroupBox()
        Me.rbMale = New RadioButton()
        Me.rbFemale = New RadioButton()
        Me.lblKomunitas = New Label()
        Me.cbKomunitas = New ComboBox()

        ' Tab2 controls
        Me.lblPhone = New Label()
        Me.mtbPhone = New MaskedTextBox()
        Me.lblEmail = New Label()
        Me.txtEmail = New TextBox()
        Me.lblAlamat = New Label()
        Me.txtAlamat = New TextBox()

        ' Tab3 controls
        Me.pbProfile = New PictureBox()
        Me.btnBrowsePhoto = New Button()
        Me.gbRoles = New GroupBox()
        Me.rbKetua = New RadioButton()
        Me.rbAnggota = New RadioButton()
        Me.rbAdmin = New RadioButton()
        Me.lblHobbies = New Label()
        Me.chkH1 = New CheckBox()
        Me.chkH2 = New CheckBox()
        Me.chkH3 = New CheckBox()
        Me.chkH4 = New CheckBox()
        Me.chkH5 = New CheckBox()
        Me.chkH6 = New CheckBox()
        Me.chkH7 = New CheckBox()
        Me.chkH8 = New CheckBox()

        Me.btnSavePrint = New Button()

        Me.openPhotoDialog = New OpenFileDialog()
        Me.openDataDialog = New OpenFileDialog()
        Me.saveDataDialog = New SaveFileDialog()

        ' Form
        Me.SuspendLayout()
        Me.ClientSize = New Size(900, 600)
        Me.Text = "Aplikasi Kartu Komunitas"

        ' MenuStrip
        Me.menuStripMain.Items.AddRange(New ToolStripItem() {
            Me.menuInputData,
            Me.menuViewCard,
            Me.menuSaveData,
            Me.menuOpenData,
            Me.menuExit})
        Me.menuStripMain.Location = New Point(0, 0)
        Me.menuStripMain.Name = "menuStripMain"
        Me.menuStripMain.Size = New Size(900, 24)
        Me.Controls.Add(Me.menuStripMain)

        Me.menuInputData.Text = "Input Data"
        Me.menuViewCard.Text = "Lihat Kartu"
        Me.menuSaveData.Text = "Simpan Data"
        Me.menuOpenData.Text = "Buka Data"
        Me.menuExit.Text = "Keluar"

        AddHandler Me.menuInputData.Click, AddressOf Me.menuInputData_Click
        AddHandler Me.menuViewCard.Click, AddressOf Me.menuViewCard_Click
        AddHandler Me.menuSaveData.Click, AddressOf Me.menuSaveData_Click
        AddHandler Me.menuOpenData.Click, AddressOf Me.menuOpenData_Click
        AddHandler Me.menuExit.Click, AddressOf Me.menuExit_Click

        ' Title and logo
        Me.lblTitle.Text = "Aplikasi Pembuatan Kartu Komunitas"
        Me.lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Me.lblTitle.Location = New Point(100, 30)
        Me.lblTitle.AutoSize = True
        Me.Controls.Add(Me.lblTitle)

        Me.pbLogo.Location = New Point(10, 26)
        Me.pbLogo.Size = New Size(72, 72)
        Me.pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        Me.pbLogo.BorderStyle = BorderStyle.FixedSingle
        Me.Controls.Add(Me.pbLogo)
        ' Default logo - can be left empty; user can set in designer

        ' TabControl
        Me.tabControlMain.Location = New Point(10, 110)
        Me.tabControlMain.Size = New Size(880, 420)
        Me.tabControlMain.TabPages.AddRange(New TabPage() {Me.tabDataUtama, Me.tabKontakInfo, Me.tabProfilAktivitas})
        Me.Controls.Add(Me.tabControlMain)

        ' TabDataUtama layout
        Me.tabDataUtama.Text = "Data Utama"
        Me.tabDataUtama.Padding = New Padding(10)

        Me.lblNama.Text = "Nama"
        Me.lblNama.Location = New Point(20, 20)
        Me.lblNama.AutoSize = True
        Me.tabDataUtama.Controls.Add(Me.lblNama)

        Me.txtNama.Location = New Point(140, 18)
        Me.txtNama.Size = New Size(300, 23)
        Me.tabDataUtama.Controls.Add(Me.txtNama)

        Me.lblID.Text = "ID Anggota"
        Me.lblID.Location = New Point(20, 60)
        Me.lblID.AutoSize = True
        Me.tabDataUtama.Controls.Add(Me.lblID)

        Me.txtID.Location = New Point(140, 58)
        Me.txtID.Size = New Size(200, 23)
        Me.tabDataUtama.Controls.Add(Me.txtID)

        Me.lblTanggalLahir.Text = "Tanggal Lahir"
        Me.lblTanggalLahir.Location = New Point(20, 100)
        Me.lblTanggalLahir.AutoSize = True
        Me.tabDataUtama.Controls.Add(Me.lblTanggalLahir)

        Me.dtpTanggalLahir.Location = New Point(140, 98)
        Me.dtpTanggalLahir.Format = DateTimePickerFormat.Short
        Me.tabDataUtama.Controls.Add(Me.dtpTanggalLahir)

        Me.gbGender.Text = "Jenis Kelamin"
        Me.gbGender.Location = New Point(20, 140)
        Me.gbGender.Size = New Size(260, 60)
        Me.rbMale.Text = "Laki-laki"
        Me.rbMale.Location = New Point(10, 22)
        Me.rbFemale.Text = "Perempuan"
        Me.rbFemale.Location = New Point(120, 22)
        Me.gbGender.Controls.AddRange(New Control() {Me.rbMale, Me.rbFemale})
        Me.tabDataUtama.Controls.Add(Me.gbGender)

        Me.lblKomunitas.Text = "Jenis Komunitas / Divisi"
        Me.lblKomunitas.Location = New Point(20, 220)
        Me.lblKomunitas.AutoSize = True
        Me.tabDataUtama.Controls.Add(Me.lblKomunitas)

        Me.cbKomunitas.Location = New Point(200, 218)
        Me.cbKomunitas.Size = New Size(240, 23)
        Me.cbKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbKomunitas.Items.AddRange(New Object() {"Teknologi", "Seni", "Olahraga", "Relawan", "Pendidikan", "Musik", "Fotografi", "Lainnya"})
        Me.tabDataUtama.Controls.Add(Me.cbKomunitas)

        ' TabKontakInfo layout
        Me.tabKontakInfo.Text = "Kontak & Info"
        Me.tabKontakInfo.Padding = New Padding(10)

        Me.lblPhone.Text = "Nomor Telepon"
        Me.lblPhone.Location = New Point(20, 20)
        Me.lblPhone.AutoSize = True
        Me.tabKontakInfo.Controls.Add(Me.lblPhone)

        Me.mtbPhone.Location = New Point(140, 18)
        Me.mtbPhone.Size = New Size(200, 23)
        Me.mtbPhone.Mask = "+62 000-0000-000"
        Me.tabKontakInfo.Controls.Add(Me.mtbPhone)

        Me.lblEmail.Text = "Email"
        Me.lblEmail.Location = New Point(20, 60)
        Me.lblEmail.AutoSize = True
        Me.tabKontakInfo.Controls.Add(Me.lblEmail)

        Me.txtEmail.Location = New Point(140, 58)
        Me.txtEmail.Size = New Size(300, 23)
        Me.tabKontakInfo.Controls.Add(Me.txtEmail)

        Me.lblAlamat.Text = "Alamat"
        Me.lblAlamat.Location = New Point(20, 100)
        Me.lblAlamat.AutoSize = True
        Me.tabKontakInfo.Controls.Add(Me.lblAlamat)

        Me.txtAlamat.Location = New Point(140, 98)
        Me.txtAlamat.Size = New Size(600, 80)
        Me.txtAlamat.Multiline = True
        Me.tabKontakInfo.Controls.Add(Me.txtAlamat)

        ' TabProfilAktivitas layout
        Me.tabProfilAktivitas.Text = "Profil & Aktivitas"
        Me.tabProfilAktivitas.Padding = New Padding(10)

        Me.pbProfile.Location = New Point(20, 20)
        Me.pbProfile.Size = New Size(160, 180)
        Me.pbProfile.BorderStyle = BorderStyle.FixedSingle
        Me.pbProfile.SizeMode = PictureBoxSizeMode.StretchImage
        Me.tabProfilAktivitas.Controls.Add(Me.pbProfile)

        Me.btnBrowsePhoto.Text = "Browse Photo..."
        Me.btnBrowsePhoto.Location = New Point(200, 20)
        Me.btnBrowsePhoto.Size = New Size(120, 28)
        AddHandler Me.btnBrowsePhoto.Click, AddressOf Me.btnBrowsePhoto_Click
        Me.tabProfilAktivitas.Controls.Add(Me.btnBrowsePhoto)

        Me.gbRoles.Text = "Pilihan Peran"
        Me.gbRoles.Location = New Point(200, 60)
        Me.gbRoles.Size = New Size(260, 100)
        Me.rbKetua.Text = "Ketua"
        Me.rbKetua.Location = New Point(10, 22)
        Me.rbAnggota.Text = "Anggota"
        Me.rbAnggota.Location = New Point(10, 45)
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.Location = New Point(120, 22)
        Me.gbRoles.Controls.AddRange(New Control() {Me.rbKetua, Me.rbAnggota, Me.rbAdmin})
        Me.tabProfilAktivitas.Controls.Add(Me.gbRoles)

        Me.lblHobbies.Text = "Hobby / Aktivitas (pilih beberapa)"
        Me.lblHobbies.Location = New Point(20, 220)
        Me.lblHobbies.AutoSize = True
        Me.tabProfilAktivitas.Controls.Add(Me.lblHobbies)

        Dim startX As Integer = 20
        Dim startY As Integer = 250
        Dim colGap As Integer = 180

        Me.chkH1.Text = "Baca"
        Me.chkH1.Location = New Point(startX, startY)
        Me.chkH2.Text = "Travelling"
        Me.chkH2.Location = New Point(startX + colGap, startY)
        Me.chkH3.Text = "Olahraga"
        Me.chkH3.Location = New Point(startX + (colGap * 2), startY)
        Me.chkH4.Text = "Musik"
        Me.chkH4.Location = New Point(startX, startY + 30)
        Me.chkH5.Text = "Fotografi"
        Me.chkH5.Location = New Point(startX + colGap, startY + 30)
        Me.chkH6.Text = "Coding"
        Me.chkH6.Location = New Point(startX + (colGap * 2), startY + 30)
        Me.chkH7.Text = "Relawan"
        Me.chkH7.Location = New Point(startX, startY + 60)
        Me.chkH8.Text = "Seni"
        Me.chkH8.Location = New Point(startX + colGap, startY + 60)

        Me.tabProfilAktivitas.Controls.AddRange(New Control() {
            Me.chkH1, Me.chkH2, Me.chkH3, Me.chkH4, Me.chkH5, Me.chkH6, Me.chkH7, Me.chkH8})

        ' Save & Cetak button
        Me.btnSavePrint.Text = "Simpan & Cetak Kartu"
        Me.btnSavePrint.Location = New Point(680, 530)
        Me.btnSavePrint.Size = New Size(200, 30)
        AddHandler Me.btnSavePrint.Click, AddressOf Me.btnSavePrint_Click
        Me.Controls.Add(Me.btnSavePrint)

        ' Dialogs
        Me.openPhotoDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
        Me.openDataDialog.Filter = "Data Files|*.txt;*.csv|All Files|*.*"
        Me.saveDataDialog.Filter = "Data Files|*.txt;*.csv|All Files|*.*"
        Me.saveDataDialog.DefaultExt = "txt"

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents menuStripMain As MenuStrip
    Friend WithEvents menuInputData As ToolStripMenuItem
    Friend WithEvents menuViewCard As ToolStripMenuItem
    Friend WithEvents menuSaveData As ToolStripMenuItem
    Friend WithEvents menuOpenData As ToolStripMenuItem
    Friend WithEvents menuExit As ToolStripMenuItem

    Friend WithEvents lblTitle As Label
    Friend WithEvents pbLogo As PictureBox

    Friend WithEvents tabControlMain As TabControl
    Friend WithEvents tabDataUtama As TabPage
    Friend WithEvents tabKontakInfo As TabPage
    Friend WithEvents tabProfilAktivitas As TabPage

    ' Tab1 controls
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents cbKomunitas As ComboBox

    ' Tab2 controls
    Friend WithEvents lblPhone As Label
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox

    ' Tab3 controls
    Friend WithEvents pbProfile As PictureBox
    Friend WithEvents btnBrowsePhoto As Button
    Friend WithEvents gbRoles As GroupBox
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents lblHobbies As Label
    Friend WithEvents chkH1 As CheckBox
    Friend WithEvents chkH2 As CheckBox
    Friend WithEvents chkH3 As CheckBox
    Friend WithEvents chkH4 As CheckBox
    Friend WithEvents chkH5 As CheckBox
    Friend WithEvents chkH6 As CheckBox
    Friend WithEvents chkH7 As CheckBox
    Friend WithEvents chkH8 As CheckBox

    Friend WithEvents btnSavePrint As Button

    Friend WithEvents openPhotoDialog As OpenFileDialog
    Friend WithEvents openDataDialog As OpenFileDialog
    Friend WithEvents saveDataDialog As SaveFileDialog
End Class
