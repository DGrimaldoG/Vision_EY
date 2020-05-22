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

namespace Reconocimiento_Visión
{
    class Consulta_Paciente
    {
            public static DataTable Query_SQL_Paciente(string paciente, SqlConnection cn)
            {
            cn.Open();
                DataTable datos = new DataTable();
                string consulta = "SELECT * FROM INFO_PACIENTE WHERE NOMBRE = '" + paciente + "'";
                SqlCommand cmd = new SqlCommand(consulta, Conexion_DB_SQL.Conectar());
                SqlDataAdapter valor = new SqlDataAdapter(cmd);
                valor.Fill(datos);
                return datos;
            cn.Close();
            }
    }
}
