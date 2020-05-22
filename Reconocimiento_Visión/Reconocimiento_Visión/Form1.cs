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
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Threading;
using System.Data.SqlClient;

namespace Reconocimiento_Visión
{
    public partial class Form1 : Form
    {

        //DECLARAR VARIABLES
        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
        HaarCascade faceDetected;
        Image<Bgr, byte> Frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace = null;
        Image<Gray, byte> grayFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> Users = new List<string>();
        int Count, NumLabels, t;
        string name, names, Asunto, TextoCorreo = null;
        DataTable datos = new DataTable();
        SqlConnection cn;

        private void buttonAgendar_Click(object sender, EventArgs e)
        {
            if (TextName.Text != "")
            {
                DateTime fecha = DateTime.Now;
                Asunto = "Cita: " + fecha;
                TextoCorreo = "Saludos";
                EnvioCorreo sf = new EnvioCorreo(TextoCorreo, Asunto);
                Application.Idle += new EventHandler(FrameProcedure);
                TextName.Text = "";
                TextApellidos.Text = "";
                TextDireccion.Text = "";
                TextTelefono.Text = "";
                TextSangre.Text = "";
                TextEdad.Text = "";
                TextNSS.Text = "";
                TextMedico.Text = "";
            }
        }

        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Se agrega contador para conocer número de imagen a guardar
            Count = Count + 1;
            grayFace = camera.QueryGrayFrame().Resize(320,240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            MCvAvgComp[][] DetectedFaces = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            //Genera un cuadro de reconocimiento por cada rostro encontrado
            foreach (MCvAvgComp f in DetectedFaces[0])

            {

                TrainedFace = Frame.Copy(f.rect).Convert<Gray, byte>();
                break;

            }
            //Agrega nuevos valores a las variables
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(TextName.Text);
            //Agrega el nuevo número al archivo txt
            File.WriteAllText(Application.StartupPath + "/Faces/Faces.txt", trainingImages.ToArray().Length.ToString() + ",");
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                //Agrega el nombre al archivo txt y guarda la imagen 
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/Faces/Faces" + i + ".bmp");
                File.AppendAllText(Application.StartupPath + "/faces/faces.txt", labels.ToArray()[i - 1] + ",");

            }

            TextName.Text = "";
        }

        public Form1()
        {
            InitializeComponent();
            //HaarCascade (DETECTAR ROSTRO)
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
            try 
            {
                //Carga información rostros conocidos
                string labelsinf = File.ReadAllText(Application.StartupPath + "/Faces/Faces.txt");
                string[] Labels = labelsinf.Split(',');
                //El número antes de la "coma" sera el número de rostros guardados.
                NumLabels = Convert.ToInt16(Labels[0]);
                Count = NumLabels;
                string FacesLoad;
                for (int i = 1; i < NumLabels + 1; i++)
                {
                    //Agrega las imagenes y los nombres a las listas.
                    FacesLoad = "faces" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/Faces/" + FacesLoad));
                    labels.Add(Labels[i]);

                }

                //Inicia Camara
                camera = new Capture();
                camera.QueryFrame();
                Application.Idle += new EventHandler(FrameProcedure);

            }
            catch
            {
                camera = new Capture();
                camera.QueryFrame();
                Application.Idle += new EventHandler(FrameProcedure);
            }
        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            //Inicia la detección de los rostros
            Users.Add("");
            Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();
            MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            //Si encuentra un rostro lo compara contra lo ya existente
            foreach (MCvAvgComp f in facesDetectedNow[0])
            {
                //Dibujara el cuadro de reconocimiento en el caso de encontrar algún rostro
                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame.Draw(f.rect, new Bgr(Color.Green), 3);
                //Si existe algún rostro para comparar entra al siguiente IF
                if (trainingImages.ToArray().Length != 0)
                {

                    MCvTermCriteria termCriterias = new MCvTermCriteria(Count, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
                    //Si el rostro existe entre las imagenes extistentes lo asigna a la variable "name"
                    name = recognizer.Recognize(result);
                    if (name == String.Empty)
                    {
                        Frame.Draw("Desconocido", ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                        //TextName.Text = "Desconocido";
                        /*SE AGREGA CUANDO ES DESCONOCIDO
                        TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        trainingImages.Add(TrainedFace);
                        labels.Add(TextName.Text);
                        for (int s = 1; s < 3; s++)
                        {

                            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                            {

                                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/Desconocidos/Faces" + i + ".bmp");

                            }

                        }*/

                    }
                    ///*Enta cuando es conocido
                    else if (name != "Desconocido" || name != null)
                    {
                        Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.Red));
                        //Obtiene la información de la persona en la BD
                        datos = new DataTable();
                        cn = Conexion_DB_SQL.Conectar();
                        datos = Consulta_Paciente.Query_SQL_Paciente(name, cn);
                        //Llena los campos correspondientes al paciente
                        TextName.Text = Convert.ToString(datos.Rows[0]["NOMBRE"]);
                        TextApellidos.Text = Convert.ToString(datos.Rows[0]["APELLIDOS"]);
                        TextDireccion.Text = Convert.ToString(datos.Rows[0]["DIRECCION"]);
                        TextTelefono.Text = Convert.ToString(datos.Rows[0]["TELEFONO"]);
                        TextSangre.Text = Convert.ToString(datos.Rows[0]["TIPO_SANGRE"]);
                        TextEdad.Text = Convert.ToString(datos.Rows[0]["EDAD"]);
                        TextNSS.Text = Convert.ToString(datos.Rows[0]["NSS"]);
                        TextMedico.Text = Convert.ToString(datos.Rows[0]["MEDICO"]);
                        //Desactiva la camara*/
                        Application.Idle -= new EventHandler(FrameProcedure);
                        Form2 fr = new Form2(name);
                        fr.Show();
                    }

                }

                Users.Add("");

            }

            CamaraBox.Image = Frame;

            names = "";

            Users.Clear();

        }
    }
}
