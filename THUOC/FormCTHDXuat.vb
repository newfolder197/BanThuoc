Public Class FormCTHDXuat
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String

    Private Sub FormCTHDXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbDonGiaXuat.Visible = False
        lbSoCTXuat.Visible = False
        lbSoLuongXuat.Visible = False
        ShowData()
        loadMaThuoc()
        NameHeaderDgv()

    End Sub
    Private Sub NameHeaderDgv()
        dgvCTHDXuat.Columns("so_ct_xuat").HeaderText = "Số Chứng Từ Xuất"
        dgvCTHDXuat.Columns("ma_thuoc").HeaderText = "Mã Thuốc"
        dgvCTHDXuat.Columns("don_gia_ban").HeaderText = "Đơn Giá Bán"
        dgvCTHDXuat.Columns("sl_xuat").HeaderText = "Số Lượng Xuất"
    End Sub
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDcthdxuat"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtDonGiaXuat.Text) Then
            lbDonGiaXuat.Visible = True
            lbDonGiaXuat.Text = "Đơn Giá Xuất Không Được Rỗng!"
        End If
        If String.IsNullOrEmpty(txtSoCTXuat.Text) Then
            lbSoCTXuat.Visible = True
            lbSoCTXuat.Text = "Số Chứng Từ Xuất không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtSoLuongXuat.Text) Then
            lbSoLuongXuat.Visible = True
            lbSoLuongXuat.Text = "Số Lượng Xuất không được rỗng!"
        End If
    End Sub
    Private Sub loadMaThuoc()
        cbMaThuoc.DataSource = kn.getData("loadTHUOC")
        cbMaThuoc.DisplayMember() = "ten_thuoc"
        cbMaThuoc.ValueMember() = "ma_thuoc"
    End Sub
    Private Sub ClearText()
        txtDonGiaXuat.Text = ""
        txtSoCTXuat.Text = ""
        txtSoLuongXuat.Text = ""
    End Sub
    Private Sub ShowData()
        dgvCTHDXuat.DataSource = kn.getData("loadCTHDXUAT")
    End Sub
    Public Function Add(ByVal ssql As String, ByVal CTHDXUAT As ClassCTHDXuat) As Integer
        _soLuong = 3

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@so_ct_xuat"
        Value(0) = CTHDXUAT.SoCtXuat


        Name(1) = "@ma_thuoc"
        Value(1) = CTHDXUAT.MaThuoc

        Name(2) = "@don_gia_ban"
        Value(2) = CTHDXUAT.DonGiaBan

        Name(3) = "@sl_xuat"
        Value(3) = CTHDXUAT.SoLuongXuat


        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function

    Private Sub dgvCTHDXuat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTHDXuat.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvCTHDXuat.Rows(e.RowIndex)
            txtSoCTXuat.Text = row.Cells("so_ct_xuat").Value.ToString
            cbMaThuoc.SelectedValue = row.Cells("ma_thuoc").Value
            txtDonGiaXuat.Text = row.Cells("don_gia_ban").Value.ToString
            txtSoLuongXuat.Text = row.Cells("sl_xuat").Value.ToString
            txtSoCTXuat.Enabled = False
        End If
    End Sub
End Class
