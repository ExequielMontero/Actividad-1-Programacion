namespace hola
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCocina = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnHornear = new System.Windows.Forms.Button();
            this.btnFormar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.tbTomarHarina = new System.Windows.Forms.TextBox();
            this.tbTomarFruta = new System.Windows.Forms.TextBox();
            this.btnTomarFruta = new System.Windows.Forms.Button();
            this.btnTomarHarina = new System.Windows.Forms.Button();
            this.btnCocinar = new System.Windows.Forms.Button();
            this.btnAmasar = new System.Windows.Forms.Button();
            this.btnFruta = new System.Windows.Forms.Button();
            this.tbFruta = new System.Windows.Forms.TextBox();
            this.btnHarina = new System.Windows.Forms.Button();
            this.tbHarina = new System.Windows.Forms.TextBox();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCocina
            // 
            this.btnCocina.BackColor = System.Drawing.Color.Gray;
            this.btnCocina.Location = new System.Drawing.Point(13, 13);
            this.btnCocina.Margin = new System.Windows.Forms.Padding(4);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(536, 97);
            this.btnCocina.TabIndex = 0;
            this.btnCocina.Text = "Crear Cocina";
            this.btnCocina.UseVisualStyleBackColor = false;
            this.btnCocina.Click += new System.EventHandler(this.btn_Click);
            // 
            // gb1
            // 
            this.gb1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gb1.Controls.Add(this.btnHornear);
            this.gb1.Controls.Add(this.btnFormar);
            this.gb1.Controls.Add(this.btnCortar);
            this.gb1.Controls.Add(this.tbTomarHarina);
            this.gb1.Controls.Add(this.tbTomarFruta);
            this.gb1.Controls.Add(this.btnTomarFruta);
            this.gb1.Controls.Add(this.btnTomarHarina);
            this.gb1.Controls.Add(this.btnCocinar);
            this.gb1.Controls.Add(this.btnAmasar);
            this.gb1.Controls.Add(this.btnFruta);
            this.gb1.Controls.Add(this.tbFruta);
            this.gb1.Controls.Add(this.btnHarina);
            this.gb1.Controls.Add(this.tbHarina);
            this.gb1.Location = new System.Drawing.Point(13, 152);
            this.gb1.Margin = new System.Windows.Forms.Padding(4);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4);
            this.gb1.Size = new System.Drawing.Size(554, 239);
            this.gb1.TabIndex = 2;
            this.gb1.TabStop = false;
            this.gb1.Text = "Cocinar";
            this.gb1.Visible = false;
            // 
            // btnHornear
            // 
            this.btnHornear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHornear.Location = new System.Drawing.Point(342, 173);
            this.btnHornear.Margin = new System.Windows.Forms.Padding(4);
            this.btnHornear.Name = "btnHornear";
            this.btnHornear.Size = new System.Drawing.Size(75, 44);
            this.btnHornear.TabIndex = 12;
            this.btnHornear.Text = "Hornear";
            this.btnHornear.UseVisualStyleBackColor = false;
            this.btnHornear.Click += new System.EventHandler(this.btnHornear_Click);
            // 
            // btnFormar
            // 
            this.btnFormar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFormar.Location = new System.Drawing.Point(234, 173);
            this.btnFormar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFormar.Name = "btnFormar";
            this.btnFormar.Size = new System.Drawing.Size(72, 44);
            this.btnFormar.TabIndex = 11;
            this.btnFormar.Text = "Formar moldes";
            this.btnFormar.UseVisualStyleBackColor = false;
            this.btnFormar.Click += new System.EventHandler(this.btnFormar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCortar.Location = new System.Drawing.Point(129, 173);
            this.btnCortar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(71, 44);
            this.btnCortar.TabIndex = 10;
            this.btnCortar.Text = "Cortar masa";
            this.btnCortar.UseVisualStyleBackColor = false;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // tbTomarHarina
            // 
            this.tbTomarHarina.Location = new System.Drawing.Point(438, 44);
            this.tbTomarHarina.Margin = new System.Windows.Forms.Padding(4);
            this.tbTomarHarina.Name = "tbTomarHarina";
            this.tbTomarHarina.Size = new System.Drawing.Size(61, 22);
            this.tbTomarHarina.TabIndex = 9;
            // 
            // tbTomarFruta
            // 
            this.tbTomarFruta.Location = new System.Drawing.Point(438, 96);
            this.tbTomarFruta.Margin = new System.Windows.Forms.Padding(4);
            this.tbTomarFruta.Name = "tbTomarFruta";
            this.tbTomarFruta.Size = new System.Drawing.Size(61, 22);
            this.tbTomarFruta.TabIndex = 8;
            // 
            // btnTomarFruta
            // 
            this.btnTomarFruta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTomarFruta.Location = new System.Drawing.Point(309, 85);
            this.btnTomarFruta.Margin = new System.Windows.Forms.Padding(4);
            this.btnTomarFruta.Name = "btnTomarFruta";
            this.btnTomarFruta.Size = new System.Drawing.Size(108, 44);
            this.btnTomarFruta.TabIndex = 7;
            this.btnTomarFruta.Text = "Tomar Fruta";
            this.btnTomarFruta.UseVisualStyleBackColor = false;
            this.btnTomarFruta.Click += new System.EventHandler(this.btnTomarFruta_Click);
            // 
            // btnTomarHarina
            // 
            this.btnTomarHarina.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTomarHarina.Location = new System.Drawing.Point(309, 34);
            this.btnTomarHarina.Margin = new System.Windows.Forms.Padding(4);
            this.btnTomarHarina.Name = "btnTomarHarina";
            this.btnTomarHarina.Size = new System.Drawing.Size(108, 43);
            this.btnTomarHarina.TabIndex = 6;
            this.btnTomarHarina.Text = "Tomar harina";
            this.btnTomarHarina.UseVisualStyleBackColor = false;
            this.btnTomarHarina.Click += new System.EventHandler(this.btnTomarHarina_Click);
            // 
            // btnCocinar
            // 
            this.btnCocinar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCocinar.Location = new System.Drawing.Point(438, 173);
            this.btnCocinar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCocinar.Name = "btnCocinar";
            this.btnCocinar.Size = new System.Drawing.Size(80, 44);
            this.btnCocinar.TabIndex = 5;
            this.btnCocinar.Text = "Cocinar";
            this.btnCocinar.UseVisualStyleBackColor = false;
            // 
            // btnAmasar
            // 
            this.btnAmasar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAmasar.Location = new System.Drawing.Point(27, 173);
            this.btnAmasar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmasar.Name = "btnAmasar";
            this.btnAmasar.Size = new System.Drawing.Size(72, 44);
            this.btnAmasar.TabIndex = 4;
            this.btnAmasar.Text = "Amasar";
            this.btnAmasar.UseVisualStyleBackColor = false;
            this.btnAmasar.Click += new System.EventHandler(this.btnAmasar_Click);
            // 
            // btnFruta
            // 
            this.btnFruta.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFruta.Location = new System.Drawing.Point(39, 96);
            this.btnFruta.Margin = new System.Windows.Forms.Padding(4);
            this.btnFruta.Name = "btnFruta";
            this.btnFruta.Size = new System.Drawing.Size(108, 44);
            this.btnFruta.TabIndex = 3;
            this.btnFruta.Text = "Agregar Fruta";
            this.btnFruta.UseVisualStyleBackColor = false;
            this.btnFruta.Click += new System.EventHandler(this.btnFruta_Click);
            // 
            // tbFruta
            // 
            this.tbFruta.Location = new System.Drawing.Point(166, 107);
            this.tbFruta.Margin = new System.Windows.Forms.Padding(4);
            this.tbFruta.Name = "tbFruta";
            this.tbFruta.Size = new System.Drawing.Size(61, 22);
            this.tbFruta.TabIndex = 2;
            // 
            // btnHarina
            // 
            this.btnHarina.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHarina.Location = new System.Drawing.Point(39, 34);
            this.btnHarina.Margin = new System.Windows.Forms.Padding(4);
            this.btnHarina.Name = "btnHarina";
            this.btnHarina.Size = new System.Drawing.Size(108, 43);
            this.btnHarina.TabIndex = 1;
            this.btnHarina.Text = "Agregar harina";
            this.btnHarina.UseVisualStyleBackColor = false;
            this.btnHarina.Click += new System.EventHandler(this.btnHarina_Click);
            // 
            // tbHarina
            // 
            this.tbHarina.Location = new System.Drawing.Point(166, 44);
            this.tbHarina.Margin = new System.Windows.Forms.Padding(4);
            this.tbHarina.Name = "tbHarina";
            this.tbHarina.Size = new System.Drawing.Size(61, 22);
            this.tbHarina.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(582, 404);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btnCocina);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cocina";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btnHarina;
        private System.Windows.Forms.TextBox tbHarina;
        private System.Windows.Forms.Button btnCocinar;
        private System.Windows.Forms.Button btnAmasar;
        private System.Windows.Forms.Button btnFruta;
        private System.Windows.Forms.TextBox tbFruta;
        private System.Windows.Forms.TextBox tbTomarHarina;
        private System.Windows.Forms.TextBox tbTomarFruta;
        private System.Windows.Forms.Button btnTomarFruta;
        private System.Windows.Forms.Button btnTomarHarina;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnFormar;
        private System.Windows.Forms.Button btnHornear;
    }
}

