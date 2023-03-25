using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void SoDienCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Không nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        private void SoDienMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Không nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void SoDienTieuThu_TextChanged(object sender, EventArgs e)
        {

            SoDienTieuThu.ReadOnly = true;
            SoDienTieuThu.Text = (Convert.ToInt32(SoDienMoi.Text) - Convert.ToInt32(SoDienCu.Text)).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SoDienDinhMuc.ReadOnly = true;
            SoDienDinhMuc.Text = "50";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SoDienTieuThu.Text) >= 50)
            {
                SoDienQua.Text = (Convert.ToInt32(SoDienTieuThu.Text) - Convert.ToInt32(SoDienDinhMuc.Text)).ToString();
            }
            else
            {
                SoDienQua.Text = "0";
            }
        }

        private void TienTra_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SoDienTieuThu.Text) >= Convert.ToInt32(SoDienDinhMuc.Text))
            {
                TienTra.Text = (Convert.ToInt32(SoDienDinhMuc.Text) * 500 + (Convert.ToInt32(SoDienQua.Text) * 1000)).ToString();
            }
            else
            {
                TienTra.Text = (Convert.ToInt32(SoDienTieuThu.Text) * 500).ToString();
            }
        }

        private void TinhTien_Click(object sender, EventArgs e)
        {
            TienTra_TextChanged(sender, e);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult click = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (click == DialogResult.Yes) this.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedText = "Mời chọn khách hàng";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Click_In_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem==null)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK);
            }
            else
            {
            //tên
            Label label_Name = new Label();
            label_Name.Size = new Size(251, 28);
            label_Name.Text = comboBox1.SelectedItem.ToString();
            label_Name.Location = new Point(0, 0);
            XuatThongTin.Controls.Add(label_Name); 
            
            Label label_TongTien = new Label();
            label_TongTien.Text = "Tien tra:"+TienTra.Text;
            label_TongTien.Location = new Point(0, 30);
            XuatThongTin.Controls.Add(label_TongTien);
            //số điện tiêu thụ
            Label label_KW = new Label();
            label_KW.Text ="So dien da tieu thu:"+ SoDienTieuThu.Text;
            label_KW.Location = new Point(0, 60);
            XuatThongTin.Controls.Add(label_KW);

            }



        }

        private void XuatThongTin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}