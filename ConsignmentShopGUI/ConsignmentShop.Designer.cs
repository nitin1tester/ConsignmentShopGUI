namespace ConsignmentShopGUI
{
    partial class ConsignmentShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeaderText = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.ItemListBoxLabel = new System.Windows.Forms.Label();
            this.AddToCart = new System.Windows.Forms.Button();
            this.ShoppingCartListBoxLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.Purchase = new System.Windows.Forms.Button();
            this.VendorList = new System.Windows.Forms.Label();
            this.VendorListBox = new System.Windows.Forms.ListBox();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreProfitAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderText.Location = new System.Drawing.Point(26, 25);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(234, 29);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "Consignment Shop";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 20;
            this.ItemListBox.Location = new System.Drawing.Point(31, 87);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(264, 224);
            this.ItemListBox.TabIndex = 1;
            // 
            // ItemListBoxLabel
            // 
            this.ItemListBoxLabel.AutoSize = true;
            this.ItemListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemListBoxLabel.Location = new System.Drawing.Point(27, 64);
            this.ItemListBoxLabel.Name = "ItemListBoxLabel";
            this.ItemListBoxLabel.Size = new System.Drawing.Size(79, 20);
            this.ItemListBoxLabel.TabIndex = 2;
            this.ItemListBoxLabel.Text = "Item List";
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(330, 154);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(125, 39);
            this.AddToCart.TabIndex = 3;
            this.AddToCart.Text = "Add To Cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // ShoppingCartListBoxLabel
            // 
            this.ShoppingCartListBoxLabel.AutoSize = true;
            this.ShoppingCartListBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoppingCartListBoxLabel.Location = new System.Drawing.Point(488, 64);
            this.ShoppingCartListBoxLabel.Name = "ShoppingCartListBoxLabel";
            this.ShoppingCartListBoxLabel.Size = new System.Drawing.Size(77, 20);
            this.ShoppingCartListBoxLabel.TabIndex = 5;
            this.ShoppingCartListBoxLabel.Text = "Cart List";
            // 
            // CartListBox
            // 
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 20;
            this.CartListBox.Location = new System.Drawing.Point(492, 87);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(264, 224);
            this.CartListBox.TabIndex = 4;
            // 
            // Purchase
            // 
            this.Purchase.Location = new System.Drawing.Point(659, 339);
            this.Purchase.Name = "Purchase";
            this.Purchase.Size = new System.Drawing.Size(97, 40);
            this.Purchase.TabIndex = 6;
            this.Purchase.Text = "Purchase";
            this.Purchase.UseVisualStyleBackColor = true;
            this.Purchase.Click += new System.EventHandler(this.Purchase_Click);
            // 
            // VendorList
            // 
            this.VendorList.AutoSize = true;
            this.VendorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorList.Location = new System.Drawing.Point(27, 339);
            this.VendorList.Name = "VendorList";
            this.VendorList.Size = new System.Drawing.Size(101, 20);
            this.VendorList.TabIndex = 8;
            this.VendorList.Text = "Vendor List";
            // 
            // VendorListBox
            // 
            this.VendorListBox.FormattingEnabled = true;
            this.VendorListBox.ItemHeight = 20;
            this.VendorListBox.Location = new System.Drawing.Point(31, 362);
            this.VendorListBox.Name = "VendorListBox";
            this.VendorListBox.Size = new System.Drawing.Size(264, 224);
            this.VendorListBox.TabIndex = 7;
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Location = new System.Drawing.Point(488, 460);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(89, 20);
            this.StoreProfitLabel.TabIndex = 9;
            this.StoreProfitLabel.Text = "Store Profit";
            // 
            // StoreProfitAmount
            // 
            this.StoreProfitAmount.AutoSize = true;
            this.StoreProfitAmount.Location = new System.Drawing.Point(610, 460);
            this.StoreProfitAmount.Name = "StoreProfitAmount";
            this.StoreProfitAmount.Size = new System.Drawing.Size(49, 20);
            this.StoreProfitAmount.TabIndex = 10;
            this.StoreProfitAmount.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 649);
            this.Controls.Add(this.StoreProfitAmount);
            this.Controls.Add(this.StoreProfitLabel);
            this.Controls.Add(this.VendorList);
            this.Controls.Add(this.VendorListBox);
            this.Controls.Add(this.Purchase);
            this.Controls.Add(this.ShoppingCartListBoxLabel);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.ItemListBoxLabel);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.HeaderText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConsignmentShop";
            this.Text = "Consignment Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label ItemListBoxLabel;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Label ShoppingCartListBoxLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Button Purchase;
        private System.Windows.Forms.Label VendorList;
        private System.Windows.Forms.ListBox VendorListBox;
        private System.Windows.Forms.Label StoreProfitLabel;
        private System.Windows.Forms.Label StoreProfitAmount;
    }
}

