using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace conexion_sql
{
    class conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-MMFJ92H;DATABASE=tarea_coneccion;" +
                "integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
