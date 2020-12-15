using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.Lab3Ex4_Validation
{
    public partial class UserControlPerson : UserControl
    {
        public UserControlPerson()
        {
            InitializeComponent();
        }

        private void UserControlPerson_Load(object sender, EventArgs e)
        {

        }

        public string PersonFirstname
        {
            get { return textBoxFirstname.Text; }
            set { textBoxFirstname.Text = value; }
        }

        public string PersonLastname
        {
            get { return textBoxLastname.Text; }
            set { textBoxLastname.Text = value; }
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                e.Cancel = false;
            }
            else
            {
                try
                {
                    double.Parse(textBoxPassword.Text);
                    e.Cancel = false;
                }
                catch
                {
                    e.Cancel = true;
                    MessageBox.Show("Пароль может содержать только цифры!");
                }
            }
        }

        private void textBoxFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Строка имени не может содержать цифры");
            }
        }

        private void textBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Строка фамилии не может содержать цифры");
            }
        }
    }
}
