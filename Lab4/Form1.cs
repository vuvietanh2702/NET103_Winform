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

namespace Lab4
{
    public partial class Form1 : Form
    {
        static string Connection = @"Data Source=LAPTOP-IRUEAU\SQLEXPRESS;Initial Catalog=QuanLy;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btGetData_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            try
            {
                string sqlString = "SELECT * FROM Users";
                SqlDataAdapter data = new SqlDataAdapter(sqlString, connect);
                connect.Open();
                DataSet ds= new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);

                data.Fill(dt);
                dataUser.DataSource = dt;
                dataUser.Columns[0].Visible = true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            string userName = dataUser.CurrentRow.Cells[1].Value.ToString();
            int groupID = Convert.ToInt32(dataUser.CurrentRow.Cells[2].Value.ToString());
            try
            {
                string insertString = @"insert into  Users ([UserName], [GroupID]) VALUES(N'" + userName + "','" + groupID +"')";
                SqlCommand cmd = new SqlCommand(insertString, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            string userName = dataUser.CurrentRow.Cells[1].Value.ToString();
            int groupID = Convert.ToInt32(dataUser.CurrentRow.Cells[2].Value.ToString());
            try
            { 
                string updateString = @"update  users 
                set UserName = 'userName', GroupID='groupID'
                Where  UserID like'" + dataUser.CurrentRow.Cells[0].Value.ToString().Trim() + "'"; 
;
                SqlCommand cmd = new SqlCommand(updateString, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection);
            try
            {
                string deleteString = @"delete from users where UserID like'" + dataUser.CurrentRow.Cells[0].Value.ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(deleteString,connect);
                connect.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            btGetData_Click(sender,e);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
