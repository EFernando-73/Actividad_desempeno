namespace conexion_sql
{
    partial class Form3
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
            this.Editar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(40, 47);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(100, 49);
            this.Editar.TabIndex = 1;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(40, 191);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(100, 49);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(563, 181);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(40, 117);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 49);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(181, 206);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(147, 20);
            this.ID.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Editar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox ID;
    }
}