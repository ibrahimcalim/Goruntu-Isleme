using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goruntuislemeodevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dosyaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void araclarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkgetirme = new Form2();
            renkgetirme.ShowDialog();

        }

        private void kanalSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 kanalsiralama=new Form3();
            kanalsiralama.ShowDialog();
        }

        private void bT709AlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 BT709Algoritması = new Form4();
            BT709Algoritması.ShowDialog();
        }

        private void ortalamaDeğerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 Ortalamadeger = new Form5();
            Ortalamadeger.ShowDialog();
        }

        private void kanalÇıkarmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 Kanalcikarma = new Form6();
            Kanalcikarma.ShowDialog();
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 Lumayontemi = new Form7();
            Lumayontemi.ShowDialog();
        }

        private void açıklıkYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 Aciklikyontemi = new Form8();
            Aciklikyontemi.ShowDialog();
       
        }
    }
}
