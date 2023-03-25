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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

      
        public Form4(String Text_Gui_Den )
        {
            InitializeComponent();
           label1.Text = Text_Gui_Den;
        }
    }
}
