using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace InterfazFincaCafetera_Borr
{
    class VentaCafe : Reporte
    {

        public double PrecioVenta { get; set; }

        public VentaCafe(double precioVenta)
        {
            PrecioVenta = precioVenta;
        }

        public void RegistrarVentaCafe(double ganancias, TextBox txtPago, TextBox txtGanancias)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                int i = 1;
                string query2 = "SELECT SUM(Pago) AS PAGO FROM Producciones";
                conexion.Open();
                SqlCommand comando2 = new SqlCommand(query2, conexion);
                SqlDataReader dr = comando2.ExecuteReader();
                dr.Read();
                double pago = Convert.ToDouble(dr["PAGO"].ToString());
                conexion.Close();
                conexion.Open();
                string query = "INSERT INTO Ventas VALUES (@Ganancias, @Perdidas, @i)";
                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Ganancias", ganancias);
                comando.Parameters.AddWithValue("@Perdidas", pago);
                comando.Parameters.AddWithValue("@i", i);
                i++;
                comando.ExecuteNonQuery();
                MessageBox.Show("Produccion ingresada correctamente");
                double neto = ganancias - pago;
                txtPago.Text = "Se debe pagar en total: $" + pago;
                txtGanancias.Text = "Las ganancias fueron de: $" + neto;
            }
        }
    }
}