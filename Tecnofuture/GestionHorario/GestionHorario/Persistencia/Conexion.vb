Imports MySql.Data.MySqlClient
Public Class Conexion
    Private MysqlCommand As New MySqlCommand
    Private conexion As MySqlConnection
    Public Sub AbrirConexion()
        Try
            Dim MysqlConnString As String = "server=localhost;user id=root;password=root;database=tecnofuture;port=3306; Convert Zero Datetime=True"

            conexion = New MySqlConnection(MysqlConnString)
            conexion.Open()

        Catch ex As MySqlException
            Throw New Exception("No es posible establecer la conexión.", ex)
        End Try
    End Sub

    Public Sub CerrarConexion()
        Me.Conexion.Close()
    End Sub


    Public Function TraerDatos(ByVal CadenaConsulta As String) As DataTable
        Try
            Dim sql As MySqlCommand = New MySqlCommand
            sql.CommandTimeout = 300
            sql.Connection = conexion
            sql.CommandText = CadenaConsulta
            sql.CommandType = CommandType.Text
            Dim DA As New MySqlDataAdapter(sql)
            Dim DT As New DataTable
            DA.Fill(DT)
            Return DT
        Catch ex As MySqlException
            Throw New Exception("No es posible obtener datos.", ex)
        End Try
        Return Nothing
    End Function

    Public Function EjecutarSQL(ByVal sentencias As String) As Boolean
        Dim result As Boolean = False
        Dim myCommand As MySqlCommand = Conexion.CreateCommand()
        Dim myTrans As MySqlTransaction
        myTrans = conexion.BeginTransaction()
        myCommand.Connection = conexion
        myCommand.Transaction = myTrans

        Try

            myCommand.CommandText = sentencias
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            result = True
        Catch ex As MySqlException
            myTrans.Rollback()
            result = False
            Throw New Exception("No es posible realizar esta operación. Corrobore los datos.", ex)
        End Try
        Return result
    End Function

End Class

