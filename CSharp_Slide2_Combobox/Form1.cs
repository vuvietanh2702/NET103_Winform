namespace CSharp_Slide2_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Ban ở {comboBox1.SelectedItem}", "địa chỉ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 1;
            comboBox1.SelectedIndex = 0;
            string[] data = { "5", "6", "7" };
            listBox2.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataNewForm_Click(object sender, EventArgs e)
        {
            Form NewForm = new Form();
            NewForm.Show();
        }
        
    }
}