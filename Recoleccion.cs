using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
   class Recoleccion : Recolector
    {
        public object Fecha_Recolección { get; set; }
        public double Peso_Cafe { get; set; }

        public string Lugar_Recolección { get; set; }
        public int Precio_Café { get; set; }

        public Recoleccion(object fecha_Recolección, double peso_Cafe, 
            string lugar_Recolección, int precio_Café) : base ()
        {
            Fecha_Recolección = fecha_Recolección;
            Peso_Cafe = peso_Cafe;
            Lugar_Recolección = lugar_Recolección;
            Precio_Café = precio_Café;
        }

        public Recoleccion()
        {
        }

        public void EscogerRecolector(ComboBox cmb)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "SELECT CONCAT(Cedula, ' - ', Nombre) as NombreCompleto FROM Recolectores";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cmb.Items.Add(registro["NombreCompleto"]);

                }
                conexion.Close();
            }
        }

        public void Registrar_Recoleccion(object Fecha_Recolección, int Peso_Cafe, string Lugar_Recolección, int Precio_Cafe, ComboBox combo)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                string query = "INSERT INTO Producciones VALUES (@Peso, @Costo, @Pago, @Cedula, @Fecha, @Lugar)";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Peso", Peso_Cafe);
                comando.Parameters.AddWithValue("@Costo", Precio_Cafe);
                double pago = Convert.ToDouble(Precio_Cafe) * Convert.ToDouble(Peso_Cafe);
                comando.Parameters.AddWithValue("@Pago", pago);
                char c = ' ';
                string[] s = combo.Text.Split(c);
                comando.Parameters.AddWithValue("@Cedula", s[0]);
                comando.Parameters.AddWithValue("@Fecha", Fecha_Recolección);
                comando.Parameters.AddWithValue("@Lugar", Lugar_Recolección);
                comando.ExecuteNonQuery();
                MessageBox.Show("Peso ingresado correctamente");
                conexion.Close();
            }
        }
        
    }
}
