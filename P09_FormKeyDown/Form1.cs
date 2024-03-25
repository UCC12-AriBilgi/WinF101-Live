using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09_FormKeyDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btonD_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.D));
        }

        private void btonA_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.A));
        }

        private void btonW_Click(object sender, EventArgs e)
        {
            Form1_KeyDown(sender, new KeyEventArgs(Keys.W));
        }

        private void btonS_Click(object sender, EventArgs e)
        {
            //int yeniX = btonHareketli.Location.X;
            //int yeniY = btonHareketli.Location.Y + 5;
            //int butonwidth = btonHareketli.Width;


            //// butonun formdan kaybolmasını engelemek için

            //if (yeniY < this.Height - butonwidth)
            //{
            //    btonHareketli.Location = new Point(yeniX, yeniY);
            //}

            Form1_KeyDown(sender, new KeyEventArgs(Keys.S));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // hangi tuşa basarak acaba buraya geldim.

            if (e.KeyCode == Keys.D) // D tusuna basılmış
            {
                int yeniX = btonHareketli.Location.X + 5;
                int yeniY = btonHareketli.Location.Y;
                int butonwidth = btonHareketli.Width;


                // butonun formdan kaybolmasını engelemek için

                if (yeniX < this.Width - butonwidth)
                {
                    btonHareketli.Location = new Point(yeniX, yeniY);
                }
            }

            if (e.KeyCode == Keys.W) 
            {
                int yeniX = btonHareketli.Location.X;
                int yeniY = btonHareketli.Location.Y - 5;
                int butonwidth = btonHareketli.Width;

                if (yeniY >= 0) // formun en baş sol tarafı
                {
                    btonHareketli.Location = new Point(yeniX, yeniY);
                }
            }

            if (e.KeyCode==Keys.A)
            {
                int yeniX = btonHareketli.Location.X - 5;
                int yeniY = btonHareketli.Location.Y;
                int butonwidth = btonHareketli.Width;

                if (yeniX >= 0) // formun en baş sol tarafı
                {
                    btonHareketli.Location = new Point(yeniX, yeniY);
                }
            }

            if (e.KeyCode == Keys.S) 
            {
                int yeniX = btonHareketli.Location.X;
                int yeniY = btonHareketli.Location.Y + 5;
                int butonwidth = btonHareketli.Width;


                // butonun formdan kaybolmasını engelemek için

                if (yeniY < this.Height - butonwidth)
                {
                    btonHareketli.Location = new Point(yeniX, yeniY);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Onay())
            {
                Application.Exit();
            }
        }

        private bool Onay()
        {
            bool secim = false;

            DialogResult dialogResult= MessageBox.Show("Programdan çıkmak istiyor musunuz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dialogResult== DialogResult.Yes)
            {
                secim = true;
            }
            else if (dialogResult== DialogResult.No)
            {
                secim = false;
            }

            return secim;

        }
    }
}
