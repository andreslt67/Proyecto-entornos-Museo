Imports Proyecto
Public Class formEliminar



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer = cbxObra.SelectedIndex
        If formPrincipal.catalogo.eliminarObra(id) = True Then
            MsgBox("Obra eliminada con exito")
        Else
            MsgBox("No se ha encontrado la obra")
        End If
    End Sub

    Private Sub cbxObra_Click(sender As Object, e As EventArgs) Handles cbxObra.Click
        For i As Integer = 1 To cbxObra.Items.Count
            cbxObra.Items.Clear()
        Next
        For Each elemento As ObraArtistica In formPrincipal.catalogo.getObras
            Me.cbxObra.Items.Add(elemento.toStringObra)
        Next
    End Sub
End Class