Imports MySql.Data.MySqlClient

Public Class FormBarang

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvbarang.Columns.Clear()
        dgvbarang.Columns.Add("Kode", "Kode Barang")
        dgvbarang.Columns.Add("Nama", "Nama Barang")
        dgvbarang.Columns.Add("Beli", "Harga Beli")
        dgvbarang.Columns.Add("Jual", "Harga Jual")
        dgvbarang.Columns.Add("Stok", "Stok")
        dgvbarang.Columns.Add("Satuan", "Satuan")


        dgvbarang.Columns(1).Width = 200
        dgvbarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvbarang.ReadOnly = True
        dgvbarang.AllowUserToAddRows = False

        dgvbarang.Columns(2).DefaultCellStyle.Format = "N0"
        dgvbarang.Columns(3).DefaultCellStyle.Format = "N0"

        cmbsatuan.Items.Clear()
        cmbsatuan.Items.AddRange(New String() {"Pcs", "Bungkus", "Botol", "Kaleng", "Dus", "Kg", "Liter", "Sachet"})

        TampilData()
    End Sub

    Sub TampilData()
        Try
            Call Koneksi()
            Dim sql As String = "SELECT id_produk, nama_produk, harga_beli, harga_jual, stok, satuan FROM produk"
            Cmd = New MySqlCommand(sql, Conn)
            Rd = Cmd.ExecuteReader

            dgvbarang.Rows.Clear()

            While Rd.Read
                dgvbarang.Rows.Add(
                    Rd("id_produk"),
                    Rd("nama_produk"),
                    Rd("harga_beli"),
                    Rd("harga_jual"),
                    Rd("stok"),
                    Rd("satuan")
                )
            End While

            Rd.Close()
            Conn.Close()

            If labeltotal IsNot Nothing Then
                labeltotal.Text = "" & dgvbarang.Rows.Count
            End If

        Catch ex As Exception
            MsgBox("Gagal Tampil Data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        If dgvbarang.CurrentRow Is Nothing Then
            MsgBox("Pilih dulu barang di tabel yang mau diedit!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim baris As DataGridViewRow = dgvbarang.CurrentRow


        txtkode.Text = baris.Cells(0).Value.ToString()
        txtnama.Text = baris.Cells(1).Value.ToString()
        txtbeli.Text = baris.Cells(2).Value.ToString()
        txtjual.Text = baris.Cells(3).Value.ToString()
        txtstok.Text = baris.Cells(4).Value.ToString()

        If baris.Cells(5).Value IsNot Nothing Then
            cmbsatuan.Text = baris.Cells(5).Value.ToString()
        End If

        MsgBox("Silakan ubah data di kolom input, lalu tekan tombol SIMPAN.", MsgBoxStyle.Information)
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click

        If txtkode.Text = "" Or txtnama.Text = "" Or cmbsatuan.Text = "" Then
            MsgBox("Kode, Nama, dan Satuan tidak boleh kosong!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Call Koneksi()

            Dim CekSql As String = "SELECT * FROM produk WHERE id_produk = '" & txtkode.Text & "'"
            Dim CekCmd As New MySqlCommand(CekSql, Conn)
            Dim CekRd As MySqlDataReader = CekCmd.ExecuteReader

            If CekRd.HasRows Then

                CekRd.Close()

                Dim UpdateSql As String = "UPDATE produk SET " &
                                          "nama_produk='" & txtnama.Text & "', " &
                                          "harga_beli='" & txtbeli.Text & "', " &
                                          "harga_jual='" & txtjual.Text & "', " &
                                          "stok='" & txtstok.Text & "', " &
                                          "satuan='" & cmbsatuan.Text & "' " &
                                          "WHERE id_produk='" & txtkode.Text & "'"

                Cmd = New MySqlCommand(UpdateSql, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Diupdate (Edit)!", MsgBoxStyle.Information)
            Else
                CekRd.Close()

                Dim InsertSql As String = "INSERT INTO produk (id_produk, nama_produk, harga_beli, harga_jual, stok, satuan, id_kategori) " &
                                          "VALUES ('" & txtkode.Text & "', '" & txtnama.Text & "', '" & txtbeli.Text & "', " &
                                          "'" & txtjual.Text & "', '" & txtstok.Text & "', '" & cmbsatuan.Text & "', 1)"

                Cmd = New MySqlCommand(InsertSql, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Data Baru Berhasil Disimpan!", MsgBoxStyle.Information)
            End If

            Bersihkan()
            TampilData()

        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click

        If dgvbarang.CurrentRow Is Nothing Then
            MsgBox("Pilih dulu barang di tabel yang mau dihapus!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim KodeDiTabel As String = dgvbarang.CurrentRow.Cells(0).Value.ToString()
        Dim NamaDiTabel As String = dgvbarang.CurrentRow.Cells(1).Value.ToString()

        If MsgBox("Yakin hapus " & NamaDiTabel & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Call Koneksi()
                Dim HapusSql As String = "DELETE FROM produk WHERE id_produk='" & KodeDiTabel & "'"
                Cmd = New MySqlCommand(HapusSql, Conn)
                Cmd.ExecuteNonQuery()

                MsgBox("Data Terhapus.", MsgBoxStyle.Information)
                Bersihkan()
                TampilData()
            Catch ex As Exception
                MsgBox("Error Hapus: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvbarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvbarang.CellClick
    End Sub
    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        Try
            Call Koneksi()
            Dim sql As String = "SELECT id_produk, nama_produk, harga_beli, harga_jual, stok, satuan FROM produk " &
                                "WHERE id_produk LIKE '%" & txtcari.Text & "%' OR nama_produk LIKE '%" & txtcari.Text & "%'"

            Cmd = New MySqlCommand(sql, Conn)
            Rd = Cmd.ExecuteReader

            dgvbarang.Rows.Clear()
            While Rd.Read
                dgvbarang.Rows.Add(Rd("id_produk"), Rd("nama_produk"), Rd("harga_beli"), Rd("harga_jual"), Rd("stok"), Rd("satuan"))
            End While
            Rd.Close()
            Conn.Close()

            If labeltotal IsNot Nothing Then
                labeltotal.Text = "" & dgvbarang.Rows.Count
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub Bersihkan()
        txtkode.Text = ""
        txtnama.Text = ""
        txtbeli.Text = ""
        txtjual.Text = ""
        txtstok.Text = ""
        cmbsatuan.SelectedIndex = -1
        txtkode.Focus()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Bersihkan()
        txtcari.Text = ""
        TampilData()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Close()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class