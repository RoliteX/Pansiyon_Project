using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Uygulaması_V._1
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand guncelle = new SqlCommand("Update AdminGiris Set Kullanici='" + TxtAd.Text + "', Sifre='" + TxtSifre.Text + "'", conn);
            guncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Admin Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
