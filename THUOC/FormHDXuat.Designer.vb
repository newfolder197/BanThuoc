<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHDXuat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHDXuat))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSoCTXuat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbSoCTXuat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.txtTongTienXuat = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbTongTienXuat = New System.Windows.Forms.Label()
        Me.btnSua = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCapNhat = New Bunifu.Framework.UI.BunifuTileButton()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbMaNhanVien = New System.Windows.Forms.ComboBox()
        Me.btnDetail = New Bunifu.Framework.UI.BunifuTileButton()
        Me.dgvHdXuat = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.dgvHdXuat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số Chứng Từ Xuất"
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
        Me.txtSoCTXuat.Location = New System.Drawing.Point(87, 95)
        Me.txtSoCTXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoCTXuat.Name = "txtSoCTXuat"
        Me.txtSoCTXuat.Size = New System.Drawing.Size(370, 30)
        Me.txtSoCTXuat.TabIndex = 1
        Me.txtSoCTXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbSoCTXuat
        '
        Me.lbSoCTXuat.AutoSize = True
        Me.lbSoCTXuat.ForeColor = System.Drawing.Color.Red
        Me.lbSoCTXuat.Location = New System.Drawing.Point(95, 129)
        Me.lbSoCTXuat.Name = "lbSoCTXuat"
        Me.lbSoCTXuat.Size = New System.Drawing.Size(55, 13)
        Me.lbSoCTXuat.TabIndex = 2
        Me.lbSoCTXuat.Text = "thong bao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mã Nhân Viên"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Ngày Xuất"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(84, 276)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(81, 13)
        Me.label.TabIndex = 12
        Me.label.Text = "Tổng Tiền Xuất"
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
        Me.txtTongTienXuat.Location = New System.Drawing.Point(87, 293)
        Me.txtTongTienXuat.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTongTienXuat.Name = "txtTongTienXuat"
        Me.txtTongTienXuat.Size = New System.Drawing.Size(370, 30)
        Me.txtTongTienXuat.TabIndex = 13
        Me.txtTongTienXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbTongTienXuat
        '
        Me.lbTongTienXuat.AutoSize = True
        Me.lbTongTienXuat.ForeColor = System.Drawing.Color.Red
        Me.lbTongTienXuat.Location = New System.Drawing.Point(95, 327)
        Me.lbTongTienXuat.Name = "lbTongTienXuat"
        Me.lbTongTienXuat.Size = New System.Drawing.Size(55, 13)
        Me.lbTongTienXuat.TabIndex = 14
        Me.lbTongTienXuat.Text = "thong bao"
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
        Me.btnSua.Location = New System.Drawing.Point(526, 404)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(71, 77)
        Me.btnSua.TabIndex = 35
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
        Me.btnXoa.Location = New System.Drawing.Point(627, 404)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(71, 77)
        Me.btnXoa.TabIndex = 36
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
        Me.btnThem.Location = New System.Drawing.Point(727, 404)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(71, 77)
        Me.btnThem.TabIndex = 37
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
        Me.btnNew.Location = New System.Drawing.Point(833, 404)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 77)
        Me.btnNew.TabIndex = 38
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
        Me.btnCapNhat.Location = New System.Drawing.Point(937, 404)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(114, 77)
        Me.btnCapNhat.TabIndex = 39
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(87, 239)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(370, 20)
        Me.DateTimePicker1.TabIndex = 40
        '
        'cbMaNhanVien
        '
        Me.cbMaNhanVien.FormattingEnabled = True
        Me.cbMaNhanVien.Location = New System.Drawing.Point(87, 175)
        Me.cbMaNhanVien.Name = "cbMaNhanVien"
        Me.cbMaNhanVien.Size = New System.Drawing.Size(370, 21)
        Me.cbMaNhanVien.TabIndex = 41
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
        Me.btnDetail.Location = New System.Drawing.Point(232, 404)
        Me.btnDetail.Margin = New System.Windows.Forms.Padding(6)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(83, 77)
        Me.btnDetail.TabIndex = 42
        '
        'dgvHdXuat
        '
        Me.dgvHdXuat.AllowUserToAddRows = False
        Me.dgvHdXuat.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHdXuat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHdXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHdXuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHdXuat.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvHdXuat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHdXuat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHdXuat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHdXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHdXuat.DoubleBuffered = True
        Me.dgvHdXuat.EnableHeadersVisualStyles = False
        Me.dgvHdXuat.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvHdXuat.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvHdXuat.Location = New System.Drawing.Point(526, 78)
        Me.dgvHdXuat.Name = "dgvHdXuat"
        Me.dgvHdXuat.ReadOnly = True
        Me.dgvHdXuat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHdXuat.Size = New System.Drawing.Size(525, 262)
        Me.dgvHdXuat.TabIndex = 43
        '
        'FormHDXuat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.dgvHdXuat)
        Me.Controls.Add(Me.btnDetail)
        Me.Controls.Add(Me.cbMaNhanVien)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.lbTongTienXuat)
        Me.Controls.Add(Me.txtTongTienXuat)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbSoCTXuat)
        Me.Controls.Add(Me.txtSoCTXuat)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHDXuat"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvHdXuat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSoCTXuat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbSoCTXuat As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtTongTienXuat As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbTongTienXuat As System.Windows.Forms.Label
    Friend WithEvents btnSua As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCapNhat As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMaNhanVien As System.Windows.Forms.ComboBox
    Friend WithEvents btnDetail As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents dgvHdXuat As Bunifu.Framework.UI.BunifuCustomDataGrid

End Class
