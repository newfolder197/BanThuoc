Public Class ClassCTHDXuat
    Private _soCtXuat, _maThuoc As String
    Private _donGiaBan, _slXuat As Integer
    Public Property SoCtXuat() As String
        Get
            Return _soCtXuat
        End Get
        Set(ByVal value As String)
            _soCtXuat = value
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
    Public Property DonGiaBan() As Integer
        Get
            Return _donGiaBan
        End Get
        Set(ByVal value As Integer)
            _donGiaBan = value
        End Set
    End Property
    Public Property SoLuongXuat() As Integer
        Get
            Return _slXuat
        End Get
        Set(ByVal value As Integer)
            _slXuat = value
        End Set
    End Property
End Class
