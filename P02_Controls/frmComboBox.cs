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
    public partial class frmComboBox : Form
    {
        public frmComboBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmComboBox_Load(object sender, EventArgs e)
        {
            lbelMessage.Visible = false;
        }

        private void btonSay_Click(object sender, EventArgs e)
        {
            // ComboBox içeriğini saymak kaç eleman var onu bulmak
            int adet = cboxSehir.Items.Count; // itemları sayıyor

            lbelMessage.Text = $"Combobox içinde {adet} şehir bulunmaktadır...";

            lbelMessage.Visible = true;
        }

        private void cboxHangi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Öncelikle yeni sonuçları göstermek için sonuç combosunun içeriğini temizliyorum.
            cboxSonuc.Items.Clear();

            string secilen=(string)cboxHangi.SelectedItem; // combobox dan seçilen eleman

            if (secilen == "Haftanın günleri")
            {
                // önce bir dizi yarat manuel olarak içini doldur.

                string[] gunler = {"Pzt.","Salı","Çarş.","Perş.","Cuma","Cmrts","Pazar" };

                cboxSonuc.Items.AddRange(gunler);
            }
            else
            {
                string[] yillar = { "2020", "2021", "2022", "2023", "2024", "2025", "2026" };

                cboxSonuc.Items.AddRange(yillar);
            }
        }
    }
}
