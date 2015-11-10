Public Class AyudaProducto

    Private dt As New DataTable

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dgvCliente.Columns(13).Visible = False
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub
    Private Sub dgvCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellDoubleClick
        If TextBox1.Text = "1" Then
            Compra.txtIdProducto.Text = dgvCliente.SelectedCells.Item(1).Value
            Compra.txtProducto.Text = dgvCliente.SelectedCells.Item(4).Value
            Compra.txtPc.Text = dgvCliente.SelectedCells.Item(11).Value
            Me.Close()

        End If
    End Sub

    Private Sub dgvCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick

    End Sub
End Class