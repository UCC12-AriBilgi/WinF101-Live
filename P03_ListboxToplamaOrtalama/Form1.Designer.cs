namespace P03_ListboxToplamaOrtalama
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSayi = new System.Windows.Forms.TextBox();
            this.btonEkle = new System.Windows.Forms.Button();
            this.lboxSayilar = new System.Windows.Forms.ListBox();
            this.btonExit = new System.Windows.Forms.Button();
            this.btonHesapla = new System.Windows.Forms.Button();
            this.tboxToplam = new System.Windows.Forms.TextBox();
            this.tboxOrtalama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btonTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı";
            // 
            // tboxSayi
            // 
            this.tboxSayi.Location = new System.Drawing.Point(69, 28);
            this.tboxSayi.Name = "tboxSayi";
            this.tboxSayi.Size = new System.Drawing.Size(91, 20);
            this.tboxSayi.TabIndex = 1;
            // 
            // btonEkle
            // 
            this.btonEkle.Location = new System.Drawing.Point(184, 25);
            this.btonEkle.Name = "btonEkle";
            this.btonEkle.Size = new System.Drawing.Size(75, 23);
            this.btonEkle.TabIndex = 2;
            this.btonEkle.Text = "Ekle";
            this.btonEkle.UseVisualStyleBackColor = true;
            this.btonEkle.Click += new System.EventHandler(this.btonEkle_Click);
            // 
            // lboxSayilar
            // 
            this.lboxSayilar.FormattingEnabled = true;
            this.lboxSayilar.Location = new System.Drawing.Point(69, 92);
            this.lboxSayilar.Name = "lboxSayilar";
            this.lboxSayilar.Size = new System.Drawing.Size(120, 160);
            this.lboxSayilar.TabIndex = 3;
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(190, 415);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(75, 23);
            this.btonExit.TabIndex = 4;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // btonHesapla
            // 
            this.btonHesapla.Location = new System.Drawing.Point(69, 282);
            this.btonHesapla.Name = "btonHesapla";
            this.btonHesapla.Size = new System.Drawing.Size(75, 23);
            this.btonHesapla.TabIndex = 5;
            this.btonHesapla.Text = "Hesapla";
            this.btonHesapla.UseVisualStyleBackColor = true;
            this.btonHesapla.Click += new System.EventHandler(this.btonHesapla_Click);
            // 
            // tboxToplam
            // 
            this.tboxToplam.Location = new System.Drawing.Point(138, 327);
            this.tboxToplam.Name = "tboxToplam";
            this.tboxToplam.Size = new System.Drawing.Size(100, 20);
            this.tboxToplam.TabIndex = 6;
            // 
            // tboxOrtalama
            // 
            this.tboxOrtalama.Location = new System.Drawing.Point(138, 362);
            this.tboxOrtalama.Name = "tboxOrtalama";
            this.tboxOrtalama.Size = new System.Drawing.Size(100, 20);
            this.tboxOrtalama.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Toplam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ortalama";
            // 
            // btonTemizle
            // 
            this.btonTemizle.Location = new System.Drawing.Point(195, 146);
            this.btonTemizle.Name = "btonTemizle";
            this.btonTemizle.Size = new System.Drawing.Size(75, 23);
            this.btonTemizle.TabIndex = 10;
            this.btonTemizle.Text = "Temizle";
            this.btonTemizle.UseVisualStyleBackColor = true;
            this.btonTemizle.Click += new System.EventHandler(this.btonTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 450);
            this.Controls.Add(this.btonTemizle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxOrtalama);
            this.Controls.Add(this.tboxToplam);
            this.Controls.Add(this.btonHesapla);
            this.Controls.Add(this.btonExit);
            this.Controls.Add(this.lboxSayilar);
            this.Controls.Add(this.btonEkle);
            this.Controls.Add(this.tboxSayi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxSayi;
        private System.Windows.Forms.Button btonEkle;
        private System.Windows.Forms.ListBox lboxSayilar;
        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Button btonHesapla;
        private System.Windows.Forms.TextBox tboxToplam;
        private System.Windows.Forms.TextBox tboxOrtalama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btonTemizle;
    }
}

