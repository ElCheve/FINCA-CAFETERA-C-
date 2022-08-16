using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace InterfazFincaCafetera_Borr
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            label1.Parent = pictureBox5;
            label2.Parent = pictureBox5;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            FrmLogin lg = new FrmLogin();
            lg.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmLogin lg = new FrmLogin();
            lg.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox5;
            label2.Parent = pictureBox5;
        }
    }

}
