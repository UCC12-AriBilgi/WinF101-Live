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
    public partial class frmCheckedListBox : Form
    {
        public frmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();// formu kapatacak
        }

        private void frmCheckedListBox_Load(object sender, EventArgs e)
        {
            lbelMessage.Text = "";
            //lbelMessage.Visible = false;
        }

        private void btonMessage_Click(object sender, EventArgs e)
        {
            MesajVer();


        }

        private void rbtnHepsi_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(true);
        }

        private void rbtnHicbiri_CheckedChanged(object sender, EventArgs e)
        {
            CheckAyarla(false);
        }

        private void CheckAyarla(bool checkState)
        {
            for (int i = 0; i < chkbDiller.Items.Count; i++)
            {
                chkbDiller.SetItemChecked(i, checkState);
            }

            MesajVer();
            //
        }

        private void MesajVer()
        {
            // Şu an listbox içinde seçilmiş secenekler var..Onları acaba hangileri diye okumam lazım.,

            var secilenDiller = new List<string>(); // seçilenler için kullanacağım bir liste yapısı (sanki dizi gibi)

            // asağıdaki bölümde sadece ve sadece seçilmiş olan secenekleri öğreniyorum/bakıyorum.
            foreach (var diller in chkbDiller.CheckedItems)
            {
                secilenDiller.Add(diller.ToString()); // Listeme seçilmiş olan seceneği ekliyorum
            }

            // listem hazır...seçili elemanlarla...
            lbelMessage.Text = $"Üzerinde uğraşmakta olduğunuz diller : {string.Join(", ", secilenDiller)}";
        }
    }
}
