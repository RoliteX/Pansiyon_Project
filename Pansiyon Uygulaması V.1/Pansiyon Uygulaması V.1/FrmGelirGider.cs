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
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtPerSayi.Text == "")
            {
                MessageBox.Show("Personel sayısı bölümü boş geçilemez.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int personel;
                personel = Convert.ToInt16(TxtPerSayi.Text);
                LblPerMaas.Text = (personel * 1500).ToString();

                int sonuc;
                sonuc = Convert.ToInt32(LblToplam.Text) - (Convert.ToInt32(LblPerMaas.Text) + Convert.ToInt32(LblUrunTutar.Text) + Convert.ToInt32(LblUrunTutar2.Text) + Convert.ToInt32(LblUrunTutar3.Text) + Convert.ToInt32(LblFaturalar.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));
                LblSonuc.Text = sonuc.ToString();
            }
            
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            // Kasadaki toplam tutar

            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand hesap = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", conn);
            SqlDataReader dr = hesap.ExecuteReader();
            while (dr.Read())
            {
                LblToplam.Text = dr["toplam"].ToString();
            }
            conn.Close();

            // Gıdalar

            conn.Open();
            SqlCommand hesap2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", conn);
            SqlDataReader dr2 = hesap2.ExecuteReader();
            while (dr2.Read())
            {
                LblUrunTutar.Text = dr2["toplam1"].ToString();
            }
            conn.Close();

            // İçecekler

            conn.Open();
            SqlCommand hesap3 = new SqlCommand("Select sum(İcecek) as toplam2 from Stoklar", conn);
            SqlDataReader dr3 = hesap3.ExecuteReader();
            while (dr3.Read())
            {
                LblUrunTutar2.Text = dr3["toplam2"].ToString();
            }
            conn.Close();

            // Atıştırmalıklar

            conn.Open();
            SqlCommand hesap4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", conn);
            SqlDataReader dr4 = hesap4.ExecuteReader();
            while (dr4.Read())
            {
                LblUrunTutar3.Text = dr4["toplam3"].ToString();
            }
            conn.Close();

            // Elektrik

            conn.Open();
            SqlCommand hesap5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", conn);
            SqlDataReader dr5 = hesap5.ExecuteReader();
            while (dr5.Read())
            {
                LblFaturalar.Text = dr5["toplam4"].ToString();
            }
            conn.Close();

            // Su

            conn.Open();
            SqlCommand hesap6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", conn);
            SqlDataReader dr6 = hesap6.ExecuteReader();
            while (dr6.Read())
            {
                LblFaturalar2.Text = dr6["toplam5"].ToString();
            }
            conn.Close();

            // İnternet

            conn.Open();
            SqlCommand hesap7 = new SqlCommand("Select sum(İnternet) as toplam6 from Faturalar", conn);
            SqlDataReader dr7 = hesap7.ExecuteReader();
            while (dr7.Read())
            {
                LblFaturalar3.Text = dr7["toplam6"].ToString();
            }
            conn.Close();
        }
    }
}
