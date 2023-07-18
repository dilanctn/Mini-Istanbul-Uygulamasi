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
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Image img = pictureBox1.Image;
            int zoomwidth = pictureBox1.Width;
            int zoomheight = pictureBox1.Height;
            if (img.Width<=(e.X+zoomwidth))
            {
                zoomwidth = img.Width - e.X;
            }
            if (img.Height<=(e.Y+zoomheight))
            {
                zoomheight = img.Height - e.Y;
            }
            Rectangle rec = new Rectangle(e.X, e.Y, zoomwidth, zoomheight);
            pictureBox2.Image = cropImage(img, rec);
            
        }
        private Image cropImage(Image img,Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpcrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpcrop);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
