Public Class FormNhanVien
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDnhanvien"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function

    Public Function Add(ByVal ssql As String, ByVal NhanVien As ClassNhanVien) As Integer
        _soLuong = 10

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma_nv"
        Value(0) = NhanVien.Manv


        Name(1) = "@ten_nv"
        Value(1) = NhanVien.Tennv

        Name(2) = "@chuc_vu"
        Value(2) = NhanVien.Chucvu

        Name(3) = "@gioi_tinh"
        Value(3) = NhanVien.Gioitinh


        Name(4) = "@nam_sinh"
        Value(4) = NhanVien.Namsinh


        Name(5) = "@dia_chi"
        Value(5) = NhanVien.Diachi


        Name(6) = "@cmnd "
        Value(6) = NhanVien.Cmnd

        Name(4) = "@phan_quyen"
        Value(4) = NhanVien.Phanquyen


        Name(5) = "@ten_dn"
        Value(5) = NhanVien.Tendn


        Name(6) = "@mk "
        Value(6) = NhanVien.Mk

        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function
    Private Sub NameHeaderDgv()
        dgvNhanVien.Columns("ma_nv").HeaderText = "Mã Nhân Viên"
        dgvNhanVien.Columns("ten_nv").HeaderText = "Tên Nhân Viên"
        dgvNhanVien.Columns("chuc_vu").HeaderText = "Chức Vụ"
        dgvNhanVien.Columns("gioi_tinh").HeaderText = "Giới Tính"
        dgvNhanVien.Columns("nam_sinh").HeaderText = "Năm Sinh"
        dgvNhanVien.Columns("dia_chi").HeaderText = "Địa Chỉ"
        dgvNhanVien.Columns("cmnd").HeaderText = "Chứng Minh Nhân Dân"
        dgvNhanVien.Columns("phan_quyen").HeaderText = "Phân Quyền"
        dgvNhanVien.Columns("ten_dn").HeaderText = "Tên Đăng Nhập"
        dgvNhanVien.Columns("mk").HeaderText = "Mật Khẩu"
    End Sub
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMaNhanVien.Text) Then
            lbMaNhanVien.Visible = True
            lbMaNhanVien.Text = "Mã Nhân Viên không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTenNhanVien.Text) Then
            lbTenNhanVien.Visible = True
            lbTenNhanVien.Text = "Tên Nhân Viên không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtChucVu.Text) Then
            lbChucVu.Visible = True
            lbChucVu.Text = "Chức Vụ không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtGioiTinh.Text) Then
            lbGioiTinh.Visible = True
            lbGioiTinh.Text = "Giới tính không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtNamSinh.Text) Then
            lbNamSinh.Visible = True
            lbNamSinh.Text = "Năm Sinh không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtDiaChi.Text) Then
            lbDiaChi.Visible = True
            lbDiaChi.Text = "Địa Chỉ không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtCMND.Text) Then
            lbCMND.Visible = True
            lbCMND.Text = "Chứng Minh Nhân Dân không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtPhanQuyen.Text) Then
            lbPhanQuyen.Visible = True
            lbPhanQuyen.Text = "Phân Quyền không được rỗng!"
        End If
        If String.IsNullOrEmpty(txttaiKhoan.Text) Then
            lbTaiKhoan.Visible = True
            lbTaiKhoan.Text = "Tài Khoản không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtMatKhau.Text) Then
            lbMatKhau.Visible = True
            lbMatKhau.Text = "Mật Khẩu không được rỗng!"
        End If
    End Sub
    Private Sub ClearText()
        txtChucVu.Text = ""
        txtCMND.Text = ""
        txtDiaChi.Text = ""
        txtGioiTinh.Text = ""
        txtMaNhanVien.Text = ""
        txtMatKhau.Text = ""
        txtNamSinh.Text = ""
        txtPhanQuyen.Text = ""
        txttaiKhoan.Text = ""
        txtTenNhanVien.Text = ""
    End Sub
    Private Sub ShowData()
        dgvNhanVien.DataSource = kn.getData("loadNHANVIEN")
    End Sub
   
    Private Sub FormNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbChucVu.Visible = False
        lbCMND.Visible = False
        lbDiaChi.Visible = False
        lbGioiTinh.Visible = False
        lbMaNhanVien.Visible = False
        lbMatKhau.Visible = False
        lbNamSinh.Visible = False
        lbPhanQuyen.Visible = False
        lbTaiKhoan.Visible = False
        lbTenNhanVien.Visible = False
        ShowData()
        NameHeaderDgv()
    End Sub
    Private Sub dgvNhanVien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvNhanVien.Rows(e.RowIndex)
            txtMaNhanVien.Text = row.Cells("ma_nv").Value.ToString
            txtTenNhanVien.Text = row.Cells("ten_nv").Value.ToString
            txtChucVu.Text = row.Cells("chuc_vu").Value.ToString
            txtGioiTinh.Text = row.Cells("gioi_tinh").Value
            txtNamSinh.Text = row.Cells("nam_sinh").Value.ToString
            txtDiaChi.Text = row.Cells("dia_chi").Value.ToString
            txtCMND.Text = row.Cells("cmnd").Value.ToString
            txtPhanQuyen.Text = row.Cells("phan_quyen").Value
            txttaiKhoan.Text = row.Cells("ten_dn").Value.ToString
            txtMatKhau.Text = row.Cells("mk").Value.ToString
            txtMaNhanVien.Enabled = False
        End If
    End Sub
End Class
