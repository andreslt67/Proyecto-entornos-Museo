Public Class ObraArtistica

    Private _titulo As String
    Private _id As Integer
    Private _añoCreada As Integer
    Private _autor As Artista

    Sub New(titulo As String, id As Integer, añoCreada As Integer, autor As Artista)
        Me._titulo = titulo
        Me._id = id
        Me._añoCreada = añoCreada
        Me._autor = autor
    End Sub

    Public Property titulo() As String
        Get
            Return Me._titulo
        End Get
        Set(value As String)
            Me._titulo = value
        End Set
    End Property

    Public Property id() As Integer
        Get
            Return Me._id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property

    Public Property añoCreada() As Integer
        Get
            Return Me._añoCreada
        End Get
        Set(value As Integer)
            Me._añoCreada = value
        End Set
    End Property

    Public Property autor() As Artista
        Get
            Return Me._autor
        End Get
        Set(value As Artista)
            Me._autor = value
        End Set
    End Property

    Public Function toStringObra()
        Dim datos As String
        datos = "Título: " + Me._titulo + " Creada en el año: " + Me._añoCreada + " por el autor: " + Me._autor.nombre
        Return datos
    End Function

End Class
