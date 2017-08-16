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
        _soLuong = 9

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

        Name(7) = "@phan_quyen"
        Value(7) = NhanVien.Phanquyen


        Name(8) = "@ten_dn"
        Value(8) = NhanVien.Tendn


        Name(9) = "@mk "
        Value(9) = NhanVien.Mk

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
    Public Function Remove(ByVal ssql As String, ByVal Nhanvien As ClassNhanVien) As Integer
        _soLuong = 0
        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma"
        Value(0) = Nhanvien.Manv
        Return kn.Add(ssql, Name, Value, _soLuong)

    End Function
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim Nhanvien As New ClassNhanVien
            Nhanvien.Manv = txtMaNhanVien.Text
            sql = "removeNHANVIEN"
            Remove(sql, Nhanvien)
            ShowData()
            ClearText()
            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _manv As String
            _manv = txtMaNhanVien.Text

            If ktrID(_manv).Rows.Count > 0 Then
                lbMaNhanVien.Text = "Trùng mã nhân viên!"
                lbMaNhanVien.Visible = True
                txtMaNhanVien.Text = ""
                txtMaNhanVien.Focus()
            Else
                lbMaNhanVien.Visible = False
                If (String.IsNullOrEmpty(txtChucVu.Text)) OrElse (String.IsNullOrEmpty(txtCMND.Text)) OrElse (String.IsNullOrEmpty(txtDiaChi.Text)) OrElse (String.IsNullOrEmpty(txtGioiTinh.Text)) OrElse (String.IsNullOrEmpty(txtMaNhanVien.Text)) OrElse (String.IsNullOrEmpty(txtMatKhau.Text)) OrElse (String.IsNullOrEmpty(txtNamSinh.Text)) OrElse (String.IsNullOrEmpty(txtPhanQuyen.Text)) OrElse (String.IsNullOrEmpty(txttaiKhoan.Text)) OrElse (String.IsNullOrEmpty(txtTenNhanVien.Text)) Then
                    KtraNULL()
                Else
                    lbMaNhanVien.Visible = False
                    lbTenNhanVien.Visible = False
                    lbTaiKhoan.Visible = False
                    lbPhanQuyen.Visible = False
                    lbNamSinh.Visible = False
                    lbMatKhau.Visible = False
                    lbGioiTinh.Visible = False
                    lbDiaChi.Visible = False
                    lbCMND.Visible = False
                    lbChucVu.Visible = False
                    Dim Nhanvien As New ClassNhanVien
                    Nhanvien.Manv = txtMaNhanVien.Text
                    Nhanvien.Tennv = txtTenNhanVien.Text
                    Nhanvien.Chucvu = txtChucVu.Text
                    Nhanvien.Cmnd = txtCMND.Text
                    Nhanvien.Diachi = txtDiaChi.Text
                    Nhanvien.Gioitinh = txtGioiTinh.Text
                    Nhanvien.Mk = txtMatKhau.Text
                    Nhanvien.Namsinh = txtNamSinh.Text
                    Nhanvien.Phanquyen = txtPhanQuyen.Text
                    Nhanvien.Tendn = txttaiKhoan.Text
                    sql = "insertNHANVIEN"
                    Add(sql, Nhanvien)
                    ShowData()
                    MessageBox.Show("Thêm thành công!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click

        If (String.IsNullOrEmpty(txtChucVu.Text)) OrElse (String.IsNullOrEmpty(txtCMND.Text)) OrElse (String.IsNullOrEmpty(txtDiaChi.Text)) OrElse (String.IsNullOrEmpty(txtGioiTinh.Text)) OrElse (String.IsNullOrEmpty(txtMaNhanVien.Text)) OrElse (String.IsNullOrEmpty(txtMatKhau.Text)) OrElse (String.IsNullOrEmpty(txtNamSinh.Text)) OrElse (String.IsNullOrEmpty(txtPhanQuyen.Text)) OrElse (String.IsNullOrEmpty(txttaiKhoan.Text)) OrElse (String.IsNullOrEmpty(txtTenNhanVien.Text)) Then
            KtraNULL()
        Else
            lbMaNhanVien.Visible = False
            lbTenNhanVien.Visible = False
            lbTaiKhoan.Visible = False
            lbPhanQuyen.Visible = False
            lbNamSinh.Visible = False
            lbMatKhau.Visible = False
            lbGioiTinh.Visible = False
            lbDiaChi.Visible = False
            lbCMND.Visible = False
            lbChucVu.Visible = False
            Dim Nhanvien As New ClassNhanVien
            Nhanvien.Manv = txtMaNhanVien.Text
            Nhanvien.Tennv = txtTenNhanVien.Text
            Nhanvien.Chucvu = txtChucVu.Text
            Nhanvien.Cmnd = txtCMND.Text
            Nhanvien.Diachi = txtDiaChi.Text
            Nhanvien.Gioitinh = txtGioiTinh.Text
            Nhanvien.Mk = txtMatKhau.Text
            Nhanvien.Namsinh = txtNamSinh.Text
            Nhanvien.Phanquyen = txtPhanQuyen.Text
            Nhanvien.Tendn = txttaiKhoan.Text
            sql = "updateNHANVIEN"
            Add(sql, Nhanvien)
            ShowData()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaNhanVien.Focus()
    End Sub

    Private Sub txtTimKiemNV_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemNV.TextChanged
        Dim _soluong As Integer
        Dim sql As String
        _soluong = 0
        Dim Value(_soluong) As String
        Dim Name(_soluong) As String
        If txtTimKiemNV.Text.Length > 0 Then

            sql = "searchIDNHANVIEN"
            Name(0) = "@ma"
            Value(0) = txtTimKiemNV.Text
            dgvNhanVien.DataSource = kn.checkID(sql, Name, Value, _soluong)

        End If
    End Sub

    Private Sub btndelsearch_Click(sender As Object, e As EventArgs) Handles btndelsearch.Click
        txtTimKiemNV.Text = ""
    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatExcel.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Mã NV,Tên NV,Chức Vụ,Giới Tính,Năm Sinh,Địa Chỉ,CMND,Phân Quyền, Tên ĐN, MK"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel_NV(dgvNhanVien.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class
