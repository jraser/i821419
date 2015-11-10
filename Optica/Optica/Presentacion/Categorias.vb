Public Class Categorias
    Private dt As New DataTable
    Private dt1 As New DataTable
    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevo.Enabled = True
        btnCancelar.Enabled = True
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        cboCampo.SelectedIndex = 0
        mostrar()

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New CategoriaDAO

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

            Else
                Inexistente.Visible = True
                dgvCliente.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub limpiar()
        txtNumDoc.Text = ""
        txtId.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        DataGridView1.DataSource = Nothing

    End Sub

    Public Sub habilitar()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        GroupBox7.Enabled = False
    End Sub
    Private Sub ocultar_columnas()
        dgvCliente.Columns(1).Visible = False
    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        limpiar()
        habilitar()


    End Sub
    Private Sub txtNumDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumDoc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre de la Categoría, este dato es Obligatorio")
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

    Private Sub dgvCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellClick
        txtId.Text = dgvCliente.SelectedCells(1).Value
        txtNumDoc.Text = dgvCliente.SelectedCells(2).Value
        btnGuardar.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        GroupBox1.Enabled = True
        btnNuevo.Enabled = False
        GroupBox7.Enabled = True
        mostrar2()
        limpiar2()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNumDoc.Text <> "" Then
            Try
                Dim dts As New vCategoria
                Dim fun As New CategoriaDAO

                dts.gNombre_Categoria = txtNumDoc.Text
                dts.gEstado = "A"
                dts.gUsuarioCreacion = Inicio.Label2.Text
                dts.gFechaCreacion = DateTime.Now



                If fun.create(dts) Then
                    MessageBox.Show("Categoría registrada de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()

                Else
                    MessageBox.Show("La Categoría no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente deseas Editar los datos de la Categoría", "Modificando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            If Me.ValidateChildren = True And txtNumDoc.Text <> "" And txtId.Text <> "" Then
                Try
                    Dim dts As New vCategoria
                    Dim fun As New CategoriaDAO
                    dts.gID_Categorias = txtId.Text
                    dts.gNombre_Categoria = txtNumDoc.Text
                    dts.gUsuarioModificacion = Inicio.Label2.Text
                    dts.gFechaModificacion = DateTime.Now



                    If fun.update(dts) Then
                        MessageBox.Show("Categoría modificada de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        habilitar()

                    Else
                        MessageBox.Show("Categoría no se modifico de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente deseas Eliminar la Categoría", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            Try
                Dim dts As New vCategoria
                Dim fun As New CategoriaDAO

                dts.gID_Categorias = txtId.Text
                dts.gEstado = "I"
                dts.gUsuarioEliminacion = Inicio.Label2.Text
                dts.gFechaEliminacion = DateTime.Now



                If fun.delete(dts) Then
                    MessageBox.Show("Categoría eliminada de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()


                Else
                    MessageBox.Show("La Categoría no se elimino de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                    habilitar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub mostrar2()
        Try
            Dim dts As New vSubcategorias
            Dim func As New SubcategoriaDAO
            dts.gID_Categorias = txtId.Text
            dt1 = func.mostrar(dts)


            If dt1.Rows.Count <> 0 Then
                DataGridView1.DataSource = dt1
                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(1).Visible = False
                DataGridView1.ColumnHeadersVisible = True
                DataGridView1.Columns(2).Width = 250
            Else
                DataGridView1.DataSource = Nothing

                DataGridView1.ColumnHeadersVisible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub limpiar2()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre de la Subcategoría, este dato es Obligatorio")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.ValidateChildren = True And TextBox1.Text <> "" Then
            Try
                Dim dts As New vSubcategorias
                Dim fun As New SubcategoriaDAO

                dts.gID_Categorias = txtId.Text
                dts.gNombre_subcategoria = TextBox1.Text
                dts.gEstado = "A"
                dts.gUsuarioCreacion = Inicio.Label2.Text
                dts.gFechaCreacion = DateTime.Now



                If fun.create(dts) Then
                    MessageBox.Show("Subcategoría registrada de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar2()
                    limpiar2()


                Else
                    MessageBox.Show("La Subcategoría no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar2()


                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente deseas Eliminar la Subcategoría", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            Try
                Dim dts As New vSubcategorias
                Dim fun As New SubcategoriaDAO

                dts.gID_Subcategoria = TextBox2.Text
                dts.gEstado = "I"
                dts.gUsuarioEliminacion = Inicio.Label2.Text
                dts.gFechaEliminacion = DateTime.Now



                If fun.delete(dts) Then
                    MessageBox.Show("Subcategoría eliminada de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar2()
                    limpiar2()


                Else
                    MessageBox.Show("La Subcategoría no se elimino de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar2()
                    limpiar2()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox2.Text = DataGridView1.SelectedCells(0).Value
        TextBox1.Text = DataGridView1.SelectedCells(2).Value
    End Sub

    Private Sub dgvCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick

    End Sub
End Class