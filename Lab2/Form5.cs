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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.TopLevel=false;
            form.Location = new Point(0,16);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size=new Size(this.Size.Width,this.Size.Height);
            this.Controls.Add(form);
            form.Show();
        }

        
        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.TopLevel = false;
            form.Location = new Point(0, 16);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = new Size(this.Size.Width, this.Size.Height);
            this.Controls.Add(form);
            form.Show();
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.TopLevel = false;
            form.Location = new Point(0, 16);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Size = new Size(this.Size.Width, this.Size.Height);
            this.Controls.Add(form);
            form.Show();
        }
    }
}
