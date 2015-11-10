Imports System.Data.SqlClient

Public Class UsuarioDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("LoginList")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim a As New SqlDataAdapter(cmd)
                a.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function mostrar2(ByVal dts As vUsuarios) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("LoginList2")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Usuario", dts.gUsuario)
            cmd.Parameters.AddWithValue("@Contraseña", dts.gContraseña)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim a As New SqlDataAdapter(cmd)
                a.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function create(ByVal dts As vUsuarios) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("LoginCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@UsuarioLogin", dts.gUsuarioLogin)
            cmd.Parameters.AddWithValue("@Usuario", dts.gUsuario)
            cmd.Parameters.AddWithValue("@Contraseña", dts.gContraseña)
            cmd.Parameters.AddWithValue("@Puesto", dts.gPuesto)
            cmd.Parameters.AddWithValue("@Imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@Acceso", dts.gAcceso)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function update(ByVal dts As vUsuarios) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("LoginUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@IdLogin", dts.gIdLogin)
            cmd.Parameters.AddWithValue("@UsuarioLogin", dts.gUsuarioLogin)
            cmd.Parameters.AddWithValue("@Usuario", dts.gUsuario)
            cmd.Parameters.AddWithValue("@Contraseña", dts.gContraseña)
            cmd.Parameters.AddWithValue("@Puesto", dts.gPuesto)
            cmd.Parameters.AddWithValue("@Imagen", dts.gimagen)
            cmd.Parameters.AddWithValue("@Acceso", dts.gAcceso)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

    Public Function delete(ByVal dts As vUsuarios) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("LoginDelete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@IdLogin", dts.gIdLogin)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function
End Class
