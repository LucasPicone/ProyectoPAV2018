namespace transaccion
{
    partial class frmPedidos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.lblNroPedido = new System.Windows.Forms.Label();
            this.txtNroCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.cmdBuscarArticulo = new System.Windows.Forms.Button();
            this.txtNroArticulo = new System.Windows.Forms.TextBox();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdBuscar2 = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(60, 13);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(81, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(60, 40);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(32, 20);
            this.txtSucursal.TabIndex = 2;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(6, 43);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(48, 13);
            this.lblSucursal.TabIndex = 3;
            this.lblSucursal.Text = "Sucursal";
            // 
            // txtNroPedido
            // 
            this.txtNroPedido.Location = new System.Drawing.Point(164, 40);
            this.txtNroPedido.Name = "txtNroPedido";
            this.txtNroPedido.Size = new System.Drawing.Size(100, 20);
            this.txtNroPedido.TabIndex = 4;
            // 
            // lblNroPedido
            // 
            this.lblNroPedido.AutoSize = true;
            this.lblNroPedido.Location = new System.Drawing.Point(98, 43);
            this.lblNroPedido.Name = "lblNroPedido";
            this.lblNroPedido.Size = new System.Drawing.Size(60, 13);
            this.lblNroPedido.TabIndex = 5;
            this.lblNroPedido.Text = "Nro Pedido";
            // 
            // txtNroCliente
            // 
            this.txtNroCliente.Location = new System.Drawing.Point(60, 67);
            this.txtNroCliente.Name = "txtNroCliente";
            this.txtNroCliente.Size = new System.Drawing.Size(32, 20);
            this.txtNroCliente.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 73);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(105, 68);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(28, 19);
            this.cmdBuscar.TabIndex = 8;
            this.cmdBuscar.Text = "...";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(140, 68);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(124, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.cmdAgregar);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.txtArticulo);
            this.groupBox1.Controls.Add(this.cmdBuscarArticulo);
            this.groupBox1.Controls.Add(this.txtNroArticulo);
            this.groupBox1.Controls.Add(this.lblArticulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 233);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cantidad,
            this.id,
            this.articulo,
            this.precio,
            this.subtotal});
            this.dgv.Location = new System.Drawing.Point(7, 81);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(505, 143);
            this.dgv.TabIndex = 18;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // articulo
            // 
            this.articulo.HeaderText = "Articulo";
            this.articulo.Name = "articulo";
            // 
            // precio
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // subtotal
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(429, 42);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 17;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(307, 42);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(269, 50);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(162, 49);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 14;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(127, 53);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(66, 50);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(55, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(10, 50);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(141, 17);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtArticulo.TabIndex = 10;
            // 
            // cmdBuscarArticulo
            // 
            this.cmdBuscarArticulo.Location = new System.Drawing.Point(106, 19);
            this.cmdBuscarArticulo.Name = "cmdBuscarArticulo";
            this.cmdBuscarArticulo.Size = new System.Drawing.Size(28, 19);
            this.cmdBuscarArticulo.TabIndex = 9;
            this.cmdBuscarArticulo.Text = "...";
            this.cmdBuscarArticulo.UseVisualStyleBackColor = true;
            this.cmdBuscarArticulo.Click += new System.EventHandler(this.cmdBuscarArticulo_Click);
            // 
            // txtNroArticulo
            // 
            this.txtNroArticulo.Location = new System.Drawing.Point(56, 20);
            this.txtNroArticulo.Name = "txtNroArticulo";
            this.txtNroArticulo.Size = new System.Drawing.Size(40, 20);
            this.txtNroArticulo.TabIndex = 1;
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(7, 20);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(42, 13);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Articulo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdSalir);
            this.groupBox2.Controls.Add(this.cmdGrabar);
            this.groupBox2.Controls.Add(this.cmdCancelar);
            this.groupBox2.Controls.Add(this.cmdBuscar2);
            this.groupBox2.Controls.Add(this.cmdNuevo);
            this.groupBox2.Location = new System.Drawing.Point(16, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 98);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(230, 19);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(46, 19);
            this.cmdSalir.TabIndex = 13;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(160, 19);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(48, 19);
            this.cmdGrabar.TabIndex = 12;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(111, 44);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(68, 27);
            this.cmdCancelar.TabIndex = 11;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdBuscar2
            // 
            this.cmdBuscar2.Location = new System.Drawing.Point(67, 19);
            this.cmdBuscar2.Name = "cmdBuscar2";
            this.cmdBuscar2.Size = new System.Drawing.Size(53, 19);
            this.cmdBuscar2.TabIndex = 10;
            this.cmdBuscar2.Text = "Buscar";
            this.cmdBuscar2.UseVisualStyleBackColor = true;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(6, 19);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(55, 19);
            this.cmdNuevo.TabIndex = 9;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(392, 361);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 12;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(392, 387);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 13;
            this.txtDescuento.Text = "0";
            // 
            // txtTotal2
            // 
            this.txtTotal2.Location = new System.Drawing.Point(392, 413);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.Size = new System.Drawing.Size(100, 20);
            this.txtTotal2.TabIndex = 14;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(337, 364);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 15;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(327, 390);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 16;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblTotal2
            // 
            this.lblTotal2.AutoSize = true;
            this.lblTotal2.Location = new System.Drawing.Point(352, 416);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(31, 13);
            this.lblTotal2.TabIndex = 17;
            this.lblTotal2.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::transaccion.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(284, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::transaccion.Properties.Resources.descarga;
            this.pictureBox2.Location = new System.Drawing.Point(383, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 534);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotal2);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.txtTotal2);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtNroCliente);
            this.Controls.Add(this.lblNroPedido);
            this.Controls.Add(this.txtNroPedido);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "frmPedidos";
            this.Text = "Orden de Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtNroPedido;
        private System.Windows.Forms.Label lblNroPedido;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button cmdBuscarArticulo;
        private System.Windows.Forms.TextBox txtNroArticulo;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdBuscar2;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;

    }
}

