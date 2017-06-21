Public Class ClassNhanVien
    Private _maNv, _tenNv, _chucVu, _diaChi, _phanQuyen, _tenDn, _mk, _cmnd As String
    Private _gioiTinh As Boolean
    Private _namSinh As Integer
    Public Property Manv() As String
        Get
            Return _maNv
        End Get
        Set(ByVal value As String)
            _maNv = value
        End Set
    End Property
    Public Property Tennv() As String
        Get
            Return _tenNv
        End Get
        Set(ByVal value As String)
            _tenNv = value
        End Set
    End Property


    Public Property Chucvu() As String
        Get
            Return _chucVu
        End Get
        Set(ByVal value As String)
            _chucVu = value
        End Set
    End Property


    Public Property Diachi() As String
        Get
            Return _diaChi
        End Get
        Set(ByVal value As String)
            _diaChi = value
        End Set
    End Property


    Public Property Phanquyen() As String
        Get
            Return _phanQuyen
        End Get
        Set(ByVal value As String)
            _phanQuyen = value
        End Set
    End Property
    Public Property Tendn() As String
        Get
            Return _tenDn
        End Get
        Set(ByVal value As String)
            _tenDn = value
        End Set
    End Property
    Public Property Mk() As String
        Get
            Return _mk
        End Get
        Set(ByVal value As String)
            _mk = value
        End Set
    End Property
    Public Property Cmnd() As String
        Get
            Return _cmnd
        End Get
        Set(ByVal value As String)
            _cmnd = value
        End Set
    End Property
    Public Property Gioitinh() As Boolean
        Get
            Return _gioiTinh
        End Get
        Set(ByVal value As Boolean)
            _gioiTinh = value
        End Set
    End Property
    Public Property Namsinh() As Integer
        Get
            Return _namSinh
        End Get
        Set(ByVal value As Integer)
            _namSinh = value
        End Set
    End Property
End Class
