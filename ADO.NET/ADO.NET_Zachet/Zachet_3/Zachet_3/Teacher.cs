using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Zachet_3
{
    public partial class TeacherForm : Form
    {
        private SchoolEntities SchoolContext;
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            SchoolContext = new SchoolEntities();
            var Person = from Pers in SchoolContext.People
                           select Pers;
            TeacherdataGridView.DataSource = Person.ToList();
            TeacherdataGridView.DataSource = SchoolContext.People.Local.ToBindingList();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                SchoolContext.SaveChanges();
                MessageBox.Show("Изменения в базе данных сохранены");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            SchoolContext.Dispose();
        }
    }
}
