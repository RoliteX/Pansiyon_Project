using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Pansiyon_Uygulaması_V._1
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand giris = new SqlCommand("Select * From AdminGiris where Kullanici = @p1 and Sifre = @p2", conn);
            giris.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            giris.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = giris.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaForm fra = new FrmAnaForm();
                fra.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Girişiniz Hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
