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
    public partial class FrmMetrobüs : Form
    {
        public FrmMetrobüs()
        {
            InitializeComponent();
        }

        private void FrmMetrobüs_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Minİstanbul Metrobüs Durak Ve Hat Bilgileri";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(1) + textBox1.Text.Substring(0, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa anaSayfa = new FrmAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text== "34    -->Avcılar – Zincirlikuyu")
            {
                textBox1.Text = "Avcılar Kampüs - Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah.- Florya - Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ - Topkapı -Bayrampaşa (Maltepe) - Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy – Zincirlikuyu-";
            }
            if (comboBox1.Text== "34A -->Cevizlibağ – Söğütlüçeşme")
            {
                textBox1.Text = "Cevizlibağ - Topkapı - Bayrampaşa Maltepe - Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan - Mecidiyeköy - Zincirlikuyu - Boğaziçi Köprüsü - Burhaniye - Altunizade - Acıbadem - Uzunçayır - Fikirtepe – Söğütlüçeşme-";
            }
            if (comboBox1.Text== "34B -->Beylikdüzü – Avcılar ")
            {
                textBox1.Text = "Beylikdüzü Sondurak (TÜYAP) – Beykent - Cumhuriyet Mahallesi - Beylikdüzü Belediye – Beylikdüzü – Güzelyurt – Haramidere - Haramidere Sanayi - Saadetdere Mahallesi - Mustafa Kemalpaşa – Cihangir – Üniversite Mahallesi - Avcılar Merkez Üniversite Kampüsü";
            }
            if (comboBox1.Text== "34C -->Beylikdüzü (TÜYAP) – Cevizlibağ ")
            {
                textBox1.Text = "Beylikdüzü Sondurak (TÜYAP) – Beykent - Cumhuriyet Mahallesi - Beylikdüzü Belediye – Beylikdüzü – Güzelyurt – Haramidere - Haramidere Sanayi - Saadetdere Mahallesi - Mustafa Kemalpaşa – Cihangir – Üniversite Mahallesi - Avcılar Merkez Üniversite Kampüsü – Şükrübey - Büyükşehir Belediye Sosyal Tesisleri – Küçükçekmece - Cennet Mahallesi – Florya – Beşyol – Sefaköy – Yenibosna - Şirinevler (Ataköy) – Bahçelievler - İncirli – Ömür (Bakırköy) – Zeytinburnu – Merter – Cevizlibağ-";
            }
            if (comboBox1.Text== "34G -->Beylikdüzü (TÜYAP) – Söğütlüçeşme")
            {
                textBox1.Text = "Avcılar Kampüs-Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah. - Florya-Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ -Topkapı - Bayrampaşa (Maltepe) -Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy - Zincirlikuyu - Boğaziçi Köprüsü - Burhaniye - Altunizade - Acıbadem - Uzunçayır - Fikirtepe –Söğütlüçeşme-";
            }
            if (comboBox1.Text== "34Z -->Zincirlikuyu – Söğütlüçeşme")
            {
                textBox1.Text = "Zincirlikuyu - Boğaziçi Köprüsü - Burhaniye - Altunizade - Acıbadem - Uzunçayır - Fikirtepe – Söğütlüçeşme-";
            }
            if (comboBox1.Text== "34AS -->Avcılar (İÜ Kampüsü) – Söğütlüçeşme")
            {
                textBox1.Text = "Beylikdüzü Sondurak - Hadımköy - Cumhuriyet Mah.- Beylikdüzü Belediye - Beylikdüzü - Güzelyurt -Haramidere - Haramidere Sanayi - Saadetdere Mah. - Mustafa Kemal Paşa - Cihangir/Üniversite mah. - Avcılar Kampüs-Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah. - Florya-Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ -Topkapı - Bayrampaşa (Maltepe) -Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy – Zincirlikuyu-";
            }
            if (comboBox1.Text== "34BZ -->Beylikdüzü Sondurak (TÜYAP) – Zincirlikuyu")
            {
                textBox1.Text = "Beylikdüzü Sondurak - Hadımköy - Cumhuriyet Mah.- Beylikdüzü Belediye - Beylikdüzü - Güzelyurt -Haramidere - Haramidere Sanayi - Saadetdere Mah. - Mustafa Kemal Paşa - Cihangir/Üniversite mah. - Avcılar Kampüs-Şükrübey - İBB Sosyal Tesisler - Küçükçekmece - Cennet Mah. - Florya-Beşyol - Sefaköy -Yenibosna - Şirinevler - Bahçelievler - İncirli - Zeytinburnu - Merter - Cevizlibağ -Topkapı - Bayrampaşa (Maltepe) -Edirnekapı - Ayvansaray - Halıcıoğlu - Okmeydanı - Darülaceze - Okmeydanı Hastane - Çağlayan -Mecidiyeköy – Zincirlikuyu-";
            }
        }
    }
}
