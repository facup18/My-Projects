Public Class FrmPrincipal
    Private unaconexion As New Conexion
    Private cont As New Controladora

    Private Sub btnRegistro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistro.Click
        Dim VentanaRegistro As New FrmRegistro
        VentanaRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdministradorClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdministrador.Click

        Dim tipoVerificar As Boolean
        Dim unEmpleado As Empleado
        Dim colEmp As ArrayList
        colEmp = cont.listadoEmpleado
        Try

            For Each unEmpleado In colEmp


                If unEmpleado.Usuario = Nothing Or unEmpleado.Contrasena = Nothing Then

                ElseIf unEmpleado.Usuario = Me.txtUsuario.Text And unEmpleado.Contrasena = Me.txtContrasena.Text And unEmpleado.Tipo_E = "Administrador" Then
                    Dim FrmAdministrador As New FrmAdministrador
                    FrmAdministrador.Show()
                    Me.Hide()
                    tipoVerificar = True
                ElseIf unEmpleado.Usuario = Me.txtUsuario.Text And unEmpleado.Contrasena = Me.txtContrasena.Text And unEmpleado.Tipo_E = "Identificado" Then
                    MessageBox.Show("Usted es un Empleado Identificado , no puede ingresar como Aministrador", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tipoVerificar = True
                End If

            Next

            If Me.txtUsuario.Text = Nothing And Me.txtContrasena.Text = Nothing Then
                MessageBox.Show("Ingrese Usuario y Contraseña", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf Me.txtUsuario.Text = Nothing Then
                MessageBox.Show("Ingrese Usuario", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.txtContrasena.Text = Nothing Then
                MessageBox.Show("Ingrese Contraseña", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tipoVerificar = False Then
                MessageBox.Show("No hay ningún empleado con ese usuario y contraseña", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            

        Catch ex As Exception
            Throw ex
        End Try


    End Sub


    Private Sub btnIdentificado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIdentificado.Click
        Dim tipoVerificar As Boolean
        Dim unEmpleado As Empleado
        Dim colEmp As ArrayList
        colEmp = cont.listadoEmpleado
        Try

            For Each unEmpleado In colEmp


                If unEmpleado.Usuario = Nothing Or unEmpleado.Contrasena = Nothing Then

                ElseIf unEmpleado.Usuario = Me.txtUsuario.Text And unEmpleado.Contrasena = Me.txtContrasena.Text And unEmpleado.Tipo_E = "Identificado" Then
                    Dim FrmAdministrador As New FrmAdministrador
                    FrmAdministrador.Show()
                    Me.Hide()
                    tipoVerificar = True
                ElseIf unEmpleado.Usuario = Me.txtUsuario.Text And unEmpleado.Contrasena = Me.txtContrasena.Text And unEmpleado.Tipo_E = "Administrador" Then
                    MessageBox.Show("Usted es un Empleado Administrador , no puede ingresar como Identificado", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tipoVerificar = True
                End If

            Next

            If Me.txtUsuario.Text = Nothing And Me.txtContrasena.Text = Nothing Then
                MessageBox.Show("Ingrese Usuario y Contraseña", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.txtUsuario.Text = Nothing Then
                MessageBox.Show("Ingrese Usuario", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.txtContrasena.Text = Nothing Then
                MessageBox.Show("Ingrese Contraseña", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf tipoVerificar = False Then
                MessageBox.Show("No hay ningún empleado con ese usuario y contraseña", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            Throw ex
        End Try



    End Sub

    Private Sub rbIdentificado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIdentificado.CheckedChanged
        btnAdministrador.Visible = False
        btnIdentificado.Visible = True

    End Sub

    Private Sub rbAdministrador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAdministrador.CheckedChanged
        btnAdministrador.Visible = True
        btnIdentificado.Visible = False
    End Sub


    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
End Class