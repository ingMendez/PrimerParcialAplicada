namespace PrimerParcial
{
    partial class PrimerParcial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimerParcial));
            this.Registro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.Image = ((System.Drawing.Image)(resources.GetObject("Registro.Image")));
            this.Registro.Location = new System.Drawing.Point(188, 12);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(160, 99);
            this.Registro.TabIndex = 0;
            this.Registro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(188, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 143);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consulta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(188, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 102);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaLir_Click);
            // 
            // PrimerParcial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(485, 378);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Registro);
            this.Name = "PrimerParcial";
            this.Text = "Primer Parcial";
            this.Load += new System.EventHandler(this.PrimerParcial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

