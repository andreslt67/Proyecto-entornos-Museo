Public Class Escultura
    Inherits ObraArtistica

    Public Enum Materiales
        arcilla
        piedra
        marmol
    End Enum

    Private _altura As Integer
    Private _material As Materiales

    Sub New(titulo As String, id As Integer, annoCreada As String, autor As String, altura As Integer, material As Materiales)
        MyBase.New(titulo, id, annoCreada, autor)
        Me._altura = altura
        Me._material = material
    End Sub

    Sub New()

    End Sub


    Public Property altura() As Integer
        Get
            Return Me._altura
        End Get
        Set(value As Integer)
            Me._altura = value
        End Set
    End Property

    Public Property material() As Materiales
        Get
            Return Me._material
        End Get
        Set(value As Materiales)
            Me._material = value
        End Set
    End Property

    Public Overloads Function toStringObra()
        Dim datos As String
        datos = MyBase.toStringObra + " Altura: " + Me._altura + "Hecho con: " + Me._material
        Return datos
    End Function
End Class
