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
    public partial class StudentForm : Form
    {
        private SchoolEntities SchoolContext;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            SchoolContext = new SchoolEntities();
            var Person = from Pers in SchoolContext.People
                         select Pers;
            StudentdataGridView.DataSource = Person.ToList();
            StudentdataGridView.DataSource = SchoolContext.People.Local.ToList();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            SchoolContext.Dispose();
        }
    }
}
