using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace InterfazFincaCafetera_Borr
{

    class Login
    {
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public string rol { get; set; }

        public Login(string usuario, string contraseña, string rol)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.rol = rol;
        }

        public void Autenticar(string user, string pass, string rol)
        {

            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Username, Contraseña FROM Usuarios WHERE Username='"
                        + user + "' AND Contraseña='" + pass + "'" + " AND Rol='" + rol + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");                        
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }

}