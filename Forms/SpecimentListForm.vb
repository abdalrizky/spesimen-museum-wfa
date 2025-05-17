Public Class SpecimentListForm
    Public Property User As New User()
    Private Sub timerNowTime_Tick(sender As Object, e As EventArgs) Handles timerNowTime.Tick
        lblNowTime.Text = DateTime.Now.ToString("HH.mm.ss WITA")
    End Sub

    Private Sub GuestHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNowTime.Text = DateTime.Now.ToString("HH.mm.ss WITA")
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
        Dim speciments As List(Of Speciment) = SpecimentRepository.GetSpeciments()
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

    Private Sub lvwSpeciments_DoubleClick(sender As Object, e As EventArgs) Handles lvwSpeciments.DoubleClick
        If lvwSpeciments.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvwSpeciments.SelectedItems(0)
            Dim specimentId As Integer = Integer.Parse(selectedItem.SubItems(1).Text)

            Dim speciment As New Speciment()
            speciment.Id = specimentId
            speciment.CommonName = selectedItem.SubItems(2).Text
            speciment.ScientificName = selectedItem.SubItems(3).Text
            speciment.Family = selectedItem.SubItems(4).Text
            speciment.PreservationMethod = selectedItem.SubItems(5).Text
            speciment.CollectionStorageName = selectedItem.SubItems(6).Text
            speciment.Description = selectedItem.SubItems(7).Text

            Dim specimentDetailForm As New SpecimentDetailForm()
            specimentDetailForm.Speciment = speciment
            specimentDetailForm.User = Me.User
            specimentDetailForm.ShowDialog()
            LoadData()
        End If
    End Sub

End Class