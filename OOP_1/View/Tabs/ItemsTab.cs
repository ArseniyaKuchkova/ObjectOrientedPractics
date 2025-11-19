using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_1.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private JsonSerialazer<Item> itemSerializer = new JsonSerialazer<Item>("C:\\Users\\Арсюша\\Desktop\\2 КУРС\\OOP\\OOP_1\\data.json");
        private List<Item> _items = new List<Item>();
        public ItemsTab()
        {
            InitializeComponent();
            _items = itemSerializer.deserialize();
            if (_items != null)
            {
                itemsListBox.DataSource = _items;
            }
            else
            {
                _items = new List<Item>();
            }
        }
       private void updateListBox()
       {
           itemSerializer.clear();
           itemSerializer.serialize(_items);
           itemsListBox.DataSource = null;
           itemsListBox.DataSource = _items;
       }
        private void AddButton_Click(object sender, EventArgs e)
        {

            Item item = new Item();
            item.Cost = double.Parse(costTextBox.Text);
            item.Name = nameTextBox.Text;
            item.Info = infoTextBox.Text;
            _items.Add(item);
            updateListBox();
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Item current = itemsListBox.SelectedItem as Item;
                idTextBox.Text = current.Id.ToString();
                costTextBox.Text = current.Cost.ToString();
                nameTextBox.Text = current.Name.ToString();
                infoTextBox.Text = current.Info.ToString();
            }
            catch (Exception ex)
            {
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Item current = itemsListBox.SelectedItem as Item;
            _items.Remove(current);
            updateListBox();
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                new Item().Cost = Double.Parse(costTextBox.Text);
                costTextBox.BackColor = Color.White;

            }
            catch (Exception ex)
            {
                costTextBox.BackColor = Color.LightPink;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nameTextBox.BackColor = Color.White;
                new Item().Name = nameTextBox.Text;
            }
            catch (Exception ex)
            {
                nameTextBox.BackColor = Color.LightPink;
            }
        }

        private void infoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                infoTextBox.BackColor = Color.White;
                new Item().Info = infoTextBox.Text;
            }
            catch (Exception ex)
            {
                infoTextBox.BackColor = Color.LightPink;
            }
        }

        private void refactorButton_Click(object sender, EventArgs e)
        {
            Item item = itemsListBox.SelectedItem as Item;
            item.Cost = double.Parse(costTextBox.Text);
            item.Name = nameTextBox.Text;
            item.Info = infoTextBox.Text;
            _items[itemsListBox.SelectedIndex] = item;
            updateListBox();
        }
    }
}
