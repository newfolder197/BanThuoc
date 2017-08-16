Public Class FormCTHDXuat
    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
    Dim directory As String = My.Application.Info.DirectoryPath
    Private Sub FormCTHDXuat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbDonGiaXuat.Visible = False
        lbSoCTXuat.Visible = False
        lbSoLuongXuat.Visible = False
        loadMaThuoc()

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
        txtSoLuongXuat.Text = ""
    End Sub
    Private Sub ShowData(ByVal id As String)
        ' MsgBox(id)

        Dim _soluong As Integer
        _soluong = 0
        Dim sql As String
        sql = "checkIDcthdxuat"
        Dim Name(_soluong) As String
        Dim Value(_soluong) As String
        Name(0) = "@ma"
        Value(0) = id
        dgvCTHDXuat.DataSource = kn.checkID(sql, Name, Value, _soluong)

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

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Try
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnInHoaDonXuat_Click(sender As Object, e As EventArgs) Handles btnInHoaDonXuat.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Số chứng từ xuất,Mã thuốc,Đơn giá bán,Số lượng Xuất"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel(dgvCTHDXuat.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub txtSoCTXuat_OnValueChanged(sender As Object, e As EventArgs) Handles txtSoCTXuat.OnValueChanged
        ShowData(txtSoCTXuat.Text)

        NameHeaderDgv()
    End Sub
    Public Function Remove(ByVal ssql As String, ByVal cthdxuat As ClassCTHDXuat) As Integer
        _soLuong = 0
        Dim Name(_soLuong) As String
        Dim Value(_soLuong) As Object
        Name(0) = "@so_ct_xuat"
        Value(0) = cthdxuat.SoCtXuat

        Return kn.Add(ssql, Name, Value, _soLuong)
    End Function
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Try
            Dim _soct As String
            _soct = txtSoCTXuat.Text
            If (String.IsNullOrEmpty(txtDonGiaXuat.Text)) OrElse (String.IsNullOrEmpty(txtSoLuongXuat.Text)) Then
                    KtraNULL()
                Else

                    Dim cthdxuat As New ClassCTHDXuat
                    cthdxuat.SoCtXuat = txtSoCTXuat.Text
                    cthdxuat.MaThuoc = cbMaThuoc.SelectedValue
                    cthdxuat.DonGiaBan = txtDonGiaXuat.Text
                    cthdxuat.SoLuongXuat = txtSoLuongXuat.Text


                    sql = "insertCTHDXUAT"
                    Add(sql, cthdxuat)
                    ShowData(Me.txtSoCTXuat.Text)

                    MessageBox.Show("Thêm thành công!")
                End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
        txtDonGiaXuat.Enabled = True
        txtSoLuongXuat.Enabled = True
        txtDonGiaXuat.Focus()
        txtSoCTXuat.Enabled = False
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Try
            Dim cthdxuat As New ClassCTHDXuat
            cthdxuat.SoCtXuat = txtSoCTXuat.Text

            sql = "removeCTHDXUAT"
            Remove(sql, cthdxuat)
            ShowData(Me.txtSoCTXuat.Text)
            ClearText()


            MessageBox.Show("Xóa thành công!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If (String.IsNullOrEmpty(txtSoLuongXuat.Text)) OrElse (String.IsNullOrEmpty(txtDonGiaXuat.Text)) Then
            KtraNULL()
        Else

            Dim cthdxuat As New ClassCTHDXuat

            cthdxuat.SoCtXuat = txtSoCTXuat.Text
            cthdxuat.MaThuoc = cbMaThuoc.SelectedValue
            cthdxuat.DonGiaBan = txtDonGiaXuat.Text
            cthdxuat.SoLuongXuat = txtSoLuongXuat.Text

            sql = "updateCTHDXUAT"
            Add(sql, cthdxuat)
            ShowData(Me.txtSoCTXuat.Text)
            '  NameHeaderDgv()
            MessageBox.Show("Cập nhật thành công!")
        End If
    End Sub


End Class
