﻿Public Class vUsuarios

    Dim IdLogin As Integer
    Dim UsuarioLogin As String
    Dim Usuario As String
    Dim Contraseña As String
    Dim Puesto As String
    Dim imagen() As Byte
    Dim Acceso As String

    Public Property gPuesto
        Get
            Return Puesto
        End Get
        Set(value)
            Puesto = value
        End Set
    End Property

    Public Property gimagen
        Get
            Return imagen
        End Get
        Set(value)
            imagen = value
        End Set
    End Property

    Public Property gIdLogin
        Get
            Return IdLogin
        End Get
        Set(value)
            IdLogin = value
        End Set
    End Property

    Public Property gUsuarioLogin
        Get
            Return UsuarioLogin
        End Get
        Set(value)
            UsuarioLogin = value
        End Set
    End Property


    Public Property gUsuario
        Get
            Return Usuario
        End Get
        Set(value)
            Usuario = value
        End Set
    End Property

    Public Property gContraseña
        Get
            Return Contraseña
        End Get
        Set(value)
            Contraseña = value
        End Set
    End Property

    Public Property gAcceso
        Get
            Return Acceso
        End Get
        Set(value)
            Acceso = value
        End Set
    End Property



    Public Sub New()

    End Sub

    Public Sub New(
        ByVal IdLogin As Integer,
        ByVal UsuarioLogin As String,
        ByVal Usuario As String,
        ByVal Contraseña As String,
        ByVal Puesto As String,
        ByVal imagen() As Byte,
        ByVal Acceso As String)

        gIdLogin = IdLogin
        gUsuarioLogin = UsuarioLogin
        gUsuario = Usuario
        gContraseña = Contraseña
        gPuesto = Puesto
        gimagen = imagen
        gAcceso = Acceso


    End Sub
End Class
