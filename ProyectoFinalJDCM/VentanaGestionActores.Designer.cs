namespace ProyectoFinalJDCM
{
    partial class VentanaGestionActores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaGestionActores));
            this.tablaActores = new System.Windows.Forms.DataGridView();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxGenero = new System.Windows.Forms.TextBox();
            this.textBoxProtagonizadas = new System.Windows.Forms.TextBox();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonMostrarActores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaActores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaActores
            // 
            this.tablaActores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaActores.Location = new System.Drawing.Point(13, 109);
            this.tablaActores.Name = "tablaActores";
            this.tablaActores.Size = new System.Drawing.Size(382, 329);
            this.tablaActores.TabIndex = 0;
            this.tablaActores.Visible = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(13, 13);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(228, 90);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.Color.Transparent;
            this.labelId.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.SystemColors.Control;
            this.labelId.Location = new System.Drawing.Point(533, 111);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 19);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID :";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNombre.Location = new System.Drawing.Point(496, 134);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 19);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.BackColor = System.Drawing.Color.Transparent;
            this.labelApellidos.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.ForeColor = System.Drawing.SystemColors.Control;
            this.labelApellidos.Location = new System.Drawing.Point(487, 163);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(73, 19);
            this.labelApellidos.TabIndex = 4;
            this.labelApellidos.Text = "Apellidos :";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.BackColor = System.Drawing.Color.Transparent;
            this.labelGenero.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGenero.Location = new System.Drawing.Point(500, 193);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(60, 19);
            this.labelGenero.TabIndex = 5;
            this.labelGenero.Text = "Genero :";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.BackColor = System.Drawing.Color.Transparent;
            this.labelCantidad.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCantidad.Location = new System.Drawing.Point(409, 219);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(151, 19);
            this.labelCantidad.TabIndex = 6;
            this.labelCantidad.Text = "Cantidas de películas :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(566, 110);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(152, 20);
            this.textBoxID.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(566, 136);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(152, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(566, 165);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(152, 20);
            this.textBoxApellidos.TabIndex = 9;
            // 
            // textBoxGenero
            // 
            this.textBoxGenero.Location = new System.Drawing.Point(566, 192);
            this.textBoxGenero.Name = "textBoxGenero";
            this.textBoxGenero.Size = new System.Drawing.Size(152, 20);
            this.textBoxGenero.TabIndex = 10;
            // 
            // textBoxProtagonizadas
            // 
            this.textBoxProtagonizadas.Location = new System.Drawing.Point(566, 218);
            this.textBoxProtagonizadas.Name = "textBoxProtagonizadas";
            this.textBoxProtagonizadas.Size = new System.Drawing.Size(152, 20);
            this.textBoxProtagonizadas.TabIndex = 11;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonRegistrar.Image")));
            this.buttonRegistrar.Location = new System.Drawing.Point(566, 253);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(152, 36);
            this.buttonRegistrar.TabIndex = 12;
            this.buttonRegistrar.Text = "REGISTRAR";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonMostrarActores
            // 
            this.buttonMostrarActores.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarActores.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonMostrarActores.Image = ((System.Drawing.Image)(resources.GetObject("buttonMostrarActores.Image")));
            this.buttonMostrarActores.Location = new System.Drawing.Point(435, 354);
            this.buttonMostrarActores.Name = "buttonMostrarActores";
            this.buttonMostrarActores.Size = new System.Drawing.Size(75, 76);
            this.buttonMostrarActores.TabIndex = 13;
            this.buttonMostrarActores.Text = "Mostrar Actores";
            this.buttonMostrarActores.UseVisualStyleBackColor = true;
            this.buttonMostrarActores.Click += new System.EventHandler(this.buttonMostrarActores_Click);
            // 
            // VentanaGestionActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMostrarActores);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxProtagonizadas);
            this.Controls.Add(this.textBoxGenero);
            this.Controls.Add(this.textBoxApellidos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.tablaActores);
            this.Name = "VentanaGestionActores";
            this.Text = "VentanaGestionActores";
            ((System.ComponentModel.ISupportInitialize)(this.tablaActores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaActores;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.TextBox textBoxGenero;
        private System.Windows.Forms.TextBox textBoxProtagonizadas;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonMostrarActores;
    }
}