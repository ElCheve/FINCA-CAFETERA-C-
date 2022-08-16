using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrar_peso_cafe : Form
    {
        public FrmRegistrar_peso_cafe()
        {
            InitializeComponent();
        }

        private void btn_cancelar_peso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBx_recolector_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbBx_recolector.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmRegistrar_peso_cafe_Load(object sender, EventArgs e)
        {
            Recoleccion Rec = new Recoleccion();
            Rec.EscogerRecolector(cmbBx_recolector);
        }


        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int Iparam);

        

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Recoleccion Reco = new Recoleccion();
            Reco.Registrar_Recoleccion(DtFecha.Value.Date, Convert.ToInt32(txtbx_peso_cafe.Text),
                TxtLugar.Text, Convert.ToInt32(TxtPrecio.Text), cmbBx_recolector);

            txtBx_pago_recolector.Text = "Se debe pagar $" +
            Convert.ToDouble(TxtPrecio.Text) * Convert.ToDouble(txtbx_peso_cafe.Text) + " al recolector";
            txtbx_peso_cafe.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLoginAll frm = new FrmLoginAll();
            frm.Show();
            
        }
    }
    }


