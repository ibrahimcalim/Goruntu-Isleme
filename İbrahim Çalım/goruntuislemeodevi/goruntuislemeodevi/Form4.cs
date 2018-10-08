using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; 

namespace goruntuislemeodevi
{
    public partial class Form4 : Form
    {
        Bitmap kaynak, islem;
       
        public Form4()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resimler|*.jpg;*.jpeg;*.png";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(openFileDialog1.FileName, format);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bT709UygulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for(int y = 0; y < yuk; y++)
            {
                for(int x = 0; x < gen; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    double bt = ((orjinal.R * 0.02125)+(orjinal.G * 0.7154)+(orjinal.B * 0.072));
                    int bt709 = Convert.ToInt16(bt);
                    Color bt709rengi = Color.FromArgb(bt709, bt709, bt709);
                    islem.SetPixel(x, y, bt709rengi);
                    
                }
            }islemBox.Image = islem;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(saveFileDialog1.FileName, format);
            }
        }
    }
}
