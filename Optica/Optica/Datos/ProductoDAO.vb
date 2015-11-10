Imports System.Data.SqlClient

Public Class ProductoDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("ProductosList")
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

    Public Function create(ByVal dts As vProductos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ProductosCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Codigo_Producto", dts.gCodigo_Producto)
            cmd.Parameters.AddWithValue("@Lote_Producto", dts.gLote_Producto)
            cmd.Parameters.AddWithValue("@Nombre_Producto", dts.gNombre_Producto)
            cmd.Parameters.AddWithValue("@Id_Marca", dts.gId_Marca)
            cmd.Parameters.AddWithValue("@Id_Categorias", dts.gId_Categorias)
            cmd.Parameters.AddWithValue("@Id_Subcategoria", dts.gId_Subcategoria)
            cmd.Parameters.AddWithValue("@PC_Producto", dts.gPC_Producto)
            cmd.Parameters.AddWithValue("@PV_Producto", dts.gPV_Producto)
            cmd.Parameters.AddWithValue("@Imagen_Producto", dts.gImagen_Producto)
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

    Public Function update(ByVal dts As vProductos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ProductoUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId_Producto)
            cmd.Parameters.AddWithValue("@Codigo_Producto", dts.gCodigo_Producto)
            cmd.Parameters.AddWithValue("@Lote_Producto", dts.gLote_Producto)
            cmd.Parameters.AddWithValue("@Nombre_Producto", dts.gNombre_Producto)
            cmd.Parameters.AddWithValue("@Id_Marca", dts.gId_Marca)
            cmd.Parameters.AddWithValue("@Id_Categorias", dts.gId_Categorias)
            cmd.Parameters.AddWithValue("@Id_Subcategoria", dts.gId_Subcategoria)
            cmd.Parameters.AddWithValue("@PC_Producto", dts.gPC_Producto)
            cmd.Parameters.AddWithValue("@PV_Producto", dts.gPV_Producto)
            cmd.Parameters.AddWithValue("@Imagen_Producto", dts.gImagen_Producto)
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

    Public Function delete(ByVal dts As vProductos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ProductoDelete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId_Producto)
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
