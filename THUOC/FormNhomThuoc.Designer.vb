<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNhomThuoc
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNhomThuoc))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaNhom = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTenNhom = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvNhomThuoc = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.FKthuocnhomthuocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NhomthuocBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.THUOCDataSet = New THUOC.THUOCDataSet()
        Me.NhomthuocTableAdapter = New THUOC.THUOCDataSetTableAdapters.nhomthuocTableAdapter()
        Me.LbMaNhom = New System.Windows.Forms.Label()
        Me.LbTenNhom = New System.Windows.Forms.Label()
        Me.btnNew = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnXoa = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnThem = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ThuocTableAdapter = New THUOC.THUOCDataSetTableAdapters.thuocTableAdapter()
        Me.btndelsearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtTimKiemNhomThuoc = New System.Windows.Forms.TextBox()
        CType(Me.dgvNhomThuoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKthuocnhomthuocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NhomthuocBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.THUOCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btndelsearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Nhóm"
        '
        'txtMaNhom
        '
        Me.txtMaNhom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMaNhom.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMaNhom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMaNhom.HintForeColor = System.Drawing.Color.Empty
        Me.txtMaNhom.HintText = ""
        Me.txtMaNhom.isPassword = False
        Me.txtMaNhom.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtMaNhom.LineIdleColor = System.Drawing.Color.Gray
        Me.txtMaNhom.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtMaNhom.LineThickness = 3
        Me.txtMaNhom.Location = New System.Drawing.Point(85, 99)
        Me.txtMaNhom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaNhom.Name = "txtMaNhom"
        Me.txtMaNhom.Size = New System.Drawing.Size(370, 34)
        Me.txtMaNhom.TabIndex = 1
        Me.txtMaNhom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tên Nhóm"
        '
        'txtTenNhom
        '
        Me.txtTenNhom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTenNhom.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtTenNhom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTenNhom.HintForeColor = System.Drawing.Color.Empty
        Me.txtTenNhom.HintText = ""
        Me.txtTenNhom.isPassword = False
        Me.txtTenNhom.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtTenNhom.LineIdleColor = System.Drawing.Color.Gray
        Me.txtTenNhom.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtTenNhom.LineThickness = 3
        Me.txtTenNhom.Location = New System.Drawing.Point(85, 180)
        Me.txtTenNhom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTenNhom.Name = "txtTenNhom"
        Me.txtTenNhom.Size = New System.Drawing.Size(370, 38)
        Me.txtTenNhom.TabIndex = 3
        Me.txtTenNhom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvNhomThuoc
        '
        Me.dgvNhomThuoc.AllowUserToAddRows = False
        Me.dgvNhomThuoc.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvNhomThuoc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNhomThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNhomThuoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNhomThuoc.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvNhomThuoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNhomThuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNhomThuoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNhomThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNhomThuoc.DoubleBuffered = True
        Me.dgvNhomThuoc.EnableHeadersVisualStyles = False
        Me.dgvNhomThuoc.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvNhomThuoc.HeaderForeColor = System.Drawing.Color.Black
        Me.dgvNhomThuoc.Location = New System.Drawing.Point(510, 82)
        Me.dgvNhomThuoc.Name = "dgvNhomThuoc"
        Me.dgvNhomThuoc.ReadOnly = True
        Me.dgvNhomThuoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNhomThuoc.Size = New System.Drawing.Size(538, 283)
        Me.dgvNhomThuoc.TabIndex = 4
        '
        'FKthuocnhomthuocBindingSource
        '
        Me.FKthuocnhomthuocBindingSource.DataMember = "FK_thuoc_nhomthuoc"
        Me.FKthuocnhomthuocBindingSource.DataSource = Me.NhomthuocBindingSource
        '
        'NhomthuocBindingSource
        '
        Me.NhomthuocBindingSource.DataMember = "nhomthuoc"
        Me.NhomthuocBindingSource.DataSource = Me.THUOCDataSet
        '
        'THUOCDataSet
        '
        Me.THUOCDataSet.DataSetName = "THUOCDataSet"
        Me.THUOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NhomthuocTableAdapter
        '
        Me.NhomthuocTableAdapter.ClearBeforeFill = True
        '
        'LbMaNhom
        '
        Me.LbMaNhom.AutoSize = True
        Me.LbMaNhom.ForeColor = System.Drawing.Color.Red
        Me.LbMaNhom.Location = New System.Drawing.Point(97, 137)
        Me.LbMaNhom.Name = "LbMaNhom"
        Me.LbMaNhom.Size = New System.Drawing.Size(55, 13)
        Me.LbMaNhom.TabIndex = 5
        Me.LbMaNhom.Text = "thong bao"
        '
        'LbTenNhom
        '
        Me.LbTenNhom.AutoSize = True
        Me.LbTenNhom.ForeColor = System.Drawing.Color.Red
        Me.LbTenNhom.Location = New System.Drawing.Point(97, 222)
        Me.LbTenNhom.Name = "LbTenNhom"
        Me.LbTenNhom.Size = New System.Drawing.Size(55, 13)
        Me.LbTenNhom.TabIndex = 6
        Me.LbTenNhom.Text = "thong bao"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.SeaGreen
        Me.btnNew.color = System.Drawing.Color.SeaGreen
        Me.btnNew.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImagePosition = 0
        Me.btnNew.ImageZoom = 50
        Me.btnNew.LabelPosition = 26
        Me.btnNew.LabelText = "New"
        Me.btnNew.Location = New System.Drawing.Point(797, 401)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(71, 77)
        Me.btnNew.TabIndex = 35
        '
        'btnXoa
        '
        Me.btnXoa.BackColor = System.Drawing.Color.SeaGreen
        Me.btnXoa.color = System.Drawing.Color.SeaGreen
        Me.btnXoa.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.ForeColor = System.Drawing.Color.White
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.ImagePosition = 0
        Me.btnXoa.ImageZoom = 50
        Me.btnXoa.LabelPosition = 26
        Me.btnXoa.LabelText = "Xóa"
        Me.btnXoa.Location = New System.Drawing.Point(654, 401)
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
        Me.btnThem.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.ForeColor = System.Drawing.Color.White
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.ImagePosition = 0
        Me.btnThem.ImageZoom = 50
        Me.btnThem.LabelPosition = 26
        Me.btnThem.LabelText = "Thêm"
        Me.btnThem.Location = New System.Drawing.Point(510, 401)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(6)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(71, 77)
        Me.btnThem.TabIndex = 37
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.SeaGreen
        Me.btnUpdate.color = System.Drawing.Color.SeaGreen
        Me.btnUpdate.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImagePosition = 0
        Me.btnUpdate.ImageZoom = 50
        Me.btnUpdate.LabelPosition = 26
        Me.btnUpdate.LabelText = "Cập Nhật"
        Me.btnUpdate.Location = New System.Drawing.Point(935, 401)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(113, 77)
        Me.btnUpdate.TabIndex = 38
        '
        'ThuocTableAdapter
        '
        Me.ThuocTableAdapter.ClearBeforeFill = True
        '
        'btndelsearch
        '
        Me.btndelsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btndelsearch.Image = CType(resources.GetObject("btndelsearch.Image"), System.Drawing.Image)
        Me.btndelsearch.ImageActive = Nothing
        Me.btndelsearch.Location = New System.Drawing.Point(431, 55)
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
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(82, 39)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(115, 13)
        Me.BunifuCustomLabel1.TabIndex = 74
        Me.BunifuCustomLabel1.Text = "Tìm Kiếm Nhóm Thuốc"
        '
        'txtTimKiemNhomThuoc
        '
        Me.txtTimKiemNhomThuoc.Location = New System.Drawing.Point(85, 55)
        Me.txtTimKiemNhomThuoc.Multiline = True
        Me.txtTimKiemNhomThuoc.Name = "txtTimKiemNhomThuoc"
        Me.txtTimKiemNhomThuoc.Size = New System.Drawing.Size(340, 24)
        Me.txtTimKiemNhomThuoc.TabIndex = 73
        '
        'FormNhomThuoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.txtTimKiemNhomThuoc)
        Me.Controls.Add(Me.btndelsearch)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.LbTenNhom)
        Me.Controls.Add(Me.LbMaNhom)
        Me.Controls.Add(Me.dgvNhomThuoc)
        Me.Controls.Add(Me.txtTenNhom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaNhom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormNhomThuoc"
        Me.Size = New System.Drawing.Size(1117, 632)
        CType(Me.dgvNhomThuoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKthuocnhomthuocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NhomthuocBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.THUOCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btndelsearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMaNhom As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTenNhom As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvNhomThuoc As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents NhomthuocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents THUOCDataSet As THUOC.THUOCDataSet
    Friend WithEvents NhomthuocTableAdapter As THUOC.THUOCDataSetTableAdapters.nhomthuocTableAdapter
    Friend WithEvents LbMaNhom As System.Windows.Forms.Label
    Friend WithEvents LbTenNhom As System.Windows.Forms.Label
    Friend WithEvents FKthuocnhomthuocBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnNew As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnXoa As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnThem As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ThuocTableAdapter As THUOC.THUOCDataSetTableAdapters.thuocTableAdapter
    Friend WithEvents btndelsearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtTimKiemNhomThuoc As TextBox
End Class
