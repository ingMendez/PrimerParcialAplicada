namespace PrimerParcial.UI.Registros
{
    partial class ExamenRegistro
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label vendedorIdLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label retencionLabel;
            System.Windows.Forms.Label rotacionLabel1;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.vendedorIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sueldoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.retencionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.rotacionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Elimiinar_button = new System.Windows.Forms.Button();
            this.Gualdar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Fecha_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            vendedorIdLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            retencionLabel = new System.Windows.Forms.Label();
            rotacionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retencionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotacionNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(21, 125);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            nombreLabel.Click += new System.EventHandler(this.NombreLabel_Click);
            // 
            // vendedorIdLabel
            // 
            vendedorIdLabel.AutoSize = true;
            vendedorIdLabel.Location = new System.Drawing.Point(21, 95);
            vendedorIdLabel.Name = "vendedorIdLabel";
            vendedorIdLabel.Size = new System.Drawing.Size(68, 13);
            vendedorIdLabel.TabIndex = 7;
            vendedorIdLabel.Text = "Vendedor Id:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(21, 155);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(41, 13);
            sueldoLabel.TabIndex = 9;
            sueldoLabel.Text = "sueldo:";
            // 
            // retencionLabel
            // 
            retencionLabel.AutoSize = true;
            retencionLabel.Location = new System.Drawing.Point(21, 187);
            retencionLabel.Name = "retencionLabel";
            retencionLabel.Size = new System.Drawing.Size(54, 13);
            retencionLabel.TabIndex = 13;
            retencionLabel.Text = "retencion:";
            // 
            // rotacionLabel1
            // 
            rotacionLabel1.AutoSize = true;
            rotacionLabel1.Location = new System.Drawing.Point(20, 221);
            rotacionLabel1.Name = "rotacionLabel1";
            rotacionLabel1.Size = new System.Drawing.Size(48, 13);
            rotacionLabel1.TabIndex = 14;
            rotacionLabel1.Text = "rotacion:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(90, 122);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 6;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // vendedorIdNumericUpDown
            // 
            this.vendedorIdNumericUpDown.Location = new System.Drawing.Point(90, 93);
            this.vendedorIdNumericUpDown.Name = "vendedorIdNumericUpDown";
            this.vendedorIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.vendedorIdNumericUpDown.TabIndex = 8;
            // 
            // sueldoNumericUpDown
            // 
            this.sueldoNumericUpDown.DecimalPlaces = 2;
            this.sueldoNumericUpDown.Location = new System.Drawing.Point(90, 148);
            this.sueldoNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sueldoNumericUpDown.Name = "sueldoNumericUpDown";
            this.sueldoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.sueldoNumericUpDown.TabIndex = 10;
            this.sueldoNumericUpDown.ValueChanged += new System.EventHandler(this.RotacionNumericUpDown_ValueChanged);
            // 
            // retencionNumericUpDown
            // 
            this.retencionNumericUpDown.DecimalPlaces = 2;
            this.retencionNumericUpDown.Location = new System.Drawing.Point(90, 187);
            this.retencionNumericUpDown.Name = "retencionNumericUpDown";
            this.retencionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.retencionNumericUpDown.TabIndex = 14;
            this.retencionNumericUpDown.ValueChanged += new System.EventHandler(this.RotacionNumericUpDown_ValueChanged);
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // rotacionNumericUpDown
            // 
            this.rotacionNumericUpDown.DecimalPlaces = 2;
            this.rotacionNumericUpDown.Enabled = false;
            this.rotacionNumericUpDown.Location = new System.Drawing.Point(90, 221);
            this.rotacionNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rotacionNumericUpDown.Name = "rotacionNumericUpDown";
            this.rotacionNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.rotacionNumericUpDown.TabIndex = 15;
            this.rotacionNumericUpDown.ValueChanged += new System.EventHandler(this.RotacionNumericUpDown_ValueChanged);
            // 
            // Buscar_button
            // 
            this.Buscar_button.Image = global::PrimerParcial.Properties.Resources.Search_48px;
            this.Buscar_button.Location = new System.Drawing.Point(306, 42);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(75, 62);
            this.Buscar_button.TabIndex = 3;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Elimiinar_button
            // 
            this.Elimiinar_button.Image = global::PrimerParcial.Properties.Resources.EliminarRegistro;
            this.Elimiinar_button.Location = new System.Drawing.Point(306, 284);
            this.Elimiinar_button.Name = "Elimiinar_button";
            this.Elimiinar_button.Size = new System.Drawing.Size(75, 59);
            this.Elimiinar_button.TabIndex = 2;
            this.Elimiinar_button.UseVisualStyleBackColor = true;
            this.Elimiinar_button.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Gualdar_button
            // 
            this.Gualdar_button.Image = global::PrimerParcial.Properties.Resources.guardarRegistro;
            this.Gualdar_button.Location = new System.Drawing.Point(190, 284);
            this.Gualdar_button.Name = "Gualdar_button";
            this.Gualdar_button.Size = new System.Drawing.Size(75, 59);
            this.Gualdar_button.TabIndex = 1;
            this.Gualdar_button.UseVisualStyleBackColor = true;
            this.Gualdar_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Image = global::PrimerParcial.Properties.Resources.nuevoRegsitro;
            this.Nuevo_button.Location = new System.Drawing.Point(62, 284);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(75, 59);
            this.Nuevo_button.TabIndex = 0;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Fecha_dateTimePicker
            // 
            this.Fecha_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fecha_dateTimePicker.Location = new System.Drawing.Point(306, 191);
            this.Fecha_dateTimePicker.Name = "Fecha_dateTimePicker";
            this.Fecha_dateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.Fecha_dateTimePicker.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Fecha";
            // 
            // ExamenRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fecha_dateTimePicker);
            this.Controls.Add(rotacionLabel1);
            this.Controls.Add(this.rotacionNumericUpDown);
            this.Controls.Add(retencionLabel);
            this.Controls.Add(this.retencionNumericUpDown);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoNumericUpDown);
            this.Controls.Add(vendedorIdLabel);
            this.Controls.Add(this.vendedorIdNumericUpDown);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Elimiinar_button);
            this.Controls.Add(this.Gualdar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Name = "ExamenRegistro";
            this.Text = "ExamenRegistro";
            this.Load += new System.EventHandler(this.ExamenRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendedorIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueldoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retencionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotacionNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Gualdar_button;
        private System.Windows.Forms.Button Elimiinar_button;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.NumericUpDown vendedorIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown sueldoNumericUpDown;
        private System.Windows.Forms.NumericUpDown retencionNumericUpDown;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
        private System.Windows.Forms.NumericUpDown rotacionNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Fecha_dateTimePicker;
    }
}