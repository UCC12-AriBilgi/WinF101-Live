namespace P02_Controls
{
    partial class frmCheckedListBox
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
            this.chkbDiller = new System.Windows.Forms.CheckedListBox();
            this.btonMessage = new System.Windows.Forms.Button();
            this.lbelMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnHepsi = new System.Windows.Forms.RadioButton();
            this.rbtnHicbiri = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
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
            this.btonClose.TabIndex = 2;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = false;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hangi programlama dilleriyle uğraşıyorsunuz?";
            // 
            // chkbDiller
            // 
            this.chkbDiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbDiller.FormattingEnabled = true;
            this.chkbDiller.Items.AddRange(new object[] {
            "CSharp",
            "Java",
            "C++",
            "Embarcadero Pascal",
            "C",
            "Javascript",
            "PHP",
            "Python"});
            this.chkbDiller.Location = new System.Drawing.Point(34, 73);
            this.chkbDiller.Name = "chkbDiller";
            this.chkbDiller.Size = new System.Drawing.Size(208, 214);
            this.chkbDiller.TabIndex = 4;
            // 
            // btonMessage
            // 
            this.btonMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonMessage.Location = new System.Drawing.Point(34, 308);
            this.btonMessage.Name = "btonMessage";
            this.btonMessage.Size = new System.Drawing.Size(122, 40);
            this.btonMessage.TabIndex = 5;
            this.btonMessage.Text = "Mesaj Ver";
            this.btonMessage.UseVisualStyleBackColor = true;
            this.btonMessage.Click += new System.EventHandler(this.btonMessage_Click);
            // 
            // lbelMessage
            // 
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelMessage.Location = new System.Drawing.Point(31, 390);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(66, 25);
            this.lbelMessage.TabIndex = 6;
            this.lbelMessage.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHicbiri);
            this.groupBox1.Controls.Add(this.rbtnHepsi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(276, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçiminiz";
            // 
            // rbtnHepsi
            // 
            this.rbtnHepsi.AutoSize = true;
            this.rbtnHepsi.Location = new System.Drawing.Point(31, 44);
            this.rbtnHepsi.Name = "rbtnHepsi";
            this.rbtnHepsi.Size = new System.Drawing.Size(121, 24);
            this.rbtnHepsi.TabIndex = 0;
            this.rbtnHepsi.TabStop = true;
            this.rbtnHepsi.Text = "Hepsini Seç";
            this.rbtnHepsi.UseVisualStyleBackColor = true;
            // 
            // rbtnHicbiri
            // 
            this.rbtnHicbiri.AutoSize = true;
            this.rbtnHicbiri.Location = new System.Drawing.Point(31, 92);
            this.rbtnHicbiri.Name = "rbtnHicbiri";
            this.rbtnHicbiri.Size = new System.Drawing.Size(144, 24);
            this.rbtnHicbiri.TabIndex = 1;
            this.rbtnHicbiri.TabStop = true;
            this.rbtnHicbiri.Text = "Hepsini Seçme";
            this.rbtnHicbiri.UseVisualStyleBackColor = true;
            // 
            // frmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbelMessage);
            this.Controls.Add(this.btonMessage);
            this.Controls.Add(this.chkbDiller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonClose);
            this.Name = "frmCheckedListBox";
            this.Text = "frmCheckedListBox";
            this.Load += new System.EventHandler(this.frmCheckedListBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkbDiller;
        private System.Windows.Forms.Button btonMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHicbiri;
        private System.Windows.Forms.RadioButton rbtnHepsi;
        public System.Windows.Forms.Label lbelMessage;
    }
}