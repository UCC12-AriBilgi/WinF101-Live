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
    public partial class frmMerhaba : Form
    {
        public frmMerhaba()
        {
            InitializeComponent();
        }

        private void btonMesaj_Click(object sender, EventArgs e)
        {
            string ad, soyad;

            ad = tboxAd.Text;
            soyad = tboxSoyad.Text;

            lbelMesaj.Text = "Hoşgeldiniz sayın " + ad + " " + soyad;

        }

        private void frmMerhaba_Load(object sender, EventArgs e)
        {
            lbelMesaj.Text = "";
        }
    }
}
