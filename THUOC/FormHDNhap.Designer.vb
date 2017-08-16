<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHDNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHDNhap))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDetail = New Bunifu.Framework.UI.BunifuTileButton()
        Me.cbMaNhanVien = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnCapNhat = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.lbTongTienNhap = New System.Windows.Forms.Label()
        Me.txtTongTienNhap = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbSoCTNhap = New System.Windows.Forms.Label()
        Me.txtSoCTNhap = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMaNhaCC = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvHDNhap = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btndelsearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTimKiemHDNhap = New System.Windows.Forms.TextBox()
        Me.FormCTHDNhap1 = New THUOC.FormCTHDNhap()
        CType(Me.dgvHDNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndelsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetail
        '
        Me.btnDetail.BackColor = System.Drawing.Color.SeaGreen
        Me.btnDetail.color = System.Drawing.Color.SeaGreen
        Me.btnDetail.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetail.ForeColor = System.Drawing.Color.Silver
        Me.btnDetail.Image = CType(resources.GetObject("btnDetail.Image"), System.Drawing.Image)
        Me.btnDetail.ImagePosition = 0
        Me.btnDetail.ImageZoom = 50
        Me.btnDetail.LabelPosition = 26
        Me.btnDetail.LabelText = "Detail"
        Me.btnDetail.Location = New System.Drawing.Point(219, 477)
        Me.btnDetail.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(83, 77)
        Me.btnDetail.TabIndex = 61
        '
        'cbMaNhanVien
        '
        Me.cbMaNhanVien.FormattingEnabled = True
        Me.cbMaNhanVien.Location = New System.Drawing.Point(81, 176)
        Me.cbMaNhanVien.Name = "cbMaNhanVien"
        Me.cbMaNhanVien.Size = New System.Drawing.Size(370, 21)
        Me.cbMaNhanVien.TabIndex = 60
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 240)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(370, 20)
        Me.DateTimePicker1.TabIndex = 59
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
        Me.btnCapNhat.Location = New System.Drawing.Point(924, 477)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(114, 77)
        Me.btnCapNhat.TabIndex = 58
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
        Me.btnNew.Location = New System.Drawing.Point(781, 477)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 77)
        Me.btnNew.TabIndex = 57
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
        Me.btnThem.Location = New System.Drawing.Point(649, 477)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(71, 77)
        Me.btnThem.TabIndex = 56
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
        Me.btnXoa.Location = New System.Drawing.Point(513, 477)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(71, 77)
        Me.btnXoa.TabIndex = 55
        '
        'lbTongTienNhap
        '
        Me.lbTongTienNhap.AutoSize = True
        Me.lbTongTienNhap.ForeColor = System.Drawing.Color.Red
        Me.lbTongTienNhap.Location = New System.Drawing.Point(89, 377)
        Me.lbTongTienNhap.Name = "lbTongTienNhap"
        Me.lbTongTienNhap.Size = New System.Drawing.Size(55, 13)
        Me.lbTongTienNhap.TabIndex = 51
        Me.lbTongTienNhap.Text = "thong bao"
        '
        'txtTongTienNhap
        '
        Me.txtTongTienNhap.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTongTienNhap.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTongTienNhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTongTienNhap.HintForeColor = System.Drawing.Color.Empty
        Me.txtTongTienNhap.HintText = ""
        Me.txtTongTienNhap.isPassword = False
        Me.txtTongTienNhap.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTongTienNhap.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTongTienNhap.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTongTienNhap.LineThickness = 3
        Me.txtTongTienNhap.Location = New System.Drawing.Point(81, 343)
        Me.txtTongTienNhap.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTongTienNhap.Name = "txtTongTienNhap"
        Me.txtTongTienNhap.Size = New System.Drawing.Size(370, 30)
        Me.txtTongTienNhap.TabIndex = 50
        Me.txtTongTienNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(78, 326)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Tổng Tiền Nhập"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Ngày Nhập"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Mã Nhân Viên"
        '
        'lbSoCTNhap
        '
        Me.lbSoCTNhap.AutoSize = True
        Me.lbSoCTNhap.ForeColor = System.Drawing.Color.Red
        Me.lbSoCTNhap.Location = New System.Drawing.Point(89, 130)
        Me.lbSoCTNhap.Name = "lbSoCTNhap"
        Me.lbSoCTNhap.Size = New System.Drawing.Size(55, 13)
        Me.lbSoCTNhap.TabIndex = 45
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
        Me.txtSoCTNhap.TabIndex = 44
        Me.txtSoCTNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Số Chứng Từ Nhập"
        '
        'cbMaNhaCC
        '
        Me.cbMaNhaCC.FormattingEnabled = True
        Me.cbMaNhaCC.Location = New System.Drawing.Point(81, 288)
        Me.cbMaNhaCC.Name = "cbMaNhaCC"
        Me.cbMaNhaCC.Size = New System.Drawing.Size(370, 21)
        Me.cbMaNhaCC.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(78, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Mã Nhà Cung Cấp"
        '
        'dgvHDNhap
        '
        Me.dgvHDNhap.AllowUserToAddRows = False
        Me.dgvHDNhap.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHDNhap.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHDNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHDNhap.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHDNhap.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHDNhap.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHDNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHDNhap.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHDNhap.DoubleBuffered = True
        Me.dgvHDNhap.EnableHeadersVisualStyles = False
        Me.dgvHDNhap.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvHDNhap.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvHDNhap.Location = New System.Drawing.Point(513, 79)
        Me.dgvHDNhap.Name = "dgvHDNhap"
        Me.dgvHDNhap.ReadOnly = True
        Me.dgvHDNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHDNhap.Size = New System.Drawing.Size(525, 311)
        Me.dgvHDNhap.TabIndex = 64
        '
        'btndelsearch
        '
        Me.btndelsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndelsearch.Image = CType(resources.GetObject("btndelsearch.Image"), System.Drawing.Image)
        Me.btndelsearch.ImageActive = Nothing
        Me.btndelsearch.Location = New System.Drawing.Point(427, 52)
        Me.btndelsearch.Name = "btndelsearch"
        Me.btndelsearch.Size = New System.Drawing.Size(24, 24)
        Me.btndelsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btndelsearch.TabIndex = 66
        Me.btndelsearch.TabStop = False
        Me.btndelsearch.Zoom = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(78, 36)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(125, 13)
        Me.BunifuCustomLabel1.TabIndex = 74
        Me.BunifuCustomLabel1.Text = "Tìm Kiếm Hóa Đơn Nhập"
        '
        'txtTimKiemHDNhap
        '
        Me.txtTimKiemHDNhap.Location = New System.Drawing.Point(81, 52)
        Me.txtTimKiemHDNhap.Multiline = True
        Me.txtTimKiemHDNhap.Name = "txtTimKiemHDNhap"
        Me.txtTimKiemHDNhap.Size = New System.Drawing.Size(340, 24)
        Me.txtTimKiemHDNhap.TabIndex = 73
        '
        'FormCTHDNhap1
        '
        Me.FormCTHDNhap1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormCTHDNhap1.Location = New System.Drawing.Point(0, 0)
        Me.FormCTHDNhap1.Name = "FormCTHDNhap1"
        Me.FormCTHDNhap1.Size = New System.Drawing.Size(1117, 632)
        Me.FormCTHDNhap1.TabIndex = 75
        '
        'FormHDNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.FormCTHDNhap1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtTimKiemHDNhap)
        Me.Controls.Add(Me.btndelsearch)
        Me.Controls.Add(Me.dgvHDNhap)
        Me.Controls.Add(Me.cbMaNhaCC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.cbMaNhanVien)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.lbTongTienNhap)
        Me.Controls.Add(Me.txtTongTienNhap)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSoCTNhap)
        Me.Controls.Add(Me.txtSoCTNhap)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHDNhap"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvHDNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndelsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetail As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents cbMaNhanVien As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCapNhat As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents lbTongTienNhap As System.Windows.Forms.Label
    Friend WithEvents txtTongTienNhap As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbSoCTNhap As System.Windows.Forms.Label
    Friend WithEvents txtSoCTNhap As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbMaNhaCC As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dgvHDNhap As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btndelsearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTimKiemHDNhap As TextBox
    Friend WithEvents FormCTHDNhap1 As FormCTHDNhap
End Class
