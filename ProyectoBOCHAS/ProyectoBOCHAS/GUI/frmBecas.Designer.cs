namespace ProyectoBOCHAS
{
    partial class frmBecas
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
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.idBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmdNueva = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdHabilitar = new System.Windows.Forms.Button();
            this.txtInstrucciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBecas
            // 
            this.dgvBecas.AllowUserToAddRows = false;
            this.dgvBecas.AllowUserToDeleteRows = false;
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBeca,
            this.nombre,
            this.descripcion});
            this.dgvBecas.Location = new System.Drawing.Point(25, 42);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.RowHeadersVisible = false;
            this.dgvBecas.RowTemplate.Height = 24;
            this.dgvBecas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBecas.Size = new System.Drawing.Size(647, 125);
            this.dgvBecas.TabIndex = 0;
            this.dgvBecas.SelectionChanged += new System.EventHandler(this.dgvBecas_SelectionChanged);
            // 
            // idBeca
            // 
            this.idBeca.HeaderText = "# Beca";
            this.idBeca.Name = "idBeca";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Beca";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 111;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 227);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre: (*)";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 272);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 17);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(112, 224);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(113, 269);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(254, 88);
            this.txtDescripcion.TabIndex = 5;
            // 
            // cmdNueva
            // 
            this.cmdNueva.Location = new System.Drawing.Point(389, 227);
            this.cmdNueva.Name = "cmdNueva";
            this.cmdNueva.Size = new System.Drawing.Size(82, 31);
            this.cmdNueva.TabIndex = 6;
            this.cmdNueva.Text = "Nueva";
            this.cmdNueva.UseVisualStyleBackColor = true;
            this.cmdNueva.Visible = false;
            this.cmdNueva.Click += new System.EventHandler(this.cmdNueva_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(389, 277);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(82, 31);
            this.cmdModificar.TabIndex = 7;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Visible = false;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(389, 324);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(82, 31);
            this.cmdCancelar.TabIndex = 8;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Visible = false;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(491, 227);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(82, 30);
            this.cmdEliminar.TabIndex = 9;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Visible = false;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdHabilitar
            // 
            this.cmdHabilitar.Location = new System.Drawing.Point(389, 228);
            this.cmdHabilitar.Name = "cmdHabilitar";
            this.cmdHabilitar.Size = new System.Drawing.Size(184, 128);
            this.cmdHabilitar.TabIndex = 10;
            this.cmdHabilitar.Text = "Nueva acción";
            this.cmdHabilitar.UseVisualStyleBackColor = true;
            this.cmdHabilitar.Click += new System.EventHandler(this.cmdHabilitar_Click);
            // 
            // txtInstrucciones
            // 
            this.txtInstrucciones.AutoSize = true;
            this.txtInstrucciones.Location = new System.Drawing.Point(12, 194);
            this.txtInstrucciones.Name = "txtInstrucciones";
            this.txtInstrucciones.Size = new System.Drawing.Size(616, 17);
            this.txtInstrucciones.TabIndex = 11;
            this.txtInstrucciones.Text = "Cargue los campos abajo para agregar beca o seleccione una de la lista para modif" +
    "icar/eliminar.";
            this.txtInstrucciones.Visible = false;
            // 
            // frmBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 378);
            this.Controls.Add(this.txtInstrucciones);
            this.Controls.Add(this.cmdHabilitar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNueva);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvBecas);
            this.Name = "frmBecas";
            this.Text = "frmBecas";
            this.Load += new System.EventHandler(this.frmBecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button cmdNueva;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdHabilitar;
        private System.Windows.Forms.Label txtInstrucciones;
    }
}