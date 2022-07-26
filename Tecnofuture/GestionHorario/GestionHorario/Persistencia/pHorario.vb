Public Class pHorario
    Private unaconexion As New Conexion

    Public Function AgregarHorario(ByVal pHorario As Horario) As Boolean
        Dim strInsert As String = ""
        Try
            strInsert = "insert into horario (Id, Entrada, Salida) values(" & pHorario.Id & ", " & pHorario.Entrada & ", " & pHorario.Salida & ");"
            unaconexion.AbrirConexion()
            unaconexion.EjecutarSQL(strInsert)

            Return True
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
        Return False
    End Function

    Public Function EliminarHorario(ByVal unId As Integer) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "DELETE FROM horario WHERE Id=" & unId
            unaconexion.AbrirConexion()
            unaconexion.EjecutarSQL(strInsert)

            Return True
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
        Return False
    End Function
End Class
