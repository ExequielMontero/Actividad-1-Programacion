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
            this.btnCocina = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbHarina = new System.Windows.Forms.TextBox();
            this.btnHarina = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCocina
            // 
            this.btnCocina.Location = new System.Drawing.Point(29, 32);
            this.btnCocina.Name = "btnCocina";
            this.btnCocina.Size = new System.Drawing.Size(72, 79);
            this.btnCocina.TabIndex = 0;
            this.btnCocina.Text = "Crear Cocina";
            this.btnCocina.UseVisualStyleBackColor = true;
            this.btnCocina.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHarina);
            this.groupBox1.Controls.Add(this.tbHarina);
            this.groupBox1.Location = new System.Drawing.Point(37, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbHarina
            // 
            this.tbHarina.Location = new System.Drawing.Point(174, 60);
            this.tbHarina.Name = "tbHarina";
            this.tbHarina.Size = new System.Drawing.Size(100, 20);
            this.tbHarina.TabIndex = 0;
            // 
            // btnHarina
            // 
            this.btnHarina.Location = new System.Drawing.Point(81, 51);
            this.btnHarina.Name = "btnHarina";
            this.btnHarina.Size = new System.Drawing.Size(72, 36);
            this.btnHarina.TabIndex = 1;
            this.btnHarina.Text = "Agregar harina";
            this.btnHarina.UseVisualStyleBackColor = true;
            this.btnHarina.Click += new System.EventHandler(this.btnHarina_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCocina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCocina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHarina;
        private System.Windows.Forms.TextBox tbHarina;
    }
}

