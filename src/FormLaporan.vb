Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormLaporan


    Dim NoFakturCetak As String = ""


    WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()


        dtpdari.Format = DateTimePickerFormat.Custom
        dtpdari.CustomFormat = "dd/MM/yyyy"
        dtpdari.Value = Now

        dtpsampai.Format = DateTimePickerFormat.Custom
        dtpsampai.CustomFormat = "dd/MM/yyyy"
        dtpsampai.Value = Now

        dgvlaporan.Columns.Clear()
        dgvlaporan.Columns.Add("Faktur", "No Faktur")
        dgvlaporan.Columns.Add("Tanggal", "Tanggal")
        dgvlaporan.Columns.Add("Jam", "Jam")
        dgvlaporan.Columns.Add("Kasir", "Kasir")
        dgvlaporan.Columns.Add("Total", "Total Belanja")


        dgvlaporan.Columns(0).Width = 120
        dgvlaporan.Columns(1).Width = 90
        dgvlaporan.Columns(2).Width = 70
        dgvlaporan.Columns(3).Width = 100
        dgvlaporan.Columns(4).Width = 150


        dgvlaporan.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvlaporan.Columns(4).DefaultCellStyle.Format = "N0"

        dgvlaporan.AllowUserToAddRows = False
        dgvlaporan.ReadOnly = True
        dgvlaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        lblmodal.Text = "Rp 0"
        lblbersih.Text = "Rp 0"
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Try
            Call Koneksi()

            Dim TglDari As String = dtpdari.Value.ToString("yyyy-MM-dd")
            Dim TglSampai As String = dtpsampai.Value.ToString("yyyy-MM-dd")

            dgvlaporan.Rows.Clear()

            Dim TotalKotor As Decimal = 0
            Dim TotalBersih As Decimal = 0



            Dim sql As String = "SELECT h.no_faktur, h.tgl_transaksi, h.jam_transaksi, h.kode_user, h.total_belanja, " &
                                "(h.total_belanja - SUM(d.jumlah * IFNULL(p.harga_beli, 0))) as keuntungan_bersih " &
                                "FROM transaksi_header h " &
                                "JOIN transaksi_detail d ON h.no_faktur = d.no_faktur " &
                                "LEFT JOIN produk p ON d.kode_barang = p.id_produk " &
                                "WHERE h.tgl_transaksi BETWEEN '" & TglDari & "' AND '" & TglSampai & "' " &
                                "GROUP BY h.no_faktur " &
                                "ORDER BY h.no_faktur DESC"

            Cmd = New MySqlCommand(sql, Conn)
            Rd = Cmd.ExecuteReader

            While Rd.Read

                Dim Kotor As Decimal = Rd("total_belanja")
                Dim Bersih As Decimal = Rd("keuntungan_bersih")

                dgvlaporan.Rows.Add(
                    Rd("no_faktur"),
                    Format(Rd("tgl_transaksi"), "dd/MM/yyyy"),
                    Rd("jam_transaksi"),
                    Rd("kode_user"),
                    Kotor,
                    Bersih
                )


                TotalKotor += Kotor
                TotalBersih += Bersih
            End While

            Rd.Close()
            Conn.Close()


            lblmodal.Text = "Rp " & Format(TotalKotor, "#,##0")

            If lblbersih IsNot Nothing Then
                lblbersih.Text = "Rp " & Format(TotalBersih, "#,##0")
                lblbersih.ForeColor = Color.Green
            End If

            If dgvlaporan.Rows.Count = 0 Then
                MsgBox("Data tidak ditemukan.", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("Error Laporan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click

        If dgvlaporan.SelectedRows.Count = 0 Then
            MsgBox("Pilih salah satu transaksi yang ingin dicetak!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If


        NoFakturCetak = dgvlaporan.SelectedRows(0).Cells(0).Value.ToString()

        PD.DefaultPageSettings.PaperSize = New PaperSize("Struk", 300, 600)

        PPD.Document = PD
        PPD.ShowDialog()

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f10 As New Font("Courier New", 10, FontStyle.Regular)
        Dim f10b As New Font("Courier New", 10, FontStyle.Bold)
        Dim f8 As New Font("Courier New", 8, FontStyle.Regular)

        Dim Center As New StringFormat With {.Alignment = StringAlignment.Center}
        Dim Right As New StringFormat With {.Alignment = StringAlignment.Far}
        Dim Left As New StringFormat With {.Alignment = StringAlignment.Near}


        Dim Garis As String = "----------------------------------------"


        Dim Y As Integer = 10
        Dim MarginKiri As Integer = 10
        Dim LebarKertas As Integer = e.PageBounds.Width - 20


        e.Graphics.DrawString("Minimarket C.7 23", f10b, Brushes.Black, New Rectangle(0, Y, e.PageBounds.Width, 20), Center)
        Y += 15
        e.Graphics.DrawString("Jl. kelompok no 4", f8, Brushes.Black, New Rectangle(0, Y, e.PageBounds.Width, 20), Center)
        Y += 20
        e.Graphics.DrawString(Garis, f8, Brushes.Black, MarginKiri, Y)
        Y += 15

        Dim Tgl As String = ""
        Dim Jam As String = ""
        Dim Kasir As String = ""
        Dim Bayar As Decimal = 0
        Dim Kembali As Decimal = 0

        Try
            Call Koneksi()
            Cmd = New MySqlCommand("SELECT * FROM transaksi_header WHERE no_faktur='" & NoFakturCetak & "'", Conn)
            Dim RdHeader As MySqlDataReader = Cmd.ExecuteReader
            If RdHeader.Read Then
                Tgl = Format(RdHeader("tgl_transaksi"), "dd/MM/yyyy")
                Jam = RdHeader("jam_transaksi").ToString
                Kasir = RdHeader("kode_user").ToString
                Bayar = RdHeader("bayar")
                Kembali = RdHeader("kembali")
            End If
            RdHeader.Close()

            e.Graphics.DrawString("Faktur : " & NoFakturCetak, f8, Brushes.Black, MarginKiri, Y)
            Y += 12
            e.Graphics.DrawString("Tgl    : " & Tgl & " " & Jam, f8, Brushes.Black, MarginKiri, Y)
            Y += 12
            e.Graphics.DrawString("Kasir  : " & Kasir, f8, Brushes.Black, MarginKiri, Y)
            Y += 15
            e.Graphics.DrawString(Garis, f8, Brushes.Black, MarginKiri, Y)
            Y += 15

            Cmd = New MySqlCommand("SELECT * FROM transaksi_detail WHERE no_faktur='" & NoFakturCetak & "'", Conn)
            Dim RdDetail As MySqlDataReader = Cmd.ExecuteReader

            While RdDetail.Read
                Dim NamaBarang As String = RdDetail("nama_barang")
                Dim Qty As Integer = RdDetail("jumlah")
                Dim Harga As Decimal = RdDetail("harga_jual")
                Dim Subtotal As Decimal = RdDetail("subtotal")

                e.Graphics.DrawString(NamaBarang, f8, Brushes.Black, MarginKiri, Y)
                Y += 12

                Dim Rincian As String = Qty & " x " & Format(Harga, "#,###")
                e.Graphics.DrawString(Rincian, f8, Brushes.Black, MarginKiri, Y)
                e.Graphics.DrawString(Format(Subtotal, "#,###"), f8, Brushes.Black, New Rectangle(0, Y, LebarKertas, 12), Right)
                Y += 15
            End While
            RdDetail.Close()
            Conn.Close()

            e.Graphics.DrawString(Garis, f8, Brushes.Black, MarginKiri, Y)
            Y += 15

            Dim Total As Decimal = dgvlaporan.SelectedRows(0).Cells(4).Value

            e.Graphics.DrawString("Total   :", f8, Brushes.Black, MarginKiri, Y)
            e.Graphics.DrawString(Format(Total, "#,###"), f8, Brushes.Black, New Rectangle(0, Y, LebarKertas, 12), Right)
            Y += 15

            e.Graphics.DrawString("Bayar   :", f8, Brushes.Black, MarginKiri, Y)
            e.Graphics.DrawString(Format(Bayar, "#,###"), f8, Brushes.Black, New Rectangle(0, Y, LebarKertas, 12), Right)
            Y += 15

            e.Graphics.DrawString("Kembali :", f8, Brushes.Black, MarginKiri, Y)
            e.Graphics.DrawString(Format(Kembali, "#,###"), f8, Brushes.Black, New Rectangle(0, Y, LebarKertas, 12), Right)
            Y += 30

            e.Graphics.DrawString("TERIMA KASIH", f10, Brushes.Black, New Rectangle(0, Y, e.PageBounds.Width, 20), Center)
            Y += 15
            e.Graphics.DrawString("Barang yang dibeli tidak dapat ditukar", f8, Brushes.Black, New Rectangle(0, Y, e.PageBounds.Width, 20), Center)

        Catch ex As Exception
            MsgBox("Error Print: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class