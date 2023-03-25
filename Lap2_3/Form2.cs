using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap2_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string TextGui)
        {
            InitializeComponent();
            Label_Nhan.Text= TextGui;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
