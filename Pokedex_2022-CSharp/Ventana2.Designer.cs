﻿namespace Pokedex_2022_CSharp
{
    partial class Ventana2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana2));
            this.cajaDescripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.movimientoA = new System.Windows.Forms.Label();
            this.movimientoB = new System.Windows.Forms.Label();
            this.movimientoC = new System.Windows.Forms.Label();
            this.movimientoD = new System.Windows.Forms.Label();
            this.tipoA = new System.Windows.Forms.Label();
            this.tipoB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaDescripcion
            // 
            this.cajaDescripcion.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaDescripcion.Location = new System.Drawing.Point(293, 12);
            this.cajaDescripcion.Name = "cajaDescripcion";
            this.cajaDescripcion.Size = new System.Drawing.Size(495, 197);
            this.cajaDescripcion.TabIndex = 0;
            this.cajaDescripcion.Click += new System.EventHandler(this.cajaDescripcion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // movimientoA
            // 
            this.movimientoA.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientoA.Location = new System.Drawing.Point(296, 231);
            this.movimientoA.Name = "movimientoA";
            this.movimientoA.Size = new System.Drawing.Size(238, 43);
            this.movimientoA.TabIndex = 3;
            // 
            // movimientoB
            // 
            this.movimientoB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientoB.Location = new System.Drawing.Point(550, 231);
            this.movimientoB.Name = "movimientoB";
            this.movimientoB.Size = new System.Drawing.Size(238, 43);
            this.movimientoB.TabIndex = 4;
            // 
            // movimientoC
            // 
            this.movimientoC.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientoC.Location = new System.Drawing.Point(296, 290);
            this.movimientoC.Name = "movimientoC";
            this.movimientoC.Size = new System.Drawing.Size(238, 43);
            this.movimientoC.TabIndex = 5;
            // 
            // movimientoD
            // 
            this.movimientoD.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientoD.Location = new System.Drawing.Point(550, 290);
            this.movimientoD.Name = "movimientoD";
            this.movimientoD.Size = new System.Drawing.Size(238, 43);
            this.movimientoD.TabIndex = 6;
            // 
            // tipoA
            // 
            this.tipoA.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoA.Location = new System.Drawing.Point(29, 263);
            this.tipoA.Name = "tipoA";
            this.tipoA.Size = new System.Drawing.Size(100, 23);
            this.tipoA.TabIndex = 7;
            // 
            // tipoB
            // 
            this.tipoB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoB.Location = new System.Drawing.Point(135, 263);
            this.tipoB.Name = "tipoB";
            this.tipoB.Size = new System.Drawing.Size(100, 23);
            this.tipoB.TabIndex = 8;
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tipoB);
            this.Controls.Add(this.tipoA);
            this.Controls.Add(this.movimientoD);
            this.Controls.Add(this.movimientoC);
            this.Controls.Add(this.movimientoB);
            this.Controls.Add(this.movimientoA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cajaDescripcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventana2";
            this.Text = "Ventana2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cajaDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label movimientoA;
        private System.Windows.Forms.Label movimientoB;
        private System.Windows.Forms.Label movimientoC;
        private System.Windows.Forms.Label movimientoD;
        private System.Windows.Forms.Label tipoA;
        private System.Windows.Forms.Label tipoB;
    }
}