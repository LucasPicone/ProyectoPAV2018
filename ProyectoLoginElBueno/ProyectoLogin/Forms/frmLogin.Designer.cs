﻿namespace ProyectoLogin
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdIngresar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbLabsis = new System.Windows.Forms.Button();
            this.cmbCasa = new System.Windows.Forms.Button();
            this.lblBD = new System.Windows.Forms.Label();
            this.cbxAudio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(35, 27);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(8, 58);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(96, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(110, 24);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(130, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = 'E';
            this.txtPassword.Size = new System.Drawing.Size(130, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdIngresar.Location = new System.Drawing.Point(60, 91);
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(75, 23);
            this.cmdIngresar.TabIndex = 2;
            this.cmdIngresar.Text = "Ingresar";
            this.cmdIngresar.UseVisualStyleBackColor = false;
            this.cmdIngresar.Click += new System.EventHandler(this.cmdIngresar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cmdSalir.Location = new System.Drawing.Point(152, 91);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 3;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoLogin.Properties.Resources.Snow;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 186);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbLabsis
            // 
            this.cmbLabsis.Location = new System.Drawing.Point(84, 151);
            this.cmbLabsis.Name = "cmbLabsis";
            this.cmbLabsis.Size = new System.Drawing.Size(75, 23);
            this.cmbLabsis.TabIndex = 7;
            this.cmbLabsis.Text = "Labsis";
            this.cmbLabsis.UseVisualStyleBackColor = true;
            this.cmbLabsis.Click += new System.EventHandler(this.cmbLabsis_Click);
            // 
            // cmbCasa
            // 
            this.cmbCasa.Location = new System.Drawing.Point(165, 151);
            this.cmbCasa.Name = "cmbCasa";
            this.cmbCasa.Size = new System.Drawing.Size(75, 23);
            this.cmbCasa.TabIndex = 8;
            this.cmbCasa.Text = "Casa";
            this.cmbCasa.UseVisualStyleBackColor = true;
            this.cmbCasa.Click += new System.EventHandler(this.cmbCasa_Click);
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Location = new System.Drawing.Point(113, 126);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(127, 13);
            this.lblBD.TabIndex = 9;
            this.lblBD.Text = "Cambio de base de datos";
            // 
            // cbxAudio
            // 
            this.cbxAudio.AutoSize = true;
            this.cbxAudio.Location = new System.Drawing.Point(277, 157);
            this.cbxAudio.Name = "cbxAudio";
            this.cbxAudio.Size = new System.Drawing.Size(60, 17);
            this.cbxAudio.TabIndex = 10;
            this.cbxAudio.Text = "Musica";
            this.cbxAudio.UseVisualStyleBackColor = true;
            this.cbxAudio.CheckedChanged += new System.EventHandler(this.cbxAudio_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 186);
            this.Controls.Add(this.cbxAudio);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.cmbCasa);
            this.Controls.Add(this.cmbLabsis);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdIngresar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmbLabsis;
        private System.Windows.Forms.Button cmbCasa;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.CheckBox cbxAudio;
    }
}