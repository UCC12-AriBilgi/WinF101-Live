using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_ButonYakala
{
    public partial class Form1 : Form
    {
        int sayac=0; // kac defada yakaladım.
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sabit bir form

            this.Width = 500;
            this.Height = 500;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            // Buton üzerine mouse geldiyse...hover
            // butonun ekranda durduğu yeri random olarak değiştireceğim..Formun sınırları içinde kalmak sartıyla

            int xcoord=random.Next(0,this.Width - button1.Width);

            int ycoord=random.Next(0,this.Height - button1.Height);

            button1.Location= new Point(xcoord, ycoord);

            sayac++; // Tıklayamama durumu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Yakaladım seni...{sayac}.ncı denemede...");
        }
    }
}
