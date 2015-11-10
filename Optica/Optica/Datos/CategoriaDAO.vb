Imports System.Data.SqlClient

Public Class CategoriaDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("CategoriaList")
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

    Public Function create(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CategoriaCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Nombre_Categoria", dts.gNombre_Categoria)
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

    Public Function update(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CategoriaUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Categorias", dts.gID_Categorias)
            cmd.Parameters.AddWithValue("@Nombre_Categoria", dts.gNombre_Categoria)
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

    Public Function delete(ByVal dts As vCategoria) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CategoriaDelete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_categorias", dts.gID_Categorias)
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
