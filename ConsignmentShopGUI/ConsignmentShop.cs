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

namespace ConsignmentShopGUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> ShoppingCartData = new List<Item>();
        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinging = new BindingSource();
        BindingSource VendorBinging = new BindingSource();
        private decimal storeProfit = 0;
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemBinding.DataSource = store.items.Where(x => x.Sold == false).ToList();
            ItemListBox.DataSource = itemBinding;

            ItemListBox.DisplayMember = "Display";
            ItemListBox.ValueMember = "Display";

            cartBinging.DataSource = ShoppingCartData;
            CartListBox.DataSource = cartBinging;

            CartListBox.DisplayMember = "Display";
            CartListBox.ValueMember = "Display";

            VendorBinging.DataSource = store.Vendors;
            VendorListBox.DataSource = VendorBinging;

            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor
            {
                FirstName = "Nitin",
                LastName = "Rastogi",
                Commission = .3
            });
            store.Vendors.Add(new Vendor
            {
                FirstName = "Mukesh",
                LastName = "Rastogi",
                Commission = .5
            });
            store.Vendors.Add(new Vendor
            {
                FirstName = "Rajendra",
                LastName = "Rastogi",
                Commission = .7
            });

            store.items.Add(new Item
            {
                Title = " Title of Item 1",
                Description = "Description of Item 1",
                Price = 100,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[0]
            });
            store.items.Add(new Item
            {
                Title = " Title of Item 2",
                Description = "Description of Item 2",
                Price = 200,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[1]
            });
            store.items.Add(new Item
            {
                Title = " Title of Item 3",
                Description = "Description of Item 3",
                Price = 300,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[1]
            });
            store.items.Add(new Item
            {
                Title = " Title of Item 4",
                Description = "Description of Item 4",
                Price = 400,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.items.Add(new Item
            {
                Title = " Title of Item 5",
                Description = "Description of Item 5",
                Price = 500,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.items.Add(new Item
            {
                Title = " Title of Item 6",
                Description = "Description of Item 6",
                Price = 600,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[1]
            });
            store.items.Add(new Item
            {
                Title = " Title of Item 7",
                Description = "Description of Item 7",
                Price = 700,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.items.Add(new Item
            {
                Title = " Title of Item 8",
                Description = "Description of Item 8",
                Price = 800,
                PaymentDistributed = true,
                Sold = false,
                Owner = store.Vendors[2]
            });
            store.StoreName = "Rastogi Book Stall";

        }


        private void AddToCart_Click(object sender, EventArgs e)
        {
            // Mark wwhat is selected on from the item list.
            // Copy that item to shopping cart list.
            // Do we remove the item from the item list ? No

            Item selectedItem = (Item)ItemListBox.SelectedItem;

            ShoppingCartData.Add(selectedItem);

            cartBinging.ResetBindings(false);
        }

        private void Purchase_Click(object sender, EventArgs e)
        {
            // Mark each item in the cart as sold.
            // Clear the cart
            foreach (Item item in ShoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            ShoppingCartData.Clear();

            itemBinding.DataSource = store.items.Where(x => x.Sold == false).ToList();

            StoreProfitAmount.Text = string.Format("${0}", storeProfit);

            cartBinging.ResetBindings(false);
            itemBinding.ResetBindings(false);
            VendorBinging.ResetBindings(false);
        }
    }
}
 