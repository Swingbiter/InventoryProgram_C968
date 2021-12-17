namespace InventoryProgram_C968
{
    partial class AddModProduct
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.input_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.input_inventory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.input_min = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.input_max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.currentPartsDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addPartsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(151, 30);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add/Mod Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // input_id
            // 
            this.input_id.Enabled = false;
            this.input_id.Location = new System.Drawing.Point(75, 42);
            this.input_id.Name = "input_id";
            this.input_id.ReadOnly = true;
            this.input_id.Size = new System.Drawing.Size(100, 23);
            this.input_id.TabIndex = 2;
            this.input_id.Text = "AUTO_ID";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(75, 71);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(100, 23);
            this.input_name.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // input_inventory
            // 
            this.input_inventory.Location = new System.Drawing.Point(75, 100);
            this.input_inventory.Name = "input_inventory";
            this.input_inventory.Size = new System.Drawing.Size(100, 23);
            this.input_inventory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory";
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(75, 129);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(100, 23);
            this.input_price.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // input_min
            // 
            this.input_min.Location = new System.Drawing.Point(75, 158);
            this.input_min.Name = "input_min";
            this.input_min.Size = new System.Drawing.Size(100, 23);
            this.input_min.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min";
            // 
            // input_max
            // 
            this.input_max.Location = new System.Drawing.Point(75, 187);
            this.input_max.Name = "input_max";
            this.input_max.Size = new System.Drawing.Size(100, 23);
            this.input_max.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max";
            // 
            // addPartsDataGridView
            // 
            this.addPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addPartsDataGridView.Location = new System.Drawing.Point(181, 42);
            this.addPartsDataGridView.MultiSelect = false;
            this.addPartsDataGridView.Name = "addPartsDataGridView";
            this.addPartsDataGridView.RowTemplate.Height = 25;
            this.addPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addPartsDataGridView.Size = new System.Drawing.Size(350, 168);
            this.addPartsDataGridView.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(431, 13);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 23);
            this.textBox7.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // currentPartsDataGridView
            // 
            this.currentPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentPartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.currentPartsDataGridView.Location = new System.Drawing.Point(181, 245);
            this.currentPartsDataGridView.MultiSelect = false;
            this.currentPartsDataGridView.Name = "currentPartsDataGridView";
            this.currentPartsDataGridView.RowTemplate.Height = 25;
            this.currentPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentPartsDataGridView.Size = new System.Drawing.Size(350, 168);
            this.currentPartsDataGridView.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 419);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(93, 390);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // AddModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.currentPartsDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.addPartsDataGridView);
            this.Controls.Add(this.input_max);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.input_min);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_inventory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Name = "AddModProduct";
            this.Text = "Add/Mod Product";
            ((System.ComponentModel.ISupportInitialize)(this.addPartsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Label label1;
        private TextBox input_id;
        private TextBox input_name;
        private Label label2;
        private TextBox input_inventory;
        private Label label3;
        private TextBox input_price;
        private Label label4;
        private TextBox input_min;
        private Label label5;
        private TextBox input_max;
        private Label label6;
        private DataGridView addPartsDataGridView;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private DataGridView currentPartsDataGridView;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}