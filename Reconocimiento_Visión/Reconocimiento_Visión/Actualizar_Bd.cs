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
    class Actualizar_Bd
    {
        public Actualizar_Bd(String nombre, String motivo, SqlConnection cn)
        {
            string actualiza = "UPDATE INFO_PACIENTE " +
                "SET MOTIVO = '" + motivo + "'" + " WHERE NOMBRE = '" + nombre + "'";
            cn.Open();
            SqlCommand Com = new SqlCommand(actualiza, cn);
            Com.ExecuteNonQuery();
            cn.Close();
        }
    }
}