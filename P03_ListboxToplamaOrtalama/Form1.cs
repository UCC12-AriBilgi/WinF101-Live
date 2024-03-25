using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_ListboxToplamaOrtalama
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

        private void btonEkle_Click(object sender, EventArgs e)
        {
            // textbox dan alınan değeri listbox içine ekleyecek..

            lboxSayilar.Items.Add(tboxSayi.Text);
            // sayıyı listeye ekledikten sonra
            tboxSayi.Clear();

        }

        private void btonHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            double ortalama = 0;

            // şimdi sayılar listbox ı içinde dönmem lazım

            for (int index = 0; index < lboxSayilar.Items.Count; index++)
            {
                toplam = toplam + Convert.ToDouble(lboxSayilar.Items[index]);
            }

            ortalama = toplam / lboxSayilar.Items.Count;

            tboxToplam.Text= toplam.ToString();
            tboxOrtalama.Text = String.Format("{0:0.##}", ortalama);
        }

        private void btonTemizle_Click(object sender, EventArgs e)
        {
            lboxSayilar.Items.Clear();
            tboxOrtalama.Clear();
            tboxToplam.Clear();
        }

        // String.Format("{0.00}",123.4567) --> 123.46
        // String.Format("{0.00}",123.4) --> 123.40
        // String.Format("{0.00}",123.0) --> 123.00

        // String.Format("{0.##}",123.4) --> 123.4

    }
}
