<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollectionStorageManagementForm
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
        lbCollectionStorage = New ListBox()
        btnDelete = New Button()
        btnAdd = New Button()
        SuspendLayout()
        ' 
        ' lbCollectionStorage
        ' 
        lbCollectionStorage.FormattingEnabled = True
        lbCollectionStorage.Location = New Point(47, 52)
        lbCollectionStorage.Name = "lbCollectionStorage"
        lbCollectionStorage.Size = New Size(458, 740)
        lbCollectionStorage.TabIndex = 0
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Azure
        btnDelete.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnDelete.FlatAppearance.BorderSize = 2
        btnDelete.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Microsoft Sans Serif", 9F)
        btnDelete.Location = New Point(529, 170)
        btnDelete.Margin = New Padding(5, 6, 5, 6)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(174, 56)
        btnDelete.TabIndex = 8
        btnDelete.Text = "Hapus"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Azure
        btnAdd.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnAdd.FlatAppearance.BorderSize = 2
        btnAdd.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.Font = New Font("Microsoft Sans Serif", 9F)
        btnAdd.Location = New Point(529, 88)
        btnAdd.Margin = New Padding(5, 6, 5, 6)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(174, 56)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Tambah"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' CollectionStorageManagementForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(740, 860)
        Controls.Add(btnAdd)
        Controls.Add(btnDelete)
        Controls.Add(lbCollectionStorage)
        Name = "CollectionStorageManagementForm"
        Text = "Manajemen Ruang Penyimpanan"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbCollectionStorage As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
End Class
