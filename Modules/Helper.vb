Imports System.Security.Cryptography
Imports System.Text

Public Class Helper
    Public Shared Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function
End Class
