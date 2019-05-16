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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.AlquilarBoton = new System.Windows.Forms.Button();
            this.DevolverBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(431, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // AlquilarBoton
            // 
            this.AlquilarBoton.Location = new System.Drawing.Point(662, 87);
            this.AlquilarBoton.Name = "AlquilarBoton";
            this.AlquilarBoton.Size = new System.Drawing.Size(126, 23);
            this.AlquilarBoton.TabIndex = 2;
            this.AlquilarBoton.Text = "Alquilar";
            this.AlquilarBoton.UseVisualStyleBackColor = true;
            // 
            // DevolverBoton
            // 
            this.DevolverBoton.Location = new System.Drawing.Point(662, 116);
            this.DevolverBoton.Name = "DevolverBoton";
            this.DevolverBoton.Size = new System.Drawing.Size(126, 23);
            this.DevolverBoton.TabIndex = 3;
            this.DevolverBoton.Text = "Devolver";
            this.DevolverBoton.UseVisualStyleBackColor = true;
            this.DevolverBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DevolverBoton);
            this.Controls.Add(this.AlquilarBoton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button AlquilarBoton;
        private System.Windows.Forms.Button DevolverBoton;
    }
}