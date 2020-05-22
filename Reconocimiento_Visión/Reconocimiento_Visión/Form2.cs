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
    public partial class Form2 : Form
    {
        SqlConnection cn;
        String motivo, area, nombre;
        public Form2(String name)
        {
            InitializeComponent();
            nombre = name;
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            motivo = TextMotivo.Text;
            area = ComboArea.Text;
            Properties.Settings.Default.Motivo = motivo;
            Properties.Settings.Default.Area = area;
            cn = Conexion_DB_SQL.Conectar();
            new Actualizar_Bd(nombre, motivo, cn);
            this.Close();
        }
    }
}
