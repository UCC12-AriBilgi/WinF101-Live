﻿using System;
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

    public partial class frmEmployees : Form
    {
        string connStr; // Connection string i tutacak

        SqlConnection conn; // bağlantı işini halledecek değişgen/nesne
        SqlCommand cmd; // VT tarafında komut çalıştırmaya yarayacak
        SqlDataReader reader; // VT tarafında oluşacak olan veri kümesini programıma tasıyacak olan kütüphane

        string sqlstr; // içine sql ce komutları yazacağım değişgen


        public frmEmployees()
        {
            InitializeComponent();
        }

        private void btonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            connStr = @"Server=EGITMEN\MSSQLSERVER2;Database=Northwind;Trusted_Connection=true;Integrated Security=true;trustservercertificate=true;";

            conn = new SqlConnection(connStr);

            cmd = new SqlCommand();

            cmd.Connection = conn; // komut yarattım ama hangi bağlantıyı kullacağım
            
            conn.Open();

            FormInit(); 
            // sıra formu doldurmaya
            LoadData();

        }

        private void FormInit()
        {
            // formumun ekrana gelirkenki ilk hali

            tboxEmployeeID.ReadOnly = true; // bu değere dokunulamaz..Key
            tboxFName.ReadOnly = false;
            tboxLName.ReadOnly = false;
            tboxTitle.ReadOnly = false;
            tboxCity.ReadOnly = false;
            tboxCountry.ReadOnly = false;


        }

        private void LoadData()
        {
            // VT tarafına göndereceğim komutu burada hazırladım.
            cmd.CommandText = "SELECT EmployeeID,FirstName,LastName,Title,City,Country FROM Employees ORDER BY EmployeeID";

            reader= cmd.ExecuteReader(); // komutu al gönder cevabı geri iste
            // Gelen veriyi göster
            ShowData();


        }

        private void ShowData()
        {
            // reader nesnemin içi veriyle dolu
            if (reader.Read()) // son kayıda kadar okuyacak
            {
                tboxEmployeeID.Text = reader[0].ToString();
                tboxFName.Text= reader[1].ToString();
                tboxLName.Text= reader[2].ToString();
                tboxTitle.Text= reader[3].ToString();
                tboxCity.Text= reader[4].ToString();
                tboxCountry.Text= reader[5].ToString();
            }
            else
            {
                MessageBox.Show("Herhangi bir veri bulunamadı..");
            }
        }

        private void btonNext_Click(object sender, EventArgs e)
        {
            ShowData(); // bir sonraki kayıdı ekrana getirebilmek için tekrardan ShowData metoduna gittim.
        }

        private void btonNew_Click(object sender, EventArgs e)
        {
            tboxEmployeeID.Text = tboxFName.Text = tboxLName.Text = tboxTitle.Text = tboxCity.Text = tboxCountry.Text = "";

            // readonly olan bazı kontroller için veri girişini sağlıyorum.
            tboxFName.ReadOnly = tboxLName.ReadOnly = tboxTitle.ReadOnly = tboxCity.ReadOnly = tboxCountry.ReadOnly = false;

            // datareader nesnesini tekrar farklı bir şekilde kullanabilmek için kapatıyorum.

            reader.Close();

            cmd.CommandText = "SELECT ISNULL(MAX(EmployeeID),1000) + 1 FROM Employees";

            tboxEmployeeID.Text=cmd.ExecuteScalar().ToString();

            btonInsert.Enabled = true;
            btonUpdate.Enabled = false;
            btonDelete.Enabled = false;

            btonNew.Enabled = false;

            tboxFName.Focus();


        }

        private void btonInsert_Click(object sender, EventArgs e)
        {
            if (tboxFName.Text == "")
                MessageBox.Show("Lütfen Ad bilgisini giriniz","Ad Bilgisi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else if (tboxLName.Text == "")
                MessageBox.Show("Lütfen Soyad bilgisini giriniz", "Soyad Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Burada yapılacak şey SQL INSERT komut yapısını oluşturmak..
                sqlstr = String.Format("INSERT INTO Employees (FirstName,LastName,Title,City,Country) VALUES ('{0}','{1}','{2}','{3}','{4}')",tboxFName.Text,tboxLName.Text,tboxTitle.Text,tboxCity.Text,tboxCountry.Text);

                ExecuteDML(sqlstr);

                LoadData();
            }
        }

        private void ExecuteDML(string pSqlText)
        {
            // görevi sadece sql komutunu çalıştırmak olacak olan metot
            reader.Close();

            DialogResult dr = MessageBox.Show("Bu SQL komutunu çalıştırmak istiyor musunuz ?\n\n" + pSqlText, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) 
            { 
                cmd.CommandText= pSqlText; 

                int count=cmd.ExecuteNonQuery();

                if (count > 0)
                {
                    // Kayıt işlemi gerçekleştiyse...
                    MessageBox.Show("Kayıt işlemi başarıyla gerçekleşti..");
                }
                else
                    MessageBox.Show("Kayıt işlemi yapılamadı..");
            }
        }

        private void btonUpdate_Click(object sender, EventArgs e)
        {
            if (tboxFName.Text == "")
                MessageBox.Show("Lütfen Ad bilgisini giriniz", "Ad Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (tboxLName.Text == "")
                MessageBox.Show("Lütfen Soyad bilgisini giriniz", "Soyad Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                // Burada yapılacak şey SQL UPDATE komut yapısını oluşturmak..
                sqlstr = String.Format("UPDATE Employees SET FirstName='{0}',LastName='{1}',Title='{2}',City='{3}',Country='{4}' WHERE EmployeeID={5}", tboxFName.Text, tboxLName.Text, tboxTitle.Text, tboxCity.Text, tboxCountry.Text,tboxEmployeeID.Text);

                ExecuteDML(sqlstr);

                LoadData();

            }
        }

        private void btonDelete_Click(object sender, EventArgs e)
        {
            sqlstr = "DELETE FROM Employees WHERE EmployeeID=" + tboxEmployeeID.Text;

            ExecuteDML(sqlstr);

            LoadData();
        }
    }
}
