Public Class FormThuoc
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDThuoc"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function

    Public Function Add(ByVal ssql As String, ByVal Thuoc As classThuoc) As Integer
        _soLuong = 6

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma_thuoc"
        Value(0) = Thuoc.MaThuoc


        Name(1) = "@ma_nhom"
        Value(1) = Thuoc.MaNhom

        Name(2) = "@ten_thuoc"
        Value(2) = Thuoc.TenThuoc

        Name(3) = "@cong_dung"
        Value(3) = Thuoc.CongDung


        Name(4) = "@dv_tinh"
        Value(4) = Thuoc.Dvt


        Name(5) = "@gia_ban"
        Value(5) = Thuoc.GiaBan


        Name(6) = "@sl "
        Value(6) = Thuoc.Sl


        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function
    Private Sub loadMaNhom()
        cbMaNhom.DataSource = kn.getData("loadNHOMTHUOC")
        cbMaNhom.DisplayMember() = "ten_nhom"
        cbMaNhom.ValueMember() = "ma_nhom"
    End Sub


    Private Sub NameHeaderDgv()
        dgvThuoc.Columns("ma_thuoc").HeaderText = "Mã thuốc"
        dgvThuoc.Columns("ma_nhom").HeaderText = "Mã nhóm"
        dgvThuoc.Columns("ten_thuoc").HeaderText = "Tên thuốc"
        dgvThuoc.Columns("cong_dung").HeaderText = "Công dụng"
        dgvThuoc.Columns("dv_tinh").HeaderText = "Đơn vị tính"
        dgvThuoc.Columns("sl").HeaderText = "Số lượng"
        dgvThuoc.Columns("nsx").HeaderText = "Ngày sản xuất"
        dgvThuoc.Columns("hsd").HeaderText = "Hạn sử dụng"
        dgvThuoc.Columns("gia_ban").HeaderText = "Giá bán"
    End Sub

    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMaThuoc.Text) Then
            lbMaThuoc.Visible = True
            lbMaThuoc.Text = "Mã thuốc không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTenThuoc.Text) Then
            lbTenThuoc.Visible = True
            lbTenThuoc.Text = "Tên thuốc không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtCongDung.Text) Then
            lbCongDung.Visible = True
            lbCongDung.Text = "Công dụng không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtDvt.Text) Then
            lbDvt.Visible = True
            lbDvt.Text = "Đơn vị tính không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtSoLuong.Text) Then
            lbSoLuong.Visible = True
            lbSoLuong.Text = "Số lượng không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtGiaBan.Text) Then
            lbGiaBan.Visible = True
            lbGiaBan.Text = "Giá bán không được rỗng!"
        End If
      
    End Sub

    Private Sub ClearText()
        txtMaThuoc.Text = ""
        txtTenThuoc.Text = ""
        txtCongDung.Text = ""
        txtDvt.Text = ""
        txtSoLuong.Text = ""
        txtGiaBan.Text = ""
    End Sub
    Private Sub ShowData()
        dgvThuoc.DataSource = kn.getData("loadTHUOC")
    End Sub

    Private Sub FormThuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbMaNhom.Visible = False
        lbMaThuoc.Visible = False
        lbCongDung.Visible = False
        lbDvt.Visible = False
        lbGiaBan.Visible = False
        lbSoLuong.Visible = False
        lbTenThuoc.Visible = False
        ShowData()
        NameHeaderDgv()
        loadMaNhom()

    End Sub

    


    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _maThuoc As String
            _maThuoc = txtMaThuoc.Text

            If ktrID(_maThuoc).Rows.Count > 0 Then
                lbMaThuoc.Text = "Trùng mã thuốc!"
                lbMaThuoc.Visible = True
                txtMaThuoc.Text = ""
                txtMaThuoc.Focus()

            Else
                lbMaThuoc.Visible = False
                If (String.IsNullOrEmpty(txtTenThuoc.Text)) OrElse (String.IsNullOrEmpty(txtCongDung.Text)) OrElse (String.IsNullOrEmpty(txtDvt.Text)) OrElse (String.IsNullOrEmpty(txtGiaBan.Text)) Then
                    KtraNULL()
                Else
                    lbTenThuoc.Visible = False
                    lbCongDung.Visible = False
                    lbDvt.Visible = False
                    lbGiaBan.Visible = False
                    Dim Thuoc As New classThuoc
                    Thuoc.MaThuoc = txtMaThuoc.Text
                    Thuoc.MaNhom = cbMaNhom.SelectedValue
                    Thuoc.CongDung = txtCongDung.Text
                    Thuoc.Dvt = txtDvt.Text
                    Thuoc.GiaBan = txtGiaBan.Text

                    sql = "insertTHUOC"
                    Add(sql, Thuoc)
                    ShowData()
                    MessageBox.Show("Thêm thành công!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
 
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaThuoc.Focus()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If (String.IsNullOrEmpty(txtMaThuoc.Text)) OrElse (String.IsNullOrEmpty(txtTenThuoc.Text)) OrElse (String.IsNullOrEmpty(txtCongDung.Text)) OrElse (String.IsNullOrEmpty(txtDvt.Text)) OrElse (String.IsNullOrEmpty(txtSoLuong.Text)) OrElse (String.IsNullOrEmpty(txtGiaBan.Text)) Then
            KtraNULL()
        Else
            lbMaThuoc.Visible = False
            lbTenThuoc.Visible = False
            lbCongDung.Visible = False
            lbDvt.Visible = False
            lbSoLuong.Visible = False
            lbGiaBan.Visible = False
            Dim Thuoc As New classThuoc
            Thuoc.MaThuoc = txtMaThuoc.Text
            Thuoc.MaNhom = cbMaNhom.SelectedValue
            Thuoc.TenThuoc = txtTenThuoc.Text
            Thuoc.CongDung = txtCongDung.Text
            Thuoc.Dvt = txtDvt.Text
            Thuoc.Sl = txtSoLuong.Text
            Thuoc.GiaBan = txtGiaBan.Text


            sql = "updateTHUOC"
            Add(sql, Thuoc)
            ShowData()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub

    Private Sub dgvThuoc_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvThuoc.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvThuoc.Rows(e.RowIndex)
            txtMaThuoc.Text = row.Cells("ma_thuoc").Value.ToString
            cbMaNhom.SelectedValue = row.Cells("ma_nhom").Value
            txtTenThuoc.Text = row.Cells("ten_thuoc").Value.ToString
            txtCongDung.Text = row.Cells("cong_dung").Value.ToString
            txtDvt.Text = row.Cells("dv_tinh").Value.ToString
            txtSoLuong.Text = row.Cells("sl").Value.ToString
            txtGiaBan.Text = row.Cells("gia_ban").Value.ToString
            txtMaThuoc.Enabled = False
        End If
    End Sub
End Class
