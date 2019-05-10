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
            this.dGListaConsultas = new System.Windows.Forms.DataGridView();
            this.botonPeliculas = new System.Windows.Forms.Button();
            this.botonDirectores = new System.Windows.Forms.Button();
            this.botonActores = new System.Windows.Forms.Button();
            this.labelTabla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGListaConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dGListaConsultas
            // 
            this.dGListaConsultas.AllowUserToOrderColumns = true;
            this.dGListaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGListaConsultas.Location = new System.Drawing.Point(12, 90);
            this.dGListaConsultas.Name = "dGListaConsultas";
            this.dGListaConsultas.ReadOnly = true;
            this.dGListaConsultas.Size = new System.Drawing.Size(495, 348);
            this.dGListaConsultas.TabIndex = 5;
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
            // labelTabla
            // 
            this.labelTabla.AutoSize = true;
            this.labelTabla.Location = new System.Drawing.Point(13, 71);
            this.labelTabla.Name = "labelTabla";
            this.labelTabla.Size = new System.Drawing.Size(0, 13);
            this.labelTabla.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTabla);
            this.Controls.Add(this.botonActores);
            this.Controls.Add(this.botonDirectores);
            this.Controls.Add(this.botonPeliculas);
            this.Controls.Add(this.dGListaConsultas);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dGListaConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGListaConsultas;
        private System.Windows.Forms.Button botonPeliculas;
        private System.Windows.Forms.Button botonDirectores;
        private System.Windows.Forms.Button botonActores;
        private System.Windows.Forms.Label labelTabla;
        private System.Windows.Forms.Label label1;
    }
}