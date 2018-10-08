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
    public partial class Form6 : Form
    {
        Bitmap kaynak,islem;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            //Yeşil rengi çıakrıyorum
        {
            int yukseklik = kaynak.Height;
            int genislik = kaynak.Width;

            islem = new Bitmap(genislik, yukseklik);

            for(int y = 0; y < yukseklik; y++)
            {
                for(int x = 0; x < genislik; x++)
                {
                    
                    Color orjinal = kaynak.GetPixel(x,y);
                    Color yesilrenksiz = Color.FromArgb(orjinal.R, 0, orjinal.B);
                    islem.SetPixel(x, y, yesilrenksiz);
                }
            }islemBox.Image = islem;
               
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

        private void button3_Click(object sender, EventArgs e)
        {
            //Mavi rengi çıkarıyorum
            int yukseklik = kaynak.Height;
            int genislik = kaynak.Width;

            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color mavirenksiz = Color.FromArgb(orjinal.R, orjinal.G, 0);
                    islem.SetPixel(x, y, mavirenksiz);
                }
            }
            islemBox.Image = islem;
        }

        private void button2_Click(object sender, EventArgs e)
            //Kırmızı rengi çıkarıyorum
        {
            int yukseklik = kaynak.Height;
            int genislik = kaynak.Width;

            islem = new Bitmap(genislik, yukseklik);

            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genislik; x++)
                {
                    
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color kirmizirenksiz = Color.FromArgb(0, orjinal.G, orjinal.B);
                    islem.SetPixel(x, y, kirmizirenksiz);
                }
            }
            islemBox.Image = islem;
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resimler|*.png;*.jpeg";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
