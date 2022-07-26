<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.btnRegistro = New System.Windows.Forms.Button
        Me.rbIdentificado = New System.Windows.Forms.RadioButton
        Me.rbAdministrador = New System.Windows.Forms.RadioButton
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtContrasena = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnIdentificado = New System.Windows.Forms.Button
        Me.btnAdministrador = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnRegistro
        '
        Me.btnRegistro.Location = New System.Drawing.Point(212, 47)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(134, 43)
        Me.btnRegistro.TabIndex = 0
        Me.btnRegistro.Text = "Ingreso / Salida"
        Me.btnRegistro.UseVisualStyleBackColor = True
        '
        'rbIdentificado
        '
        Me.rbIdentificado.AutoSize = True
        Me.rbIdentificado.Checked = True
        Me.rbIdentificado.Location = New System.Drawing.Point(89, 121)
        Me.rbIdentificado.Name = "rbIdentificado"
        Me.rbIdentificado.Size = New System.Drawing.Size(130, 17)
        Me.rbIdentificado.TabIndex = 2
        Me.rbIdentificado.TabStop = True
        Me.rbIdentificado.Text = "Empleado Identificado"
        Me.rbIdentificado.UseVisualStyleBackColor = True
        '
        'rbAdministrador
        '
        Me.rbAdministrador.AutoSize = True
        Me.rbAdministrador.Location = New System.Drawing.Point(348, 121)
        Me.rbAdministrador.Name = "rbAdministrador"
        Me.rbAdministrador.Size = New System.Drawing.Size(138, 17)
        Me.rbAdministrador.TabIndex = 3
        Me.rbAdministrador.TabStop = True
        Me.rbAdministrador.Text = "Empleado Administrador"
        Me.rbAdministrador.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(119, 181)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 4
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(348, 181)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(278, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña:"
        '
        'btnIdentificado
        '
        Me.btnIdentificado.Location = New System.Drawing.Point(458, 258)
        Me.btnIdentificado.Name = "btnIdentificado"
        Me.btnIdentificado.Size = New System.Drawing.Size(82, 40)
        Me.btnIdentificado.TabIndex = 10
        Me.btnIdentificado.Text = "Entrar Identificado"
        Me.btnIdentificado.UseVisualStyleBackColor = True
        '
        'btnAdministrador
        '
        Me.btnAdministrador.Location = New System.Drawing.Point(458, 258)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(82, 40)
        Me.btnAdministrador.TabIndex = 11
        Me.btnAdministrador.Text = "Entrar Administrador"
        Me.btnAdministrador.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 310)
        Me.Controls.Add(Me.btnAdministrador)
        Me.Controls.Add(Me.btnIdentificado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.rbAdministrador)
        Me.Controls.Add(Me.rbIdentificado)
        Me.Controls.Add(Me.btnRegistro)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRegistro As System.Windows.Forms.Button
    Friend WithEvents rbIdentificado As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdministrador As System.Windows.Forms.RadioButton
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContrasena As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnIdentificado As System.Windows.Forms.Button
    Friend WithEvents btnAdministrador As System.Windows.Forms.Button
End Class
