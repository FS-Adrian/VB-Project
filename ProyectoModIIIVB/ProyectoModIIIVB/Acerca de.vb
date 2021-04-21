Public Class Acerca


    Private Sub Regresar_Click(sender As System.Object, e As System.EventArgs) Handles Regresar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Salir_Click(sender As System.Object, e As System.EventArgs) Handles Salir.Click
        Me.Close()
        Form1.Close()
    End Sub
End Class