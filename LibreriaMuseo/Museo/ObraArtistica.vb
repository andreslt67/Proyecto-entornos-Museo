''' <summary>
''' Clase obra artistica que permite definir cualquier obra del mueso de forma general
''' </summary>
Public Class ObraArtistica

    Protected _titulo As String ''Refactorización: encapsulo las propiedades de forma que solo puedan acceder las clases hijas
    Protected _id As Integer
    Protected _annoCreada As String
    Protected _autor As String

    ''' <summary>
    ''' Método constructor de obraArtistica 
    ''' </summary>
    ''' <param name="titulo">Título para la obra</param>
    ''' <param name="id">Su id en el inventario</param>
    ''' <param name="annoCreada">Año de creación (AC o DC)</param>
    ''' <param name="autor">Nombre su autor</param>
    Sub New(titulo As String, id As Integer, annoCreada As String, autor As String)
        Me._titulo = titulo
        Me._id = id
        Me._annoCreada = annoCreada
        Me._autor = autor
    End Sub

    ''' <summary>
    ''' Constructor vacío de la clase útil para algunas funciones
    ''' </summary>
    Sub New()

    End Sub

    ''' <summary>
    ''' Métodos de acceso para la propiedad titulo
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property titulo() As String
        Get
            Return Me._titulo
        End Get
        Set(value As String)
            Me._titulo = value
        End Set
    End Property

    ''' <summary>
    ''' Métodos de acceso para la propiedad id
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property id() As Integer
        Get
            Return Me._id
        End Get
        Set(value As Integer)
            Me._id = value
        End Set
    End Property

    ''' <summary>
    ''' Métodos de acceso para la propiedad annoCreada
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property annoCreada() As String
        Get
            Return Me._annoCreada
        End Get
        Set(value As String)
            Me._annoCreada = value
        End Set
    End Property

    ''' <summary>
    ''' Métodos de acceso para la propiedad autor
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property autor() As String
        Get
            Return Me._autor
        End Get
        Set(value As String)
            Me._autor = value
        End Set
    End Property

    ''' <summary>
    ''' Método que compara el objeto introducido con este
    ''' </summary>
    ''' <param name="obj">objeto de la clase Object pasado por parámetro</param>
    ''' <returns>Devuelve True o False dependiendo si ambos objetos son iguales o diferentes</returns>
    Public Overrides Function Equals(obj As Object) As Boolean
        Dim otro As ObraArtistica = obj

        If Me.GetType <> otro.GetType Then
            Return False
        End If
        If Me._titulo <> otro.titulo Then
            Return False
        End If
        If Me._id <> otro.id Then
            Return False
        End If
        If Me._annoCreada <> otro.annoCreada Then
            Return False
        End If
        If Me._autor <> otro.autor Then
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' fabrica un String con los valores de las propiedades de ObraArtistica
    ''' </summary>
    ''' <returns>Devuelve dicho String</returns>
    Public Function toStringObra()
        Dim datos As String
        datos = "Título: " & Me._titulo & ", ID: " & Me._id & ", Creada en el año: " & Me._annoCreada & ", por el autor: " & Me._autor
        Return datos
    End Function

End Class
