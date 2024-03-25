using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_DateDiffer
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

        private void btonHesapla_Click(object sender, EventArgs e)
        {
            DateTime startDate = Convert.ToDateTime(dtpStart.Text);

            DateTime endDate = Convert.ToDateTime(dtpEnd.Text);

            TimeSpan sonuc=endDate.Subtract(startDate); // endDate - StartDate

            // sonuc içindeki değeri anlamlı hale döndürmek.

            string Year = Convert.ToString(Math.Round(sonuc.TotalDays / 365, 4)) + " Yıl veya";

            string Month = Convert.ToString(Math.Round(sonuc.TotalDays / 30,2)) + " Ay veya";

            string Day = Math.Round(sonuc.TotalDays, 2).ToString() + " Gün veya";

            string Hour = Math.Round(sonuc.TotalHours, 2).ToString() + " Saat veya";

            string Minute = Math.Round(sonuc.TotalMinutes, 2).ToString() + " Dakika";

            lboxSonuc.Items.Clear();

            lboxSonuc.Items.Add(Year);
            lboxSonuc.Items.Add(Month);
            lboxSonuc.Items.Add(Day);
            lboxSonuc.Items.Add(Hour);
            lboxSonuc.Items.Add(Minute);


        }
    }
}
