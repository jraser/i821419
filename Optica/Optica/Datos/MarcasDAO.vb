Imports System.Data.SqlClient

Public Class MarcasDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("MarcaList")
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

    Public Function create(ByVal dts As vMarcas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("MarcaCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Nombre_Marca", dts.gNombre_Marca)
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

    Public Function update(ByVal dts As vMarcas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("MarcaUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Marca", dts.gID_Marca)
            cmd.Parameters.AddWithValue("@Nombre_Marca", dts.gNombre_Marca)
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

    Public Function delete(ByVal dts As vMarcas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("MarcaDelete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Marca", dts.gID_Marca)
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
