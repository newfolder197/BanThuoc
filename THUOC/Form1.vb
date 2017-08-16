Public Class Form1


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Try
            Form2.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnThuoc_Click(sender As Object, e As EventArgs) Handles btnThuoc.Click
        FormThuoc1.BringToFront()

    End Sub

    Private Sub btnNhomThuoc_Click(sender As Object, e As EventArgs) Handles btnNhomThuoc.Click
        FormNhomThuoc1.BringToFront()

    End Sub

    Private Sub btnNhanVien_Click(sender As Object, e As EventArgs) Handles btnNhanVien.Click
        FormNhanVien1.BringToFront()

    End Sub

    Private Sub btnNhaCungCap_Click(sender As Object, e As EventArgs) Handles btnNhaCungCap.Click
        FormNhaCC1.BringToFront()
    End Sub

    Private Sub btnHoaDonXuat_Click(sender As Object, e As EventArgs) Handles btnHoaDonXuat.Click
        FormHDXuat1.BringToFront()
    End Sub

    Private Sub btnHoaDonNhap_Click(sender As Object, e As EventArgs) Handles btnHoaDonNhap.Click
        FormHDNhap1.BringToFront()

    End Sub

    Private Sub btnCTHDNhap_Click(sender As Object, e As EventArgs) Handles btnCTHDNhap.Click
        MsgBox("Trước Tiên Hãy Ghé Thăm Hóa Đơn Nhập ->Detail Để ra CTHD Nhập Bạn Nhé !", vbOKOnly + vbInformation, "Warning")

    End Sub


    Private Sub btnCTHDXuat_Click(sender As Object, e As EventArgs) Handles btnCTHDXuat.Click
        MsgBox("Trước Tiên Hãy Ghé Thăm Hóa Đơn Nhập ->Detail Để ra CTHD Nhập Bạn Nhé !", vbOKOnly + vbInformation, "Warning")
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        FormHome1.BringToFront()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        FormThongKe1.BringToFront()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormHome1.BringToFront()

    End Sub
End Class