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
        If id = -1 Then
            MsgBox("No has introducido ningún valor")
        Else
            Dim obra
            If formPrincipal.catalogo.buscarObra(id).GetType.Equals(New Pintura()) Then
                obra = formPrincipal.catalogo.buscarObra(id)
            ElseIf formPrincipal.catalogo.buscarObra(id).GetType.Equals(New Escultura()) Then
                obra = formPrincipal.catalogo.buscarObra(id)
            Else
                obra = formPrincipal.catalogo.buscarObra(id)
            End If
            MsgBox(obra.toStringObra)
        End If
    End Sub
End Class