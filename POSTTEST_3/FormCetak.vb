Public Class FormCetak
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Dim buka As New OpenFileDialog

        buka.Filter = "Image Files|*.jpg;*.png;*.jpeg"

        If buka.ShowDialog = DialogResult.OK Then
            picFoto.Image = Image.FromFile(buka.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong")
            Exit Sub
        End If

        If Not rbLaki.Checked And Not rbPerempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin")
            Exit Sub
        End If

        Dim hobbyDipilih As Boolean = False

        For Each ctrl As Control In GrpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hobbyDipilih = True
                End If
            End If
        Next

        If hobbyDipilih = False Then
            MessageBox.Show("Pilih minimal satu hobby")
            Exit Sub
        End If



        Dim hobby As String = ""

        For Each ctrl As Control In GrpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                If CType(ctrl, CheckBox).Checked Then
                    hobby &= ctrl.Text & ", "
                End If
            End If
        Next

        Dim formHasil As New FormHasil

        formHasil.lblNama.Text = txtNama.Text
        formHasil.lblUmur.Text = txtUmur.Text
        formHasil.lblTelepon.Text = txtTelepon.Text
        formHasil.lblAlamat.Text = txtAlamat.Text
        formHasil.lblTanggal.Text = dtTanggalLAhir.Value.ToShortDateString()
        formHasil.lblHobby.Text = hobby

        If rbLaki.Checked Then
            formHasil.lblGender.Text = "Laki-Laki"
        Else
            formHasil.lblGender.Text = "Perempuan"
        End If

        formHasil.picFotoHasil.Image = picFoto.Image

        formHasil.Show()

    End Sub
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbMemasak_CheckedChanged(sender As Object, e As EventArgs) Handles cbMemasak.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rbPerempuan_CheckedChanged(sender As Object, e As EventArgs) Handles rbPerempuan.CheckedChanged

    End Sub
End Class