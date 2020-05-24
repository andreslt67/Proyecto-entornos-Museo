Imports Proyecto
''' <summary>
''' Clase del formulario principal instancia un objeto de la clase Catalogo que se usará para toda la aplicación, importa la librería Museo
''' </summary>
Public Class formPrincipal

    Public catalogo As Catalogo = New Catalogo()

    ''' <summary>
    ''' Método que cierra el formulario cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Método que muestra el formulario formLista de forma modal cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnMostrarLista_Click(sender As Object, e As EventArgs) Handles btnMostrarLista.Click
        formLista.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que muestra el formulario formAnadir de forma modal cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        formAnadir.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que muestra el formulario formEliminar de forma modal cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        formEliminar.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que muestra el formulario formBuscar de forma modal cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        formBuscar.ShowDialog()
    End Sub

    ''' <summary>
    ''' Método que muestra un MsgBox con el resultado de llamar al método superficie() de Catalogo cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnSuperficie_Click(sender As Object, e As EventArgs) Handles btnSuperficie.Click
        Dim info As String = "La superficie total si unieramos todas las pinturas del museo sería igual a " & catalogo.superficiePinturas & " cm2."
        MsgBox(info)
    End Sub

    ''' <summary>
    ''' Método que muestra un MsgBox con el resultado de llamar al método esculturaMasAlta() de Catalogo cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnMasAlta_Click(sender As Object, e As EventArgs) Handles btnMasAlta.Click
        Dim info As String = "La escultura más alta del museo es " & catalogo.esculturaMasAlta.toStringObra
        MsgBox(info)
    End Sub
End Class
