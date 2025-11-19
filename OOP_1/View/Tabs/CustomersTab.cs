using OOP_1.Model;
using OOP_1.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_1.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> customers = new List<Customer>();
        private JsonSerialazer<Customer> serialazer = new JsonSerialazer<Customer>("C:\\Users\\Арсюша\\Desktop\\2 КУРС\\OOP\\OOP_1\\customersData.json");
        public CustomersTab()
        {
            InitializeComponent();
            customers = serialazer.deserialize();
            if (customers != null)
            {
                customersListBox.DataSource = customers;
            }
            else
            {
                customers = new List<Customer>();
            }
        }

        private void updateListBox()
        {
            serialazer.clear();
            serialazer.serialize(customers);
            customersListBox.DataSource = null;
            customersListBox.DataSource = customers;
        }
        private void customersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer customer = customersListBox.SelectedItem as Customer;
            idTextBox.Text = customer.Id.ToString();
            nameTextBox.Text = customer.Fullname;
            addressTextBox.Text = customer.Address;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new Customer().Fullname = nameTextBox.Text;
                nameTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                nameTextBox.BackColor = Color.LightPink;
            }
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new Customer().Address = addressTextBox.Text;
                addressTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                addressTextBox.BackColor = Color.LightPink;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Fullname = nameTextBox.Text;
            customer.Address = addressTextBox.Text;
            customers.Add(customer);
            updateListBox();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            customers.Remove(customersListBox.SelectedItem as Customer);
            updateListBox();
        }

        private void refactorButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Fullname = nameTextBox.Text;
            customer.Address = addressTextBox.Text;
            customers[customersListBox.SelectedIndex] = customer;
            updateListBox();
        }
    }
}
