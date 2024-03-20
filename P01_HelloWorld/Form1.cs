using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form ekrana ilk geldiğinde çalışacak metot
            label1.Text = "";
        }

        private void btonMesaj_Click(object sender, EventArgs e)
        {
            // Burası da butona tıklandığında (click olayı) gerçekleştiğinde

            label1.Text = "Merhaba Dünya...Nasılsın ?";
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programdan çıkar..Uygulamamı sonlandırır..
        }
    }
}
