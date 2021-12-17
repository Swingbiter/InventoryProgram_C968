using System.Collections;


namespace InventoryProgram_C968
{
    public partial class Main : Form
    {
        public static BindingSource partsBindingSource = new BindingSource();
        public static BindingSource productBindingSource = new BindingSource();
        public Main()
        {
            InitializeComponent();
        }

        public void AddFakeData()
        {
            Inventory.addPart(new Inhouse("Red Frame", 12.5, 3, 1, 20, 1));
            Inventory.addPart(new Inhouse("Green Frame", 18.5, 4, 3, 25, 2));
            Inventory.addPart(new Inhouse("Blue Frame", 15.7, 4, 5, 22, 3));
            Inventory.addPart(new Inhouse("Seat", 5.5, 4, 4, 4, 4));
            Inventory.addPart(new Outsourced("Wheel", 6.52, 12, 4, 4, "Davie's Wheelhouse"));
            Inventory.addPart(new Outsourced("Chain", 1.25, 36, 4, 4, "Chains Hang Low"));
            Inventory.addPart(new Outsourced("Handlebars", 3.25, 36, 4, 4, "bars Bars BARS"));
            Inventory.addPart(new Outsourced("Tassles", 3.25, 36, 4, 4, "Pure Unadulterated Blissporium"));
            Inventory.addPart(new Outsourced("Flame Decals", 3.25, 36, 4, 4, "More Horsepower Ltd."));
            Inventory.addPart(new Outsourced("Card Clacker", 3.25, 36, 4, 4, "BEST COMPANY"));
            Inventory.addPart(new Outsourced("Bike Horn", 3.25, 36, 4, 4, "HONKS R US"));


            Inventory.addProduct(new Product("Red Bike", 100.00, 37, 0, 100, new ArrayList()));
            Inventory.addProduct(new Product("Green Bike", 135.00, 67, 0, 100, new ArrayList()));
            Inventory.addProduct(new Product("Blue Bike", 125.00, 15, 1, 25, new ArrayList()));


            // red bike add parts
            Product red_bike = Inventory.lookupProduct(0);
            red_bike.addAssociatedPart(Inventory.lookupPart(0));
            red_bike.addAssociatedPart(Inventory.lookupPart(3));
            red_bike.addAssociatedPart(Inventory.lookupPart(4));
            red_bike.addAssociatedPart(Inventory.lookupPart(5));
            red_bike.addAssociatedPart(Inventory.lookupPart(6));
            red_bike.addAssociatedPart(Inventory.lookupPart(8));
            red_bike.addAssociatedPart(Inventory.lookupPart(10));

            // green bike add parts
            Product green_bike = Inventory.lookupProduct(1);
            green_bike.addAssociatedPart(Inventory.lookupPart(1));
            green_bike.addAssociatedPart(Inventory.lookupPart(3));
            green_bike.addAssociatedPart(Inventory.lookupPart(4));
            green_bike.addAssociatedPart(Inventory.lookupPart(5));
            green_bike.addAssociatedPart(Inventory.lookupPart(6));
            green_bike.addAssociatedPart(Inventory.lookupPart(9));
            green_bike.addAssociatedPart(Inventory.lookupPart(10));

            // blue bike add parts
            Product blue_bike = Inventory.lookupProduct(2);
            blue_bike.addAssociatedPart(Inventory.lookupPart(2));
            blue_bike.addAssociatedPart(Inventory.lookupPart(3));
            blue_bike.addAssociatedPart(Inventory.lookupPart(4));
            blue_bike.addAssociatedPart(Inventory.lookupPart(5));
            blue_bike.addAssociatedPart(Inventory.lookupPart(6));
            blue_bike.addAssociatedPart(Inventory.lookupPart(7));
            blue_bike.addAssociatedPart(Inventory.lookupPart(10));

        }

        private void RefreshDataGrids()
        {
            partsBindingSource.ResetBindings(false);
            productBindingSource.ResetBindings(false);
            partsBindingSource.DataSource = Inventory.AllParts;
            productBindingSource.DataSource = Inventory.Products;
            partsDataGridView.DataSource = partsBindingSource;
            productDataGridView.DataSource = productBindingSource;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AddFakeData();
            RefreshDataGrids();

            // Parts
            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.Columns["Price"].DefaultCellStyle.Format = "c";
            partsDataGridView.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            partsDataGridView.RowHeadersVisible = false;

            //Product
            productDataGridView.Columns["ProductID"].HeaderText = "Product ID";
            productDataGridView.Columns["Price"].DefaultCellStyle.Format = "c";
            productDataGridView.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            productDataGridView.RowHeadersVisible = false;
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            RefreshDataGrids();
        }

