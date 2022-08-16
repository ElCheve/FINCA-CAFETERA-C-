using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    class Recolector
    {
        public string nombre { get; set; }
        public long celular { get; set; }
        public long cedula { get; set; }
        public object fecha { get; set; }

        public Recolector(string nombre, long celular, long cedula, object fecha)
        {
            this.nombre = nombre;
            this.celular = celular;
            this.cedula = cedula;
            this.fecha = fecha;
        }

        public Recolector()
        {
           
        }

        public void RegistrarRecolector(long cedu, string nom, long cel, object fecha)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {

                string query = "INSERT INTO Recolectores VALUES (@cedula,@nombre,@celular,@fecha)";
                conexion.Open();

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@cedula", cedu);
                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@celular", cel);
                comando.Parameters.AddWithValue("@fecha", fecha);
                comando.ExecuteNonQuery();

                MessageBox.Show("¡Recolector ingresado correctamente!");
            }
        }

        public void MostrarRecolectores(DataGridView info)
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Recolectores", conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);                
                info.DataSource = tabla;
            }
        }
    }
}
