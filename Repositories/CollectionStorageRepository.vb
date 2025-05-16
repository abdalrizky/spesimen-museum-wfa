Imports MySql.Data.MySqlClient

Public Class CollectionStorageRepository
    Public Shared Function GetCollectionStorages() As List(Of CollectionStorage)
        Dim query As String = "SELECT * FROM collection_storages"
        Dim result As New List(Of CollectionStorage)()
        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                Dim storage As New CollectionStorage()
                storage.Id = Convert.ToInt32(reader("id"))
                storage.Name = reader("name").ToString()
                storage.Location = reader("location").ToString()
                result.Add(storage)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try

        Return result

    End Function
    Public Shared Function Insert(collectionStorage As CollectionStorage)
        Dim query As String = "INSERT INTO collection_storages (name, location) VALUES (@name, @location)"

        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@name", collectionStorage.Name)
            command.Parameters.AddWithValue("@location", collectionStorage.Location)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Shared Function Edit(collectionStorage As CollectionStorage)
        Dim query As String = "UPDATE collection_storages SET name = @name, location = @location WHERE id = @id"

        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@name", collectionStorage.Name)
            command.Parameters.AddWithValue("@location", collectionStorage.Location)
            command.Parameters.AddWithValue("@id", collectionStorage.Id)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Shared Function Delete(id As Integer) As Boolean
        Dim query As String = "DELETE FROM collection_storages WHERE id = @id"

        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@id", id)

            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        Catch ex As Exception
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
End Class
