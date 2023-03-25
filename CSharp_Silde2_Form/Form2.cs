using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Silde2_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public Form2(String Text_Gui_Den)
        {
            InitializeComponent();
            label2.Text = Text_Gui_Den;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }

}
