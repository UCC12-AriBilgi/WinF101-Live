using System;
using System.Collections;
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
    public partial class frmListBox : Form
    {
        public frmListBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Soldaki listbox dan sağdaki listbox a tek eleman taşır
            gonder(listBox1, listBox2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Soldaki listbox daki tüm elemanları sağdaki listbox a taşır
            foreach (var eleman in listBox1.Items)
            {
                listBox2.Items.Add(eleman);
            }

            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Sağdaki listbox dan soldaki listbox a tek eleman taşır
            gonder(listBox2, listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Sağdaki listbox daki tüm elemanları soldaki listbox a taşır
            listBox1.Items.AddRange(listBox2.Items);

            listBox2.Items.Clear();
        }

        // hangi taraftan hangi tarafa veri tasıyacağını anlatmak için parametre gönderilecek
        private void gonder(ListBox source,ListBox dest) 
        {
            try
            {
                ArrayList secilenler = new ArrayList(); // seçtiklerimi bir diziye yerleştirmek için 

                secilenler.AddRange(source.SelectedItems);

                foreach (var eleman in secilenler)
                {
                    dest.Items.Add(eleman); // varış listbox ına elemanı yerleştir

                    source.Items.Remove(eleman);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Önce seçim yapmalısınız...Hata : {e.Message}");
                throw;
            }
        }
    }
}
