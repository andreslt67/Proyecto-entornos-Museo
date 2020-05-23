Imports Proyecto
Public Class formLista


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    Private Sub formLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each elemento As ObraArtistica In formPrincipal.catalogo.getObras
            listBox.Items.Add(elemento.toStringObra)
        Next
    End Sub
End Class