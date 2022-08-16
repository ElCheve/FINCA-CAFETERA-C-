using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrar_Cafe : Form
    {
        public FrmRegistrar_Cafe()
        {
            InitializeComponent();
        }

        private void FrmRegistrar_Cafe_Load(object sender, EventArgs e)
        {

        }
        private void btnRegistrarCafé_Click(object sender, EventArgs e)
        {
            FrmRegistrar_peso_cafe Peso = new FrmRegistrar_peso_cafe();
            Peso.ShowDialog();
            this.Hide();
        }
        private void btnCancelCafé_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmRegistrar_Cafe_MouseDown(object sender, MouseEventArgs e)
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
