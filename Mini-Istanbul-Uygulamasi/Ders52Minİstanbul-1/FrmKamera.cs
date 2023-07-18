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
    public partial class FrmKamera : Form
    {
        public FrmKamera()
        {
            InitializeComponent();
        }

        private void btnkadıköycanlı_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/karakoy-2/");
        }

        private void FrmKamera_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnistiklalcanlı_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/istiklal-caddesi-2/");

        }

        private void btntaksim_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/taksim/");

        }

        private void btnbagdatcanlı_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/bagdat-caddesi/");

        }

        private void btnpiercanlı_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/pierre-lotti/");

        }

        private void btnemimönücanlı_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://istanbuluseyret.ibb.gov.tr/eminonu-3/");

        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa dön = new FrmAnaSayfa();
            dön.Show();
            this.Hide();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
