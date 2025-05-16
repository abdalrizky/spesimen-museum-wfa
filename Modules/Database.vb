Imports MySql.Data.MySqlClient

Module Database
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public reader As MySqlDataReader
    Public adapter As MySqlDataAdapter
    Public ds As DataSet
    Public connStr As String
    Sub OpenConnection()
        Try
            connStr = "server=localhost;userid=root;password=;database=spesimen_museum"
            conn = New MySqlConnection(connStr)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub CloseConnection()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module
