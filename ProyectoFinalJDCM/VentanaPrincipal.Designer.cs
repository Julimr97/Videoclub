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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.dGListaConsultas = new System.Windows.Forms.DataGridView();
            this.botonPeliculas = new System.Windows.Forms.Button();
            this.botonDirectores = new System.Windows.Forms.Button();
            this.botonActores = new System.Windows.Forms.Button();
            this.labelTabla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStock = new System.Windows.Forms.Button();
            this.butonAñadirPelis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGListaConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGListaConsultas
            // 
            this.dGListaConsultas.AllowUserToOrderColumns = true;
            this.dGListaConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGListaConsultas.Location = new System.Drawing.Point(12, 90);
            this.dGListaConsultas.Name = "dGListaConsultas";
            this.dGListaConsultas.ReadOnly = true;
            this.dGListaConsultas.Size = new System.Drawing.Size(490, 348);
            this.dGListaConsultas.TabIndex = 5;
            this.dGListaConsultas.Visible = false;
        
            // 
            // botonPeliculas
            // 
            this.botonPeliculas.BackColor = System.Drawing.Color.Transparent;
            this.botonPeliculas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonPeliculas.BackgroundImage")));
            this.botonPeliculas.Cursor = System.Windows.Forms.Cursors.Default;
            this.botonPeliculas.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPeliculas.ForeColor = System.Drawing.SystemColors.Control;
            this.botonPeliculas.Location = new System.Drawing.Point(572, 82);
            this.botonPeliculas.Name = "botonPeliculas";
            this.botonPeliculas.Size = new System.Drawing.Size(157, 31);
            this.botonPeliculas.TabIndex = 6;
            this.botonPeliculas.Text = "Películas";
            this.botonPeliculas.UseVisualStyleBackColor = false;
            this.botonPeliculas.Click += new System.EventHandler(this.botonPeliculas_Click);
            // 
            // botonDirectores
            // 
            this.botonDirectores.BackColor = System.Drawing.Color.Transparent;
            this.botonDirectores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonDirectores.BackgroundImage")));
            this.botonDirectores.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDirectores.ForeColor = System.Drawing.SystemColors.Control;
            this.botonDirectores.Location = new System.Drawing.Point(572, 119);
            this.botonDirectores.Name = "botonDirectores";
            this.botonDirectores.Size = new System.Drawing.Size(157, 31);
            this.botonDirectores.TabIndex = 7;
            this.botonDirectores.Text = "Directores";
            this.botonDirectores.UseVisualStyleBackColor = false;
            this.botonDirectores.Click += new System.EventHandler(this.botonDirectores_Click);
            // 
            // botonActores
            // 
            this.botonActores.BackColor = System.Drawing.Color.Transparent;
            this.botonActores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonActores.BackgroundImage")));
            this.botonActores.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonActores.ForeColor = System.Drawing.SystemColors.Control;
            this.botonActores.Location = new System.Drawing.Point(572, 156);
            this.botonActores.Name = "botonActores";
            this.botonActores.Size = new System.Drawing.Size(157, 31);
            this.botonActores.TabIndex = 8;
            this.botonActores.Text = "Actores";
            this.botonActores.UseVisualStyleBackColor = false;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 91);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.Transparent;
            this.buttonStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStock.BackgroundImage")));
            this.buttonStock.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStock.Location = new System.Drawing.Point(657, 271);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(144, 31);
            this.buttonStock.TabIndex = 12;
            this.buttonStock.Text = "Stock";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // butonAñadirPelis
            // 
            this.butonAñadirPelis.BackColor = System.Drawing.Color.Transparent;
            this.butonAñadirPelis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonAñadirPelis.BackgroundImage")));
            this.butonAñadirPelis.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonAñadirPelis.ForeColor = System.Drawing.SystemColors.Control;
            this.butonAñadirPelis.Location = new System.Drawing.Point(508, 271);
            this.butonAñadirPelis.Name = "butonAñadirPelis";
            this.butonAñadirPelis.Size = new System.Drawing.Size(143, 31);
            this.butonAñadirPelis.TabIndex = 13;
            this.butonAñadirPelis.Text = "Gestión de Pelis";
            this.butonAñadirPelis.UseVisualStyleBackColor = false;
            this.butonAñadirPelis.Click += new System.EventHandler(this.butonAñadirPelis_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butonAñadirPelis);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTabla);
            this.Controls.Add(this.botonActores);
            this.Controls.Add(this.botonDirectores);
            this.Controls.Add(this.botonPeliculas);
            this.Controls.Add(this.dGListaConsultas);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dGListaConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button butonAñadirPelis;
    }
}