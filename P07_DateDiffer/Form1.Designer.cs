namespace P07_DateDiffer
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
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btonHesapla = new System.Windows.Forms.Button();
            this.lboxSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(273, 276);
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
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(112, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 3;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(112, 59);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 4;
            // 
            // btonHesapla
            // 
            this.btonHesapla.Location = new System.Drawing.Point(112, 108);
            this.btonHesapla.Name = "btonHesapla";
            this.btonHesapla.Size = new System.Drawing.Size(75, 23);
            this.btonHesapla.TabIndex = 5;
            this.btonHesapla.Text = "Hesapla";
            this.btonHesapla.UseVisualStyleBackColor = true;
            this.btonHesapla.Click += new System.EventHandler(this.btonHesapla_Click);
            // 
            // lboxSonuc
            // 
            this.lboxSonuc.FormattingEnabled = true;
            this.lboxSonuc.Location = new System.Drawing.Point(112, 153);
            this.lboxSonuc.Name = "lboxSonuc";
            this.lboxSonuc.Size = new System.Drawing.Size(200, 95);
            this.lboxSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 311);
            this.Controls.Add(this.lboxSonuc);
            this.Controls.Add(this.btonHesapla);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btonHesapla;
        private System.Windows.Forms.ListBox lboxSonuc;
    }
}

