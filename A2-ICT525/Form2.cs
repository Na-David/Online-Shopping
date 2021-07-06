using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace A2_ICT525
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            Form1 OriginalForm = (Form1)Application.OpenForms["Form1"];     // Open the Form1
        }
        public string location = Application.StartupPath;       // Get the path of the file

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 OriginalForm = (Form1)Application.OpenForms["Form1"];
            if (OriginalForm.OrderLists.Count == 0)     // if the ordered list count is 0, add the following string as an initial value.
            {
                ItemListView.BeginUpdate();
                ListViewItem newList = new ListViewItem();
                ItemListView.Items.Add("Please add an item to cart");
                ItemListView.Items.Add(newList);
                ItemListView.EndUpdate();
            } else
            {
                foreach (Form1.OrderList LIST in OriginalForm.OrderLists)   // Display the ordered list item details on the ListViewItem.
                {
                    ItemListView.BeginUpdate();
                    ListViewItem newList = new ListViewItem(LIST.item);
                    newList.SubItems.Add(LIST.NumberRequired.ToString());
                    newList.SubItems.Add("$ " + LIST.TotalPrice.ToString());
                    ItemListView.Items.Add(newList);
                    ItemListView.EndUpdate();
                }
            }

            NameText.Text = OriginalForm.NameText.Text;     // For the below section, switch the text regarding of the UserDetails
            EamilText.Text = OriginalForm.EmailText.Text;
            AddressText.Text = OriginalForm.AddressText.Text;
            TotalPriceText.Text = "$ " +OriginalForm.TotalPrice;

        }
        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            string fileName = NameText.Text + DateTime.Now.ToLongDateString()+" .txt";      // Set the file name with the User Name + Date time.
            Form1 OriginalForm = (Form1)Application.OpenForms["Form1"];
            FileStream fs = null;
            try
            {
              fs = new FileStream(fileName, FileMode.CreateNew);        // Create a new file.
                using (StreamWriter writer = new StreamWriter(fs,Encoding.Default))     // In the file, write the following instructions below.
                {
                    writer.WriteLine("******************************Invoice******************************");
                    writer.WriteLine("Customer Name: " + NameText.Text);
                    writer.WriteLine("Customer Email: " + EamilText.Text);
                    writer.WriteLine("Customer Address: " + AddressText.Text);
                    writer.WriteLine("Invoice Date: " + DateTime.Now.ToLongDateString());
                    writer.WriteLine("Item \t\t | \t Total Item Price \t | \t Number of Items Ordered");

                    foreach (Form1.OrderList LIST in OriginalForm.OrderLists)
                    {
                        writer.WriteLine("{0} \t\t | \t\t {1} \t\t | \t\t {2}", LIST.item, LIST.TotalPrice, LIST.NumberRequired);
                    }
                }
            }
            finally
            {
                if (fs != null)     // If the filestream is not a null, release all resources.
                    fs.Dispose();
            }
            if (OriginalForm.OrderLists.Count == 0)
            {
                MessageBox.Show("Please add an item to cart"); 
                return;
            } else
            {
                MessageBox.Show("Order placed! Order invoice can be found on\n" + location + NameText.Text +".txt");
            }
        }
    }
}
