Public Class CosultarStock

    Private dt As New DataTable

    Private Sub CosultarStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim func As New StockDAO

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
                dgvCliente.Columns(3).Width = 150
                dgvCliente.Columns(4).Width = 150
                dgvCliente.Columns(5).Width = 150
                dgvCliente.Columns(6).Width = 250
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
    End Sub




    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellDoubleClick
        VerImagen.ShowDialog()
    End Sub





    Private Sub dgvCliente_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCliente.CellFormatting
        e.CellStyle.SelectionBackColor = Color.Blue
        e.CellStyle.SelectionForeColor = Color.White
    End Sub

    Private Sub dgvCliente_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvCliente.CellPainting
        'If e.ColumnIndex = 0 Then
        '    e.CellStyle.BackColor = Color.CadetBlue
        'End If

        'If e.ColumnIndex = 2 Then
        '    e.CellStyle.BackColor = Color.Moccasin
        'End If

        'If e.ColumnIndex = 8 Then
        '    e.CellStyle.BackColor = Color.Black
        'End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        mostrar()

    End Sub

    Private Sub dgvCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCliente.CellContentClick

    End Sub
End Class