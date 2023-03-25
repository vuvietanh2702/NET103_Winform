using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        public int GCD(int a, int b)
        {
            if (a == 0)
                 txtKetQua.Text=b.ToString();
            while (b != a)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
             txtKetQua.Text=a.ToString();
            return b;
        }
        public void GCD1(int a, int b)
        {
            txtKetQua.Text=((a*b)/ GCD(a,b)).ToString();
        }
        private void NutTim_Click(object sender, EventArgs e)
        {
            if (USCLN_Changed.Checked)
            {
                GCD(Convert.ToInt32(txtSoA.Text), Convert.ToInt32(txtSoB.Text));
            }
            else
            {
                GCD1(Convert.ToInt32(txtSoA.Text), Convert.ToInt32(txtSoB.Text));
            }
            
        }

        private void NutBoQua_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtKetQua.Text = "";
        }

        private void NutThoat_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("bạn có muốn thoát hay không?", "thoát chương trình", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }

        }



        private void txtSoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
