Public Class FormNhaCC
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
    Private sl As Integer = 0
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDnhacc"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Public Function Add(ByVal ssql As String, ByVal NhaCC As ClassNhaCC) As Integer
        _soLuong = 3

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma_ncc"
        Value(0) = NhaCC.MaNCC

        Name(1) = "@ten_ncc"
        Value(1) = NhaCC.TenNCC

        Name(2) = "@dc"
        Value(2) = NhaCC.DiaChi

        Name(3) = "@sdt"
        Value(3) = NhaCC.SoDT

        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function
    Public Function Remove(ByVal ssql As String, ByVal ncc As ClassNhaCC) As Integer
        _soLuong = 0
        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma"
        Value(0) = ncc.MaNCC
        Return kn.Add(ssql, Name, Value, _soLuong)

    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtDiaChi.Text) Then
            lbDiaChi.Visible = True
            lbDiaChi.Text = "Địa Chỉ không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtMaNhaCC.Text) Then
            lbMaNhaCC.Visible = True
            lbMaNhaCC.Text = "Mã Nhà Cung Cấp không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtSDT.Text) Then
            lbSDT.Visible = True
            lbSDT.Text = "Số Điện Thoại không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTenNhaCC.Text) Then
            lbTenNhaCC.Visible = True
            lbTenNhaCC.Text = "Tên Nhà Cung Cấp không được rỗng!"
        End If
    End Sub
    Private Sub NameHeaderDgv()
        dgvNhaCC.Columns("ma_ncc").HeaderText = "Mã Nhà Cung Cấp"
        dgvNhaCC.Columns("ten_ncc").HeaderText = "Tên Nhà Cung Cấp"
        dgvNhaCC.Columns("dia_chi").HeaderText = "Địa Chỉ"
        dgvNhaCC.Columns("sdt").HeaderText = "Số Điện Thoại"
    End Sub
    Private Sub ClearText()
        txtDiaChi.Text = ""
        txtMaNhaCC.Text = ""
        txtSDT.Text = ""
        txtTenNhaCC.Text = ""
    End Sub
    Private Sub ShowData()
        dgvNhaCC.DataSource = kn.getData("loadNHACC")
    End Sub
    Private Sub FormNhaCC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTimKiemNCC.Text = ""
        lbDiaChi.Visible = False
        lbMaNhaCC.Visible = False
        lbSDT.Visible = False
        lbTenNhaCC.Visible = False
        ShowData()
        NameHeaderDgv()

    End Sub

    Private Sub dgvNhaCC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhaCC.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvNhaCC.Rows(e.RowIndex)
            txtMaNhaCC.Text = row.Cells("ma_ncc").Value.ToString
            txtTenNhaCC.Text = row.Cells("ten_ncc").Value.ToString
            txtDiaChi.Text = row.Cells("dia_chi").Value.ToString
            txtSDT.Text = row.Cells("sdt").Value.ToString
            txtMaNhaCC.Enabled = False
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If (String.IsNullOrEmpty(txtTenNhaCC.Text)) OrElse (String.IsNullOrEmpty(txtSDT.Text)) OrElse (String.IsNullOrEmpty(txtMaNhaCC.Text)) OrElse (String.IsNullOrEmpty(txtDiaChi.Text)) Then
            KtraNULL()
        Else
            lbDiaChi.Visible = False
            lbMaNhaCC.Visible = False
            lbTenNhaCC.Visible = False
            lbSDT.Visible = False
            Dim ncc As New ClassNhaCC
            ncc.MaNCC = txtMaNhaCC.Text
            ncc.TenNCC = txtTenNhaCC.Text
            ncc.Diachi = txtDiaChi.Text
            ncc.SoDT = txtSDT.Text
            sql = "updateNHACC"
            Add(sql, ncc)
            ShowData()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaNhaCC.Focus()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim ncc As New ClassNhaCC
            ncc.MaNCC = txtMaNhaCC.Text
            sql = "removeNHACC"
            Remove(sql, ncc)
            ShowData()
            ClearText()
            'MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _mancc As String
            _mancc = txtMaNhaCC.Text

            If ktrID(_mancc).Rows.Count > 0 Then
                lbMaNhaCC.Text = "Trùng mã nhà cung cấp!"
                lbMaNhaCC.Visible = True
                txtMaNhaCC.Text = ""
                txtMaNhaCC.Focus()
            Else
                lbMaNhaCC.Visible = False
                If (String.IsNullOrEmpty(txtMaNhaCC.Text)) OrElse (String.IsNullOrEmpty(txtDiaChi.Text)) OrElse (String.IsNullOrEmpty(txtTenNhaCC.Text)) OrElse (String.IsNullOrEmpty(txtSDT.Text)) Then
                    KtraNULL()
                Else
                    lbMaNhaCC.Visible = False
                    lbTenNhaCC.Visible = False
                    lbDiaChi.Visible = False
                    lbSDT.Visible = False
                    Dim NhaCC As New ClassNhaCC
                    NhaCC.MaNCC = txtMaNhaCC.Text
                    NhaCC.TenNCC = txtTenNhaCC.Text
                    NhaCC.DiaChi = txtDiaChi.Text
                    NhaCC.SoDT = txtSDT.Text
                    sql = "insertNHACC"
                    Add(sql, NhaCC)
                    ShowData()
                    MessageBox.Show("Thêm thành công!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btndelsearch_Click(sender As Object, e As EventArgs) Handles btndelsearch.Click
        txtTimKiemNCC.Text = ""
    End Sub


    Private Sub txtTimKiemNCC_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemNCC.TextChanged
        Dim _soluong As Integer
        Dim sql As String
        _soluong = 0
        Dim Value(_soluong) As String
        Dim Name(_soluong) As String
        If txtTimKiemNCC.Text.Length > 0 Then

            sql = "searchIDNHACC"
            Name(0) = "@ma"
            Value(0) = txtTimKiemNCC.Text
            dgvNhaCC.DataSource = kn.checkID(sql, Name, Value, _soluong)

        End If
    End Sub
End Class
