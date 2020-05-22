using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Reconocimiento_Visión
{
    public partial class EnvioCorreo
    {
        public EnvioCorreo(string MailBody, string Asunto)
        {
            Boolean Confirmación;
            try
            {
                //Dani me la pela
                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("royez56@gmail.com", "alexi-200"),
                    EnableSsl = true
                };
                client.Send("royez56@gmail.com", "Rogelio.Yepez.Aguirre@mx.ey.com", Asunto, MailBody);

                Confirmación = true;
            }
            catch
            {
                Confirmación = false;
            }
        }
    }
}
