namespace ProyectoLogin
{
    partial class frmBugs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBugs));
            this.cmdConsultaBugs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdConsultaBugs
            // 
            this.cmdConsultaBugs.Location = new System.Drawing.Point(304, 114);
            this.cmdConsultaBugs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdConsultaBugs.Name = "cmdConsultaBugs";
            this.cmdConsultaBugs.Size = new System.Drawing.Size(100, 28);
            this.cmdConsultaBugs.TabIndex = 0;
            this.cmdConsultaBugs.Text = "consultaBugs";
            this.cmdConsultaBugs.UseVisualStyleBackColor = true;
            this.cmdConsultaBugs.Click += new System.EventHandler(this.cmdConsultaBugs_Click);
            // 
            // frmBugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1143, 495);
            this.Controls.Add(this.cmdConsultaBugs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultaBugs;
    }
}

