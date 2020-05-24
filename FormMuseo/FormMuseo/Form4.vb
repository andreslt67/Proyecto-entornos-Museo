Imports Proyecto
''' <summary>
''' Clase del formulario formEliminar de la aplicación, importa la librería Museo
''' </summary>
Public Class formEliminar


    ''' <summary>
    ''' Método que elimina la obra seleccionada del comboBox, lo actualiza e indica el resultado del proceso cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer = cbxObra.SelectedIndex
        If id = -1 Then
            MsgBox("No has introducido ningún valor")
        Else
            If formPrincipal.catalogo.eliminarObra(id) = True Then
                MsgBox("Obra eliminada con éxito")
            Else
                MsgBox("No se ha encontrado la obra")
            End If
        End If
        For i As Integer = 1 To cbxObra.Items.Count
            cbxObra.Items.Clear()
        Next
        For Each elemento As ObraArtistica In formPrincipal.catalogo.getObras
            Me.cbxObra.Items.Add(elemento.toStringObra)
        Next
    End Sub

    ''' <summary>
    ''' Método que actualiza el comboBox del formulario cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub cbxObra_Click(sender As Object, e As EventArgs) Handles cbxObra.Click
        For i As Integer = 1 To cbxObra.Items.Count
            cbxObra.Items.Clear()
        Next
        For Each elemento As ObraArtistica In formPrincipal.catalogo.getObras
            Me.cbxObra.Items.Add(elemento.toStringObra)
        Next
    End Sub
End Class