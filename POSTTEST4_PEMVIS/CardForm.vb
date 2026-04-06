Imports System.IO

Public Class CardForm
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Load data into card view
    Public Sub LoadData(nama As String, id As String, komunitas As String, contact As String, hobbies As String, photoPath As String)
        lblCardName.Text = "Nama: " & nama
        lblCardID.Text = "ID: " & id
        lblCardKomunitas.Text = "Komunitas: " & komunitas
        lblCardContact.Text = "Contact: " & contact
        lblCardHobbies.Text = "Hobby: " & If(String.IsNullOrWhiteSpace(hobbies), "-", hobbies.Replace(";", ", "))
        If Not String.IsNullOrWhiteSpace(photoPath) AndAlso File.Exists(photoPath) Then
            Try
                pbCardPhoto.Image = Image.FromFile(photoPath)
            Catch
                pbCardPhoto.Image = Nothing
            End Try
        Else
            pbCardPhoto.Image = Nothing
        End If
    End Sub
End Class