Imports MySql.Data.MySqlClient

Public Class SpecimentRepository
    Public Shared Function GetSpeciments() As List(Of Speciment)
        Dim query As String = "SELECT * FROM speciments"
        Dim result As New List(Of Speciment)()
        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim speciment As New Speciment()
                speciment.Id = reader("id").ToString()
                speciment.CommonName = reader("common_name").ToString()
                speciment.ScientificName = reader("scientific_name").ToString()
                speciment.Family = reader("family").ToString()
                speciment.PreservationMethod = reader("preservation_method").ToString()
                speciment.Description = reader("description").ToString()
                speciment.PhotoPath = reader("photo_path").ToString()
                'speciment.CollectionStorageId = reader("collection_storage_id").ToString()
                result.Add(speciment)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try

        Return result
    End Function

    Public Shared Function Insert(speciment As Speciment)
        Dim query As String =
            "INSERT INTO speciments (collection_storage_id, common_name, scientific_name, family, preservation_method, description, photo_path, created_at)
VALUES (7, @common_name, @scientific_name, @family, 'tes', @description, @photo_path, @created_at)"

        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@common_name", speciment.CommonName)
            command.Parameters.AddWithValue("@scientific_name", speciment.ScientificName)
            command.Parameters.AddWithValue("@family", speciment.Family)
            'command.Parameters.AddWithValue("@preservation_method", speciment.PreservationMethod)
            command.Parameters.AddWithValue("@description", speciment.Description)
            command.Parameters.AddWithValue("@photo_path", speciment.PhotoPath)
            command.Parameters.AddWithValue("@created_at", DateTime.Now)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Shared Function Edit(speciment As Speciment)
        Dim query As String = "UPDATE speciments SET common_name = @common_name, scientific_name = @scientific_name, family = @family, preservation_method = @preservation_method, description = @description, photo_path = @photo_path WHERE id = @id"

        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@common_name", speciment.CommonName)
            command.Parameters.AddWithValue("@scientific_name", speciment.ScientificName)
            command.Parameters.AddWithValue("@family", speciment.Family)
            command.Parameters.AddWithValue("@preservation_method", speciment.PreservationMethod)
            command.Parameters.AddWithValue("@description", speciment.Description)
            command.Parameters.AddWithValue("@photo_path", speciment.PhotoPath)
            command.Parameters.AddWithValue("@id", speciment.Id)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
End Class
