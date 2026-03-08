Public Class Form1

    'PROCEDURE TAMBAH BUKU (BYVAL)
    Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        ModuleBuku.judulBuku(jumlah) = judul
        genreBuku(jumlah) = genre
        jumlah += 1

    End Sub


    'FUNCTION CARI INDEX BUKU
    Function CariBuku(ByVal judul As String) As Integer

        For i As Integer = 0 To jumlah - 1
            If ModuleBuku.judulBuku(i).ToLower = judul.ToLower Then
                Return i
            End If
        Next

        Return -1

    End Function


    'PROCEDURE TAMPILKAN LIST
    Sub TampilkanBuku()

        ListBox1.Items.Clear()

        For i As Integer = 0 To jumlah - 1
            ListBox1.Items.Add(ModuleBuku.judulBuku(i) & " (" & genreBuku(i) & ")")
        Next

    End Sub


    'BUTTON TAMBAH
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        TambahBuku(txtJudul.Text, txtGenre.Text)

        TampilkanBuku()

        txtJudul.Clear()
        txtGenre.Clear()

    End Sub


    'BUTTON HAPUS
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim index As Integer

        index = CariBuku(txtHapus.Text)

        If index = -1 Then
            MsgBox("Buku tidak ditemukan")
        Else

            For i As Integer = index To jumlah - 2
                ModuleBuku.judulBuku(i) = ModuleBuku.judulBuku(i + 1)
                genreBuku(i) = genreBuku(i + 1)
            Next

            jumlah -= 1

            TampilkanBuku()

        End If

        txtHapus.Clear()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class