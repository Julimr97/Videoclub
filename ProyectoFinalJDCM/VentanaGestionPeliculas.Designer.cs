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
            this.tablaPeliculas = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRegistrarPelis = new System.Windows.Forms.Button();
            this.buttonMostrarPelis = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxRank = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaPeliculas
            // 
            this.tablaPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPeliculas.Location = new System.Drawing.Point(24, 117);
            this.tablaPeliculas.Name = "tablaPeliculas";
            this.tablaPeliculas.Size = new System.Drawing.Size(371, 280);
            this.tablaPeliculas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRegistrarPelis
            // 
            this.buttonRegistrarPelis.Location = new System.Drawing.Point(599, 329);
            this.buttonRegistrarPelis.Name = "buttonRegistrarPelis";
            this.buttonRegistrarPelis.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrarPelis.TabIndex = 2;
            this.buttonRegistrarPelis.Text = "Registrar";
            this.buttonRegistrarPelis.UseVisualStyleBackColor = true;
            this.buttonRegistrarPelis.Click += new System.EventHandler(this.buttonRegistrarPelis_Click);
            // 
            // buttonMostrarPelis
            // 
            this.buttonMostrarPelis.Location = new System.Drawing.Point(599, 373);
            this.buttonMostrarPelis.Name = "buttonMostrarPelis";
            this.buttonMostrarPelis.Size = new System.Drawing.Size(75, 44);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // VentanaGestionPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxRank);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buttonMostrarPelis);
            this.Controls.Add(this.buttonRegistrarPelis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tablaPeliculas);
            this.Name = "VentanaGestionPeliculas";
            this.Text = "VentanaGestionPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaPeliculas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRegistrarPelis;
        private System.Windows.Forms.Button buttonMostrarPelis;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxRank;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}