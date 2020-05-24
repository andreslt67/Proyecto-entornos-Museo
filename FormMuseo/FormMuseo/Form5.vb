Imports Proyecto
''' <summary>
''' Clase del formulario formBuscar de la aplicación, importa la librería Museo
''' </summary>
Public Class formBuscar

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

    ''' <summary>
    ''' Método que muestra la obra seleccionada en el comboBox cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
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
            MsgBox(obra.toStringObra) ''Refactorización: creo solo una variable y dependiendo de los condicionales le asigno un resultado y la muestro al final del método
        End If
    End Sub
End Class