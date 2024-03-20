namespace P01_HelloWorld
{
    partial class frmMerhaba
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
            this.tboxAd = new System.Windows.Forms.TextBox();
            this.tboxSoyad = new System.Windows.Forms.TextBox();
            this.lbelMesaj = new System.Windows.Forms.Label();
            this.btonMesaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonExit.Location = new System.Drawing.Point(481, 365);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(106, 42);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adınız :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadınız :";
            // 
            // tboxAd
            // 
            this.tboxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAd.Location = new System.Drawing.Point(188, 22);
            this.tboxAd.Name = "tboxAd";
            this.tboxAd.Size = new System.Drawing.Size(182, 34);
            this.tboxAd.TabIndex = 3;
            // 
            // tboxSoyad
            // 
            this.tboxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSoyad.Location = new System.Drawing.Point(188, 90);
            this.tboxSoyad.Name = "tboxSoyad";
            this.tboxSoyad.Size = new System.Drawing.Size(182, 34);
            this.tboxSoyad.TabIndex = 4;
            // 
            // lbelMesaj
            // 
            this.lbelMesaj.AutoSize = true;
            this.lbelMesaj.Location = new System.Drawing.Point(35, 179);
            this.lbelMesaj.Name = "lbelMesaj";
            this.lbelMesaj.Size = new System.Drawing.Size(41, 15);
            this.lbelMesaj.TabIndex = 5;
            this.lbelMesaj.Text = "label3";
            // 
            // btonMesaj
            // 
            this.btonMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btonMesaj.Location = new System.Drawing.Point(188, 265);
            this.btonMesaj.Name = "btonMesaj";
            this.btonMesaj.Size = new System.Drawing.Size(109, 36);
            this.btonMesaj.TabIndex = 6;
            this.btonMesaj.Text = "Mesaj Ver";
            this.btonMesaj.UseVisualStyleBackColor = true;
            this.btonMesaj.Click += new System.EventHandler(this.btonMesaj_Click);
            // 
            // frmMerhaba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 419);
            this.Controls.Add(this.btonMesaj);
            this.Controls.Add(this.lbelMesaj);
            this.Controls.Add(this.tboxSoyad);
            this.Controls.Add(this.tboxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonExit);
            this.Name = "frmMerhaba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMerhaba";
            this.Load += new System.EventHandler(this.frmMerhaba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxAd;
        private System.Windows.Forms.TextBox tboxSoyad;
        private System.Windows.Forms.Label lbelMesaj;
        private System.Windows.Forms.Button btonMesaj;
    }
}