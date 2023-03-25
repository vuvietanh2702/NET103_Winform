using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var entitiesCtor = new StudentInformationEntities();
            using (entitiesCtor)
            {
                var student = entitiesCtor.StudentDetails.Where(s => s.Id == 2).FirstOrDefault(StudentInfomation);
            }
        }
    }
}
