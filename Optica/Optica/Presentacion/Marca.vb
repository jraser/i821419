Public Class Marca

    Private dt As New DataTable
    Private Sub Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            Dim func As New MarcasDAO

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

    End Sub
    Public Sub habilitar()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
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
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre de la Marca, este dato es Obligatorio")
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


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And txtNumDoc.Text <> "" Then
            Try
                Dim dts As New vMarcas
                Dim fun As New MarcasDAO

                dts.gNombre_Marca = txtNumDoc.Text
                dts.gEstado = "A"
                dts.gUsuarioCreacion = Inicio.Label2.Text
                dts.gFechaCreacion = DateTime.Now



                If fun.create(dts) Then
                    MessageBox.Show("Marca registrado de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()

                Else
                    MessageBox.Show("La Marca no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente deseas Editar los datos de la Marca", "Modificando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            If Me.ValidateChildren = True And txtNumDoc.Text <> "" And txtId.Text <> "" Then
                Try
                    Dim dts As New vMarcas
                    Dim fun As New MarcasDAO
                    dts.gID_Marca = txtId.Text
                    dts.gNombre_Marca = txtNumDoc.Text
                    dts.gUsuarioModificacion = Inicio.Label2.Text
                    dts.gFechaModificacion = DateTime.Now



                    If fun.update(dts) Then
                        MessageBox.Show("Marca modificada de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        habilitar()

                    Else
                        MessageBox.Show("La Marca no se modifico de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente deseas Eliminar la Marca", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            Try
                Dim dts As New vMarcas
                Dim fun As New MarcasDAO

                dts.gID_Marca = txtId.Text
                dts.gEstado = "I"
                dts.gUsuarioEliminacion = Inicio.Label2.Text
                dts.gFechaEliminacion = DateTime.Now



                If fun.delete(dts) Then
                    MessageBox.Show("Marca eliminada de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()


                Else
                    MessageBox.Show("La Marca no se elimino de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                    habilitar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub cboCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCampo.SelectedIndexChanged

    End Sub
End Class