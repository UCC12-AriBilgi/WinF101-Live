namespace P04_ArttirAzalt
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rbtnArttir = new System.Windows.Forms.RadioButton();
            this.rbtnAzalt = new System.Windows.Forms.RadioButton();
            this.btonIslem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btonExit
            // 
            this.btonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonExit.Location = new System.Drawing.Point(189, 316);
            this.btonExit.Name = "btonExit";
            this.btonExit.Size = new System.Drawing.Size(75, 23);
            this.btonExit.TabIndex = 0;
            this.btonExit.Text = "Çıkış";
            this.btonExit.UseVisualStyleBackColor = true;
            this.btonExit.Click += new System.EventHandler(this.btonExit_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(95, 37);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // rbtnArttir
            // 
            this.rbtnArttir.AutoSize = true;
            this.rbtnArttir.Location = new System.Drawing.Point(95, 83);
            this.rbtnArttir.Name = "rbtnArttir";
            this.rbtnArttir.Size = new System.Drawing.Size(46, 17);
            this.rbtnArttir.TabIndex = 2;
            this.rbtnArttir.TabStop = true;
            this.rbtnArttir.Text = "Arttır";
            this.rbtnArttir.UseVisualStyleBackColor = true;
            // 
            // rbtnAzalt
            // 
            this.rbtnAzalt.AutoSize = true;
            this.rbtnAzalt.Location = new System.Drawing.Point(159, 83);
            this.rbtnAzalt.Name = "rbtnAzalt";
            this.rbtnAzalt.Size = new System.Drawing.Size(48, 17);
            this.rbtnAzalt.TabIndex = 3;
            this.rbtnAzalt.TabStop = true;
            this.rbtnAzalt.Text = "Azalt";
            this.rbtnAzalt.UseVisualStyleBackColor = true;
            // 
            // btonIslem
            // 
            this.btonIslem.Location = new System.Drawing.Point(95, 144);
            this.btonIslem.Name = "btonIslem";
            this.btonIslem.Size = new System.Drawing.Size(75, 23);
            this.btonIslem.TabIndex = 4;
            this.btonIslem.Text = "İşlem Yap";
            this.btonIslem.UseVisualStyleBackColor = true;
            this.btonIslem.Click += new System.EventHandler(this.btonIslem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sonuc : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Miktar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonIslem);
            this.Controls.Add(this.rbtnAzalt);
            this.Controls.Add(this.rbtnArttir);
            this.Controls.Add(this.numericUpDown1);
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton rbtnArttir;
        private System.Windows.Forms.RadioButton rbtnAzalt;
        private System.Windows.Forms.Button btonIslem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

