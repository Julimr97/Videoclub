namespace ProyectoFinalJDCM
{
    partial class VentanaPrincipal
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
            this.listaConsultas = new System.Windows.Forms.DataGridView();
            this.botonPeliculas = new System.Windows.Forms.Button();
            this.botonDirectores = new System.Windows.Forms.Button();
            this.botonActores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // listaConsultas
            // 
            this.listaConsultas.AllowUserToOrderColumns = true;
            this.listaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaConsultas.Location = new System.Drawing.Point(12, 90);
            this.listaConsultas.Name = "listaConsultas";
            this.listaConsultas.ReadOnly = true;
            this.listaConsultas.Size = new System.Drawing.Size(495, 348);
            this.listaConsultas.TabIndex = 5;
            // 
            // botonPeliculas
            // 
            this.botonPeliculas.Location = new System.Drawing.Point(646, 90);
            this.botonPeliculas.Name = "botonPeliculas";
            this.botonPeliculas.Size = new System.Drawing.Size(75, 23);
            this.botonPeliculas.TabIndex = 6;
            this.botonPeliculas.Text = "Peliculas";
            this.botonPeliculas.UseVisualStyleBackColor = true;
            this.botonPeliculas.Click += new System.EventHandler(this.botonPeliculas_Click);
            // 
            // botonDirectores
            // 
            this.botonDirectores.Location = new System.Drawing.Point(646, 119);
            this.botonDirectores.Name = "botonDirectores";
            this.botonDirectores.Size = new System.Drawing.Size(75, 23);
            this.botonDirectores.TabIndex = 7;
            this.botonDirectores.Text = "Directores";
            this.botonDirectores.UseVisualStyleBackColor = true;
            this.botonDirectores.Click += new System.EventHandler(this.botonDirectores_Click);
            // 
            // botonActores
            // 
            this.botonActores.Location = new System.Drawing.Point(646, 148);
            this.botonActores.Name = "botonActores";
            this.botonActores.Size = new System.Drawing.Size(75, 23);
            this.botonActores.TabIndex = 8;
            this.botonActores.Text = "Actores";
            this.botonActores.UseVisualStyleBackColor = true;
            this.botonActores.Click += new System.EventHandler(this.botonActores_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonActores);
            this.Controls.Add(this.botonDirectores);
            this.Controls.Add(this.botonPeliculas);
            this.Controls.Add(this.listaConsultas);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.listaConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView listaConsultas;
        private System.Windows.Forms.Button botonPeliculas;
        private System.Windows.Forms.Button botonDirectores;
        private System.Windows.Forms.Button botonActores;
    }
}