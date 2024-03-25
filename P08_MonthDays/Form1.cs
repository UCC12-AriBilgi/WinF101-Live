using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08_MonthDays
{
    public partial class Form1 : Form
    {
        DateTimeFormatInfo formatTR = CultureInfo.GetCultureInfo("tr-TR").DateTimeFormat; // Türkiye için tarih format yapısını öğrenme...

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
            for (int i = 0; i < 12; i++)
            {
                cboxAylar.Items.Add(formatTR.MonthNames[i]);
            }

            cboxAylar.SelectedIndex = 0; // combodaki ilk elemanı gösterecek.

            int year=Convert.ToInt32(DateTime.Now.Year);

            numericUpDown1.Value= year;
        }

        private void btonListele_Click(object sender, EventArgs e)
        {
            lboxGunler.Items.Clear();

            int yil = Convert.ToInt32(numericUpDown1.Value);

            int ay = cboxAylar.SelectedIndex + 1;

            DateTime tarih = new DateTime(yil, ay, 1);

            int TotalDaysCount = DateTime.DaysInMonth(yil, ay); // ay/yıl durumuna göre ne kadar gün çektiği biliyor.

            for (int i = 1; i <= TotalDaysCount; i++)
            {
                lboxGunler.Items.Add(tarih.Day + " " + cboxAylar.Text + " " + formatTR.DayNames[(int)tarih.DayOfWeek]);

                tarih = tarih.AddDays(1); // o an bulunduğum tarihi 1 gün sonraya al/geç
            }
        }
    }
}
