Public Class AddEditCollectionStorageForm
    Public Property IsEditMode As Boolean
    Public Property CollectionStorage As New CollectionStorage()

    Private Sub InsertCollectionStorage(collectionStorage As CollectionStorage)
        CollectionStorageRepository.Insert(collectionStorage)
    End Sub

    Private Sub EditCollectionStorage(collectionStorage As CollectionStorage)
        CollectionStorageRepository.Edit(collectionStorage)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim storageName = txtStorageName.Text
        Dim storageLocation = txtStorageLocation.Text

        If storageName = "" Or storageLocation = "" Then
            MessageBox.Show("Harus diisi semua", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim collectionStorageObj As New CollectionStorage()
        collectionStorageObj.Name = storageName
        collectionStorageObj.Location = storageLocation

        If Not IsEditMode Then
            InsertCollectionStorage(collectionStorageObj)
        Else
            collectionStorageObj.Id = CollectionStorage.Id
            EditCollectionStorage(collectionStorageObj)
        End If

        Me.Close()
    End Sub

    Private Sub AddEditCollectionStorageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEditMode Then
            txtStorageName.Text = CollectionStorage.Name
            txtStorageLocation.Text = CollectionStorage.Location
        End If
    End Sub
End Class