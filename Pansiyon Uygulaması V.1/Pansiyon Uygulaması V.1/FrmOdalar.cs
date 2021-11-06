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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }

        ConnectionID connect = new ConnectionID();

        private void FrmOdalar_Load(object sender, EventArgs e)
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
            }
        }
    }
}
