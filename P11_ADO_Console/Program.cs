using Microsoft.Data.SqlClient;
namespace P11_ADO_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connStr; // Connection string i tutacak
            
            SqlConnection conn; // bağlantı işini halledecek değişgen/nesne

            connStr = @"Server=EGITMEN\MSSQLSERVER2;Database=Northwind;Trusted_Connection=true;Integrated Security=true;trustservercertificate=true;";
            
            conn= new SqlConnection(connStr);

            try
            {
                conn.Open(); // DB ye ulasmaya çalışacak

                Console.WriteLine("VT tarafına ulaştım...\n\n");
            }
            catch (Exception e)
            {

                Console.WriteLine($"Ulaşamadım - Hata kodu : {e.Message}");
            }
            finally
            {
                conn.Close();

                Console.WriteLine("VT bağlantısını kestim...\n\n");


            }
            




            Console.ReadKey();
        }
    }
}
