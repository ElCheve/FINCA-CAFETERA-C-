using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace InterfazFincaCafetera_Borr
{
    public partial class FrmLoginAll : Form
    {
        public FrmLoginAll()
        {
            InitializeComponent();
        }
        public String Perfil { get; set; }


        private void FrmLoginAll_Load(object sender, EventArgs e)
        {
            if (this.Perfil == "Administrador")
            {
                PicPerfil.Image = imageList1.Images[2];
            }
            else
            {
                if (this.Perfil == "Mayordomo")
                {
                    PicPerfil.Image = imageList1.Images[0];
                }
                else
                {
                    if (this.Perfil == "Propietario")
                    {
                        PicPerfil.Image = imageList1.Images[1];
                    }
                }
            }
        }


        private void BtnEnterLoginAll_Click(object sender, EventArgs e)
        {
            Login lg = new Login(txtUser.Text, txtPass.Text, "");
            if (this.Perfil == "Administrador")
            {
                try
                {
                    lg.Autenticar(txtUser.Text, txtPass.Text, "Administrador");
                    FrmAdministrador admin = new FrmAdministrador();
                    admin.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                if (this.Perfil == "Mayordomo")
                {
                    try
                    {
                        lg.Autenticar(txtUser.Text, txtPass.Text, "Mayordomo");
                        FrmRegistrar_Cafe mayor = new FrmRegistrar_Cafe();
                        mayor.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    if (this.Perfil == "Propietario")
                    {
                        try
                        {
                            lg.Autenticar(txtUser.Text, txtPass.Text, "Propietario");
                            FrmRegistrarProduccion prop = new FrmRegistrarProduccion();
                            prop.Show();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            this.Hide();

        }

        private void BtnCancelLoginAll_Click(object sender, EventArgs e)
        {
            Welcome frem= new Welcome();
            this.Close();
            frem.Show();
        }

        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
        }

        private void PanelTop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
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
