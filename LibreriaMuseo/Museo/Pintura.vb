''' <summary>
''' Clase Pintura que hereda de la clase ObraArtistica
''' </summary>
Public Class Pintura
    Inherits ObraArtistica

    Private _altura, _anchura As Integer ''Refactorización: encapsulo las propiedades
    Private _soporte, _pintura As String

    ''' <summary>
    ''' Método constructor de la clase
    ''' </summary>
    ''' <param name="titulo">Título para la obra</param>
    ''' <param name="id">Su id en el inventario</param>
    ''' <param name="annoCreada">Año de creación (AC o DC)</param>
    ''' <param name="autor">Nombre su autor</param>
    ''' <param name="altura">Altura del cuadro</param>
    ''' <param name="anchura">Anchura del cuadro</param>
    ''' <param name="soporte">Soporte del cuadro</param>
    ''' <param name="pintura">Tipo de pintura en el que se ha realizado</param>
    Sub New(titulo As String, id As Integer, annoCreada As String, autor As String, altura As Integer, anchura As Integer, soporte As String, pintura As String)
        MyBase.New(titulo, id, annoCreada, autor)
        Me._altura = altura
        Me._anchura = anchura
        Me._soporte = soporte
        Me._pintura = pintura
    End Sub

    ''' <summary>
    ''' Constructor vacío de la clase útil para algunas funciones
    ''' </summary>
    Sub New()

    End Sub

    ''' <summary>
    ''' Métodos de acceso para la propiedad altura
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property altura() As Integer
        Get
            Return Me._altura
        End Get
        Set(value As Integer)
            Me._altura = value
        End Set
    End Property

    ''' <summary>
    ''' Métodos de acceso para la propiedad anchura
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property anchura() As Integer
        Get
            Return Me._anchura
        End Get
        Set(value As Integer)
            Me._anchura = value
        End Set
    End Property

    ''' <summary>
    ''' Métodos de acceso para la propiedad soporte
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property soporte() As String
        Get
            Return Me._soporte
        End Get
        Set(value As String)
            Me._soporte = value
        End Set
    End Property

    ''' <summary>
    ''' Métodos de acceso para la propiedad pintura
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property pintura() As String
        Get
            Return Me._pintura
        End Get
        Set(value As String)
            Me._pintura = value
        End Set
    End Property

    ''' <summary>
    ''' Método que compara el objeto introducido con este, hereda del método con el mismo nombre de la clase padre
    ''' </summary>
    ''' <param name="obj">objeto de la clase Object pasado por parámetro</param>
    ''' <returns>Devuelve True o False dependiendo si ambos objetos son iguales o diferentes</returns>
    Public Overloads Function Equals(obj As Object) As Boolean
        If MyBase.Equals(obj) = False Then ''Refactorización: llamo al método de la clase padre para no repetir código
            Return False
        Else
            Dim otro As Pintura = obj
            If Me._altura <> otro.altura Then
                Return False
            End If
            If Me._anchura <> otro.anchura Then
                Return False
            End If
            If Me._soporte <> otro.soporte Then
                Return False
            End If
            If Me._pintura <> otro.pintura Then
                Return False
            End If
        End If
        Return True
    End Function

    ''' <summary>
    ''' Fabrica un String con los valores de las propiedades de ObraArtistica y Pintura
    ''' </summary>
    ''' <returns>Devuelve dicho String</returns>
    Public Overloads Function toStringObra()
        Dim datos As String
        datos = MyBase.toStringObra & ", Altura: " & Me._altura & "cm, Anchura: " & Me._anchura & "cm, Pintada sobre: " & Me._soporte + ", Pintada con:" & Me._pintura
        Return datos
    End Function



End Class
