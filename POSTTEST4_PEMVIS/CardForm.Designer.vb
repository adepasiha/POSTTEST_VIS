<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CardForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private pbCardPhoto As PictureBox
    Private lblCardName As Label
    Private lblCardID As Label
    Private lblCardKomunitas As Label
    Private lblCardContact As Label
    Private lblCardHobbies As Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pbCardPhoto = New PictureBox()
        Me.lblCardName = New Label()
        Me.lblCardID = New Label()
        Me.lblCardKomunitas = New Label()
        Me.lblCardContact = New Label()
        Me.lblCardHobbies = New Label()

        Me.SuspendLayout()
        Me.ClientSize = New Size(420, 260)
        Me.Text = "Kartu Komunitas - Preview"

        Me.pbCardPhoto.Location = New Point(20, 20)
        Me.pbCardPhoto.Size = New Size(120, 160)
        Me.pbCardPhoto.BorderStyle = BorderStyle.FixedSingle
        Me.pbCardPhoto.SizeMode = PictureBoxSizeMode.StretchImage
        Me.Controls.Add(Me.pbCardPhoto)

        Me.lblCardName.Location = New Point(160, 20)
        Me.lblCardName.AutoSize = True
        Me.lblCardName.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Me.lblCardName.Text = "Nama: "
        Me.Controls.Add(Me.lblCardName)

        Me.lblCardID.Location = New Point(160, 55)
        Me.lblCardID.AutoSize = True
        Me.lblCardID.Text = "ID: "
        Me.Controls.Add(Me.lblCardID)

        Me.lblCardKomunitas.Location = New Point(160, 85)
        Me.lblCardKomunitas.AutoSize = True
        Me.lblCardKomunitas.Text = "Komunitas: "
        Me.Controls.Add(Me.lblCardKomunitas)

        Me.lblCardContact.Location = New Point(160, 115)
        Me.lblCardContact.AutoSize = True
        Me.lblCardContact.Size = New Size(240, 40)
        Me.lblCardContact.Text = "Contact: "
        Me.Controls.Add(Me.lblCardContact)

        Me.lblCardHobbies.Location = New Point(160, 155)
        Me.lblCardHobbies.AutoSize = True
        Me.lblCardHobbies.Text = "Hobby: "
        Me.Controls.Add(Me.lblCardHobbies)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
End Class