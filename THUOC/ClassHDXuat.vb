Public Class ClassHDXuat
    Private _soCTXuat, _maNv As String
    Private _ngayXuat As Date
    Private _ttBan As Integer
    Public Property SoCtXuat() As String
        Get
            Return _soCTXuat
        End Get
        Set(ByVal value As String)
            _soCTXuat = value
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
    Public Property NgayXuat() As Date
        Get
            Return _ngayXuat
        End Get
        Set(ByVal value As Date)
            _ngayXuat = value
        End Set
    End Property


    Public Property TtBan() As Integer
        Get
            Return _ttBan
        End Get
        Set(ByVal value As Integer)
            _ttBan = value
        End Set
    End Property
End Class
