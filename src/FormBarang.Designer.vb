<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbsatuan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstok = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnrefresh = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjual = New System.Windows.Forms.TextBox()
        Me.txtbeli = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvbarang = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labeltotal = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbsatuan)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtstok)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtjual)
        Me.Panel1.Controls.Add(Me.txtbeli)
        Me.Panel1.Controls.Add(Me.txtnama)
        Me.Panel1.Controls.Add(Me.txtkode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 531)
        Me.Panel1.TabIndex = 0
        '
        'cmbsatuan
        '
        Me.cmbsatuan.FormattingEnabled = True
        Me.cmbsatuan.Location = New System.Drawing.Point(264, 325)
        Me.cmbsatuan.Name = "cmbsatuan"
        Me.cmbsatuan.Size = New System.Drawing.Size(121, 28)
        Me.cmbsatuan.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "satuan :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "stok :"
        '
        'txtstok
        '
        Me.txtstok.Location = New System.Drawing.Point(21, 325)
        Me.txtstok.Name = "txtstok"
        Me.txtstok.Size = New System.Drawing.Size(100, 26)
        Me.txtstok.TabIndex = 15
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnrefresh)
        Me.Panel5.Controls.Add(Me.btnsimpan)
        Me.Panel5.Location = New System.Drawing.Point(21, 387)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(528, 100)
        Me.Panel5.TabIndex = 14
        '
        'btnrefresh
        '
        Me.btnrefresh.Location = New System.Drawing.Point(191, 7)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(118, 32)
        Me.btnrefresh.TabIndex = 2
        Me.btnrefresh.Text = "Refresh"
        Me.btnrefresh.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(10, 7)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(94, 31)
        Me.btnsimpan.TabIndex = 0
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "harga jual :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "harga beli :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "nama barang :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "kode barang :"
        '
        'txtjual
        '
        Me.txtjual.Location = New System.Drawing.Point(23, 257)
        Me.txtjual.Name = "txtjual"
        Me.txtjual.Size = New System.Drawing.Size(362, 26)
        Me.txtjual.TabIndex = 8
        '
        'txtbeli
        '
        Me.txtbeli.Location = New System.Drawing.Point(23, 203)
        Me.txtbeli.Name = "txtbeli"
        Me.txtbeli.Size = New System.Drawing.Size(362, 26)
        Me.txtbeli.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(23, 142)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(362, 26)
        Me.txtnama.TabIndex = 6
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(23, 85)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(362, 26)
        Me.txtkode.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input Barang"
        '
        'dgvbarang
        '
        Me.dgvbarang.BackgroundColor = System.Drawing.Color.White
        Me.dgvbarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbarang.Location = New System.Drawing.Point(19, 142)
        Me.dgvbarang.Name = "dgvbarang"
        Me.dgvbarang.RowHeadersWidth = 62
        Me.dgvbarang.RowTemplate.Height = 28
        Me.dgvbarang.Size = New System.Drawing.Size(459, 283)
        Me.dgvbarang.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.labeltotal)
        Me.Panel4.Controls.Add(Me.btnedit)
        Me.Panel4.Controls.Add(Me.btnhapus)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtcari)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.dgvbarang)
        Me.Panel4.Location = New System.Drawing.Point(584, 31)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(497, 531)
        Me.Panel4.TabIndex = 3
        '
        'labeltotal
        '
        Me.labeltotal.AutoSize = True
        Me.labeltotal.Location = New System.Drawing.Point(103, 455)
        Me.labeltotal.Name = "labeltotal"
        Me.labeltotal.Size = New System.Drawing.Size(18, 20)
        Me.labeltotal.TabIndex = 23
        Me.labeltotal.Text = "0"
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(269, 450)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(94, 31)
        Me.btnedit.TabIndex = 1
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(384, 450)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(94, 31)
        Me.btnhapus.TabIndex = 2
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 455)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total Data :"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(19, 85)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(362, 26)
        Me.txtcari.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cari barang :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Data Barang"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(929, 589)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(133, 39)
        Me.btnkembali.TabIndex = 4
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 664)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtkode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvbarang As DataGridView
    Friend WithEvents btnrefresh As Button
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjual As TextBox
    Friend WithEvents txtbeli As TextBox
    Friend WithEvents txtstok As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnsimpan As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents cmbsatuan As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents labeltotal As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtcari As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnkembali As Button
End Class
