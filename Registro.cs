using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace conexion_sql
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {

            conexion.Conectar();
            string insertar = "INSERT INTO empadronado (ID,nombre1,nombre2,apellido,apellido2,cui,fecha_nacimiento)VALUES(@ID,@nombre1,@nombre2,@apellido,@apellido2,@cui,@fecha_nacimiento)";
            SqlCommand cmd1 = new SqlCommand(insertar, conexion.Conectar());
            cmd1.Parameters.AddWithValue("@ID", ID.Text);
            cmd1.Parameters.AddWithValue("@nombre1", nom1.Text);
            cmd1.Parameters.AddWithValue("@nombre2", nom2.Text);
            cmd1.Parameters.AddWithValue("@apellido", ape1.Text);
            cmd1.Parameters.AddWithValue("@apellido2", ape2.Text);
            cmd1.Parameters.AddWithValue("@cui", cui1.Text);
            cmd1.Parameters.AddWithValue("@fecha_nacimiento", fecha1.MinDate);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("los datos fueron agregados");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nom1.Clear();
            nom2.Clear();
            ape1.Clear();
            ape2.Clear();
            cui1.Clear();
            ID.Clear();
            nom1.Focus();

        }

        private void consulta1_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            this.Hide();
            Form3.ShowDialog();
            this.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}
