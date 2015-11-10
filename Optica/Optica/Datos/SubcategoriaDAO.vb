Imports System.Data.SqlClient

Public Class SubcategoriaDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar(ByVal dts As vSubcategorias) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("SubcategoriaList")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Categorias", dts.gID_Categorias)

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

    Public Function create(ByVal dts As vSubcategorias) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SubcategoriaCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Categorias", dts.gID_Categorias)
            cmd.Parameters.AddWithValue("@Nombre_Subcategoria", dts.gNombre_subcategoria)
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

    Public Function update(ByVal dts As vSubcategorias) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SubcategoriaUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Subcategoria", dts.gID_Subcategoria)
            cmd.Parameters.AddWithValue("@Nombre_subcategoria", dts.gNombre_subcategoria)
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

    Public Function delete(ByVal dts As vSubcategorias) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("SubcategoriaDelete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@ID_Subcategoria", dts.gID_Subcategoria)
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
