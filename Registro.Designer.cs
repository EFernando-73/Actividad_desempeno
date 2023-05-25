namespace conexion_sql
{
    partial class Registro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Agregar = new System.Windows.Forms.Button();
            this.nom1 = new System.Windows.Forms.TextBox();
            this.nom2 = new System.Windows.Forms.TextBox();
            this.ape1 = new System.Windows.Forms.TextBox();
            this.ape2 = new System.Windows.Forms.TextBox();
            this.cui1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.consulta1 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.llw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Pellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de DPI (CUI)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de Nacimiento";
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(98, 247);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(139, 49);
            this.Agregar.TabIndex = 6;
            this.Agregar.Text = "Agregar Registro";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // nom1
            // 
            this.nom1.Location = new System.Drawing.Point(97, 67);
            this.nom1.Name = "nom1";
            this.nom1.Size = new System.Drawing.Size(175, 20);
            this.nom1.TabIndex = 7;
            // 
            // nom2
            // 
            this.nom2.Location = new System.Drawing.Point(285, 67);
            this.nom2.Name = "nom2";
            this.nom2.Size = new System.Drawing.Size(200, 20);
            this.nom2.TabIndex = 8;
            // 
            // ape1
            // 
            this.ape1.Location = new System.Drawing.Point(97, 145);
            this.ape1.Name = "ape1";
            this.ape1.Size = new System.Drawing.Size(175, 20);
            this.ape1.TabIndex = 9;
            // 
            // ape2
            // 
            this.ape2.Location = new System.Drawing.Point(285, 145);
            this.ape2.Name = "ape2";
            this.ape2.Size = new System.Drawing.Size(200, 20);
            this.ape2.TabIndex = 10;
            // 
            // cui1
            // 
            this.cui1.Location = new System.Drawing.Point(499, 67);
            this.cui1.Name = "cui1";
            this.cui1.Size = new System.Drawing.Size(200, 20);
            this.cui1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 49);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fecha1
            // 
            this.fecha1.Location = new System.Drawing.Point(499, 145);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(200, 20);
            this.fecha1.TabIndex = 14;
            // 
            // consulta1
            // 
            this.consulta1.Location = new System.Drawing.Point(465, 247);
            this.consulta1.Name = "consulta1";
            this.consulta1.Size = new System.Drawing.Size(139, 49);
            this.consulta1.TabIndex = 15;
            this.consulta1.Text = "Consultar Lista";
            this.consulta1.UseVisualStyleBackColor = true;
            this.consulta1.Click += new System.EventHandler(this.consulta1_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(98, 199);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(175, 20);
            this.ID.TabIndex = 17;
            // 
            // llw
            // 
            this.llw.AutoSize = true;
            this.llw.Location = new System.Drawing.Point(95, 222);
            this.llw.Name = "llw";
            this.llw.Size = new System.Drawing.Size(54, 13);
            this.llw.TabIndex = 16;
            this.llw.Text = "Codigo ID";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.llw);
            this.Controls.Add(this.consulta1);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cui1);
            this.Controls.Add(this.ape2);
            this.Controls.Add(this.ape1);
            this.Controls.Add(this.nom2);
            this.Controls.Add(this.nom1);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox nom1;
        private System.Windows.Forms.TextBox nom2;
        private System.Windows.Forms.TextBox ape1;
        private System.Windows.Forms.TextBox ape2;
        private System.Windows.Forms.TextBox cui1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.Button consulta1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label llw;
    }
}