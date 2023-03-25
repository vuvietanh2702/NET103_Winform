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

namespace Lab3
{
    public partial class Formbai1 : Form
    {
        public Formbai1()
        {
            InitializeComponent();
        }



        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Formbai1_Load(object sender, EventArgs e)
        {
            // Get Danh sách lớp vào listbox sổ ra các tên lớp
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True;trusted_connection=true;encrypt=false"))
            {
                try
                {
                    string query = "SELECT MaLop, TenLop FROM Lop"; //tạo một chuỗi truy vấn SQL để chọn các cột MaLop và TenLop từ bảng Lop
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);// truy vấn SQL được chỉ định trong biến query và kết nối cơ sở dữ liệu được chỉ định trong biến conn.
                    conn.Open(); //mở sql
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Lop");//sử dụng đối tượng SqlDataAdapter da để điền vào đối tượng DataSet ds với dữ liệu từ bảng Lop.
                    DsMaLop.DisplayMember = "TenLop";
                    DsMaLop.ValueMember = "MaLop";
                    DsMaLop.DataSource = ds.Tables["Lop"];//liên kết dữ liệu từ bảng “Lop” với danh sách DsMaLop.
                }
                catch (Exception )
                {

                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maHs = txtMaSV.Text.Trim();
            string tenHS = txtTenHS.Text.Trim();
            string ngaySinh = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string diaChi = txtDiaChi.Text.Trim();
            string maLop = DsMaLop.SelectedValue.ToString();
            string dTB = TxtDiemTB.Text.Trim();


            //string t = @"INSERT[dbo].[HocSinh]([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES(N'00003', N'Trần Bình', CAST(N'2023-03-15' AS Date), N'Hải Dương', CAST(5.8 AS Decimal(4, 1)), N'12A2')";
            //N'giatri'--> N'"+ giatri + @"'

            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True;trusted_connection=true;encrypt=false"))
            {

                string commandText = @"INSERT [HocSinh]([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES(N'" + txtMaSV.Text + @"', N'" + txtTenHS.Text + @"', CAST(N'" + ngaySinh + @"' AS Date), N'" + diaChi + @"', CAST(" + dTB + " AS Decimal(4, 1)), N'" + maLop + "')";
                SqlCommand cmd = new SqlCommand(commandText, conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted!");
                }
                catch (Exception )
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string query = $"delete from hocsinh where maHS like '{txtMaSV.Text}'";
            ExcuteNonQuery(query);
            Formbai1_Load(sender, e);
            MessageBox.Show("Xoá thành công");
        }
        int ExcuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                return cmd.ExecuteNonQuery();
            }
           ;
        }
    }
}
