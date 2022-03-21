namespace Pokedex_2022_CSharp
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.Izquierda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Derecha = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.botonInfo = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.inicioDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Izquierda
            // 
            this.Izquierda.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Izquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Izquierda.FlatAppearance.BorderSize = 0;
            this.Izquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izquierda.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izquierda.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Izquierda.Location = new System.Drawing.Point(481, 681);
            this.Izquierda.Name = "Izquierda";
            this.Izquierda.Size = new System.Drawing.Size(52, 31);
            this.Izquierda.TabIndex = 0;
            this.Izquierda.Text = "<";
            this.Izquierda.UseVisualStyleBackColor = false;
            this.Izquierda.Click += new System.EventHandler(this.Izquierda_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Location = new System.Drawing.Point(142, 341);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 168);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Derecha
            // 
            this.Derecha.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Derecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Derecha.FlatAppearance.BorderSize = 0;
            this.Derecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Derecha.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Derecha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Derecha.Location = new System.Drawing.Point(569, 681);
            this.Derecha.Name = "Derecha";
            this.Derecha.Size = new System.Drawing.Size(50, 31);
            this.Derecha.TabIndex = 2;
            this.Derecha.Text = ">";
            this.Derecha.UseVisualStyleBackColor = false;
            this.Derecha.Click += new System.EventHandler(this.Derecha_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.DarkGray;
            this.nombrePokemon.Cursor = System.Windows.Forms.Cursors.Default;
            this.nombrePokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombrePokemon.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.Color.Black;
            this.nombrePokemon.Location = new System.Drawing.Point(316, 341);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(271, 44);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nombrePokemon.Click += new System.EventHandler(this.nombrePokemon_Click);
            // 
            // botonInfo
            // 
            this.botonInfo.BackColor = System.Drawing.Color.Transparent;
            this.botonInfo.Location = new System.Drawing.Point(297, 551);
            this.botonInfo.Name = "botonInfo";
            this.botonInfo.Size = new System.Drawing.Size(115, 38);
            this.botonInfo.TabIndex = 5;
            this.botonInfo.Text = "Mas Info";
            this.botonInfo.UseVisualStyleBackColor = false;
            this.botonInfo.Click += new System.EventHandler(this.botonInfo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(739, 972);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // inicioDesc
            // 
            this.inicioDesc.BackColor = System.Drawing.Color.DarkGray;
            this.inicioDesc.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioDesc.Location = new System.Drawing.Point(316, 399);
            this.inicioDesc.Name = "inicioDesc";
            this.inicioDesc.Size = new System.Drawing.Size(271, 111);
            this.inicioDesc.TabIndex = 7;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 962);
            this.Controls.Add(this.inicioDesc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonInfo);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.Derecha);
            this.Controls.Add(this.Izquierda);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Izquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Derecha;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Button botonInfo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label inicioDesc;
    }
}

