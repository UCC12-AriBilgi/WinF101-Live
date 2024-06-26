﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_ADO_WinF
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

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();

            frmEmployees.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers(); 

            frmCustomers.ShowDialog();
        }
    }
}
