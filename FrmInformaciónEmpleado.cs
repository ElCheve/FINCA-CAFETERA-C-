using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace InterfazFincaCafetera_Borr
{
    public partial class FrmInformacionEmpleado : Form
    {
       
        public String Reporte { get; set; }
        public FrmInformacionEmpleado()
        {
            InitializeComponent();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNombreRecolector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ReportDiario InfoDiaria = new ReportDiario();
            ReporteSemanal InfoSemanal = new ReporteSemanal();
            if (this.Reporte == "Diario")
            {
                 InfoDiaria.InfoEmpleadoDiaria(txtCantidadRecogida, txtTotal_A_Pagar, cmbNombreRecolector, DtFecha);
            }
            else if (this.Reporte == "Semanal")
            {
                InfoSemanal.InfoEmpleadoSemanal(txtCantidadRecogida, txtTotal_A_Pagar,
                    cmbNombreRecolector, DtFecha, DtFechaFinal);
            }
        }

        private void FrmInformacionEmpleado_Load(object sender, EventArgs e)
        {
            txtCantidadRecogida.Text = "0";
            txtTotal_A_Pagar.Text = "$ 0";
            Reporte llenar = new Reporte();
            llenar.LlenarCombobox(cmbNombreRecolector);
            if (this.Reporte == "Diario")
            {
                lblFechaInicio.Visible = false;
                lblFechaFinal.Visible = false;
                DtFechaFinal.Visible = false;
            }
            else if (this.Reporte == "Semanal")
            {
                lblFechaDiario.Visible = false;
            }
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
            this.Close();
            FrmAdministrador frmAdministrador = new FrmAdministrador();
            frmAdministrador.Show();
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