Public Class SpecimentFavoriteForm
    Public Property User As New User()
    Private Sub SpecimentFavoriteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        lvwSpeciments.Items.Clear()
        lvwSpeciments.Columns.Clear()
        lvwSpeciments.Columns.Add("No.")
        lvwSpeciments.Columns.Add("ID")
        lvwSpeciments.Columns.Add("Nama Umum", 200)
        lvwSpeciments.Columns.Add("Nama Ilmiah", 200)
        lvwSpeciments.Columns.Add("Famili", 200)
        lvwSpeciments.Columns.Add("Metode Pengawetan", 250)
        lvwSpeciments.Columns.Add("Ruang Penyimpanan", 250)
        lvwSpeciments.Columns.Add("Deskripsi", 250)
        Dim speciments As List(Of Speciment) = SpecimentRepository.GetFavorite(User.Id)
        Dim ordinal As Integer = 1
        For Each speciment In speciments
            Dim item As New ListViewItem(ordinal.ToString())
            item.SubItems.Add(speciment.Id)
            item.SubItems.Add(speciment.CommonName)
            item.SubItems.Add(speciment.ScientificName)
            item.SubItems.Add(speciment.Family)
            item.SubItems.Add(speciment.PreservationMethod)
            item.SubItems.Add(speciment.CollectionStorageName)
            item.SubItems.Add(speciment.Description)
            lvwSpeciments.Items.Add(item)
            ordinal += 1
        Next
    End Sub
End Class