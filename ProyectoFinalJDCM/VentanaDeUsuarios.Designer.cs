namespace ProyectoFinalJDCM
{
    partial class VentanaDeUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDeUsuarios));
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPSW = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPSW = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(483, 201);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(225, 20);
            this.textBoxDNI.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(483, 227);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(225, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(483, 253);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(225, 20);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 86);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(410, 201);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 4;
            this.labelDNI.Text = "DNI";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(483, 280);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(225, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // textBoxPSW
            // 
            this.textBoxPSW.Location = new System.Drawing.Point(483, 307);
            this.textBoxPSW.Name = "textBoxPSW";
            this.textBoxPSW.Size = new System.Drawing.Size(225, 20);
            this.textBoxPSW.TabIndex = 6;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(410, 227);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(413, 253);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 8;
            this.labelApellidos.Text = "Apellidos";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(413, 280);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // labelPSW
            // 
            this.labelPSW.AutoSize = true;
            this.labelPSW.Location = new System.Drawing.Point(413, 307);
            this.labelPSW.Name = "labelPSW";
            this.labelPSW.Size = new System.Drawing.Size(53, 13);
            this.labelPSW.TabIndex = 10;
            this.labelPSW.Text = "Password";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(538, 353);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(170, 23);
            this.buttonRegistrar.TabIndex = 11;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // VentanaDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.labelPSW);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxPSW);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Name = "VentanaDeUsuarios";
            this.Text = "GestorDeUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPSW;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPSW;
        private System.Windows.Forms.Button buttonRegistrar;
    }
}