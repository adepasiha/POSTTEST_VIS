Imports System.IO
Imports System.Text

Public Class Form1

    Public Sub New()
        InitializeComponent()
        ' Optionally set a default logo if available
        ' pbLogo.Image = Image.FromFile("path\to\logo.png")
    End Sub

    Private Sub menuInputData_Click(sender As Object, e As EventArgs)
        ' Focus to first tab and Nama
        tabControlMain.SelectedIndex = 0
        txtNama.Focus()
    End Sub

    Private Sub menuViewCard_Click(sender As Object, e As EventArgs)
        Dim card As New CardForm()
        card.LoadData(GetNama(), GetID(), GetKomunitas(), GetContact(), GetHobbies(), pbProfile.Tag?.ToString())
        card.ShowDialog()
    End Sub

    Private Sub menuSaveData_Click(sender As Object, e As EventArgs)
        SaveDataToFileInteractive()
    End Sub

    Private Sub menuOpenData_Click(sender As Object, e As EventArgs)
        If openDataDialog.ShowDialog() = DialogResult.OK Then
            Try
                LoadDataFromFile(openDataDialog.FileName)
                MessageBox.Show("Data berhasil dibuka.", "Buka Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal membuka data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub menuExit_Click(sender As Object, e As EventArgs)
        Dim dr = MessageBox.Show("Keluar aplikasi? Semua perubahan yang belum disimpan akan hilang.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dr = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBrowsePhoto_Click(sender As Object, e As EventArgs)
        If openPhotoDialog.ShowDialog() = DialogResult.OK Then
            Try
                pbProfile.Image = Image.FromFile(openPhotoDialog.FileName)
                pbProfile.Tag = openPhotoDialog.FileName ' simpan path di Tag
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs)
        ' Ask to save data first
        Dim saveFirst = MessageBox.Show("Simpan data sebelum mencetak?", "Simpan Data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If saveFirst = DialogResult.Cancel Then Return
        If saveFirst = DialogResult.Yes Then
            If Not SaveDataToFileInteractive() Then
                Return
            End If
        End If

        ' Confirm print (here we just show the CardForm and a print confirmation dialog)
        Dim printConfirm = MessageBox.Show("Cetak kartu sekarang?", "Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If printConfirm = DialogResult.Yes Then
            Dim card As New CardForm()
            card.LoadData(GetNama(), GetID(), GetKomunitas(), GetContact(), GetHobbies(), pbProfile.Tag?.ToString())
            ' In real app: implement printing. Here show preview/dialog.
            card.ShowDialog()
            MessageBox.Show("(Simulasi) Kartu dikirim ke printer.", "Cetak", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Helpers to gather data
    Private Function GetNama() As String
        Return txtNama.Text.Trim()
    End Function

    Private Function GetID() As String
        Return txtID.Text.Trim()
    End Function

    Private Function GetKomunitas() As String
        Return If(cbKomunitas.SelectedItem IsNot Nothing, cbKomunitas.SelectedItem.ToString(), "")
    End Function

    Private Function GetGender() As String
        If rbMale.Checked Then Return "Laki-laki"
        If rbFemale.Checked Then Return "Perempuan"
        Return ""
    End Function

    Private Function GetContact() As String
        Dim sb As New StringBuilder()
        sb.AppendLine("Tel: " & mtbPhone.Text)
        sb.AppendLine("Email: " & txtEmail.Text)
        sb.AppendLine("Alamat: " & txtAlamat.Text)
        Return sb.ToString().Trim()
    End Function

    Private Function GetRole() As String
        If rbKetua.Checked Then Return "Ketua"
        If rbAnggota.Checked Then Return "Anggota"
        If rbAdmin.Checked Then Return "Admin"
        Return ""
    End Function

    Private Function GetHobbies() As String
        Dim list As New List(Of String)()
        For Each chk In New CheckBox() {chkH1, chkH2, chkH3, chkH4, chkH5, chkH6, chkH7, chkH8}
            If chk.Checked Then list.Add(chk.Text)
        Next
        Return String.Join(";", list)
    End Function

    ' Save data interactive
    Private Function SaveDataToFileInteractive() As Boolean
        If saveDataDialog.ShowDialog() = DialogResult.OK Then
            Try
                SaveDataToFile(saveDataDialog.FileName)
                MessageBox.Show("Data berhasil disimpan.", "Simpan Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            Catch ex As Exception
                MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If
        Return False
    End Function

    ' Save data (pipe-delimited single line)
    Private Sub SaveDataToFile(filePath As String)
        Dim fields As New List(Of String)()
        fields.Add(GetNama())
        fields.Add(GetID())
        fields.Add(dtpTanggalLahir.Value.ToShortDateString())
        fields.Add(GetGender())
        fields.Add(GetKomunitas())
        fields.Add(mtbPhone.Text)
        fields.Add(txtEmail.Text)
        fields.Add(txtAlamat.Text.Replace(vbCrLf, " ")) ' normalize
        fields.Add(GetRole())
        fields.Add(GetHobbies())
        fields.Add(If(pbProfile.Tag IsNot Nothing, pbProfile.Tag.ToString(), ""))

        Dim line = String.Join("|", fields)
        File.WriteAllText(filePath, line, Encoding.UTF8)
    End Sub

    Private Sub LoadDataFromFile(filePath As String)
        Dim content = File.ReadAllText(filePath, Encoding.UTF8).Trim()
        If String.IsNullOrWhiteSpace(content) Then Throw New Exception("File kosong.")
        Dim parts As String() = content.Split("|"c)
        ' Expecting 11 parts as saved above
        If parts.Length < 11 Then Throw New Exception("Format file tidak sesuai.")

        txtNama.Text = parts(0)
        txtID.Text = parts(1)
        Dim parsedDate As DateTime
        If DateTime.TryParse(parts(2), parsedDate) Then dtpTanggalLahir.Value = parsedDate
        Dim gender = parts(3)
        rbMale.Checked = (gender = "Laki-laki")
        rbFemale.Checked = (gender = "Perempuan")
        Dim komunitas = parts(4)
        If cbKomunitas.Items.Contains(komunitas) Then cbKomunitas.SelectedItem = komunitas Else cbKomunitas.Text = komunitas
        mtbPhone.Text = parts(5)
        txtEmail.Text = parts(6)
        txtAlamat.Text = parts(7)
        Dim role = parts(8)
        rbKetua.Checked = (role = "Ketua")
        rbAnggota.Checked = (role = "Anggota")
        rbAdmin.Checked = (role = "Admin")
        Dim hobbies = parts(9).Split(";"c)
        For Each chk In New CheckBox() {chkH1, chkH2, chkH3, chkH4, chkH5, chkH6, chkH7, chkH8}
            chk.Checked = hobbies.Contains(chk.Text)
        Next
        Dim photoPath = parts(10)
        If Not String.IsNullOrWhiteSpace(photoPath) AndAlso File.Exists(photoPath) Then
            Try
                pbProfile.Image = Image.FromFile(photoPath)
                pbProfile.Tag = photoPath
            Catch
                pbProfile.Image = Nothing
                pbProfile.Tag = Nothing
            End Try
        Else
            pbProfile.Image = Nothing
            pbProfile.Tag = Nothing
        End If
    End Sub
End Class
