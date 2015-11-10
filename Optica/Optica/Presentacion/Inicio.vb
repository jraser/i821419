Imports System.IO

Public Class Inicio
    Private dt As New DataTable
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente quieres salir del Sistema", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then
            fSocioNegocio.Close()
            Marca.Close()
            Categorias.Close()
            Productos.Close()
            AyudaMarca.Close()
            AyudaCategoria.Close()
            AyudaProducto.Close()
            AyudaProveedor.Close()
            Compra.Close()
            AyudaCompra.Close()
            CosultarStock.Close()
            VerImagen.Close()
            Rx.Close()
            Usuario.Close()

            Login.Show()


            Login.TextBox1.Clear()
            Login.TextBox2.Clear()

            Me.Close()

        End If



    End Sub

    Private Sub Inicio_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        RadialMenu1.ShowPopup(New Point(Me.Location))
    End Sub


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Size = New System.Drawing.Size(39, 39)
        RadialMenu1.ShowPopup(New Point(Me.Location))


    End Sub
    Public Sub mostrar()
        Try
            Dim dts As New vUsuarios
            Dim func As New UsuarioDAO
            Dim byImagen() As Byte = Nothing
            Dim oMemoryStream As MemoryStream
            Dim bmpImagen As Bitmap
            Dim dtTabla As New DataTable

            dts.gUsuario = Label2.Text
            dts.gContraseña = Label4.Text
            dt = func.mostrar2(dts)


            If dt.Rows.Count <> 0 Then
                lblNombre.Text = dt.Rows(0).Item(1).ToString
                Label3.Text = dt.Rows(0).Item(4).ToString
                Dim value As Object = dt.Rows(0).Item(5)



                byImagen = CType(value, Byte())
                oMemoryStream = New MemoryStream(byImagen)
                bmpImagen = New Bitmap(oMemoryStream)
                'Lo muestro en el PictureBox
                ptbImagen.Image = bmpImagen
                ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage



            Else


            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Size = New System.Drawing.Size(39, 39)
        RadialMenu1.ShowPopup(New Point(Me.Location))
    End Sub

    Private Sub RadialMenu1_CloseUp(sender As Object, e As EventArgs) Handles RadialMenu1.CloseUp
        Me.Size = New System.Drawing.Size(227, 321)
    End Sub

    Private Sub btnSocio_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSocio.ItemClick
        fSocioNegocio.Show()

    End Sub

    Private Sub btnMarca_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarca.ItemClick
        Marca.Show()

    End Sub


    Private Sub btnCategoria_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCategoria.ItemClick
        Categorias.Show()

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProductos.ItemClick
        Productos.Show()

    End Sub

    Private Sub btnCompra_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCompra.ItemClick
        Compra.Show()

    End Sub

    Private Sub btnStock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStock.ItemClick
        CosultarStock.Show()

    End Sub

    Private Sub btnDx_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDx.ItemClick
        Rx.Show()

    End Sub

    Private Sub btnUsuarios_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUsuarios.ItemClick
        Usuario.Show()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class