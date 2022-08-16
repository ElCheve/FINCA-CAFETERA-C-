using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;
using System.Drawing;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmEstadisticas : Form
    {
        public FrmEstadisticas()
        {
            InitializeComponent();
        }

        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {

        }

        private void FrmEstadisticas_Load_1(object sender, EventArgs e)
        {
            //traer las ganancias del reporte mensual

            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "SELECT SUM(Ganancias) AS Ganancias_totales, Perdidas FROM Ventas GROUP BY Perdidas";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                double ganacias = 0;
                double perdidas = 0;
                while (registro.Read())
                {
                    
                    ganacias = Convert.ToDouble(registro["Ganancias_totales"].ToString());
                    perdidas = Convert.ToDouble(registro["Perdidas"].ToString());
                    
                }
                double porc_ganancias = 100 - (100 * perdidas / ganacias);
                Title titulo = grafica_ganancias.Titles.Add("Gráfica de comparación");
                titulo.ShadowColor = System.Drawing.Color.Black;
                titulo.ShadowOffset = 1;
                titulo.ForeColor = System.Drawing.Color.Brown;
                titulo.BorderWidth = 2;
                titulo.Font = new System.Drawing.Font("Arial", 24, FontStyle.Bold);
               

                Series series = grafica_ganancias.Series.Add("Ganancias");
                Series series2 = grafica_ganancias.Series.Add("Perdidas");
                series.BackGradientStyle = GradientStyle.TopBottom;
                series2.BackGradientStyle = GradientStyle.HorizontalCenter;
                series.Color = System.Drawing.Color.Green;
                series2.Color = System.Drawing.Color.Red;
                series.ShadowColor = System.Drawing.Color.Black;
                series.ShadowOffset = 3;
                series2.ShadowColor = System.Drawing.Color.Black;
                series2.ShadowOffset = 3;

                series.Points.Add(ganacias);
                series2.Points.Add(perdidas);
                


                txtbx_ganancias_year.Text = ("La producción " +
                    "ha generado una ganancia del "
                     + Math.Round(porc_ganancias,2) + "%");

            }
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
            [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
            private extern static void ReleaseCapture();
            [DllImport("user32.dll", EntryPoint = "SendMessage")]
            private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);
      
    }
}
