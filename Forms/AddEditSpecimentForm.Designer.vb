<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditSpecimentForm
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
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        txtNamaIlmiah = New TextBox()
        txtNamaSpesimen = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        txtFamili = New TextBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        Panel3 = New Panel()
        txtDeskripsi = New TextBox()
        btnSimpan = New Button()
        btnBatal = New Button()
        Label4 = New Label()
        btnSave = New Button()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Panel5 = New Panel()
        cbCollectionStorages = New ComboBox()
        Label8 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(31, 52)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(213, 31)
        Label2.TabIndex = 1
        Label2.Text = "Nama Spesimen"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 122)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(165, 31)
        Label3.TabIndex = 2
        Label3.Text = "Nama Ilmiah"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.FlatStyle = FlatStyle.Flat
        Label5.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(31, 26)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 31)
        Label5.TabIndex = 4
        Label5.Text = "Deskripsi"
        ' 
        ' txtNamaIlmiah
        ' 
        txtNamaIlmiah.BorderStyle = BorderStyle.FixedSingle
        txtNamaIlmiah.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaIlmiah.Location = New Point(338, 122)
        txtNamaIlmiah.Margin = New Padding(5, 6, 5, 6)
        txtNamaIlmiah.Name = "txtNamaIlmiah"
        txtNamaIlmiah.Size = New Size(320, 31)
        txtNamaIlmiah.TabIndex = 6
        ' 
        ' txtNamaSpesimen
        ' 
        txtNamaSpesimen.BorderStyle = BorderStyle.FixedSingle
        txtNamaSpesimen.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaSpesimen.Location = New Point(338, 48)
        txtNamaSpesimen.Margin = New Padding(5, 6, 5, 6)
        txtNamaSpesimen.Name = "txtNamaSpesimen"
        txtNamaSpesimen.Size = New Size(320, 31)
        txtNamaSpesimen.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtNamaSpesimen)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtNamaIlmiah)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(37, 24)
        Panel1.Margin = New Padding(5, 6, 5, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(700, 214)
        Panel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(txtFamili)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(37, 276)
        Panel2.Margin = New Padding(5, 6, 5, 6)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(700, 214)
        Panel2.TabIndex = 9
        ' 
        ' txtFamili
        ' 
        txtFamili.BorderStyle = BorderStyle.FixedSingle
        txtFamili.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFamili.Location = New Point(338, 52)
        txtFamili.Margin = New Padding(5, 6, 5, 6)
        txtFamili.Name = "txtFamili"
        txtFamili.Size = New Size(320, 31)
        txtFamili.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(31, 52)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 31)
        Label1.TabIndex = 9
        Label1.Text = "Famili"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(338, 117)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(320, 40)
        ComboBox1.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(31, 120)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(262, 31)
        Label6.TabIndex = 2
        Label6.Text = "Metode Pengawetan"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(txtDeskripsi)
        Panel3.Controls.Add(Label5)
        Panel3.Location = New Point(37, 534)
        Panel3.Margin = New Padding(5, 6, 5, 6)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(700, 476)
        Panel3.TabIndex = 10
        ' 
        ' txtDeskripsi
        ' 
        txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
        txtDeskripsi.Font = New Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDeskripsi.Location = New Point(37, 72)
        txtDeskripsi.Margin = New Padding(5, 6, 5, 6)
        txtDeskripsi.Multiline = True
        txtDeskripsi.Name = "txtDeskripsi"
        txtDeskripsi.Size = New Size(621, 354)
        txtDeskripsi.TabIndex = 8
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Azure
        btnSimpan.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnSimpan.FlatAppearance.BorderSize = 2
        btnSimpan.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(1119, 1062)
        btnSimpan.Margin = New Padding(5, 6, 5, 6)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(182, 78)
        btnSimpan.TabIndex = 15
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.White
        btnBatal.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnBatal.FlatAppearance.BorderSize = 2
        btnBatal.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.Location = New Point(1311, 1062)
        btnBatal.Margin = New Padding(5, 6, 5, 6)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(182, 78)
        btnBatal.TabIndex = 16
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(805, 297)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 31)
        Label4.TabIndex = 17
        Label4.Text = "Gambar"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Azure
        btnSave.FlatAppearance.BorderColor = Color.LightSkyBlue
        btnSave.FlatAppearance.BorderSize = 2
        btnSave.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Microsoft Sans Serif", 9F)
        btnSave.Location = New Point(935, 286)
        btnSave.Margin = New Padding(5, 6, 5, 6)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(232, 56)
        btnSave.TabIndex = 18
        btnSave.Text = "Unggah Gambar"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(793, 354)
        Panel4.Margin = New Padding(5, 6, 5, 6)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(700, 656)
        Panel4.TabIndex = 19
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(140, 169)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(416, 416)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(cbCollectionStorages)
        Panel5.Controls.Add(Label8)
        Panel5.Location = New Point(793, 24)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(700, 214)
        Panel5.TabIndex = 20
        ' 
        ' cbCollectionStorages
        ' 
        cbCollectionStorages.FormattingEnabled = True
        cbCollectionStorages.Location = New Point(338, 87)
        cbCollectionStorages.Name = "cbCollectionStorages"
        cbCollectionStorages.Size = New Size(326, 40)
        cbCollectionStorages.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(40, 87)
        Label8.Name = "Label8"
        Label8.Size = New Size(266, 31)
        Label8.TabIndex = 0
        Label8.Text = "Ruang Penyimpanan"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' AddEditSpecimentForm
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightCyan
        CancelButton = btnBatal
        ClientSize = New Size(1543, 1186)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(btnSave)
        Controls.Add(Label4)
        Controls.Add(btnBatal)
        Controls.Add(btnSimpan)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(5, 6, 5, 6)
        MaximizeBox = False
        MinimizeBox = False
        Name = "AddEditSpecimentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulir Spesimen"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNamaIlmiah As TextBox
    Friend WithEvents txtNamaSpesimen As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtDeskripsi As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txtFamili As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbCollectionStorages As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
