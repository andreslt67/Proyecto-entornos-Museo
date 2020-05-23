Public Class Artista

    Private _nombre, _lugarNac, _fechaNac As String

    Sub New(nombre As String, lugarNac As String, fechaNac As String)
        Me._nombre = nombre
        Me._lugarNac = lugarNac
        Me._fechaNac = fechaNac
    End Sub

    Sub New()

    End Sub


    Public Property nombre() As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property lugarNac() As String
        Get
            Return Me._lugarNac
        End Get
        Set(value As String)
            Me._lugarNac = value
        End Set
    End Property

    Public Property fechaNac() As String
        Get
            Return Me._fechaNac
        End Get
        Set(value As String)
            Me._fechaNac = value
        End Set
    End Property

    Public Function toStringArtista()
        Dim datos As String
        datos = "Nombre: " + Me._nombre + " Lugar de nacimiento: " + Me._lugarNac + " Fecha de nacimiento: " + Me._fechaNac
        Return datos
    End Function

End Class
