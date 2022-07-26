Public Class FrmABMEmpleado
    Private cont As New Controladora
    Dim unaCI As Integer

    Public Sub listarEmpleado()
        Me.lstEmp.Items.Clear()
        Dim lista As New ListViewItem
        Dim unEmpleado As Empleado
        Dim colEmpleado As ArrayList = cont.listadoEmpleado
        For Each unEmpleado In colEmpleado

            lista = New ListViewItem(unEmpleado.CI)
            lista.SubItems.Add(unEmpleado.Nombre)
            lista.SubItems.Add(unEmpleado.Apellido)
            lista.SubItems.Add(unEmpleado.Tipo_E)
            lista.SubItems.Add(unEmpleado.Sistema)
            lista.SubItems.Add(unEmpleado.Usuario)
            lista.SubItems.Add(unEmpleado.Contrasena)
            Me.lstEmp.Items.Add(lista)

        Next

    End Sub

    Public Sub limpiar_txt()
        Me.txtCI.Clear()
        Me.txtNombre.Clear()
        Me.txtApellido.Clear()
        Me.ckbSistema.Checked = False
        Me.cbTipo.SelectedItem = False
        Me.txtUsuario.Clear()
        Me.txtContrasena.Clear()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        'Agregar empleado
        If rbAgregar.Checked = True Then
            If txtCI.Text = Nothing Then
                MessageBox.Show("Debe ingresar el CI del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtNombre.Text = Nothing Then
                MessageBox.Show("Debe ingresar el nombre del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf txtApellido.Text = Nothing Then
                MessageBox.Show("Debe ingresar el apellido del Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cbTipo.SelectedItem = Nothing Then
                MessageBox.Show("Debe seleccionar un tipo de Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else


               

                Dim confirm As Boolean = cont.AgregarEmpleado(Me.txtCI.Text, Me.txtNombre.Text, Me.txtApellido.Text, _
                                                                Me.cbTipo.SelectedItem, Me.ckbSistema.Checked, Me.txtUsuario.Text, Me.txtContrasena.Text)

                If confirm = True Then
                    limpiar_txt()
                    listarEmpleado()
                Else
                    MessageBox.Show("Hubo un error en el ingreso del Empleado. Intentelo de nuevo", "Verifique los datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            'Modificar empleado
        ElseIf rbModificar.Checked = True Then
            If lstEmp.SelectedItems.Count = 0 Then
                MessageBox.Show("No hay ningún Empleado seleccionado, seleccione uno antes de presionar modificar", "Error", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim confirm As Boolean
                confirm = cont.ModificarEmpleado(Me.txtCI.Text, Me.txtNombre.Text, Me.txtApellido.Text, Me.cbTipo.SelectedItem, Me.ckbSistema.Checked, Me.txtUsuario.Text, Me.txtContrasena.Text)
                If confirm = True Then
                    listarEmpleado()
                    MsgBox("El Empleado se modificó correctamente")

                Else
                    MessageBox.Show("Hubo un error al modificar, verifique los datos", "Error", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                listarEmpleado()
                limpiar_txt()
            End If

            'Eliminar empleado
        Else
            If Me.txtCI.Text = "" Then
                MessageBox.Show("No hay ningún Empleado seleccionado. Seleccione uno y presione Borrar", "Error", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim result As DialogResult = MessageBox.Show("Seguro que desea eliminar el Empleado seleccionado?", _
                                       "Confirmación de eliminación", _
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Information)

                If result = Windows.Forms.DialogResult.Yes Then
                    Dim confirm As Boolean
                    confirm = cont.BorrarEmpleado(Me.txtCI.Text)
                    If confirm = True Then
                        listarEmpleado()
                        limpiar_txt()
                        MsgBox("El Empleado se eliminó correctamente")

                    Else
                        MessageBox.Show("El Empleado no se pudo eliminar, corrobore los datos", "Error", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                End If
            End If
        End If

        
    End Sub

    Private Sub FrmABMEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listarEmpleado()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmp.SelectedIndexChanged
        If lstEmp.SelectedItems.Count > 0 Then
            unaCI = lstEmp.SelectedItems(0).Text
            Me.txtCI.Text = lstEmp.SelectedItems(0).SubItems(0).Text
            Me.txtNombre.Text = lstEmp.SelectedItems(0).SubItems(1).Text
            Me.txtApellido.Text = lstEmp.SelectedItems(0).SubItems(2).Text
            Me.cbTipo.SelectedItem = lstEmp.SelectedItems(0).SubItems(3).Text
            Me.ckbSistema.Checked = lstEmp.SelectedItems(0).SubItems(4).Text
            Me.txtUsuario.Text = lstEmp.SelectedItems(0).SubItems(5).Text
            Me.txtContrasena.Text = lstEmp.SelectedItems(0).SubItems(6).Text

        End If
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipo.SelectedIndexChanged
        If cbTipo.SelectedItem = "Mensual" Or cbTipo.SelectedItem = "Jornalero" Or cbTipo.SelectedItem = "Administrador" Then
            ckbSistema.Checked = True
            ckbSistema.Enabled = False
        Else
            ckbSistema.Checked = False
            ckbSistema.Enabled = True
        End If

        If cbTipo.SelectedItem = "Administrador" Or cbTipo.SelectedItem = "Identificado" Then
            txtUsuario.Enabled = True
            txtContrasena.Enabled = True

        Else
            txtUsuario.Enabled = False
            txtContrasena.Enabled = False
            txtUsuario.Text = ""
            txtContrasena.Text = ""
        End If
    End Sub

    Private Sub rbAgregar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAgregar.CheckedChanged
        Me.lstEmp.Enabled = False
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        Me.Label4.Visible = True
        Me.Label5.Visible = True
        Me.Label6.Visible = True
        Me.txtNombre.Visible = True
        Me.txtApellido.Visible = True
        Me.txtUsuario.Visible = True
        Me.txtContrasena.Visible = True
        Me.ckbSistema.Visible = True
        Me.cbTipo.Visible = True
        limpiar_txt()
    End Sub

    Private Sub rbModificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbModificar.CheckedChanged
        Me.lstEmp.Enabled = True
        Me.Label2.Visible = True
        Me.Label3.Visible = True
        Me.Label4.Visible = True
        Me.Label5.Visible = True
        Me.Label6.Visible = True
        Me.txtNombre.Visible = True
        Me.txtApellido.Visible = True
        Me.txtUsuario.Visible = True
        Me.txtContrasena.Visible = True
        Me.ckbSistema.Visible = True
        Me.cbTipo.Visible = True
        limpiar_txt()
    End Sub

    Private Sub rbBorrar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBorrar.CheckedChanged
        Me.lstEmp.Enabled = True
        Me.Label2.Visible = False
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.Label5.Visible = False
        Me.Label6.Visible = False
        Me.txtNombre.Visible = False
        Me.txtApellido.Visible = False
        Me.txtUsuario.Visible = False
        Me.txtContrasena.Visible = False
        Me.ckbSistema.Visible = False
        Me.cbTipo.Visible = False
        limpiar_txt()

    End Sub

    Private Sub lstEmp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmp.SelectedIndexChanged
        If lstEmp.SelectedItems.Count > 0 Then
            unaCI = lstEmp.SelectedItems(0).Text
            Me.txtNombre.Text = lstEmp.SelectedItems(0).SubItems(1).Text
            Me.txtApellido.Text = lstEmp.SelectedItems(0).SubItems(2).Text
            Me.cbTipo.SelectedItem = lstEmp.SelectedItems(0).SubItems(3).Text
            Me.ckbSistema.Checked = lstEmp.SelectedItems(0).SubItems(4).Text
            Me.txtUsuario.Text = lstEmp.SelectedItems(0).SubItems(5).Text
            Me.txtContrasena.Text = lstEmp.SelectedItems(0).SubItems(6).Text
        End If
    End Sub



    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        FrmAdministrador.Show()
        Me.Hide()
    End Sub
End Class