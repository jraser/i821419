Public Class Usuario

    Private dt As New DataTable

    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ptbImagen.Image = Nothing
        ptbImagen.BackgroundImage = My.Resources.file
        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New UsuarioDAO
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
                dgvCliente.Columns(2).Width = 250
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
        dgvCliente.Columns(7).Visible = False
    End Sub
    Public Sub limpiar()
        txtNombre.Text = ""
        txtUsuario.Text = ""
        txtBuscar.Text = ""
        txtContraseña.Text = ""
        txtPuesto.Text = ""
        cboCampo.SelectedIndex = 0
        txtId.Text = ""
        ptbImagen.Image = Nothing
        ptbImagen.BackgroundImage = My.Resources.file
        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre del Producto, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre del Producto, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre del Producto, este dato es Obligatorio")
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
        If Me.ValidateChildren = True And txtNombre.Text <> "" And txtUsuario.Text <> "" And txtContraseña.Text <> "" Then
            Try
                Dim dts As New vUsuarios
                Dim fun As New UsuarioDAO

                dts.gUsuarioLogin = txtNombre.Text
                dts.gUsuario = txtUsuario.Text
                dts.gContraseña = txtContraseña.Text
                dts.gPuesto = txtPuesto.Text

                Dim ms As New IO.MemoryStream
                If Not ptbImagen.Image Is Nothing Then
                    ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                Else
                    ptbImagen.Image = My.Resources.file
                    ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                End If

                dts.gimagen = ms.GetBuffer

                dts.gAcceso = "1"




                If fun.create(dts) Then
                    MessageBox.Show("Usuario registrado de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()

                Else
                    MessageBox.Show("El Usuario no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente deseas Editar los datos del Usuario", "Modificando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then
            If Me.ValidateChildren = True And txtNombre.Text <> "" And txtUsuario.Text <> "" And txtContraseña.Text <> "" Then
                Try

                    Dim dts As New vUsuarios
                    Dim fun As New UsuarioDAO

                    dts.gIdLogin = txtId.Text
                    dts.gUsuarioLogin = txtNombre.Text
                    dts.gUsuario = txtUsuario.Text
                    dts.gContraseña = txtContraseña.Text
                    dts.gPuesto = txtPuesto.Text

                    Dim ms As New IO.MemoryStream
                    If Not ptbImagen.Image Is Nothing Then
                        ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                    Else
                        ptbImagen.Image = My.Resources.file
                        ptbImagen.Image.Save(ms, ptbImagen.Image.RawFormat)
                    End If

                    dts.gimagen = ms.GetBuffer

                    dts.gAcceso = "1"




                    If fun.update(dts) Then
                        MessageBox.Show("Usuario modificado de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        habilitar()

                    Else
                        MessageBox.Show("El Usuario no se modifico de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente deseas Eliminar el Usuario", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            Try
                Dim dts As New vUsuarios
                Dim fun As New UsuarioDAO
                dts.gIdLogin = txtId.Text



                If fun.delete(dts) Then
                    MessageBox.Show("Usuario eliminado de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()


                Else
                    MessageBox.Show("El Usuario no se elimino de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        txtNombre.Text = dgvCliente.SelectedCells(2).Value
        txtUsuario.Text = dgvCliente.SelectedCells(3).Value
        txtContraseña.Text = dgvCliente.SelectedCells(4).Value
        txtPuesto.Text = dgvCliente.SelectedCells(5).Value
        ptbImagen.BackgroundImage = Nothing
        Dim b() As Byte = dgvCliente.SelectedCells.Item(6).Value
        Dim ms As New IO.MemoryStream(b)

        ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage

        btnGuardar.Enabled = False
        ptbImagen.Image = Image.FromStream(ms)
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        GroupBox1.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ptbImagen.BackgroundImage = Nothing
            ptbImagen.Image = New Bitmap(dlg.FileName)
            ptbImagen.SizeMode = PictureBoxSizeMode.StretchImage

        End If
    End Sub

    Private Sub txtPuesto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPuesto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre del Producto, este dato es Obligatorio")
        End If
    End Sub
End Class