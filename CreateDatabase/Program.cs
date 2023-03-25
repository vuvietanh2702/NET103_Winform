using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CreateDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
            //tạo database 
            //string query = "Create Database ComputerShop";
            //rename database
            //string query = "Alter Database Ta MODIFY NAME=SHOP";
            string query = "Insert into NhanVien1([FirstName],[LastName]) Values('Huan','Nguyen Cong')";
            // update database
            //string query = "Update NhanVien set FirstName='Thuong', LastName='Vo Van' WHERE ID=4" ;
            //delete database
            //string query = "Delete from NhanVien where ID=3";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Database Created Successfully");

            }
            catch (Exception e)
            {

                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                conn.Close();
                Console.ReadKey();
            }
        }
    }
}
