using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        { //get data từ sql -> datagridview
            using (SqlConnection connectionn = new SqlConnection(@"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True;trusted_connection=true;encrypt=false"))
            {
                try
                {
                    string query = "SELECT MaLop, TenLop FROM Lop"; //lấy tất cả dữ liệu trong sql bảng lớp
                    SqlDataAdapter da = new SqlDataAdapter(query, connectionn);

                    string queryHS = "SELECT HocSinh.MaHS, HocSinh.TenHS, HocSinh.NgaySinh, HocSinh.DiaChi, HocSinh.DTB, Lop.TenLop, Lop.MaLop FROM HocSinh INNER JOIN Lop ON HocSinh.MaLop = Lop.MaLop"; //lấy tất cả dữ liệu trong sql bảng hocsinh
                    SqlDataAdapter hs = new SqlDataAdapter(queryHS, connectionn);
                    connectionn.Open();
                    // get mã lớp vào ô button lớp
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Lop");
                    txtDsLop.DisplayMember = "TenLop";
                    txtDsLop.ValueMember = "MaLop";
                    txtDsLop.DataSource = ds.Tables["Lop"];
                    // lấy data vào bảng gridview
                    DataTable dt = new DataTable();
                    hs.Fill(dt);
                    Data.DataSource = dt;

                    Data.Columns[6].Visible = false;
                    DataGridViewColumn column = Data.Columns[3];
                    column.Width = 300;
                    Data.Columns[0].HeaderText = "Mã học sinh";
                    Data.Columns[1].HeaderText = "Tên học sinh";
                    Data.Columns[2].HeaderText = "Ngày sinh";
                    Data.Columns[3].HeaderText = "Địa chỉ";
                    Data.Columns[4].HeaderText = "Điểm TB";
                    Data.Columns[5].HeaderText = "Tên lớp";
                    Data.Rows[0].Selected = true;


                    txtMaHS.Text = Data.CurrentRow.Cells[0].Value.ToString();
                    txtTen.Text = Data.CurrentRow.Cells[1].Value.ToString();
                    txtNS.Text = Data.CurrentRow.Cells[2].Value.ToString();
                    txtDChi.Text = Data.CurrentRow.Cells[3].Value.ToString();
                    txtDiemTB.Text = Data.CurrentRow.Cells[4].Value.ToString();
                    txtDsLop.SelectedValue = Data.CurrentRow.Cells[6].Value;
                }
                catch (Exception)
                {

                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }


        }

        private void Data_SelectionChanged(object sender, EventArgs e)
        {
            if (Data.CurrentRow != null)
            {
                txtMaHS.Text = Data.CurrentRow.Cells[0].Value.ToString();
                txtTen.Text = Data.CurrentRow.Cells[1].Value.ToString();
                txtNS.Text = Data.CurrentRow.Cells[2].Value.ToString();
                txtDChi.Text = Data.CurrentRow.Cells[3].Value.ToString();
                txtDiemTB.Text = Data.CurrentRow.Cells[4].Value.ToString();
                txtDsLop.SelectedValue = Data.CurrentRow.Cells[6].Value;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            string query = @"delete from hocsinh where maHS like '"+ Data.CurrentRow.Cells[0].Value.ToString() +"' ";
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch 
                {
                    MessageBox.Show("erro");
                }
            }
            Form2_Load(sender, e);
        }

        private void btLuu_Click_1(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text.Trim();
            string Ten = txtTen.Text.Trim();
            string Ns = txtNS.Value.ToShortDateString();
            string DcHi = txtDChi.Text.Trim();
            string DiemTB = txtDiemTB.Text.Trim();
            string DSLop = txtDsLop.SelectedValue.ToString().Trim();

            using (SqlConnection connectionn = new SqlConnection(@"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=QLHOCSINH;Integrated Security=True;trusted_connection=true;encrypt=false"))
            {
                string commandText = @" Insert into [HocSinh]([MaHS], [TenHS], [NgaySinh], [DiaChi], [DTB], [MaLop]) VALUES(N'" + maHS + @"', N'" + Ten + @"', CAST(N'" + Ns + @"' AS Date), N'" + DcHi + @"', CAST(" + DiemTB + " AS Decimal(4, 1)), N'" + DSLop + "')";
                SqlCommand cmd = new SqlCommand(commandText, connectionn);
                try
                {
                    connectionn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted!");
                }
                catch (Exception)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
                finally
                {
                    connectionn.Close();
                }
                Form2_Load(sender, e);
            }
        }
    }
}
