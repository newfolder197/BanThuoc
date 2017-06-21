Public Class FormNhomThuoc
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
    Public Function ktrID(ByVal Id As String) As DataTable
        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDnhomthuoc"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = Id
        Return kn.checkID(sql, Name, Value, _soluong)
    End Function
    Private Sub KtraNULL()
        If String.IsNullOrEmpty(txtMaNhom.Text) Then
            LbMaNhom.Visible = True
            LbMaNhom.Text = "Mã nhóm không được rỗng!"
        End If
        If String.IsNullOrEmpty(txtTenNhom.Text) Then
            LbTenNhom.Visible = True
            LbTenNhom.Text = "Tên Nhóm không được rỗng!"
        End If

    End Sub
    Public Function Add(ByVal ssql As String, ByVal NhomThuoc As ClassNhomThuoc) As Integer
        _soLuong = 2

        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@ma_nhom"
        Value(0) = NhomThuoc.MaNhom

        Name(1) = "@ten_nhom"
        Value(1) = NhomThuoc.TenNhom

        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function
    Private Sub NameHeaderDgv()
        dgvNhomThuoc.Columns("ma_nhom").HeaderText = "Mã Nhóm"
        dgvNhomThuoc.Columns("ten_nhom").HeaderText = "Tên nhóm"
        
    End Sub
    Private Sub ClearText()
        txtMaNhom.Text = ""
        txtTenNhom.Text = ""
    End Sub
    Private Sub ShowData()
        dgvNhomThuoc.DataSource = kn.getData("loadNHOMTHUOC")
    End Sub
    Private Sub dgvNhomThuoc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhomThuoc.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As New DataGridViewRow
            row = dgvNhomThuoc.Rows(e.RowIndex)
            txtMaNhom.Text = row.Cells("ma_nhom").Value.ToString
            txtTenNhom.Text = row.Cells("ten_nhom").Value.ToString
            txtMaNhom.Enabled = False
        End If
    End Sub
    Private Sub FormNhomThuoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbMaNhom.Visible = False
        LbTenNhom.Visible = False
        ShowData()
        NameHeaderDgv()
    End Sub

    
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtMaNhom.Focus()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _maNhom As String
            _maNhom = txtMaNhom.Text()

            If ktrID(_maNhom).Rows.Count > 0 Then
                LbMaNhom.Text = "Trùng mã nhóm!"
                LbMaNhom.Visible = True
                txtMaNhom.Text = ""
                txtMaNhom.Focus()

            Else
                LbMaNhom.Visible = False
                If (String.IsNullOrEmpty(txtMaNhom.Text)) OrElse (String.IsNullOrEmpty(txtTenNhom.Text)) Then
                    KtraNULL()
                Else
                    LbMaNhom.Visible = False
                    LbTenNhom.Visible = False
                    
                    Dim NhomThuoc As New ClassNhomThuoc
                    NhomThuoc.MaNhom = txtMaNhom.Text
                    NhomThuoc.TenNhom = txtTenNhom.Text
                    sql = "insertNHOMTHUOC"
                    Add(sql, NhomThuoc)
                    ShowData()
                    MessageBox.Show("Thêm thành công!")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
