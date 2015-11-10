Imports System.Data.SqlClient

Public Class LoginDAO

    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function LoginAccseso(ByVal dts As vLogin)
        Try
            conectado()
            cmd = New SqlCommand("LoginAccseso")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@Usuario", dts.gUsuario)
            cmd.Parameters.AddWithValue("@Contraseña", dts.gContraseña)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
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
