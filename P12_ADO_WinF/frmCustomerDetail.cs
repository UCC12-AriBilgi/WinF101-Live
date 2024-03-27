using System;
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
    public partial class frmCustomerDetail : Form
    {
        string connStr = @"Server=EGITMEN\MSSQLSERVER2;Database=Northwind;Trusted_Connection=true;Integrated Security=true;trustservercertificate=true;";

        public string Mod = ""; // Hangi durumda formu actığımı bildirmek için (Insert I,Update U
        
        string sqlstr = "";

        public frmCustomerDetail()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomerDetail_Load(object sender, EventArgs e)
        {
            if (Mod == "I")
            {
                this.Text = "Müşteri Detay Formu (Insert)";
            }
            else this.Text= "Müşteri Detay Formu (Update)";
        }

        private void btonSave_Click(object sender, EventArgs e)
        {
            switch (Mod)
            {
                // Verinin güvenliği için dış dünyaya karşı ...Parametresel bir yapı kullanmanız tavsiye olunur.

                case "I":
                    sqlstr = "INSERT INTO Customers (CustomerID,CompanyName,ContactName,Country) VALUES(@CustomerID,@CompanyName,@ContactName,@Country)";

                    break;

                case "U":
                    sqlstr = "UPDATE Customers SET ";
                    sqlstr += "CompanyName=@CompanyName,";
                    sqlstr += "ContactName=@ContactName,";
                    sqlstr += "Country=@Country ";
                    sqlstr += "WHERE CustomerID=@CustomerID"


                    break;






                default:
                    break;
            }
        }
    }
}
