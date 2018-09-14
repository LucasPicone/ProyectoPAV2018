namespace ProyectoBOCHAS
{
    partial class frmSocios
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
            this.dgvSocios = new System.Windows.Forms.DataGridView();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.idSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdHabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSocios
            // 
            this.dgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSocio,
            this.apellido,
            this.nombre,
            this.direccion,
            this.dni,
            this.fechaNacimiento});
            this.dgvSocios.Location = new System.Drawing.Point(13, 13);
            this.dgvSocios.Name = "dgvSocios";
            this.dgvSocios.RowHeadersVisible = false;
            this.dgvSocios.RowTemplate.Height = 24;
            this.dgvSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSocios.Size = new System.Drawing.Size(945, 150);
            this.dgvSocios.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(177, 177);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(117, 22);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(177, 205);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(177, 233);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(117, 22);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(177, 262);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(117, 22);
            this.txtDni.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(177, 300);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(117, 22);
            this.dtpFecha.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(90, 180);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 17);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido: (*)";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(90, 208);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre: (*)";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(81, 236);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(90, 17);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección: (*)";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(117, 262);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(54, 17);
            this.lblDni.TabIndex = 9;
            this.lblDni.Text = "DNI: (*)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(7, 300);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(164, 17);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha de Nacimiento: (*)";
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(311, 204);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(84, 37);
            this.cmdNuevo.TabIndex = 11;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(401, 204);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(84, 37);
            this.cmdCancelar.TabIndex = 12;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(311, 247);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(174, 37);
            this.cmdModificar.TabIndex = 13;
            this.cmdModificar.Text = "Modificar/Eliminar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
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
            // cmdHabilitar
            // 
            this.cmdHabilitar.Location = new System.Drawing.Point(491, 205);
            this.cmdHabilitar.Name = "cmdHabilitar";
            this.cmdHabilitar.Size = new System.Drawing.Size(174, 79);
            this.cmdHabilitar.TabIndex = 15;
            this.cmdHabilitar.Text = "Nueva Acción";
            this.cmdHabilitar.UseVisualStyleBackColor = true;
            this.cmdHabilitar.Click += new System.EventHandler(this.cmdHabilitar_Click);
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 367);
            this.Controls.Add(this.cmdHabilitar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.dgvSocios);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSocios";
            this.Text = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSocios;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.Button cmdHabilitar;
    }
}