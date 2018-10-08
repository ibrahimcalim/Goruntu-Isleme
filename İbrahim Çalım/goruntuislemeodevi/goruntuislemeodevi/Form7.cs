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
    public partial class Form7 : Form
    {
        Bitmap islem, kaynak;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gen = kaynak.Width;
            int yuk = kaynak.Height;

            islem = new Bitmap(gen, yuk);

            for(int y = 0; y < yuk; y++)
            {
                for(int x = 0; x < gen; x++)
                {
                    Color orjinal = kaynak.GetPixel(x, y);
                    double ibrahim=(orjinal.R*0.3+orjinal.G*0.59+orjinal.B*0.11);
                    int ibrahim1 = Convert.ToInt16(ibrahim);
                    Color luma = Color.FromArgb(ibrahim1, ibrahim1, ibrahim1);
                    islem.SetPixel(x, y, luma);
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
