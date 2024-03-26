namespace P12_ADO_WinF
{
    partial class frmEmployees
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
            this.tboxEmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxFName = new System.Windows.Forms.TextBox();
            this.tboxLName = new System.Windows.Forms.TextBox();
            this.tboxTitle = new System.Windows.Forms.TextBox();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.tboxCountry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(242, 314);
            this.btonClose.Name = "btonClose";
            this.btonClose.Size = new System.Drawing.Size(75, 23);
            this.btonClose.TabIndex = 0;
            this.btonClose.Text = "Kapat";
            this.btonClose.UseVisualStyleBackColor = true;
            this.btonClose.Click += new System.EventHandler(this.btonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmployeeID";
            // 
            // tboxEmployeeID
            // 
            this.tboxEmployeeID.Location = new System.Drawing.Point(99, 19);
            this.tboxEmployeeID.Name = "tboxEmployeeID";
            this.tboxEmployeeID.Size = new System.Drawing.Size(50, 20);
            this.tboxEmployeeID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Country";
            // 
            // tboxFName
            // 
            this.tboxFName.Location = new System.Drawing.Point(99, 64);
            this.tboxFName.Name = "tboxFName";
            this.tboxFName.Size = new System.Drawing.Size(100, 20);
            this.tboxFName.TabIndex = 8;
            // 
            // tboxLName
            // 
            this.tboxLName.Location = new System.Drawing.Point(99, 101);
            this.tboxLName.Name = "tboxLName";
            this.tboxLName.Size = new System.Drawing.Size(100, 20);
            this.tboxLName.TabIndex = 9;
            // 
            // tboxTitle
            // 
            this.tboxTitle.Location = new System.Drawing.Point(99, 143);
            this.tboxTitle.Name = "tboxTitle";
            this.tboxTitle.Size = new System.Drawing.Size(149, 20);
            this.tboxTitle.TabIndex = 10;
            // 
            // tboxCity
            // 
            this.tboxCity.Location = new System.Drawing.Point(99, 176);
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(100, 20);
            this.tboxCity.TabIndex = 11;
            // 
            // tboxCountry
            // 
            this.tboxCountry.Location = new System.Drawing.Point(99, 209);
            this.tboxCountry.Name = "tboxCountry";
            this.tboxCountry.Size = new System.Drawing.Size(100, 20);
            this.tboxCountry.TabIndex = 12;
            // 
            // frmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 349);
            this.Controls.Add(this.tboxCountry);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.tboxTitle);
            this.Controls.Add(this.tboxLName);
            this.Controls.Add(this.tboxFName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonClose);
            this.Name = "frmEmployees";
            this.Text = "frmEmployees";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxEmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxFName;
        private System.Windows.Forms.TextBox tboxLName;
        private System.Windows.Forms.TextBox tboxTitle;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.TextBox tboxCountry;
    }
}