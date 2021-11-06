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
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void verilerigoster()
        {
            listView1.Items.Clear();
            SqlConnection conn = new SqlConnection(connect.Address);
            conn.Open();
            SqlCommand goster = new SqlCommand("Select * From Mesajlar", conn);
            SqlDataReader dr = goster.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["Mesajid"].ToString();
                ekle.SubItems.Add(dr["Adsoyad"].ToString());
                ekle.SubItems.Add(dr["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            conn.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAdSoyad.Text == "" && RchMesaj.Text == "")
            {
                MessageBox.Show("Müşteri Adı, Soyadı veya Mesaj bölümü boş bırakılamaz.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection conn = new SqlConnection(connect.Address);
                conn.Open();
                SqlCommand kaydet = new SqlCommand("insert into Mesajlar (Adsoyad, Mesaj) values (@p1, @p2)", conn);
                kaydet.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
                kaydet.Parameters.AddWithValue("@p2", RchMesaj.Text);
                kaydet.ExecuteNonQuery();
                conn.Close();
                verilerigoster();
            }
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            RchMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
