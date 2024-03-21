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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckControls frmCheckControls = new frmCheckControls();

            frmCheckControls.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckedListBox frmCheckedListBox = new frmCheckedListBox();

            frmCheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComboBox frmComboBox = new frmComboBox();

            frmComboBox.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListBox frmListBox = new frmListBox();

            frmListBox.ShowDialog();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDateTime frmDateTime = new frmDateTime();

            frmDateTime.ShowDialog();
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimer frmTimer = new frmTimer();

            frmTimer.ShowDialog();
        }
    }
}
