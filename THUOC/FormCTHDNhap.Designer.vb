<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCTHDNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCTHDNhap))
        Me.cbMaThuoc = New System.Windows.Forms.ComboBox()
        Me.dgvCTHDnhap = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.lbSoLo = New System.Windows.Forms.Label()
        Me.txtSoLo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbSoCTNhap = New System.Windows.Forms.Label()
        Me.txtSoCTNhap = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDonGiaNhap = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbDonGiaNhap = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSoLuongNhap = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbSoLuongNhap = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnInHoaDonXuat = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnSua = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCapNhat = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.dgvCTHDnhap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbMaThuoc
        '
        Me.cbMaThuoc.FormattingEnabled = True
        Me.cbMaThuoc.Location = New System.Drawing.Point(81, 190)
        Me.cbMaThuoc.Name = "cbMaThuoc"
        Me.cbMaThuoc.Size = New System.Drawing.Size(370, 21)
        Me.cbMaThuoc.TabIndex = 79
        '
        'dgvCTHDnhap
        '
        Me.dgvCTHDnhap.AllowUserToAddRows = False
        Me.dgvCTHDnhap.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCTHDnhap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCTHDnhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCTHDnhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCTHDnhap.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCTHDnhap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCTHDnhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCTHDnhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCTHDnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCTHDnhap.DoubleBuffered = True
        Me.dgvCTHDnhap.EnableHeadersVisualStyles = False
        Me.dgvCTHDnhap.HeaderBgColor = System.Drawing.Color.Gray
        Me.dgvCTHDnhap.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvCTHDnhap.Location = New System.Drawing.Point(513, 79)
        Me.dgvCTHDnhap.Name = "dgvCTHDnhap"
        Me.dgvCTHDnhap.ReadOnly = True
        Me.dgvCTHDnhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCTHDnhap.Size = New System.Drawing.Size(557, 382)
        Me.dgvCTHDnhap.TabIndex = 72
        '
        'lbSoLo
        '
        Me.lbSoLo.AutoSize = True
        Me.lbSoLo.ForeColor = System.Drawing.Color.Red
        Me.lbSoLo.Location = New System.Drawing.Point(95, 451)
        Me.lbSoLo.Name = "lbSoLo"
        Me.lbSoLo.Size = New System.Drawing.Size(55, 13)
        Me.lbSoLo.TabIndex = 71
        Me.lbSoLo.Text = "thong bao"
        '
        'txtSoLo
        '
        Me.txtSoLo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoLo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSoLo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoLo.HintForeColor = System.Drawing.Color.Empty
        Me.txtSoLo.HintText = ""
        Me.txtSoLo.isPassword = False
        Me.txtSoLo.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSoLo.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSoLo.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSoLo.LineThickness = 3
        Me.txtSoLo.Location = New System.Drawing.Point(81, 417)
        Me.txtSoLo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoLo.Name = "txtSoLo"
        Me.txtSoLo.Size = New System.Drawing.Size(370, 30)
        Me.txtSoLo.TabIndex = 70
        Me.txtSoLo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Số Lô"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Mã Thuốc"
        '
        'lbSoCTNhap
        '
        Me.lbSoCTNhap.AutoSize = True
        Me.lbSoCTNhap.ForeColor = System.Drawing.Color.Red
        Me.lbSoCTNhap.Location = New System.Drawing.Point(89, 130)
        Me.lbSoCTNhap.Name = "lbSoCTNhap"
        Me.lbSoCTNhap.Size = New System.Drawing.Size(55, 13)
        Me.lbSoCTNhap.TabIndex = 66
        Me.lbSoCTNhap.Text = "thong bao"
        '
        'txtSoCTNhap
        '
        Me.txtSoCTNhap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoCTNhap.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSoCTNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoCTNhap.HintForeColor = System.Drawing.Color.Empty
        Me.txtSoCTNhap.HintText = ""
        Me.txtSoCTNhap.isPassword = False
        Me.txtSoCTNhap.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSoCTNhap.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSoCTNhap.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSoCTNhap.LineThickness = 3
        Me.txtSoCTNhap.Location = New System.Drawing.Point(81, 96)
        Me.txtSoCTNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoCTNhap.Name = "txtSoCTNhap"
        Me.txtSoCTNhap.Size = New System.Drawing.Size(370, 30)
        Me.txtSoCTNhap.TabIndex = 65
        Me.txtSoCTNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Số Chứng Từ Nhập"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Đơn Giá Nhập"
        '
        'txtDonGiaNhap
        '
        Me.txtDonGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDonGiaNhap.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDonGiaNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDonGiaNhap.HintForeColor = System.Drawing.Color.Empty
        Me.txtDonGiaNhap.HintText = ""
        Me.txtDonGiaNhap.isPassword = False
        Me.txtDonGiaNhap.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtDonGiaNhap.LineIdleColor = System.Drawing.Color.Gray
        Me.txtDonGiaNhap.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtDonGiaNhap.LineThickness = 3
        Me.txtDonGiaNhap.Location = New System.Drawing.Point(81, 251)
        Me.txtDonGiaNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDonGiaNhap.Name = "txtDonGiaNhap"
        Me.txtDonGiaNhap.Size = New System.Drawing.Size(370, 30)
        Me.txtDonGiaNhap.TabIndex = 82
        Me.txtDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbDonGiaNhap
        '
        Me.lbDonGiaNhap.AutoSize = True
        Me.lbDonGiaNhap.ForeColor = System.Drawing.Color.Red
        Me.lbDonGiaNhap.Location = New System.Drawing.Point(95, 285)
        Me.lbDonGiaNhap.Name = "lbDonGiaNhap"
        Me.lbDonGiaNhap.Size = New System.Drawing.Size(55, 13)
        Me.lbDonGiaNhap.TabIndex = 83
        Me.lbDonGiaNhap.Text = "thong bao"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Số Lượng Nhập"
        '
        'txtSoLuongNhap
        '
        Me.txtSoLuongNhap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoLuongNhap.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSoLuongNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoLuongNhap.HintForeColor = System.Drawing.Color.Empty
        Me.txtSoLuongNhap.HintText = ""
        Me.txtSoLuongNhap.isPassword = False
        Me.txtSoLuongNhap.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSoLuongNhap.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSoLuongNhap.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSoLuongNhap.LineThickness = 3
        Me.txtSoLuongNhap.Location = New System.Drawing.Point(81, 340)
        Me.txtSoLuongNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoLuongNhap.Name = "txtSoLuongNhap"
        Me.txtSoLuongNhap.Size = New System.Drawing.Size(370, 30)
        Me.txtSoLuongNhap.TabIndex = 85
        Me.txtSoLuongNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbSoLuongNhap
        '
        Me.lbSoLuongNhap.AutoSize = True
        Me.lbSoLuongNhap.ForeColor = System.Drawing.Color.Red
        Me.lbSoLuongNhap.Location = New System.Drawing.Point(95, 374)
        Me.lbSoLuongNhap.Name = "lbSoLuongNhap"
        Me.lbSoLuongNhap.Size = New System.Drawing.Size(55, 13)
        Me.lbSoLuongNhap.TabIndex = 86
        Me.lbSoLuongNhap.Text = "thong bao"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 475)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Ngày Sản Xuất"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 502)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(370, 20)
        Me.DateTimePicker1.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(78, 532)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Hạn Sử Dụng"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(81, 559)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(370, 20)
        Me.DateTimePicker2.TabIndex = 90
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
        Me.btnInHoaDonXuat.Location = New System.Drawing.Point(679, 469)
        Me.btnInHoaDonXuat.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnInHoaDonXuat.Name = "btnInHoaDonXuat"
        Me.btnInHoaDonXuat.Size = New System.Drawing.Size(235, 41)
        Me.btnInHoaDonXuat.TabIndex = 112
        Me.btnInHoaDonXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSua
        '
        Me.btnSua.BackColor = System.Drawing.Color.SeaGreen
        Me.btnSua.color = System.Drawing.Color.SeaGreen
        Me.btnSua.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnSua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSua.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.ForeColor = System.Drawing.Color.White
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.ImagePosition = 0
        Me.btnSua.ImageZoom = 50
        Me.btnSua.LabelPosition = 26
        Me.btnSua.LabelText = "Sửa"
        Me.btnSua.Location = New System.Drawing.Point(513, 532)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(71, 77)
        Me.btnSua.TabIndex = 113
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.SeaGreen
        Me.btnXoa.color = System.Drawing.Color.SeaGreen
        Me.btnXoa.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnXoa.ForeColor = System.Drawing.Color.White
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImagePosition = 0
        Me.btnXoa.ImageZoom = 50
        Me.btnXoa.LabelPosition = 26
        Me.btnXoa.LabelText = "Xóa"
        Me.btnXoa.Location = New System.Drawing.Point(621, 532)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(71, 77)
        Me.btnXoa.TabIndex = 114
        '
        'btnThem
        '
        Me.btnThem.BackColor = System.Drawing.Color.SeaGreen
        Me.btnThem.color = System.Drawing.Color.SeaGreen
        Me.btnThem.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnThem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnThem.ForeColor = System.Drawing.Color.White
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImagePosition = 0
        Me.btnThem.ImageZoom = 50
        Me.btnThem.LabelPosition = 26
        Me.btnThem.LabelText = "Thêm"
        Me.btnThem.Location = New System.Drawing.Point(734, 532)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(71, 77)
        Me.btnThem.TabIndex = 115
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.SeaGreen
        Me.btnNew.color = System.Drawing.Color.SeaGreen
        Me.btnNew.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImagePosition = 0
        Me.btnNew.ImageZoom = 50
        Me.btnNew.LabelPosition = 26
        Me.btnNew.LabelText = "New"
        Me.btnNew.Location = New System.Drawing.Point(843, 532)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 77)
        Me.btnNew.TabIndex = 116
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCapNhat.color = System.Drawing.Color.SeaGreen
        Me.btnCapNhat.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCapNhat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnCapNhat.ForeColor = System.Drawing.Color.White
        Me.btnCapNhat.Image = CType(resources.GetObject("btnCapNhat.Image"), System.Drawing.Image)
        Me.btnCapNhat.ImagePosition = 0
        Me.btnCapNhat.ImageZoom = 50
        Me.btnCapNhat.LabelPosition = 26
        Me.btnCapNhat.LabelText = "Cập Nhật"
        Me.btnCapNhat.Location = New System.Drawing.Point(956, 532)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(114, 77)
        Me.btnCapNhat.TabIndex = 117
        '
        'FormCTHDNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnInHoaDonXuat)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbSoLuongNhap)
        Me.Controls.Add(Me.txtSoLuongNhap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbDonGiaNhap)
        Me.Controls.Add(Me.txtDonGiaNhap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMaThuoc)
        Me.Controls.Add(Me.dgvCTHDnhap)
        Me.Controls.Add(Me.lbSoLo)
        Me.Controls.Add(Me.txtSoLo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSoCTNhap)
        Me.Controls.Add(Me.txtSoCTNhap)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCTHDNhap"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvCTHDnhap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbMaThuoc As System.Windows.Forms.ComboBox
    Friend WithEvents dgvCTHDnhap As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lbSoLo As System.Windows.Forms.Label
    Friend WithEvents txtSoLo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbSoCTNhap As System.Windows.Forms.Label
    Friend WithEvents txtSoCTNhap As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDonGiaNhap As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbDonGiaNhap As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSoLuongNhap As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbSoLuongNhap As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnInHoaDonXuat As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnSua As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCapNhat As Bunifu.Framework.UI.BunifuTileButton

End Class
