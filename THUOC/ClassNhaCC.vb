Public Class ClassNhaCC
    Private _maNcc, _tenNCC, _diaChi As String
    Private _sdt As Integer
    Public Property MaNCC() As String
        Get
            Return _maNcc
        End Get
        Set(ByVal value As String)
            _maNcc = value
        End Set
    End Property
    Public Property TenNCC() As String
        Get
            Return _tenNCC
        End Get
        Set(ByVal value As String)
            _tenNCC = value
        End Set
    End Property


    Public Property DiaChi() As Integer
        Get
            Return _diaChi
        End Get
        Set(ByVal value As Integer)
            _diaChi = value
        End Set
    End Property


    Public Property SoDT() As Integer
        Get
            Return _sdt
        End Get
        Set(ByVal value As Integer)
            _sdt = value
        End Set
    End Property
End Class
