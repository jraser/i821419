Public Class Login

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = TimeOfDay
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dts As New vLogin
            Dim fun As New LoginDAO
            dts.gUsuario = TextBox1.Text
            dts.gContraseña = TextBox2.Text

            If fun.LoginAccseso(dts) = True Then
                Inicio.Show()
                Me.Hide()
                Inicio.Label2.Text = dts.gUsuario
                Inicio.Label4.Text = dts.gContraseña
                Inicio.mostrar()
            Else
                MsgBox("Ingrese nuevamente sus datos correctos", MsgBoxStyle.Information, "Acceso al Sistema")
                TextBox1.Clear()
                TextBox2.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class