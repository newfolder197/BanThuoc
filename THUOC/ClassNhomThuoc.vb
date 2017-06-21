Public Class ClassNhomThuoc
    Private _maNhom, _tenNhom As String
    Public Property MaNhom() As String
        Get
            Return _maNhom

        End Get
        Set(ByVal value As String)
            _maNhom = value
        End Set
    End Property
    Public Property TenNhom() As String
        Get
            Return _tenNhom
        End Get
        Set(ByVal value As String)
            _tenNhom = value
        End Set
    End Property
End Class
