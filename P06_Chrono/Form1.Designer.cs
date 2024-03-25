namespace P06_Chrono
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
            this.components = new System.ComponentModel.Container();
            this.btonExit = new System.Windows.Forms.Button();
            this.lbelDakika = new System.Windows.Forms.Label();
            this.lbelSaniye = new System.Windows.Forms.Label();
            this.lbelSalise = new System.Windows.Forms.Label();
            this.btonStart = new System.Windows.Forms.Button();
            this.btonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(131, 148);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(75, 23);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // lbelDakika
            // 
            this.lbelDakika.AutoSize = true;
            this.lbelDakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbelDakika.Location = new System.Drawing.Point(28, 30);
            this.lbelDakika.Name = "lbelDakika";
            this.lbelDakika.Size = new System.Drawing.Size(44, 31);
            this.lbelDakika.TabIndex = 1;
            this.lbelDakika.Text = "00";
            // 
            // lbelSaniye
            // 
            this.lbelSaniye.AutoSize = true;
            this.lbelSaniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbelSaniye.Location = new System.Drawing.Point(88, 30);
            this.lbelSaniye.Name = "lbelSaniye";
            this.lbelSaniye.Size = new System.Drawing.Size(44, 31);
            this.lbelSaniye.TabIndex = 2;
            this.lbelSaniye.Text = "00";
            // 
            // lbelSalise
            // 
            this.lbelSalise.AutoSize = true;
            this.lbelSalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbelSalise.Location = new System.Drawing.Point(148, 30);
            this.lbelSalise.Name = "lbelSalise";
            this.lbelSalise.Size = new System.Drawing.Size(44, 31);
            this.lbelSalise.TabIndex = 3;
            this.lbelSalise.Text = "00";
            // 
            // btonStart
            // 
            this.btonStart.Location = new System.Drawing.Point(34, 96);
            this.btonStart.Name = "btonStart";
            this.btonStart.Size = new System.Drawing.Size(75, 23);
            this.btonStart.TabIndex = 4;
            this.btonStart.Text = "Başlat";
            this.btonStart.UseVisualStyleBackColor = true;
            this.btonStart.Click += new System.EventHandler(this.btonStart_Click);
            // 
            // btonStop
            // 
            this.btonStop.Location = new System.Drawing.Point(117, 96);
            this.btonStop.Name = "btonStop";
            this.btonStop.Size = new System.Drawing.Size(75, 23);
            this.btonStop.TabIndex = 5;
            this.btonStop.Text = "Durdur";
            this.btonStop.UseVisualStyleBackColor = true;
            this.btonStop.Click += new System.EventHandler(this.btonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 183);
            this.Controls.Add(this.btonStop);
            this.Controls.Add(this.btonStart);
            this.Controls.Add(this.lbelSalise);
            this.Controls.Add(this.lbelSaniye);
            this.Controls.Add(this.lbelDakika);
            this.Controls.Add(this.btonExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonExit;
        private System.Windows.Forms.Label lbelDakika;
        private System.Windows.Forms.Label lbelSaniye;
        private System.Windows.Forms.Label lbelSalise;
        private System.Windows.Forms.Button btonStart;
        private System.Windows.Forms.Button btonStop;
        private System.Windows.Forms.Timer timer1;
    }
}

