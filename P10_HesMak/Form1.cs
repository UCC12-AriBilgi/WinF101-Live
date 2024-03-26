using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_HesMak
{
    public partial class Form1 : Form
    {
        // Global tanımlar

        bool esittir = false; // = butonuna basılmış durumu
        bool islemsec=false; // herhangi bir işlem(+-*/) seçilmiş mi
        bool sayisec=false; // işlem için sayıların seçilip/seçilmediğini belirtiyor

        string islem; // hangi işlemin yapılacağını tutuyor.

        int sayi1 = 0;
        int sayi2 = 0;
        int sonuc = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sayilar = "0123456789";

            // Ekrandaki bulunan kontrollerden sadece butonlara ulaşmak ve programatik olarak özellikleri üzerinde oynamak istersen

            foreach (Control control in this.Controls)
            {
                if (control is Button) // bulmuş olduğum kontrol eğer bir butonsa
                {
                    if (sayilar.IndexOf(control.Text) != -1) // text içindeki 0123... dan butonun kendi texti varsa
                    {
                        control.Font = new Font("Arial", 17);
                    }
                    else // bulduğum kontrol butondan farklıysa
                    {
                        control.Font = new Font("Arial", 13);
                        (control as Button).FlatStyle = FlatStyle.Flat; // .net6
                       //( (Button)control).FlatStyle = FlatStyle.Flat; // .net8
                        (control as Button).FlatAppearance.BorderSize = 0; // Border kalktı
                        (control as Button).BackColor = Color.FromName("ControlLight"); // renk ayarlaması
                    }
                }
            }

        }

        #region Sayısal Buton Bölgesi

        // herbir sayısal butonun ortak olarak kullanabileceği bir metot. Amaç 10 tane sayısal butonların ayrı ayrı olacak click metotlarını tek yere toparlamak..
        private void SayisalGiris(object sender, EventArgs e)
        {
            // Buraya 012...9 butonlarıyla geliniyor. Acaba hangisi.

            Button button = (Button)sender; // hangi butondan gelindiğini anlayabilmek için...Text özelliği ile mesela

            if (tboxSonuc.Text == "0" || islemsec)
            {
                tboxSonuc.Text = button.Text;
            }
            else
            {
                tboxSonuc.Text = tboxSonuc.Text + button.Text;
            }

            //? Sayı giriyoruz ama sayı seçildiğini söylemiyoruz.
            sayisec = true; // sayı girişi yapıyorum
            islemsec = false;

        }
        #endregion

        #region İşlem Öğrenme bölgesi
        private void IslemOgren(object sender, EventArgs e)
        {
            // Buraya + - * / butonlarıyla geliniyor. hangisi acaba?
            string islemkod = "+-*/";


            Button button = (Button)sender; // Basılmış olan butonu öğrendim.

            if (islemkod.IndexOf(button.Text) != -1) // butonun text in de yukardaki karakterlerden biri varmı
            {
                islem = button.Text; // basılan butonun texti
                // demek bir işlem yapılacak
                islemsec = true;
            }

            if ((sayisec && sayi1 == 0) || esittir)
            {
                sayi1 = Convert.ToInt32(tboxSonuc.Text);

                tboxHistory.Text = sayi1.ToString() + " " + islem;
            }
            else if (sayisec && sayi2==0)
            {
                sayi2 = Convert.ToInt32(tboxSonuc.Text);

                tboxHistory.Text= tboxHistory.Text + sayi2.ToString() + " " + islem;

                // sayi1 ve sayi2 yi burlara kadar aldı öğrendi..
                // işlemlere baslama zamanı

                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;

                    case "-":
                        sonuc= sayi1 - sayi2;
                        break;

                    case "*":
                        sonuc= sayi1 * sayi2;
                        break;

                    case "/":
                        sonuc=sayi1 / sayi2;
                        break;
                    default:
                        break;
                }

                tboxSonuc.Text = sonuc.ToString();

                // ekrana o anki sonucu yazdı.Sayılarımın yeni durumunu ayarlama işlemi...

                sayi1 = sonuc; // ekranda yazan
                sayi2 = 0;

            }

            // History


        }

        #endregion


    }
}
