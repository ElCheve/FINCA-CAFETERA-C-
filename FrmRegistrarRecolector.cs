using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrarRecolector : Form
    {
        public FrmRegistrarRecolector()
        {
            InitializeComponent();
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmAdministrador fa = new FrmAdministrador();
            this.Close();
            fa.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Recolector Rec = new Recolector(txtNombre.Text,
            Convert.ToInt64(txtCelular.Text), Convert.ToInt64(txtCedula.Text),
            DtFecha.Value.Date);

            Rec.RegistrarRecolector(Convert.ToInt64(txtCedula.Text), txtNombre.Text,
            Convert.ToInt64(txtCelular.Text), DtFecha.Value.Date);
            txtCedula.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Recolector Reco = new Recolector();
            Reco.MostrarRecolectores(DgvRecolectores);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAdministrador frm = new FrmAdministrador();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

