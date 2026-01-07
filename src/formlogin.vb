Imports MySql.Data.MySqlClient

Public Class FormLogin


    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = ""
        txtPass.Text = ""

        txtPass.PasswordChar = "*"

        txtUser.Focus()
    End Sub

    Private Sub cbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cbshowpassword.CheckedChanged
        If cbshowpassword.Checked = True Then

            txtPass.PasswordChar = ControlChars.NullChar
        Else

            txtPass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click


        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        Try
            Call Koneksi()

            Dim SQL As String = "SELECT * FROM user WHERE username='" & txtUser.Text & "' AND password='" & HitungMD5(txtPass.Text) & "'"

            Cmd = New MySqlCommand(SQL, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then


                ModuleKoneksi.UserSedangLogin = Rd("nama_user")
                ModuleKoneksi.LevelUser = Rd("role")

                MsgBox("Login Berhasil! Selamat Datang, " & ModuleKoneksi.UserSedangLogin, MsgBoxStyle.Information, "Sukses")

                Me.Hide()
                FormUtama.Show()
            Else

                MsgBox("Username atau Password salah!", MsgBoxStyle.Critical, "Gagal Login")
                txtPass.Text = ""
                txtPass.Focus()
            End If

            Rd.Close()

        Catch ex As Exception
            MsgBox("Error Database: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        End
    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

End Class