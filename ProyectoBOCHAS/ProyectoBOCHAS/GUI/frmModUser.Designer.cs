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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModUser));
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
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del usuario a modificar:";
            // 
            // txtModBuscar
            // 
            this.txtModBuscar.Location = new System.Drawing.Point(47, 43);
            this.txtModBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModBuscar.Name = "txtModBuscar";
            this.txtModBuscar.Size = new System.Drawing.Size(468, 22);
            this.txtModBuscar.TabIndex = 2;
            // 
            // cmdBscarUsuarioMod
            // 
            this.cmdBscarUsuarioMod.Location = new System.Drawing.Point(47, 148);
            this.cmdBscarUsuarioMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdBscarUsuarioMod.Name = "cmdBscarUsuarioMod";
            this.cmdBscarUsuarioMod.Size = new System.Drawing.Size(469, 28);
            this.cmdBscarUsuarioMod.TabIndex = 3;
            this.cmdBscarUsuarioMod.Text = "Buscar";
            this.cmdBscarUsuarioMod.UseVisualStyleBackColor = true;
            this.cmdBscarUsuarioMod.Click += new System.EventHandler(this.cmdBscarUsuarioMod_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nuevo nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nueva contraseña: ";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Enabled = false;
            this.txtNuevoNombre.Location = new System.Drawing.Point(220, 212);
            this.txtNuevoNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(229, 22);
            this.txtNuevoNombre.TabIndex = 8;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Enabled = false;
            this.txtNuevaPass.Location = new System.Drawing.Point(220, 244);
            this.txtNuevaPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.PasswordChar = '*';
            this.txtNuevaPass.Size = new System.Drawing.Size(229, 22);
            this.txtNuevaPass.TabIndex = 9;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(47, 329);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(141, 53);
            this.cmdModificar.TabIndex = 10;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(197, 422);
            this.cmdCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(157, 53);
            this.cmdCancelar.TabIndex = 11;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // txtPassModificar
            // 
            this.txtPassModificar.Location = new System.Drawing.Point(47, 102);
            this.txtPassModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassModificar.Name = "txtPassModificar";
            this.txtPassModificar.PasswordChar = '*';
            this.txtPassModificar.Size = new System.Drawing.Size(468, 22);
            this.txtPassModificar.TabIndex = 12;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(373, 330);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(143, 52);
            this.cmdEliminar.TabIndex = 13;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Contraseña del usuario a modificar:";
            // 
            // frmModUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 492);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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