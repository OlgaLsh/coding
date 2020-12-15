using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Coeffitients : Form
    {
        public double A
        {
            get { return Convert.ToDouble(textBox1.Text); }

        }
        public double B
        {
            get { return Convert.ToDouble(textBox2.Text); }
        }
        public double C
        {
            get { return Convert.ToDouble(textBox3.Text); }
        }
        public Coeffitients()
        {
            InitializeComponent();
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
        private void empty_Validating(object sender, CancelEventArgs e)
        {
            Control sendCtrl = (Control)sender;
            bool valid = !String.IsNullOrWhiteSpace(sendCtrl.Text);
            e.Cancel = !valid;
            errorProvider1.SetError(sendCtrl, (valid ? string.Empty : sendCtrl.Tag.ToString()));
        }

        private void Coeffitients_Load(object sender, EventArgs e)
        {

        }
    }
}
