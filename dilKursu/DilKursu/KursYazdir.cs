using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DilKursu
{
    public partial class KursYazdir : Form
    {
        public KursYazdir()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wolf\Documents\KursDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void KursYazdir_Load(object sender, EventArgs e)
        {
            uyeler();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from KursTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            KYonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void AraBt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KursTbl where KursAdi like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            KYonetimDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.KYonetimDgv.Width, this.KYonetimDgv.Height);
            KYonetimDgv.DrawToBitmap(bmp, new Rectangle(0,0,this.KYonetimDgv.Width,this.KYonetimDgv.Height));
            e.Graphics.DrawImage(bmp, 20, 150);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void KYonetimDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
