Public Class vStock
    Dim Id_Stock As Integer
    Dim Id_Producto As Integer
    Dim Cantidad As Integer

    Public Property gId_Stock
        Get
            Return Id_Stock
        End Get
        Set(value)
            Id_Stock = value
        End Set
    End Property
    Public Property gId_Producto
        Get
            Return Id_Producto
        End Get
        Set(value)
            Id_Producto = value
        End Set
    End Property
    Public Property gCantidad
        Get
            Return Cantidad
        End Get
        Set(value)
            Cantidad = value
        End Set
    End Property
    Public Sub New()

    End Sub

    Public Sub New(ByVal Id_Stock As Integer,
        ByVal Id_Producto As Integer,
        ByVal Cantidad As Integer)

        gId_Stock = Id_Stock
        gId_Producto = Id_Producto
        gCantidad = Cantidad

    End Sub
End Class
