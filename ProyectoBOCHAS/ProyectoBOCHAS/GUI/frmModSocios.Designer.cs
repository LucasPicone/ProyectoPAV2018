namespace ProyectoBOCHAS
{
    partial class frmModSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModSocios));
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsableTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.txtApellidoNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdTelefono = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtTelefonoNuevo = new System.Windows.Forms.TextBox();
            this.txtResponsableNuevo = new System.Windows.Forms.TextBox();
            this.lblNuevoTelefono = new System.Windows.Forms.Label();
            this.lblResponsableNuevo = new System.Windows.Forms.Label();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdEliminarTelefono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(98, 15);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(98, 71);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 22);
            this.txtDni.TabIndex = 2;
            // 
            // dgvSocios
            // 
            this.dgvSocios.AllowUserToAddRows = false;
            this.dgvSocios.AllowUserToDeleteRows = false;
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.apellido,
            this.nombre,
            this.direccion,
            this.dni,
            this.fechaNacimiento,
            this.nroTelefono,
            this.responsableTelefono});
            this.dgvSocios.Location = new System.Drawing.Point(11, 108);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.RowHeadersVisible = false;
            this.dgvSocios.RowTemplate.Height = 24;
            this.dgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocios.Size = new System.Drawing.Size(1118, 150);
            this.dgvSocios.TabIndex = 3;
            this.dgvSocios.SelectionChanged += new System.EventHandler(this.dgvSocios_SelectionChanged);
            // 
            // idSocio
            // 
            this.idSocio.HeaderText = "# Socio";
            this.idSocio.Name = "idSocio";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // dni
            // 
            this.dni.HeaderText = "Documento";
            this.dni.Name = "dni";
            // 
            // fechaNacimiento
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fechaNacimiento.DefaultCellStyle = dataGridViewCellStyle1;
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            // 
            // nroTelefono
            // 
            this.nroTelefono.HeaderText = "Telefono";
            this.nroTelefono.Name = "nroTelefono";
            // 
            // responsableTelefono
            // 
            this.responsableTelefono.HeaderText = "Responsable";
            this.responsableTelefono.Name = "responsableTelefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 18);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(62, 17);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(8, 74);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(84, 17);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "Documento:";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Location = new System.Drawing.Point(216, 37);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(75, 34);
            this.cmdBuscar.TabIndex = 7;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // txtApellidoNuevo
            // 
            this.txtApellidoNuevo.Enabled = false;
            this.txtApellidoNuevo.Location = new System.Drawing.Point(122, 264);
            this.txtApellidoNuevo.Name = "txtApellidoNuevo";
            this.txtApellidoNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtApellidoNuevo.TabIndex = 8;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Enabled = false;
            this.txtNombreNuevo.Location = new System.Drawing.Point(122, 293);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtNombreNuevo.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(122, 322);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(122, 351);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(35, 267);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(81, 17);
            this.lblApellido1.TabIndex = 12;
            this.lblApellido1.Text = "Apellido: (*)";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(35, 296);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(81, 17);
            this.lblNombre1.TabIndex = 13;
            this.lblNombre1.Text = "Nombre: (*)";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(45, 325);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 17);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(48, 354);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 17);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono:";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(258, 267);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(80, 48);
            this.cmdModificar.TabIndex = 16;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(258, 321);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(80, 48);
            this.cmdEliminar.TabIndex = 17;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdTelefono
            // 
            this.cmdTelefono.Enabled = false;
            this.cmdTelefono.Location = new System.Drawing.Point(352, 267);
            this.cmdTelefono.Name = "cmdTelefono";
            this.cmdTelefono.Size = new System.Drawing.Size(80, 48);
            this.cmdTelefono.TabIndex = 18;
            this.cmdTelefono.Text = "Agregar Telefono";
            this.cmdTelefono.UseVisualStyleBackColor = true;
            this.cmdTelefono.Click += new System.EventHandler(this.cmdTelefono_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Enabled = false;
            this.cmdCancelar.Location = new System.Drawing.Point(258, 375);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(80, 48);
            this.cmdCancelar.TabIndex = 19;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Enabled = false;
            this.txtResponsable.Location = new System.Drawing.Point(122, 380);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(100, 22);
            this.txtResponsable.TabIndex = 20;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(21, 383);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(95, 17);
            this.lblResponsable.TabIndex = 21;
            this.lblResponsable.Text = "Responsable:";
            // 
            // txtTelefonoNuevo
            // 
            this.txtTelefonoNuevo.Location = new System.Drawing.Point(543, 264);
            this.txtTelefonoNuevo.Name = "txtTelefonoNuevo";
            this.txtTelefonoNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtTelefonoNuevo.TabIndex = 22;
            this.txtTelefonoNuevo.Visible = false;
            // 
            // txtResponsableNuevo
            // 
            this.txtResponsableNuevo.Location = new System.Drawing.Point(543, 293);
            this.txtResponsableNuevo.Name = "txtResponsableNuevo";
            this.txtResponsableNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtResponsableNuevo.TabIndex = 23;
            this.txtResponsableNuevo.Visible = false;
            // 
            // lblNuevoTelefono
            // 
            this.lblNuevoTelefono.AutoSize = true;
            this.lblNuevoTelefono.Location = new System.Drawing.Point(469, 267);
            this.lblNuevoTelefono.Name = "lblNuevoTelefono";
            this.lblNuevoTelefono.Size = new System.Drawing.Size(68, 17);
            this.lblNuevoTelefono.TabIndex = 24;
            this.lblNuevoTelefono.Text = "Telefono:";
            this.lblNuevoTelefono.Visible = false;
            // 
            // lblResponsableNuevo
            // 
            this.lblResponsableNuevo.AutoSize = true;
            this.lblResponsableNuevo.Location = new System.Drawing.Point(442, 296);
            this.lblResponsableNuevo.Name = "lblResponsableNuevo";
            this.lblResponsableNuevo.Size = new System.Drawing.Size(95, 17);
            this.lblResponsableNuevo.TabIndex = 25;
            this.lblResponsableNuevo.Text = "Responsable:";
            this.lblResponsableNuevo.Visible = false;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(553, 325);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(80, 48);
            this.cmdAgregar.TabIndex = 26;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Visible = false;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdEliminarTelefono
            // 
            this.cmdEliminarTelefono.Enabled = false;
            this.cmdEliminarTelefono.Location = new System.Drawing.Point(352, 321);
            this.cmdEliminarTelefono.Name = "cmdEliminarTelefono";
            this.cmdEliminarTelefono.Size = new System.Drawing.Size(80, 48);
            this.cmdEliminarTelefono.TabIndex = 27;
            this.cmdEliminarTelefono.Text = "Eliminar Telefono";
            this.cmdEliminarTelefono.UseVisualStyleBackColor = true;
            this.cmdEliminarTelefono.Click += new System.EventHandler(this.cmdEliminarTelefono_Click);
            // 
            // frmModSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 449);
            this.Controls.Add(this.cmdEliminarTelefono);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.lblResponsableNuevo);
            this.Controls.Add(this.lblNuevoTelefono);
            this.Controls.Add(this.txtResponsableNuevo);
            this.Controls.Add(this.txtTelefonoNuevo);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdTelefono);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre1);
            this.Controls.Add(this.lblApellido1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreNuevo);
            this.Controls.Add(this.txtApellidoNuevo);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.dgvSocios);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModSocios";
            this.Text = "Modificación de Socios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsableTelefono;
        private System.Windows.Forms.TextBox txtApellidoNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdTelefono;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtTelefonoNuevo;
        private System.Windows.Forms.TextBox txtResponsableNuevo;
        private System.Windows.Forms.Label lblNuevoTelefono;
        private System.Windows.Forms.Label lblResponsableNuevo;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdEliminarTelefono;
    }
}