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
    public partial class Form2 : Form
    {
        Bitmap kaynak;

        public Form2()
        {
            InitializeComponent();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc== DialogResult.OK)
            {
                kaynak = new Bitmap(openFileDialog1.FileName);
                kaynakBox.Image = kaynak;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = int.Parse(xKor.Text);
            int y = int.Parse(yKor.Text);

            Color pikselrengi = kaynak.GetPixel(x, y);
             

            Console.WriteLine("R: " + pikselrengi.R + " G: " + pikselrengi.G + " B: " + pikselrengi.B);
            islembox.BackColor = pikselrengi;


            



        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            }
        }
    }

