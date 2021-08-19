using ConsignmentShopLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopApp
{
    public partial class Form1 : Form
    {
        private Store store = new Store();
        private List<ItemClass> shoppingcartData = new List<ItemClass>();
        private decimal store_profit = 0; 

        
        BindingSource source = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            SetupData();
            source.DataSource = store.Items.Where(x=>x.Sold==false).ToList();
            ItemListBox.DataSource = source;
            ItemListBox.DisplayMember = "Display";
            ItemListBox.ValueMember = "Display";

            cartBinding.DataSource = shoppingcartData;
            ShoppingCartListBox.DataSource = cartBinding;

            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            VendorList.DataSource = vendorBinding;
            cartBinding.ResetBindings(false);

            VendorList.DisplayMember = "Display";
            VendorList.ValueMember = "Display";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "bill", LastName = "Gates" });
            store.Vendors.Add(new Vendor { FirstName = "steve", LastName = "jobs" });

            store.Items.Add(new ItemClass { Title = "Behind The Eyes", Description = "Story of a knight", Price = 4.50M, Owner = store.Vendors[0] });

            store.Items.Add(new ItemClass { Title = "Revolution", Description = "Information and examples",
                Price = 6.38M,
                Owner = store.Vendors[1] });

            store.Items.Add(new ItemClass
            {
                Title = "A story in an age of a candel",
                Description = " love story",
                Price = 5.8M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new ItemClass
            {
                Title = "Ghost in Wires",
                Description = "Information Technology",
                Price = 6.0M,
                Owner = store.Vendors[1]
            });
        }

        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            ItemClass item = (ItemClass)ItemListBox.SelectedItem;
            shoppingcartData.Add(item);
        }

        private void ShoppingCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            foreach (ItemClass item in shoppingcartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                store_profit +=(1- (decimal)item.Owner.Commission) * item.Price;

            }
            store_profit_value.Text = $"{store_profit}";
            source.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            shoppingcartData.Clear();
            source.ResetBindings(false);
            cartBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);
           
        }
    }
}
