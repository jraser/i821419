Public Class Productos

    Private dt As New DataTable
    Private dt2 As New DataTable




    Private Sub subcat()

        Try
            Dim dts As New vSubcategorias
            Dim func As New SubcategoriaDAO
            dts.gID_Categorias = txtCodCategoria.Text
            dt2 = func.mostrar(dts)


            If dt2.Rows.Count <> 0 Then
                With cboSubCategoria
                    .DataSource = dt2
                    .DisplayMember = "CATEGORIAS"
                    .ValueMember = "Id_subcategoria"
                End With
            Else
                cboSubCategoria.ValueMember = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ptbImagen.BackgroundImage = Nothing
            ptbImagen.Image = New Bitmap(dlg.FileName)
            ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ptbImagen.Image = Nothing
        ptbImagen.BackgroundImage = My.Resources.file
        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevo.Enabled = True
        btnCancelar.Enabled = True
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        With Me.dgvCliente
            'Para definir el alto de la fila, depende de ustedes.
            .RowTemplate.Height = 60
            .RowTemplate.MinimumHeight = 20
            'le damos colores a las filas, alternamos
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            'Evitamos que se agregue la última fila(Fila vacía)
            .AllowUserToAddRows = False
            .EnableHeadersVisualStyles = False
        End With
        cboCampo.SelectedIndex = 0
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New ProductoDAO
            dt = func.mostrar
            dgvCliente.Columns.Item("Eliminar").Visible = False


            If dt.Rows.Count <> 0 Then
                dgvCliente.DataSource = dt
                txtBuscar.Enabled = True
                dgvCliente.ColumnHeadersVisible = True
                Inexistente.Visible = False
            Else
                dgvCliente.DataSource = Nothing
                txtBuscar.Enabled = False
                dgvCliente.ColumnHeadersVisible = False
                Inexistente.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


        buscar()
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = cboCampo.Text & " like '" & txtBuscar.Text & "%'"


            If dv.Count <> 0 Then
                Inexistente.Visible = False
                dgvCliente.DataSource = dv
                ocultar_columnas()
                dgvCliente.Columns(4).Width = 250
                For i As Integer = 0 To dgvCliente.Columns.Count - 1
                    If TypeOf dgvCliente.Columns(i) Is DataGridViewImageColumn Then
                        DirectCast(dgvCliente.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
                    End If
                Next

            Else
                Inexistente.Visible = True
                dgvCliente.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas()
        dgvCliente.Columns(1).Visible = False
        dgvCliente.Columns(2).Visible = False
        dgvCliente.Columns(3).Visible = False
        dgvCliente.Columns(5).Visible = False
        dgvCliente.Columns(7).Visible = False
        dgvCliente.Columns(9).Visible = False
        'dgvCliente.Columns(13).Visible = False
    End Sub

    Public Sub limpiar()
        txtCodPro.Text = ""
        txtLote.Text = ""
        txtNombre.Text = ""
        txtCodMarca.Text = ""
        txtMarca.Text = ""
        txtCategoria.Text = ""
        txtPC.Text = "0"
        txtPV.Text = "0"
        txtCodCategoria.Text = ""

        cboSubCategoria.DataSource = Nothing

        cboCampo.SelectedIndex = 0
        txtId.Text = ""
        ptbImagen.Image = Nothing
        ptbImagen.BackgroundImage = My.Resources.file
        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub txtCodPro_TextChanged(sender As Object, e As EventArgs) Handles txtCodPro.TextChanged

    End Sub






    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre del Producto, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtCodMarca_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCodMarca.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Marca del Producto, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtCategoria_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCategoria.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Categoría del Producto, este dato es Obligatorio")
        End If
    End Sub



    Private Sub txtPC_Validated(sender As Object, e As EventArgs) Handles txtPC.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el PC del Producto, este dato es Obligatorio")
        End If
    End Sub



    Private Sub txtPV_VisibleChanged(sender As Object, e As EventArgs) Handles txtPV.VisibleChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el PV del Producto, este dato es Obligatorio")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        GroupBox1.Enabled = True
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        mostrar()
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        habilitar()
    End Sub
    Public Sub habilitar()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtMarca.Text <> "" And txtCodCategoria.Text <> "" And txtPC.Text <> "" And txtPC.Text <> "0" And txtPV.Text <> "" And txtPV.Text <> "0" Then
            Try
                Dim dts As New vProductos
                Dim fun As New ProductoDAO

                dts.gCodigo_Producto = txtCodPro.Text
                dts.gLote_Producto = txtLote.Text
                dts.gNombre_Producto = txtNombre.Text
                dts.gId_Marca = txtCodMarca.Text
                dts.gId_Categorias = txtCodCategoria.Text
                dts.gId_Subcategoria = cboSubCategoria.SelectedValue
                dts.gPC_Producto = txtPC.Text
                dts.gPV_Producto = txtPV.Text

                Dim ms As New IO.MemoryStream
                If Not ptbImagen.Image Is Nothing Then
                    ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                Else
                    ptbImagen.Image = My.Resources.file
                    ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                End If

                dts.gImagen_Producto = ms.GetBuffer

                dts.gEstado = "A"
                dts.gUsuarioCreacion = Inicio.Label2.Text
                dts.gFechaCreacion = DateTime.Now



                If fun.create(dts) Then
                    MessageBox.Show("Producto registrado de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()

                Else
                    MessageBox.Show("El Producto no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                    habilitar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub txtCodCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtCodCategoria.TextChanged

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente deseas Editar los datos del Producto", "Modificando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then
            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtMarca.Text <> "" And txtCodCategoria.Text <> "" And txtPC.Text <> "" And txtPC.Text <> "0" And txtPV.Text <> "" And txtPV.Text <> "0" Then
                Try

                    Dim dts As New vProductos
                    Dim fun As New ProductoDAO

                    dts.gId_Producto = txtId.Text
                    dts.gCodigo_Producto = txtCodPro.Text
                    dts.gLote_Producto = txtLote.Text
                    dts.gNombre_Producto = txtNombre.Text
                    dts.gId_Marca = txtCodMarca.Text
                    dts.gId_Categorias = txtCodCategoria.Text
                    dts.gId_Subcategoria = cboSubCategoria.SelectedValue
                    dts.gPC_Producto = txtPC.Text
                    dts.gPV_Producto = txtPV.Text

                    Dim ms As New IO.MemoryStream
                    If Not ptbImagen.Image Is Nothing Then
                        ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                    Else
                        ptbImagen.Image = My.Resources.file
                        ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                    End If

                    dts.gImagen_Producto = ms.GetBuffer
                    dts.gUsuarioModificacion = Inicio.Label2.Text
                    dts.gFechaModificacion = DateTime.Now



                    If fun.update(dts) Then
                        MessageBox.Show("Producto modificado de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        habilitar()

                    Else
                        MessageBox.Show("El Producto no se modifico de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                        habilitar()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente deseas Eliminar el Producto", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            Try
                Dim dts As New vProductos
                Dim fun As New ProductoDAO
                dts.gId_Producto = txtId.Text
                dts.gEstado = "I"
                dts.gUsuarioEliminacion = Inicio.Label2.Text
                dts.gFechaEliminacion = DateTime.Now



                If fun.delete(dts) Then
                    MessageBox.Show("Producto eliminado de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()


                Else
                    MessageBox.Show("El Producto no se elimino de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                    habilitar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub dgvCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellClick
        txtId.Text = dgvCliente.SelectedCells(1).Value
        txtCodPro.Text = dgvCliente.SelectedCells(2).Value
        txtLote.Text = dgvCliente.SelectedCells(3).Value
        txtNombre.Text = dgvCliente.SelectedCells(4).Value
        txtCodMarca.Text = dgvCliente.SelectedCells(5).Value
        txtMarca.Text = dgvCliente.SelectedCells(6).Value
        txtCodCategoria.Text = dgvCliente.SelectedCells(7).Value
        txtCategoria.Text = dgvCliente.SelectedCells(8).Value

        subcat()


        cboSubCategoria.Text = dgvCliente.SelectedCells(10).Value
        txtPC.Text = dgvCliente.SelectedCells(11).Value
        txtPV.Text = dgvCliente.SelectedCells(12).Value

        ptbImagen.BackgroundImage = Nothing
        Dim b() As Byte = dgvCliente.SelectedCells.Item(13).Value
        Dim ms As New IO.MemoryStream(b)

        ptbImagen.Image = Image.FromStream(ms)
        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage

        btnGuardar.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        GroupBox1.Enabled = True
        btnNuevo.Enabled = False

    End Sub

    Private Sub dgvCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick

    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        AyudaMarca.TextBox1.Text = "1"
        AyudaMarca.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AyudaCategoria.TextBox1.Text = "1"
        AyudaCategoria.ShowDialog()
        subcat()

    End Sub

Public Sub NumConFrac(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs) 
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPC.KeyPress
        NumConFrac(Me.txtPC, e)
    End Sub

    Private Sub txtPV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPV.KeyPress
        NumConFrac(Me.txtPV, e)
    End Sub

    Private Sub txtPC_TextChanged(sender As Object, e As EventArgs) Handles txtPC.TextChanged

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
End Class