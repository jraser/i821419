Public Class vCategoria
    Dim ID_Categorias As Integer
    Dim Nombre_Categoria As String
    Dim Estado As String
    Dim UsuarioCreacion As String
    Dim UsuarioModificacion As String
    Dim UsuarioEliminacion As String
    Dim FechaCreacion As DateTime
    Dim FechaModificacion As DateTime
    Dim FechaEliminacion As DateTime

    Public Property gID_Categorias
        Get
            Return ID_Categorias
        End Get
        Set(value)
            ID_Categorias = value
        End Set
    End Property

    Public Property gNombre_Categoria
        Get
            Return Nombre_Categoria
        End Get
        Set(value)
            Nombre_Categoria = value
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

    Public Sub New(ByVal ID_Categorias As Integer,
        ByVal Nombre_Categoria As String,
        ByVal Estado As String,
        ByVal UsuarioCreacion As String,
        ByVal UsuarioModificacion As String,
        ByVal UsuarioEliminacion As String,
        ByVal FechaCreacion As DateTime,
        ByVal FechaModificacion As DateTime,
        ByVal FechaEliminacion As DateTime)

        gID_Categorias = ID_Categorias
        gNombre_Categoria = Nombre_Categoria
        gEstado = Estado
        gUsuarioCreacion = UsuarioCreacion
        gUsuarioModificacion = UsuarioModificacion
        gUsuarioEliminacion = UsuarioEliminacion
        gFechaCreacion = FechaCreacion
        gFechaModificacion = FechaModificacion
        gFechaEliminacion = FechaEliminacion
    End Sub
End Class
