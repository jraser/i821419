Public Class VerImagen

    Private Sub VerImagen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = CosultarStock.dgvCliente.SelectedCells.Item(6).Value
        ptbImagen.BackgroundImage = Nothing
        Dim b() As Byte = CosultarStock.dgvCliente.SelectedCells.Item(8).Value
        Dim ms As New IO.MemoryStream(b)

        ptbImagen.Image = Image.FromStream(ms)
        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class