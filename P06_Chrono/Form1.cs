using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06_Chrono
{
    public partial class Form1 : Form
    {
        int dak = 0, san = 0, sal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // saliseyi arttır

            sal++;

            if (sal ==100)
            {
                san++;
                sal = 0;
                if (san == 60)
                {
                    dak++;
                    san = 0;
                }
            }

            lbelDakika.Text = String.Format("{0:D2}", dak);

            lbelSaniye.Text = String.Format("{0:D2}", san);

            lbelSalise.Text = String.Format("{0:D2}", sal);


        }

        private void btonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
