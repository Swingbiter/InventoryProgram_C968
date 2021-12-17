namespace InventoryProgram_C968
{
    public partial class AddModPart : Form
    {
        private string mode = "";
        private string source_mode = "in-house";
        private Part part = null;


        public AddModPart()
        {
            InitializeComponent();
            Text = "Add New Part";
            lbl_title.Text = "Add New Part";
            mode = "add";
            input_id.Text = Inventory.next_part_id.ToString();
        }

        public AddModPart(Part _part)
        {
            this.part = _part;
            mode = "mod";
            InitializeComponent();
            Text = "Modify Part";
            lbl_title.Text = "Modify Part";
            LoadPart(_part);
        }

        public void LoadPart(Part _part)
        {
            input_id.Text = _part.PartID.ToString();
            input_name.Text = _part.Name.ToString();
            input_inventory.Text = _part.InStock.ToString();
            input_price.Text = _part.Price.ToString();
            input_min.Text = _part.Min.ToString();
            input_max.Text = _part.Max.ToString();
            if (part is Inhouse)
            {
                input_source.Text = _part.get_machine_id().ToString();
                source_mode = "in-house";
                lbl_source.Text = "Machine ID";
                rad_btn_in_house.Checked = true;
            }
            else if (part is Outsourced)
            {
                input_source.Text = _part.get_company_name().ToString();
                source_mode = "outsourced";
                lbl_source.Text = "Company Name";
                rad_btn_outsourced.Checked = true;
            }
        }

        private void radio_in_house(object sender, EventArgs e)
        {
            source_mode = "in-house";
            lbl_source.Text = "Machine ID";
        }

        private void radio_outsourced(object sender, EventArgs e)
        {
            source_mode = "outsourced";
            lbl_source.Text = "Company Name";
        }

        // Exit form
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (mode == "add")
            {
                string name = input_name.Text;
                double price = Convert.ToDouble(input_price.Text);
                int in_stock = Convert.ToInt32(input_inventory.Text);
                int min = Convert.ToInt32(input_min.Text);
                int max = Convert.ToInt32(input_max.Text);

                if (source_mode == "in-house")
                {
                    int machine_id = Convert.ToInt32(input_source.Text);
                    Inventory.addPart(new Inhouse(
                        name,
                        price,
                        in_stock,
                        min,
                        max,
                        machine_id));
                }
                else
                {
                    string company_name = input_source.Text;
                    Inventory.addPart(new Outsourced(
                        name,
                        price,
                        in_stock,
                        min,
                        max,
                        company_name
                        ));
                }

                this.Close();
            }
            else if (mode == "mod")
            {
                Part modified_part;
                string name = input_name.Text;
                double price = Convert.ToDouble(input_price.Text);
                int in_stock = Convert.ToInt32(input_inventory.Text);
                int min = Convert.ToInt32(input_min.Text);
                int max = Convert.ToInt32(input_max.Text);

                if (source_mode == "in-house")
                {
                    int machine_id = Convert.ToInt32(input_source.Text);
                    modified_part = new Inhouse(
                        name,
                        price,
                        in_stock,
                        min,
                        max,
                        machine_id);
                }
                else
                {
                    string company_name = input_source.Text;
                    modified_part = new Outsourced(
                        name,
                        price,
                        in_stock,
                        min,
                        max,
                        company_name
                        );
                }
                Inventory.UpdatePart(Convert.ToInt32(input_id.Text), modified_part);
                this.Close();
            }
        }
    }
}
