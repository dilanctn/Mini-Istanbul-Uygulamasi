using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders52Minİstanbul_1
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCamiler camibilgi = new FrmCamiler();
            camibilgi.Show();
            
        }

        private void btnvasıtaharita_Click(object sender, EventArgs e)
        {
            FrmHarita harita = new FrmHarita();
            harita.Show();
            this.Hide();
        }

        private void btncanlıkamera_Click(object sender, EventArgs e)
        {
            FrmKamera canlı = new FrmKamera();
            canlı.Show();
            this.Hide();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMetro metro = new FrmMetro();
            metro.Show();
            this.Hide();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMetrobüs metrobüsformu = new FrmMetrobüs();
            metrobüsformu.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FrmNeAlınır nealınır = new FrmNeAlınır();
            nealınır.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FrmNeYenir neyenir = new FrmNeYenir();
            neyenir.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKöprüler kopru = new FrmKöprüler();
            kopru.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMüzeler müze = new FrmMüzeler();
            müze.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmKorular koru = new FrmKorular();
            koru.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmÇarşılar çarşı = new FrmÇarşılar();
            çarşı.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAvm avm = new FrmAvm();
            avm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAdalar adalar = new FrmAdalar();
            adalar.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormFotolar foto = new FormFotolar();
            foto.Show();

        }
    }
}
