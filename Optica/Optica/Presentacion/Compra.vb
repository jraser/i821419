
Public Class Compra

    Private dt As New DataTable
    Private dt1 As New DataTable
    Private dt2 As New DataTable
    Private dt3 As New DataTable
    Private dt4 As New DataTable

    Private Sub cargarConceptoTipoSocio()
        Dim conb As New Conceptos
        dt1 = conb.ConceptoTipDoc

        With cboTipoDoc
            .DataSource = dt1
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub
    Private Sub cargarIGV()
        Dim conb As New Conceptos
        dt2 = conb.ConceptoIGV

        With cboIGV
            .DataSource = dt2
            .DisplayMember = "Descripcion"
            .ValueMember = "Codigo"
        End With
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar()
        GroupBox1.Enabled = True
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnBusca.Enabled = False
        GroupBox2.Enabled = False
        lblMensaje.Visible = True

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles lblMensaje.Click

    End Sub

    Private Sub Compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMensaje.Visible = False
        dtFecha.Value = DateTime.Now
        cargarConceptoTipoSocio()
        cboTipoDoc.SelectedIndex = 0
        cargarIGV()
        cboIGV.SelectedIndex = 0
    End Sub

    Private Sub btnSocio_Click(sender As Object, e As EventArgs) Handles btnSocio.Click
        AyudaProveedor.TextBox1.Text = "1"
        AyudaProveedor.ShowDialog()
    End Sub

    Public Sub habilitar()
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        btnBusca.Enabled = True
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
    End Sub

    Public Sub limpiar()
        txtId.Text = ""
        dtFecha.Value = DateTime.Now
        cboTipoDoc.SelectedIndex = 0
        txtNumDoc.Text = ""
        txtCodSocio.Text = ""
        txtCodSocio.Text = ""
        txtIdProducto.Text = ""
        txtProducto.Text = ""
        txtPc.Text = "0.00"
        txtCantidad.Text = "0"
        txtMonto.Text = "0.00"
        txtSubtotal.Text = "0.00"
        txtIgv.Text = "0.00"
        txtTotal.Text = "0.00"
        txtSocio.Text = ""
        dgvCliente.DataSource = Nothing

        dgvCliente.ColumnHeadersVisible = False
        chkIgv.Checked = False

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        habilitar()
        lblMensaje.Visible = False
        limpiar()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtId.Text = "" Then
            If Me.ValidateChildren = True And cboTipoDoc.SelectedIndex <> 0 And cboTipoDoc.SelectedIndex <> 0 And txtNumDoc.Text <> "" And txtCodSocio.Text <> "" Then
                Try
                    Dim dts As New vCompra
                    Dim fun As New CompraDAO
                    dts.gFecha_Compra = dtFecha.Value
                    dts.gTipo_Doc = cboTipoDoc.SelectedValue
                    dts.gNum_Doc = txtNumDoc.Text
                    dts.gId_Socio = txtCodSocio.Text
                    dts.gsubtotal = txtSubtotal.Text
                    dts.gigv_valor = cboIGV.Text
                    dts.gigv = txtIgv.Text
                    dts.gtotal = txtIgv.Text
                    dts.gEstado = "A"
                    dts.gUsuarioCreacion = Inicio.Label2.Text
                    dts.gFechaCreacion = DateTime.Now



                    If fun.create(dts) Then
                        MessageBox.Show("Compra registrado de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        id()
                        GroupBox2.Enabled = True
                        lblMensaje.Visible = False


                    Else
                        MessageBox.Show("La Compra no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Else
            updatea()
            MessageBox.Show("La Compra se actualizo de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub updatea()
        Try
            Dim dts As New vCompra
            Dim fun As New CompraDAO
            dts.gId_Compra = txtId.Text
            dts.gFecha_Compra = dtFecha.Value
            dts.gTipo_Doc = cboTipoDoc.SelectedValue
            dts.gNum_Doc = txtNumDoc.Text
            dts.gId_Socio = txtCodSocio.Text
            dts.gsubtotal = txtSubtotal.Text
            dts.gigv_valor = cboIGV.Text
            dts.gigv = txtIgv.Text
            dts.gtotal = txtTotal.Text
            dts.gEstado = "A"
            dts.gUsuarioModificacion = Inicio.Label2.Text
            dts.gFechaModificacion = DateTime.Now



            If fun.update(dts) Then


            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub id()

        Try
            Dim dts As New vCompra
            Dim func As New CompraDAO
            dts.gNum_Doc = txtNumDoc.Text
            dts.gId_Socio = txtCodSocio.Text
            dts.gTipo_Doc = cboTipoDoc.SelectedValue
            dt3 = func.mostrarTipDoc(dts)


            With txtId
                .DataSource = dt3
                .DisplayMember = "id_Compra"
                .ValueMember = "id_Compra"
            End With


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub cboTipoDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cboTipoDoc.Validating
        If DirectCast(sender, ComboBox).SelectedIndex > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Seleccione un Tipo de Documento, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtNumDoc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNumDoc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Num. de Documento, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtSocio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtSocio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese un Socio, este dato es Obligatorio")
        End If
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        AyudaProducto.TextBox1.Text = "1"
        AyudaProducto.ShowDialog()
    End Sub

    Private Sub txtPc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPc.KeyPress
        NumConFrac(Me.txtPc, e)
    End Sub

    Private Sub txtPc_TextChanged(sender As Object, e As EventArgs) Handles txtPc.TextChanged
        txtMonto.Text = Val(txtPc.Text) * Val(txtCantidad.Text)
        txtMonto.Text = Format(Double.Parse(txtMonto.Text), "###,###,##0.00")
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        Else : e.Handled = True

        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        txtMonto.Text = Val(txtPc.Text) * Val(txtCantidad.Text)
        txtMonto.Text = Format(Double.Parse(txtMonto.Text), "###,###,##0.00")

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

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged

    End Sub

    Private Sub txtIdProducto_Validated(sender As Object, e As EventArgs) Handles txtIdProducto.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese un Producto, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtPc_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPc.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el Precio debe ser mayor de 0, este dato es Obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese una Cantidad, este dato es Obligatorio")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If Me.ValidateChildren = True And txtIdProducto.Text <> "" And txtPc.Text <> 0 And txtPc.Text <> 0 Then
            Try
                Dim dts As New vDetalleCompra
                Dim fun As New DetalleCompraDAO
                dts.gId_Compra = txtId.Text
                dts.gId_Producto = txtIdProducto.Text
                dts.gPC = txtPc.Text
                dts.gCantida = txtCantidad.Text
                dts.gMonto = txtMonto.Text
                dts.gEstado = "A"
                dts.gUsuarioCreacion = Inicio.Label2.Text
                dts.gFechaCreacion = DateTime.Now



                If fun.create(dts) Then
                    MessageBox.Show("Detalle registrado de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    buscarstock()
                    mostrar()
                    limpiar2()
                    cargarSubtoral()
                    updatea()

                Else
                    MessageBox.Show("El Detalle no se registro de forma correcta", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub limpiar2()
        txtIdProducto.Text = ""
        txtProducto.Text = ""
        txtPc.Text = "0.00"
        txtCantidad.Text = "0"
        txtMonto.Text = "0.00"
    End Sub

    Private Sub mostrar()
        Try
            Dim dts As New vDetalleCompra
            Dim func As New DetalleCompraDAO
            dts.gId_Compra = txtId.Text
            dt1 = func.mostrar(dts)


            If dt1.Rows.Count <> 0 Then
                dgvCliente.DataSource = dt1
                dgvCliente.Columns(0).Visible = False
                dgvCliente.Columns(1).Visible = False
                dgvCliente.Columns(2).Visible = False
                dgvCliente.ColumnHeadersVisible = True
                dgvCliente.Columns(4).Width = 220
            Else
                dgvCliente.DataSource = Nothing

                dgvCliente.ColumnHeadersVisible = False
                txtSubtotal.Text = "0.00"

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub cargarSubtoral()

        Try


            Dim dts As New vDetalleCompra
            Dim func As New DetalleCompraDAO
            dts.gId_Compra = txtId.Text
            dt4 = func.DetalleCompraSumaList(dts)

            If dt4.Rows.Count <> 0 Then

                With txtSubtotal
                    .DataSource = dt4
                    .DisplayMember = "MONTO"
                    .ValueMember = "MONTO"

                End With
                If txtSubtotal.Text = "" Then
                    txtSubtotal.Text = "0.00"
                End If
            Else
                txtSubtotal.Text = "0.00"
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub chkIgv_CheckedChanged(sender As Object, e As EventArgs) Handles chkIgv.CheckedChanged
        If chkIgv.Checked = True Then
            txtIgv.Text = Val(txtSubtotal.Text) * Val(Val(cboIGV.Text) / 100)
            'txtIgv.Text = Format(Double.Parse(txtIgv.Text), "###,###,##0.00")
            updatea()

        Else
            txtIgv.Text = "0.00"
            updatea()


        End If
    End Sub

    Private Sub txtIgv_TextChanged(sender As Object, e As EventArgs) Handles txtIgv.TextChanged
        txtTotal.Text = Val(txtSubtotal.Text) + Val(txtIgv.Text)
        txtTotal.Text = Format(Double.Parse(txtTotal.Text), "###,###,##0.00")
    End Sub

    Private Sub txtSubtotal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSubtotal.SelectedIndexChanged

    End Sub

    Private Sub txtSubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtSubtotal.TextChanged
        txtTotal.Text = Val(txtSubtotal.Text) + Val(txtIgv.Text)
        txtTotal.Text = Format(Double.Parse(txtTotal.Text), "###,###,##0.00")
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim result As DialogResult
        result = MessageBox.Show("Realmente deseas Eliminar el ¨Producto de la Compra", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = Windows.Forms.DialogResult.Yes Then


            Try
                Dim dts As New vDetalleCompra
                Dim fun As New DetalleCompraDAO
                dts.gId_DetalleCompra = dgvCliente.SelectedCells.Item(0).Value
                dts.gId_Compra = txtId.Text
                dts.gEstado = "I"
                dts.gUsuarioEliminacion = Inicio.Label2.Text
                dts.gFechaEliminacion = DateTime.Now



                If fun.delete(dts) Then
                    MessageBox.Show("Producto eliminado de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    stockresta()
                    mostrar()
                    limpiar2()
                    cargarSubtoral()
                    updatea()


                Else
                    MessageBox.Show("El Producto no se elimino de forma correcta", "Eliminar Registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar2()
                    cargarSubtoral()
                    updatea()


                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub




    Private Sub btnBusca_Click(sender As Object, e As EventArgs) Handles btnBusca.Click
        AyudaCompra.TextBox1.Text = "1"
        AyudaCompra.ShowDialog()
        If txtId.Text <> "" Then
            mostrar()
            btnNuevo.Enabled = False
            btnBusca.Enabled = False
            btnGuardar.Enabled = True
            btnCancelar.Enabled = True

            GroupBox1.Enabled = True
            GroupBox2.Enabled = True

        End If
    End Sub


    Private Sub buscarstock()
        Try
            Dim dts As New vStock
            Dim func As New StockDAO
            dts.gId_Producto = txtIdProducto.Text
            dt1 = func.StockXProductoList(dts)


            If dt1.Rows.Count = 0 Then
                agregarstock()

            Else
                stocksuma()


            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub




    Private Sub agregarstock()
        Try
            Dim dts As New vStock
            Dim fun As New StockDAO
            dts.gId_Producto = txtIdProducto.Text
            dts.gCantidad = txtCantidad.Text

            fun.create(dts)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub stocksuma()
        Try
            Dim dts As New vStock
            Dim fun As New StockDAO
            dts.gId_Producto = txtIdProducto.Text
            dts.gCantidad = txtCantidad.Text

            fun.StockSumaUpdate(dts)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub stockresta()
        Try
            Dim dts As New vStock
            Dim fun As New StockDAO
            dts.gId_Producto = dgvCliente.SelectedCells.Item(2).Value
            dts.gCantidad = dgvCliente.SelectedCells.Item(3).Value

            fun.StockRestaUpdate(dts)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class