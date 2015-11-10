Imports System.Data.SqlClient

Public Class SocioNegocioDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SocioNegocioList")
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

    Public Function SocioNegocioProvList() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SocioNegocioProvList")
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
    Public Function SocioNegocioClienteList() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SocioNegocioClienteList")
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
    Public Function create(ByVal dts As vSocioNegocio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SocioNegocioCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Tipo_Socio", dts.gTipo_Socio)
            cmd.Parameters.AddWithValue("@Regimen_Socio", dts.gRegimen_Socio)
            cmd.Parameters.AddWithValue("@Tipo_Documento", dts.gTipo_Documento)
            cmd.Parameters.AddWithValue("@Num_Documento", dts.gNum_Documento)
            cmd.Parameters.AddWithValue("@Nombres_Socio", dts.gNombres_Socio)
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", dts.gFecha_Nacimiento)
            cmd.Parameters.AddWithValue("@Sexo", dts.gSexo)
            cmd.Parameters.AddWithValue("@Telefono", dts.gTelefono)
            cmd.Parameters.AddWithValue("@Origen_Socio", dts.gOrigen_Socio)
            cmd.Parameters.AddWithValue("@Direccion_Socio", dts.gDireccion_Socio)
            cmd.Parameters.AddWithValue("@Email", dts.gEmail)
            cmd.Parameters.AddWithValue("@Estado", dts.gEstado)
            cmd.Parameters.AddWithValue("@UsuarioCreacion", dts.gUsuarioCreacion)
            cmd.Parameters.AddWithValue("@FechaCreacion", dts.gFechaCreacion)

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

    Public Function update(ByVal dts As vSocioNegocio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SocioNegocioUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Socio", dts.gID_Socio)
            cmd.Parameters.AddWithValue("@Tipo_Socio", dts.gTipo_Socio)
            cmd.Parameters.AddWithValue("@Regimen_Socio", dts.gRegimen_Socio)
            cmd.Parameters.AddWithValue("@Tipo_Documento", dts.gTipo_Documento)
            cmd.Parameters.AddWithValue("@Num_Documento", dts.gNum_Documento)
            cmd.Parameters.AddWithValue("@Nombres_Socio", dts.gNombres_Socio)
            cmd.Parameters.AddWithValue("@Fecha_Nacimiento", dts.gFecha_Nacimiento)
            cmd.Parameters.AddWithValue("@Sexo", dts.gSexo)
            cmd.Parameters.AddWithValue("@Telefono", dts.gTelefono)
            cmd.Parameters.AddWithValue("@Origen_Socio", dts.gOrigen_Socio)
            cmd.Parameters.AddWithValue("@Direccion_Socio", dts.gDireccion_Socio)
            cmd.Parameters.AddWithValue("@Email", dts.gEmail)
            cmd.Parameters.AddWithValue("@UsuarioModificacion", dts.gUsuarioModificacion)
            cmd.Parameters.AddWithValue("@FechaModificacion", dts.gFechaModificacion)

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

    Public Function delete(ByVal dts As vSocioNegocio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SocioNegocioDelete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Socio", dts.gID_Socio)
            cmd.Parameters.AddWithValue("@Estado", dts.gEstado)
            cmd.Parameters.AddWithValue("@UsuarioEliminacion", dts.gUsuarioEliminacion)
            cmd.Parameters.AddWithValue("@FechaEliminacion", dts.gFechaEliminacion)

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
