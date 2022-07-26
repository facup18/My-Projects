<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistro
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
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.btnFinalizar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LabelIniciarJornada = New System.Windows.Forms.Label
        Me.LabelFinalizarJornada = New System.Windows.Forms.Label
        Me.btnVolverPrincipal = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(117, 191)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 0
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(356, 191)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizar.TabIndex = 1
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ingresar CI"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(210, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'LabelIniciarJornada
        '
        Me.LabelIniciarJornada.AutoSize = True
        Me.LabelIniciarJornada.Location = New System.Drawing.Point(98, 175)
        Me.LabelIniciarJornada.Name = "LabelIniciarJornada"
        Me.LabelIniciarJornada.Size = New System.Drawing.Size(114, 13)
        Me.LabelIniciarJornada.TabIndex = 4
        Me.LabelIniciarJornada.Text = "Iniciar Jornada Laboral"
        '
        'LabelFinalizarJornada
        '
        Me.LabelFinalizarJornada.AutoSize = True
        Me.LabelFinalizarJornada.Location = New System.Drawing.Point(336, 175)
        Me.LabelFinalizarJornada.Name = "LabelFinalizarJornada"
        Me.LabelFinalizarJornada.Size = New System.Drawing.Size(124, 13)
        Me.LabelFinalizarJornada.TabIndex = 5
        Me.LabelFinalizarJornada.Text = "Finalizar Jornada Laboral"
        '
        'btnVolverPrincipal
        '
        Me.btnVolverPrincipal.Location = New System.Drawing.Point(12, 261)
        Me.btnVolverPrincipal.Name = "btnVolverPrincipal"
        Me.btnVolverPrincipal.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverPrincipal.TabIndex = 6
        Me.btnVolverPrincipal.Text = "Volver"
        Me.btnVolverPrincipal.UseVisualStyleBackColor = True
        '
        'FrmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 296)
        Me.Controls.Add(Me.btnVolverPrincipal)
        Me.Controls.Add(Me.LabelFinalizarJornada)
        Me.Controls.Add(Me.LabelIniciarJornada)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "FrmRegistro"
        Me.Text = "FrmRegistro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LabelIniciarJornada As System.Windows.Forms.Label
    Friend WithEvents LabelFinalizarJornada As System.Windows.Forms.Label
    Friend WithEvents btnVolverPrincipal As System.Windows.Forms.Button
End Class
