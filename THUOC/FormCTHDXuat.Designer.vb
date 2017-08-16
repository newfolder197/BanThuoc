<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCTHDXuat
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCTHDXuat))
        Me.lbSoLuongXuat = New System.Windows.Forms.Label()
        Me.txtSoLuongXuat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbDonGiaXuat = New System.Windows.Forms.Label()
        Me.txtDonGiaXuat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbMaThuoc = New System.Windows.Forms.ComboBox()
        Me.dgvCTHDXuat = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbSoCTXuat = New System.Windows.Forms.Label()
        Me.txtSoCTXuat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInHoaDonXuat = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCapNhat = New Bunifu.Framework.UI.BunifuTileButton()
        Me.txtTongTienXuat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpngayxuat = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbsophieuxuat = New System.Windows.Forms.Label()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvCTHDXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbSoLuongXuat
        '
        Me.lbSoLuongXuat.AutoSize = True
        Me.lbSoLuongXuat.ForeColor = System.Drawing.Color.Red
        Me.lbSoLuongXuat.Location = New System.Drawing.Point(89, 326)
        Me.lbSoLuongXuat.Name = "lbSoLuongXuat"
        Me.lbSoLuongXuat.Size = New System.Drawing.Size(55, 13)
        Me.lbSoLuongXuat.TabIndex = 110
        Me.lbSoLuongXuat.Text = "thong bao"
        '
        'txtSoLuongXuat
        '
        Me.txtSoLuongXuat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoLuongXuat.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSoLuongXuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoLuongXuat.HintForeColor = System.Drawing.Color.Empty
        Me.txtSoLuongXuat.HintText = ""
        Me.txtSoLuongXuat.isPassword = False
        Me.txtSoLuongXuat.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSoLuongXuat.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSoLuongXuat.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSoLuongXuat.LineThickness = 3
        Me.txtSoLuongXuat.Location = New System.Drawing.Point(81, 292)
        Me.txtSoLuongXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoLuongXuat.Name = "txtSoLuongXuat"
        Me.txtSoLuongXuat.Size = New System.Drawing.Size(370, 30)
        Me.txtSoLuongXuat.TabIndex = 109
        Me.txtSoLuongXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Số Lượng Xuất"
        '
        'lbDonGiaXuat
        '
        Me.lbDonGiaXuat.AutoSize = True
        Me.lbDonGiaXuat.ForeColor = System.Drawing.Color.Red
        Me.lbDonGiaXuat.Location = New System.Drawing.Point(89, 258)
        Me.lbDonGiaXuat.Name = "lbDonGiaXuat"
        Me.lbDonGiaXuat.Size = New System.Drawing.Size(55, 13)
        Me.lbDonGiaXuat.TabIndex = 107
        Me.lbDonGiaXuat.Text = "thong bao"
        '
        'txtDonGiaXuat
        '
        Me.txtDonGiaXuat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDonGiaXuat.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDonGiaXuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDonGiaXuat.HintForeColor = System.Drawing.Color.Empty
        Me.txtDonGiaXuat.HintText = ""
        Me.txtDonGiaXuat.isPassword = False
        Me.txtDonGiaXuat.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtDonGiaXuat.LineIdleColor = System.Drawing.Color.Gray
        Me.txtDonGiaXuat.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtDonGiaXuat.LineThickness = 3
        Me.txtDonGiaXuat.Location = New System.Drawing.Point(81, 224)
        Me.txtDonGiaXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDonGiaXuat.Name = "txtDonGiaXuat"
        Me.txtDonGiaXuat.Size = New System.Drawing.Size(370, 30)
        Me.txtDonGiaXuat.TabIndex = 106
        Me.txtDonGiaXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Đơn Giá Xuất"
        '
        'cbMaThuoc
        '
        Me.cbMaThuoc.FormattingEnabled = True
        Me.cbMaThuoc.Location = New System.Drawing.Point(81, 179)
        Me.cbMaThuoc.Name = "cbMaThuoc"
        Me.cbMaThuoc.Size = New System.Drawing.Size(370, 21)
        Me.cbMaThuoc.TabIndex = 104
        '
        'dgvCTHDXuat
        '
        Me.dgvCTHDXuat.AllowUserToAddRows = False
        Me.dgvCTHDXuat.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCTHDXuat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCTHDXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCTHDXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCTHDXuat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCTHDXuat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCTHDXuat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCTHDXuat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCTHDXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCTHDXuat.DoubleBuffered = True
        Me.dgvCTHDXuat.EnableHeadersVisualStyles = False
        Me.dgvCTHDXuat.HeaderBgColor = System.Drawing.Color.Gray
        Me.dgvCTHDXuat.HeaderForeColor = System.Drawing.Color.Silver
        Me.dgvCTHDXuat.Location = New System.Drawing.Point(497, 82)
        Me.dgvCTHDXuat.Name = "dgvCTHDXuat"
        Me.dgvCTHDXuat.ReadOnly = True
        Me.dgvCTHDXuat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCTHDXuat.Size = New System.Drawing.Size(557, 257)
        Me.dgvCTHDXuat.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Mã Thuốc"
        '
        'lbSoCTXuat
        '
        Me.lbSoCTXuat.AutoSize = True
        Me.lbSoCTXuat.ForeColor = System.Drawing.Color.Red
        Me.lbSoCTXuat.Location = New System.Drawing.Point(89, 133)
        Me.lbSoCTXuat.Name = "lbSoCTXuat"
        Me.lbSoCTXuat.Size = New System.Drawing.Size(55, 13)
        Me.lbSoCTXuat.TabIndex = 93
        Me.lbSoCTXuat.Text = "thong bao"
        '
        'txtSoCTXuat
        '
        Me.txtSoCTXuat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoCTXuat.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSoCTXuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoCTXuat.HintForeColor = System.Drawing.Color.Empty
        Me.txtSoCTXuat.HintText = ""
        Me.txtSoCTXuat.isPassword = False
        Me.txtSoCTXuat.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSoCTXuat.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSoCTXuat.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSoCTXuat.LineThickness = 3
        Me.txtSoCTXuat.Location = New System.Drawing.Point(81, 99)
        Me.txtSoCTXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoCTXuat.Name = "txtSoCTXuat"
        Me.txtSoCTXuat.Size = New System.Drawing.Size(370, 30)
        Me.txtSoCTXuat.TabIndex = 92
        Me.txtSoCTXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Số Chứng Từ Xuất"
        '
        'btnInHoaDonXuat
        '
        Me.btnInHoaDonXuat.ActiveBorderThickness = 1
        Me.btnInHoaDonXuat.ActiveCornerRadius = 20
        Me.btnInHoaDonXuat.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnInHoaDonXuat.ActiveForecolor = System.Drawing.Color.White
        Me.btnInHoaDonXuat.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnInHoaDonXuat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnInHoaDonXuat.BackgroundImage = CType(resources.GetObject("btnInHoaDonXuat.BackgroundImage"), System.Drawing.Image)
        Me.btnInHoaDonXuat.ButtonText = "In Hóa Đơn"
        Me.btnInHoaDonXuat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInHoaDonXuat.Font = New System.Drawing.Font("Corbel", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInHoaDonXuat.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnInHoaDonXuat.IdleBorderThickness = 1
        Me.btnInHoaDonXuat.IdleCornerRadius = 20
        Me.btnInHoaDonXuat.IdleFillColor = System.Drawing.Color.White
        Me.btnInHoaDonXuat.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnInHoaDonXuat.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnInHoaDonXuat.Location = New System.Drawing.Point(659, 347)
        Me.btnInHoaDonXuat.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnInHoaDonXuat.Name = "btnInHoaDonXuat"
        Me.btnInHoaDonXuat.Size = New System.Drawing.Size(235, 41)
        Me.btnInHoaDonXuat.TabIndex = 111
        Me.btnInHoaDonXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.SeaGreen
        Me.btnXoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnXoa.color = System.Drawing.Color.SeaGreen
        Me.btnXoa.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnXoa.ForeColor = System.Drawing.Color.Transparent
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImagePosition = 0
        Me.btnXoa.ImageZoom = 50
        Me.btnXoa.LabelPosition = 26
        Me.btnXoa.LabelText = "Xóa"
        Me.btnXoa.Location = New System.Drawing.Point(497, 455)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(71, 77)
        Me.btnXoa.TabIndex = 113
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.SeaGreen
        Me.btnThem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnThem.color = System.Drawing.Color.SeaGreen
        Me.btnThem.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnThem.ForeColor = System.Drawing.Color.Transparent
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImagePosition = 0
        Me.btnThem.ImageZoom = 50
        Me.btnThem.LabelPosition = 26
        Me.btnThem.LabelText = "Thêm"
        Me.btnThem.Location = New System.Drawing.Point(643, 455)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 77)
        Me.btnThem.TabIndex = 114
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.SeaGreen
        Me.btnNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnNew.color = System.Drawing.Color.SeaGreen
        Me.btnNew.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.Transparent
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImagePosition = 0
        Me.btnNew.ImageZoom = 50
        Me.btnNew.LabelPosition = 26
        Me.btnNew.LabelText = "New"
        Me.btnNew.Location = New System.Drawing.Point(800, 455)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 77)
        Me.btnNew.TabIndex = 115
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCapNhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnCapNhat.color = System.Drawing.Color.SeaGreen
        Me.btnCapNhat.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnCapNhat.ForeColor = System.Drawing.Color.Transparent
        Me.btnCapNhat.Image = CType(resources.GetObject("btnCapNhat.Image"), System.Drawing.Image)
        Me.btnCapNhat.ImagePosition = 0
        Me.btnCapNhat.ImageZoom = 50
        Me.btnCapNhat.LabelPosition = 26
        Me.btnCapNhat.LabelText = "Cập Nhật"
        Me.btnCapNhat.Location = New System.Drawing.Point(940, 455)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(114, 77)
        Me.btnCapNhat.TabIndex = 116
        '
        'txtTongTienXuat
        '
        Me.txtTongTienXuat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTongTienXuat.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTongTienXuat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTongTienXuat.HintForeColor = System.Drawing.Color.Empty
        Me.txtTongTienXuat.HintText = ""
        Me.txtTongTienXuat.isPassword = False
        Me.txtTongTienXuat.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTongTienXuat.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTongTienXuat.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTongTienXuat.LineThickness = 3
        Me.txtTongTienXuat.Location = New System.Drawing.Point(81, 361)
        Me.txtTongTienXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTongTienXuat.Name = "txtTongTienXuat"
        Me.txtTongTienXuat.Size = New System.Drawing.Size(370, 30)
        Me.txtTongTienXuat.TabIndex = 117
        Me.txtTongTienXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Tổng Tiền Xuất"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Ngày Xuất"
        '
        'dtpngayxuat
        '
        Me.dtpngayxuat.Location = New System.Drawing.Point(81, 421)
        Me.dtpngayxuat.Name = "dtpngayxuat"
        Me.dtpngayxuat.Size = New System.Drawing.Size(370, 20)
        Me.dtpngayxuat.TabIndex = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 17)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Chi Tiết Phiếu Xuất :"
        '
        'lbsophieuxuat
        '
        Me.lbsophieuxuat.AutoSize = True
        Me.lbsophieuxuat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbsophieuxuat.ForeColor = System.Drawing.Color.Blue
        Me.lbsophieuxuat.Location = New System.Drawing.Point(220, 50)
        Me.lbsophieuxuat.Name = "lbsophieuxuat"
        Me.lbsophieuxuat.Size = New System.Drawing.Size(17, 21)
        Me.lbsophieuxuat.TabIndex = 122
        Me.lbsophieuxuat.Text = "s"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(1077, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(24, 24)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnclose.TabIndex = 123
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(848, 355)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'FormCTHDXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lbsophieuxuat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpngayxuat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTongTienXuat)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnInHoaDonXuat)
        Me.Controls.Add(Me.lbSoLuongXuat)
        Me.Controls.Add(Me.txtSoLuongXuat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbDonGiaXuat)
        Me.Controls.Add(Me.txtDonGiaXuat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMaThuoc)
        Me.Controls.Add(Me.dgvCTHDXuat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSoCTXuat)
        Me.Controls.Add(Me.txtSoCTXuat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCTHDXuat"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvCTHDXuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbSoLuongXuat As System.Windows.Forms.Label
    Friend WithEvents txtSoLuongXuat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbDonGiaXuat As System.Windows.Forms.Label
    Friend WithEvents txtDonGiaXuat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMaThuoc As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCTHDXuat As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbSoCTXuat As System.Windows.Forms.Label
    Friend WithEvents txtSoCTXuat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnInHoaDonXuat As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCapNhat As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents txtTongTienXuat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpngayxuat As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents lbsophieuxuat As Label
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
