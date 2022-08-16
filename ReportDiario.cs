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
    
    class ReportDiario : Reporte
    {

        
        public ReportDiario()
        {

        }
        public ReportDiario(object Fecha) : base(Fecha)
        {

        }
        public void InfoEmpleadoDiaria(TextBox Cantidad_Recogida, TextBox Total, ComboBox cmbRecolector, DateTimePicker fechita)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {             
                conexion.Open();
                string[] s = cmbRecolector.SelectedItem.ToString().Split(' ');
                int cedula = Convert.ToInt32(s[0]);            
                string query2 = "SELECT Peso, Pago FROM Producciones WHERE" +
                    "(Fecha_Recoleccion = '" + fechita.Text + "'" + "AND Cedula_recolector =" + cedula + ")";
                
                
                SqlCommand comando2 = new SqlCommand(query2, conexion);
                SqlDataReader registro2 = comando2.ExecuteReader();
                registro2.Read();

                MessageBox.Show(query2);
                Cantidad_Recogida.Text = registro2["Peso"].ToString();
                Total.Text = "$ " + registro2["Pago"].ToString();
                conexion.Close();
                
            }
        }
    }
}
    

