﻿namespace ProyectoBOCHAS
{
    partial class frmCategorias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.lblEdadDesde = new System.Windows.Forms.Label();
            this.cmbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblEdadHasta = new System.Windows.Forms.Label();
            this.txtEdadTope = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtEdadInicial = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.idDisciplina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevaAccion = new System.Windows.Forms.Button();
            this.lblPrecioInscripcion = new System.Windows.Forms.Label();
            this.txtPrecioInscripcion = new System.Windows.Forms.TextBox();
            this.lblPrecioCuota = new System.Windows.Forms.Label();
            this.txtPrecioCuota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(12, 9);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 0;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Location = new System.Drawing.Point(12, 35);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Categoria";
            // 
            // lblEdadDesde
            // 
            this.lblEdadDesde.AutoSize = true;
            this.lblEdadDesde.Location = new System.Drawing.Point(12, 62);
            this.lblEdadDesde.Name = "lblEdadDesde";
            this.lblEdadDesde.Size = new System.Drawing.Size(61, 13);
            this.lblEdadDesde.TabIndex = 2;
            this.lblEdadDesde.Text = "Edad inicial";
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.Location = new System.Drawing.Point(95, 6);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.Size = new System.Drawing.Size(231, 21);
            this.cmbDisciplina.TabIndex = 3;
            // 
            // lblEdadHasta
            // 
            this.lblEdadHasta.AutoSize = true;
            this.lblEdadHasta.Location = new System.Drawing.Point(12, 88);
            this.lblEdadHasta.Name = "lblEdadHasta";
            this.lblEdadHasta.Size = new System.Drawing.Size(59, 13);
            this.lblEdadHasta.TabIndex = 4;
            this.lblEdadHasta.Text = "Edad tope ";
            // 
            // txtEdadTope
            // 
            this.txtEdadTope.Location = new System.Drawing.Point(95, 85);
            this.txtEdadTope.Name = "txtEdadTope";
            this.txtEdadTope.Size = new System.Drawing.Size(40, 20);
            this.txtEdadTope.TabIndex = 5;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(95, 32);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(231, 20);
            this.txtCategoria.TabIndex = 6;
            // 
            // txtEdadInicial
            // 
            this.txtEdadInicial.Location = new System.Drawing.Point(95, 59);
            this.txtEdadInicial.Name = "txtEdadInicial";
            this.txtEdadInicial.Size = new System.Drawing.Size(40, 20);
            this.txtEdadInicial.TabIndex = 7;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(176, 132);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 51);
            this.btnConsultar.TabIndex = 9;
            this.btnConsultar.Text = "Consultar categorias";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(176, 196);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 51);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar categoria";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(95, 196);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 51);
            this.btnAñadir.TabIndex = 11;
            this.btnAñadir.Text = "Añadir categoria";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(257, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 51);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar categoria";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDisciplina,
            this.idCategoria,
            this.nombre,
            this.edadDesde,
            this.edadHasta,
            this.precioCuota,
            this.precioInscripcion});
            this.dgvCategorias.Location = new System.Drawing.Point(349, 6);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(700, 177);
            this.dgvCategorias.TabIndex = 8;
            // 
            // idDisciplina
            // 
            this.idDisciplina.HeaderText = "# Disciplina";
            this.idDisciplina.Name = "idDisciplina";
            // 
            // idCategoria
            // 
            this.idCategoria.HeaderText = "# Categoria";
            this.idCategoria.Name = "idCategoria";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // edadDesde
            // 
            this.edadDesde.HeaderText = "Edad Desde";
            this.edadDesde.Name = "edadDesde";
            // 
            // edadHasta
            // 
            this.edadHasta.HeaderText = "Edad Hasta";
            this.edadHasta.Name = "edadHasta";
            // 
            // precioCuota
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precioCuota.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioCuota.HeaderText = "Precio de la cuota";
            this.precioCuota.Name = "precioCuota";
            // 
            // precioInscripcion
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.precioInscripcion.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioInscripcion.HeaderText = "Precio de la inscripción";
            this.precioInscripcion.Name = "precioInscripcion";
            // 
            // btnNuevaAccion
            // 
            this.btnNuevaAccion.Location = new System.Drawing.Point(257, 132);
            this.btnNuevaAccion.Name = "btnNuevaAccion";
            this.btnNuevaAccion.Size = new System.Drawing.Size(75, 51);
            this.btnNuevaAccion.TabIndex = 14;
            this.btnNuevaAccion.Text = "Nueva Accion";
            this.btnNuevaAccion.UseVisualStyleBackColor = true;
            this.btnNuevaAccion.Click += new System.EventHandler(this.btnNuevaAccion_Click);
            // 
            // lblPrecioInscripcion
            // 
            this.lblPrecioInscripcion.AutoSize = true;
            this.lblPrecioInscripcion.Location = new System.Drawing.Point(148, 63);
            this.lblPrecioInscripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioInscripcion.Name = "lblPrecioInscripcion";
            this.lblPrecioInscripcion.Size = new System.Drawing.Size(74, 13);
            this.lblPrecioInscripcion.TabIndex = 15;
            this.lblPrecioInscripcion.Text = "Inscripción: (*)";
            // 
            // txtPrecioInscripcion
            // 
            this.txtPrecioInscripcion.Location = new System.Drawing.Point(226, 63);
            this.txtPrecioInscripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioInscripcion.Name = "txtPrecioInscripcion";
            this.txtPrecioInscripcion.Size = new System.Drawing.Size(76, 20);
            this.txtPrecioInscripcion.TabIndex = 16;
            // 
            // lblPrecioCuota
            // 
            this.lblPrecioCuota.AutoSize = true;
            this.lblPrecioCuota.Location = new System.Drawing.Point(150, 87);
            this.lblPrecioCuota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioCuota.Name = "lblPrecioCuota";
            this.lblPrecioCuota.Size = new System.Drawing.Size(51, 13);
            this.lblPrecioCuota.TabIndex = 17;
            this.lblPrecioCuota.Text = "Cuota: (*)";
            // 
            // txtPrecioCuota
            // 
            this.txtPrecioCuota.Location = new System.Drawing.Point(226, 88);
            this.txtPrecioCuota.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCuota.Name = "txtPrecioCuota";
            this.txtPrecioCuota.Size = new System.Drawing.Size(76, 20);
            this.txtPrecioCuota.TabIndex = 18;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 263);
            this.Controls.Add(this.txtPrecioCuota);
            this.Controls.Add(this.lblPrecioCuota);
            this.Controls.Add(this.txtPrecioInscripcion);
            this.Controls.Add(this.lblPrecioInscripcion);
            this.Controls.Add(this.btnNuevaAccion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.txtEdadInicial);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtEdadTope);
            this.Controls.Add(this.lblEdadHasta);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.lblEdadDesde);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.lblDisciplina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Label lblEdadDesde;
        private System.Windows.Forms.Label lblEdadHasta;
        private System.Windows.Forms.TextBox txtEdadTope;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtEdadInicial;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.ComboBox cmbDisciplina;
        private System.Windows.Forms.Button btnNuevaAccion;
        private System.Windows.Forms.Label lblPrecioInscripcion;
        private System.Windows.Forms.TextBox txtPrecioInscripcion;
        private System.Windows.Forms.Label lblPrecioCuota;
        private System.Windows.Forms.TextBox txtPrecioCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDisciplina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioInscripcion;
    }
}