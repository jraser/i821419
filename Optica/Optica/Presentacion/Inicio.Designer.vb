<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.RadialMenu1 = New DevExpress.XtraBars.Ribbon.RadialMenu(Me.components)
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.btnSocio = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProductos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarca = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCategoria = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDx = New DevExpress.XtraBars.BarButtonItem()
        Me.btnStock = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.btnCompra = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVenta = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ptbImagen = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadialMenu1
        '
        Me.RadialMenu1.AutoExpand = True
        Me.RadialMenu1.BackColor = System.Drawing.Color.White
        Me.RadialMenu1.BorderColor = System.Drawing.SystemColors.Highlight
        Me.RadialMenu1.Glyph = CType(resources.GetObject("RadialMenu1.Glyph"), System.Drawing.Image)
        Me.RadialMenu1.ItemAutoSize = DevExpress.XtraBars.Ribbon.RadialMenuItemAutoSize.Spring
        Me.RadialMenu1.ItemLinks.Add(Me.BarSubItem1)
        Me.RadialMenu1.ItemLinks.Add(Me.btnDx)
        Me.RadialMenu1.ItemLinks.Add(Me.btnStock)
        Me.RadialMenu1.ItemLinks.Add(Me.BarSubItem2)
        Me.RadialMenu1.MenuColor = System.Drawing.SystemColors.HotTrack
        Me.RadialMenu1.Name = "RadialMenu1"
        Me.RadialMenu1.Ribbon = Me.RibbonControl1
        Me.RadialMenu1.SubMenuHoverColor = System.Drawing.SystemColors.HotTrack
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Mantenimientos"
        Me.BarSubItem1.Glyph = CType(resources.GetObject("BarSubItem1.Glyph"), System.Drawing.Image)
        Me.BarSubItem1.Id = 1
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnSocio), New DevExpress.XtraBars.LinkPersistInfo(Me.btnProductos), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMarca), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCategoria), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUsuarios)})
        Me.BarSubItem1.Name = "BarSubItem1"
        Me.BarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnSocio
        '
        Me.btnSocio.Caption = "SocioNegocio"
        Me.btnSocio.Glyph = CType(resources.GetObject("btnSocio.Glyph"), System.Drawing.Image)
        Me.btnSocio.Id = 1
        Me.btnSocio.LargeGlyph = CType(resources.GetObject("btnSocio.LargeGlyph"), System.Drawing.Image)
        Me.btnSocio.Name = "btnSocio"
        '
        'btnProductos
        '
        Me.btnProductos.Caption = "Productos"
        Me.btnProductos.Glyph = CType(resources.GetObject("btnProductos.Glyph"), System.Drawing.Image)
        Me.btnProductos.Id = 3
        Me.btnProductos.LargeGlyph = CType(resources.GetObject("btnProductos.LargeGlyph"), System.Drawing.Image)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnMarca
        '
        Me.btnMarca.Caption = "Marcas"
        Me.btnMarca.Glyph = CType(resources.GetObject("btnMarca.Glyph"), System.Drawing.Image)
        Me.btnMarca.Id = 1
        Me.btnMarca.LargeGlyph = CType(resources.GetObject("btnMarca.LargeGlyph"), System.Drawing.Image)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnCategoria
        '
        Me.btnCategoria.Caption = "Categorias y Subcategorias"
        Me.btnCategoria.Glyph = CType(resources.GetObject("btnCategoria.Glyph"), System.Drawing.Image)
        Me.btnCategoria.Id = 2
        Me.btnCategoria.LargeGlyph = CType(resources.GetObject("btnCategoria.LargeGlyph"), System.Drawing.Image)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Caption = "Usuarios"
        Me.btnUsuarios.Glyph = CType(resources.GetObject("btnUsuarios.Glyph"), System.Drawing.Image)
        Me.btnUsuarios.Id = 1
        Me.btnUsuarios.Name = "btnUsuarios"
        '
        'btnDx
        '
        Me.btnDx.Caption = "Dx"
        Me.btnDx.Glyph = CType(resources.GetObject("btnDx.Glyph"), System.Drawing.Image)
        Me.btnDx.Id = 1
        Me.btnDx.Name = "btnDx"
        Me.btnDx.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnStock
        '
        Me.btnStock.Caption = "Consultar Stock"
        Me.btnStock.Glyph = CType(resources.GetObject("btnStock.Glyph"), System.Drawing.Image)
        Me.btnStock.Id = 3
        Me.btnStock.Name = "btnStock"
        Me.btnStock.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Movimientos"
        Me.BarSubItem2.Glyph = CType(resources.GetObject("BarSubItem2.Glyph"), System.Drawing.Image)
        Me.BarSubItem2.Id = 6
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnCompra), New DevExpress.XtraBars.LinkPersistInfo(Me.btnVenta)})
        Me.BarSubItem2.Name = "BarSubItem2"
        Me.BarSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnCompra
        '
        Me.btnCompra.Caption = "Compra"
        Me.btnCompra.Glyph = CType(resources.GetObject("btnCompra.Glyph"), System.Drawing.Image)
        Me.btnCompra.Id = 9
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btnVenta
        '
        Me.btnVenta.Caption = "Venta"
        Me.btnVenta.Glyph = CType(resources.GetObject("btnVenta.Glyph"), System.Drawing.Image)
        Me.btnVenta.Id = 10
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.BarSubItem1, Me.btnSocio, Me.btnMarca, Me.btnCategoria, Me.btnProductos, Me.btnDx, Me.btnStock, Me.BarSubItem2, Me.btnCompra, Me.btnVenta, Me.btnUsuarios})
        Me.RibbonControl1.Location = New System.Drawing.Point(-4, 4)
        Me.RibbonControl1.MaxItemId = 2
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Size = New System.Drawing.Size(10, 47)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above
        Me.RibbonControl1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(60, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Admin"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(198, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(19, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Optica.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(5, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblNombre.Location = New System.Drawing.Point(5, 263)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(212, 21)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "jr"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(5, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "as"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbImagen
        '
        Me.ptbImagen.BackColor = System.Drawing.Color.Transparent
        Me.ptbImagen.BackgroundImage = Global.Optica.My.Resources.Resources.file
        Me.ptbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbImagen.Location = New System.Drawing.Point(45, 105)
        Me.ptbImagen.Name = "ptbImagen"
        Me.ptbImagen.Size = New System.Drawing.Size(134, 149)
        Me.ptbImagen.TabIndex = 45
        Me.ptbImagen.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(102, 373)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Admin"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Optica.My.Resources.Resources.abstract_blue_background_vector_graphic_1_148034
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(227, 321)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ptbImagen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(1000, 100)
        Me.Name = "Inicio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inicio"
        CType(Me.RadialMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadialMenu1 As DevExpress.XtraBars.Ribbon.RadialMenu
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnSocio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMarca As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCategoria As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProductos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDx As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnStock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnCompra As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVenta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ptbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
