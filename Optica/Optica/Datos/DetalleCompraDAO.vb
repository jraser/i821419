Imports System.Data.SqlClient

Public Class DetalleCompraDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function create(ByVal dts As vDetalleCompra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("DetalleCompraCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Id_Compra", dts.gId_Compra)
            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId_Producto)
            cmd.Parameters.AddWithValue("@PC", dts.gPC)
            cmd.Parameters.AddWithValue("@Cantida", dts.gCantida)
            cmd.Parameters.AddWithValue("@Monto", dts.gMonto)
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

    Public Function mostrar(ByVal dts As vDetalleCompra) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("DetalleCompraList")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Id_Compra", dts.gId_Compra)

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

    Public Function DetalleCompraSumaList(ByVal dts As vDetalleCompra) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("DetalleCompraSumaList")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Id_Compra", dts.gId_Compra)

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

    Public Function delete(ByVal dts As vDetalleCompra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("DetalleCompraDelete")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@id_detallecompra", dts.gId_DetalleCompra)
            cmd.Parameters.AddWithValue("@id_compra", dts.gId_Compra)
            cmd.Parameters.AddWithValue("@estado", dts.gEstado)
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
