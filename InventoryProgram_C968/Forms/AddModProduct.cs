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
            InitializeComponent();
            lbl_title.Text = "Add Product";
            Text = "Add Product";
            RefreshDataGrids();
            mode = "add";
            input_id.Text = Inventory.next_product_id.ToString();
        }

        public AddModProduct(Product _product)
        {
            InitializeComponent();
            product = _product;
            mode = "mod";
            lbl_title.Text = "Modify Product";
            Text = "Modify Product";
            LoadProduct(_product);
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
            foreach (Part part in partsToAddBindingList)
            {
                partsList.Add(part);
            }

            if (mode == "add")
            {
                Inventory.addProduct(new Product(
                    input_name.Text,
                    Convert.ToDouble(input_price.Text),
                    Convert.ToInt32(input_inventory.Text),
                    Convert.ToInt32(input_min.Text),
                    Convert.ToInt32(input_max.Text),
                    partsList
                    ));
                Close();
            }
            else if (mode == "mod")
            {
                Product modified_product;
                int productID = Convert.ToInt32(input_id.Text);
                modified_product = new Product(
                    productID,
                    input_name.Text,
                    Convert.ToDouble(input_price.Text),
                    Convert.ToInt32(input_inventory.Text),
                    Convert.ToInt32(input_min.Text),
                    Convert.ToInt32(input_max.Text),
                    partsList
                    );
                Inventory.UpdateProduct(productID, modified_product);
                Close();
            }    
        }
    }
}
