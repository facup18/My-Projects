<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbAgregar = New System.Windows.Forms.RadioButton
        Me.rbModificar = New System.Windows.Forms.RadioButton
        Me.rbBorrar = New System.Windows.Forms.RadioButton
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnVolver = New System.Windows.Forms.Button
        Me.txtCI = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtContrasena = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ckbSistema = New System.Windows.Forms.CheckBox
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstEmp = New System.Windows.Forms.ListView
        Me.CI = New System.Windows.Forms.ColumnHeader
        Me.Nombre = New System.Windows.Forms.ColumnHeader
        Me.Apellido = New System.Windows.Forms.ColumnHeader
        Me.Tipo_E = New System.Windows.Forms.ColumnHeader
        Me.Sistema = New System.Windows.Forms.ColumnHeader
        Me.Usuario = New System.Windows.Forms.ColumnHeader
        Me.Contraseña = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'rbAgregar
        '
        Me.rbAgregar.AutoSize = True
        Me.rbAgregar.Checked = True
        Me.rbAgregar.Location = New System.Drawing.Point(91, 33)
        Me.rbAgregar.Name = "rbAgregar"
        Me.rbAgregar.Size = New System.Drawing.Size(62, 17)
        Me.rbAgregar.TabIndex = 0
        Me.rbAgregar.TabStop = True
        Me.rbAgregar.Text = "Agregar"
        Me.rbAgregar.UseVisualStyleBackColor = True
        '
        'rbModificar
        '
        Me.rbModificar.AutoSize = True
        Me.rbModificar.Location = New System.Drawing.Point(339, 33)
        Me.rbModificar.Name = "rbModificar"
        Me.rbModificar.Size = New System.Drawing.Size(68, 17)
        Me.rbModificar.TabIndex = 1
        Me.rbModificar.TabStop = True
        Me.rbModificar.Text = "Modificar"
        Me.rbModificar.UseVisualStyleBackColor = True
        '
        'rbBorrar
        '
        Me.rbBorrar.AutoSize = True
        Me.rbBorrar.Location = New System.Drawing.Point(588, 33)
        Me.rbBorrar.Name = "rbBorrar"
        Me.rbBorrar.Size = New System.Drawing.Size(53, 17)
        Me.rbBorrar.TabIndex = 2
        Me.rbBorrar.TabStop = True
        Me.rbBorrar.Text = "Borrar"
        Me.rbBorrar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(650, 376)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 376)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(63, 72)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(123, 20)
        Me.txtCI.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(313, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(117, 20)
        Me.txtNombre.TabIndex = 7
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(557, 72)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(117, 20)
        Me.txtApellido.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(313, 122)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(117, 20)
        Me.txtUsuario.TabIndex = 10
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(557, 122)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(117, 20)
        Me.txtContrasena.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(504, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Apellido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(261, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(487, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Contraseña:"
        '
        'ckbSistema
        '
        Me.ckbSistema.AutoSize = True
        Me.ckbSistema.Location = New System.Drawing.Point(329, 165)
        Me.ckbSistema.Name = "ckbSistema"
        Me.ckbSistema.Size = New System.Drawing.Size(63, 17)
        Me.ckbSistema.TabIndex = 19
        Me.ckbSistema.Text = "Sistema"
        Me.ckbSistema.UseVisualStyleBackColor = True
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Mensual", "Jornalero", "Identificado", "Administrador"})
        Me.cbTipo.Location = New System.Drawing.Point(63, 121)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(123, 21)
        Me.cbTipo.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Tipo:"
        '
        'lstEmp
        '
        Me.lstEmp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CI, Me.Nombre, Me.Apellido, Me.Tipo_E, Me.Sistema, Me.Usuario, Me.Contraseña})
        Me.lstEmp.FullRowSelect = True
        Me.lstEmp.GridLines = True
        Me.lstEmp.Location = New System.Drawing.Point(40, 211)
        Me.lstEmp.MultiSelect = False
        Me.lstEmp.Name = "lstEmp"
        Me.lstEmp.Size = New System.Drawing.Size(674, 97)
        Me.lstEmp.TabIndex = 22
        Me.lstEmp.UseCompatibleStateImageBehavior = False
        Me.lstEmp.View = System.Windows.Forms.View.Details
        '
        'CI
        '
        Me.CI.Text = "CI"
        Me.CI.Width = 41
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 101
        '
        'Apellido
        '
        Me.Apellido.Text = "Apellido"
        Me.Apellido.Width = 127
        '
        'Tipo_E
        '
        Me.Tipo_E.Text = "Tipo"
        Me.Tipo_E.Width = 102
        '
        'Sistema
        '
        Me.Sistema.Text = "Sistema"
        Me.Sistema.Width = 98
        '
        'Usuario
        '
        Me.Usuario.Text = "Usuario"
        Me.Usuario.Width = 108
        '
        'Contraseña
        '
        Me.Contraseña.Text = "Contraseña"
        Me.Contraseña.Width = 85
        '
        'FrmABMEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 411)
        Me.Controls.Add(Me.lstEmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.ckbSistema)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.rbBorrar)
        Me.Controls.Add(Me.rbModificar)
        Me.Controls.Add(Me.rbAgregar)
        Me.Name = "FrmABMEmpleado"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbAgregar As System.Windows.Forms.RadioButton
    Friend WithEvents rbModificar As System.Windows.Forms.RadioButton
    Friend WithEvents rbBorrar As System.Windows.Forms.RadioButton
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckbSistema As System.Windows.Forms.CheckBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstEmp As System.Windows.Forms.ListView
    Friend WithEvents CI As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents Apellido As System.Windows.Forms.ColumnHeader
    Friend WithEvents Tipo_E As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sistema As System.Windows.Forms.ColumnHeader
    Friend WithEvents Usuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents Contraseña As System.Windows.Forms.ColumnHeader
End Class
