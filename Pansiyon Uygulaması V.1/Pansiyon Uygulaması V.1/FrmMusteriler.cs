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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void verilerigoster()
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand musteriler = new SqlCommand("Select * From MusteriEkle", conn);
            SqlDataReader dr = musteriler.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Musteriid"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNo"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            MskTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikis.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNo.Text == "100")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda100", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "101")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda101", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "102")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda102", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "103")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda103", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "104")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda104", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "105")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda105", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "106")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda106", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "106")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda106", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "107")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda107", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "108")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda108", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "109")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda109", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "110")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda110", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }

            if (TxtOdaNo.Text == "111")
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand sil = new SqlCommand("Delete From Oda111", conn);
                sil.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Müşteri Odadan Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verilerigoster();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Clear();
            TxtSoyad.Clear();
            CmbCinsiyet.Text = "";
            MskTelefon.Text = "";
            TxtMail.Text = "";
            MskTC.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpGiris.Text = "";
            DtpCikis.Text = "";
            TxtAra.Clear();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand guncelle = new SqlCommand("Update MusteriEkle Set Adi=@p1, Soyadi=@p2, Cinsiyet=@p3, Telefon=@p4, Mail=@p5, TC=@p6, OdaNo=@p7, Ucret=@p8, GirisTarihi=@p9, CikisTarihi=@p10 where Musteriid= ("+ id +")", conn);
            guncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            guncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3", CmbCinsiyet.Text);
            guncelle.Parameters.AddWithValue("@p4", MskTelefon.Text);
            guncelle.Parameters.AddWithValue("@p5", TxtMail.Text);
            guncelle.Parameters.AddWithValue("@p6", MskTC.Text);
            guncelle.Parameters.AddWithValue("@p7", TxtOdaNo.Text);
            guncelle.Parameters.AddWithValue("@p8", TxtUcret.Text);
            guncelle.Parameters.AddWithValue("@p9", DtpGiris.Value.ToString("yyyy-MM-dd"));
            guncelle.Parameters.AddWithValue("@p10", DtpCikis.Value.ToString("yyyy-MM-dd"));
            guncelle.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand musteriler = new SqlCommand("Select * From MusteriEkle where Adi like '%" + TxtAra.Text + "%'", conn);
            SqlDataReader dr = musteriler.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Musteriid"].ToString();
                ekle.SubItems.Add(dr["Adi"].ToString());
                ekle.SubItems.Add(dr["Soyadi"].ToString());
                ekle.SubItems.Add(dr["Cinsiyet"].ToString());
                ekle.SubItems.Add(dr["Telefon"].ToString());
                ekle.SubItems.Add(dr["Mail"].ToString());
                ekle.SubItems.Add(dr["TC"].ToString());
                ekle.SubItems.Add(dr["OdaNo"].ToString());
                ekle.SubItems.Add(dr["Ucret"].ToString());
                ekle.SubItems.Add(dr["GirisTarihi"].ToString());
                ekle.SubItems.Add(dr["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            conn.Close();
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand sil = new SqlCommand("Delete From MusteriEkle where Musteriid = (" + id + ")", conn);
            sil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
