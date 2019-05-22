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
            this.tablaConsultasDG = new System.Windows.Forms.DataGridView();
            this.botonPeliculas = new System.Windows.Forms.Button();
            this.botonDirectores = new System.Windows.Forms.Button();
            this.botonActores = new System.Windows.Forms.Button();
            this.logoPB = new System.Windows.Forms.PictureBox();
            this.buttonStock = new System.Windows.Forms.Button();
            this.butonGestorUsuarios = new System.Windows.Forms.Button();
            this.buttonGestionPelis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaConsultasDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaConsultasDG
            // 
            this.tablaConsultasDG.AllowUserToOrderColumns = true;
            this.tablaConsultasDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaConsultasDG.Location = new System.Drawing.Point(12, 102);
            this.tablaConsultasDG.Name = "tablaConsultasDG";
            this.tablaConsultasDG.ReadOnly = true;
            this.tablaConsultasDG.Size = new System.Drawing.Size(490, 348);
            this.tablaConsultasDG.TabIndex = 5;
            this.tablaConsultasDG.Visible = false;
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
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.Transparent;
            this.logoPB.Image = ((System.Drawing.Image)(resources.GetObject("logoPB.Image")));
            this.logoPB.Location = new System.Drawing.Point(284, 5);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(218, 91);
            this.logoPB.TabIndex = 11;
            this.logoPB.TabStop = false;
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.Color.Transparent;
            this.buttonStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStock.BackgroundImage")));
            this.buttonStock.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStock.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStock.Location = new System.Drawing.Point(659, 307);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(103, 61);
            this.buttonStock.TabIndex = 12;
            this.buttonStock.Text = "Stock";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // butonGestorUsuarios
            // 
            this.butonGestorUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.butonGestorUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butonGestorUsuarios.BackgroundImage")));
            this.butonGestorUsuarios.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonGestorUsuarios.ForeColor = System.Drawing.SystemColors.Control;
            this.butonGestorUsuarios.Location = new System.Drawing.Point(537, 307);
            this.butonGestorUsuarios.Name = "butonGestorUsuarios";
            this.butonGestorUsuarios.Size = new System.Drawing.Size(103, 61);
            this.butonGestorUsuarios.TabIndex = 13;
            this.butonGestorUsuarios.Text = "Gestión de Usuarios";
            this.butonGestorUsuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.butonGestorUsuarios.UseVisualStyleBackColor = false;
            this.butonGestorUsuarios.Click += new System.EventHandler(this.butonGestorUsuarios_Click);
            // 
            // buttonGestionPelis
            // 
            this.buttonGestionPelis.Location = new System.Drawing.Point(537, 394);
            this.buttonGestionPelis.Name = "buttonGestionPelis";
            this.buttonGestionPelis.Size = new System.Drawing.Size(103, 58);
            this.buttonGestionPelis.TabIndex = 14;
            this.buttonGestionPelis.Text = "Gestión de Peliculas";
            this.buttonGestionPelis.UseVisualStyleBackColor = true;
            this.buttonGestionPelis.Click += new System.EventHandler(this.buttonGestionPelis_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.buttonGestionPelis);
            this.Controls.Add(this.butonGestorUsuarios);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.botonActores);
            this.Controls.Add(this.botonDirectores);
            this.Controls.Add(this.botonPeliculas);
            this.Controls.Add(this.tablaConsultasDG);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.tablaConsultasDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView tablaConsultasDG;
        private System.Windows.Forms.Button botonPeliculas;
        private System.Windows.Forms.Button botonDirectores;
        private System.Windows.Forms.Button botonActores;
        private System.Windows.Forms.PictureBox logoPB;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button butonGestorUsuarios;
        private System.Windows.Forms.Button buttonGestionPelis;
    }
}