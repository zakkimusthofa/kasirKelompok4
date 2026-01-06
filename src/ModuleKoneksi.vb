Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Rd As MySqlDataReader

    Public UserSedangLogin As String = ""
    Public LevelUser As String = ""

    Public Sub Koneksi()
        Try
            Conn = New MySqlConnection("server=localhost;user id=root;password=;database=kasirminimarket;")
            Conn.Open()
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub

    Public Function HitungMD5(ByVal SourceText As String) As String

        If String.IsNullOrEmpty(SourceText) Then Return ""

        Dim Ubytes As New System.Text.ASCIIEncoding
        Dim Bytes As Byte()
        Dim Sb As New System.Text.StringBuilder()

        Dim md5 As System.Security.Cryptography.MD5 = System.Security.Cryptography.MD5.Create()

        Bytes = md5.ComputeHash(Ubytes.GetBytes(SourceText))

        For Each b As Byte In Bytes
            Sb.Append(b.ToString("x2"))
        Next

        Return Sb.ToString()
    End Function
End Module