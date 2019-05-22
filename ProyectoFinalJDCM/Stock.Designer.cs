namespace ProyectoFinalJDCM
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.dniTB = new System.Windows.Forms.TextBox();
            this.peliculasCB = new System.Windows.Forms.ComboBox();
            this.AlquilarBoton = new System.Windows.Forms.Button();
            this.DevolverBoton = new System.Windows.Forms.Button();
            this.fechaHoyDTP = new System.Windows.Forms.DateTimePicker();
            this.fechaDevolucionDTP = new System.Windows.Forms.DateTimePicker();
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // dniTB
            // 
            this.dniTB.Location = new System.Drawing.Point(7, 131);
            this.dniTB.Name = "dniTB";
            this.dniTB.Size = new System.Drawing.Size(262, 20);
            this.dniTB.TabIndex = 0;
            // 
            // peliculasCB
            // 
            this.peliculasCB.FormattingEnabled = true;
            this.peliculasCB.Location = new System.Drawing.Point(275, 130);
            this.peliculasCB.Name = "peliculasCB";
            this.peliculasCB.Size = new System.Drawing.Size(225, 21);
            this.peliculasCB.TabIndex = 1;
            // 
            // AlquilarBoton
            // 
            this.AlquilarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AlquilarBoton.BackgroundImage")));
            this.AlquilarBoton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlquilarBoton.ForeColor = System.Drawing.SystemColors.Control;
            this.AlquilarBoton.Location = new System.Drawing.Point(393, 203);
            this.AlquilarBoton.Name = "AlquilarBoton";
            this.AlquilarBoton.Size = new System.Drawing.Size(107, 33);
            this.AlquilarBoton.TabIndex = 2;
            this.AlquilarBoton.Text = "Alquilar";
            this.AlquilarBoton.UseVisualStyleBackColor = true;
            this.AlquilarBoton.Click += new System.EventHandler(this.AlquilarBoton_Click);
            // 
            // DevolverBoton
            // 
            this.DevolverBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DevolverBoton.BackgroundImage")));
            this.DevolverBoton.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevolverBoton.ForeColor = System.Drawing.SystemColors.Control;
            this.DevolverBoton.Location = new System.Drawing.Point(275, 203);
            this.DevolverBoton.Name = "DevolverBoton";
            this.DevolverBoton.Size = new System.Drawing.Size(107, 33);
            this.DevolverBoton.TabIndex = 3;
            this.DevolverBoton.Text = "Devolver";
            this.DevolverBoton.UseVisualStyleBackColor = true;

            // 
            // fechaHoyDTP
            // 
            this.fechaHoyDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaHoyDTP.Location = new System.Drawing.Point(506, 130);
            this.fechaHoyDTP.Name = "fechaHoyDTP";
            this.fechaHoyDTP.Size = new System.Drawing.Size(232, 20);
            this.fechaHoyDTP.TabIndex = 4;
            // 
            // fechaDevolucionDTP
            // 
            this.fechaDevolucionDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDevolucionDTP.Location = new System.Drawing.Point(506, 156);
            this.fechaDevolucionDTP.Name = "fechaDevolucionDTP";
            this.fechaDevolucionDTP.Size = new System.Drawing.Size(232, 20);
            this.fechaDevolucionDTP.TabIndex = 5;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(21, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(225, 93);
            this.logo.TabIndex = 6;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.fechaDevolucionDTP);
            this.Controls.Add(this.fechaHoyDTP);
            this.Controls.Add(this.DevolverBoton);
            this.Controls.Add(this.AlquilarBoton);
            this.Controls.Add(this.peliculasCB);
            this.Controls.Add(this.dniTB);
            this.Name = "Stock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dniTB;
        private System.Windows.Forms.ComboBox peliculasCB;
        private System.Windows.Forms.Button AlquilarBoton;
        private System.Windows.Forms.Button DevolverBoton;
        private System.Windows.Forms.DateTimePicker fechaHoyDTP;
        private System.Windows.Forms.DateTimePicker fechaDevolucionDTP;
        private System.Windows.Forms.PictureBox logo;
    }
}