Imports Proyecto
Public Class formBuscar

    Private Sub cbxObra_Click(sender As Object, e As EventArgs) Handles cbxObra.Click
        For i As Integer = 1 To cbxObra.Items.Count
            cbxObra.Items.Clear()
        Next
        For Each elemento As ObraArtistica In formPrincipal.catalogo.getObras
            Me.cbxObra.Items.Add(elemento.toStringObra)
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim id As Integer = cbxObra.SelectedIndex
        Dim obra As ObraArtistica = formPrincipal.catalogo.buscarObra(id)
        MsgBox(obra.toStringObra)
    End Sub
End Class