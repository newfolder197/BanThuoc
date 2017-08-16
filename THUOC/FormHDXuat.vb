Public Class FormHDXuat
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String

    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDhdxuat"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtSoCTXuat.Text) Then
            lbSoCTXuat.Visible = True
            lbSoCTXuat.Text = "Số Chứng Từ Xuất Không Được Rỗng!"
        End If
        If String.IsNullOrEmpty(txtTongTienXuat.Text) Then
            lbTongTienXuat.Visible = True
            lbTongTienXuat.Text = "Tổng Tiền Xuất không được rỗng!"
        End If
    End Sub
    Private Sub NameHeaderDgv()
        dgvHdXuat.Columns("so_ct_xuat").HeaderText = "Số Chứng Từ Xuất"
        dgvHdXuat.Columns("ma_nv").HeaderText = "Mã Nhân Viên"
        dgvHdXuat.Columns("ngay_xuat").HeaderText = "Ngày Xuất"
        dgvHdXuat.Columns("tt_ban").HeaderText = "Tổng Tiền Bán"
    End Sub
    Private Sub loadMaNhanVien()
        cbMaNhanVien.DataSource = kn.getData("loadNHANVIEN")
        cbMaNhanVien.DisplayMember() = "ten_nv"
        cbMaNhanVien.ValueMember() = "ma_nv"
    End Sub
    Private Sub ClearText()
        txtSoCTXuat.Text = ""
        txtTongTienXuat.Text = ""
    End Sub
    Private Sub ShowData()
        dgvHDXuat.DataSource = kn.getData("loadHDXUAT")
    End Sub
    Public Function Add(ByVal ssql As String, ByVal HDXuat As ClassHDXuat) As Integer
        _soLuong = 3

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@so_ct_xuat"
        Value(0) = HDXuat.SoCtXuat


        Name(1) = "@ma_nv"
        Value(1) = HDXuat.Manv

        Name(2) = "@ngay_xuat"
        Value(2) = HDXuat.NgayXuat

        Name(3) = "@tt_ban"
        Value(3) = HDXuat.TtBan

        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function

    Private Sub FormHDXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormCTHDXuat1.Visible = False
        FormCTHDXuat1.SendToBack()
        lbSoCTXuat.Visible = False
        lbTongTienXuat.Visible = False
        ShowData()
        NameHeaderDgv()
        loadMaNhanVien()
    End Sub

    Private Sub dgvHdXuat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHdXuat.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvHdXuat.Rows(e.RowIndex)
            txtSoCTXuat.Text = row.Cells("so_ct_xuat").Value.ToString
            FormCTHDXuat1.txtSoCTXuat.Text = row.Cells("so_ct_xuat").Value.ToString

            cbMaNhanVien.SelectedValue = row.Cells("ma_nv").Value
            txtTongTienXuat.Text = row.Cells("tt_ban").Value.ToString
            DateTimePicker1.Value = row.Cells("ngay_xuat").Value.ToString
            txtSoCTXuat.Enabled = False

            FormCTHDXuat1.txtSoCTXuat.Text = row.Cells("so_ct_xuat").Value.ToString
            FormCTHDXuat1.txtTongTienXuat.Text = row.Cells("tt_ban").Value.ToString
            FormCTHDXuat1.dtpngayxuat.Value = DateTimePicker1.Value.ToString
        End If
    End Sub
    Public Function Remove(ByVal ssql As String, ByVal HDxuat As ClassHDXuat) As Integer
        _soLuong = 0
        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma"
        Value(0) = HDxuat.SoCtXuat
        Return kn.Add(ssql, Name, Value, _soLuong)

    End Function

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim HDxuat As New ClassHDXuat
            HDxuat.SoCtXuat = txtSoCTXuat.Text
            sql = "removeHDXUAT"
            Remove(sql, HDxuat)
            ShowData()
            ClearText()
            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _soct As String
            _soct = txtSoCTXuat.Text

            If ktrID(_soct).Rows.Count > 0 Then
                lbSoCTXuat.Text = "Trùng Số Chứng Từ!"
                lbSoCTXuat.Visible = True
                txtSoCTXuat.Text = ""
                txtSoCTXuat.Focus()

            Else

                lbSoCTXuat.Visible = False
                If (String.IsNullOrEmpty(txtSoCTXuat.Text)) OrElse (String.IsNullOrEmpty(txtTongTienXuat.Text)) Then
                    KtraNULL()
                Else


                    lbSoCTXuat.Visible = False
                    lbTongTienXuat.Visible = False
                    Dim HDxuat As New ClassHDXuat
                    HDxuat.SoCtXuat = txtSoCTXuat.Text
                    HDxuat.Manv = cbMaNhanVien.SelectedValue
                    HDxuat.TtBan = txtTongTienXuat.Text
                    HDxuat.NgayXuat = DateTimePicker1.Value.ToString


                    sql = "insertHDXUAT"
                    Add(sql, HDxuat)
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
        txtSoCTXuat.Focus()
        txtSoCTXuat.Enabled = True
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If (String.IsNullOrEmpty(txtSoCTXuat.Text)) Then
            KtraNULL()
        Else
            lbSoCTXuat.Visible = False
            lbTongTienXuat.Visible = False

            Dim HDxuat As New ClassHDXuat
            HDxuat.SoCtXuat = txtSoCTXuat.Text
            HDxuat.Manv = cbMaNhanVien.SelectedValue
            HDxuat.TtBan = txtTongTienXuat.Text
            HDxuat.NgayXuat = DateTimePicker1.Value.ToString

            sql = "updateHDXUAT"
            Add(sql, HDxuat)
            ShowData()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub

    Private Sub txtTimKiemHDXuat_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiemHDXuat.TextChanged
        Dim _soluong As Integer
        Dim sql As String
        _soluong = 0
        Dim Value(_soluong) As String
        Dim Name(_soluong) As String
        If txtTimKiemHDXuat.Text.Length > 0 Then

            sql = "searchIDHDXUAT"
            Name(0) = "@ma"
            Value(0) = txtTimKiemHDXuat.Text
            dgvHdXuat.DataSource = kn.checkID(sql, Name, Value, _soluong)

        End If
    End Sub

    Private Sub btndelsearch_Click(sender As Object, e As EventArgs) Handles btndelsearch.Click
        txtTimKiemHDXuat.Text = ""
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        FormCTHDXuat1.Visible = True
        FormCTHDXuat1.BringToFront()
        FormCTHDXuat1.lbsophieuxuat.Text = txtSoCTXuat.Text
    End Sub


End Class
