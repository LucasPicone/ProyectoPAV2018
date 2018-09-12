namespace ProyectoBOCHAS.GUI
{
    partial class frmModUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtModBuscar = new System.Windows.Forms.TextBox();
            this.cmdBscarUsuarioMod = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.txtPassModificar = new System.Windows.Forms.TextBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del usuario a modificar:";
            // 
            // txtModBuscar
            // 
            this.txtModBuscar.Location = new System.Drawing.Point(35, 35);
            this.txtModBuscar.Name = "txtModBuscar";
            this.txtModBuscar.Size = new System.Drawing.Size(352, 20);
            this.txtModBuscar.TabIndex = 2;
            // 
            // cmdBscarUsuarioMod
            // 
            this.cmdBscarUsuarioMod.Location = new System.Drawing.Point(35, 120);
            this.cmdBscarUsuarioMod.Name = "cmdBscarUsuarioMod";
            this.cmdBscarUsuarioMod.Size = new System.Drawing.Size(352, 23);
            this.cmdBscarUsuarioMod.TabIndex = 3;
            this.cmdBscarUsuarioMod.Text = "Buscar";
            this.cmdBscarUsuarioMod.UseVisualStyleBackColor = true;
            this.cmdBscarUsuarioMod.Click += new System.EventHandler(this.cmdBscarUsuarioMod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nuevo nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nueva contraseña: ";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Enabled = false;
            this.txtNuevoNombre.Location = new System.Drawing.Point(165, 172);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNuevoNombre.TabIndex = 8;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Enabled = false;
            this.txtNuevaPass.Location = new System.Drawing.Point(165, 198);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.PasswordChar = '*';
            this.txtNuevaPass.Size = new System.Drawing.Size(173, 20);
            this.txtNuevaPass.TabIndex = 9;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(35, 267);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(106, 43);
            this.cmdModificar.TabIndex = 10;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(148, 343);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(118, 43);
            this.cmdCancelar.TabIndex = 11;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtPassModificar
            // 
            this.txtPassModificar.Location = new System.Drawing.Point(35, 83);
            this.txtPassModificar.Name = "txtPassModificar";
            this.txtPassModificar.PasswordChar = '*';
            this.txtPassModificar.Size = new System.Drawing.Size(352, 20);
            this.txtPassModificar.TabIndex = 12;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(280, 268);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(107, 42);
            this.cmdEliminar.TabIndex = 13;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña del usuario a modificar:";
            // 
            // frmModUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.txtPassModificar);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.txtNuevaPass);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdBscarUsuarioMod);
            this.Controls.Add(this.txtModBuscar);
            this.Controls.Add(this.label1);
            this.Name = "frmModUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar datos de usuario";
            this.Load += new System.EventHandler(this.frmModUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModBuscar;
        private System.Windows.Forms.Button cmdBscarUsuarioMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtPassModificar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label label2;
    }
}