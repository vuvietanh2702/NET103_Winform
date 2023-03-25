using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CreateMSAcccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ADMIN\OneDrive\Desktop\Database11.accdb");
            OleDbCommand cmd = con.CreateCommand();
            try
            {
                con.Open();
                cmd.CommandText = "Insert into NhanVien(FirstName,LastName)Values('Tuan','Nguyen Cong')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Nhập dữ liệu thành công");

            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi"+ e.ToString());
                
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
    }
}
