using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_Uygulaması_V._1
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGiris fra = new FrmAdminGiris();
            fra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fry = new FrmYeniMusteri();
            fry.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmOdalar fro = new FrmOdalar();
            fro.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer Pansiyon Project - 2021 - Taha Toklucu", "Hakkımızda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmGelirGider fgg = new FrmGelirGider();
            fgg.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmStoklar frs = new FrmStoklar();
            frs.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRadyoDinle frr = new FrmRadyoDinle();
            frr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmGazeteler frg = new FrmGazeteler();
            frg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle frs = new FrmSifreGuncelle();
            frs.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            frm.Show();
        }
    }
}
