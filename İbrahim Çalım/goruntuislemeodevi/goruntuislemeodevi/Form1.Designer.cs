namespace goruntuislemeodevi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araclarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.reToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalSıralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709AlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaDeğerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalÇıkarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.araclarToolStripMenuItem,
            this.griYöntemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(286, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // araclarToolStripMenuItem
            // 
            this.araclarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reToolStripMenuItem,
            this.kanalSıralamaToolStripMenuItem});
            this.araclarToolStripMenuItem.Name = "araclarToolStripMenuItem";
            this.araclarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.araclarToolStripMenuItem.Text = "Araclar";
            this.araclarToolStripMenuItem.Click += new System.EventHandler(this.araclarToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // reToolStripMenuItem
            // 
            this.reToolStripMenuItem.Name = "reToolStripMenuItem";
            this.reToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reToolStripMenuItem.Text = "Renk Getirme";
            this.reToolStripMenuItem.Click += new System.EventHandler(this.reToolStripMenuItem_Click);
            // 
            // kanalSıralamaToolStripMenuItem
            // 
            this.kanalSıralamaToolStripMenuItem.Name = "kanalSıralamaToolStripMenuItem";
            this.kanalSıralamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kanalSıralamaToolStripMenuItem.Text = "Kanal Sıralama";
            this.kanalSıralamaToolStripMenuItem.Click += new System.EventHandler(this.kanalSıralamaToolStripMenuItem_Click);
            // 
            // griYöntemleriToolStripMenuItem
            // 
            this.griYöntemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bT709AlgoritmasıToolStripMenuItem,
            this.ortalamaDeğerToolStripMenuItem,
            this.kanalÇıkarmaToolStripMenuItem,
            this.lumaYöntemiToolStripMenuItem,
            this.açıklıkYöntemiToolStripMenuItem});
            this.griYöntemleriToolStripMenuItem.Name = "griYöntemleriToolStripMenuItem";
            this.griYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.griYöntemleriToolStripMenuItem.Text = "Gri Yöntemleri";
            // 
            // bT709AlgoritmasıToolStripMenuItem
            // 
            this.bT709AlgoritmasıToolStripMenuItem.Name = "bT709AlgoritmasıToolStripMenuItem";
            this.bT709AlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bT709AlgoritmasıToolStripMenuItem.Text = "BT 709 Algoritması";
            this.bT709AlgoritmasıToolStripMenuItem.Click += new System.EventHandler(this.bT709AlgoritmasıToolStripMenuItem_Click);
            // 
            // ortalamaDeğerToolStripMenuItem
            // 
            this.ortalamaDeğerToolStripMenuItem.Name = "ortalamaDeğerToolStripMenuItem";
            this.ortalamaDeğerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ortalamaDeğerToolStripMenuItem.Text = "Ortalama Değer";
            this.ortalamaDeğerToolStripMenuItem.Click += new System.EventHandler(this.ortalamaDeğerToolStripMenuItem_Click);
            // 
            // kanalÇıkarmaToolStripMenuItem
            // 
            this.kanalÇıkarmaToolStripMenuItem.Name = "kanalÇıkarmaToolStripMenuItem";
            this.kanalÇıkarmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kanalÇıkarmaToolStripMenuItem.Text = "Kanal Çıkarma";
            this.kanalÇıkarmaToolStripMenuItem.Click += new System.EventHandler(this.kanalÇıkarmaToolStripMenuItem_Click);
            // 
            // lumaYöntemiToolStripMenuItem
            // 
            this.lumaYöntemiToolStripMenuItem.Name = "lumaYöntemiToolStripMenuItem";
            this.lumaYöntemiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lumaYöntemiToolStripMenuItem.Text = "Luma Yöntemi";
            this.lumaYöntemiToolStripMenuItem.Click += new System.EventHandler(this.lumaYöntemiToolStripMenuItem_Click);
            // 
            // açıklıkYöntemiToolStripMenuItem
            // 
            this.açıklıkYöntemiToolStripMenuItem.Name = "açıklıkYöntemiToolStripMenuItem";
            this.açıklıkYöntemiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açıklıkYöntemiToolStripMenuItem.Text = "Açıklık Yöntemi";
            this.açıklıkYöntemiToolStripMenuItem.Click += new System.EventHandler(this.açıklıkYöntemiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 420);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Goruntu Isleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araclarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem kanalSıralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709AlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaDeğerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkYöntemiToolStripMenuItem;
    }
}

