<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        Me.components = New System.ComponentModel.Container()
        Me.btnbarang = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.btnlaporan = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblrole = New System.Windows.Forms.Label()
        Me.lblsapaan = New System.Windows.Forms.Label()
        Me.btntambahbarang = New System.Windows.Forms.Button()
        Me.btninput = New System.Windows.Forms.Button()
        Me.txtcaribarang = New System.Windows.Forms.TextBox()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvkeranjang = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnbayar = New System.Windows.Forms.Button()
        Me.lblkembalian = New System.Windows.Forms.Label()
        Me.txtbayar = New System.Windows.Forms.TextBox()
        Me.lblgrandtotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvkeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnbarang
        '
        Me.btnbarang.Location = New System.Drawing.Point(36, 25)
        Me.btnbarang.Name = "btnbarang"
        Me.btnbarang.Size = New System.Drawing.Size(125, 40)
        Me.btnbarang.TabIndex = 4
        Me.btnbarang.Text = "Barang"
        Me.btnbarang.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnlogout)
        Me.Panel1.Controls.Add(Me.btnlaporan)
        Me.Panel1.Controls.Add(Me.btnbarang)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 548)
        Me.Panel1.TabIndex = 11
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(36, 141)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(125, 40)
        Me.btnlogout.TabIndex = 6
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'btnlaporan
        '
        Me.btnlaporan.Location = New System.Drawing.Point(36, 82)
        Me.btnlaporan.Name = "btnlaporan"
        Me.btnlaporan.Size = New System.Drawing.Size(125, 40)
        Me.btnlaporan.TabIndex = 5
        Me.btnlaporan.Text = "Laporan"
        Me.btnlaporan.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblrole)
        Me.Panel2.Controls.Add(Me.lblsapaan)
        Me.Panel2.Controls.Add(Me.btntambahbarang)
        Me.Panel2.Controls.Add(Me.btninput)
        Me.Panel2.Controls.Add(Me.txtcaribarang)
        Me.Panel2.Controls.Add(Me.lbljam)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(218, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(744, 190)
        Me.Panel2.TabIndex = 12
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.Location = New System.Drawing.Point(50, 45)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(35, 20)
        Me.lblrole.TabIndex = 7
        Me.lblrole.Text = "role"
        '
        'lblsapaan
        '
        Me.lblsapaan.AutoSize = True
        Me.lblsapaan.Location = New System.Drawing.Point(50, 15)
        Me.lblsapaan.Name = "lblsapaan"
        Me.lblsapaan.Size = New System.Drawing.Size(158, 20)
        Me.lblsapaan.TabIndex = 6
        Me.lblsapaan.Text = "Selamat Malam, user"
        '
        'btntambahbarang
        '
        Me.btntambahbarang.Location = New System.Drawing.Point(595, 115)
        Me.btntambahbarang.Name = "btntambahbarang"
        Me.btntambahbarang.Size = New System.Drawing.Size(124, 53)
        Me.btntambahbarang.TabIndex = 5
        Me.btntambahbarang.Text = "Refresh"
        Me.btntambahbarang.UseVisualStyleBackColor = True
        '
        'btninput
        '
        Me.btninput.Location = New System.Drawing.Point(495, 145)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(75, 33)
        Me.btninput.TabIndex = 4
        Me.btninput.Text = "Input"
        Me.btninput.UseVisualStyleBackColor = True
        '
        'txtcaribarang
        '
        Me.txtcaribarang.Location = New System.Drawing.Point(24, 113)
        Me.txtcaribarang.Multiline = True
        Me.txtcaribarang.Name = "txtcaribarang"
        Me.txtcaribarang.Size = New System.Drawing.Size(546, 26)
        Me.txtcaribarang.TabIndex = 3
        Me.txtcaribarang.Text = "Cari Barang"
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Location = New System.Drawing.Point(639, 25)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(49, 20)
        Me.lbljam.TabIndex = 2
        Me.lbljam.Text = "00:00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(470, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kelompok 4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kasir Minimarket"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgvkeranjang)
        Me.Panel3.Location = New System.Drawing.Point(218, 217)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(744, 240)
        Me.Panel3.TabIndex = 13
        '
        'dgvkeranjang
        '
        Me.dgvkeranjang.BackgroundColor = System.Drawing.Color.White
        Me.dgvkeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkeranjang.Location = New System.Drawing.Point(14, 20)
        Me.dgvkeranjang.Name = "dgvkeranjang"
        Me.dgvkeranjang.RowHeadersVisible = False
        Me.dgvkeranjang.RowHeadersWidth = 62
        Me.dgvkeranjang.RowTemplate.Height = 28
        Me.dgvkeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvkeranjang.Size = New System.Drawing.Size(705, 204)
        Me.dgvkeranjang.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnbayar)
        Me.Panel4.Controls.Add(Me.lblkembalian)
        Me.Panel4.Controls.Add(Me.txtbayar)
        Me.Panel4.Controls.Add(Me.lblgrandtotal)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(218, 463)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(744, 97)
        Me.Panel4.TabIndex = 14
        '
        'btnbayar
        '
        Me.btnbayar.Location = New System.Drawing.Point(620, 51)
        Me.btnbayar.Name = "btnbayar"
        Me.btnbayar.Size = New System.Drawing.Size(87, 32)
        Me.btnbayar.TabIndex = 7
        Me.btnbayar.Text = "Bayar"
        Me.btnbayar.UseVisualStyleBackColor = True
        '
        'lblkembalian
        '
        Me.lblkembalian.AutoSize = True
        Me.lblkembalian.Location = New System.Drawing.Point(333, 64)
        Me.lblkembalian.Name = "lblkembalian"
        Me.lblkembalian.Size = New System.Drawing.Size(18, 20)
        Me.lblkembalian.TabIndex = 6
        Me.lblkembalian.Text = "0"
        '
        'txtbayar
        '
        Me.txtbayar.Location = New System.Drawing.Point(559, 19)
        Me.txtbayar.Name = "txtbayar"
        Me.txtbayar.Size = New System.Drawing.Size(148, 26)
        Me.txtbayar.TabIndex = 5
        Me.txtbayar.Text = "Masukan Tunai"
        Me.txtbayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblgrandtotal
        '
        Me.lblgrandtotal.AutoSize = True
        Me.lblgrandtotal.Location = New System.Drawing.Point(333, 20)
        Me.lblgrandtotal.Name = "lblgrandtotal"
        Me.lblgrandtotal.Size = New System.Drawing.Size(18, 20)
        Me.lblgrandtotal.TabIndex = 3
        Me.lblgrandtotal.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Kembalian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "TOTAL"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 572)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormUtama"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvkeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnbarang As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btninput As Button
    Friend WithEvents txtcaribarang As TextBox
    Friend WithEvents lbljam As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvkeranjang As DataGridView
    Friend WithEvents lblgrandtotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents lblkembalian As Label
    Friend WithEvents btnbayar As Button
    Friend WithEvents btnlaporan As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btntambahbarang As Button
    Friend WithEvents lblsapaan As Label
    Friend WithEvents lblrole As Label
End Class
