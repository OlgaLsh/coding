using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirst;

namespace Zachet_4
{
    public partial class MarketForm : Form
    {
        SampleContext context = new SampleContext();
        public MarketForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    LastName = this.textBoxLastName.Text,
                    FirstName = this.textBoxFirstName.Text,
                    Phone = this.textBoxPhone.Text,
                    email = this.textBoxEmail.Text,
                    Orders = orderlistBox.SelectedItems.OfType<Order>().ToList()
                };
                context.Customers.Add(customer);
                context.SaveChanges();
                textBoxLastName.Text = String.Empty;
                textBoxFirstName.Text = String.Empty;
                textBoxPhone.Text = String.Empty;
                textBoxEmail.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }

        private void Output()
        {
            if (this.radioButtonCustomer.Checked == true)
                dataGridView1.DataSource = context.Customers.ToList();
            else if (this.radioButtonOrder.Checked == true)
                dataGridView1.DataSource = context.Orders.ToList();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            Output();
            var query = from b in context.Customers
                        orderby b.LastName
                        select b;
        }

        private void MarketForm_Load(object sender, EventArgs e)
        {
            context.Orders.Add(new Order
            {
                OrderName = "Томаты",
                Weight = 2,
                Price = 154
            });
            context.Orders.Add(new Order
            {
                OrderName = "Картофель",
                Weight = 3,
                Price = 69
            });
            context.Orders.Add(new Order
            {
                OrderName = "Огурцы",
                Weight = 1,
                Price = 211
            });
            context.Orders.Add(new Order
            {
                OrderName = "Капуста",
                Weight = 1,
                Price = 50
            });
            context.SaveChanges();
            orderlistBox.DataSource = context.Orders.ToList();
        }
    }
}
