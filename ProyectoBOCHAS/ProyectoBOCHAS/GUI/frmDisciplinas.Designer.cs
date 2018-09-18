namespace ProyectoBOCHAS
{
    partial class frmDisciplinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisciplinas));
            this.dgvDisciplinas = new System.Windows.Forms.DataGridView();
            this.idDisciplinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdCategorias = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdHabilitar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisciplinas
            // 
            this.dgvDisciplinas.AllowUserToAddRows = false;
            this.dgvDisciplinas.AllowUserToDeleteRows = false;
            this.dgvDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDisciplinas,
            this.nombre,
            this.precioCuota});
            this.dgvDisciplinas.Location = new System.Drawing.Point(13, 13);
            this.dgvDisciplinas.Name = "dgvDisciplinas";
            this.dgvDisciplinas.RowHeadersVisible = false;
            this.dgvDisciplinas.RowTemplate.Height = 24;
            this.dgvDisciplinas.Size = new System.Drawing.Size(448, 140);
            this.dgvDisciplinas.TabIndex = 0;
            // 
            // idDisciplinas
            // 
            this.idDisciplinas.HeaderText = "# Disciplinas";
            this.idDisciplinas.Name = "idDisciplinas";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // precioCuota
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precioCuota.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioCuota.HeaderText = "Precio de la Cuota";
            this.precioCuota.Name = "precioCuota";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 188);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: (*)";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(103, 185);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Location = new System.Drawing.Point(13, 216);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(84, 54);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio de la cuota basica: (*)";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(103, 232);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 22);
            this.txtPrecio.TabIndex = 4;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(260, 184);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(89, 32);
            this.cmdNuevo.TabIndex = 5;
            this.cmdNuevo.Text = "Nuevo";
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.cmdNuevo_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(260, 222);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(89, 32);
            this.cmdModificar.TabIndex = 6;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(355, 184);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(89, 32);
            this.cmdEliminar.TabIndex = 7;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdCategorias
            // 
            this.cmdCategorias.Location = new System.Drawing.Point(473, 180);
            this.cmdCategorias.Name = "cmdCategorias";
            this.cmdCategorias.Size = new System.Drawing.Size(89, 32);
            this.cmdCategorias.TabIndex = 8;
            this.cmdCategorias.Text = "Categorias";
            this.cmdCategorias.UseVisualStyleBackColor = true;
            this.cmdCategorias.Click += new System.EventHandler(this.cmdCategorias_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(355, 222);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(89, 32);
            this.cmdCancelar.TabIndex = 9;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdHabilitar
            // 
            this.cmdHabilitar.Location = new System.Drawing.Point(260, 184);
            this.cmdHabilitar.Name = "cmdHabilitar";
            this.cmdHabilitar.Size = new System.Drawing.Size(184, 70);
            this.cmdHabilitar.TabIndex = 10;
            this.cmdHabilitar.Text = "Nueva acción";
            this.cmdHabilitar.UseVisualStyleBackColor = true;
            this.cmdHabilitar.Click += new System.EventHandler(this.cmdHabilitar_Click);
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 365);
            this.Controls.Add(this.cmdHabilitar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdCategorias);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDisciplinas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDisciplinas";
            this.Text = "Disciplinas";
            this.Load += new System.EventHandler(this.frmDisciplinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisciplinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDisciplinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCuota;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdCategorias;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdHabilitar;
    }
}