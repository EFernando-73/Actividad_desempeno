using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace conexion_sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
            MessageBox.Show("conexion exitosa");

          
        }

        public DataTable llenado()
        {
            conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM empadronado";
            SqlCommand cmd = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Registro Registro = new Registro();
            this.Hide();
            Registro.ShowDialog();
            this.Show();
              
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void consulta_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            this.Hide();
            Form3.ShowDialog();
            this.Show();
        }
    }
}
