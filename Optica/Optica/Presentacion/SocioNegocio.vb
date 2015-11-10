Public Class fSocioNegocio

    Private dt As New DataTable
    Private dt1 As New DataTable
    Private dt2 As New DataTable
    Private dt3 As New DataTable
    Private dt4 As New DataTable
    Private dt5 As New DataTable
    Private dt6 As New DataTable

    Private Sub SocioNegocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevo.Enabled = True
        btnCancelar.Enabled = True
        btnGuardar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False

        cboCampo.SelectedIndex = 0
        mostrar()
        cargarConceptoTipoSocio()
        cargarSexo()
        ConceptoTipoPersona()
        ConceptoTipoDocumento()
        ConceptoTipoNacionalidad()

    End Sub

    Private Sub cargarConceptoTipoSocio()
        Dim conb As New Conceptos
        dt1 = conb.ConceptoTipoSocio

        With cboTipoSocio
            .DataSource = dt1
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub

    Private Sub cargarSexo()
        Dim conb As New Conceptos
        dt2 = conb.ConceptoSexo

        With cboSexo
            .DataSource = dt2
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub
    Private Sub ConceptoTipoPersona()
        Dim conb As New Conceptos
        dt3 = conb.ConceptoTipoPersona

        With cboRegimen
            .DataSource = dt3
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub
    Private Sub ConceptoTipoDocumento()
        Dim conb As New Conceptos
        dt4 = conb.ConceptoTipoDocumento

        With cboTipoDoc
            .DataSource = dt4
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub
    Private Sub ConceptoTipoNacionalidad()
        Dim conb As New Conceptos
        dt5 = conb.ConceptoTipoNacionalidad

        With cboNacionalidad
            .DataSource = dt5
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub
    Private Sub ConceptoTipoDocumentoNatu()
        Dim conb As New Conceptos
        dt6 = conb.ConceptoTipoDocumentoNatu

        With cboTipoDoc
            .DataSource = dt6
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub

    Public Sub limpiar()
        cboTipoSocio.SelectedIndex = 0
        cboRegimen.SelectedIndex = 0
        cboTipoDoc.SelectedIndex = 0
        txtNumDoc.Text = ""
        txtNombreSocio.Text = ""
        dtFechaNacimiento.Value = Now.Date
        cboSexo.SelectedIndex = 0
        cboNacionalidad.SelectedIndex = 0
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtId.Text = ""
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New SocioNegocioDAO
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
    Private Sub ocultar_columnas()
        dgvCliente.Columns(1).Visible = False
    End Sub


    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()

    End Sub




    Private Sub cboRegimen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRegimen.SelectedIndexChanged
        If cboRegimen.Text = "JURIDICA" Then
            ConceptoTipoDocumento()

            cboTipoDoc.SelectedIndex = 3
            cboTipoDoc.Enabled = False
            cboSexo.SelectedIndex = 0
            cboSexo.Enabled = False
            dtFechaNacimiento.Enabled = False

        Else
            ConceptoTipoDocumentoNatu()
            cboTipoDoc.Enabled = True
            cboSexo.Enabled = True
            dtFechaNacimiento.Enabled = True
        End If
    End Sub

    Private Sub cboRegimen_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboRegimen.Validating
        If DirectCast(sender, ComboBox).SelectedIndex > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Seleccione un Régimen, este dato es Obligatorio")
        End If
    End Sub

    Private Sub cboTipoSocio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboTipoSocio.Validating
        If DirectCast(sender, ComboBox).SelectedIndex > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Seleccione un tipo de Socio, este dato es Obligatorio")
        End If
    End Sub

    Private Sub cboTipoDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboTipoDoc.Validating
        If DirectCast(sender, ComboBox).SelectedIndex > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Seleccione un tipo de Documento, este dato es Obligatorio")
        End If
    End Sub


    'Private Sub cboSexo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboSexo.Validating
    '    If DirectCast(sender, ComboBox).SelectedIndex > 0 Then
    '        Me.ErrorIcono.SetError(sender, "")
    '    Else
    '        Me.ErrorIcono.SetError(sender, "Seleccione un Sexo, este dato es Obligatorio")
    '    End If
    'End Sub

    Private Sub cboNacionalidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboNacionalidad.Validating
        If DirectCast(sender, ComboBox).SelectedIndex > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Seleccione una Nacionalidad, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtNumDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumDoc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub txtNumDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumDoc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Num. de Documento, este dato es Obligatorio")
        End If
    End Sub


    Private Sub txtNombreSocio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNombreSocio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Nombre del Socio, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_Validated(sender As Object, e As EventArgs) Handles txtDireccion.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese la Dirección del Socio, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelefono_Validated(sender As Object, e As EventArgs) Handles txtTelefono.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Teléfono del Socio, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtEmail_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese wl E-mail del Socio, este dato es Obligatorio")
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.ValidateChildren = True And cboTipoSocio.SelectedIndex <> 0 And cboRegimen.SelectedIndex <> 0 And cboTipoDoc.SelectedIndex <> 0 And txtNumDoc.Text <> "" And txtNombreSocio.Text <> "" And cboNacionalidad.SelectedIndex <> 0 And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtEmail.Text <> "" Then
            Try
                Dim dts As New vSocioNegocio
                Dim fun As New SocioNegocioDAO
                dts.gTipo_Socio = cboTipoSocio.SelectedValue
                dts.gRegimen_Socio = cboRegimen.SelectedValue
                dts.gTipo_Documento = cboTipoDoc.SelectedValue
                dts.gNum_Documento = txtNumDoc.Text
                dts.gNombres_Socio = txtNombreSocio.Text
                dts.gFecha_Nacimiento = dtFechaNacimiento.Value
                dts.gSexo = cboSexo.SelectedValue
                dts.gOrigen_Socio = cboNacionalidad.SelectedValue
                dts.gDireccion_Socio = txtDireccion.Text
                dts.gTelefono = txtTelefono.Text
                dts.gEmail = txtEmail.Text
                dts.gEstado = "A"
                dts.gUsuarioCreacion = Inicio.Label2.Text
                dts.gFechaCreacion = DateTime.Now



                If fun.create(dts) Then
                    MessageBox.Show("Socio registrado de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()

                Else
                    MessageBox.Show("El Socio no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub cboCampo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCampo.SelectedIndexChanged
        txtBuscar.Text = ""
        mostrar()

    End Sub

    Private Sub dgvCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellClick
        txtId.Text = dgvCliente.SelectedCells(1).Value
        txtNombreSocio.Text = dgvCliente.SelectedCells(2).Value
        cboTipoSocio.Text = dgvCliente.SelectedCells(3).Value
        cboRegimen.Text = dgvCliente.SelectedCells(4).Value
        cboTipoDoc.Text = dgvCliente.SelectedCells(5).Value
        txtNumDoc.Text = dgvCliente.SelectedCells(6).Value
        dtFechaNacimiento.Value = dgvCliente.SelectedCells(7).Value
        cboSexo.Text = dgvCliente.SelectedCells(8).Value
        txtTelefono.Text = dgvCliente.SelectedCells(9).Value
        cboNacionalidad.Text = dgvCliente.SelectedCells(10).Value
        txtDireccion.Text = dgvCliente.SelectedCells(11).Value
        txtEmail.Text = dgvCliente.SelectedCells(12).Value
        btnGuardar.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        GroupBox1.Enabled = True
        btnNuevo.Enabled = False


    End Sub

    Private Sub dgvCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick
        If e.ColumnIndex = Me.dgvCliente.Columns.Item("Eliminar").Index Then
            Dim chcell As DataGridViewCheckBoxCell = Me.dgvCliente.Rows(e.RowIndex).Cells("Eliminar")
            chcell.Value = Not chcell.Value
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente deseas Editar los datos del Socio", "Modificando Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            If Me.ValidateChildren = True And cboTipoSocio.SelectedIndex <> 0 And cboRegimen.SelectedIndex <> 0 And cboTipoDoc.SelectedIndex <> 0 And txtNumDoc.Text <> "" And txtNombreSocio.Text <> "" And cboNacionalidad.SelectedIndex <> 0 And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtEmail.Text <> "" And txtId.Text <> "" Then
                Try
                    Dim dts As New vSocioNegocio
                    Dim fun As New SocioNegocioDAO
                    dts.gID_Socio = txtId.Text
                    dts.gTipo_Socio = cboTipoSocio.SelectedValue
                    dts.gRegimen_Socio = cboRegimen.SelectedValue
                    dts.gTipo_Documento = cboTipoDoc.SelectedValue
                    dts.gNum_Documento = txtNumDoc.Text
                    dts.gNombres_Socio = txtNombreSocio.Text
                    dts.gFecha_Nacimiento = dtFechaNacimiento.Value
                    dts.gSexo = cboSexo.SelectedValue
                    dts.gOrigen_Socio = cboNacionalidad.SelectedValue
                    dts.gDireccion_Socio = txtDireccion.Text
                    dts.gTelefono = txtTelefono.Text
                    dts.gEmail = txtEmail.Text
                    dts.gUsuarioModificacion = Inicio.Label2.Text
                    dts.gFechaModificacion = DateTime.Now



                    If fun.update(dts) Then
                        MessageBox.Show("Socio modificado de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        habilitar()

                    Else
                        MessageBox.Show("El Socio no se modifico de forma correcta", "Modificar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        result = MessageBox.Show("Realmente deseas Eliminar el Socio", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            Try
                Dim dts As New vSocioNegocio
                Dim fun As New SocioNegocioDAO
                dts.gID_Socio = txtId.Text
                dts.gEstado = "I"
                dts.gUsuarioEliminacion = Inicio.Label2.Text
                dts.gFechaEliminacion = DateTime.Now



                If fun.delete(dts) Then
                    MessageBox.Show("Socio eliminado de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    habilitar()


                Else
                    MessageBox.Show("El Socio no se elimino de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                    habilitar()

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
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


End Class