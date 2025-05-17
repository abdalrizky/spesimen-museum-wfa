Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SpecimentManagementForm
    Private Sub SpecimentManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addEditSpecimentForm As New AddEditSpecimentForm()
        addEditSpecimentForm.Text = "Tambah Spesimen"
        addEditSpecimentForm.ShowDialog()
        LoadData()
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

            Dim addEditSpecimentForm As New AddEditSpecimentForm()
            addEditSpecimentForm.Text = "Edit Spesimen"
            addEditSpecimentForm.Speciment = speciment
            addEditSpecimentForm.IsEditMode = True
            addEditSpecimentForm.ShowDialog()
            LoadData()
        End If
    End Sub

    Private printFont As New Font("Arial", 10)
    Private currentY As Integer = 0

    Private Sub PrintDocument1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        currentY = 0
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim pageWidth As Integer = e.MarginBounds.Width
        Dim cellHeight As Integer = 25
        Dim colWidths(lvwSpeciments.Columns.Count - 1) As Integer

        ' Atur lebar kolom: kolom pertama kecil, sisanya standar
        colWidths(0) = 50
        For i = 1 To colWidths.Length - 1
            colWidths(i) = 100
        Next

        currentY = e.MarginBounds.Top

        ' === JUDUL TENGAH ===
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim titleText As String = "Data Spesimen"
        Dim titleSize As SizeF = g.MeasureString(titleText, titleFont)
        Dim titleX As Integer = leftMargin + (pageWidth - titleSize.Width) / 2
        g.DrawString(titleText, titleFont, Brushes.Black, titleX, currentY)
        currentY += CInt(titleSize.Height + 20)

        ' === HEADER TABEL ===
        Dim x As Integer = leftMargin
        For i = 0 To lvwSpeciments.Columns.Count - 1
            ' Gambar kotak header
            g.DrawRectangle(Pens.Black, x, currentY, colWidths(i), cellHeight)
            ' Gambar teks header
            g.DrawString(lvwSpeciments.Columns(i).Text, printFont, Brushes.Black, x + 5, currentY + 5)
            x += colWidths(i)
        Next
        currentY += cellHeight

        ' === ISI DATA ===
        For Each item As ListViewItem In lvwSpeciments.Items
            x = leftMargin
            For i = 0 To lvwSpeciments.Columns.Count - 1
                Dim cellText As String = If(i = 0, item.Text, item.SubItems(i).Text)
                g.DrawRectangle(Pens.Black, x, currentY, colWidths(i), cellHeight)
                g.DrawString(cellText, printFont, Brushes.Black, x + 5, currentY + 5)
                x += colWidths(i)
            Next
            currentY += cellHeight
        Next

        e.HasMorePages = False
    End Sub

    Private Sub btnPrintSpecimentList_Click(sender As Object, e As EventArgs) Handles btnPrintSpecimentList.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class