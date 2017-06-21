Public Class FormCTHDNhap
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
  
    Private Sub NameHeaderDgv()
        dgvCTHDnhap.Columns("so_ct_nhap").HeaderText = "Số Chứng Từ Nhập"
        dgvCTHDnhap.Columns("ma_thuoc").HeaderText = "Mã Thuốc"
        dgvCTHDnhap.Columns("don_gia_nhap").HeaderText = "Đơn Giá Nhập"
        dgvCTHDnhap.Columns("sl_nhap").HeaderText = "Số Lượng Nhập"
        dgvCTHDnhap.Columns("so_lo").HeaderText = "Số Lô "
        dgvCTHDnhap.Columns("nsx").HeaderText = "Ngày Sản Xuất"
        dgvCTHDnhap.Columns("hsd").HeaderText = "Hạn Sử Dụng"
    End Sub
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDcthdnhap"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtDonGiaNhap.Text) Then
            lbDonGiaNhap.Visible = True
            lbDonGiaNhap.Text = "Đơn Giá Nhập Không Được Rỗng!"
        End If
        If String.IsNullOrEmpty(txtSoCTNhap.Text) Then
            lbSoCTNhap.Visible = True
            lbSoCTNhap.Text = "Số Chứng Từ Nhập không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtSoLo.Text) Then
            lbSoLo.Visible = True
            lbSoLo.Text = "Số Lô không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtSoLuongNhap.Text) Then
            lbSoLuongNhap.Visible = True
            lbSoLuongNhap.Text = "Số Lượng Nhập không được rỗng!"
        End If
    End Sub
    Private Sub loadMaThuoc()
        cbMaThuoc.DataSource = kn.getData("loadTHUOC")
        cbMaThuoc.DisplayMember() = "ten_thuoc"
        cbMaThuoc.ValueMember() = "ma_thuoc"

    End Sub
    Private Sub ClearText()
        txtDonGiaNhap.Text = ""
        txtSoCTNhap.Text = ""
        txtSoLo.Text = ""
        txtSoLuongNhap.Text = ""
    End Sub
    Private Sub ShowData()
        dgvCTHDnhap.DataSource = kn.getData("loadCTHDNHAP")
    End Sub
    Public Function Add(ByVal ssql As String, ByVal CTHDNHAP As ClassCTHDNhap) As Integer
        _soLuong = 6

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@so_ct_nhap"
        Value(0) = CTHDNHAP.SoCTNhap

        Name(1) = "@ma_thuoc"
        Value(1) = CTHDNHAP.MaThuoc

        Name(2) = "@don_gia_nhap"
        Value(2) = CTHDNHAP.DonGiaNhap

        Name(3) = "@sl_nhap"
        Value(3) = CTHDNHAP.SLNhap

        Name(4) = "@so_lo"
        Value(4) = CTHDNHAP.SoLo

        Name(5) = "@nsx"
        Value(5) = CTHDNHAP.NgaySanXuat

        Name(6) = "@hsd"
        Value(6) = CTHDNHAP.HanSuDung


        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function
    Private Sub FormCTHDNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbDonGiaNhap.Visible = False
        lbSoCTNhap.Visible = False
        lbSoLo.Visible = False
        lbSoLuongNhap.Visible = False
        ShowData()
        NameHeaderDgv()
        
    End Sub

    Private Sub dgvCTHDNhap_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTHDnhap.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvCTHDnhap.Rows(e.RowIndex)
            txtSoCTNhap.Text = row.Cells("so_ct_nhap").Value.ToString
            cbMaThuoc.SelectedValue = row.Cells("ma_thuoc").Value
            txtDonGiaNhap.Text = row.Cells("don_gia_nhap").Value.ToString
            txtSoLuongNhap.Text = row.Cells("sl_nhap").Value.ToString
            txtSoLo.Text = row.Cells("so_lo").Value.ToString
            txtSoCTNhap.Enabled = False
        End If
    End Sub
End Class
