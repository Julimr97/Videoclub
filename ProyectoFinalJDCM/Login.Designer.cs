﻿namespace ProyectoFinalJDCM
{
    partial class Login
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbPwd = new System.Windows.Forms.TextBox();
            this.btAcceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(136, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(118, 137);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(64, 13);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(187, 107);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(267, 20);
            this.txbUsuario.TabIndex = 2;
            // 
            // txbPwd
            // 
            this.txbPwd.Location = new System.Drawing.Point(187, 134);
            this.txbPwd.Name = "txbPwd";
            this.txbPwd.Size = new System.Drawing.Size(267, 20);
            this.txbPwd.TabIndex = 3;
            // 
            // btAcceder
            // 
            this.btAcceder.Location = new System.Drawing.Point(258, 193);
            this.btAcceder.Name = "btAcceder";
            this.btAcceder.Size = new System.Drawing.Size(75, 23);
            this.btAcceder.TabIndex = 4;
            this.btAcceder.Text = "Acceder";
            this.btAcceder.UseVisualStyleBackColor = true;
            this.btAcceder.Click += new System.EventHandler(this.btAcceder_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 307);
            this.Controls.Add(this.btAcceder);
            this.Controls.Add(this.txbPwd);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbPwd;
        private System.Windows.Forms.Button btAcceder;
    }
}