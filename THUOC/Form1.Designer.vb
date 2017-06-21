<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnCTHDXuat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCTHDNhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHoaDonXuat = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnHoaDonNhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhaCungCap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhanVien = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnNhomThuoc = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnThuoc = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnminus = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FormThuoc1 = New THUOC.FormThuoc()
        Me.FormNhomThuoc1 = New THUOC.FormNhomThuoc()
        Me.FormNhanVien1 = New THUOC.FormNhanVien()
        Me.FormNhaCC1 = New THUOC.FormNhaCC()
        Me.FormHDXuat1 = New THUOC.FormHDXuat()
        Me.FormHDNhap1 = New THUOC.FormHDNhap()
        Me.FormCTHDNhap1 = New THUOC.FormCTHDNhap()
        Me.FormCTHDXuat1 = New THUOC.FormCTHDXuat()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.btnminus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(200, 198)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.btnCTHDXuat)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnCTHDNhap)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnHoaDonXuat)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnHoaDonNhap)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnNhaCungCap)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnNhanVien)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnNhomThuoc)
        Me.BunifuGradientPanel2.Controls.Add(Me.btnThuoc)
        Me.BunifuGradientPanel2.Controls.Add(Me.PictureBox4)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(200, 680)
        Me.BunifuGradientPanel2.TabIndex = 4
        '
        'btnCTHDXuat
        '
        Me.btnCTHDXuat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCTHDXuat.BackColor = System.Drawing.Color.Transparent
        Me.btnCTHDXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCTHDXuat.BorderRadius = 0
        Me.btnCTHDXuat.ButtonText = "CT Hóa Đơn Xuất"
        Me.btnCTHDXuat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCTHDXuat.DisabledColor = System.Drawing.Color.Gray
        Me.btnCTHDXuat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCTHDXuat.Iconimage = CType(resources.GetObject("btnCTHDXuat.Iconimage"), System.Drawing.Image)
        Me.btnCTHDXuat.Iconimage_right = Nothing
        Me.btnCTHDXuat.Iconimage_right_Selected = Nothing
        Me.btnCTHDXuat.Iconimage_Selected = Nothing
        Me.btnCTHDXuat.IconMarginLeft = 0
        Me.btnCTHDXuat.IconMarginRight = 0
        Me.btnCTHDXuat.IconRightVisible = True
        Me.btnCTHDXuat.IconRightZoom = 0.0R
        Me.btnCTHDXuat.IconVisible = True
        Me.btnCTHDXuat.IconZoom = 90.0R
        Me.btnCTHDXuat.IsTab = False
        Me.btnCTHDXuat.Location = New System.Drawing.Point(0, 530)
        Me.btnCTHDXuat.Name = "btnCTHDXuat"
        Me.btnCTHDXuat.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCTHDXuat.OnHovercolor = System.Drawing.Color.Silver
        Me.btnCTHDXuat.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnCTHDXuat.selected = False
        Me.btnCTHDXuat.Size = New System.Drawing.Size(200, 48)
        Me.btnCTHDXuat.TabIndex = 9
        Me.btnCTHDXuat.Text = "CT Hóa Đơn Xuất"
        Me.btnCTHDXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCTHDXuat.Textcolor = System.Drawing.Color.DarkGray
        Me.btnCTHDXuat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'btnCTHDNhap
        '
        Me.btnCTHDNhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCTHDNhap.BackColor = System.Drawing.Color.Transparent
        Me.btnCTHDNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCTHDNhap.BorderRadius = 0
        Me.btnCTHDNhap.ButtonText = "CT Hóa Đơn Nhập"
        Me.btnCTHDNhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCTHDNhap.DisabledColor = System.Drawing.Color.Gray
        Me.btnCTHDNhap.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCTHDNhap.Iconimage = CType(resources.GetObject("btnCTHDNhap.Iconimage"), System.Drawing.Image)
        Me.btnCTHDNhap.Iconimage_right = Nothing
        Me.btnCTHDNhap.Iconimage_right_Selected = Nothing
        Me.btnCTHDNhap.Iconimage_Selected = Nothing
        Me.btnCTHDNhap.IconMarginLeft = 0
        Me.btnCTHDNhap.IconMarginRight = 0
        Me.btnCTHDNhap.IconRightVisible = True
        Me.btnCTHDNhap.IconRightZoom = 0.0R
        Me.btnCTHDNhap.IconVisible = True
        Me.btnCTHDNhap.IconZoom = 90.0R
        Me.btnCTHDNhap.IsTab = False
        Me.btnCTHDNhap.Location = New System.Drawing.Point(0, 482)
        Me.btnCTHDNhap.Name = "btnCTHDNhap"
        Me.btnCTHDNhap.Normalcolor = System.Drawing.Color.Transparent
        Me.btnCTHDNhap.OnHovercolor = System.Drawing.Color.Silver
        Me.btnCTHDNhap.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnCTHDNhap.selected = False
        Me.btnCTHDNhap.Size = New System.Drawing.Size(200, 48)
        Me.btnCTHDNhap.TabIndex = 8
        Me.btnCTHDNhap.Text = "CT Hóa Đơn Nhập"
        Me.btnCTHDNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCTHDNhap.Textcolor = System.Drawing.Color.DarkGray
        Me.btnCTHDNhap.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'btnHoaDonXuat
        '
        Me.btnHoaDonXuat.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnHoaDonXuat.BackColor = System.Drawing.Color.Transparent
        Me.btnHoaDonXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHoaDonXuat.BorderRadius = 0
        Me.btnHoaDonXuat.ButtonText = "Hóa Đơn Xuất"
        Me.btnHoaDonXuat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHoaDonXuat.DisabledColor = System.Drawing.Color.Gray
        Me.btnHoaDonXuat.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHoaDonXuat.Iconimage = CType(resources.GetObject("btnHoaDonXuat.Iconimage"), System.Drawing.Image)
        Me.btnHoaDonXuat.Iconimage_right = Nothing
        Me.btnHoaDonXuat.Iconimage_right_Selected = Nothing
        Me.btnHoaDonXuat.Iconimage_Selected = Nothing
        Me.btnHoaDonXuat.IconMarginLeft = 0
        Me.btnHoaDonXuat.IconMarginRight = 0
        Me.btnHoaDonXuat.IconRightVisible = True
        Me.btnHoaDonXuat.IconRightZoom = 0.0R
        Me.btnHoaDonXuat.IconVisible = True
        Me.btnHoaDonXuat.IconZoom = 90.0R
        Me.btnHoaDonXuat.IsTab = False
        Me.btnHoaDonXuat.Location = New System.Drawing.Point(0, 434)
        Me.btnHoaDonXuat.Name = "btnHoaDonXuat"
        Me.btnHoaDonXuat.Normalcolor = System.Drawing.Color.Transparent
        Me.btnHoaDonXuat.OnHovercolor = System.Drawing.Color.Silver
        Me.btnHoaDonXuat.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnHoaDonXuat.selected = False
        Me.btnHoaDonXuat.Size = New System.Drawing.Size(200, 48)
        Me.btnHoaDonXuat.TabIndex = 7
        Me.btnHoaDonXuat.Text = "Hóa Đơn Xuất"
        Me.btnHoaDonXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHoaDonXuat.Textcolor = System.Drawing.Color.DarkGray
        Me.btnHoaDonXuat.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'btnHoaDonNhap
        '
        Me.btnHoaDonNhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnHoaDonNhap.BackColor = System.Drawing.Color.Transparent
        Me.btnHoaDonNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHoaDonNhap.BorderRadius = 0
        Me.btnHoaDonNhap.ButtonText = "Hóa Đơn Nhập"
        Me.btnHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHoaDonNhap.DisabledColor = System.Drawing.Color.Gray
        Me.btnHoaDonNhap.Iconcolor = System.Drawing.Color.Transparent
        Me.btnHoaDonNhap.Iconimage = CType(resources.GetObject("btnHoaDonNhap.Iconimage"), System.Drawing.Image)
        Me.btnHoaDonNhap.Iconimage_right = Nothing
        Me.btnHoaDonNhap.Iconimage_right_Selected = Nothing
        Me.btnHoaDonNhap.Iconimage_Selected = Nothing
        Me.btnHoaDonNhap.IconMarginLeft = 0
        Me.btnHoaDonNhap.IconMarginRight = 0
        Me.btnHoaDonNhap.IconRightVisible = True
        Me.btnHoaDonNhap.IconRightZoom = 0.0R
        Me.btnHoaDonNhap.IconVisible = True
        Me.btnHoaDonNhap.IconZoom = 90.0R
        Me.btnHoaDonNhap.IsTab = False
        Me.btnHoaDonNhap.Location = New System.Drawing.Point(0, 386)
        Me.btnHoaDonNhap.Name = "btnHoaDonNhap"
        Me.btnHoaDonNhap.Normalcolor = System.Drawing.Color.Transparent
        Me.btnHoaDonNhap.OnHovercolor = System.Drawing.Color.Silver
        Me.btnHoaDonNhap.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnHoaDonNhap.selected = False
        Me.btnHoaDonNhap.Size = New System.Drawing.Size(200, 48)
        Me.btnHoaDonNhap.TabIndex = 6
        Me.btnHoaDonNhap.Text = "Hóa Đơn Nhập"
        Me.btnHoaDonNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHoaDonNhap.Textcolor = System.Drawing.Color.DarkGray
        Me.btnHoaDonNhap.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'btnNhaCungCap
        '
        Me.btnNhaCungCap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNhaCungCap.BackColor = System.Drawing.Color.Transparent
        Me.btnNhaCungCap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhaCungCap.BorderRadius = 0
        Me.btnNhaCungCap.ButtonText = " Nhà Cung Cấp"
        Me.btnNhaCungCap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNhaCungCap.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhaCungCap.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhaCungCap.Iconimage = CType(resources.GetObject("btnNhaCungCap.Iconimage"), System.Drawing.Image)
        Me.btnNhaCungCap.Iconimage_right = Nothing
        Me.btnNhaCungCap.Iconimage_right_Selected = Nothing
        Me.btnNhaCungCap.Iconimage_Selected = Nothing
        Me.btnNhaCungCap.IconMarginLeft = 0
        Me.btnNhaCungCap.IconMarginRight = 0
        Me.btnNhaCungCap.IconRightVisible = True
        Me.btnNhaCungCap.IconRightZoom = 0.0R
        Me.btnNhaCungCap.IconVisible = True
        Me.btnNhaCungCap.IconZoom = 90.0R
        Me.btnNhaCungCap.IsTab = False
        Me.btnNhaCungCap.Location = New System.Drawing.Point(0, 338)
        Me.btnNhaCungCap.Name = "btnNhaCungCap"
        Me.btnNhaCungCap.Normalcolor = System.Drawing.Color.Transparent
        Me.btnNhaCungCap.OnHovercolor = System.Drawing.Color.Silver
        Me.btnNhaCungCap.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnNhaCungCap.selected = False
        Me.btnNhaCungCap.Size = New System.Drawing.Size(200, 48)
        Me.btnNhaCungCap.TabIndex = 5
        Me.btnNhaCungCap.Text = " Nhà Cung Cấp"
        Me.btnNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhaCungCap.Textcolor = System.Drawing.Color.DarkGray
        Me.btnNhaCungCap.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'btnNhanVien
        '
        Me.btnNhanVien.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNhanVien.BackColor = System.Drawing.Color.Transparent
        Me.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhanVien.BorderRadius = 0
        Me.btnNhanVien.ButtonText = " Nhân Viên"
        Me.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNhanVien.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhanVien.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhanVien.Iconimage = CType(resources.GetObject("btnNhanVien.Iconimage"), System.Drawing.Image)
        Me.btnNhanVien.Iconimage_right = Nothing
        Me.btnNhanVien.Iconimage_right_Selected = Nothing
        Me.btnNhanVien.Iconimage_Selected = Nothing
        Me.btnNhanVien.IconMarginLeft = 0
        Me.btnNhanVien.IconMarginRight = 0
        Me.btnNhanVien.IconRightVisible = True
        Me.btnNhanVien.IconRightZoom = 0.0R
        Me.btnNhanVien.IconVisible = True
        Me.btnNhanVien.IconZoom = 90.0R
        Me.btnNhanVien.IsTab = False
        Me.btnNhanVien.Location = New System.Drawing.Point(0, 290)
        Me.btnNhanVien.Name = "btnNhanVien"
        Me.btnNhanVien.Normalcolor = System.Drawing.Color.Transparent
        Me.btnNhanVien.OnHovercolor = System.Drawing.Color.Silver
        Me.btnNhanVien.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnNhanVien.selected = False
        Me.btnNhanVien.Size = New System.Drawing.Size(200, 48)
        Me.btnNhanVien.TabIndex = 4
        Me.btnNhanVien.Text = " Nhân Viên"
        Me.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhanVien.Textcolor = System.Drawing.Color.DarkGray
        Me.btnNhanVien.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'btnNhomThuoc
        '
        Me.btnNhomThuoc.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnNhomThuoc.BackColor = System.Drawing.Color.Transparent
        Me.btnNhomThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhomThuoc.BorderRadius = 0
        Me.btnNhomThuoc.ButtonText = " Nhóm Thuốc"
        Me.btnNhomThuoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNhomThuoc.DisabledColor = System.Drawing.Color.Gray
        Me.btnNhomThuoc.Iconcolor = System.Drawing.Color.Transparent
        Me.btnNhomThuoc.Iconimage = CType(resources.GetObject("btnNhomThuoc.Iconimage"), System.Drawing.Image)
        Me.btnNhomThuoc.Iconimage_right = Nothing
        Me.btnNhomThuoc.Iconimage_right_Selected = Nothing
        Me.btnNhomThuoc.Iconimage_Selected = Nothing
        Me.btnNhomThuoc.IconMarginLeft = 0
        Me.btnNhomThuoc.IconMarginRight = 0
        Me.btnNhomThuoc.IconRightVisible = True
        Me.btnNhomThuoc.IconRightZoom = 0.0R
        Me.btnNhomThuoc.IconVisible = True
        Me.btnNhomThuoc.IconZoom = 90.0R
        Me.btnNhomThuoc.IsTab = False
        Me.btnNhomThuoc.Location = New System.Drawing.Point(0, 242)
        Me.btnNhomThuoc.Name = "btnNhomThuoc"
        Me.btnNhomThuoc.Normalcolor = System.Drawing.Color.Transparent
        Me.btnNhomThuoc.OnHovercolor = System.Drawing.Color.Silver
        Me.btnNhomThuoc.OnHoverTextColor = System.Drawing.Color.Transparent
        Me.btnNhomThuoc.selected = False
        Me.btnNhomThuoc.Size = New System.Drawing.Size(200, 48)
        Me.btnNhomThuoc.TabIndex = 2
        Me.btnNhomThuoc.Text = " Nhóm Thuốc"
        Me.btnNhomThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNhomThuoc.Textcolor = System.Drawing.Color.DarkGray
        Me.btnNhomThuoc.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'btnThuoc
        '
        Me.btnThuoc.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnThuoc.BackColor = System.Drawing.Color.Silver
        Me.btnThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThuoc.BorderRadius = 0
        Me.btnThuoc.ButtonText = " Thuốc"
        Me.btnThuoc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnThuoc.DisabledColor = System.Drawing.Color.Gray
        Me.btnThuoc.Iconcolor = System.Drawing.Color.Transparent
        Me.btnThuoc.Iconimage = CType(resources.GetObject("btnThuoc.Iconimage"), System.Drawing.Image)
        Me.btnThuoc.Iconimage_right = Nothing
        Me.btnThuoc.Iconimage_right_Selected = Nothing
        Me.btnThuoc.Iconimage_Selected = Nothing
        Me.btnThuoc.IconMarginLeft = 0
        Me.btnThuoc.IconMarginRight = 0
        Me.btnThuoc.IconRightVisible = True
        Me.btnThuoc.IconRightZoom = 0.0R
        Me.btnThuoc.IconVisible = True
        Me.btnThuoc.IconZoom = 90.0R
        Me.btnThuoc.IsTab = False
        Me.btnThuoc.Location = New System.Drawing.Point(0, 195)
        Me.btnThuoc.Name = "btnThuoc"
        Me.btnThuoc.Normalcolor = System.Drawing.Color.Silver
        Me.btnThuoc.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnThuoc.OnHoverTextColor = System.Drawing.Color.Silver
        Me.btnThuoc.selected = False
        Me.btnThuoc.Size = New System.Drawing.Size(200, 48)
        Me.btnThuoc.TabIndex = 1
        Me.btnThuoc.Text = " Thuốc"
        Me.btnThuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnThuoc.Textcolor = System.Drawing.Color.White
        Me.btnThuoc.TextFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnminus)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(200, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 29)
        Me.Panel1.TabIndex = 5
        '
        'btnminus
        '
        Me.btnminus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnminus.Image = CType(resources.GetObject("btnminus.Image"), System.Drawing.Image)
        Me.btnminus.ImageActive = Nothing
        Me.btnminus.Location = New System.Drawing.Point(1063, 2)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(24, 24)
        Me.btnminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnminus.TabIndex = 8
        Me.btnminus.TabStop = False
        Me.btnminus.Zoom = 10
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnclose.Image = CType(resources.GetObject("btnclose.Image"), System.Drawing.Image)
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(1088, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(24, 24)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnclose.TabIndex = 7
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1115, 19)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(937, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Phần Mềm Quản Lý Thuốc Ver 1.0"
        '
        'FormThuoc1
        '
        Me.FormThuoc1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormThuoc1.Location = New System.Drawing.Point(200, 48)
        Me.FormThuoc1.Name = "FormThuoc1"
        Me.FormThuoc1.Size = New System.Drawing.Size(1117, 632)
        Me.FormThuoc1.TabIndex = 7
        '
        'FormNhomThuoc1
        '
        Me.FormNhomThuoc1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormNhomThuoc1.Location = New System.Drawing.Point(200, 48)
        Me.FormNhomThuoc1.Name = "FormNhomThuoc1"
        Me.FormNhomThuoc1.Size = New System.Drawing.Size(1117, 632)
        Me.FormNhomThuoc1.TabIndex = 8
        '
        'FormNhanVien1
        '
        Me.FormNhanVien1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormNhanVien1.Location = New System.Drawing.Point(200, 48)
        Me.FormNhanVien1.Name = "FormNhanVien1"
        Me.FormNhanVien1.Size = New System.Drawing.Size(1117, 632)
        Me.FormNhanVien1.TabIndex = 9
        '
        'FormNhaCC1
        '
        Me.FormNhaCC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormNhaCC1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormNhaCC1.Location = New System.Drawing.Point(200, 48)
        Me.FormNhaCC1.Name = "FormNhaCC1"
        Me.FormNhaCC1.Size = New System.Drawing.Size(1117, 632)
        Me.FormNhaCC1.TabIndex = 10
        '
        'FormHDXuat1
        '
        Me.FormHDXuat1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormHDXuat1.Location = New System.Drawing.Point(200, 48)
        Me.FormHDXuat1.Name = "FormHDXuat1"
        Me.FormHDXuat1.Size = New System.Drawing.Size(1117, 632)
        Me.FormHDXuat1.TabIndex = 11
        '
        'FormHDNhap1
        '
        Me.FormHDNhap1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormHDNhap1.Location = New System.Drawing.Point(200, 48)
        Me.FormHDNhap1.Name = "FormHDNhap1"
        Me.FormHDNhap1.Size = New System.Drawing.Size(1117, 632)
        Me.FormHDNhap1.TabIndex = 12
        '
        'FormCTHDNhap1
        '
        Me.FormCTHDNhap1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormCTHDNhap1.Location = New System.Drawing.Point(200, 48)
        Me.FormCTHDNhap1.Name = "FormCTHDNhap1"
        Me.FormCTHDNhap1.Size = New System.Drawing.Size(1117, 632)
        Me.FormCTHDNhap1.TabIndex = 13
        '
        'FormCTHDXuat1
        '
        Me.FormCTHDXuat1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormCTHDXuat1.Location = New System.Drawing.Point(200, 48)
        Me.FormCTHDXuat1.Name = "FormCTHDXuat1"
        Me.FormCTHDXuat1.Size = New System.Drawing.Size(1117, 632)
        Me.FormCTHDXuat1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 680)
        Me.Controls.Add(Me.FormCTHDXuat1)
        Me.Controls.Add(Me.FormCTHDNhap1)
        Me.Controls.Add(Me.FormHDNhap1)
        Me.Controls.Add(Me.FormHDXuat1)
        Me.Controls.Add(Me.FormNhaCC1)
        Me.Controls.Add(Me.FormNhanVien1)
        Me.Controls.Add(Me.FormNhomThuoc1)
        Me.Controls.Add(Me.FormThuoc1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnminus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnCTHDXuat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCTHDNhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnHoaDonXuat As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnHoaDonNhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhaCungCap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhanVien As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnNhomThuoc As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnThuoc As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnminus As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FormThuoc1 As THUOC.FormThuoc
    Friend WithEvents FormNhomThuoc1 As THUOC.FormNhomThuoc
    Friend WithEvents FormNhanVien1 As THUOC.FormNhanVien
    Friend WithEvents FormNhaCC1 As THUOC.FormNhaCC
    Friend WithEvents FormHDXuat1 As THUOC.FormHDXuat
    Friend WithEvents FormHDNhap1 As THUOC.FormHDNhap
    Friend WithEvents FormCTHDNhap1 As THUOC.FormCTHDNhap
    Friend WithEvents FormCTHDXuat1 As THUOC.FormCTHDXuat
End Class
