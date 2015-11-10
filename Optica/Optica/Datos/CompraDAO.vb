Imports System.Data.SqlClient

Public Class CompraDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("CompraList")
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

    Public Function mostrarTipDoc(ByVal dts As vCompra) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("CompraNumDocList")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@num_doc", dts.gNum_Doc)
            cmd.Parameters.AddWithValue("@id_socio", dts.gId_Socio)
            cmd.Parameters.AddWithValue("@Tipo_Doc", dts.gTipo_Doc)
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

    Public Function create(ByVal dts As vCompra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CompraCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Fecha_Compra", dts.gFecha_Compra)
            cmd.Parameters.AddWithValue("@Tipo_Doc", dts.gTipo_Doc)
            cmd.Parameters.AddWithValue("@Num_Doc", dts.gNum_Doc)
            cmd.Parameters.AddWithValue("@Id_Socio", dts.gId_Socio)
            cmd.Parameters.AddWithValue("@Subtotal", dts.gsubtotal)
            cmd.Parameters.AddWithValue("@Igv_Valor", dts.gigv_valor)
            cmd.Parameters.AddWithValue("@Igv", dts.gigv)
            cmd.Parameters.AddWithValue("@Total", dts.gtotal)
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

    Public Function update(ByVal dts As vCompra) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("CompraUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Id_Compra", dts.gId_Compra)
            cmd.Parameters.AddWithValue("@Fecha_Compra", dts.gFecha_Compra)
            cmd.Parameters.AddWithValue("@Tipo_Doc", dts.gTipo_Doc)
            cmd.Parameters.AddWithValue("@Num_Doc", dts.gNum_Doc)
            cmd.Parameters.AddWithValue("@Id_Socio", dts.gId_Socio)
            cmd.Parameters.AddWithValue("@Subtotal", dts.gsubtotal)
            cmd.Parameters.AddWithValue("@Igv_Valor", dts.gigv_valor)
            cmd.Parameters.AddWithValue("@Igv", dts.gigv)
            cmd.Parameters.AddWithValue("@Total", dts.gtotal)
            cmd.Parameters.AddWithValue("@Estado", dts.gEstado)
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
End Class
