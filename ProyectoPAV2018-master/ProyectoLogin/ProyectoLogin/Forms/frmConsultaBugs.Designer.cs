namespace ProyectoLogin
{
    partial class frmConsultaBugs
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
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbAsignado = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblAsignado = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCriticiadad = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.grdBugs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(16, 12);
            this.lblFechaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(94, 17);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Fecha  desde";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(393, 12);
            this.lblFechaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(86, 17);
            this.lblFechaHasta.TabIndex = 1;
            this.lblFechaHasta.Text = "Fecha hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(127, 12);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(160, 22);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(512, 12);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(160, 22);
            this.dtpFechaHasta.TabIndex = 7;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(127, 54);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEstado.Size = new System.Drawing.Size(160, 24);
            this.cmbEstado.TabIndex = 8;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(127, 148);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbProducto.Size = new System.Drawing.Size(160, 24);
            this.cmbProducto.TabIndex = 9;
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(512, 103);
            this.cmbCriticidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCriticidad.Size = new System.Drawing.Size(160, 24);
            this.cmbCriticidad.TabIndex = 10;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(127, 103);
            this.cmbPrioridad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPrioridad.Size = new System.Drawing.Size(160, 24);
            this.cmbPrioridad.TabIndex = 11;
            // 
            // cmbAsignado
            // 
            this.cmbAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignado.FormattingEnabled = true;
            this.cmbAsignado.Location = new System.Drawing.Point(512, 54);
            this.cmbAsignado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAsignado.Name = "cmbAsignado";
            this.cmbAsignado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAsignado.Size = new System.Drawing.Size(160, 24);
            this.cmbAsignado.TabIndex = 12;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(512, 148);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(161, 37);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblAsignado
            // 
            this.lblAsignado.AutoSize = true;
            this.lblAsignado.Location = new System.Drawing.Point(401, 64);
            this.lblAsignado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignado.Name = "lblAsignado";
            this.lblAsignado.Size = new System.Drawing.Size(79, 17);
            this.lblAsignado.TabIndex = 14;
            this.lblAsignado.Text = "Asignado a";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(16, 151);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(65, 17);
            this.lblProducto.TabIndex = 15;
            this.lblProducto.Text = "Producto";
            // 
            // lblCriticiadad
            // 
            this.lblCriticiadad.AutoSize = true;
            this.lblCriticiadad.Location = new System.Drawing.Point(401, 107);
            this.lblCriticiadad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriticiadad.Name = "lblCriticiadad";
            this.lblCriticiadad.Size = new System.Drawing.Size(66, 17);
            this.lblCriticiadad.TabIndex = 16;
            this.lblCriticiadad.Text = "Criticidad";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(16, 107);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(65, 17);
            this.lblPrioridad.TabIndex = 17;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 64);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado";
            // 
            // grdBugs
            // 
            this.grdBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBugs.Location = new System.Drawing.Point(20, 223);
            this.grdBugs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdBugs.Name = "grdBugs";
            this.grdBugs.Size = new System.Drawing.Size(953, 315);
            this.grdBugs.TabIndex = 19;
            // 
            // frmConsultaBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 553);
            this.Controls.Add(this.grdBugs);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblCriticiadad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblAsignado);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmbAsignado);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.cmbCriticidad);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblFechaDesde);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaBugs";
            this.Text = "Consulta Bugs";
            this.Load += new System.EventHandler(this.frmConsultaBugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbAsignado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblAsignado;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCriticiadad;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView grdBugs;
    }
}

