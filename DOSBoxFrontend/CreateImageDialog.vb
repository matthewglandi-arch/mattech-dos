Imports System.IO
Imports System.Windows.Forms

''' <summary>Simple dialog for creating a blank floppy image.</summary>
Public Class CreateImageDialog
    Inherits Form

    Public Property OutputPath As String = ""
    Public Property SizeBytes As Long = 1474560

    Private WithEvents CmbSize As New ComboBox()
    Private WithEvents TxtPath As New TextBox()
    Private WithEvents BtnBrowse As New Button()
    Private WithEvents BtnOK As New Button()
    Private WithEvents BtnCancel As New Button()

    Public Sub New()
        Me.Text = "Create Blank Floppy Image"
        Me.Size = New System.Drawing.Size(480, 200)
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.StartPosition = FormStartPosition.CenterParent
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Font = New System.Drawing.Font("Segoe UI", 9)

        Dim lblSize As New Label() With {.Text = "Floppy Size:", .Location = New System.Drawing.Point(12, 18), .AutoSize = True}
        CmbSize.Location = New System.Drawing.Point(110, 15)
        CmbSize.Size = New System.Drawing.Size(200, 23)
        CmbSize.DropDownStyle = ComboBoxStyle.DropDownList
        CmbSize.Items.AddRange(New Object() {
            "1.44 MB  (1,474,560 bytes)",
            "1.2 MB   (1,228,800 bytes)",
            "720 KB   (737,280 bytes)",
            "360 KB   (368,640 bytes)"})
        CmbSize.SelectedIndex = 0

        Dim lblPath As New Label() With {.Text = "Save As:", .Location = New System.Drawing.Point(12, 58), .AutoSize = True}
        TxtPath.Location = New System.Drawing.Point(110, 55)
        TxtPath.Size = New System.Drawing.Size(240, 23)

        BtnBrowse.Text = "Browse..."
        BtnBrowse.Location = New System.Drawing.Point(358, 53)
        BtnBrowse.Size = New System.Drawing.Size(90, 27)

        BtnOK.Text = "Create"
        BtnOK.Location = New System.Drawing.Point(110, 110)
        BtnOK.Size = New System.Drawing.Size(100, 30)
        BtnOK.DialogResult = DialogResult.None

        BtnCancel.Text = "Cancel"
        BtnCancel.Location = New System.Drawing.Point(220, 110)
        BtnCancel.Size = New System.Drawing.Size(80, 30)
        BtnCancel.DialogResult = DialogResult.Cancel

        Me.Controls.AddRange(New Control() {lblSize, CmbSize, lblPath, TxtPath, BtnBrowse, BtnOK, BtnCancel})
        Me.AcceptButton = BtnOK
        Me.CancelButton = BtnCancel
    End Sub

    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Using sfd As New SaveFileDialog()
            sfd.Title = "Save Floppy Image As"
            sfd.Filter = "Floppy Image (*.img)|*.img|All Files (*.*)|*.*"
            sfd.DefaultExt = "img"
            sfd.FileName = "floppy.img"
            If sfd.ShowDialog() = DialogResult.OK Then
                TxtPath.Text = sfd.FileName
            End If
        End Using
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If String.IsNullOrWhiteSpace(TxtPath.Text) Then
            MessageBox.Show("Please choose a save location.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        OutputPath = TxtPath.Text.Trim()
        Select Case CmbSize.SelectedIndex
            Case 0 : SizeBytes = 1474560
            Case 1 : SizeBytes = 1228800
            Case 2 : SizeBytes = 737280
            Case 3 : SizeBytes = 368640
            Case Else : SizeBytes = 1474560
        End Select
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class
