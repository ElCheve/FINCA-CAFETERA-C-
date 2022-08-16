using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmAdministrador : Form
    {
        public FrmAdministrador()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void BtnRegistrarR_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRegistrarRecolector reco = new FrmRegistrarRecolector();
            reco.ShowDialog();

        }
        private void BtnReporteDiario_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInformacionEmpleado dia = new FrmInformacionEmpleado();
            dia.Reporte = "Diario";
            dia.Show();
        }

        private void BtnReporteSemanal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInformacionEmpleado dia = new FrmInformacionEmpleado();
            dia.Reporte = "Semanal";
            dia.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized) this.WindowState = FormWindowState.Normal;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
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
