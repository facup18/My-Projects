Public Class FrmRegistro

    
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelIniciarJornada.Click

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelFinalizarJornada.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverPrincipal.Click
        Dim VolverPrincipal As New FrmPrincipal
        VolverPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click

    End Sub
End Class