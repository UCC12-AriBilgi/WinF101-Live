using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_Controls
{
    public partial class frmCheckControls : Form
    {
        public frmCheckControls()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close(); // formumu kapatacak
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckKontrol();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox üzerinde seçim yapıldığında veya seçim kaldırıldığında
            CheckKontrol();

        }

        private void CheckKontrol()
        {
            if (checkBox1.Checked == true) // eğer chb1 seçilmişse
            {
                if(checkBox2.Checked == true) // eğer chb2 de seçilmişse
                {
                    lbelMessage.Text = "Her iki checkbox da seçili";
                }
                else
                {
                    lbelMessage.Text = "checkbox1 seçili checkbox2 seçili değil..";
                }
            }
            else
            {
                if (checkBox2.Checked == true) // eğer chb2 de seçilmişse
                {
                    lbelMessage.Text = "checkbox1 seçili değil, checkbox2 seçili";
                }
                else
                {
                    lbelMessage.Text = "checkbox1 ve checkbox2 seçili değil..";
                }
            }
        }

        private void RadioControl(object sender, EventArgs e)
        {
            // Burası heriki rb için ortak yer dolayısıyla hangi rb ye basıldığını anlamam lazım ki ona göre mesaj verebileyim.

            RadioButton rb;

            rb=(RadioButton)sender; // buraya gönderen nesne bir radio butondur.

            if (rb.Checked == true) // seçili ise
            {
                lbelMessage.Text = rb.Name + " seçili..";
            }
        }

        private void frmCheckControls_Load(object sender, EventArgs e)
        {
            lbelMessage.Text = "";
        }
    }
}
