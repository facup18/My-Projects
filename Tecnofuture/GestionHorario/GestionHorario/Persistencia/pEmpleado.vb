Public Class pEmpleado
    Private unaconexion As New Conexion

    Public Function AgregarEmpleado(ByVal pEmp As Empleado) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "insert into empleado (CI, Nombre, Apellido, Tipo_E, Sistema, Usuario, Contrasena) values(" & pEmp.CI & ", '" & pEmp.Nombre & "', '" & pEmp.Apellido & "', '" & pEmp.Tipo_E & "', " & pEmp.Sistema & ", '" & pEmp.Usuario & "', '" & pEmp.Contrasena & "');"
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
    Public Function EliminarEmpleado(ByVal unCI As Integer) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "DELETE FROM empleado WHERE CI=" & unCI
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
    Public Function ModificarEmpleado(ByVal pEmp As Empleado) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "UPDATE empleado SET Nombre='" & pEmp.Nombre & "', Apellido='" & pEmp.Apellido & "', Tipo_E='" & pEmp.Tipo_E & "', Sistema=" & pEmp.Sistema & ", Usuario='" & pEmp.Usuario & "', Contrasena='" & pEmp.Contrasena & "' WHERE CI=" & pEmp.CI & ";"
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

    Public Function MostrarEmpleado() As ArrayList
        Dim dt As DataTable = Nothing
        Dim strSelect As String
        Dim unEmpleado As Empleado
        Dim colEmpleado As New ArrayList
        strSelect = "select * from empleado;"

        Try
            unaconexion.AbrirConexion()
            dt = unaconexion.TraerDatos(strSelect)

            For i As Integer = 0 To dt.Rows.Count - 1
                unEmpleado = New Empleado
                unEmpleado.CI = CInt(dt(i).Item("CI"))
                unEmpleado.Nombre = dt(i).Item("Nombre").ToString
                unEmpleado.Apellido = dt(i).Item("Apellido").ToString
                unEmpleado.Tipo_E = dt(i).Item("Tipo_E").ToString
                unEmpleado.Sistema = dt(i).Item("Sistema").ToString
                unEmpleado.Usuario = dt(i).Item("Usuario").ToString
                unEmpleado.Contrasena = dt(i).Item("Contrasena").ToString

                colEmpleado.Add(unEmpleado)
            Next
            Return colEmpleado
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try

    End Function




End Class