        // Exit
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Part Buttons
        private void btn_add_part_Click(object sender, EventArgs e)
        {
            AddModPart addPart = new AddModPart()
            {
                MdiParent = this.MdiParent
            };
            addPart.Show();
        }

        private void btn_mod_part_Click(object sender, EventArgs e)
        {
            // Get row
            DataGridViewRow row = partsDataGridView.SelectedRows[0];
            // Get part id
            int index = Convert.ToInt32(row.Cells["PartID"].Value);
            // Look up part
            Part part = Inventory.lookupPart(index);
            // instance form
            AddModPart addPart = new AddModPart(part)
            {
                MdiParent = this.MdiParent
            };
            addPart.Show();
        }

        private void btn_remove_part_Click(object sender, EventArgs e)
        {
            // Get row
            DataGridViewRow row = partsDataGridView.SelectedRows[0];
            // Get part id
            int index = Convert.ToInt32(row.Cells["PartID"].Value);
            // Look up part
            Part part = Inventory.lookupPart(index);
            // Delete part
            Inventory.removePart(part);
            RefreshDataGrids();
        }
        
        

        private void btn_search_parts_Click(object sender, EventArgs e)
        {
            int searchID = 0;
            bool searchFound = false;

            // get and validate search id
            try
            {
                searchID = Convert.ToInt32(searchbox_parts.Text);

            }
            catch
            {
                MessageBox.Show("Must be a integer (0, 1, 2, etc.)");
                searchbox_parts.Clear();
                searchbox_parts.Focus();
                return;
            }

            foreach (DataGridViewRow dataGridViewRow in partsDataGridView.Rows)
            {
                Part part = (Part)dataGridViewRow.DataBoundItem;
                // if part found select that row
                if (part.PartID == searchID)
                {
                    dataGridViewRow.Selected = true;
                    searchFound = true;
                    break;
                }
            }

            if (!searchFound)
            {
                MessageBox.Show("Part not found");
                searchbox_parts.Clear();
                searchbox_parts.Focus();
            }
        }

        // Product
        private void btn_add_product_Click(object sender, EventArgs e)
        {
            AddModProduct addProduct = new AddModProduct()
            {
                MdiParent = this.MdiParent
            };
            addProduct.Show();
        }

        private void btn_mod_product_Click(object sender, EventArgs e)
        {
            // Get row
            DataGridViewRow row = productDataGridView.SelectedRows[0];
            // Get part id
            int index = Convert.ToInt32(row.Cells["ProductID"].Value);
            // Look up part
            Product product = Inventory.lookupProduct(index);
            // instance form
            AddModProduct addProduct = new AddModProduct(product)
            {
                MdiParent = this.MdiParent
            };
            addProduct.Show();
        }

        private void btn_remove_product_Click(object sender, EventArgs e)
        {
            // Get row
            DataGridViewRow row = productDataGridView.SelectedRows[0];
            // Get part id
            int index = Convert.ToInt32(row.Cells["ProductID"].Value);
            // Look up part
            Product product = Inventory.lookupProduct(index);
            // Delete part
            Inventory.removeProduct(index);
            RefreshDataGrids();
        }

        private void btn_search_product_Click(object sender, EventArgs e)
        {
            int searchID = 0;
            bool searchFound = false;

            // get and validate search id
            try
            {
                searchID = Convert.ToInt32(searchbox_product.Text);

            }
            catch
            {
                MessageBox.Show("Must be a integer (0, 1, 2, etc.)");
                searchbox_product.Clear();
                searchbox_product.Focus();
                return;
            }

            foreach (DataGridViewRow dataGridViewRow in productDataGridView.Rows)
            {
                Product product = (Product)dataGridViewRow.DataBoundItem;
                // if part found select that row
                if (product.ProductID == searchID)
                {
                    dataGridViewRow.Selected = true;
                    searchFound = true;
                    break;
                }
            }

            if (!searchFound)
            {
                MessageBox.Show("Product not found");
                searchbox_product.Clear();
                searchbox_product.Focus();
            }
        }
    }
}