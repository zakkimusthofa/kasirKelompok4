Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormUtama

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Me.RightToLeft = RightToLeft.No
        Me.RightToLeftLayout = False
        dgvkeranjang.RightToLeft = RightToLeft.No


        Timer1.Interval = 1000
        Timer1.Enabled = True

        dgvkeranjang.Columns.Clear()

        dgvkeranjang.Columns.Add("Nama", "Nama Barang")
        dgvkeranjang.Columns(0).Width = 300
        dgvkeranjang.Columns(0).ReadOnly = True

        dgvkeranjang.Columns.Add("Qty", "Qty")
        dgvkeranjang.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvkeranjang.Columns(1).Width = 50

        dgvkeranjang.Columns.Add("Harga", "Harga")
        dgvkeranjang.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvkeranjang.Columns(2).DefaultCellStyle.Format = "N0"
        dgvkeranjang.Columns(2).ReadOnly = True


        dgvkeranjang.Columns.Add("Subtotal", "Subtotal")
        dgvkeranjang.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvkeranjang.Columns(3).DefaultCellStyle.Format = "N0"
        dgvkeranjang.Columns(3).ReadOnly = True

        dgvkeranjang.Columns.Add("Kode", "Kode")
        dgvkeranjang.Columns(4).Visible = False

        dgvkeranjang.AllowUserToAddRows = False


        AturSapaan()
        BuatNomor() ' Generate TRX otomatis

        ' Reset Textbox
        txtcaribarang.Focus()
        lblgrandtotal.Text = "0"
        lblkembalian.Text = "0"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lbljam IsNot Nothing Then
            lbljam.Text = Format(Now, "HH:mm")
        End If
        AturSapaan()
    End Sub

    Sub BuatNomor()
        Try
            Call Koneksi()
            Dim HariIni As String = "TRX" & Format(Now, "yyMMdd")


            Dim sql As String = "SELECT no_faktur FROM transaksi_header WHERE no_faktur LIKE '" & HariIni & "%' ORDER BY no_faktur DESC"
            Cmd = New MySqlCommand(sql, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then
                Dim Hitung As Long = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1

            Else

            End If
            Rd.Close()
            Conn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Sub InputBarang()
        If txtcaribarang.Text = "" Or txtcaribarang.Text = "Cari Barang" Then Exit Sub

        Try
            Call Koneksi()

            Dim sql As String = "SELECT * FROM produk WHERE id_produk='" & txtcaribarang.Text & "' OR nama_produk LIKE '%" & txtcaribarang.Text & "%'"
            Cmd = New MySqlCommand(sql, Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()

            If Rd.HasRows Then

                Dim Kode As String = Rd("id_produk")
                Dim Nama As String = Rd("nama_produk")
                Dim Harga As Decimal = Rd("harga_jual")
                Dim Stok As Integer = Rd("stok")


                If Stok <= 0 Then
                    MsgBox("Stok Habis!", MsgBoxStyle.Exclamation)
                    Rd.Close()
                    Conn.Close()
                    Exit Sub
                End If

                Rd.Close()
                Conn.Close()

                Dim BarisKe As Integer = -1


                For i As Integer = 0 To dgvkeranjang.Rows.Count - 1
                    If dgvkeranjang.Rows(i).Cells(4).Value = Kode Then
                        BarisKe = i
                        Exit For
                    End If
                Next

                If BarisKe > -1 Then

                    Dim QtyLama As Integer = dgvkeranjang.Rows(BarisKe).Cells(1).Value


                    If QtyLama + 1 > Stok Then
                        MsgBox("Stok tidak cukup!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If

                    Dim QtyBaru As Integer = QtyLama + 1
                    dgvkeranjang.Rows(BarisKe).Cells(1).Value = QtyBaru
                    dgvkeranjang.Rows(BarisKe).Cells(3).Value = QtyBaru * Harga
                Else

                    dgvkeranjang.Rows.Add(Nama, 1, Harga, Harga, Kode)
                End If

                HitungTotal()
                txtcaribarang.Text = ""
                txtcaribarang.Focus()
            Else
                MsgBox("Barang tidak ditemukan!", MsgBoxStyle.Exclamation)
                txtcaribarang.SelectAll()
                Rd.Close()
                Conn.Close()
            End If

        Catch ex As Exception
            MsgBox("Error Database: " & ex.Message)
        End Try
    End Sub

    Sub HitungTotal()
        Dim TotalBelanja As Decimal = 0
        For i As Integer = 0 To dgvkeranjang.Rows.Count - 1
            TotalBelanja += dgvkeranjang.Rows(i).Cells(3).Value
        Next
        lblgrandtotal.Text = Format(TotalBelanja, "#,###")
        If TotalBelanja = 0 Then lblgrandtotal.Text = "0"
    End Sub

    Private Sub txtcaribarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcaribarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            InputBarang()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        InputBarang()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnTambahBarang.Click


        If dgvkeranjang.Rows.Count = 0 Then
            txtcaribarang.Text = ""
            txtcaribarang.Focus()
            Exit Sub
        End If


        If MsgBox("Reset Transaksi?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi Refresh") = MsgBoxResult.Yes Then


            dgvkeranjang.Rows.Clear()


            lblgrandtotal.Text = "0"
            lblkembalian.Text = "0"
            txtbayar.Text = ""

            txtcaribarang.Text = ""
            txtcaribarang.Focus()

        End If
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnbarang.Click
        FormBarang.ShowDialog()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnlaporan.Click
        FormLaporan.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim tanya As Integer = MsgBox("Apakah Anda yakin ingin Logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi Logout")
        If tanya = MsgBoxResult.Yes Then
            Me.Hide()
            FormLogin.Show()
        End If
    End Sub

    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbayar.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBayar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim StrTotal As String = lblgrandtotal.Text.Replace(".", "").Replace(",", "").Replace("Rp", "")
            Dim StrBayar As String = txtbayar.Text.Replace(".", "").Replace(",", "")

            Dim TotalBelanja As Decimal = Val(StrTotal)
            Dim UangBayar As Decimal = Val(StrBayar)

            If UangBayar < TotalBelanja Then
                MsgBox("Uang Kurang", MsgBoxStyle.Critical)
                lblkembalian.Text = "0"
            Else
                Dim Kembalian As Decimal = UangBayar - TotalBelanja
                lblkembalian.Text = Format(Kembalian, "#,##0")
                btnbayar.Focus()
            End If
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click

        If dgvkeranjang.Rows.Count = 0 Then
            MsgBox("Keranjang kosong!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        Dim StrKembalian As String = lblkembalian.Text.Replace(".", "").Replace(",", "").Replace("Rp", "")
        Dim StrBayar As String = txtbayar.Text.Replace(".", "").Replace(",", "")

        If Val(StrKembalian) < 0 Or txtbayar.Text = "" Or Val(StrBayar) = 0 Then
            MsgBox("Pembayaran belum valid! Silakan masukkan nominal dan tekan Enter.", MsgBoxStyle.Exclamation)
            txtbayar.Focus()
            Exit Sub
        End If


        Dim Pesan As String = "PERHATIAN!" & vbCrLf & vbCrLf &
                              "Barang yang dibeli tidak bisa dikembalikan (No Refund)." & vbCrLf &
                              "Apakah transaksi sudah benar?"

        If MsgBox(Pesan, MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi Bayar") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim tr As MySqlTransaction = Nothing

        Try
            Call Koneksi()

            tr = Conn.BeginTransaction()
            Cmd.Connection = Conn
            Cmd.Transaction = tr

            Dim HariIni As String = "TRX" & Format(Now, "yyMMdd")
            Dim NoFaktur As String = ""

            Dim sqlCek As String = "SELECT no_faktur FROM transaksi_header WHERE no_faktur LIKE @hari ORDER BY no_faktur DESC LIMIT 1"
            Cmd.CommandText = sqlCek
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@hari", HariIni & "%")


            Using RdCek As MySqlDataReader = Cmd.ExecuteReader()
                If RdCek.Read() Then
                    Dim Hitung As Long = Microsoft.VisualBasic.Right(RdCek.GetString(0), 3) + 1
                    NoFaktur = HariIni & Microsoft.VisualBasic.Right("000" & Hitung, 3)
                Else
                    NoFaktur = HariIni & "001"
                End If
            End Using


            Dim TotalBelanja As Decimal = Val(lblgrandtotal.Text.Replace(".", "").Replace(",", ""))
            Dim Bayar As Decimal = Val(StrBayar)
            Dim Kembali As Decimal = Val(StrKembalian)
            Dim Kasir As String = ModuleKoneksi.UserSedangLogin

            Dim SqlHeader As String = "INSERT INTO transaksi_header (no_faktur, tgl_transaksi, jam_transaksi, total_belanja, bayar, kembali, kode_user) VALUES " &
                                      "(@no_faktur, @tgl, @jam, @total, @bayar, @kembali, @user)"

            Cmd.CommandText = SqlHeader
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@no_faktur", NoFaktur)
            Cmd.Parameters.AddWithValue("@tgl", Format(Now, "yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@jam", Format(Now, "HH:mm:ss"))
            Cmd.Parameters.AddWithValue("@total", TotalBelanja)
            Cmd.Parameters.AddWithValue("@bayar", Bayar)
            Cmd.Parameters.AddWithValue("@kembali", Kembali)
            Cmd.Parameters.AddWithValue("@user", Kasir)
            Cmd.ExecuteNonQuery()

            For Each row As DataGridViewRow In dgvkeranjang.Rows
                Dim KodeBrg As String = row.Cells(4).Value
                Dim NamaBrg As String = row.Cells(0).Value
                Dim Qty As Integer = row.Cells(1).Value
                Dim Harga As Decimal = row.Cells(2).Value
                Dim Subtotal As Decimal = row.Cells(3).Value

                Dim SqlDetail As String = "INSERT INTO transaksi_detail (no_faktur, kode_barang, nama_barang, harga_jual, jumlah, subtotal) VALUES " &
                                          "(@faktur_det, @kode, @nama, @harga, @qty, @sub)"
                Cmd.CommandText = SqlDetail
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@faktur_det", NoFaktur)
                Cmd.Parameters.AddWithValue("@kode", KodeBrg)
                Cmd.Parameters.AddWithValue("@nama", NamaBrg)
                Cmd.Parameters.AddWithValue("@harga", Harga)
                Cmd.Parameters.AddWithValue("@qty", Qty)
                Cmd.Parameters.AddWithValue("@sub", Subtotal)
                Cmd.ExecuteNonQuery()

                ' 2. Update Stok
                Dim SqlStok As String = "UPDATE produk SET stok = stok - @qty_stok WHERE id_produk = @kode_stok"
                Cmd.CommandText = SqlStok
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@qty_stok", Qty)
                Cmd.Parameters.AddWithValue("@kode_stok", KodeBrg)
                Cmd.ExecuteNonQuery()
            Next


            tr.Commit()

            MsgBox("Transaksi BERHASIL!" & vbCrLf & "No Faktur: " & NoFaktur, MsgBoxStyle.Information)

            dgvkeranjang.Rows.Clear()
            lblgrandtotal.Text = "0"
            txtbayar.Text = ""
            lblkembalian.Text = "0"
            txtcaribarang.Focus()


        Catch ex As Exception

            If tr IsNot Nothing Then
                tr.Rollback()
            End If
            MsgBox("Transaksi GAGAL! Database dikembalikan ke status awal." & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub txtcaribarang_Enter(sender As Object, e As EventArgs) Handles txtcaribarang.Enter
        If txtcaribarang.Text = "Cari Barang" Then
            txtcaribarang.Text = ""
            txtcaribarang.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtcaribarang_Leave(sender As Object, e As EventArgs) Handles txtcaribarang.Leave
        If txtcaribarang.Text = "" Then
            txtcaribarang.Text = "Cari Barang"
            txtcaribarang.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtBayar_Enter(sender As Object, e As EventArgs) Handles txtbayar.Enter
        If txtbayar.Text = "Masukan Tunai" Then
            txtbayar.Text = ""
            txtbayar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBayar_Leave(sender As Object, e As EventArgs) Handles txtbayar.Leave
        If txtbayar.Text = "" Or txtbayar.Text = "0" Then
            txtbayar.Text = "Masukan Tunai"
            txtbayar.ForeColor = Color.Gray
        End If
    End Sub

    Sub AturSapaan()
        Dim Jam As Integer = Now.Hour
        Dim Waktu As String = ""
        Select Case Jam
            Case 0 To 10 : Waktu = "Selamat Pagi"
            Case 11 To 14 : Waktu = "Selamat Siang"
            Case 15 To 18 : Waktu = "Selamat Sore"
            Case Else : Waktu = "Selamat Malam"
        End Select
        lblsapaan.Text = Waktu & ", " & ModuleKoneksi.UserSedangLogin
        lblrole.Text = ModuleKoneksi.LevelUser
    End Sub

    Private Sub dgvkeranjang_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkeranjang.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then
            Try
                Dim row As DataGridViewRow = dgvkeranjang.Rows(e.RowIndex)
                Dim QtyBaru As Integer = Val(row.Cells(1).Value)
                Dim Harga As Decimal = Val(row.Cells(2).Value)


                row.Cells(3).Value = QtyBaru * Harga
                HitungTotal()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvkeranjang_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvkeranjang.EditingControlShowing
        If dgvkeranjang.CurrentCell.ColumnIndex = 1 Then
            Dim txt As TextBox = CType(e.Control, TextBox)
            RemoveHandler txt.KeyPress, AddressOf Qty_KeyPress
            AddHandler txt.KeyPress, AddressOf Qty_KeyPress
        End If
    End Sub

    Private Sub Qty_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class