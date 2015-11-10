Public Class AyudaCliente
    Private dt As New DataTable
    Private Sub AyudaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCampo.SelectedIndex = 0
        mostrar()
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New SocioNegocioDAO
            dt = func.SocioNegocioClienteList
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
                dgvCliente.Columns(2).Width = 300
                dgvCliente.Columns(3).Width = 100
                dgvCliente.Columns(4).Width = 100
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

    Private Sub dgvCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick

    End Sub

    Private Sub dgvCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellDoubleClick
        If TextBox1.Text = "1" Then
            Rx.TextBox1.Text = dgvCliente.SelectedCells.Item(1).Value
            Rx.txtNombreS.Text = dgvCliente.SelectedCells.Item(2).Value
            Rx.txtNumDoc.Text = dgvCliente.SelectedCells.Item(3).Value
            Rx.dtFechaNacimiento.Text = dgvCliente.SelectedCells.Item(4).Value
            Rx.txtEdad.Text = dgvCliente.SelectedCells.Item(5).Value
            Rx.txtSexo.Text = dgvCliente.SelectedCells.Item(6).Value
            Me.Close()

        End If
    End Sub
End Class