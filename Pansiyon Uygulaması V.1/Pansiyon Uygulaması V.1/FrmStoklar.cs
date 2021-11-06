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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void veriler()
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand kaydet = new SqlCommand("Select * From Stoklar", conn);
            SqlDataReader dr = kaydet.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Gida"].ToString();
                ekle.SubItems.Add(dr["İcecek"].ToString());
                ekle.SubItems.Add(dr["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            conn.Close();
        }

        private void veriler2()
        {
            listView2.Items.Clear();
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand kaydet2 = new SqlCommand("Select * From Faturalar", conn);
            SqlDataReader dr2 = kaydet2.ExecuteReader();
            while (dr2.Read())
            {
                ListViewItem ekle2 = new ListViewItem();
                ekle2.Text = dr2["Elektrik"].ToString();
                ekle2.SubItems.Add(dr2["Su"].ToString());
                ekle2.SubItems.Add(dr2["İnternet"].ToString());
                listView2.Items.Add(ekle2);
            }
            conn.Close();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtElektrik.Text == "" && TxtInternet.Text == "" && TxtSu.Text == "")
            {
                MessageBox.Show("Elektrik, Su veya İnternet tutarları boş bırakılamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand kayit2 = new SqlCommand("insert into Faturalar (Elektrik, Su, İnternet) values (@p1, @p2, @p3)", conn);
                kayit2.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                kayit2.Parameters.AddWithValue("@p2", TxtSu.Text);
                kayit2.Parameters.AddWithValue("@p3", TxtInternet.Text);
                kayit2.ExecuteNonQuery();
                conn.Close();
                veriler2();
            }
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            if (TxtGidaTutar.Text == "" && TxtİcecekTutar.Text == "" && TxtAtistirmalik.Text == "")
            {
                MessageBox.Show("Gıda, İçecek veya Atıştırmalıkların tutarları boş bırakılamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand kayit = new SqlCommand("insert into Stoklar (Gida, İcecek, Cerezler) values (@p1, @p2, @p3)", conn);
                kayit.Parameters.AddWithValue("@p1", TxtGidaTutar.Text);
                kayit.Parameters.AddWithValue("@p2", TxtİcecekTutar.Text);
                kayit.Parameters.AddWithValue("@p3", TxtAtistirmalik.Text);
                kayit.ExecuteNonQuery();
                conn.Close();
                veriler();
            }
        }
    }
}
