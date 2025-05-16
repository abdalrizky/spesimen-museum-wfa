Public Class CollectionStorageManagementForm
    Dim collectionStorages As List(Of CollectionStorage)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addEditCollectionStorageForm As New AddEditCollectionStorageForm()
        addEditCollectionStorageForm.ShowDialog()
        LoadData()
    End Sub

    Private Sub CollectionStorageManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        lbCollectionStorage.Items.Clear()
        collectionStorages = CollectionStorageRepository.GetCollectionStorages()
        For Each collectionStorage In collectionStorages
            lbCollectionStorage.Items.Add(collectionStorage)
        Next
    End Sub

    Private Sub DeleteCollectionStorage(id As Integer)
        CollectionStorageRepository.Delete(id)
    End Sub

    Private Sub lbCollectionStorage_DoubleClick(sender As Object, e As EventArgs) Handles lbCollectionStorage.DoubleClick
        If lbCollectionStorage.SelectedIndex <> -1 Then
            Dim addEditCollectionStorageForm As New AddEditCollectionStorageForm()
            addEditCollectionStorageForm.CollectionStorage.Id = CType(lbCollectionStorage.SelectedItem, CollectionStorage).Id
            addEditCollectionStorageForm.CollectionStorage.Name = lbCollectionStorage.SelectedItem.ToString()
            addEditCollectionStorageForm.CollectionStorage.Location = CType(lbCollectionStorage.SelectedItem, CollectionStorage).Location
            addEditCollectionStorageForm.IsEditMode = True
            addEditCollectionStorageForm.ShowDialog()
            LoadData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lbCollectionStorage.SelectedIndex <> -1 Then
            Dim collectionStorageId As Integer = CType(lbCollectionStorage.SelectedItem, CollectionStorage).Id
            Dim result As DialogResult = MessageBox.Show("Yakin ingin menghapus ruangan museum ini? Semua spesimen yang terkait dengan ruangan ini akan dihapus. Harap lakukan dengan hati-hati.", "Hapus Ruangan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                DeleteCollectionStorage(collectionStorageId)
                LoadData()
            End If
        End If
    End Sub
End Class