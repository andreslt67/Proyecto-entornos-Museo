Public Class Catalogo

    Private _obras As ArrayList

    Sub New()
        Dim a1 As Artista = New Artista("Vincent Van Gogh", "Paises Bajos", "3-12-1853")
        Dim o1 As ObraArtistica = New Pintura("La noche estrellada", 1, "1889 DC", a1, 12, 6, "caballete", "oleo")
        _obras.Add(o1)

        Dim a2 As Artista = New Artista("Mirón de Eléuteras", "Grecia", "480 AC")
        Dim o2 As ObraArtistica = New Escultura("Discóbolo", 2, "455 DC", a2, 230, Escultura.Materiales.piedra)
        _obras.Add(o2)
    End Sub

    Public Function addObra(obra As ObraArtistica)
        Dim repetida As Boolean = False
        For Each elemento As ObraArtistica In _obras
            If obra.Equals(elemento) Then
                repetida = True
            End If
        Next
        If Not repetida Then
            _obras.Add(obra)
        End If

        Return repetida
    End Function

    Public Function eliminarObra(id As Integer)
        Dim eliminada As Boolean = False
        For Each elemento As ObraArtistica In _obras
            If id = elemento.id Then
                _obras.RemoveAt(id)
                eliminada = True
            End If
        Next

        Return eliminada
    End Function

    Public Function buscarObra(id As String) As ObraArtistica
        Return _obras.Item(id)
    End Function

    Public Function getObras()
        Return _obras
    End Function

    Public Function esculturaMasAlta() As ObraArtistica
        Dim masAlta As Escultura = New Escultura()

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

    Public Function superficiePinturas()
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
