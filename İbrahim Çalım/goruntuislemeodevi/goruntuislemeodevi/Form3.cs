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
    public partial class Form3 : Form
    {
        Bitmap islem, kaynak;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GBR
            int yuk = kaynak.Height;
            int gen = kaynak.Width;

            islem = new Bitmap(gen, yuk);

            for(int y = 0; y < yuk; y++)
            {
                for(int x = 0; x < gen; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color siralanmis = Color.FromArgb(orjinal.G, orjinal.B, orjinal.R);
                    islem.SetPixel(x, y, siralanmis);
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
                islem.Save(saveFileDialog1.FileName);
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //RBG
            int yuk = kaynak.Height;
            int gen = kaynak.Width;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color siralanmis = Color.FromArgb(orjinal.R, orjinal.B, orjinal.G);
                    islem.SetPixel(x, y, siralanmis);
                }
            }
            islemBox.Image = islem;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // GRB
            int yuk = kaynak.Height;
            int gen = kaynak.Width;

            islem = new Bitmap(gen, yuk);

            for (int y = 0; y < yuk; y++)
            {
                for (int x = 0; x < gen; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    Color siralanmis = Color.FromArgb(orjinal.G, orjinal.R, orjinal.B);
                    islem.SetPixel(x, y, siralanmis);
                }
            }
            islemBox.Image = islem;
        }

        

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;
            }
        }
    }
}
