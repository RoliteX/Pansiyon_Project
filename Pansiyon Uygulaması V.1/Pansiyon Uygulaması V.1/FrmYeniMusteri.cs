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
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void BtnOda100_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "100";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda100 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda101 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda102 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda103 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda104 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda105 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda106 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda107 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda108 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda109 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda110_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "110";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda110 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnOda111_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "111";
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Oda111 (Adi, Soyadi) values (@p1, @p2)", conn);
            cmd.Parameters.AddWithValue("@p1", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Odaların Dolu Olduğunu Göstermektedir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBoş_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Odaların Boş Olduğunu Göstermektedir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DtpCikis_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikis.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(label11.Text) * 50;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand kaydet = new SqlCommand("insert into MusteriEkle (Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10)", conn);
            kaydet.Parameters.AddWithValue("@p1", TxtAd.Text);
            kaydet.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            kaydet.Parameters.AddWithValue("@p3", CmbCinsiyet.Text);
            kaydet.Parameters.AddWithValue("@p4", MskTelefon.Text);
            kaydet.Parameters.AddWithValue("@p5", TxtMail.Text);
            kaydet.Parameters.AddWithValue("@p6", MskTC.Text);
            kaydet.Parameters.AddWithValue("@p7", TxtOdaNo.Text);
            kaydet.Parameters.AddWithValue("@p8", TxtUcret.Text);
            kaydet.Parameters.AddWithValue("@p9", DtpGiris.Value.ToString("yyyy-MM-dd"));
            kaydet.Parameters.AddWithValue("@p10", DtpCikis.Value.ToString("yyyy-MM-dd"));
            kaydet.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri Bilgileri Kaydedildi.", "Müşteri Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Oda100", conn);
            SqlDataReader dr1 = cmd.ExecuteReader();

            // Oda 100

            while (dr1.Read())
            {
                BtnOda100.Text = dr1["Adi"].ToString() + " " + dr1["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda100.Text != "100")
            {
                BtnOda100.BackColor = Color.Red;
                BtnOda100.Enabled = false;
            }

            // Oda 101

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Select * From Oda101", conn);
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                BtnOda101.Text = dr2["Adi"].ToString() + " " + dr2["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }

            // Oda 102

            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Select * From Oda102", conn);
            SqlDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                BtnOda102.Text = dr3["Adi"].ToString() + " " + dr3["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }

            // Oda 103

            conn.Open();
            SqlCommand cmd4 = new SqlCommand("Select * From Oda103", conn);
            SqlDataReader dr4 = cmd4.ExecuteReader();

            while (dr4.Read())
            {
                BtnOda103.Text = dr4["Adi"].ToString() + " " + dr4["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }

            // Oda 104

            conn.Open();
            SqlCommand cmd5 = new SqlCommand("Select * From Oda104", conn);
            SqlDataReader dr5 = cmd5.ExecuteReader();

            while (dr5.Read())
            {
                BtnOda104.Text = dr5["Adi"].ToString() + " " + dr5["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }

            // Oda 105

            conn.Open();
            SqlCommand cmd6 = new SqlCommand("Select * From Oda105", conn);
            SqlDataReader dr6 = cmd6.ExecuteReader();

            while (dr6.Read())
            {
                BtnOda105.Text = dr6["Adi"].ToString() + " " + dr6["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }

            // Oda 106

            conn.Open();
            SqlCommand cmd7 = new SqlCommand("Select * From Oda106", conn);
            SqlDataReader dr7 = cmd7.ExecuteReader();

            while (dr7.Read())
            {
                BtnOda106.Text = dr7["Adi"].ToString() + " " + dr7["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }

            // Oda 107

            conn.Open();
            SqlCommand cmd8 = new SqlCommand("Select * From Oda107", conn);
            SqlDataReader dr8 = cmd8.ExecuteReader();

            while (dr8.Read())
            {
                BtnOda107.Text = dr8["Adi"].ToString() + " " + dr8["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda107.Text != "107")
            {
                BtnOda107.BackColor = Color.Red;
                BtnOda107.Enabled = false;
            }

            // Oda 108

            conn.Open();
            SqlCommand cmd9 = new SqlCommand("Select * From Oda108", conn);
            SqlDataReader dr9 = cmd9.ExecuteReader();

            while (dr9.Read())
            {
                BtnOda108.Text = dr9["Adi"].ToString() + " " + dr9["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda108.Text != "108")
            {
                BtnOda108.BackColor = Color.Red;
                BtnOda108.Enabled = false;
            }

            // Oda 109

            conn.Open();
            SqlCommand cmd10 = new SqlCommand("Select * From Oda109", conn);
            SqlDataReader dr10 = cmd10.ExecuteReader();

            while (dr10.Read())
            {
                BtnOda109.Text = dr10["Adi"].ToString() + " " + dr10["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda109.Text != "109")
            {
                BtnOda109.BackColor = Color.Red;
                BtnOda109.Enabled = false;
            }

            // Oda 110

            conn.Open();
            SqlCommand cmd11 = new SqlCommand("Select * From Oda110", conn);
            SqlDataReader dr11 = cmd11.ExecuteReader();

            while (dr11.Read())
            {
                BtnOda110.Text = dr11["Adi"].ToString() + " " + dr11["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda110.Text != "110")
            {
                BtnOda110.BackColor = Color.Red;
                BtnOda110.Enabled = false;
            }

            // Oda 111

            conn.Open();
            SqlCommand cmd12 = new SqlCommand("Select * From Oda111", conn);
            SqlDataReader dr12 = cmd12.ExecuteReader();

            while (dr12.Read())
            {
                BtnOda111.Text = dr12["Adi"].ToString() + " " + dr12["Soyadi"].ToString();
            }
            conn.Close();

            if (BtnOda111.Text != "111")
            {
                BtnOda111.BackColor = Color.Red;
                BtnOda111.Enabled = false;
            }
        }
    }
}
