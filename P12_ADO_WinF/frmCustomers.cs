using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_ADO_WinF
{
    public partial class frmCustomers : Form
    {
        // Global

        
        string connStr = @"Server=EGITMEN\MSSQLSERVER2;Database=Northwind;Trusted_Connection=true;Integrated Security=true;trustservercertificate=true;";

        string sqlstr; // içine sql ce komutları yazacağım değişgen



        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            PrepareGrid();

            BindGrid();
        }

        private void PrepareGrid()
        {
            // Burada DG cesitli ayarlama işlemlerini yapacağız.

            dgrdCustomers.AutoGenerateColumns = false; // otomatik kolon oluşturma ..db tablosuna bakarak...

            dgrdCustomers.AllowUserToAddRows = false; // kullanıcı DG üzerinden kayıt eklesinmi/silsinmi
            dgrdCustomers.AllowUserToDeleteRows = false;

            dgrdCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Kolonların genişlikleriyle ilgili 

            dgrdCustomers.RowHeadersVisible = false; // gösterme

            dgrdCustomers.AllowUserToResizeRows = false;

            dgrdCustomers.ReadOnly = true;

            dgrdCustomers.SelectionMode= DataGridViewSelectionMode.FullRowSelect; // tüm satır seçili

            dgrdCustomers.ColumnCount = 4;

            // DG mi dizayn ediyorum.

            dgrdCustomers.Columns[0].Name = "CustomerID";
            dgrdCustomers.Columns[0].HeaderText = "Müşteri No";
            dgrdCustomers.Columns[0].DataPropertyName = "CustomerID"; // ilgili tablodaki alan adı

            dgrdCustomers.Columns[1].Name = "CompanyName";
            dgrdCustomers.Columns[1].HeaderText = "Müşteri Adı";
            dgrdCustomers.Columns[1].DataPropertyName = "CompanyName"; // ilgili tablodaki alan adı

            dgrdCustomers.Columns[2].Name = "ContactName";
            dgrdCustomers.Columns[2].HeaderText = "İlgili Kişi";
            dgrdCustomers.Columns[2].DataPropertyName = "ContactName"; // ilgili tablodaki alan adı

            dgrdCustomers.Columns[3].Name = "Country";
            dgrdCustomers.Columns[3].HeaderText = "Ülke";
            dgrdCustomers.Columns[3].DataPropertyName = "Country"; // ilgili tablodaki alan adı


        }

        private void BindGrid()
        {
            // VT tarafındaki veriyi okuyup DG içine dolduracak.

            sqlstr = "SELECT * FROM Customers";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using(SqlCommand cmd = new SqlCommand(sqlstr, connection))
                {
                    cmd.CommandType = CommandType.Text;

                    // borulama
                    using (SqlDataAdapter adapter=new SqlDataAdapter(cmd))
                    {
                        using(DataSet dset=new DataSet())
                        {
                            adapter.Fill(dset);

                            dgrdCustomers.DataSource = dset.Tables[0];
                        }

                    }
                }
            }
        }

        private void btonAdd_Click(object sender, EventArgs e)
        {
            // Kayıt Ekleme
            ShowData("I");// I ile Insert yapacağını anlatacağım diğer forma

        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            ShowData("U"); // Update yapacağını anlatıyoruz..
        }

        private void ShowData(string prmMode)
        {
            frmCustomerDetail frmCustomerDetail = new frmCustomerDetail();

            frmCustomerDetail.Mod=prmMode;

            // IU durumuna göre ekrandaki kontrol ayarları yapılıyor.

            switch (prmMode)
            {
                case "I": // Insert durumu
                    frmCustomerDetail.tboxCustomerID.Text = "";
                    frmCustomerDetail.tboxCompanyName.Text = "";
                    frmCustomerDetail.tboxContactName.Text = "";
                    frmCustomerDetail.tboxCountry.Text = "";
                    break;

                case "U": // Update durumu
                    // DG içinde kullanabilmem için verileri diğer forma göndereceğim.
                    frmCustomerDetail.tboxCustomerID.Text = dgrdCustomers.CurrentRow.Cells[0].Value.ToString();
                    frmCustomerDetail.tboxCustomerID.Enabled = false;

                    frmCustomerDetail.tboxCompanyName.Text = dgrdCustomers.CurrentRow.Cells[1].Value.ToString();

                    frmCustomerDetail.tboxContactName.Text = dgrdCustomers.CurrentRow.Cells[2].Value.ToString();

                    frmCustomerDetail.tboxCountry.Text = dgrdCustomers.CurrentRow.Cells[3].Value.ToString();

                    break;
                default:
                    break;
            }

            frmCustomerDetail.ShowDialog();

            BindGrid(); // Yeni oluşan verileri tekrardan DG içine yüklemek için.


        }

        private void dgrdCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Buradan da Update modda diğer forma gitsin

            ShowData("U"); // Update yapacağını anlatıyoruz..
        }

        private void btonDelete_Click(object sender, EventArgs e)
        {
            sqlstr = "DELETE FROM Customers WHERE CustomerID=@CustomerID";


            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlstr, conn))
                {
                    // hala veri yok..Verileri dolduralım.
                    cmd.Parameters.AddWithValue("CustomerID", dgrdCustomers.CurrentRow.Cells[0].Value); // DG deki 0.indexdeki kolonda duran değer

                    cmd.CommandType = CommandType.Text;

                    // artık veri hazır...

                    try
                    {
                        conn.Open(); // VT bağlantısı açıldı.

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Bilgileriniz VT den  basarıyla silindi...");

                        BindGrid();

                    }
                    catch (Exception message)
                    {
                        MessageBox.Show("Hata : " + message.ToString());

                    }

                }
            }
        }
    }
}
