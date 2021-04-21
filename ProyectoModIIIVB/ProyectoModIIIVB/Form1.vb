Public Class Form1

    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub Informacion_Click(sender As System.Object, e As System.EventArgs) Handles Informacion.Click
        Acerca.Show()
    End Sub

    Private Sub Encuesta_Click(sender As System.Object, e As System.EventArgs) Handles Encuesta.Click
        Encuesta1.Show()
    End Sub

    Private Sub Agendar_Click(sender As System.Object, e As System.EventArgs) Handles Agendar.Click
        Agendar1.Show()
    End Sub

    Private Sub Bitacora_Click(sender As System.Object, e As System.EventArgs) Handles Bitacora.Click
        Bitacora1.Show()
    End Sub
End Class
