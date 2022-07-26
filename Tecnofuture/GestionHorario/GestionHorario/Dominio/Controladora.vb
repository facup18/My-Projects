Public Class Controladora
    Private unaconexion As New Conexion
    Private pEmpleado As New pEmpleado
    Private pHora As New pHora
    Private pHorario As New pHorario
    Private pRegistro As New pRegistro
    Dim colEmpleado As New ArrayList
    Dim colHora As New ArrayList
    Dim colRegistro As New ArrayList
    Dim colHorario As New ArrayList

    'Empleado-------------------------------------------------------------------------------------------------------------------------------------------

    Public Function AgregarEmpleado(ByVal unaCI As Integer, ByVal unNombre As String, ByVal unApellido As String, ByVal unTipo_E As String, _
                                    ByVal unSistema As Boolean, ByVal unUsuario As String, ByVal unaContrasena As String) As Boolean
        Try
            Dim unEmpleado As Empleado
            unEmpleado = New Empleado(unaCI, unNombre, unApellido, unTipo_E, unSistema, unUsuario, unaContrasena)

            If pEmpleado.AgregarEmpleado(unEmpleado) = True Then
                colEmpleado.Add(unEmpleado)
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ModificarEmpleado(ByVal unaCI As Integer, ByVal unNombre As String, ByVal unApellido As String, _
                                     ByVal unTipo_E As String, ByVal unSistema As Boolean, ByVal unUsuario As String, ByVal unaContrasena As String) As Boolean
        Dim unEmpleado As New Empleado
        unEmpleado.CI = unaCI
        unEmpleado.Nombre = unNombre
        unEmpleado.Apellido = unApellido
        unEmpleado.Tipo_E = unTipo_E
        unEmpleado.Sistema = unSistema
        unEmpleado.Usuario = unUsuario
        unEmpleado.Contrasena = unaContrasena
        If pEmpleado.ModificarEmpleado(unEmpleado) = True Then
            Return True
        End If

    End Function

    Public Function BorrarEmpleado(ByVal unaCI As Integer) As Boolean
        If pEmpleado.EliminarEmpleado(unaCI) = True Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Function listadoEmpleado() As ArrayList
        colEmpleado = pEmpleado.MostrarEmpleado
        Return colEmpleado
    End Function

    'Registro-------------------------------------------------------------------------------------------------------------------------------------------

    Public Function AgregarRegistro(ByVal unaEntrada As Integer, ByVal unaSalida As Integer, ByVal unafecha As Date, _
                                ByVal unaObservacion As String, ByVal unHorario As Horario, ByVal unEmpleado As Empleado, _
                                ByVal unaHora As Hora) As Boolean
        Try
            Dim unRegistro As Registro
            unRegistro = New Registro(0, unaEntrada, unaSalida, unafecha, unaObservacion, unHorario, unEmpleado, unaHora)

            If pRegistro.AgregarRegistro(unRegistro) = True Then


            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

   

End Class

