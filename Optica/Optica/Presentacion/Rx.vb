Public Class Rx

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Rx_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub chbSesacionC_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles chkEndemaOI.CheckedChanged

    End Sub

    Private Sub btnBuscarPaciente_Click(sender As Object, e As EventArgs) Handles btnBuscarPaciente.Click
        AyudaCliente.TextBox1.Text = "1"
        AyudaCliente.ShowDialog()
    End Sub
End Class