<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNhaCC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNhaCC))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMaNhaCC = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenNhaCC = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbTenNhaCC = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbDiaChi = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSDT = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lbSDT = New System.Windows.Forms.Label()
        Me.btnSua = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCapNhat = New Bunifu.Framework.UI.BunifuTileButton()
        Me.txtMaNhaCC = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvNhaCC = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.THUOCDataSet = New THUOC.THUOCDataSet()
        Me.NhaccBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NhaccTableAdapter = New THUOC.THUOCDataSetTableAdapters.nhaccTableAdapter()
        CType(Me.dgvNhaCC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THUOCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NhaccBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(77, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Nhà Cung Cấp"
        '
        'lbMaNhaCC
        '
        Me.lbMaNhaCC.AutoSize = True
        Me.lbMaNhaCC.ForeColor = System.Drawing.Color.Red
        Me.lbMaNhaCC.Location = New System.Drawing.Point(86, 137)
        Me.lbMaNhaCC.Name = "lbMaNhaCC"
        Me.lbMaNhaCC.Size = New System.Drawing.Size(55, 13)
        Me.lbMaNhaCC.TabIndex = 2
        Me.lbMaNhaCC.Text = "thong bao"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(77, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên Nhà Cung Cấp"
        '
        'txtTenNhaCC
        '
        Me.txtTenNhaCC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenNhaCC.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTenNhaCC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTenNhaCC.HintForeColor = System.Drawing.Color.Empty
        Me.txtTenNhaCC.HintText = ""
        Me.txtTenNhaCC.isPassword = False
        Me.txtTenNhaCC.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTenNhaCC.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTenNhaCC.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTenNhaCC.LineThickness = 3
        Me.txtTenNhaCC.Location = New System.Drawing.Point(80, 177)
        Me.txtTenNhaCC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenNhaCC.Name = "txtTenNhaCC"
        Me.txtTenNhaCC.Size = New System.Drawing.Size(370, 34)
        Me.txtTenNhaCC.TabIndex = 4
        Me.txtTenNhaCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbTenNhaCC
        '
        Me.lbTenNhaCC.AutoSize = True
        Me.lbTenNhaCC.ForeColor = System.Drawing.Color.Red
        Me.lbTenNhaCC.Location = New System.Drawing.Point(86, 215)
        Me.lbTenNhaCC.Name = "lbTenNhaCC"
        Me.lbTenNhaCC.Size = New System.Drawing.Size(55, 13)
        Me.lbTenNhaCC.TabIndex = 5
        Me.lbTenNhaCC.Text = "thong bao"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(77, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Địa Chỉ"
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
        Me.txtDiaChi.Location = New System.Drawing.Point(80, 256)
        Me.txtDiaChi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(370, 34)
        Me.txtDiaChi.TabIndex = 7
        Me.txtDiaChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbDiaChi
        '
        Me.lbDiaChi.AutoSize = True
        Me.lbDiaChi.ForeColor = System.Drawing.Color.Red
        Me.lbDiaChi.Location = New System.Drawing.Point(86, 294)
        Me.lbDiaChi.Name = "lbDiaChi"
        Me.lbDiaChi.Size = New System.Drawing.Size(55, 13)
        Me.lbDiaChi.TabIndex = 8
        Me.lbDiaChi.Text = "thong bao"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(77, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Số Điện Thoại"
        '
        'txtSDT
        '
        Me.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSDT.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSDT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSDT.HintForeColor = System.Drawing.Color.Empty
        Me.txtSDT.HintText = ""
        Me.txtSDT.isPassword = False
        Me.txtSDT.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSDT.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSDT.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSDT.LineThickness = 3
        Me.txtSDT.Location = New System.Drawing.Point(80, 335)
        Me.txtSDT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSDT.Name = "txtSDT"
        Me.txtSDT.Size = New System.Drawing.Size(370, 34)
        Me.txtSDT.TabIndex = 10
        Me.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbSDT
        '
        Me.lbSDT.AutoSize = True
        Me.lbSDT.ForeColor = System.Drawing.Color.Red
        Me.lbSDT.Location = New System.Drawing.Point(86, 373)
        Me.lbSDT.Name = "lbSDT"
        Me.lbSDT.Size = New System.Drawing.Size(55, 13)
        Me.lbSDT.TabIndex = 11
        Me.lbSDT.Text = "thong bao"
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
        Me.btnSua.Location = New System.Drawing.Point(513, 412)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(71, 77)
        Me.btnSua.TabIndex = 34
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
        Me.btnXoa.Location = New System.Drawing.Point(622, 412)
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
        Me.btnThem.Location = New System.Drawing.Point(739, 412)
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
        Me.btnNew.Location = New System.Drawing.Point(845, 412)
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
        Me.btnCapNhat.Location = New System.Drawing.Point(953, 412)
        Me.btnCapNhat.Margin = New System.Windows.Forms.Padding(7)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(114, 77)
        Me.btnCapNhat.TabIndex = 38
        '
        'txtMaNhaCC
        '
        Me.txtMaNhaCC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaNhaCC.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMaNhaCC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMaNhaCC.HintForeColor = System.Drawing.Color.Empty
        Me.txtMaNhaCC.HintText = ""
        Me.txtMaNhaCC.isPassword = False
        Me.txtMaNhaCC.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMaNhaCC.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMaNhaCC.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMaNhaCC.LineThickness = 3
        Me.txtMaNhaCC.Location = New System.Drawing.Point(80, 99)
        Me.txtMaNhaCC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaNhaCC.Name = "txtMaNhaCC"
        Me.txtMaNhaCC.Size = New System.Drawing.Size(370, 34)
        Me.txtMaNhaCC.TabIndex = 40
        Me.txtMaNhaCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvNhaCC
        '
        Me.dgvNhaCC.AllowUserToAddRows = False
        Me.dgvNhaCC.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvNhaCC.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNhaCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNhaCC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNhaCC.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNhaCC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNhaCC.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhaCC.DoubleBuffered = True
        Me.dgvNhaCC.EnableHeadersVisualStyles = False
        Me.dgvNhaCC.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvNhaCC.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvNhaCC.Location = New System.Drawing.Point(484, 82)
        Me.dgvNhaCC.Name = "dgvNhaCC"
        Me.dgvNhaCC.ReadOnly = True
        Me.dgvNhaCC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNhaCC.Size = New System.Drawing.Size(595, 249)
        Me.dgvNhaCC.TabIndex = 41
        '
        'THUOCDataSet
        '
        Me.THUOCDataSet.DataSetName = "THUOCDataSet"
        Me.THUOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NhaccBindingSource
        '
        Me.NhaccBindingSource.DataMember = "nhacc"
        Me.NhaccBindingSource.DataSource = Me.THUOCDataSet
        '
        'NhaccTableAdapter
        '
        Me.NhaccTableAdapter.ClearBeforeFill = True
        '
        'FormNhaCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.dgvNhaCC)
        Me.Controls.Add(Me.txtMaNhaCC)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.lbSDT)
        Me.Controls.Add(Me.txtSDT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbDiaChi)
        Me.Controls.Add(Me.txtDiaChi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbTenNhaCC)
        Me.Controls.Add(Me.txtTenNhaCC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbMaNhaCC)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Name = "FormNhaCC"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvNhaCC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THUOCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NhaccBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbMaNhaCC As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTenNhaCC As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbTenNhaCC As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDiaChi As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbDiaChi As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSDT As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lbSDT As System.Windows.Forms.Label
    Friend WithEvents btnSua As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCapNhat As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents txtMaNhaCC As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvNhaCC As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents NhaccBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents THUOCDataSet As THUOC.THUOCDataSet
    Friend WithEvents NhaccTableAdapter As THUOC.THUOCDataSetTableAdapters.nhaccTableAdapter

End Class
