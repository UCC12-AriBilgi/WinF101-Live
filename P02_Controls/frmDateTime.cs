using System;
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
    public partial class frmDateTime : Form
    {
        public frmDateTime()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonGoster_Click(object sender, EventArgs e)
        {
            DateTime dgun = new DateTime();

            dgun = dtpTarih.Value; // datetimepickerda seçtiğim tarih.

            int dYil = dgun.Year; // sadece yıl bilgisini oğrenmek için
            int dAy = dgun.Month; // ay bilgisi
            int dGun = dgun.Day; // gün için

            int buYil= DateTime.Now.Year;

            int yas = buYil- dYil;

            MessageBox.Show($"Sayın {tboxAdSoyad.Text} - Siz {dYil} yılının {dAy}.ncı ayının {dGun}. gününde doğmuşsunuz. Dolayısıyla {yas} yaşındasınız...");
        }
    }
}
