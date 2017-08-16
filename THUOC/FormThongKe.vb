
Public Class FormThongKe

    Dim kn As New KetNoi
    Private _soLuong As Integer
    Private sql As String
    Private Sub FormThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
        NameHeaderDgv()
        NameHeaderDgv1()
        NameHeaderDgv2()
        NameHeaderDgv3()
        tongsl()
        tongthu()
        tongchi()
        doanhthu()
    End Sub

    Private Sub NameHeaderDgv()
        dgvthuoctrongkho.Columns("ma_thuoc").HeaderText = "Mã thuốc"
        dgvthuoctrongkho.Columns("ma_nhom").HeaderText = "Mã nhóm"
        dgvthuoctrongkho.Columns("ten_thuoc").HeaderText = "Tên thuốc"
        dgvthuoctrongkho.Columns("cong_dung").HeaderText = "Công dụng"
        dgvthuoctrongkho.Columns("dv_tinh").HeaderText = "Đơn vị tính"
        dgvthuoctrongkho.Columns("sl").HeaderText = "Số lượng"
        dgvthuoctrongkho.Columns("nsx").HeaderText = "Ngày sản xuất"
        dgvthuoctrongkho.Columns("hsd").HeaderText = "Hạn sử dụng"
        dgvthuoctrongkho.Columns("gia_ban").HeaderText = "Giá bán"
    End Sub
    Private Sub NameHeaderDgv3()
        dgvcthdnhap.Columns("so_ct_nhap").HeaderText = "Số Chứng Từ Nhập"
        dgvcthdnhap.Columns("tt_nhap").HeaderText = "Tổng Tiền Nhập"
    End Sub
    Private Sub NameHeaderDgv1()
        dgvthuochethan.Columns("ma_thuoc").HeaderText = "Mã thuốc"
        dgvthuochethan.Columns("ma_nhom").HeaderText = "Mã nhóm"
        dgvthuochethan.Columns("ten_thuoc").HeaderText = "Tên thuốc"
        dgvthuochethan.Columns("cong_dung").HeaderText = "Công dụng"
        dgvthuochethan.Columns("dv_tinh").HeaderText = "Đơn vị tính"
        dgvthuochethan.Columns("sl").HeaderText = "Số lượng"
        dgvthuochethan.Columns("nsx").HeaderText = "Ngày sản xuất"
        dgvthuochethan.Columns("hsd").HeaderText = "Hạn sử dụng"
        dgvthuochethan.Columns("gia_ban").HeaderText = "Giá bán"
    End Sub
    Private Sub NameHeaderDgv2()
        dgvcthdxuat.Columns("so_ct_xuat").HeaderText = "Số Chứng Từ Xuất"
        dgvcthdxuat.Columns("tt_ban").HeaderText = "Tổng Tiền Bán"
    End Sub
    Private Sub ShowData()
        dgvthuoctrongkho.DataSource = kn.getData("loadTHUOC")
        dgvthuochethan.DataSource = kn.getData("thuochethan")
        dgvcthdxuat.DataSource = kn.getData("loadHDXUAT1")
        dgvcthdnhap.DataSource = kn.getData("loadHDNHAP1")

    End Sub

    Private Sub btnxuatexcelthuoc_Click(sender As Object, e As EventArgs) Handles btnxuatexcelthuoc.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Mã Thuốc,Mã Nhóm,Tên Thuốc,Công Dụng,Đơn Vị Tính,Địa Chỉ,Số Lượng,Ngày Sản Xuất,Hạn Sử Dụng, Giá Bán"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel_thuoc(dgvthuoctrongkho.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btnxuatexcelsaphethan_Click(sender As Object, e As EventArgs) Handles btnxuatexcelsaphethan.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Mã Thuốc,Mã Nhóm,Tên Thuốc,Công Dụng,Đơn Vị Tính,Địa Chỉ,Số Lượng,Ngày Sản Xuất,Hạn Sử Dụng, Giá Bán"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel_thuoc(dgvthuochethan.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub

    Private Sub btnxuatexcelsaphetsl_Click(sender As Object, e As EventArgs) Handles btnxuatexcelsaphetsl.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Số Chứng Từ Nhập,Tổng Tiền Nhập"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel_thuoc(dgvcthdnhap.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
    Private Sub tongsl()
        tongslthuoc.Text = dgvthuoctrongkho.RowCount.ToString
        Dim sum As Integer
        Try
            For i = 0 To dgvthuoctrongkho.RowCount - 1
                sum += dgvthuoctrongkho.Rows(i).Cells(5).Value
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        tongslthuoc.Text = sum.ToString
    End Sub
    Private Sub tongthu()
        lbtongthu.Text = dgvcthdxuat.RowCount.ToString
        Dim sum As Integer
        Try
            For i = 0 To dgvcthdxuat.RowCount - 1
                sum += dgvcthdxuat.Rows(i).Cells(1).Value
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        lbtongthu.Text = sum.ToString
    End Sub
    Private Sub tongchi()
        lbtongchi.Text = dgvcthdnhap.RowCount.ToString
        Dim sum As Integer
        Try
            For i = 0 To dgvcthdnhap.RowCount - 1
                sum += dgvcthdnhap.Rows(i).Cells(1).Value
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        lbtongchi.Text = sum.ToString

    End Sub
    Private Sub doanhthu()
        lbtongthu.Text = dgvcthdxuat.RowCount.ToString
        tongthu()

        lbtongchi.Text = dgvcthdnhap.RowCount.ToString
        tongchi()

        lbdoanhthu.Text = lbtongthu.Text - lbtongchi.Text
    End Sub

    Private Sub btnxuatexcelhethan_Click(sender As Object, e As EventArgs) Handles btnxuatexcelhethan.Click
        Dim SaveFileDialog1 As SaveFileDialog = New SaveFileDialog()

        Dim colName As String = "Số Chứng từ Xuất, Tổng Tiền Bán"
        Try
            SaveFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            Dim File_name = SaveFileDialog1.FileName
            Export_to_Excel_thuoc(dgvcthdnhap.DataSource, colName, File_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub
End Class
