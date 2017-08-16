<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNhanVien
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNhanVien))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtMaNhanVien = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenNhanVien = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChucVu = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGioiTinh = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbMaNhanVien = New System.Windows.Forms.Label()
        Me.lbTenNhanVien = New System.Windows.Forms.Label()
        Me.lbChucVu = New System.Windows.Forms.Label()
        Me.lbGioiTinh = New System.Windows.Forms.Label()
        Me.lbNamSinh = New System.Windows.Forms.Label()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCMND = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbCMND = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPhanQuyen = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbPhanQuyen = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txttaiKhoan = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbTaiKhoan = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMatKhau = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbMatKhau = New System.Windows.Forms.Label()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCapNhat = New Bunifu.Framework.UI.BunifuTileButton()
        Me.dgvNhanVien = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.txtNamSinh = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btndelsearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTimKiemNV = New System.Windows.Forms.TextBox()
        Me.btnXuatExcel = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndelsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaNhanVien
        '
        Me.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaNhanVien.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMaNhanVien.HintForeColor = System.Drawing.Color.Empty
        Me.txtMaNhanVien.HintText = ""
        Me.txtMaNhanVien.isPassword = False
        Me.txtMaNhanVien.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMaNhanVien.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMaNhanVien.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMaNhanVien.LineThickness = 3
        Me.txtMaNhanVien.Location = New System.Drawing.Point(77, 99)
        Me.txtMaNhanVien.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaNhanVien.Name = "txtMaNhanVien"
        Me.txtMaNhanVien.Size = New System.Drawing.Size(370, 32)
        Me.txtMaNhanVien.TabIndex = 0
        Me.txtMaNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mã Nhân Viên"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Nhân Viên"
        '
        'txtTenNhanVien
        '
        Me.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenNhanVien.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTenNhanVien.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTenNhanVien.HintForeColor = System.Drawing.Color.Empty
        Me.txtTenNhanVien.HintText = ""
        Me.txtTenNhanVien.isPassword = False
        Me.txtTenNhanVien.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTenNhanVien.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTenNhanVien.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTenNhanVien.LineThickness = 3
        Me.txtTenNhanVien.Location = New System.Drawing.Point(77, 171)
        Me.txtTenNhanVien.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenNhanVien.Name = "txtTenNhanVien"
        Me.txtTenNhanVien.Size = New System.Drawing.Size(370, 32)
        Me.txtTenNhanVien.TabIndex = 3
        Me.txtTenNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Chức Vụ"
        '
        'txtChucVu
        '
        Me.txtChucVu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChucVu.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtChucVu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtChucVu.HintForeColor = System.Drawing.Color.Empty
        Me.txtChucVu.HintText = ""
        Me.txtChucVu.isPassword = False
        Me.txtChucVu.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtChucVu.LineIdleColor = System.Drawing.Color.Gray
        Me.txtChucVu.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtChucVu.LineThickness = 3
        Me.txtChucVu.Location = New System.Drawing.Point(77, 234)
        Me.txtChucVu.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChucVu.Name = "txtChucVu"
        Me.txtChucVu.Size = New System.Drawing.Size(370, 32)
        Me.txtChucVu.TabIndex = 5
        Me.txtChucVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Giới Tính"
        '
        'txtGioiTinh
        '
        Me.txtGioiTinh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGioiTinh.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtGioiTinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGioiTinh.HintForeColor = System.Drawing.Color.Empty
        Me.txtGioiTinh.HintText = ""
        Me.txtGioiTinh.isPassword = False
        Me.txtGioiTinh.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtGioiTinh.LineIdleColor = System.Drawing.Color.Gray
        Me.txtGioiTinh.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtGioiTinh.LineThickness = 3
        Me.txtGioiTinh.Location = New System.Drawing.Point(77, 300)
        Me.txtGioiTinh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGioiTinh.Name = "txtGioiTinh"
        Me.txtGioiTinh.Size = New System.Drawing.Size(370, 32)
        Me.txtGioiTinh.TabIndex = 7
        Me.txtGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 349)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Năm Sinh"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Địa Chỉ"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiaChi.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDiaChi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDiaChi.HintForeColor = System.Drawing.Color.Empty
        Me.txtDiaChi.HintText = ""
        Me.txtDiaChi.isPassword = False
        Me.txtDiaChi.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtDiaChi.LineIdleColor = System.Drawing.Color.Gray
        Me.txtDiaChi.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtDiaChi.LineThickness = 3
        Me.txtDiaChi.Location = New System.Drawing.Point(77, 432)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(370, 32)
        Me.txtDiaChi.TabIndex = 11
        Me.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbMaNhanVien
        '
        Me.lbMaNhanVien.AutoSize = True
        Me.lbMaNhanVien.ForeColor = System.Drawing.Color.Red
        Me.lbMaNhanVien.Location = New System.Drawing.Point(81, 135)
        Me.lbMaNhanVien.Name = "lbMaNhanVien"
        Me.lbMaNhanVien.Size = New System.Drawing.Size(55, 13)
        Me.lbMaNhanVien.TabIndex = 12
        Me.lbMaNhanVien.Text = "thong bao"
        '
        'lbTenNhanVien
        '
        Me.lbTenNhanVien.AutoSize = True
        Me.lbTenNhanVien.ForeColor = System.Drawing.Color.Red
        Me.lbTenNhanVien.Location = New System.Drawing.Point(81, 207)
        Me.lbTenNhanVien.Name = "lbTenNhanVien"
        Me.lbTenNhanVien.Size = New System.Drawing.Size(55, 13)
        Me.lbTenNhanVien.TabIndex = 13
        Me.lbTenNhanVien.Text = "thong bao"
        '
        'lbChucVu
        '
        Me.lbChucVu.AutoSize = True
        Me.lbChucVu.ForeColor = System.Drawing.Color.Red
        Me.lbChucVu.Location = New System.Drawing.Point(81, 270)
        Me.lbChucVu.Name = "lbChucVu"
        Me.lbChucVu.Size = New System.Drawing.Size(55, 13)
        Me.lbChucVu.TabIndex = 14
        Me.lbChucVu.Text = "thong bao"
        '
        'lbGioiTinh
        '
        Me.lbGioiTinh.AutoSize = True
        Me.lbGioiTinh.ForeColor = System.Drawing.Color.Red
        Me.lbGioiTinh.Location = New System.Drawing.Point(81, 336)
        Me.lbGioiTinh.Name = "lbGioiTinh"
        Me.lbGioiTinh.Size = New System.Drawing.Size(55, 13)
        Me.lbGioiTinh.TabIndex = 15
        Me.lbGioiTinh.Text = "thong bao"
        '
        'lbNamSinh
        '
        Me.lbNamSinh.AutoSize = True
        Me.lbNamSinh.ForeColor = System.Drawing.Color.Red
        Me.lbNamSinh.Location = New System.Drawing.Point(81, 402)
        Me.lbNamSinh.Name = "lbNamSinh"
        Me.lbNamSinh.Size = New System.Drawing.Size(55, 13)
        Me.lbNamSinh.TabIndex = 16
        Me.lbNamSinh.Text = "thong bao"
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.ForeColor = System.Drawing.Color.Red
        Me.lbDiaChi.Location = New System.Drawing.Point(81, 468)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(55, 13)
        Me.lbDiaChi.TabIndex = 17
        Me.lbDiaChi.Text = "thong bao"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(74, 481)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Chứng Minh Nhân Dân"
        '
        'txtCMND
        '
        Me.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCMND.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCMND.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCMND.HintForeColor = System.Drawing.Color.Empty
        Me.txtCMND.HintText = ""
        Me.txtCMND.isPassword = False
        Me.txtCMND.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtCMND.LineIdleColor = System.Drawing.Color.Gray
        Me.txtCMND.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtCMND.LineThickness = 3
        Me.txtCMND.Location = New System.Drawing.Point(77, 498)
        Me.txtCMND.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCMND.Name = "txtCMND"
        Me.txtCMND.Size = New System.Drawing.Size(370, 32)
        Me.txtCMND.TabIndex = 19
        Me.txtCMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbCMND
        '
        Me.lbCMND.AutoSize = True
        Me.lbCMND.ForeColor = System.Drawing.Color.Red
        Me.lbCMND.Location = New System.Drawing.Point(81, 534)
        Me.lbCMND.Name = "lbCMND"
        Me.lbCMND.Size = New System.Drawing.Size(55, 13)
        Me.lbCMND.TabIndex = 20
        Me.lbCMND.Text = "thong bao"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(74, 547)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Phân Quyền"
        '
        'txtPhanQuyen
        '
        Me.txtPhanQuyen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhanQuyen.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPhanQuyen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPhanQuyen.HintForeColor = System.Drawing.Color.Empty
        Me.txtPhanQuyen.HintText = ""
        Me.txtPhanQuyen.isPassword = False
        Me.txtPhanQuyen.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtPhanQuyen.LineIdleColor = System.Drawing.Color.Gray
        Me.txtPhanQuyen.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtPhanQuyen.LineThickness = 3
        Me.txtPhanQuyen.Location = New System.Drawing.Point(77, 564)
        Me.txtPhanQuyen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhanQuyen.Name = "txtPhanQuyen"
        Me.txtPhanQuyen.Size = New System.Drawing.Size(370, 32)
        Me.txtPhanQuyen.TabIndex = 22
        Me.txtPhanQuyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbPhanQuyen
        '
        Me.lbPhanQuyen.AutoSize = True
        Me.lbPhanQuyen.ForeColor = System.Drawing.Color.Red
        Me.lbPhanQuyen.Location = New System.Drawing.Point(81, 600)
        Me.lbPhanQuyen.Name = "lbPhanQuyen"
        Me.lbPhanQuyen.Size = New System.Drawing.Size(55, 13)
        Me.lbPhanQuyen.TabIndex = 23
        Me.lbPhanQuyen.Text = "thong bao"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(482, 349)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Tài khoản"
        '
        'txttaiKhoan
        '
        Me.txttaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttaiKhoan.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txttaiKhoan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txttaiKhoan.HintForeColor = System.Drawing.Color.Empty
        Me.txttaiKhoan.HintText = ""
        Me.txttaiKhoan.isPassword = False
        Me.txttaiKhoan.LineFocusedColor = System.Drawing.Color.Blue
        Me.txttaiKhoan.LineIdleColor = System.Drawing.Color.Gray
        Me.txttaiKhoan.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txttaiKhoan.LineThickness = 3
        Me.txttaiKhoan.Location = New System.Drawing.Point(485, 366)
        Me.txttaiKhoan.Margin = New System.Windows.Forms.Padding(4)
        Me.txttaiKhoan.Name = "txttaiKhoan"
        Me.txttaiKhoan.Size = New System.Drawing.Size(370, 32)
        Me.txttaiKhoan.TabIndex = 25
        Me.txttaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbTaiKhoan
        '
        Me.lbTaiKhoan.AutoSize = True
        Me.lbTaiKhoan.ForeColor = System.Drawing.Color.Red
        Me.lbTaiKhoan.Location = New System.Drawing.Point(493, 402)
        Me.lbTaiKhoan.Name = "lbTaiKhoan"
        Me.lbTaiKhoan.Size = New System.Drawing.Size(55, 13)
        Me.lbTaiKhoan.TabIndex = 26
        Me.lbTaiKhoan.Text = "thong bao"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(482, 415)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Mật Khẩu"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMatKhau.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMatKhau.HintForeColor = System.Drawing.Color.Empty
        Me.txtMatKhau.HintText = ""
        Me.txtMatKhau.isPassword = False
        Me.txtMatKhau.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMatKhau.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMatKhau.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMatKhau.LineThickness = 3
        Me.txtMatKhau.Location = New System.Drawing.Point(485, 432)
        Me.txtMatKhau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(370, 32)
        Me.txtMatKhau.TabIndex = 28
        Me.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbMatKhau
        '
        Me.lbMatKhau.AutoSize = True
        Me.lbMatKhau.ForeColor = System.Drawing.Color.Red
        Me.lbMatKhau.Location = New System.Drawing.Point(493, 468)
        Me.lbMatKhau.Name = "lbMatKhau"
        Me.lbMatKhau.Size = New System.Drawing.Size(55, 13)
        Me.lbMatKhau.TabIndex = 29
        Me.lbMatKhau.Text = "thong bao"
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
        Me.btnXoa.Location = New System.Drawing.Point(485, 519)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(71, 77)
        Me.btnXoa.TabIndex = 35
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
        Me.btnThem.Location = New System.Drawing.Point(639, 519)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(71, 77)
        Me.btnThem.TabIndex = 36
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
        Me.btnNew.Location = New System.Drawing.Point(784, 519)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 77)
        Me.btnNew.TabIndex = 37
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
        Me.btnCapNhat.Location = New System.Drawing.Point(931, 519)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(114, 77)
        Me.btnCapNhat.TabIndex = 38
        '
        'dgvNhanVien
        '
        Me.dgvNhanVien.AllowUserToAddRows = False
        Me.dgvNhanVien.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvNhanVien.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNhanVien.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhanVien.DoubleBuffered = True
        Me.dgvNhanVien.EnableHeadersVisualStyles = False
        Me.dgvNhanVien.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvNhanVien.HeaderForeColor = System.Drawing.Color.Silver
        Me.dgvNhanVien.Location = New System.Drawing.Point(485, 82)
        Me.dgvNhanVien.Name = "dgvNhanVien"
        Me.dgvNhanVien.ReadOnly = True
        Me.dgvNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNhanVien.Size = New System.Drawing.Size(560, 250)
        Me.dgvNhanVien.TabIndex = 39
        '
        'txtNamSinh
        '
        Me.txtNamSinh.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamSinh.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNamSinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNamSinh.HintForeColor = System.Drawing.Color.Empty
        Me.txtNamSinh.HintText = ""
        Me.txtNamSinh.isPassword = False
        Me.txtNamSinh.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNamSinh.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNamSinh.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNamSinh.LineThickness = 3
        Me.txtNamSinh.Location = New System.Drawing.Point(77, 366)
        Me.txtNamSinh.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNamSinh.Name = "txtNamSinh"
        Me.txtNamSinh.Size = New System.Drawing.Size(370, 32)
        Me.txtNamSinh.TabIndex = 9
        Me.txtNamSinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btndelsearch
        '
        Me.btndelsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndelsearch.Image = CType(resources.GetObject("btndelsearch.Image"), System.Drawing.Image)
        Me.btndelsearch.ImageActive = Nothing
        Me.btndelsearch.Location = New System.Drawing.Point(423, 56)
        Me.btndelsearch.Name = "btndelsearch"
        Me.btndelsearch.Size = New System.Drawing.Size(24, 24)
        Me.btndelsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btndelsearch.TabIndex = 68
        Me.btndelsearch.TabStop = False
        Me.btndelsearch.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(74, 40)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(103, 13)
        Me.BunifuCustomLabel1.TabIndex = 72
        Me.BunifuCustomLabel1.Text = "Tìm Kiếm Nhân Viên"
        '
        'txtTimKiemNV
        '
        Me.txtTimKiemNV.Location = New System.Drawing.Point(77, 56)
        Me.txtTimKiemNV.Multiline = True
        Me.txtTimKiemNV.Name = "txtTimKiemNV"
        Me.txtTimKiemNV.Size = New System.Drawing.Size(340, 24)
        Me.txtTimKiemNV.TabIndex = 71
        '
        'btnXuatExcel
        '
        Me.btnXuatExcel.Activecolor = System.Drawing.Color.Gray
        Me.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnXuatExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnXuatExcel.BorderRadius = 3
        Me.btnXuatExcel.ButtonText = "Excel"
        Me.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXuatExcel.DisabledColor = System.Drawing.Color.Gray
        Me.btnXuatExcel.Iconcolor = System.Drawing.Color.Transparent
        Me.btnXuatExcel.Iconimage = CType(resources.GetObject("btnXuatExcel.Iconimage"), System.Drawing.Image)
        Me.btnXuatExcel.Iconimage_right = Nothing
        Me.btnXuatExcel.Iconimage_right_Selected = Nothing
        Me.btnXuatExcel.Iconimage_Selected = Nothing
        Me.btnXuatExcel.IconMarginLeft = 0
        Me.btnXuatExcel.IconMarginRight = 0
        Me.btnXuatExcel.IconRightVisible = True
        Me.btnXuatExcel.IconRightZoom = 0R
        Me.btnXuatExcel.IconVisible = True
        Me.btnXuatExcel.IconZoom = 90.0R
        Me.btnXuatExcel.IsTab = False
        Me.btnXuatExcel.Location = New System.Drawing.Point(931, 400)
        Me.btnXuatExcel.Name = "btnXuatExcel"
        Me.btnXuatExcel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnXuatExcel.OnHovercolor = System.Drawing.Color.Silver
        Me.btnXuatExcel.OnHoverTextColor = System.Drawing.Color.WhiteSmoke
        Me.btnXuatExcel.selected = False
        Me.btnXuatExcel.Size = New System.Drawing.Size(104, 62)
        Me.btnXuatExcel.TabIndex = 73
        Me.btnXuatExcel.Text = "Excel"
        Me.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnXuatExcel.Textcolor = System.Drawing.Color.Black
        Me.btnXuatExcel.TextFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FormNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.btnXuatExcel)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtTimKiemNV)
        Me.Controls.Add(Me.btndelsearch)
        Me.Controls.Add(Me.dgvNhanVien)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.lbMatKhau)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lbTaiKhoan)
        Me.Controls.Add(Me.txttaiKhoan)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lbPhanQuyen)
        Me.Controls.Add(Me.txtPhanQuyen)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbCMND)
        Me.Controls.Add(Me.txtCMND)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.lbNamSinh)
        Me.Controls.Add(Me.lbGioiTinh)
        Me.Controls.Add(Me.lbChucVu)
        Me.Controls.Add(Me.lbTenNhanVien)
        Me.Controls.Add(Me.lbMaNhanVien)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNamSinh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtGioiTinh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtChucVu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTenNhanVien)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMaNhanVien)
        Me.Name = "FormNhanVien"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndelsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaNhanVien As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTenNhanVien As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChucVu As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGioiTinh As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbMaNhanVien As System.Windows.Forms.Label
    Friend WithEvents lbTenNhanVien As System.Windows.Forms.Label
    Friend WithEvents lbChucVu As System.Windows.Forms.Label
    Friend WithEvents lbGioiTinh As System.Windows.Forms.Label
    Friend WithEvents lbNamSinh As System.Windows.Forms.Label
    Friend WithEvents lbDiaChi As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCMND As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbCMND As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPhanQuyen As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbPhanQuyen As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txttaiKhoan As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbTaiKhoan As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtMatKhau As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbMatKhau As System.Windows.Forms.Label
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCapNhat As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents dgvNhanVien As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtNamSinh As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btndelsearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTimKiemNV As TextBox
    Friend WithEvents btnXuatExcel As Bunifu.Framework.UI.BunifuFlatButton
End Class
