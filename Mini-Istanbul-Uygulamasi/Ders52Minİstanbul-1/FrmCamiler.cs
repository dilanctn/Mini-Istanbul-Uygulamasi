using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ders52Minİstanbul_1
{
    public partial class FrmCamiler : Form
    {
        public FrmCamiler()
        {
            InitializeComponent();
        }
        OleDbConnection bagla = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\CamiAd.mdb");

        private void button3_Click(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bagla;
            komut.CommandText = "Select *from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text=oku["sultanahmet"].ToString();
            }
            bagla.Close();

            pictureBox1.ImageLocation = @"C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\camiler\sultanahmet camii.jpg";
            webBrowser1.Navigate ("https://www.google.com.tr/maps/place/Sultan+Ahmet+Camii/@41.0052934,28.9742597,16.75z/data=!4m5!3m4!1s0x14cab9bd6570f4e1:0xe52df7368a157ca4!8m2!3d41.0054096!4d28.9768138?hl=tr&authuser=0");

        }

        private void button8_Click(object sender, EventArgs e)
        {
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bagla;
            komut.CommandText = "Select * from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["yenicamii"].ToString();
            }
            bagla.Close();
            pictureBox1.ImageLocation = @"C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\camiler\Yeni_Camii.JPG";
            webBrowser1.Navigate ("https://www.google.com.tr/maps/place/Yeni+Cami/@41.0169862,28.9697707,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab9eba0aba48d:0x653381c9eafc239c!8m2!3d41.016848!4d28.9717702?hl=tr&authuser=0");
        }

        private void FrmCamiler_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnayasofya_Click(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bagla;
            komut.CommandText = "Select * from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["ayasofya"].ToString();
            }
            bagla.Close();
            pictureBox1.ImageLocation = @"C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\camiler\ayasofya.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Ayasofya+Camii/@41.008587,28.9779863,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab9be92011c27:0x236e6f6f37444fae!8m2!3d41.008583!4d28.980175?hl=tr&authuser=0");

        }

        private void btnortaköy_Click(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bagla;
            komut.CommandText = "Select * from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["ortaköy"].ToString();
            }
            bagla.Close();
            pictureBox1.ImageLocation = @"C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\camiler\ortaköy.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/B%C3%BCy%C3%BCk+Mecidiye+Camii+(Ortak%C3%B6y+Camii)/@41.0472515,29.0248203,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab7c8e42887ad:0xfd73f2a29eafc8bc!8m2!3d41.0472515!4d29.027009?hl=tr&authuser=0");
        }

        private void btnfatih_Click(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bagla;
            komut.CommandText = "Select * from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["fatih"].ToString();
            }
            bagla.Close();
            pictureBox1.ImageLocation = @"C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\camiler\Fatih_camii.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Fatih+Camii/@41.0196061,28.9477327,17z/data=!3m1!4b1!4m5!3m4!1s0x14caba21ca2b1031:0xbcb8746d3c867663!8m2!3d41.0194273!4d28.9501042?hl=tr&authuser=0");
        }

        private void btnsüleymaniye_Click(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bagla;
            komut.CommandText = "Select * from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["süleymaniye"].ToString();
            }
            bagla.Close();
            pictureBox1.ImageLocation = @"C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\camiler\üleymaniye_Mosque.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/S%C3%BCleymaniye+Camii/@41.0161775,28.9619646,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab98d3ac01031:0x8accf5042157cfed!8m2!3d41.0161775!4d28.9641533?hl=tr&authuser=0");
        }

        private void btnbeyazid_Click(object sender, EventArgs e)
        {
            bagla.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = bagla;
            komut.CommandText = "Select * from CamiAd";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                richTextBox1.Text = oku["beyazid"].ToString();
            }
            bagla.Close();
            pictureBox1.ImageLocation = @"C:\Users\Monster\Desktop\Mydağ\Ders52Minİstanbul\camiler\beyazid.jpg";
            webBrowser1.Navigate("https://www.google.com.tr/maps/place/Beyaz%C4%B1t+Camii/@41.010222,28.9630139,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab991d73292a1:0xc5894f505ceb16fa!8m2!3d41.0100054!4d28.9648621?hl=tr&authuser=0");
        }
    }
}
