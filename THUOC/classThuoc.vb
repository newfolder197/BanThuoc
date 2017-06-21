Public Class classThuoc
    Private _maThuoc, _maNhom, _tenThuoc, _congDung, _dvt As String
    Private _sl, _giaBan As Integer
    Private _nsx, _hsd As Date
    Public Property Nsx() As Date
        Get
            Return _nsx
        End Get
        Set(ByVal value As Date)
            _nsx = value
        End Set
    End Property
    Public Property Hsd() As Date
        Get
            Return _hsd
        End Get
        Set(ByVal value As Date)
            _hsd = value
        End Set
    End Property


    Public Property Sl() As Integer
        Get
            Return _sl
        End Get
        Set(ByVal value As Integer)
            _sl = value
        End Set
    End Property


    Public Property GiaBan() As Integer
        Get
            Return _giaBan
        End Get
        Set(ByVal value As Integer)
            _giaBan = value
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
    Public Property MaNhom() As String
        Get
            Return _maNhom
        End Get
        Set(ByVal value As String)
            _maNhom = value
        End Set
    End Property
    Public Property TenThuoc() As String
        Get
            Return _tenThuoc
        End Get
        Set(ByVal value As String)
            _tenThuoc = value
        End Set
    End Property
    Public Property CongDung() As String
        Get
            Return _congDung
        End Get
        Set(ByVal value As String)
            _congDung = value
        End Set
    End Property
    Public Property Dvt() As String
        Get
            Return _dvt
        End Get
        Set(ByVal value As String)
            _dvt = value
        End Set
    End Property

    Public Sub New()

    End Sub

End Class
