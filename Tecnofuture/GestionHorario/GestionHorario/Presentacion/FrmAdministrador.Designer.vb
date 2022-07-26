<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministrador
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
        Me.btnVolverPrincipal = New System.Windows.Forms.Button
        Me.btnABMEmpleado = New System.Windows.Forms.Button
        Me.btnABMHorario = New System.Windows.Forms.Button
        Me.btnAgregarLicencia = New System.Windows.Forms.Button
        Me.btnAgregarObservacion = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnVolverPrincipal
        '
        Me.btnVolverPrincipal.Location = New System.Drawing.Point(34, 278)
        Me.btnVolverPrincipal.Name = "btnVolverPrincipal"
        Me.btnVolverPrincipal.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverPrincipal.TabIndex = 7
        Me.btnVolverPrincipal.Text = "Volver"
        Me.btnVolverPrincipal.UseVisualStyleBackColor = True
        '
        'btnABMEmpleado
        '
        Me.btnABMEmpleado.Location = New System.Drawing.Point(34, 29)
        Me.btnABMEmpleado.Name = "btnABMEmpleado"
        Me.btnABMEmpleado.Size = New System.Drawing.Size(134, 43)
        Me.btnABMEmpleado.TabIndex = 8
        Me.btnABMEmpleado.Text = "ABM Empleado"
        Me.btnABMEmpleado.UseVisualStyleBackColor = True
        '
        'btnABMHorario
        '
        Me.btnABMHorario.Location = New System.Drawing.Point(34, 91)
        Me.btnABMHorario.Name = "btnABMHorario"
        Me.btnABMHorario.Size = New System.Drawing.Size(134, 43)
        Me.btnABMHorario.TabIndex = 9
        Me.btnABMHorario.Text = "ABM Horario"
        Me.btnABMHorario.UseVisualStyleBackColor = True
        '
        'btnAgregarLicencia
        '
        Me.btnAgregarLicencia.Location = New System.Drawing.Point(344, 29)
        Me.btnAgregarLicencia.Name = "btnAgregarLicencia"
        Me.btnAgregarLicencia.Size = New System.Drawing.Size(127, 43)
        Me.btnAgregarLicencia.TabIndex = 10
        Me.btnAgregarLicencia.Text = "Agregar Licencia"
        Me.btnAgregarLicencia.UseVisualStyleBackColor = True
        '
        'btnAgregarObservacion
        '
        Me.btnAgregarObservacion.Location = New System.Drawing.Point(344, 91)
        Me.btnAgregarObservacion.Name = "btnAgregarObservacion"
        Me.btnAgregarObservacion.Size = New System.Drawing.Size(127, 43)
        Me.btnAgregarObservacion.TabIndex = 11
        Me.btnAgregarObservacion.Text = "Agregar Observación"
        Me.btnAgregarObservacion.UseVisualStyleBackColor = True
        '
        'FrmAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 313)
        Me.Controls.Add(Me.btnAgregarObservacion)
        Me.Controls.Add(Me.btnAgregarLicencia)
        Me.Controls.Add(Me.btnABMHorario)
        Me.Controls.Add(Me.btnABMEmpleado)
        Me.Controls.Add(Me.btnVolverPrincipal)
        Me.Name = "FrmAdministrador"
        Me.Text = "FrmAdministrador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverPrincipal As System.Windows.Forms.Button
    Friend WithEvents btnABMEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnABMHorario As System.Windows.Forms.Button
    Friend WithEvents btnAgregarLicencia As System.Windows.Forms.Button
    Friend WithEvents btnAgregarObservacion As System.Windows.Forms.Button
End Class
