Public Class AddEditSpecimentForm
    Public Property IsEditMode As Boolean
    Public Property Speciment As New Speciment()

    Private Sub AddEditSpecimentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsEditMode Then
            txtNamaSpesimen.Text = Speciment.CommonName
            txtNamaIlmiah.Text = Speciment.ScientificName
            txtFamili.Text = Speciment.Family
            txtDeskripsi.Text = Speciment.Description
        End If
    End Sub

    Private Sub InsertSpeciment(speciment As Speciment)
        SpecimentRepository.Insert(speciment)
    End Sub

    Private Sub EditSpeciment(speciment As Speciment)
        SpecimentRepository.Edit(speciment)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim commonName = txtNamaSpesimen.Text
        Dim scientificName = txtNamaIlmiah.Text
        Dim family = txtFamili.Text
        Dim description = txtDeskripsi.Text

        Dim specimentObj As New Speciment()
        specimentObj.CommonName = commonName
        specimentObj.ScientificName = scientificName
        specimentObj.Family = family
        specimentObj.Description = description

        If Not IsEditMode Then
            InsertSpeciment(specimentObj)
            Me.Close()
        Else
            specimentObj.Id = Speciment.Id
            EditSpeciment(specimentObj)
        End If
    End Sub
End Class