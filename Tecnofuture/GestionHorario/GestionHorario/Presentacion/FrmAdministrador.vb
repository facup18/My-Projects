Public Class FrmAdministrador

    Private Sub btnVolverPrincipal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverPrincipal.Click
        Dim VolverPrincipal As New FrmPrincipal
        VolverPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnABMEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnABMEmpleado.Click
        FrmABMEmpleado.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarLicencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLicencia.Click
        frmLicencia.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarObservacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarObservacion.Click
        FrmObservaciones.Show()
        Me.Hide()
    End Sub

    Private Sub FrmAdministrador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnABMHorario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnABMHorario.Click
        FrmHorario.Show()
        Me.Hide()
    End Sub
End Class