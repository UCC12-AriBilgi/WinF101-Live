namespace P02_Controls
{
    partial class frmDateTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboxAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.btonGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btonClose.Location = new System.Drawing.Point(590, 390);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(83, 48);
            this.btonClose.TabIndex = 5;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = false;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adınız Soyadınız";
            // 
            // tboxAdSoyad
            // 
            this.tboxAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAdSoyad.Location = new System.Drawing.Point(215, 36);
            this.tboxAdSoyad.Name = "tboxAdSoyad";
            this.tboxAdSoyad.Size = new System.Drawing.Size(269, 26);
            this.tboxAdSoyad.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doğum Tarihiniz";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTarih.Location = new System.Drawing.Point(214, 92);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(250, 26);
            this.dtpTarih.TabIndex = 15;
            // 
            // btonGoster
            // 
            this.btonGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btonGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btonGoster.Location = new System.Drawing.Point(28, 164);
            this.btonGoster.Name = "btonGoster";
            this.btonGoster.Size = new System.Drawing.Size(83, 48);
            this.btonGoster.TabIndex = 16;
            this.btonGoster.Text = "Göster";
            this.btonGoster.UseVisualStyleBackColor = false;
            this.btonGoster.Click += new System.EventHandler(this.btonGoster_Click);
            // 
            // frmDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.btonGoster);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxAdSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonClose);
            this.Name = "frmDateTime";
            this.Text = "frmDateTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Button btonGoster;
    }
}