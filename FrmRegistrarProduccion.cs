using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrarProduccion : Form
    {
        public FrmRegistrarProduccion()
        {
            InitializeComponent();
        }
        private void BtnRegistrarProducción_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrar_Produccion regPro = new FrmRegistrar_Produccion();
            regPro.ShowDialog();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin frm= new FrmLogin();
            this.Close();
            frm.ShowDialog();
        }
    }
}
