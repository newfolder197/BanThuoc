<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormThuoc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormThuoc))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbMaNhom = New System.Windows.Forms.ComboBox()
        Me.lbMaThuoc = New System.Windows.Forms.Label()
        Me.lbMaNhom = New System.Windows.Forms.Label()
        Me.lbTenThuoc = New System.Windows.Forms.Label()
        Me.txtCongDung = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbCongDung = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDvt = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbDvt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSoLuong = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtTenThuoc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbSoLuong = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtGiaBan = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbGiaBan = New System.Windows.Forms.Label()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnSua = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCapNhat = New Bunifu.Framework.UI.BunifuTileButton()
        Me.txtMaThuoc = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvThuoc = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Thuốc"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Công Dụng"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mã Nhóm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tên Thuốc"
        '
        'cbMaNhom
        '
        Me.cbMaNhom.FormattingEnabled = True
        Me.cbMaNhom.Location = New System.Drawing.Point(89, 169)
        Me.cbMaNhom.Name = "cbMaNhom"
        Me.cbMaNhom.Size = New System.Drawing.Size(283, 21)
        Me.cbMaNhom.TabIndex = 8
        '
        'lbMaThuoc
        '
        Me.lbMaThuoc.AutoSize = True
        Me.lbMaThuoc.ForeColor = System.Drawing.Color.Red
        Me.lbMaThuoc.Location = New System.Drawing.Point(101, 129)
        Me.lbMaThuoc.Name = "lbMaThuoc"
        Me.lbMaThuoc.Size = New System.Drawing.Size(55, 13)
        Me.lbMaThuoc.TabIndex = 9
        Me.lbMaThuoc.Text = "thong bao"
        '
        'lbMaNhom
        '
        Me.lbMaNhom.AutoSize = True
        Me.lbMaNhom.ForeColor = System.Drawing.Color.Red
        Me.lbMaNhom.Location = New System.Drawing.Point(101, 193)
        Me.lbMaNhom.Name = "lbMaNhom"
        Me.lbMaNhom.Size = New System.Drawing.Size(55, 13)
        Me.lbMaNhom.TabIndex = 10
        Me.lbMaNhom.Text = "thong bao"
        '
        'lbTenThuoc
        '
        Me.lbTenThuoc.AutoSize = True
        Me.lbTenThuoc.ForeColor = System.Drawing.Color.Red
        Me.lbTenThuoc.Location = New System.Drawing.Point(101, 270)
        Me.lbTenThuoc.Name = "lbTenThuoc"
        Me.lbTenThuoc.Size = New System.Drawing.Size(55, 13)
        Me.lbTenThuoc.TabIndex = 11
        Me.lbTenThuoc.Text = "thong bao"
        '
        'txtCongDung
        '
        Me.txtCongDung.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCongDung.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCongDung.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCongDung.HintForeColor = System.Drawing.Color.Empty
        Me.txtCongDung.HintText = ""
        Me.txtCongDung.isPassword = False
        Me.txtCongDung.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCongDung.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCongDung.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCongDung.LineThickness = 3
        Me.txtCongDung.Location = New System.Drawing.Point(89, 310)
        Me.txtCongDung.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCongDung.Name = "txtCongDung"
        Me.txtCongDung.Size = New System.Drawing.Size(283, 34)
        Me.txtCongDung.TabIndex = 3
        Me.txtCongDung.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbCongDung
        '
        Me.lbCongDung.AutoSize = True
        Me.lbCongDung.ForeColor = System.Drawing.Color.Red
        Me.lbCongDung.Location = New System.Drawing.Point(101, 348)
        Me.lbCongDung.Name = "lbCongDung"
        Me.lbCongDung.Size = New System.Drawing.Size(55, 13)
        Me.lbCongDung.TabIndex = 13
        Me.lbCongDung.Text = "thong bao"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Đơn Vị Tính"
        '
        'txtDvt
        '
        Me.txtDvt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDvt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDvt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDvt.HintForeColor = System.Drawing.Color.Empty
        Me.txtDvt.HintText = ""
        Me.txtDvt.isPassword = False
        Me.txtDvt.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtDvt.LineIdleColor = System.Drawing.Color.Gray
        Me.txtDvt.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtDvt.LineThickness = 3
        Me.txtDvt.Location = New System.Drawing.Point(89, 388)
        Me.txtDvt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDvt.Name = "txtDvt"
        Me.txtDvt.Size = New System.Drawing.Size(283, 34)
        Me.txtDvt.TabIndex = 4
        Me.txtDvt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbDvt
        '
        Me.lbDvt.AutoSize = True
        Me.lbDvt.ForeColor = System.Drawing.Color.Red
        Me.lbDvt.Location = New System.Drawing.Point(101, 428)
        Me.lbDvt.Name = "lbDvt"
        Me.lbDvt.Size = New System.Drawing.Size(55, 13)
        Me.lbDvt.TabIndex = 16
        Me.lbDvt.Text = "thong bao"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 450)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Số Lượng"
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSoLuong.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSoLuong.HintForeColor = System.Drawing.Color.Empty
        Me.txtSoLuong.HintText = ""
        Me.txtSoLuong.isPassword = False
        Me.txtSoLuong.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSoLuong.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSoLuong.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSoLuong.LineThickness = 3
        Me.txtSoLuong.Location = New System.Drawing.Point(89, 467)
        Me.txtSoLuong.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(283, 34)
        Me.txtSoLuong.TabIndex = 5
        Me.txtSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTenThuoc
        '
        Me.txtTenThuoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenThuoc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTenThuoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTenThuoc.HintForeColor = System.Drawing.Color.Empty
        Me.txtTenThuoc.HintText = ""
        Me.txtTenThuoc.isPassword = False
        Me.txtTenThuoc.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTenThuoc.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTenThuoc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTenThuoc.LineThickness = 3
        Me.txtTenThuoc.Location = New System.Drawing.Point(89, 232)
        Me.txtTenThuoc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenThuoc.Name = "txtTenThuoc"
        Me.txtTenThuoc.Size = New System.Drawing.Size(283, 34)
        Me.txtTenThuoc.TabIndex = 2
        Me.txtTenThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbSoLuong
        '
        Me.lbSoLuong.AutoSize = True
        Me.lbSoLuong.ForeColor = System.Drawing.Color.Red
        Me.lbSoLuong.Location = New System.Drawing.Point(101, 505)
        Me.lbSoLuong.Name = "lbSoLuong"
        Me.lbSoLuong.Size = New System.Drawing.Size(55, 13)
        Me.lbSoLuong.TabIndex = 19
        Me.lbSoLuong.Text = "thong bao"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(399, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Ngày Sản Xuất"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(402, 422)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(669, 406)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Hạn Sử Dụng"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(672, 422)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 535)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Giá Bán"
        '
        'txtGiaBan
        '
        Me.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGiaBan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGiaBan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGiaBan.HintForeColor = System.Drawing.Color.Empty
        Me.txtGiaBan.HintText = ""
        Me.txtGiaBan.isPassword = False
        Me.txtGiaBan.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtGiaBan.LineIdleColor = System.Drawing.Color.Gray
        Me.txtGiaBan.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtGiaBan.LineThickness = 3
        Me.txtGiaBan.Location = New System.Drawing.Point(89, 552)
        Me.txtGiaBan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGiaBan.Name = "txtGiaBan"
        Me.txtGiaBan.Size = New System.Drawing.Size(283, 34)
        Me.txtGiaBan.TabIndex = 6
        Me.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbGiaBan
        '
        Me.lbGiaBan.AutoSize = True
        Me.lbGiaBan.ForeColor = System.Drawing.Color.Red
        Me.lbGiaBan.Location = New System.Drawing.Point(101, 590)
        Me.lbGiaBan.Name = "lbGiaBan"
        Me.lbGiaBan.Size = New System.Drawing.Size(55, 13)
        Me.lbGiaBan.TabIndex = 26
        Me.lbGiaBan.Text = "thong bao"
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
        Me.btnThem.Location = New System.Drawing.Point(695, 494)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(71, 77)
        Me.btnThem.TabIndex = 30
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
        Me.btnXoa.Location = New System.Drawing.Point(564, 494)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(71, 77)
        Me.btnXoa.TabIndex = 31
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
        Me.btnSua.Location = New System.Drawing.Point(428, 494)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(71, 77)
        Me.btnSua.TabIndex = 33
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
        Me.btnNew.Location = New System.Drawing.Point(828, 494)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 77)
        Me.btnNew.TabIndex = 34
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
        Me.btnCapNhat.Location = New System.Drawing.Point(956, 494)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(114, 77)
        Me.btnCapNhat.TabIndex = 35
        '
        'txtMaThuoc
        '
        Me.txtMaThuoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaThuoc.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMaThuoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMaThuoc.HintForeColor = System.Drawing.Color.Empty
        Me.txtMaThuoc.HintText = ""
        Me.txtMaThuoc.isPassword = False
        Me.txtMaThuoc.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMaThuoc.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMaThuoc.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMaThuoc.LineThickness = 3
        Me.txtMaThuoc.Location = New System.Drawing.Point(89, 91)
        Me.txtMaThuoc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaThuoc.Name = "txtMaThuoc"
        Me.txtMaThuoc.Size = New System.Drawing.Size(283, 34)
        Me.txtMaThuoc.TabIndex = 36
        Me.txtMaThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvThuoc
        '
        Me.dgvThuoc.AllowUserToAddRows = False
        Me.dgvThuoc.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvThuoc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvThuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvThuoc.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvThuoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThuoc.DoubleBuffered = True
        Me.dgvThuoc.EnableHeadersVisualStyles = False
        Me.dgvThuoc.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvThuoc.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvThuoc.Location = New System.Drawing.Point(428, 73)
        Me.dgvThuoc.Name = "dgvThuoc"
        Me.dgvThuoc.ReadOnly = True
        Me.dgvThuoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvThuoc.Size = New System.Drawing.Size(642, 320)
        Me.dgvThuoc.TabIndex = 37
        '
        'FormThuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.dgvThuoc)
        Me.Controls.Add(Me.txtMaThuoc)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lbGiaBan)
        Me.Controls.Add(Me.txtGiaBan)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbSoLuong)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbDvt)
        Me.Controls.Add(Me.txtDvt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbCongDung)
        Me.Controls.Add(Me.txtCongDung)
        Me.Controls.Add(Me.lbTenThuoc)
        Me.Controls.Add(Me.lbMaNhom)
        Me.Controls.Add(Me.lbMaThuoc)
        Me.Controls.Add(Me.cbMaNhom)
        Me.Controls.Add(Me.txtTenThuoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormThuoc"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbMaNhom As System.Windows.Forms.ComboBox
    Friend WithEvents lbMaThuoc As System.Windows.Forms.Label
    Friend WithEvents lbMaNhom As System.Windows.Forms.Label
    Friend WithEvents lbTenThuoc As System.Windows.Forms.Label
    Friend WithEvents txtCongDung As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbCongDung As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDvt As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbDvt As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSoLuong As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtTenThuoc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbSoLuong As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtGiaBan As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbGiaBan As System.Windows.Forms.Label
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnSua As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCapNhat As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents txtMaThuoc As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvThuoc As Bunifu.Framework.UI.BunifuCustomDataGrid

End Class
