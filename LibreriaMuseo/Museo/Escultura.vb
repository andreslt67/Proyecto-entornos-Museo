''' <summary>
''' Clase Escultura que hereda de la clase ObraArtistica
''' </summary>
Public Class Escultura
    Inherits ObraArtistica

    ''' <summary>
    ''' Enumeración de los materiales que puede usar la propiedad material de la clase Escultura
    ''' </summary>
    Public Enum Materiales
        arcilla
        piedra
        marmol
    End Enum

    Private _altura As Integer ''Refactorización: encapsulo las propiedades
    Private _material As Materiales

    ''' <summary>
    ''' Método constructor de la clase
    ''' </summary>
    ''' <param name="titulo">Título para la obra</param>
    ''' <param name="id">Su id en el inventario</param>
    ''' <param name="annoCreada">Año de creación (AC o DC)</param>
    ''' <param name="autor">Nombre su autor</param>
    ''' <param name="altura">Altura del cuadro</param>
    ''' <param name="material">Material con el que se realizó la obra</param>
    Sub New(titulo As String, id As Integer, annoCreada As String, autor As String, altura As Integer, material As Materiales)
        MyBase.New(titulo, id, annoCreada, autor)
        Me._altura = altura
        Me._material = material
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
    ''' Métodos de acceso para la propiedad material
    ''' </summary>
    ''' <value>Valor para cambiar esa propiedad</value>
    ''' <returns>Devuelve dicha propiedad de la clase</returns>
    Public Property material() As Materiales
        Get
            Return Me._material
        End Get
        Set(value As Materiales)
            Me._material = value
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
            Dim otro As Escultura = obj
            If Me._altura <> otro.altura Then
                Return False
            End If
            If Me._material <> otro.material Then
                Return False
            End If
        End If
        Return True
    End Function

    ''' <summary>
    ''' Fabrica un String con los valores de las propiedades de ObraArtistica y Escultura
    ''' </summary>
    ''' <returns>Devuelve dicho String</returns>
    Public Overloads Function toStringObra()
        Dim datos As String
        datos = MyBase.toStringObra & ", Altura: " & Me._altura & "cm, Hecho con: " & Me._material.ToString
        Return datos
    End Function
End Class
