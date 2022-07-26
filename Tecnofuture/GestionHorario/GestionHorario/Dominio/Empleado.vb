Public Class Empleado
    Private mCI As Integer
    Private mNombre As String
    Private mApellido As String
    Private mTipo_E As String
    Private mSistema As Boolean
    Private mUsuario As String
    Private mContrasena As String


    Public Property CI() As Integer
        Get
            Return mCI
        End Get
        Set(ByVal value As Integer)
            mCI = value
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return mNombre
        End Get
        Set(ByVal value As String)
            mNombre = value
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return mApellido
        End Get
        Set(ByVal value As String)
            mApellido = value
        End Set
    End Property
    Public Property Tipo_E() As String
        Get
            Return mTipo_E
        End Get
        Set(ByVal value As String)
            mTipo_E = value
        End Set
    End Property
    Public Property Sistema() As Boolean
        Get
            Return mSistema
        End Get
        Set(ByVal value As Boolean)
            mSistema = value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return mUsuario
        End Get
        Set(ByVal value As String)
            mUsuario = value
        End Set
    End Property
    Public Property Contrasena() As String
        Get
            Return mContrasena
        End Get
        Set(ByVal value As String)
            mContrasena = value
        End Set
    End Property
    Public Sub New(ByVal pCI As Integer, ByVal pNombre As String, ByVal pApellido As String, ByVal pTipo_E As String, ByVal pSistema As Boolean, ByVal pUsuario As String, ByVal pContrasena As String)
        CI = pCI
        Nombre = pNombre
        Apellido = pApellido
        Tipo_E = pTipo_E
        Sistema = pSistema
        Usuario = pUsuario
        Contrasena = pContrasena
    End Sub

    Public Sub New()

    End Sub

End Class
