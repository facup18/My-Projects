Public Class pHora
    Private unaconexion As New Conexion

    Public Function AgregarHora(ByVal pHora As Hora) As Boolean
        Dim strInsert As String = ""
        Try
            strInsert = "insert into hora (Id, Tipo_H) values('" & pHora.id & "', '" & pHora.Tipo_H & "');"
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

    Public Function EliminarHora(ByVal unid As Integer) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "DELETE FROM hora WHERE ID=" & unid
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
