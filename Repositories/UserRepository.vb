Imports MySql.Data.MySqlClient

Public Class UserRepository
    Public Shared Function Login(username As String, password As String) As LoginResult

        Dim loginResult As New LoginResult()

        ' login default admin
        If username = "admin" And password = "admin" Then
            loginResult.Username = username
            loginResult.Role = "admin"
            loginResult.IsLoggedIn = True
            Return loginResult
        End If

        Dim query As String =
            "SELECT c.username, r.name as role_name FROM credentials c
JOIN roles r ON c.role_id = r.id WHERE c.username = @username AND c.password = @password"

        Try
            OpenConnection()
            Dim passwordHashed = Helper.HashPassword(password)
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", passwordHashed)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                LoginResult.Username = reader("username").ToString()
                LoginResult.Role = reader("role_name").ToString()
                LoginResult.IsLoggedIn = True
                Return LoginResult
            End If

            LoginResult.IsLoggedIn = False
            Return LoginResult
        Catch ex As Exception
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function

    Public Shared Function Register(username As String, password As String) As Boolean
        Dim query As String = "INSERT INTO credentials (role_id, username, password) VALUES (3, @username, @password)"

        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", Helper.HashPassword(password))
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Shared Function CheckUsernameExists(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM credentials WHERE username = @username"
        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@username", username)
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            Return False
        Finally
            CloseConnection()
        End Try
    End Function

    Public Shared Function GetUsers() As List(Of User)
        Dim users As New List(Of User)()
        Dim query As String = "SELECT c.id, c.username, r.name as role_name FROM credentials c JOIN roles r ON c.role_id = r.id"
        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                Dim user As New User()
                user.Id = reader("id").ToString()
                user.Username = reader("username").ToString()
                user.Role = reader("role_name").ToString()
                users.Add(user)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            CloseConnection()
        End Try
        Return users
    End Function

    Public Shared Function RegisterBiologist(usernameParam As String, passwordParam As String) As Boolean
        Dim username = $"bio:{usernameParam}"
        Dim password = passwordParam
        Dim query As String = "INSERT INTO credentials (role_id, username, password) VALUES (2, @username, @password)"

        Try
            OpenConnection()
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", Helper.HashPassword(password))
            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
End Class
