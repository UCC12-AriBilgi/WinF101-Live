namespace P12_ADO_WinF
{
    partial class frmCustomers
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
            this.dgrdCustomers = new System.Windows.Forms.DataGridView();
            this.btonAdd = new System.Windows.Forms.Button();
            this.btonUpdate = new System.Windows.Forms.Button();
            this.btonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btonClose
            // 
            this.btonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btonClose.Location = new System.Drawing.Point(562, 422);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customers Data";
            // 
            // dgrdCustomers
            // 
            this.dgrdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdCustomers.Location = new System.Drawing.Point(38, 91);
            this.dgrdCustomers.Name = "dgrdCustomers";
            this.dgrdCustomers.Size = new System.Drawing.Size(531, 275);
            this.dgrdCustomers.TabIndex = 2;
            this.dgrdCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdCustomers_CellContentDoubleClick);
            // 
            // btonAdd
            // 
            this.btonAdd.Location = new System.Drawing.Point(38, 393);
            this.btonAdd.Name = "btonAdd";
            this.btonAdd.Size = new System.Drawing.Size(75, 23);
            this.btonAdd.TabIndex = 3;
            this.btonAdd.Text = "Ekle";
            this.btonAdd.UseVisualStyleBackColor = true;
            this.btonAdd.Click += new System.EventHandler(this.btonAdd_Click);
            // 
            // btonUpdate
            // 
            this.btonUpdate.Location = new System.Drawing.Point(128, 393);
            this.btonUpdate.Name = "btonUpdate";
            this.btonUpdate.Size = new System.Drawing.Size(75, 23);
            this.btonUpdate.TabIndex = 4;
            this.btonUpdate.Text = "Güncelle";
            this.btonUpdate.UseVisualStyleBackColor = true;
            this.btonUpdate.Click += new System.EventHandler(this.btonUpdate_Click);
            // 
            // btonDelete
            // 
            this.btonDelete.Location = new System.Drawing.Point(218, 393);
            this.btonDelete.Name = "btonDelete";
            this.btonDelete.Size = new System.Drawing.Size(75, 23);
            this.btonDelete.TabIndex = 5;
            this.btonDelete.Text = "Sil";
            this.btonDelete.UseVisualStyleBackColor = true;
            this.btonDelete.Click += new System.EventHandler(this.btonDelete_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 457);
            this.Controls.Add(this.btonDelete);
            this.Controls.Add(this.btonUpdate);
            this.Controls.Add(this.btonAdd);
            this.Controls.Add(this.dgrdCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btonClose);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgrdCustomers;
        private System.Windows.Forms.Button btonAdd;
        private System.Windows.Forms.Button btonUpdate;
        private System.Windows.Forms.Button btonDelete;
    }
}