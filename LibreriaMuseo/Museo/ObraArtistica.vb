Public Class ObraArtistica

    Protected _titulo As String
    Protected _id As Integer
    Protected _annoCreada As String
    Protected _autor As String

    Sub New(titulo As String, id As Integer, annoCreada As String, autor As String)
        Me._titulo = titulo
        Me._id = id
        Me._annoCreada = annoCreada
        Me._autor = autor
    End Sub

    Sub New()

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

    Public Property annoCreada() As String
        Get
            Return Me._annoCreada
        End Get
        Set(value As String)
            Me._annoCreada = value
        End Set
    End Property

    Public Property autor() As String
        Get
            Return Me._autor
        End Get
        Set(value As String)
            Me._autor = value
        End Set
    End Property

    Public Function toStringObra()
        Dim datos As String
        datos = "Título: " + Me._titulo + " Creada en el año: " + Me._annoCreada + " por el autor: " + Me._autor
        Return datos
    End Function

End Class
