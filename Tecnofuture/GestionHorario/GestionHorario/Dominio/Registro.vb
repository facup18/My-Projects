
Public Class Registro

    Private mid As Integer
    Private mH_Entrada As Integer
    Private mH_Salida As Integer
    Private mFecha As Date
    Private mObservaciones As String
    Private mHorario As Horario
    Private mEmpleado As Empleado
    Private mHora As Hora

    Public Property id() As Integer
        Get
            Return mid
        End Get
        Set(ByVal value As Integer)
            mid = value
        End Set
    End Property

    Public Property H_Entrada() As Integer
        Get
            Return mH_Entrada
        End Get
        Set(ByVal value As Integer)
            mH_Entrada = value
        End Set
    End Property

    Public Property H_Salida() As Integer
        Get
            Return mH_Salida
        End Get
        Set(ByVal value As Integer)
            mH_Salida = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return mFecha
        End Get
        Set(ByVal value As Date)
            mFecha = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return mObservaciones
        End Get
        Set(ByVal value As String)
            mObservaciones = value
        End Set
    End Property

    Public Property Horario() As Horario
        Get
            Return mHorario
        End Get
        Set(ByVal value As Horario)
            mHorario = value
        End Set
    End Property

    Public Property Empleado() As Empleado
        Get
            Return mEmpleado
        End Get
        Set(ByVal value As Empleado)
            mEmpleado = value
        End Set
    End Property

    Public Property Hora() As Hora
        Get
            Return mHora
        End Get
        Set(ByVal value As Hora)
            mHora = value
        End Set
    End Property

    Public Sub New(ByVal pid As Integer, ByVal pH_Entrada As Integer, ByVal pH_Salida As Integer, ByVal pFecha As Date, _
                   ByVal pObservaciones As String, ByVal pHorario As Horario, ByVal pEmpleado As Empleado, _
                   ByVal pHora As Hora)

        id = pid
        H_Entrada = pH_Entrada
        H_Salida = pH_Salida
        Fecha = pFecha
        Observaciones = pObservaciones
        Horario = pHorario
        Empleado = pEmpleado
        Hora = pHora

    End Sub

    Public Sub New()

    End Sub
End Class
