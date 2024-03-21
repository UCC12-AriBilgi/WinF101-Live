namespace P02_Controls
{
    partial class frmComboBox
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
            this.btonClose = new System.Windows.Forms.Button();
            this.cboxSehir = new System.Windows.Forms.ComboBox();
            this.btonSay = new System.Windows.Forms.Button();
            this.lbelMessage = new System.Windows.Forms.Label();
            this.cboxHangi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSonuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btonClose.Location = new System.Drawing.Point(705, 390);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(83, 48);
            this.btonClose.TabIndex = 3;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = false;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // cboxSehir
            // 
            this.cboxSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSehir.FormattingEnabled = true;
            this.cboxSehir.Items.AddRange(new object[] {
            "Ankara",
            "Bursa",
            "İstanbul",
            "İzmir",
            "Adana"});
            this.cboxSehir.Location = new System.Drawing.Point(48, 37);
            this.cboxSehir.Name = "cboxSehir";
            this.cboxSehir.Size = new System.Drawing.Size(176, 28);
            this.cboxSehir.TabIndex = 4;
            // 
            // btonSay
            // 
            this.btonSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonSay.Location = new System.Drawing.Point(276, 32);
            this.btonSay.Name = "btonSay";
            this.btonSay.Size = new System.Drawing.Size(93, 36);
            this.btonSay.TabIndex = 5;
            this.btonSay.Text = "Say";
            this.btonSay.UseVisualStyleBackColor = true;
            this.btonSay.Click += new System.EventHandler(this.btonSay_Click);
            // 
            // lbelMessage
            // 
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelMessage.Location = new System.Drawing.Point(44, 116);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(53, 20);
            this.lbelMessage.TabIndex = 7;
            this.lbelMessage.Text = "label2";
            // 
            // cboxHangi
            // 
            this.cboxHangi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxHangi.FormattingEnabled = true;
            this.cboxHangi.Items.AddRange(new object[] {
            "Haftanın günleri",
            "Yıllar"});
            this.cboxHangi.Location = new System.Drawing.Point(48, 215);
            this.cboxHangi.Name = "cboxHangi";
            this.cboxHangi.Size = new System.Drawing.Size(176, 28);
            this.cboxHangi.TabIndex = 8;
            this.cboxHangi.SelectedIndexChanged += new System.EventHandler(this.cboxHangi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seçenekler";
            // 
            // cboxSonuc
            // 
            this.cboxSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSonuc.FormattingEnabled = true;
            this.cboxSonuc.Items.AddRange(new object[] {
            "Ankara",
            "Bursa",
            "İstanbul",
            "İzmir",
            "Adana"});
            this.cboxSonuc.Location = new System.Drawing.Point(276, 215);
            this.cboxSonuc.Name = "cboxSonuc";
            this.cboxSonuc.Size = new System.Drawing.Size(176, 28);
            this.cboxSonuc.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sonuç";
            // 
            // frmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxHangi);
            this.Controls.Add(this.lbelMessage);
            this.Controls.Add(this.btonSay);
            this.Controls.Add(this.cboxSehir);
            this.Controls.Add(this.btonClose);
            this.Name = "frmComboBox";
            this.Text = "frmComboBox";
            this.Load += new System.EventHandler(this.frmComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.ComboBox cboxSehir;
        private System.Windows.Forms.Button btonSay;
        public System.Windows.Forms.Label lbelMessage;
        private System.Windows.Forms.ComboBox cboxHangi;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSonuc;
        public System.Windows.Forms.Label label2;
    }
}