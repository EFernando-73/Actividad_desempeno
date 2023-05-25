namespace conexion_sql
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
            this.Registro = new System.Windows.Forms.Button();
            this.consulta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.Location = new System.Drawing.Point(135, 166);
            this.Registro.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(119, 61);
            this.Registro.TabIndex = 13;
            this.Registro.Text = "Nuevo Registro";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.agregar_Click);
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(540, 166);
            this.consulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(115, 61);
            this.consulta.TabIndex = 15;
            this.consulta.Text = "Consultar lista";
            this.consulta.UseVisualStyleBackColor = true;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Gloucester MT Extra Condensed", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Location = new System.Drawing.Point(12, -2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 41);
            this.textBox1.TabIndex = 16;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "aplicacion de resgitro del trubunal supremo electoral";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::conexion_sql.Properties.Resources.Logo_del_Tribunal_Supremo_Electoral_de_Guatemala_svg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(808, 436);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.Registro);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "nuevo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.Button consulta;
        private System.Windows.Forms.TextBox textBox1;
    }
}

