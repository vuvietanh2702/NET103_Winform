using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGender.Items.Add("Male");
            txtGender.Items.Add("?Female");
        }
        private void Display()
        {
            using(StudentInformationEntities entities = new StudentInformationEntities())
            {
                List<StudentInfo> studentsList = new List<StudentInfo>();
                studentsList = entities.StudentDetails.Select(x => new StudentInfo
                {
                    Id=x.id,
                    Name=x.name,
                    Age=x.age,
                    City=x.city,
                    Gender=x.gender,
                }).ToList();
                dataGridView.DataSource= studentsList;
            }
        }
    }
}
