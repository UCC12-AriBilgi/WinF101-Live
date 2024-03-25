using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_ArttirAzalt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 1000;

        }

        private void btonIslem_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown1.Maximum)
            {
                MessageBox.Show("Lütfen maksimum değerimi aşmayınız...");
            }





            if (rbtnArttir.Checked == true) // arttır butonu seçilmişse
            {
                int miktar = Convert.ToInt32(numericUpDown1.Value); // ne kadarlık bir işlem yapacağım

                int sonuc = Convert.ToInt32(label3.Text);  

                label3.Text= (sonuc + miktar).ToString();
            }
            else if (rbtnAzalt.Checked==true) // azalt butonu
            {
                int miktar = Convert.ToInt32(numericUpDown1.Value); // ne kadarlık bir işlem yapacağım

                int sonuc = Convert.ToInt32(label3.Text);

                label3.Text = (sonuc - miktar).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen ne yapacağımı belirtiniz...");
            }

        }
    }
}
