using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace A2_ICT525
{
    public partial class Form1 : Form
    {
        public List<OrderList> OrderLists = new List<OrderList>();              // Make a new list for the order
        Dictionary<string, ItemView> Items = new Dictionary<string,ItemView>(); // Make a new list of the item detail group 
        public struct ItemView          // Create an ItemView list   
        {
            public double Price;
            public int Left;
        }
        public struct OrderList         // Create an OrderList list
        {
            public string item;
            public double TotalPrice;
            public int NumberRequired;
        }
        public struct UserDetails       // Create an UserDetails list
        {
            public string UserName;
            public string UserEmail;
            public string UserAddress;
        }
        public Form1()
        {
            InitializeComponent();
            ItemGroupbox.Enabled = false;   // Make Bottom Groupbox unabled when Form1 loaded.
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            ItemGroupbox.Enabled = true;
            ItemNeededNum.Enabled = false;
            const string Txtfile = @"A2.txt";   

            ItemView item;
            item.Price = 0.0;
            item.Left = 0;
            Items.Add("Please select an item", item);       // print this string value as a initial value.
        
            using (StreamReader file = new StreamReader(Txtfile))
            {
                string line;
                file.ReadLine();
                while((line = file.ReadLine()) != null)     // Read the line until the value is null
                {
                    string[] space = line.Trim().Split('|');    // Splits a string into substrings with the following character which is ‘|’
                    item.Price = double.Parse(space[1]);
                    item.Left = int.Parse(space[2]);
                    Items.Add(space[0], item);      // Adds items in the Dictionary
                }
            }
            foreach (var LIST in Items)
            {
                ItemComboBox.Items.Add(LIST.Key);   // Adds items in the combo box
            }
            ItemComboBox.SelectedIndex = 0;
        }

        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( ItemComboBox.SelectedIndex == 0)   // If there is no selected item, then numerical up down function will be disabled. or not, enables the numerical up down
            {
                ItemNeededNum.Enabled = false;
            } else
            {
                ItemNeededNum.Enabled = true;
            }

            ItemPriceText.Text = "$" + Items[(string)ItemComboBox.SelectedItem].Price.ToString();   // Switch the Price text with the following function
            ItemsLeftText.Text = Items[(string)ItemComboBox.SelectedItem].Left.ToString();      //  Switch the Left text with the following function
        }

        public double TotalPrice;

        private void button1_Click(object sender, EventArgs e)
        {
            if (ItemNeededNum.Value == 0)
            {
                MessageBox.Show("Must be more than 1");     // Show this message if the user set 0 quantity of the item
                return;
            } else
            {
                MessageBox.Show("Selected item has been added to the cart."); // or not, show this.
            }
            OrderList order;
            int ItemNumber = (int)ItemNeededNum.Value;
            order.item = (string)ItemComboBox.SelectedItem;
            order.NumberRequired = ItemNumber;
            order.TotalPrice = ItemNumber * Items[(string)ItemComboBox.SelectedItem].Price;
            OrderLists.Add(order);
            TotalPrice = TotalPrice + order.TotalPrice;
        }

        private void ViewCartBtn_Click(object sender, EventArgs e)
        {
            Form2 viewchart = new Form2();
            viewchart.ShowDialog();     // show the Form 2.
        }
    }
}
