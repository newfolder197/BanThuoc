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
            cbMaNhanVien.SelectedValue = row.Cells("ma_nv").Value
            txtTongTienXuat.Text = row.Cells("tt_ban").Value.ToString
            txtSoCTXuat.Enabled = False
        End If
    End Sub
End Class
