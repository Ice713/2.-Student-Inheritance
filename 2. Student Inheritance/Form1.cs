using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.Student_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Student student = new Student(textBoxName.Text, Convert.ToInt32(numericUpDownAge.Text), textBoxCourse.Text);

            string details = student.GetDetails();

            MessageBox.Show(details, "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
