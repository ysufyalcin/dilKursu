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

namespace DilKursu
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wolf\Documents\KursDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void Kayit_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from OgrenciTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OgrenciDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            OgrenciPb.ImageLocation = openFileDialog1.FileName;
            OgrenciResimTb.Text=openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(OgrenciAdTb.Text=="" || OgrenciTelefonTb.Text=="" || OgrenciCinsCb.Text=="" || OgrenciAdresTb  .Text=="")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into OgrenciTbl values('" + OgrenciAdTb.Text + "','" + OgrenciTelefonTb.Text + "','" + Tarih.Text + "','" + OgrenciCinsCb.Text + "','" + OgrenciResimTb.Text + "','" + OgrenciAdresTb.Text + "')";
                    SqlCommand komut=new SqlCommand(query,baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ogrenci eklendi");
                    baglanti.Close();
                    uyeler();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciAdTb.Text = "";
            OgrenciTelefonTb.Text = "";
            OgrenciCinsCb.Text = "";
            OgrenciResimTb.Text = "";
            OgrenciAdresTb.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
