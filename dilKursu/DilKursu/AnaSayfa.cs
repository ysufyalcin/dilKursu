using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilKursu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            PanelDesign();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PanelDesign()
        {
            panel_ogrenciMenu.Visible = false;
            panel_kursMenu.Visible = false;
            panel_puanMenu.Visible = false;
        }

        private void HideMenu()
        {
            if(panel_ogrenciMenu.Visible==true)
                panel_ogrenciMenu.Visible=false;
            if(panel_kursMenu.Visible==true)
                panel_kursMenu.Visible=false;
            if (panel_puanMenu.Visible == true)
                panel_puanMenu.Visible=false;
        }

        private void ShowMenu(Panel menu)
        {
            if(menu.Visible == false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void button_ogrenci_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_ogrenciMenu);
        }

        private void button_ogrenciKayit_Click(object sender, EventArgs e)
        {
            HideMenu();
            Kayit kyt=new Kayit();
            kyt.Show();
            this.Hide();
        }

        private void button_ogrenciYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYonetim ogry = new OgrenciYonetim();
            ogry.Show();
            this.Hide();
        }

        private void button_ogrenciIcerik_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_ogrenciYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYazdir yzd = new OgrenciYazdir();
            yzd.Show();
            this.Hide();
        }

        private void button_kurs_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_kursMenu);
        }

        private void button_kursKayit_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniKurs yni = new YeniKurs();
            yni.Show();
            this.Hide();
        }

        private void button_kursYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            KayitYonetim kyt = new KayitYonetim();
            kyt.Show();
            this.Hide();
        }

        private void button_kursYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
        }

        private void button_puan_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_puanMenu);
        }

        private void button_puanYeni_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniPuan yni = new YeniPuan();
            yni.Show();
            this.Hide();
        }

        private void button_puanYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYonetim yon = new PuanYonetim();
            yon.Show();
            this.Hide();
        }

        private void button_puanYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYazdir yaz = new PuanYazdir();
            yaz.Show();
            this.Hide();
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
