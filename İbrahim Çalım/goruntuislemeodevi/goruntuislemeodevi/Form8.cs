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
    public partial class Form8 : Form
    {
        Bitmap islem, kaynak;
        int[] renkler = new int[3];
        int sonuc;
        int sonuc1;
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG|*.png";
            ImageFormat format = ImageFormat.Png;
            DialogResult sonuc = saveFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                islem.Save(openFileDialog1.FileName);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uygulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for(int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    int maksimum = Math.Max(orjinal.R, orjinal.G);
                    int sonmaksimum = Math.Max(maksimum, orjinal.B);
                    int minimum = Math.Min(orjinal.R, orjinal.G);
                    int sonminumum = Math.Min(orjinal.B, minimum);
                    int sonuc = (sonmaksimum + sonminumum) / 2;
                    Color sonrenk = Color.FromArgb(sonuc, sonuc, sonuc);
                    islem.SetPixel(x, y, sonrenk);




                }
            }islemBox.Image = islem;
            

        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Görüntüler|*.png;*.jpeg;*.jpg";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
