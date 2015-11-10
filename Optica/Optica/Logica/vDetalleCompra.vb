Public Class vDetalleCompra
    Dim Id_DetalleCompra As Integer
    Dim Id_Compra As Integer
    Dim Id_Producto As Integer
    Dim PC As Decimal
    Dim Cantida As Integer
    Dim Monto As Decimal
    Dim Estado As String
    Dim UsuarioCreacion As String
    Dim UsuarioModificacion As String
    Dim UsuarioEliminacion As String
    Dim FechaCreacion As DateTime
    Dim FechaModificacion As DateTime
    Dim FechaEliminacion As DateTime

    Public Property gId_DetalleCompra
        Get
            Return Id_DetalleCompra
        End Get
        Set(value)
            Id_DetalleCompra = value
        End Set
    End Property

    Public Property gId_Compra
        Get
            Return Id_Compra
        End Get
        Set(value)
            Id_Compra = value
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

    Public Property gPC
        Get
            Return PC
        End Get
        Set(value)
            PC = value
        End Set
    End Property

    Public Property gCantida
        Get
            Return Cantida
        End Get
        Set(value)
            Cantida = value
        End Set
    End Property

    Public Property gMonto
        Get
            Return Monto
        End Get
        Set(value)
            Monto = value
        End Set
    End Property

    Public Property gEstado
        Get
            Return Estado
        End Get
        Set(value)
            Estado = value
        End Set
    End Property

    Public Property gUsuarioCreacion
        Get
            Return UsuarioCreacion
        End Get
        Set(value)
            UsuarioCreacion = value
        End Set
    End Property

    Public Property gUsuarioModificacion
        Get
            Return UsuarioModificacion
        End Get
        Set(value)
            UsuarioModificacion = value
        End Set
    End Property

    Public Property gUsuarioEliminacion
        Get
            Return UsuarioEliminacion
        End Get
        Set(value)
            UsuarioEliminacion = value
        End Set
    End Property

    Public Property gFechaCreacion
        Get
            Return FechaCreacion
        End Get
        Set(value)
            FechaCreacion = value
        End Set
    End Property

    Public Property gFechaModificacion
        Get
            Return FechaModificacion
        End Get
        Set(value)
            FechaModificacion = value
        End Set
    End Property

    Public Property gFechaEliminacion
        Get
            Return FechaEliminacion
        End Get
        Set(value)
            FechaEliminacion = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal Id_DetalleCompra As Integer,
                   ByVal Id_Compra As Integer,
                   ByVal Id_Producto As Integer,
                   ByVal PC As Decimal,
                   ByVal Cantida As Integer,
                   ByVal Monto As Decimal,
                    ByVal Estado As String,
                    ByVal UsuarioCreacion As String,
                    ByVal UsuarioModificacion As String,
                    ByVal UsuarioEliminacion As String,
                    ByVal FechaCreacion As DateTime,
                    ByVal FechaModificacion As DateTime,
                    ByVal FechaEliminacion As DateTime)

        gId_DetalleCompra = Id_DetalleCompra
        gId_Compra = Id_Compra
        gId_Producto = Id_Producto
        gPC = PC
        gCantida = Cantida
        gMonto = Monto
        gEstado = Estado
        gUsuarioCreacion = UsuarioCreacion
        gUsuarioModificacion = UsuarioModificacion
        gUsuarioEliminacion = UsuarioEliminacion
        gFechaCreacion = FechaCreacion
        gFechaModificacion = FechaModificacion
        gFechaEliminacion = FechaEliminacion
    End Sub
End Class
