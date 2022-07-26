Public Class pRegistro
    Private unaconexion As New Conexion

    Public Function AgregarRegistro(ByVal pRegistro As Registro) As Boolean
        Dim strInsert As String = ""
        Try
            Dim fechaSQL As String = pRegistro.Fecha.ToString("yyyy-MM-dd")
            strInsert = "insert into registro (H_Entrada, H_Salida, Fecha, Observaciones, Id_Horario, CI_Empleado, Id_Hora) values(" & pRegistro.H_Entrada & ", " & pRegistro.H_Salida & ", '" & fechaSQL & "', " & pRegistro.Observaciones & ", " & pRegistro.Horario.id & ", " & pRegistro.Empleado.CI & ", " & pRegistro.Hora.Id & ");"
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

    Public Function MostrarRegistro() As ArrayList
        Dim dt As DataTable = Nothing
        Dim strSelect As String
        Dim unregistro As Registro
        Dim colregistro As New ArrayList
        strSelect = "select a.*, b.nombre, b.apellido, c.producto from registro a inner join empleado b on a.id_empleado=b.id left join hora c on a.id_hora=c.id;"
        Try
            unaconexion.AbrirConexion()
            dt = unaconexion.TraerDatos(strSelect)

            For i As Integer = 0 To dt.Rows.Count - 1
                unregistro = New Registro
                unregistro.Empleado = New Empleado
                unregistro.Hora = New Hora
                unregistro.id = CInt(dt(i).Item("ID").ToString)
                unregistro.H_Entrada = dt(i).Item("Hora Entrada").ToString
                unregistro.H_Salida = dt(i).Item("Hora Salida").ToString
                unregistro.Fecha = dt(i).Item("Fecha").ToString
                unregistro.Observaciones = dt(i).Item("Observaciones").ToString
                unregistro.Empleado.Nombre = dt(i).Item("Nombre").ToString
                unregistro.Empleado.Apellido = dt(i).Item("Apellido").ToString
                unregistro.Hora.Tipo_H = dt(i).Item("Tipo de Hora").ToString



                colregistro.Add(unregistro)
            Next
            Return colregistro
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try

    End Function

    Public Function ModificarRegistro(ByVal pRegistro As Registro) As Boolean
        Dim strInsert As String = ""
        Try
            Dim fechaSQL As String = pRegistro.Fecha.ToString("yyyy-MM-dd")
            strInsert = "UPDATE registro SET H_Entrada='" & pRegistro.H_Entrada & "', H_Salida='" & pRegistro.H_Salida & "', Fecha=" & fechaSQL & ", Observaciones='" & pRegistro.Observaciones & "', Id_Horario='" & pRegistro.Horario.id & "', CI_Empleado=" & pRegistro.Empleado.CI & "', Id_Hora=" & pRegistro.Hora.Id & " WHERE ID=" & pRegistro.id & ";"
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
