Public Class vCompra
    Dim Id_Compra As Integer
    Dim Fecha_Compra As DateTime
    Dim Tipo_Doc As String
    Dim Num_Doc As String
    Dim Id_Socio As Integer
    Dim subtotal As Decimal
    Dim igv_valor As Decimal
    Dim igv As Decimal
    Dim total As Decimal
    Dim Estado As String
    Dim UsuarioCreacion As String
    Dim UsuarioModificacion As String
    Dim UsuarioEliminacion As String
    Dim FechaCreacion As DateTime
    Dim FechaModificacion As DateTime
    Dim FechaEliminacion As DateTime


    Public Property gId_Compra
        Get
            Return Id_Compra
        End Get
        Set(value)
            Id_Compra = value
        End Set
    End Property

    Public Property gFecha_Compra
        Get
            Return Fecha_Compra
        End Get
        Set(value)
            Fecha_Compra = value
        End Set
    End Property
    Public Property gTipo_Doc
        Get
            Return Tipo_Doc
        End Get
        Set(value)
            Tipo_Doc = value
        End Set
    End Property

    Public Property gNum_Doc
        Get
            Return Num_Doc
        End Get
        Set(value)
            Num_Doc = value
        End Set
    End Property

    Public Property gId_Socio
        Get
            Return Id_Socio
        End Get
        Set(value)
            Id_Socio = value
        End Set
    End Property
    Public Property gsubtotal
        Get
            Return subtotal
        End Get
        Set(value)
            subtotal = value
        End Set
    End Property
    Public Property gigv_valor
        Get
            Return igv_valor
        End Get
        Set(value)
            igv_valor = value
        End Set
    End Property
    Public Property gigv
        Get
            Return igv
        End Get
        Set(value)
            igv = value
        End Set
    End Property
    Public Property gtotal
        Get
            Return total
        End Get
        Set(value)
            total = value
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

    Public Sub New(ByVal Id_Compra As Integer,
        ByVal Fecha_Compra As DateTime,
        ByVal Tipo_Doc As String,
        ByVal Num_Doc As String,
        ByVal Id_Socio As Integer,
        ByVal subtotal As Decimal,
        ByVal igv_valor As Decimal,
        ByVal igv As Decimal,
        ByVal total As Decimal,
        ByVal Estado As String,
        ByVal UsuarioCreacion As String,
        ByVal UsuarioModificacion As String,
        ByVal UsuarioEliminacion As String,
        ByVal FechaCreacion As DateTime,
        ByVal FechaModificacion As DateTime,
        ByVal FechaEliminacion As DateTime)

        gId_Compra = Id_Compra
        gFecha_Compra = Fecha_Compra
        gTipo_Doc = Tipo_Doc
        gNum_Doc = Num_Doc
        gId_Socio = Id_Socio
        gsubtotal = subtotal
        gigv_valor = igv_valor
        gigv = igv
        gtotal = total
        gEstado = Estado
        gUsuarioCreacion = UsuarioCreacion
        gUsuarioModificacion = UsuarioModificacion
        gUsuarioEliminacion = UsuarioEliminacion
        gFechaCreacion = FechaCreacion
        gFechaModificacion = FechaModificacion
        gFechaEliminacion = FechaEliminacion
    End Sub
End Class
