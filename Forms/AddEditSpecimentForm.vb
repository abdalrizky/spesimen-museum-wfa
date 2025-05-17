Public Class AddEditSpecimentForm
    Public Property IsEditMode As Boolean
    Public Property Speciment As New Speciment()

    Private Sub AddEditSpecimentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCollectionStorageComboBoxItem()
        If IsEditMode Then
            txtNamaSpesimen.Text = Speciment.CommonName
            txtNamaIlmiah.Text = Speciment.ScientificName
            txtFamili.Text = Speciment.Family
            cbMetodePengawetan.Text = Speciment.PreservationMethod
            cbRuangPenyimpanan.Text = Speciment.CollectionStorageName
            txtDeskripsi.Text = Speciment.Description
            btnHapus.Visible = True
        End If
    End Sub

    Private Sub LoadCollectionStorageComboBoxItem()
        Dim collectionStorages = CollectionStorageRepository.GetCollectionStorages()
        For Each collectionStorage In collectionStorages
            cbRuangPenyimpanan.Items.Add(collectionStorage.Name)
        Next
    End Sub

    Private Sub InsertSpeciment(speciment As Speciment)
        SpecimentRepository.Insert(speciment)
    End Sub

    Private Sub EditSpeciment(speciment As Speciment)
        SpecimentRepository.Edit(speciment)
    End Sub

    Private Sub DeleteSpeciment(id As Integer)
        SpecimentRepository.Delete(id)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim commonName = txtNamaSpesimen.Text
        Dim scientificName = txtNamaIlmiah.Text
        Dim family = txtFamili.Text
        Dim preservationMethod = cbMetodePengawetan.Text
        Dim description = txtDeskripsi.Text
        Dim collectionStorageName = cbRuangPenyimpanan.Text

        Dim specimentObj As New Speciment()
        specimentObj.CommonName = commonName
        specimentObj.ScientificName = scientificName
        specimentObj.Family = family
        specimentObj.PreservationMethod = preservationMethod
        specimentObj.Description = description
        specimentObj.CollectionStorageName = collectionStorageName

        If Not IsEditMode Then
            InsertSpeciment(specimentObj)
            Me.Close()
        Else
            specimentObj.Id = Speciment.Id
            EditSpeciment(specimentObj)
            Me.Close()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus spesimen museum ini? Harap lakukan dengan hati-hati.", "Hapus Ruangan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            DeleteSpeciment(Speciment.Id)
            Me.Close()
        End If
    End Sub

    Private Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click

        Dim ofd As New OpenFileDialog()

        ' Filter agar hanya file gambar yang bisa dipilih
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If ofd.ShowDialog() = DialogResult.OK Then
            ' Load gambar ke PictureBox dari file yang dipilih
            PictureBox1.Image = Image.FromFile(ofd.FileName)

            ' Optional: atur mode tampil gambar supaya proporsional
            PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        End If
    End Sub
End Class