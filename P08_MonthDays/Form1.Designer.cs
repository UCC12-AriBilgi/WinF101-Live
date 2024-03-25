namespace P08_MonthDays
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
            this.btonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cboxAylar = new System.Windows.Forms.ComboBox();
            this.btonListele = new System.Windows.Forms.Button();
            this.lboxGunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(173, 285);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(75, 23);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yıl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aylar";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(68, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cboxAylar
            // 
            this.cboxAylar.FormattingEnabled = true;
            this.cboxAylar.Location = new System.Drawing.Point(68, 59);
            this.cboxAylar.Name = "cboxAylar";
            this.cboxAylar.Size = new System.Drawing.Size(102, 21);
            this.cboxAylar.TabIndex = 4;
            // 
            // btonListele
            // 
            this.btonListele.Location = new System.Drawing.Point(68, 101);
            this.btonListele.Name = "btonListele";
            this.btonListele.Size = new System.Drawing.Size(75, 23);
            this.btonListele.TabIndex = 5;
            this.btonListele.Text = "Listele";
            this.btonListele.UseVisualStyleBackColor = true;
            this.btonListele.Click += new System.EventHandler(this.btonListele_Click);
            // 
            // lboxGunler
            // 
            this.lboxGunler.FormattingEnabled = true;
            this.lboxGunler.Location = new System.Drawing.Point(68, 146);
            this.lboxGunler.Name = "lboxGunler";
            this.lboxGunler.Size = new System.Drawing.Size(120, 95);
            this.lboxGunler.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 320);
            this.Controls.Add(this.lboxGunler);
            this.Controls.Add(this.btonListele);
            this.Controls.Add(this.cboxAylar);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cboxAylar;
        private System.Windows.Forms.Button btonListele;
        private System.Windows.Forms.ListBox lboxGunler;
    }
}

