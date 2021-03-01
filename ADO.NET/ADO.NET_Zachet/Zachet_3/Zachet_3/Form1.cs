using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zachet_3
{
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentFrm = new StudentForm();
            studentFrm.Show();
            this.Hide();
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            TeacherForm teacherFrm = new TeacherForm();
            teacherFrm.Show();
            this.Hide();
        }
    }
}
