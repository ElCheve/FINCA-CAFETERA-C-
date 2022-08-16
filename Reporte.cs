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
    class Reporte : Recoleccion
    {
        public object Fecha { get; set; }

        public Reporte()
        {

        }
        public Reporte(object Fecha)
        {
            this.Fecha = Fecha;
        }

        public void LlenarCombobox(System.Windows.Forms.ComboBox cmbNombreRecolector)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "SELECT DISTINCT CONCAT(Cedula_recolector, ' - ', Nombre) AS Nombre_Cedula" +
                    " FROM Recolectores r JOIN Producciones p " +
                    "ON r.Cedula=p.Cedula_recolector";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registro = comando.ExecuteReader();

                while (registro.Read())
                {
                    cmbNombreRecolector.Items.Add(registro["Nombre_Cedula"]);
                }
                conexion.Close();
            }
        }
    }
}
