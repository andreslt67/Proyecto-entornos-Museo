Imports Proyecto
''' <summary>
''' Clase del formulario formAnadir de la aplicación, importa la librería Museo
''' </summary>
Public Class formAnadir

    ''' <summary>
    ''' Método que actualiza el comboBox del formulario con los distintos materiales del Enum de escultura cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub formAnadir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To cbxMaterial.Items.Count
            cbxMaterial.Items.Clear()
        Next
        Me.cbxMaterial.Items.Add(Escultura.Materiales.arcilla)
        Me.cbxMaterial.Items.Add(Escultura.Materiales.marmol)
        Me.cbxMaterial.Items.Add(Escultura.Materiales.piedra)
    End Sub

    ''' <summary>
    ''' Método que crea un Objeto de la clase Pintura con los parametro introducidos en el formulario, lo añade al arraylist de catalogo e indica el resultado del proceso cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        If IsNumeric(txtId.Text) And IsNumeric(txtAltura.Text) And IsNumeric(txtAnchura.Text) Then
            Dim titulo As String = textTitulo.Text
            Dim id As Integer = txtId.Text
            Dim anno As String = txtAnno.Text
            Dim autor As String = txtAutor.Text
            Dim altura As Integer = txtAltura.Text
            Dim anchura As Integer = txtAnchura.Text
            Dim soporte As String = txtSoporte.Text
            Dim pinturaTipo As String = txtPintura.Text

            Dim pintura As Pintura = New Pintura(titulo, id, anno, autor, altura, anchura, soporte, pinturaTipo)
            If formPrincipal.catalogo.addObra(pintura) = False Then
                MsgBox("Obra añadida con éxito")
            Else
                MsgBox("La obra ya se encuentra en el Catálogo")
            End If
        Else
            MsgBox("El id, la altura y la anchura deben ser datos de carácter numérico")
        End If


    End Sub

    ''' <summary>
    ''' Método que crea un Objeto de la clase Escultura con los parametro introducidos en el formulario, lo añade al arraylist de catalogo e indica el resultado del proceso cuando se produce el evento
    ''' </summary>
    ''' <param name="sender">Objeto en el que se ha producido el evento</param>
    ''' <param name="e">Información adicional del objeto</param>
    Private Sub btnAnadirE_Click(sender As Object, e As EventArgs) Handles btnAnadirE.Click
        If IsNumeric(txtIdE.Text) And IsNumeric(txtAlturaE.Text) Then
            Dim titulo As String = txtTituloE.Text
            Dim id As Integer = txtIdE.Text
            Dim anno As String = txtAnnoE.Text
            Dim autor As String = txtAutorE.Text
            Dim altura As Integer = txtAlturaE.Text
            Dim material As Escultura.Materiales = cbxMaterial.SelectedItem

            Dim escultura As Escultura = New Escultura(titulo, id, anno, autor, altura, material)
            If formPrincipal.catalogo.addObra(escultura) = False Then
                MsgBox("Obra añadida con éxito")
            Else
                MsgBox("La obra ya se encuentra en el Catálogo")
            End If
        Else
            MsgBox("El id y la altura deben ser datos de carácter numérico")
        End If

    End Sub
End Class