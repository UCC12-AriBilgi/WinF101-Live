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

        bool islemsec=false; // herhangi bir işlem(+-*/) seçilmiş mi

        int sayi1 = 0;
        int sayi2 = 0;

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
                        (control as Button).FlatStyle = FlatStyle.Flat;
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
            Button button = (Button)sender; // hangi butondan gelindiğini anlayabilmek için...Text özelliği ile mesela


        }

        #endregion


    }
}
