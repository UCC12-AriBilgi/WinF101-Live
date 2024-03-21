namespace P02_Controls
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            this.btonClose = new System.Windows.Forms.Button();
            this.tmerSayac = new System.Windows.Forms.Timer(this.components);
            this.lbelSaat = new System.Windows.Forms.Label();
            this.btonStart = new System.Windows.Forms.Button();
            this.btonStop = new System.Windows.Forms.Button();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btonClose.Location = new System.Drawing.Point(526, 248);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(83, 48);
            this.btonClose.TabIndex = 6;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = false;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // tmerSayac
            // 
            this.tmerSayac.Tick += new System.EventHandler(this.tmerSayac_Tick);
            // 
            // lbelSaat
            // 
            this.lbelSaat.AutoSize = true;
            this.lbelSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelSaat.Location = new System.Drawing.Point(329, 39);
            this.lbelSaat.Name = "lbelSaat";
            this.lbelSaat.Size = new System.Drawing.Size(95, 31);
            this.lbelSaat.TabIndex = 13;
            this.lbelSaat.Text = "Label1";
            // 
            // btonStart
            // 
            this.btonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btonStart.Location = new System.Drawing.Point(41, 127);
            this.btonStart.Name = "btonStart";
            this.btonStart.Size = new System.Drawing.Size(83, 48);
            this.btonStart.TabIndex = 14;
            this.btonStart.Text = "Başlat";
            this.btonStart.UseVisualStyleBackColor = false;
            this.btonStart.Click += new System.EventHandler(this.btonStart_Click);
            // 
            // btonStop
            // 
            this.btonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btonStop.Location = new System.Drawing.Point(41, 201);
            this.btonStop.Name = "btonStop";
            this.btonStop.Size = new System.Drawing.Size(83, 48);
            this.btonStop.TabIndex = 15;
            this.btonStop.Text = "Durdur";
            this.btonStop.UseVisualStyleBackColor = false;
            this.btonStop.Click += new System.EventHandler(this.btonStop_Click);
            // 
            // nudInterval
            // 
            this.nudInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudInterval.Location = new System.Drawing.Point(353, 168);
            this.nudInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(71, 26);
            this.nudInterval.TabIndex = 16;
            this.nudInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.nudInterval);
            this.Controls.Add(this.btonStop);
            this.Controls.Add(this.btonStart);
            this.Controls.Add(this.lbelSaat);
            this.Controls.Add(this.btonClose);
            this.Name = "frmTimer";
            this.Text = "frmTimer";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.Timer tmerSayac;
        private System.Windows.Forms.Label lbelSaat;
        private System.Windows.Forms.Button btonStart;
        private System.Windows.Forms.Button btonStop;
        private System.Windows.Forms.NumericUpDown nudInterval;
    }
}