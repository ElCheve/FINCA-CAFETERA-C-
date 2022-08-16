using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginAll adminitrador = new FrmLoginAll();
            adminitrador.Perfil = "Administrador";
            adminitrador.ShowDialog();
        }

        private void BtnPropietario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginAll Propietario = new FrmLoginAll();
            Propietario.Perfil = "Propietario";
            Propietario.ShowDialog();
        }
        private void BtnMayordomo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLoginAll Mayordomo = new FrmLoginAll();
            Mayordomo.Perfil = "Mayordomo";
            Mayordomo.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Welcome frm=new Welcome();
            frm.Show();
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
