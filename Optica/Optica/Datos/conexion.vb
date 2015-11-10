Imports System.Data.SqlClient

Public Class conexion
    Protected cn As New SqlConnection

    Public idusuario As Integer

    Protected Function conectado()
        Try
            cn = New SqlConnection("data source=192.168.1.38;initial catalog=DBOptica;user id=rita;password=123")
            cn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



    Protected Function desconectado()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
