using System.Text.RegularExpressions;
using System.Collections;
using System.ComponentModel;


namespace InventoryProgram_C968
{
    public partial class AddModProduct : Form
    {
        private string mode = "";

        public static BindingSource addPartsBindingSource = new BindingSource();
        public static BindingSource currentPartsBindingSource = new BindingSource();
        public static BindingList<Part> partsToAddBindingList = new BindingList<Part>();
        Product product;
        public AddModProduct()
        {
            partsToAddBindingList = new BindingList<Part>();
            InitializeComponent();
            lbl_title.Text = "Add Product";
            Text = "Add Product";
            RefreshDataGrids();
            mode = "add";
            input_id.Text = Inventory.next_product_id.ToString();
            SetupDGV();
        }

        public AddModProduct(Product _product)
        {
            partsToAddBindingList = new BindingList<Part>();
            InitializeComponent();
            product = _product;
            mode = "mod";
            lbl_title.Text = "Modify Product";
            Text = "Modify Product";
            LoadProduct(_product);
            SetupDGV();
            RefreshDataGrids();
        }

        public void LoadProduct(Product _product)
        {
            input_id.Text = _product.ProductID.ToString();
            input_name.Text = _product.Name.ToString();
            input_inventory.Text = _product.InStock.ToString();
            input_price.Text = _product.Price.ToString();
            input_min.Text = _product.Min.ToString();
            input_max.Text = _product.Max.ToString();
            foreach (Part part in _product.AssociatedParts)
            {
                partsToAddBindingList.Add(part);
            }
        }

        public void SetupDGV()
        {
            addPartsDataGridView.RowHeadersVisible = false;
            currentPartsDataGridView.RowHeadersVisible = false;
        }

        public void RefreshDataGrids()
        {
            addPartsBindingSource.ResetBindings(false);
            addPartsBindingSource.DataSource = Inventory.AllParts;
            addPartsDataGridView.DataSource = addPartsBindingSource;

            currentPartsBindingSource.ResetBindings(false);
            currentPartsBindingSource.DataSource = partsToAddBindingList;
            currentPartsDataGridView.DataSource = currentPartsBindingSource;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Get row
            DataGridViewRow row = addPartsDataGridView.SelectedRows[0];
            // Get part id
            int index = Convert.ToInt32(row.Cells["PartID"].Value);
            // Look up part
            Part part = Inventory.lookupPart(index);
            partsToAddBindingList.Add(part);
            RefreshDataGrids();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Get row
            if (currentPartsDataGridView.SelectedRows.Count <= 0)
            {
                return;
            }
            DataGridViewRow row = currentPartsDataGridView.SelectedRows[0];
            // Get part id
            int index = Convert.ToInt32(row.Cells["PartID"].Value);
            // Look up part
            Part part = Inventory.lookupPart(index);
            partsToAddBindingList.Remove(part);
            RefreshDataGrids();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ArrayList partsList = new ArrayList();
            string name = input_name.Text;
            double price = Convert.ToDouble(input_price.Text);
            int in_stock = Convert.ToInt32(input_inventory.Text);
            int min = Convert.ToInt32(input_min.Text);
            int max = Convert.ToInt32(input_max.Text);

            if (min > max)
            {
                MessageBox.Show("Min can not be greater than max");
                input_min.Focus();
                return;
            }

            if (in_stock < min || in_stock > max)
            {
                MessageBox.Show($"Inventory count must be within {min} - {max}");
                input_inventory.Focus();
                return;
            }

            foreach (Part part in partsToAddBindingList)
            {
                partsList.Add(part);
            }

            if (mode == "add")
            {
                Inventory.addProduct(new Product( name, price, in_stock, min, max, partsList ));
                Close();
            }
            else if (mode == "mod")
            {
                Product modified_product;
                int productID = Convert.ToInt32(input_id.Text);
                modified_product = new Product( productID, name, price, in_stock, min, max, partsList);
                Inventory.UpdateProduct(productID, modified_product);
                Close();
            }

            
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            int searchID = 0;
            bool searchFound = false;

            try
            {
                searchID = Convert.ToInt32(input_search.Text);
            }
            catch
            {
                MessageBox.Show("Must be a integer (0, 1, 2, etc.)");
                input_search.Clear();
                input_search.Focus();
                return;
            }

            foreach (DataGridViewRow dataGridViewRow in addPartsDataGridView.Rows)
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
                input_search.Clear();
                input_search.Focus();
            }
        }

        // Validation
        private void num_validate(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (Regex.IsMatch(textBox.Text, "[0-9]"))
            {

                textBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                textBox.BackColor = Color.Red;
            }
        }

        private void string_validate(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (Regex.IsMatch(textBox.Text, "[a-z]|[A-Z]|/s"))
            {

                textBox.BackColor = Color.White;
            }
            else
            {
                e.Cancel = true;
                textBox.BackColor = Color.Red;
            }
        }

    }
}
