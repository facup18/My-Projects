Public Class Horario

    Private mId As Integer
    Private mEntrada As Integer
    Private mSalida As Integer

    Public Property Id() As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property Entrada() As Integer
        Get
            Return mEntrada
        End Get
        Set(ByVal value As Integer)
            mEntrada = value
        End Set
    End Property

    Public Property Salida() As Integer
        Get
            Return mSalida
        End Get
        Set(ByVal value As Integer)
            mSalida = value
        End Set
    End Property

    Public Sub New(ByVal pId As Integer, ByVal pEntrada As Integer, ByVal pSalida As Integer)

        Id = pId
        Entrada = pEntrada
        Salida = pSalida

    End Sub

    Public Sub New()

    End Sub
End Class
