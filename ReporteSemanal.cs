using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    class ReporteSemanal : Reporte
    {
        public string FechaFinal { get; set; }

        public ReporteSemanal()
        {
        }

        public ReporteSemanal(string Fecha, string FechaFinal) : base(Fecha)
        {
            this.FechaFinal = FechaFinal;
        }

        public void InfoEmpleadoSemanal(System.Windows.Forms.TextBox Cantidad_Recogida,
    System.Windows.Forms.TextBox Total, System.Windows.Forms.ComboBox cmbRecolector, DateTimePicker fechita, DateTimePicker fecha)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                conexion.Open();
                string[] s = cmbRecolector.SelectedItem.ToString().Split(' ');
                int cedula = Convert.ToInt32(s[0]);
                string query = "SELECT SUM(Peso) AS Cantidad, SUM(Pago) AS Total FROM Producciones" +
                    " WHERE(Fecha_Recoleccion BETWEEN '" + fechita.Text + "' AND '" + fecha.Text + "') " +
                    "AND Cedula_recolector =" + cedula;             
                SqlCommand comando2 = new SqlCommand(query, conexion);
                SqlDataReader registro2 = comando2.ExecuteReader();
                registro2.Read();
                Cantidad_Recogida.Text = registro2["Cantidad"].ToString();
                Total.Text = "$ " + registro2["Total"].ToString();
                conexion.Close();
            }
        }
    }
}
