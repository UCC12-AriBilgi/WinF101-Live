namespace P01_HelloWorld
{
    partial class frmMessage
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
            this.lbelMessage = new System.Windows.Forms.Label();
            this.btonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbelMessage
            // 
            this.lbelMessage.AutoSize = true;
            this.lbelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelMessage.Location = new System.Drawing.Point(46, 57);
            this.lbelMessage.Name = "lbelMessage";
            this.lbelMessage.Size = new System.Drawing.Size(99, 36);
            this.lbelMessage.TabIndex = 0;
            this.lbelMessage.Text = "label1";
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonClose.Location = new System.Drawing.Point(707, 141);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(88, 38);
            this.btonClose.TabIndex = 1;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 191);
            this.ControlBox = false;
            this.Controls.Add(this.btonClose);
            this.Controls.Add(this.lbelMessage);
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btonClose;
        public System.Windows.Forms.Label lbelMessage;
    }
}