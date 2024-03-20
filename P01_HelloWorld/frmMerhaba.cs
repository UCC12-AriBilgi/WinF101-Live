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

            // 1.yol....bir label componenti kullanarak gösterme
            //lbelMesaj.Text = "";
            //lbelMesaj.Text = $"Hoşgeldiniz sayın {ad} {soyad}...";




            // 2.yol varolan bir Sınıf/metot kullanarak

            //MessageBox.Show($"Merhaba {ad} {soyad}..Hoşgeldiniz...5 gittiniz...");


            // 3.yol Ayrı bir şekilde hazırlanmış bir formda göstermek(bulunduğum formdan diğer başka bir formu çağırmak)

            frmMessage frmMessage = new frmMessage();

            frmMessage.Text = "Mesajınız var..";

            frmMessage.lbelMessage.Text = $"Merhaba sevgili {ad.ToUpper()} {soyad.ToUpper()} ...Bugün nasılsın...";

            if (frmMessage.ShowDialog() == DialogResult.OK) // gelen formdan OK/Cancel yapıldı mı
            {
                tboxAd.Clear();
                tboxSoyad.Clear();

                tboxAd.Focus();
            }
            else
            {
                tboxAd.BackColor = Color.Red;
                tboxSoyad.BackColor = Color.Green;
            }




            //tboxAd.Clear();
            //tboxSoyad.Clear();

            //tboxAd.Focus();
        }

        private void frmMerhaba_Load(object sender, EventArgs e)
        {
            lbelMesaj.Text = "";
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
