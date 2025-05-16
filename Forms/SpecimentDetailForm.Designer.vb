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
        PictureBox1 = New PictureBox()
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
        btnSimpan = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(395, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 372)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 32)
        Label1.TabIndex = 1
        Label1.Text = "Nama Umum"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(63, 446)
        Label2.Name = "Label2"
        Label2.Size = New Size(149, 32)
        Label2.TabIndex = 2
        Label2.Text = "Nama Ilmiah"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 517)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 32)
        Label3.TabIndex = 3
        Label3.Text = "Famili"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(63, 592)
        Label4.Name = "Label4"
        Label4.Size = New Size(234, 32)
        Label4.TabIndex = 4
        Label4.Text = "Metode Pengawetan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(63, 721)
        Label5.Name = "Label5"
        Label5.Size = New Size(110, 32)
        Label5.TabIndex = 5
        Label5.Text = "Deskripsi"
        ' 
        ' txtCommonName
        ' 
        txtCommonName.Enabled = False
        txtCommonName.Location = New Point(417, 372)
        txtCommonName.Name = "txtCommonName"
        txtCommonName.Size = New Size(514, 39)
        txtCommonName.TabIndex = 6
        ' 
        ' txtDescription
        ' 
        txtDescription.Enabled = False
        txtDescription.Location = New Point(63, 756)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(868, 192)
        txtDescription.TabIndex = 7
        txtDescription.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(64, 661)
        Label6.Name = "Label6"
        Label6.Size = New Size(233, 32)
        Label6.TabIndex = 8
        Label6.Text = "Ruang Penyimpanan"
        ' 
        ' txtScientificName
        ' 
        txtScientificName.Enabled = False
        txtScientificName.Location = New Point(417, 443)
        txtScientificName.Name = "txtScientificName"
        txtScientificName.Size = New Size(514, 39)
        txtScientificName.TabIndex = 9
        ' 
        ' txtFamily
        ' 
        txtFamily.Enabled = False
        txtFamily.Location = New Point(417, 517)
        txtFamily.Name = "txtFamily"
        txtFamily.Size = New Size(514, 39)
        txtFamily.TabIndex = 10
        ' 
        ' txtPreservationMethod
        ' 
        txtPreservationMethod.Enabled = False
        txtPreservationMethod.Location = New Point(417, 592)
        txtPreservationMethod.Name = "txtPreservationMethod"
        txtPreservationMethod.Size = New Size(514, 39)
        txtPreservationMethod.TabIndex = 11
        ' 
        ' txtCollectionStorage
        ' 
        txtCollectionStorage.Enabled = False
        txtCollectionStorage.Location = New Point(417, 661)
        txtCollectionStorage.Name = "txtCollectionStorage"
        txtCollectionStorage.Size = New Size(514, 39)
        txtCollectionStorage.TabIndex = 12
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Azure
        btnSimpan.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnSimpan.FlatAppearance.BorderSize = 2
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(747, 36)
        btnSimpan.Margin = New Padding(5, 6, 5, 6)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(224, 78)
        btnSimpan.TabIndex = 16
        btnSimpan.Text = "Difavoritkan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' SpecimentDetailForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        ClientSize = New Size(1020, 1006)
        Controls.Add(btnSimpan)
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
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "SpecimentDetailForm"
        Text = "Detail Spesimen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents btnSimpan As Button
End Class
