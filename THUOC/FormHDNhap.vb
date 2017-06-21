Public Class FormHDNhap
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String

    Private Sub FormHDNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbSoCTNhap.Visible = False
        lbTongTienNhap.Visible = False
        loadMaNhaCC()
        loadMaNhanVien()
        ShowData()
        NameHeaderDgv()
    End Sub
    Private Sub NameHeaderDgv()
        dgvHDNhap.Columns("so_ct_nhap").HeaderText = "Số Chứng Từ Nhập"
        dgvHDNhap.Columns("ma_nv").HeaderText = "Mã Nhân Viên"
        dgvHDNhap.Columns("ngay_nhap").HeaderText = "Ngày Nhập"
        dgvHDNhap.Columns("ma_ncc").HeaderText = "Mã Nhà Cung Cấp"
        dgvHDNhap.Columns("tt_nhap").HeaderText = "Tổng Tiền Nhập"
    End Sub
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDhdnhap"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtSoCTNhap.Text) Then
            lbSoCTNhap.Visible = True
            lbSoCTNhap.Text = "Số Chứng Từ Nhập Không Được Rỗng!"
        End If
        If String.IsNullOrEmpty(txtTongTienNhap.Text) Then
            lbTongTienNhap.Visible = True
            lbTongTienNhap.Text = "Tổng Tiền Nhập không được rỗng!"
        End If
    End Sub
    Private Sub loadMaNhanVien()
        cbMaNhanVien.DataSource = kn.getData("loadNHANVIEN")
        cbMaNhanVien.DisplayMember() = "ten_nv"
        cbMaNhanVien.ValueMember() = "ma_nv"

    End Sub
    Private Sub loadMaNhaCC()
        cbMaNhaCC.DataSource = kn.getData("loadNHACC")
        cbMaNhaCC.DisplayMember() = "ten_ncc"
        cbMaNhaCC.ValueMember() = "ma_ncc"
    End Sub
    Private Sub ClearText()
        txtSoCTNhap.Text = ""
        txtTongTienNhap.Text = ""
    End Sub
    Private Sub ShowData()
        dgvHDNhap.DataSource = kn.getData("loadHDNHAP")
    End Sub
    Public Function Add(ByVal ssql As String, ByVal HDNhap As ClassHDNhap) As Integer
        _soLuong = 4

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@so_ct_nhap"
        Value(0) = HDNhap.SoCtNhap


        Name(1) = "@ma_nv"
        Value(1) = HDNhap.Manv

        Name(2) = "@ngay_nhap"
        Value(2) = HDNhap.Ngaynhap

        Name(3) = "@ma_ncc"
        Value(3) = HDNhap.Mancc


        Name(4) = "@tt_nhap"
        Value(4) = HDNhap.Ttnhap


        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function

    Private Sub dgvHDNhap_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHDNhap.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvHDNhap.Rows(e.RowIndex)
            txtSoCTNhap.Text = row.Cells("so_ct_nhap").Value.ToString
            cbMaNhanVien.SelectedValue = row.Cells("ma_nv").Value
            cbMaNhaCC.SelectedValue = row.Cells("ma_ncc").Value
            txtTongTienNhap.Text = row.Cells("tt_nhap").Value.ToString
            txtSoCTNhap.Enabled = False
        End If
    End Sub
End Class
