Public Class Form1

    
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

        Try
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
        FormCTHDNhap1.BringToFront()

    End Sub

    Private Sub btnCTHDXuat_Click(sender As Object, e As EventArgs) Handles btnCTHDXuat.Click
        FormCTHDXuat1.BringToFront()

    End Sub

    Private Sub FormCTHDXuat1_Load(sender As Object, e As EventArgs) Handles FormCTHDXuat1.Load

    End Sub
End Class