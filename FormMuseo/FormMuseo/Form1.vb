Imports Proyecto
Public Class formPrincipal

    Public catalogo As Catalogo = New Catalogo()

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnMostrarLista_Click(sender As Object, e As EventArgs) Handles btnMostrarLista.Click
        formLista.ShowDialog()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        formAnadir.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        formEliminar.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        formBuscar.ShowDialog()
    End Sub
End Class
