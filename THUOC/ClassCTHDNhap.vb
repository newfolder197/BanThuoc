Public Class ClassCTHDNhap
    Private _soCtNhap, _maThuoc As String
    Private _donGiaNhap, _slNhap, _soLo As Integer
    Private _nsx, _hsd As Date
    Public Property SoCTNhap() As String
        Get
            Return _soCtNhap
        End Get
        Set(ByVal value As String)
            _soCtNhap = value
        End Set
    End Property
    Public Property MaThuoc() As String
        Get
            Return _maThuoc
        End Get
        Set(ByVal value As String)
            _maThuoc = value
        End Set
    End Property
    Public Property DonGiaNhap() As Integer
        Get
            Return _donGiaNhap
        End Get
        Set(ByVal value As Integer)
            _donGiaNhap = value
        End Set
    End Property
    Public Property SLNhap() As Integer
        Get
            Return _slNhap
        End Get
        Set(ByVal value As Integer)
            _slNhap = value
        End Set
    End Property
    Public Property SoLo() As Integer
        Get
            Return _soLo
        End Get
        Set(ByVal value As Integer)
            _soLo = value
        End Set
    End Property
    Public Property NgaySanXuat() As Date
        Get
            Return _nsx
        End Get
        Set(ByVal value As Date)
            _nsx = value
        End Set
    End Property
    Public Property HanSuDung() As Date
        Get
            Return _hsd
        End Get
        Set(ByVal value As Date)
            _hsd = value
        End Set
    End Property
End Class
