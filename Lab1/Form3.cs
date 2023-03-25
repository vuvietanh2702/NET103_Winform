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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void GiaiPT(object sender, EventArgs e)
        {
            if (PTBac1.Checked)
            {
                GiaiPTBac1(Convert.ToDouble(txtSoA.Text),Convert.ToDouble(txtSoB.Text));
            }
            else
            {
                GiaiPTBac2(Convert.ToDouble(txtSoA.Text), Convert.ToDouble(txtSoB.Text),Convert.ToDouble(txtSoC.Text));
            }
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            var check = MessageBox.Show("bạn có muốn thoát hay không?", "thoát chương trình", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                this.Close();
            }
            
            
           
        }

        private void SoA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void GiaiPTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0) txtKetQua.Text ="vô số nghiệm";
                else txtKetQua.Text="vô nghiệm";
            }
            else
            {
                  txtKetQua.Text = (-b/a).ToString();
            }
        }
        public void GiaiPTBac2 (double a, double b, double c)
        {
            if (a==0)
            {
                GiaiPTBac1(b,c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                double x1, x2;
                if (delta > 0)
                {
                    x1 = (double)(-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (double)(-b + Math.Sqrt(delta)) / (2 * a);
                    txtKetQua.Text = x1.ToString() + "||" + x2.ToString();
                    
                }
                else if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                     txtKetQua.Text= "nghiệm kép:" + x1.ToString();
                }
                else
                {
                    txtKetQua.Text="Vo nghiem!";
                }
            }
        }

        private void PTBac1_CheckedChanged(object sender, EventArgs e)
        {
            txtSoC.ReadOnly = true;
        }

        private void PTBac2_CheckedChanged(object sender, EventArgs e)
        {
            txtSoC.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtSoC.Text = "";
            txtKetQua.Text = "";
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
