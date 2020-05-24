Imports Proyecto
''' <summary>
''' Clase del formulario formLista de la aplicación, importa la librería Museo
''' </summary>
Public Class formLista

    ''' <summary>
    ''' Método que cierra el formulario cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Método que primero vacía la lista y después las rellena con los elementos del Objeto catálogo del museo al producirse el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub formLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To listBox.Items.Count
            listBox.Items.Clear()
        Next
        For i As Integer = 0 To formPrincipal.catalogo.getNumObras - 1
            listBox.Items.Add(formPrincipal.catalogo.getObras(i).toStringObra)
        Next
    End Sub
End Class