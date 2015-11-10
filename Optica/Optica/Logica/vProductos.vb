Public Class vProductos
    Dim Id_Producto As Integer
    Dim Codigo_Producto As String
    Dim Lote_Producto As String
    Dim Nombre_Producto As String
    Dim Id_Marca As Integer
    Dim Id_Categorias As Integer
    Dim Id_Subcategoria As Integer
    Dim PC_Producto As Decimal
    Dim PV_Producto As Decimal
    Dim Imagen_Producto() As Byte
    Dim Estado As String
    Dim UsuarioCreacion As String
    Dim UsuarioModificacion As String
    Dim UsuarioEliminacion As String
    Dim FechaCreacion As DateTime
    Dim FechaModificacion As DateTime
    Dim FechaEliminacion As DateTime




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

    Public Property gImagen_Producto
        Get
            Return Imagen_Producto
        End Get
        Set(value)
            Imagen_Producto = value
        End Set
    End Property

    Public Property gPV_Producto
        Get
            Return PV_Producto
        End Get
        Set(value)
            PV_Producto = value
        End Set
    End Property

    Public Property gPC_Producto
        Get
            Return PC_Producto
        End Get
        Set(value)
            PC_Producto = value
        End Set
    End Property

    Public Property gId_Subcategoria
        Get
            Return Id_Subcategoria
        End Get
        Set(value)
            Id_Subcategoria = value
        End Set
    End Property

    Public Property gId_Categorias
        Get
            Return Id_Categorias
        End Get
        Set(value)
            Id_Categorias = value
        End Set
    End Property

    Public Property gId_Marca
        Get
            Return Id_Marca
        End Get
        Set(value)
            Id_Marca = value
        End Set
    End Property

    Public Property gNombre_Producto
        Get
            Return Nombre_Producto
        End Get
        Set(value)
            Nombre_Producto = value
        End Set
    End Property

    Public Property gLote_Producto
        Get
            Return Lote_Producto
        End Get
        Set(value)
            Lote_Producto = value
        End Set
    End Property

    Public Property gCodigo_Producto
        Get
            Return Codigo_Producto
        End Get
        Set(value)
            Codigo_Producto = value
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


    Public Sub New()

    End Sub

    Public Sub New(ByVal Id_Producto As Integer,
        ByVal Codigo_Producto As String,
        ByVal Lote_Producto As String,
        ByVal Nombre_Producto As String,
        ByVal Id_Marca As Integer,
        ByVal Id_Categorias As Integer,
        ByVal Id_Subcategoria As Integer,
        ByVal PC_Producto As Decimal,
        ByVal PV_Producto As Decimal,
        ByVal Imagen_Producto() As Byte,
        ByVal Estado As String,
        ByVal UsuarioCreacion As String,
        ByVal UsuarioModificacion As String,
        ByVal UsuarioEliminacion As String,
        ByVal FechaCreacion As DateTime,
        ByVal FechaModificacion As DateTime,
        ByVal FechaEliminacion As DateTime)

        gId_Producto = Id_Producto
        gCodigo_Producto = Codigo_Producto
        gLote_Producto = Lote_Producto
        gNombre_Producto = Nombre_Producto
        gId_Marca = Id_Marca
        gId_Categorias = Id_Categorias
        gId_Subcategoria = Id_Subcategoria
        gPC_Producto = PC_Producto
        gPV_Producto = PV_Producto
        gImagen_Producto = Imagen_Producto
        gEstado = Estado
        gUsuarioCreacion = UsuarioCreacion
        gUsuarioModificacion = UsuarioModificacion
        gUsuarioEliminacion = UsuarioEliminacion
        gFechaCreacion = FechaCreacion
        gFechaModificacion = FechaModificacion
        gFechaEliminacion = FechaEliminacion
    End Sub
End Class
