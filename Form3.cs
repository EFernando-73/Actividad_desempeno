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
using System.Data.SqlClient;

namespace conexion_sql
{
    public partial class Form3 : Form
    {
        public Form3()
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

       

        private void Form3_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = llenado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string eliminar = "DELETE FROM empadronado WHERE ID = @ID";
            SqlCommand cmd2 = new SqlCommand(eliminar, conexion.Conectar());
            cmd2.Parameters.AddWithValue("@ID", ID.Text);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Los datos fueron eliminados");

            dataGridView1.DataSource = llenado();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID.Text = dataGridView1.CurrentRow.Cells[0]. Value.ToString();
            }
            catch { }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            string buscar = "SELECT * FROM empadronado WHERE ID = @ID";
            SqlCommand cmd3 = new SqlCommand(buscar, conexion.Conectar());
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@ID", ID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd3);
            DataTable dt = new DataTable();

            da.Fill(dt);
            


        }
    }
}
