Public Class ClassHDNhap
    Private _soCTNhap, _maNv, _maNcc As String
    Private _ngayNhap As Date
    Private _ttNhap As Integer
    Public Property SoCtNhap() As String
        Get
            Return _soCTNhap
        End Get
        Set(ByVal value As String)
            _soCTNhap = value
        End Set
    End Property
    Public Property Manv() As String
        Get
            Return _maNv
        End Get
        Set(ByVal value As String)
            _maNv = value
        End Set
    End Property
    Public Property Mancc() As String
        Get
            Return _maNcc
        End Get
        Set(ByVal value As String)
            _maNcc = value
        End Set
    End Property


    Public Property Ngaynhap() As Date
        Get
            Return _ngayNhap
        End Get
        Set(ByVal value As Date)
            _ngayNhap = value
        End Set
    End Property


    Public Property Ttnhap() As Integer
        Get
            Return _ttNhap
        End Get
        Set(ByVal value As Integer)
            _ttNhap = value
        End Set
    End Property
End Class
