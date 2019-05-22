namespace ProyectoFinalJDCM
{
    partial class VentanaGestionPeliculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaGestionPeliculas));
            this.tablaPeliculas = new System.Windows.Forms.DataGridView();
            this.logo = new System.Windows.Forms.PictureBox();
            this.buttonRegistrarPelis = new System.Windows.Forms.Button();
            this.buttonMostrarPelis = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelAnnio = new System.Windows.Forms.Label();
            this.labelRank = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPeliculas
            // 
            this.tablaPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPeliculas.Location = new System.Drawing.Point(24, 117);
            this.tablaPeliculas.Name = "tablaPeliculas";
            this.tablaPeliculas.Size = new System.Drawing.Size(371, 280);
            this.tablaPeliculas.TabIndex = 0;
            this.tablaPeliculas.Visible = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(24, 13);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 98);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // buttonRegistrarPelis
            // 
            this.buttonRegistrarPelis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRegistrarPelis.BackgroundImage")));
            this.buttonRegistrarPelis.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarPelis.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrarPelis.Location = new System.Drawing.Point(599, 293);
            this.buttonRegistrarPelis.Name = "buttonRegistrarPelis";
            this.buttonRegistrarPelis.Size = new System.Drawing.Size(100, 30);
            this.buttonRegistrarPelis.TabIndex = 2;
            this.buttonRegistrarPelis.Text = "Registrar";
            this.buttonRegistrarPelis.UseVisualStyleBackColor = true;
            this.buttonRegistrarPelis.Click += new System.EventHandler(this.buttonRegistrarPelis_Click);
            // 
            // buttonMostrarPelis
            // 
            this.buttonMostrarPelis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMostrarPelis.BackgroundImage")));
            this.buttonMostrarPelis.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarPelis.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMostrarPelis.Location = new System.Drawing.Point(599, 342);
            this.buttonMostrarPelis.Name = "buttonMostrarPelis";
            this.buttonMostrarPelis.Size = new System.Drawing.Size(100, 61);
            this.buttonMostrarPelis.TabIndex = 3;
            this.buttonMostrarPelis.Text = "Mostar Peliculas";
            this.buttonMostrarPelis.UseVisualStyleBackColor = true;
            this.buttonMostrarPelis.Click += new System.EventHandler(this.buttonMostrarPelis_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(599, 117);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(599, 143);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(599, 169);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 6;
            // 
            // textBoxRank
            // 
            this.textBoxRank.Location = new System.Drawing.Point(599, 195);
            this.textBoxRank.Name = "textBoxRank";
            this.textBoxRank.Size = new System.Drawing.Size(100, 20);
            this.textBoxRank.TabIndex = 7;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(599, 221);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxStock.TabIndex = 8;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.SystemColors.Control;
            this.labelID.Location = new System.Drawing.Point(530, 117);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(29, 20);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID :";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombre.Location = new System.Drawing.Point(530, 143);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 20);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelAnnio
            // 
            this.labelAnnio.AutoSize = true;
            this.labelAnnio.BackColor = System.Drawing.Color.Transparent;
            this.labelAnnio.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnio.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAnnio.Location = new System.Drawing.Point(530, 169);
            this.labelAnnio.Name = "labelAnnio";
            this.labelAnnio.Size = new System.Drawing.Size(38, 20);
            this.labelAnnio.TabIndex = 11;
            this.labelAnnio.Text = "Año :";
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.BackColor = System.Drawing.Color.Transparent;
            this.labelRank.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRank.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRank.Location = new System.Drawing.Point(530, 195);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(48, 20);
            this.labelRank.TabIndex = 12;
            this.labelRank.Text = "Rank :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.BackColor = System.Drawing.Color.Transparent;
            this.labelStock.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStock.Location = new System.Drawing.Point(530, 221);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(52, 20);
            this.labelStock.TabIndex = 13;
            this.labelStock.Text = "Stock :";
            // 
            // VentanaGestionPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.labelAnnio);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonMostrarPelis);
            this.Controls.Add(this.buttonRegistrarPelis);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tablaPeliculas);
            this.Name = "VentanaGestionPeliculas";
            this.Text = "VentanaGestionPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPeliculas;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button buttonRegistrarPelis;
        private System.Windows.Forms.Button buttonMostrarPelis;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelAnnio;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Label labelStock;
    }
}