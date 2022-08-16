
namespace InterfazFincaCafetera_Borr
{
    partial class FrmAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrador));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnReporteSemanal = new InterfazFincaCafetera_Borr.Style_Button();
            this.BtnReporteDiario = new InterfazFincaCafetera_Borr.Style_Button();
            this.BtnRegistrarR = new InterfazFincaCafetera_Borr.Style_Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(91)))), ((int)(((byte)(59)))));
            this.PanelTop.Controls.Add(this.pictureBox3);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.pictureBox2);
            this.PanelTop.Controls.Add(this.BtnMin);
            this.PanelTop.Controls.Add(this.BtnClose);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1067, 62);
            this.PanelTop.TabIndex = 11;
            this.PanelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(443, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Perfil Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::InterfazFincaCafetera_Borr.Properties.Resources.arrow_left_line1;
            this.pictureBox2.Location = new System.Drawing.Point(61, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnMin
            // 
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.Location = new System.Drawing.Point(940, 12);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(32, 32);
            this.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnMin.TabIndex = 1;
            this.BtnMin.TabStop = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(1001, 12);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 32);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnClose.TabIndex = 0;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // BtnReporteSemanal
            // 
            this.BtnReporteSemanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnReporteSemanal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnReporteSemanal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnReporteSemanal.BorderRadius = 20;
            this.BtnReporteSemanal.BorderSize = 0;
            this.BtnReporteSemanal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReporteSemanal.FlatAppearance.BorderSize = 0;
            this.BtnReporteSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporteSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteSemanal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnReporteSemanal.Location = new System.Drawing.Point(711, 263);
            this.BtnReporteSemanal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReporteSemanal.Name = "BtnReporteSemanal";
            this.BtnReporteSemanal.Size = new System.Drawing.Size(247, 78);
            this.BtnReporteSemanal.TabIndex = 9;
            this.BtnReporteSemanal.Text = "Reporte semanal";
            this.BtnReporteSemanal.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnReporteSemanal.UseVisualStyleBackColor = false;
            this.BtnReporteSemanal.Click += new System.EventHandler(this.BtnReporteSemanal_Click);
            // 
            // BtnReporteDiario
            // 
            this.BtnReporteDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnReporteDiario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnReporteDiario.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnReporteDiario.BorderRadius = 20;
            this.BtnReporteDiario.BorderSize = 0;
            this.BtnReporteDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReporteDiario.FlatAppearance.BorderSize = 0;
            this.BtnReporteDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporteDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporteDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnReporteDiario.Location = new System.Drawing.Point(396, 263);
            this.BtnReporteDiario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReporteDiario.Name = "BtnReporteDiario";
            this.BtnReporteDiario.Size = new System.Drawing.Size(255, 78);
            this.BtnReporteDiario.TabIndex = 8;
            this.BtnReporteDiario.Text = "Reporte diario";
            this.BtnReporteDiario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnReporteDiario.UseVisualStyleBackColor = false;
            this.BtnReporteDiario.Click += new System.EventHandler(this.BtnReporteDiario_Click);
            // 
            // BtnRegistrarR
            // 
            this.BtnRegistrarR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnRegistrarR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnRegistrarR.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRegistrarR.BorderRadius = 20;
            this.BtnRegistrarR.BorderSize = 0;
            this.BtnRegistrarR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegistrarR.FlatAppearance.BorderSize = 0;
            this.BtnRegistrarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnRegistrarR.Location = new System.Drawing.Point(99, 263);
            this.BtnRegistrarR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarR.Name = "BtnRegistrarR";
            this.BtnRegistrarR.Size = new System.Drawing.Size(235, 78);
            this.BtnRegistrarR.TabIndex = 7;
            this.BtnRegistrarR.Text = "Registrar recolectores";
            this.BtnRegistrarR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnRegistrarR.UseVisualStyleBackColor = false;
            this.BtnRegistrarR.Click += new System.EventHandler(this.BtnRegistrarR_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1067, 549);
            this.Controls.Add(this.PanelTop);
            this.Controls.Add(this.BtnReporteSemanal);
            this.Controls.Add(this.BtnReporteDiario);
            this.Controls.Add(this.BtnRegistrarR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1920, 1030);
            this.Name = "FrmAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdministrador";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.PictureBox BtnMin;
        private System.Windows.Forms.PictureBox BtnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Style_Button BtnReporteDiario;
        private Style_Button BtnRegistrarR;
        private Style_Button BtnReporteSemanal;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}