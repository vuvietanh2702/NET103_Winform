using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CSharp_Silde4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Program().Data();
        }
        private void Data()
        {
            try
            {
                // Tạo một bảng Customer
                DataTable Customer = new DataTable("Customer");

                //Tạo các cột và các schema
                DataColumn CustomerId = new DataColumn("ID", typeof(Int32));
                Customer.Columns.Add(CustomerId);
                DataColumn CustomerName = new DataColumn("Name", typeof(string));
                Customer.Columns.Add(CustomerName);
                DataColumn CustomerMobile = new DataColumn("Mobile", typeof(string));
                Customer.Columns.Add(CustomerMobile);

                //Thêm các hàng dữ liệu vào bảng Customer
                Customer.Rows.Add(101, "Van Quyen", "118001229");
                Customer.Rows.Add(202, "Freetuts.net", "1234567890");

                // Tạo bảng Orders
                DataTable Orders = new DataTable("Orders");

                //Tạo các cột và các schema
                DataColumn OrderId = new DataColumn("ID", typeof(Int32));
                Orders.Columns.Add(OrderId);
                DataColumn CustId = new DataColumn("CustomerId", typeof(Int32));
                Orders.Columns.Add(CustId);
                DataColumn OrderAmount = new DataColumn("Amount", typeof(Int32));
                Orders.Columns.Add(OrderAmount);

                //Thêm các hàng dữ liệu vào bảng Orders
                Orders.Rows.Add(10001, 101, 20000);
                Orders.Rows.Add(10002, 102, 30000);

                //Tạo DataSet
                DataSet dataSet = new DataSet();

                //Thêm các DataTables vào DataSet.
                dataSet.Tables.Add(Customer);
                dataSet.Tables.Add(Orders);

                Console.WriteLine("Du lieu trong bang Customer: ");
                //sử dụng vòng lặp foreach để thêm dữ liệu vào datatable bằng vị trí index
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine(row["ID"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
                }
                Console.WriteLine();

                Console.WriteLine("Du lieu trong bang Orders: ");
                //sử dụng vòng lặp foreach để thêm dữ liệu vào datatable bằng tên bảng
                foreach (DataRow row in dataSet.Tables["Orders"].Rows)
                {
                    Console.WriteLine(row["ID"] + ",  " + row["CustomerId"] + ",  " + row["Amount"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }

        }
    }
}
