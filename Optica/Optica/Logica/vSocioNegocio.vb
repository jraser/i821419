Public Class vSocioNegocio
    Dim ID_Socio As Integer
    Dim Tipo_Socio As String
    Dim Regimen_Socio As String
    Dim Tipo_Documento As String
    Dim Num_Documento As String
    Dim Nombres_Socio As String
    Dim Fecha_Nacimiento As Date
    Dim Sexo As String
    Dim Telefono As String
    Dim Origen_Socio As String
    Dim Direccion_Socio As String
    Dim Email As String
    Dim Estado As String
    Dim UsuarioCreacion As String
    Dim UsuarioModificacion As String
    Dim UsuarioEliminacion As String
    Dim FechaCreacion As DateTime
    Dim FechaModificacion As DateTime
    Dim FechaEliminacion As DateTime

    Public Property gID_Socio
        Get
            Return ID_Socio
        End Get
        Set(value)
            ID_Socio = value
        End Set
    End Property

    Public Property gTipo_Socio
        Get
            Return Tipo_Socio
        End Get
        Set(value)
            Tipo_Socio = value
        End Set
    End Property

    Public Property gRegimen_Socio
        Get
            Return Regimen_Socio
        End Get
        Set(value)
            Regimen_Socio = value
        End Set
    End Property

    Public Property gTipo_Documento
        Get
            Return Tipo_Documento
        End Get
        Set(value)
            Tipo_Documento = value
        End Set
    End Property

    Public Property gNum_Documento
        Get
            Return Num_Documento
        End Get
        Set(value)
            Num_Documento = value
        End Set
    End Property

    Public Property gNombres_Socio
        Get
            Return Nombres_Socio
        End Get
        Set(value)
            Nombres_Socio = value
        End Set
    End Property

    Public Property gFecha_Nacimiento
        Get
            Return Fecha_Nacimiento
        End Get
        Set(value)
            Fecha_Nacimiento = value
        End Set
    End Property

    Public Property gSexo
        Get
            Return Sexo
        End Get
        Set(value)
            Sexo = value
        End Set
    End Property

    Public Property gTelefono
        Get
            Return Telefono
        End Get
        Set(value)
            Telefono = value
        End Set
    End Property

    Public Property gOrigen_Socio
        Get
            Return Origen_Socio
        End Get
        Set(value)
            Origen_Socio = value
        End Set
    End Property

    Public Property gDireccion_Socio
        Get
            Return Direccion_Socio
        End Get
        Set(value)
            Direccion_Socio = value
        End Set
    End Property

    Public Property gEmail
        Get
            Return Email
        End Get
        Set(value)
            Email = value
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

    Public Sub New(ByVal ID_Socio As Integer,
        ByVal Tipo_Socio As String,
        ByVal Regimen_Socio As String,
        ByVal Tipo_Documento As String,
        ByVal Num_Documento As Integer,
        ByVal Nombres_Socio As String,
        ByVal Fecha_Nacimiento As Date,
        ByVal Sexo As String,
        ByVal Telefono As Integer,
        ByVal Origen_Socio As String,
        ByVal Direccion_Socio As String,
        ByVal Email As String,
        ByVal Estado As String,
        ByVal UsuarioCreacion As String,
        ByVal UsuarioModificacion As String,
        ByVal UsuarioEliminacion As String,
        ByVal FechaCreacion As DateTime,
        ByVal FechaModificacion As DateTime,
        ByVal FechaEliminacion As DateTime)

        gID_Socio = ID_Socio
        gTipo_Socio = Tipo_Socio
        gRegimen_Socio = Regimen_Socio
        gTipo_Documento = Tipo_Documento
        gNum_Documento = Num_Documento
        gNombres_Socio = Nombres_Socio
        gFecha_Nacimiento = Fecha_Nacimiento
        gSexo = Sexo
        gTelefono = Telefono
        gOrigen_Socio = Origen_Socio
        gDireccion_Socio = Direccion_Socio
        gEmail = Email
        gEstado = Estado
        gUsuarioCreacion = UsuarioCreacion
        gUsuarioModificacion = UsuarioModificacion
        gUsuarioEliminacion = UsuarioEliminacion
        gFechaCreacion = FechaCreacion
        gFechaModificacion = FechaModificacion
        gFechaEliminacion = FechaEliminacion
    End Sub
End Class


