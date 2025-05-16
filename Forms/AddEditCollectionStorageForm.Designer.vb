<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditCollectionStorageForm
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
        txtStorageName = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtStorageLocation = New TextBox()
        btnCancel = New Button()
        btnSave = New Button()
        SuspendLayout()
        ' 
        ' txtStorageName
        ' 
        txtStorageName.Location = New Point(47, 86)
        txtStorageName.Name = "txtStorageName"
        txtStorageName.Size = New Size(636, 39)
        txtStorageName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 32)
        Label1.TabIndex = 1
        Label1.Text = "Nama Ruangan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(47, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 32)
        Label2.TabIndex = 3
        Label2.Text = "Lokasi"
        ' 
        ' txtStorageLocation
        ' 
        txtStorageLocation.Location = New Point(47, 200)
        txtStorageLocation.Name = "txtStorageLocation"
        txtStorageLocation.Size = New Size(636, 39)
        txtStorageLocation.TabIndex = 2
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnCancel.FlatAppearance.BorderSize = 2
        btnCancel.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Microsoft Sans Serif", 9F)
        btnCancel.Location = New Point(509, 280)
        btnCancel.Margin = New Padding(5, 6, 5, 6)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(174, 56)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Batal"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Azure
        btnSave.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Microsoft Sans Serif", 9F)
        btnSave.Location = New Point(325, 280)
        btnSave.Margin = New Padding(5, 6, 5, 6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(174, 56)
        btnSave.TabIndex = 11
        btnSave.Text = "Simpan"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' AddEditCollectionStorageForm
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        CancelButton = btnCancel
        ClientSize = New Size(730, 382)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(Label2)
        Controls.Add(txtStorageLocation)
        Controls.Add(Label1)
        Controls.Add(txtStorageName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEditCollectionStorageForm"
        Text = "Ruang Penyimpanan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStorageName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStorageLocation As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
