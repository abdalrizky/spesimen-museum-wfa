<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpecimentDetailForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtCommonName = New TextBox()
        txtDescription = New RichTextBox()
        Label6 = New Label()
        txtScientificName = New TextBox()
        txtFamily = New TextBox()
        txtPreservationMethod = New TextBox()
        txtCollectionStorage = New TextBox()
        btnFavorite = New Button()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(67, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 32)
        Label1.TabIndex = 1
        Label1.Text = "Nama Umum"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 32)
        Label2.TabIndex = 2
        Label2.Text = "Nama Ilmiah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(67, 333)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 32)
        Label3.TabIndex = 3
        Label3.Text = "Famili"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(67, 408)
        Label4.Name = "Label4"
        Label4.Size = New Size(234, 32)
        Label4.TabIndex = 4
        Label4.Text = "Metode Pengawetan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(67, 537)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 32)
        Label5.TabIndex = 5
        Label5.Text = "Deskripsi"
        ' 
        ' txtCommonName
        ' 
        txtCommonName.BackColor = Color.Azure
        txtCommonName.BorderStyle = BorderStyle.None
        txtCommonName.Location = New Point(421, 188)
        txtCommonName.Name = "txtCommonName"
        txtCommonName.ReadOnly = True
        txtCommonName.Size = New Size(514, 32)
        txtCommonName.TabIndex = 6
        ' 
        ' txtDescription
        ' 
        txtDescription.BackColor = Color.Azure
        txtDescription.BorderStyle = BorderStyle.None
        txtDescription.Location = New Point(67, 572)
        txtDescription.Name = "txtDescription"
        txtDescription.ReadOnly = True
        txtDescription.Size = New Size(868, 192)
        txtDescription.TabIndex = 7
        txtDescription.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(68, 477)
        Label6.Name = "Label6"
        Label6.Size = New Size(233, 32)
        Label6.TabIndex = 8
        Label6.Text = "Ruang Penyimpanan"
        ' 
        ' txtScientificName
        ' 
        txtScientificName.BackColor = Color.Azure
        txtScientificName.BorderStyle = BorderStyle.None
        txtScientificName.Location = New Point(421, 259)
        txtScientificName.Name = "txtScientificName"
        txtScientificName.ReadOnly = True
        txtScientificName.Size = New Size(514, 32)
        txtScientificName.TabIndex = 9
        ' 
        ' txtFamily
        ' 
        txtFamily.BackColor = Color.Azure
        txtFamily.BorderStyle = BorderStyle.None
        txtFamily.Location = New Point(421, 333)
        txtFamily.Name = "txtFamily"
        txtFamily.ReadOnly = True
        txtFamily.Size = New Size(514, 32)
        txtFamily.TabIndex = 10
        ' 
        ' txtPreservationMethod
        ' 
        txtPreservationMethod.BackColor = Color.Azure
        txtPreservationMethod.BorderStyle = BorderStyle.None
        txtPreservationMethod.Location = New Point(421, 408)
        txtPreservationMethod.Name = "txtPreservationMethod"
        txtPreservationMethod.ReadOnly = True
        txtPreservationMethod.Size = New Size(514, 32)
        txtPreservationMethod.TabIndex = 11
        ' 
        ' txtCollectionStorage
        ' 
        txtCollectionStorage.BackColor = Color.Azure
        txtCollectionStorage.BorderStyle = BorderStyle.None
        txtCollectionStorage.Location = New Point(421, 477)
        txtCollectionStorage.Name = "txtCollectionStorage"
        txtCollectionStorage.ReadOnly = True
        txtCollectionStorage.Size = New Size(514, 32)
        txtCollectionStorage.TabIndex = 12
        ' 
        ' btnFavorite
        ' 
        btnFavorite.BackColor = Color.Azure
        btnFavorite.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnFavorite.FlatAppearance.BorderSize = 2
        btnFavorite.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnFavorite.FlatStyle = FlatStyle.Flat
        btnFavorite.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFavorite.Location = New Point(601, 53)
        btnFavorite.Margin = New Padding(5, 6, 5, 6)
        btnFavorite.Name = "btnFavorite"
        btnFavorite.Size = New Size(334, 78)
        btnFavorite.TabIndex = 16
        btnFavorite.Text = "Hapus dari Favorit"
        btnFavorite.UseVisualStyleBackColor = False
        btnFavorite.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14F)
        Label7.Location = New Point(67, 63)
        Label7.Name = "Label7"
        Label7.Size = New Size(291, 51)
        Label7.TabIndex = 17
        Label7.Text = "Detail Spesimen"
        ' 
        ' SpecimentDetailForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1012, 822)
        Controls.Add(Label7)
        Controls.Add(btnFavorite)
        Controls.Add(txtCollectionStorage)
        Controls.Add(txtPreservationMethod)
        Controls.Add(txtFamily)
        Controls.Add(txtScientificName)
        Controls.Add(Label6)
        Controls.Add(txtDescription)
        Controls.Add(txtCommonName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "SpecimentDetailForm"
        Text = "Detail Spesimen"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCommonName As TextBox
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtScientificName As TextBox
    Friend WithEvents txtFamily As TextBox
    Friend WithEvents txtPreservationMethod As TextBox
    Friend WithEvents txtCollectionStorage As TextBox
    Friend WithEvents btnFavorite As Button
    Friend WithEvents Label7 As Label
End Class
