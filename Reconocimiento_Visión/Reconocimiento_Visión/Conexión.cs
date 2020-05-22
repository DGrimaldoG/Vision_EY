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
       class Conexion_DB_SQL
        {
            public static SqlConnection Conectar()
            {
                SqlConnection cn = new SqlConnection(Properties.Settings.Default.ConexionSQL);
                //cn.Open();
                return cn;
            }
        }
}
