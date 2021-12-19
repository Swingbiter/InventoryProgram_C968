using System.Text.RegularExpressions;
using System.ComponentModel;

namespace InventoryProgram_C968
{
    public partial class AddModPart : Form
    {
        private string mode = "";
        private string source_mode = "in-house";

        // Constructors
        public AddModPart() // Empty constructor yields Add Part form
        {
            InitializeComponent();
            Text = "Add New Part";
            lbl_title.Text = "Add New Part";
            mode = "add";
            input_id.Text = Inventory.next_part_id.ToString();
        }

        public AddModPart(Part _part) // Constructor with Part argument yields Mod Part form
        {
            mode = "mod";
            InitializeComponent();
            Text = "Modify Part";
            lbl_title.Text = "Modify Part";
            LoadPart(_part);
        }

        // Load part information into input boxes
        public void LoadPart(Part _part)
        {
            input_id.Text = _part.PartID.ToString();
            input_name.Text = _part.Name.ToString();
            input_inventory.Text = _part.InStock.ToString();
            input_price.Text = _part.Price.ToString();
            input_min.Text = _part.Min.ToString();
            input_max.Text = _part.Max.ToString();
            if (_part is Inhouse)
            {
                input_source.Text = _part.get_machine_id().ToString();
                source_mode = "in-house";
                lbl_source.Text = "Machine ID";
                rad_btn_in_house.Checked = true;
            }
            else if (_part is Outsourced)
            {
                input_source.Text = _part.get_company_name().ToString();
                source_mode = "outsourced";
                lbl_source.Text = "Company Name";
                rad_btn_outsourced.Checked = true;
            }
        }

        // Button Event Handling
        // Radio button handling
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

        // Save / Modify part
        private void btn_save_Click(object sender, EventArgs e)
        {
            string name = input_name.Text;
            double price = Convert.ToDouble(input_price.Text);
            int in_stock = Convert.ToInt32(input_inventory.Text);
            int min = Convert.ToInt32(input_min.Text);
            int max = Convert.ToInt32(input_max.Text);

            // Data validation
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

            if (mode == "add")
            {
                if (source_mode == "in-house") // In-house part creation
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
                else // Outsourced part creation
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

                if (source_mode == "in-house") // In-house part modification
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
                else // Outsource part modification
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


        // Text validation
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

        private void source_validate(object sender, CancelEventArgs e)
        {
            string regex = "";
            if (source_mode == "in-house")
            {
                regex = "[0-9]";
            }
            else
            {
                regex = "[a-z]|[A-Z]|/s";
            }

            TextBox textBox = sender as TextBox;
            if (Regex.IsMatch(textBox.Text, regex))
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

