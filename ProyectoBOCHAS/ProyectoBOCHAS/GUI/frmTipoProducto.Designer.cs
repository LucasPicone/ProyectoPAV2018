namespace ProyectoBOCHAS
{
    partial class frmTipoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoProducto));
            this.dgvTipoProducto = new System.Windows.Forms.DataGridView();
            this.idTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdCargarTipoIni = new System.Windows.Forms.Button();
            this.cmdModElini = new System.Windows.Forms.Button();
            this.gbxCarga = new System.Windows.Forms.GroupBox();
            this.lblCarga = new System.Windows.Forms.Label();
            this.cmdCarga = new System.Windows.Forms.Button();
            this.txtCarga = new System.Windows.Forms.TextBox();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.gbxPrincipal = new System.Windows.Forms.GroupBox();
            this.gbxMod = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtMod2 = new System.Windows.Forms.TextBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblMod = new System.Windows.Forms.Label();
            this.cmdMod = new System.Windows.Forms.Button();
            this.txtMod = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProducto)).BeginInit();
            this.gbxCarga.SuspendLayout();
            this.gbxPrincipal.SuspendLayout();
            this.gbxMod.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTipoProducto
            // 
            this.dgvTipoProducto.AllowUserToAddRows = false;
            this.dgvTipoProducto.AllowUserToDeleteRows = false;
            this.dgvTipoProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoProducto,
            this.nombre});
            this.dgvTipoProducto.Location = new System.Drawing.Point(16, 15);
            this.dgvTipoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTipoProducto.Name = "dgvTipoProducto";
            this.dgvTipoProducto.RowHeadersVisible = false;
            this.dgvTipoProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoProducto.Size = new System.Drawing.Size(708, 146);
            this.dgvTipoProducto.TabIndex = 0;
            this.dgvTipoProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoProducto_CellContentClick);
            // 
            // idTipoProducto
            // 
            this.idTipoProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idTipoProducto.HeaderText = "# Tipo Producto";
            this.idTipoProducto.MinimumWidth = 50;
            this.idTipoProducto.Name = "idTipoProducto";
            this.idTipoProducto.Width = 127;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // cmdCargarTipoIni
            // 
            this.cmdCargarTipoIni.Location = new System.Drawing.Point(80, 43);
            this.cmdCargarTipoIni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCargarTipoIni.Name = "cmdCargarTipoIni";
            this.cmdCargarTipoIni.Size = new System.Drawing.Size(224, 48);
            this.cmdCargarTipoIni.TabIndex = 8;
            this.cmdCargarTipoIni.Text = "Cargar nuevo tipo de producto";
            this.cmdCargarTipoIni.UseVisualStyleBackColor = true;
            this.cmdCargarTipoIni.Click += new System.EventHandler(this.cmdCargarTipoIni_Click);
            // 
            // cmdModElini
            // 
            this.cmdModElini.Location = new System.Drawing.Point(387, 43);
            this.cmdModElini.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdModElini.Name = "cmdModElini";
            this.cmdModElini.Size = new System.Drawing.Size(241, 48);
            this.cmdModElini.TabIndex = 9;
            this.cmdModElini.Text = "Modificar/Eliminar tipo existente";
            this.cmdModElini.UseVisualStyleBackColor = true;
            this.cmdModElini.Click += new System.EventHandler(this.cmdModElini_Click);
            // 
            // gbxCarga
            // 
            this.gbxCarga.Controls.Add(this.lblCarga);
            this.gbxCarga.Controls.Add(this.cmdCarga);
            this.gbxCarga.Controls.Add(this.txtCarga);
            this.gbxCarga.Enabled = false;
            this.gbxCarga.Location = new System.Drawing.Point(16, 325);
            this.gbxCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCarga.Name = "gbxCarga";
            this.gbxCarga.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCarga.Size = new System.Drawing.Size(708, 161);
            this.gbxCarga.TabIndex = 11;
            this.gbxCarga.TabStop = false;
            // 
            // lblCarga
            // 
            this.lblCarga.AutoSize = true;
            this.lblCarga.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblCarga.Enabled = false;
            this.lblCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarga.Location = new System.Drawing.Point(187, 0);
            this.lblCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(251, 20);
            this.lblCarga.TabIndex = 13;
            this.lblCarga.Text = "Ingrese el nombre del nuevo tipo";
            // 
            // cmdCarga
            // 
            this.cmdCarga.Enabled = false;
            this.cmdCarga.Location = new System.Drawing.Point(241, 107);
            this.cmdCarga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCarga.Name = "cmdCarga";
            this.cmdCarga.Size = new System.Drawing.Size(211, 28);
            this.cmdCarga.TabIndex = 8;
            this.cmdCarga.Text = "Cargar producto";
            this.cmdCarga.UseVisualStyleBackColor = true;
            this.cmdCarga.Click += new System.EventHandler(this.cmdCarga_Click);
            // 
            // txtCarga
            // 
            this.txtCarga.Enabled = false;
            this.txtCarga.Location = new System.Drawing.Point(205, 54);
            this.txtCarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarga.Multiline = true;
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(281, 29);
            this.txtCarga.TabIndex = 7;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(201, 0);
            this.lblPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(243, 20);
            this.lblPrincipal.TabIndex = 12;
            this.lblPrincipal.Text = "Seleccione la accion a realizar:";
            // 
            // gbxPrincipal
            // 
            this.gbxPrincipal.Controls.Add(this.lblPrincipal);
            this.gbxPrincipal.Controls.Add(this.cmdCargarTipoIni);
            this.gbxPrincipal.Controls.Add(this.cmdModElini);
            this.gbxPrincipal.Location = new System.Drawing.Point(16, 186);
            this.gbxPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPrincipal.Name = "gbxPrincipal";
            this.gbxPrincipal.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxPrincipal.Size = new System.Drawing.Size(708, 108);
            this.gbxPrincipal.TabIndex = 13;
            this.gbxPrincipal.TabStop = false;
            // 
            // gbxMod
            // 
            this.gbxMod.Controls.Add(this.lbl2);
            this.gbxMod.Controls.Add(this.lbl1);
            this.gbxMod.Controls.Add(this.txtMod2);
            this.gbxMod.Controls.Add(this.cmdEliminar);
            this.gbxMod.Controls.Add(this.lblMod);
            this.gbxMod.Controls.Add(this.cmdMod);
            this.gbxMod.Controls.Add(this.txtMod);
            this.gbxMod.Enabled = false;
            this.gbxMod.Location = new System.Drawing.Point(16, 505);
            this.gbxMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxMod.Name = "gbxMod";
            this.gbxMod.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxMod.Size = new System.Drawing.Size(708, 181);
            this.gbxMod.TabIndex = 14;
            this.gbxMod.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Enabled = false;
            this.lbl2.Location = new System.Drawing.Point(97, 100);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(76, 17);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "Nuevo tipo";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Enabled = false;
            this.lbl1.Location = new System.Drawing.Point(51, 53);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(123, 17);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "Tipo seleccionado";
            // 
            // txtMod2
            // 
            this.txtMod2.Enabled = false;
            this.txtMod2.Location = new System.Drawing.Point(205, 96);
            this.txtMod2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMod2.Multiline = true;
            this.txtMod2.Name = "txtMod2";
            this.txtMod2.Size = new System.Drawing.Size(281, 29);
            this.txtMod2.TabIndex = 15;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(352, 145);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(136, 28);
            this.cmdEliminar.TabIndex = 14;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // lblMod
            // 
            this.lblMod.AutoSize = true;
            this.lblMod.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMod.Enabled = false;
            this.lblMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMod.Location = new System.Drawing.Point(141, 0);
            this.lblMod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMod.Name = "lblMod";
            this.lblMod.Size = new System.Drawing.Size(376, 20);
            this.lblMod.TabIndex = 13;
            this.lblMod.Text = "Seleccione un elemento de la lista para modificar";
            // 
            // cmdMod
            // 
            this.cmdMod.Enabled = false;
            this.cmdMod.Location = new System.Drawing.Point(205, 145);
            this.cmdMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdMod.Name = "cmdMod";
            this.cmdMod.Size = new System.Drawing.Size(124, 28);
            this.cmdMod.TabIndex = 8;
            this.cmdMod.Text = "Modificar";
            this.cmdMod.UseVisualStyleBackColor = true;
            this.cmdMod.Click += new System.EventHandler(this.cmdMod_Click);
            // 
            // txtMod
            // 
            this.txtMod.Enabled = false;
            this.txtMod.Location = new System.Drawing.Point(205, 49);
            this.txtMod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMod.Multiline = true;
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(281, 29);
            this.txtMod.TabIndex = 7;
            // 
            // frmTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 700);
            this.Controls.Add(this.gbxCarga);
            this.Controls.Add(this.dgvTipoProducto);
            this.Controls.Add(this.gbxPrincipal);
            this.Controls.Add(this.gbxMod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTipoProducto";
            this.Text = "frmTipoProducto";
            this.Load += new System.EventHandler(this.frmTipoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoProducto)).EndInit();
            this.gbxCarga.ResumeLayout(false);
            this.gbxCarga.PerformLayout();
            this.gbxPrincipal.ResumeLayout(false);
            this.gbxPrincipal.PerformLayout();
            this.gbxMod.ResumeLayout(false);
            this.gbxMod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.Button cmdCargarTipoIni;
        private System.Windows.Forms.Button cmdModElini;
        private System.Windows.Forms.GroupBox gbxCarga;
        private System.Windows.Forms.Button cmdCarga;
        private System.Windows.Forms.TextBox txtCarga;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.GroupBox gbxPrincipal;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.GroupBox gbxMod;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblMod;
        private System.Windows.Forms.Button cmdMod;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtMod2;
    }
}