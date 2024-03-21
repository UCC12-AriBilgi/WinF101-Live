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
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btonStart_Click(object sender, EventArgs e)
        {
            tmerSayac.Interval = Convert.ToInt32(nudInterval.Value);
            tmerSayac.Enabled = true;
        }

        private void tmerSayac_Tick(object sender, EventArgs e)
        {
            // şu anki saat

            // her interval değerine ulaştığında buraya düşecek.

            int Saat = DateTime.Now.Hour;
            int Dakka = DateTime.Now.Minute;
            int Saniye = DateTime.Now.Second;

            lbelSaat.Text=Saat + ":" + Dakka + ":" + Saniye;

        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            lbelSaat.Text = "";
        }

        private void btonStop_Click(object sender, EventArgs e)
        {
            tmerSayac.Stop();
        }
    }
}
