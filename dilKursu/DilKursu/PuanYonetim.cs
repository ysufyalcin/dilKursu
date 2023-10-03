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
    public partial class PuanYonetim : Form
    {
        public PuanYonetim()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Wolf\Documents\KursDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void PuanYonetim_Load(object sender, EventArgs e)
        {
            puanlar();
        }
        private void puanlar()
        {
            baglanti.Open();
            string query = "select * from PuanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        int Pid;
        private void button2_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || PuanTb.Text == "" || KursSecCb.Text == "")
            {
                MessageBox.Show("Silinecek puani secin");
            }
            else
            {
                try
                {
                    Pid = Convert.ToInt32(PuanDgv.SelectedRows[0].Cells[0].Value.ToString());
                    baglanti.Open();
                    string query = "delete from PuanTbl where PuanId= "+Pid+"";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Basariyla silindi");
                    baglanti.Close();
                    puanlar();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PuanDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pid = Convert.ToInt32(PuanDgv.SelectedRows[0].Cells[0].Value.ToString());
            OgrenciIdTb.Text = PuanDgv.SelectedRows[0].Cells[1].Value.ToString();
            PuanTb.Text = PuanDgv.SelectedRows[0].Cells[2].Value.ToString();
            KursSecCb.Text = PuanDgv.SelectedRows[0].Cells[3].Value.ToString();
            AciklamaTb.Text = PuanDgv.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OgrenciIdTb.Text == "" || PuanTb.Text == "" || KursSecCb.Text == "")
            {
                MessageBox.Show("Eksik bilgi");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update PuanTbl set OgrenciId=" + OgrenciIdTb.Text + ", Puan='" + PuanTb.Text + "', Kurs='" + KursSecCb.Text + "', Aciklama='" + AciklamaTb.Text + "' where PuanId=" + Pid + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(" puan guncellendi");
                    baglanti.Close();
                    puanlar();

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OgrenciIdTb.Text = "";
            PuanTb.Text = "";
            KursSecCb.Text = "";
            AciklamaTb.Text = "";
            
        }

        private void AraBt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PuanTbl where OgrenciId like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            puanlar();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AnaSayfa ana= new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
