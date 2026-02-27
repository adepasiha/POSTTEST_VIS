Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ip As Double

        If Double.TryParse(txtIPSemester.Text, ip) Then

            If ip >= 0 And ip <= 4 Then

                totalIP += ip
                jumlahSemester += 1

                Dim ipk As Double = totalIP / jumlahSemester
                txtIPKumulatif.Text = ipk.ToString("0.00")

                If ipk >= 2.0 And ipk <= 2.75 Then
                    lblPredikat.Text = "cukup"
                ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                    lblPredikat.Text = "Memuaskan"
                ElseIf ipk >= 3.01 Then
                    lblPredikat.Text = "sangat Memuaskan"
                Else
                    lblPredikat.Text = ""
                End If

                txtIPSemester.Clear()
                txtIPSemester.Focus()

            Else
                MessageBox.Show("IP harus antara 0 - 4")
            End If

        Else
            MessageBox.Show("masukan angka yang valid!")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPSemester.Clear()
        txtIPKumulatif.Clear()
        lblPredikat.Text = ""

        txtIPSemester.Focus()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtIPSemester_TextChanged(sender As Object, e As EventArgs) Handles txtIPSemester.TextChanged

    End Sub
End Class