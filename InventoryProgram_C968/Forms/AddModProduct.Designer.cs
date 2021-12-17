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
            this.input_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
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
            this.lbl_title.Location = new System.Drawing.Point(14, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(186, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add/Mod Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // input_id
            // 
            this.input_id.Enabled = false;
            this.input_id.Location = new System.Drawing.Point(86, 56);
            this.input_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_id.Name = "input_id";
            this.input_id.ReadOnly = true;
            this.input_id.Size = new System.Drawing.Size(114, 27);
            this.input_id.TabIndex = 2;
            this.input_id.Text = "AUTO_ID";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(86, 95);
            this.input_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(114, 27);
            this.input_name.TabIndex = 4;
            this.input_name.Validating += new System.ComponentModel.CancelEventHandler(this.string_validate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // input_inventory
            // 
            this.input_inventory.Location = new System.Drawing.Point(86, 133);
            this.input_inventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_inventory.Name = "input_inventory";
            this.input_inventory.Size = new System.Drawing.Size(114, 27);
            this.input_inventory.TabIndex = 6;
            this.input_inventory.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory";
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(86, 172);
            this.input_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(114, 27);
            this.input_price.TabIndex = 8;
            this.input_price.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // input_min
            // 
            this.input_min.Location = new System.Drawing.Point(86, 211);
            this.input_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_min.Name = "input_min";
            this.input_min.Size = new System.Drawing.Size(114, 27);
            this.input_min.TabIndex = 10;
            this.input_min.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Min";
            // 
            // input_max
            // 
            this.input_max.Location = new System.Drawing.Point(86, 249);
            this.input_max.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_max.Name = "input_max";
            this.input_max.Size = new System.Drawing.Size(114, 27);
            this.input_max.TabIndex = 12;
            this.input_max.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Max";
            // 
            // addPartsDataGridView
            // 
            this.addPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.addPartsDataGridView.Location = new System.Drawing.Point(207, 56);
            this.addPartsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPartsDataGridView.MultiSelect = false;
            this.addPartsDataGridView.Name = "addPartsDataGridView";
            this.addPartsDataGridView.RowHeadersWidth = 51;
            this.addPartsDataGridView.RowTemplate.Height = 25;
            this.addPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addPartsDataGridView.Size = new System.Drawing.Size(400, 224);
            this.addPartsDataGridView.TabIndex = 13;
            // 
            // input_search
            // 
            this.input_search.Location = new System.Drawing.Point(493, 17);
            this.input_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_search.Name = "input_search";
            this.input_search.Size = new System.Drawing.Size(114, 27);
            this.input_search.TabIndex = 15;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(400, 16);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 31);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // currentPartsDataGridView
            // 
            this.currentPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentPartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.currentPartsDataGridView.Location = new System.Drawing.Point(207, 327);
            this.currentPartsDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currentPartsDataGridView.MultiSelect = false;
            this.currentPartsDataGridView.Name = "currentPartsDataGridView";
            this.currentPartsDataGridView.RowHeadersWidth = 51;
            this.currentPartsDataGridView.RowTemplate.Height = 25;
            this.currentPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentPartsDataGridView.Size = new System.Drawing.Size(400, 224);
            this.currentPartsDataGridView.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 559);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 520);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 20;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(106, 520);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 31);
            this.button5.TabIndex = 21;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // AddModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 600);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.currentPartsDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.input_search);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private TextBox input_search;
        private Button btn_search;
        private Button button2;
        private DataGridView currentPartsDataGridView;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}