Imports System.Data.SqlClient

Public Class StockDAO
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("StockList")
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


    Public Function StockXProductoList(ByVal dts As vStock) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("StockXProductoList")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId_Producto)

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

    Public Function create(ByVal dts As vStock) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("StockCreate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId_Producto)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)

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

    Public Function StockSumaUpdate(ByVal dts As vStock) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("StockSumaUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId_Producto)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)

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
    Public Function StockRestaUpdate(ByVal dts As vStock) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("StockRestaUpdate")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@Id_Producto", dts.gId_Producto)
            cmd.Parameters.AddWithValue("@Cantidad", dts.gCantidad)

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
