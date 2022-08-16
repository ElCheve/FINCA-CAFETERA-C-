using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace InterfazFincaCafetera_Borr
{
    public partial class FrmRegistrar_Produccion : Form
    {
        public FrmRegistrar_Produccion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmE = new FrmEstadisticas();
            frmE.ShowDialog();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            VentaCafe ventas = new VentaCafe(Convert.ToDouble(TxtBx_Total_venta.Text));
            ventas.RegistrarVentaCafe(Convert.ToDouble(TxtBx_Total_venta.Text),
                txtbx_pagototal_recolectores, TxtGanancias);      
             TxtBx_Total_venta.Clear();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmRegistrarProduccion frm = new FrmRegistrarProduccion();
            this.Hide();
            frm.ShowDialog();
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




