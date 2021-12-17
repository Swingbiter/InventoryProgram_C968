using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProgram_C968
{
    public partial class Form1 : Form
    {
        public static BindingSource partsBindingSource = new BindingSource();
        public static BindingList<Part> partsBindingList = new BindingList<Part>();
        public static List<Part> partsList = new List<Part>();
        public Form1()
        {
            InitializeComponent();
        }

        public void AddFakeData()
        {
            Inventory.addPart(new Inhouse("Frame", 1.5, 4, 4, 4, 4));
            Inventory.addPart(new Inhouse("Seat", 1.5, 4, 4, 4, 4));
            Inventory.addPart(new Outsourced("Wheel", 1.5, 4, 4, 4, "Davie's Wheelhouse"));
            Inventory.addPart(new Outsourced("Chain", 1.5, 4, 4, 4, "Chains Hang Low"));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            AddFakeData();
            partsDataGridView.DataSource = Inventory.AllParts;
            productDataGridView.DataSource = Inventory.Products;


            partsDataGridView.Columns["Price"].DefaultCellStyle.Format = "c";
            partsDataGridView.Columns["Price"].HeaderText = "Price/Cost Per Unit";
            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.RowHeadersVisible = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddModPart addPart = new AddModPart()
            {
                MdiParent = this.MdiParent
            };
            addPart.Show();
        }
    }
}