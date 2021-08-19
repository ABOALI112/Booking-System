
namespace ConsignmentShopApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.Store_item_label = new System.Windows.Forms.Label();
            this.StoreitemLabel = new System.Windows.Forms.Label();
            this.ShoppingCartListBox = new System.Windows.Forms.ListBox();
            this.AddtoCartButton = new System.Windows.Forms.Button();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.VendorList = new System.Windows.Forms.ListBox();
            this.StoreProfitlabel = new System.Windows.Forms.Label();
            this.store_profit_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consignment Shop Demo ";
            // 
            // ItemListBox
            // 
            this.ItemListBox.BackColor = System.Drawing.SystemColors.Info;
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.ItemHeight = 15;
            this.ItemListBox.Location = new System.Drawing.Point(30, 113);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.Size = new System.Drawing.Size(286, 259);
            this.ItemListBox.TabIndex = 1;
            // 
            // Store_item_label
            // 
            this.Store_item_label.AutoSize = true;
            this.Store_item_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Store_item_label.ForeColor = System.Drawing.Color.Black;
            this.Store_item_label.Location = new System.Drawing.Point(30, 85);
            this.Store_item_label.Name = "Store_item_label";
            this.Store_item_label.Size = new System.Drawing.Size(110, 25);
            this.Store_item_label.TabIndex = 2;
            this.Store_item_label.Text = "Store Items";
            // 
            // StoreitemLabel
            // 
            this.StoreitemLabel.AutoSize = true;
            this.StoreitemLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StoreitemLabel.ForeColor = System.Drawing.Color.Black;
            this.StoreitemLabel.Location = new System.Drawing.Point(604, 85);
            this.StoreitemLabel.Name = "StoreitemLabel";
            this.StoreitemLabel.Size = new System.Drawing.Size(110, 25);
            this.StoreitemLabel.TabIndex = 4;
            this.StoreitemLabel.Text = "Store Items";
            // 
            // ShoppingCartListBox
            // 
            this.ShoppingCartListBox.FormattingEnabled = true;
            this.ShoppingCartListBox.ItemHeight = 15;
            this.ShoppingCartListBox.Location = new System.Drawing.Point(604, 113);
            this.ShoppingCartListBox.Name = "ShoppingCartListBox";
            this.ShoppingCartListBox.Size = new System.Drawing.Size(286, 259);
            this.ShoppingCartListBox.TabIndex = 3;
            this.ShoppingCartListBox.SelectedIndexChanged += new System.EventHandler(this.ShoppingCartListBox_SelectedIndexChanged);
            // 
            // AddtoCartButton
            // 
            this.AddtoCartButton.BackColor = System.Drawing.Color.Transparent;
            this.AddtoCartButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddtoCartButton.ForeColor = System.Drawing.Color.Maroon;
            this.AddtoCartButton.Location = new System.Drawing.Point(399, 208);
            this.AddtoCartButton.Name = "AddtoCartButton";
            this.AddtoCartButton.Size = new System.Drawing.Size(129, 49);
            this.AddtoCartButton.TabIndex = 5;
            this.AddtoCartButton.Text = "AddtoCart =>";
            this.AddtoCartButton.UseVisualStyleBackColor = false;
            this.AddtoCartButton.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PurchaseButton.ForeColor = System.Drawing.Color.Firebrick;
            this.PurchaseButton.Location = new System.Drawing.Point(794, 378);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(96, 38);
            this.PurchaseButton.TabIndex = 6;
            this.PurchaseButton.Text = "Purchase";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // VendorLabel
            // 
            this.VendorLabel.AutoSize = true;
            this.VendorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VendorLabel.ForeColor = System.Drawing.Color.Black;
            this.VendorLabel.Location = new System.Drawing.Point(30, 427);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(110, 25);
            this.VendorLabel.TabIndex = 8;
            this.VendorLabel.Text = "Store Items";
            // 
            // VendorList
            // 
            this.VendorList.BackColor = System.Drawing.SystemColors.Info;
            this.VendorList.FormattingEnabled = true;
            this.VendorList.ItemHeight = 15;
            this.VendorList.Location = new System.Drawing.Point(30, 455);
            this.VendorList.Name = "VendorList";
            this.VendorList.Size = new System.Drawing.Size(286, 259);
            this.VendorList.TabIndex = 7;
            // 
            // StoreProfitlabel
            // 
            this.StoreProfitlabel.AutoSize = true;
            this.StoreProfitlabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.StoreProfitlabel.ForeColor = System.Drawing.Color.Black;
            this.StoreProfitlabel.Location = new System.Drawing.Point(568, 440);
            this.StoreProfitlabel.Name = "StoreProfitlabel";
            this.StoreProfitlabel.Size = new System.Drawing.Size(109, 25);
            this.StoreProfitlabel.TabIndex = 9;
            this.StoreProfitlabel.Text = "Store Profit";
            // 
            // store_profit_value
            // 
            this.store_profit_value.AutoSize = true;
            this.store_profit_value.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.store_profit_value.ForeColor = System.Drawing.Color.Black;
            this.store_profit_value.Location = new System.Drawing.Point(701, 440);
            this.store_profit_value.Name = "store_profit_value";
            this.store_profit_value.Size = new System.Drawing.Size(61, 25);
            this.store_profit_value.TabIndex = 10;
            this.store_profit_value.Text = "0.00$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(929, 739);
            this.Controls.Add(this.store_profit_value);
            this.Controls.Add(this.StoreProfitlabel);
            this.Controls.Add(this.VendorLabel);
            this.Controls.Add(this.VendorList);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.AddtoCartButton);
            this.Controls.Add(this.StoreitemLabel);
            this.Controls.Add(this.ShoppingCartListBox);
            this.Controls.Add(this.Store_item_label);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label Store_item_label;
        private System.Windows.Forms.Label StoreitemLabel;
        private System.Windows.Forms.ListBox ShoppingCartListBox;
        private System.Windows.Forms.Button AddtoCartButton;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.ListBox VendorList;
        private System.Windows.Forms.Label StoreProfitlabel;
        private System.Windows.Forms.Label store_profit_value;
    }
}

