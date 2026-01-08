<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncari = New System.Windows.Forms.Button()
        Me.dtpsampai = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpdari = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvlaporan = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblbersih = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.btntutup = New System.Windows.Forms.Button()
        Me.lblmodal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvlaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btncari)
        Me.Panel1.Controls.Add(Me.dtpsampai)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.dtpdari)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(25, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 186)
        Me.Panel1.TabIndex = 0
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(518, 150)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(106, 33)
        Me.btncari.TabIndex = 5
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'dtpsampai
        '
        Me.dtpsampai.Location = New System.Drawing.Point(381, 100)
        Me.dtpsampai.Name = "dtpsampai"
        Me.dtpsampai.Size = New System.Drawing.Size(168, 26)
        Me.dtpsampai.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Sampai tanggal :"
        '
        'dtpdari
        '
        Me.dtpdari.Location = New System.Drawing.Point(40, 100)
        Me.dtpdari.Name = "dtpdari"
        Me.dtpdari.Size = New System.Drawing.Size(168, 26)
        Me.dtpdari.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dari tanggal :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Periode"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvlaporan)
        Me.Panel2.Location = New System.Drawing.Point(25, 280)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(746, 273)
        Me.Panel2.TabIndex = 1
        '
        'dgvlaporan
        '
        Me.dgvlaporan.BackgroundColor = System.Drawing.Color.White
        Me.dgvlaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlaporan.Location = New System.Drawing.Point(40, 26)
        Me.dgvlaporan.Name = "dgvlaporan"
        Me.dgvlaporan.RowHeadersWidth = 62
        Me.dgvlaporan.RowTemplate.Height = 28
        Me.dgvlaporan.Size = New System.Drawing.Size(669, 217)
        Me.dgvlaporan.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblbersih)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btncetak)
        Me.Panel3.Controls.Add(Me.btntutup)
        Me.Panel3.Controls.Add(Me.lblmodal)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(25, 574)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(746, 75)
        Me.Panel3.TabIndex = 2
        '
        'lblbersih
        '
        Me.lblbersih.AutoSize = True
        Me.lblbersih.Location = New System.Drawing.Point(164, 40)
        Me.lblbersih.Name = "lblbersih"
        Me.lblbersih.Size = New System.Drawing.Size(18, 20)
        Me.lblbersih.TabIndex = 6
        Me.lblbersih.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Pendapatan bersih :"
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(543, 11)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(81, 31)
        Me.btncetak.TabIndex = 4
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'btntutup
        '
        Me.btntutup.Location = New System.Drawing.Point(634, 11)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(81, 31)
        Me.btntutup.TabIndex = 3
        Me.btntutup.Text = "Kembali"
        Me.btntutup.UseVisualStyleBackColor = True
        '
        'lblmodal
        '
        Me.lblmodal.AutoSize = True
        Me.lblmodal.Location = New System.Drawing.Point(164, 11)
        Me.lblmodal.Name = "lblmodal"
        Me.lblmodal.Size = New System.Drawing.Size(18, 20)
        Me.lblmodal.TabIndex = 2
        Me.lblmodal.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Pendapatan :"
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 661)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormLaporan"
        Me.Text = "FormLaporan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvlaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btncari As Button
    Friend WithEvents dtpsampai As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpdari As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvlaporan As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btncetak As Button
    Friend WithEvents btntutup As Button
    Friend WithEvents lblmodal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblbersih As Label
End Class
