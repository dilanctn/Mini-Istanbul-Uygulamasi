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
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Minİstanbul Programı Metro Durakları";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "M1B metro hattı (Kirazlı - Bağcılar‎→Yenikapı)")
            {
                textBox1.Text = "Kirazlı-Bağcılar Meydan-Üçyüzlü-Menderes-Esenler-Otogar-Kocatepe-Sağmalcılar-Bayrampaşa - Maltepe-Topkapı - Ulubatlı-Emniyet - Fatih-Aksaray-Yenikapı-";
            }
            if (comboBox1.Text== "M2 metro hattı (Hacıosman‎→Yenikapı)")
            {
                textBox1.Text = "Hacıosman-Darüşşafaka-Atatürk Oto Sanayi-İtü Ayazağa-Sanayi-4. Levent-Levent-Gayrettepe-Şişli/Mecidiyeköy-Osmanbey-Taksim-Şişhane-Haliç-Vezneciler-Yenikapı-";
            }
            if (comboBox1.Text== "M3 metro hattı (Başakşehir - Metrokent‎→Kirazlı - Bağcılar)")
            {
                textBox1.Text = "Metrokent-Başak Konutları-Siteler-Turgut Özal-İkitelli Sanayi-İstoç-Mahmutbey-Yenimahalle-Kirazlı-";
            }
            if (comboBox1.Text== "M4 metro hattı (Kadıköy‎→Tavşantepe)")
            {
                textBox1.Text = "Kadıköy-Ayrılık Çeşmesi-Acıbadem-Ünalan-Göztepe-Yenisahra-Kozyatağı-Bostancı-Küçükyalı-Maltepe-Huzurevi-Gülsuyu-Esenkent-Hastane - Adliye-Soğanlık-Kartal-Yakacık-Pendik-Tavşantepe-";
            }
            if (comboBox1.Text== "TF1 metro hattı (Maçka‎→Taşkışla)")
            {
                textBox1.Text = "Maçka-Taşkişla-";
            }
            if (comboBox1.Text== "TF2 metro hattı (Eyüp‎→Pierre Loti)")
            {
                textBox1.Text = "Eyüp-Pierreloti-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaform = new FrmAnaSayfa();
            anaform.Show();
            this.Hide();
        }
    }
}
