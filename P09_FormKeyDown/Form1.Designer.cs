namespace P09_FormKeyDown
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
            this.btonHareketli = new System.Windows.Forms.Button();
            this.btonA = new System.Windows.Forms.Button();
            this.btonS = new System.Windows.Forms.Button();
            this.btonD = new System.Windows.Forms.Button();
            this.btonW = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btonHareketli
            // 
            this.btonHareketli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btonHareketli.Location = new System.Drawing.Point(185, 138);
            this.btonHareketli.Name = "btonHareketli";
            this.btonHareketli.Size = new System.Drawing.Size(52, 54);
            this.btonHareketli.TabIndex = 0;
            this.btonHareketli.UseVisualStyleBackColor = false;
            // 
            // btonA
            // 
            this.btonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonA.Location = new System.Drawing.Point(21, 377);
            this.btonA.Name = "btonA";
            this.btonA.Size = new System.Drawing.Size(43, 43);
            this.btonA.TabIndex = 1;
            this.btonA.Text = "A";
            this.btonA.UseVisualStyleBackColor = true;
            this.btonA.Click += new System.EventHandler(this.btonA_Click);
            // 
            // btonS
            // 
            this.btonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonS.Location = new System.Drawing.Point(70, 377);
            this.btonS.Name = "btonS";
            this.btonS.Size = new System.Drawing.Size(43, 43);
            this.btonS.TabIndex = 2;
            this.btonS.Text = "S";
            this.btonS.UseVisualStyleBackColor = true;
            this.btonS.Click += new System.EventHandler(this.btonS_Click);
            // 
            // btonD
            // 
            this.btonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonD.Location = new System.Drawing.Point(119, 377);
            this.btonD.Name = "btonD";
            this.btonD.Size = new System.Drawing.Size(43, 43);
            this.btonD.TabIndex = 3;
            this.btonD.Text = "D";
            this.btonD.UseVisualStyleBackColor = true;
            this.btonD.Click += new System.EventHandler(this.btonD_Click);
            // 
            // btonW
            // 
            this.btonW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btonW.Location = new System.Drawing.Point(70, 328);
            this.btonW.Name = "btonW";
            this.btonW.Size = new System.Drawing.Size(43, 43);
            this.btonW.TabIndex = 4;
            this.btonW.Text = "W";
            this.btonW.UseVisualStyleBackColor = true;
            this.btonW.Click += new System.EventHandler(this.btonW_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btonW);
            this.Controls.Add(this.btonD);
            this.Controls.Add(this.btonS);
            this.Controls.Add(this.btonA);
            this.Controls.Add(this.btonHareketli);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btonHareketli;
        private System.Windows.Forms.Button btonA;
        private System.Windows.Forms.Button btonS;
        private System.Windows.Forms.Button btonD;
        private System.Windows.Forms.Button btonW;
        private System.Windows.Forms.Button button1;
    }
}

