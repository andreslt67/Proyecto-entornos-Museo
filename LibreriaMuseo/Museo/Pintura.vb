Public Class Pintura
    Inherits ObraArtistica

    Private _altura, _anchura As Integer
    Private _soporte, _pintura As String

    Sub New(titulo As String, id As Integer, añoCreada As String, autor As Artista, altura As Integer, anchura As Integer, soporte As String, pintura As String)
        MyBase.New(titulo, id, añoCreada, autor)
        Me._altura = altura
        Me._anchura = anchura
        Me._soporte = soporte
        Me._pintura = pintura
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

    Public Property anchura() As Integer
        Get
            Return Me._anchura
        End Get
        Set(value As Integer)
            Me._anchura = value
        End Set
    End Property

    Public Property soporte() As String
        Get
            Return Me._soporte
        End Get
        Set(value As String)
            Me._soporte = value
        End Set
    End Property

    Public Property pintura() As String
        Get
            Return Me._pintura
        End Get
        Set(value As String)
            Me._pintura = value
        End Set
    End Property

    Public Function toStringPintura()
        Dim datos As String
        datos = MyBase.toStringObra + " Altura: " + Me._altura + "cm Anchura: " + Me._anchura + "cm Pintada sobre: " + Me._soporte + " Pintada con:" + Me._pintura
        Return datos
    End Function



End Class
