namespace ProyectoLogin
{
    partial class frmConsultaBugs
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
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dptHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbAsignado = new System.Windows.Forms.ComboBox();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblAsignado = new System.Windows.Forms.Label();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.grdBugs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(90, 13);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // dptHasta
            // 
            this.dptHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptHasta.Location = new System.Drawing.Point(349, 13);
            this.dptHasta.Name = "dptHasta";
            this.dptHasta.Size = new System.Drawing.Size(137, 20);
            this.dptHasta.TabIndex = 1;
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(87, 89);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(151, 21);
            this.cmbPrioridad.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(87, 52);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(151, 21);
            this.cmbEstado.TabIndex = 4;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(87, 132);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(151, 21);
            this.cmbProducto.TabIndex = 5;
            // 
            // cmbAsignado
            // 
            this.cmbAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsignado.FormattingEnabled = true;
            this.cmbAsignado.Location = new System.Drawing.Point(349, 54);
            this.cmbAsignado.Name = "cmbAsignado";
            this.cmbAsignado.Size = new System.Drawing.Size(137, 21);
            this.cmbAsignado.TabIndex = 6;
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(349, 94);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(137, 21);
            this.cmbCriticidad.TabIndex = 7;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(13, 19);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 8;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(13, 55);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(13, 89);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(48, 13);
            this.lblPrioridad.TabIndex = 10;
            this.lblPrioridad.Text = "Prioridad";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(13, 134);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 11;
            this.lblProducto.Text = "Producto";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(257, 19);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 12;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblAsignado
            // 
            this.lblAsignado.AutoSize = true;
            this.lblAsignado.Location = new System.Drawing.Point(257, 55);
            this.lblAsignado.Name = "lblAsignado";
            this.lblAsignado.Size = new System.Drawing.Size(60, 13);
            this.lblAsignado.TabIndex = 13;
            this.lblAsignado.Text = "Asignado a";
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.AutoSize = true;
            this.lblCriticidad.Location = new System.Drawing.Point(257, 97);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(50, 13);
            this.lblCriticidad.TabIndex = 14;
            this.lblCriticidad.Text = "Criticidad";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(349, 129);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 15;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // grdBugs
            // 
            this.grdBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBugs.Location = new System.Drawing.Point(12, 176);
            this.grdBugs.Name = "grdBugs";
            this.grdBugs.Size = new System.Drawing.Size(519, 265);
            this.grdBugs.TabIndex = 16;
            // 
            // frmConsultaBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 453);
            this.Controls.Add(this.grdBugs);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.lblCriticidad);
            this.Controls.Add(this.lblAsignado);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaDesde);
            this.Controls.Add(this.cmbCriticidad);
            this.Controls.Add(this.cmbAsignado);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.dptHasta);
            this.Controls.Add(this.dtpDesde);
            this.Name = "frmConsultaBugs";
            this.Text = "frmConsultaBugs";
            ((System.ComponentModel.ISupportInitialize)(this.grdBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dptHasta;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbAsignado;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblAsignado;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.DataGridView grdBugs;
    }
}