Public Class SpecimentDetailForm
    Public Property Speciment As New Speciment()
    Public Property User As User

    Private Sub SpecimentDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCommonName.Text = Speciment.CommonName
        txtScientificName.Text = Speciment.ScientificName
        txtFamily.Text = Speciment.Family
        txtPreservationMethod.Text = Speciment.PreservationMethod
        txtCollectionStorage.Text = Speciment.CollectionStorageName
        txtDescription.Text = Speciment.Description

        If User.Id <> 0 Then
            btnFavorite.Visible = True
        Else
            btnFavorite.Visible = False
        End If
    End Sub
End Class