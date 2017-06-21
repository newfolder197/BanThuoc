Public Class FormNhaCC
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
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
        _soLuong = 4

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma_ncc"
        Value(0) = NhaCC.MaNCC


        Name(1) = "@ten_ncc"
        Value(1) = NhaCC.TenNCC

        Name(2) = "@dia_chi"
        Value(2) = NhaCC.DiaChi

        Name(3) = "@sdt"
        Value(3) = NhaCC.SoDT

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
End Class
