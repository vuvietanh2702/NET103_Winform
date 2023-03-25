namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKetQua.Text=(int.Parse(txtSoN.Text)+ int.Parse(txtSoM.Text)).ToString();

        }

        private void txtSoN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (int.Parse(txtSoN.Text) - int.Parse(txtSoM.Text)).ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (int.Parse(txtSoN.Text) * int.Parse(txtSoM.Text)).ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = (int.Parse(txtSoN.Text) / int.Parse(txtSoM.Text)).ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtSoN.Text = "";
            txtSoM.Text = "";
            txtKetQua.Text = "";
        }

        private void txtSoN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}