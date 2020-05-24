''' <summary>
''' Clase de servicio de la libreria, contiene un arraylist con distintos objetos de la clase ObraArtistica como de las clases hijas
''' </summary>
Public Class Catalogo

    Private _obras As ArrayList = New ArrayList() ''Refactorización: encapsulo las propiedades
    Dim o1 As Pintura = New Pintura("La noche estrellada", 1, "1889 DC", "Vincent Van Gogh", 12, 6, "caballete", "oleo")
    Dim o2 As Escultura = New Escultura("Discóbolo", 2, "455 AC", "Mirón de Eléuteras", 230, Escultura.Materiales.piedra)

    ''' <summary>
    ''' Método constructor de la clase añade dos obras instanciadas anterior mente al arraylist de la clase
    ''' </summary>
    Sub New()
        _obras.Add(o1)
        _obras.Add(o2)
    End Sub

    ''' <summary>
    ''' Método que añade una obra al arraylist de la clase
    ''' </summary>
    ''' <param name="obra">Objeto de la clase ObraArtistica o de alguna de sus clases hijas</param>
    ''' <returns>Devuelve True o False si se ha completado la acción o no</returns>
    Public Function addObra(obra As ObraArtistica) ''Refactorización(MVC): devuelve un boolean para poder usarlo en futuras funciones
        Dim repetida As Boolean = False
        For i As Integer = 0 To getNumObras() - 1
            If obra.Equals(buscarObra(i)) Then
                repetida = True
            End If
        Next
        If Not repetida Then
            _obras.Add(obra)
        End If

        Return repetida
    End Function

    ''' <summary>
    ''' Método que elimina la obra seleccionada del arraylist de la clase
    ''' </summary>
    ''' <param name="id">Valor índice para buscar en el arraylist</param>
    ''' <returns>Devuelve True o False si se ha completado la acción o no</returns>
    Public Function eliminarObra(id As Integer) ''Refactorización(MVC): devuelve un boolean para poder usarlo en futuras funciones
        Dim eliminada As Boolean = False
        Dim obra As ObraArtistica = buscarObra(id)

        _obras.Remove(obra)
        eliminada = True

        Return eliminada
    End Function

    ''' <summary>
    ''' Método que devuleve una obra seleccionada del arraylist de la clase
    ''' </summary>
    ''' <param name="id">Valor índice para buscar en el arraylist</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function buscarObra(id As Integer) As ObraArtistica ''Refactorización(MVC): devuelve el objeto para poder usarlo en futuras funciones
        Return _obras.Item(id)
    End Function

    ''' <summary>
    ''' Método que devuelve el arraylist completo de la clase
    ''' </summary>
    ''' <returns>ArrayList _obras</returns>
    Public Function getObras()
        Return _obras
    End Function

    ''' <summary>
    ''' Devuelve la longitud del arraylist de la clase obra
    ''' </summary>
    ''' <returns>Longitud del ArrayList _obras</returns>
    Public Function getNumObras()
        Return _obras.Count
    End Function

    ''' <summary>
    ''' Método que calcula cual es la escultura más alta de la lista
    ''' </summary>
    ''' <returns>Un objeto de la clase Escultura</returns>
    Public Function esculturaMasAlta() As Escultura
        Dim masAlta As Escultura = New Escultura() ''Refactorización(MVC): devuelve el objeto para poder usarlo en futuras funciones

        For i As Integer = 0 To _obras.Count - 1
            If _obras.Item(i).GetType.Equals(masAlta.GetType) Then
                Dim escultura As Escultura = _obras.Item(i)
                If i = 0 Or escultura.altura > masAlta.altura Then
                    masAlta = escultura
                End If
            End If
        Next
        Return masAlta
    End Function

    ''' <summary>
    ''' Método que calcula cual es la superficie total sumando todos los cuadros del museo
    ''' </summary>
    ''' <returns>Integer con dicho valor</returns>
    Public Function superficiePinturas() ''Refactorización(MVC): devuelve el objeto para poder usarlo en futuras funciones
        Dim superficie As Integer
        Dim pintura As Pintura = New Pintura()

        For i As Integer = 0 To _obras.Count - 1
            If _obras.Item(i).GetType.Equals(pintura.GetType) Then
                Dim pin As Pintura = _obras.Item(i)
                superficie += pin.altura * pin.anchura
            End If
        Next
        Return superficie
    End Function


End Class
