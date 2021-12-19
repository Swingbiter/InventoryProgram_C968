namespace InventoryProgram_C968
{
    partial class Main
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
            this.PartsGroupBox = new System.Windows.Forms.GroupBox();
            this.btn_add_part = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchbox_parts = new System.Windows.Forms.TextBox();
            this.btn_search_parts = new System.Windows.Forms.Button();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.searchbox_product = new System.Windows.Forms.TextBox();
            this.btn_search_product = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.PartsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsGroupBox
            // 
            this.PartsGroupBox.Controls.Add(this.btn_add_part);
            this.PartsGroupBox.Controls.Add(this.button3);
            this.PartsGroupBox.Controls.Add(this.button2);
            this.PartsGroupBox.Controls.Add(this.searchbox_parts);
            this.PartsGroupBox.Controls.Add(this.btn_search_parts);
            this.PartsGroupBox.Controls.Add(this.partsDataGridView);
            this.PartsGroupBox.Location = new System.Drawing.Point(10, 37);
            this.PartsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PartsGroupBox.Name = "PartsGroupBox";
            this.PartsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PartsGroupBox.Size = new System.Drawing.Size(422, 276);
            this.PartsGroupBox.TabIndex = 1;
            this.PartsGroupBox.TabStop = false;
            this.PartsGroupBox.Text = "Parts";
            // 
            // btn_add_part
            // 
            this.btn_add_part.Location = new System.Drawing.Point(159, 244);
            this.btn_add_part.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_part.Name = "btn_add_part";
            this.btn_add_part.Size = new System.Drawing.Size(82, 22);
            this.btn_add_part.TabIndex = 5;
            this.btn_add_part.Text = "Add";
            this.btn_add_part.UseVisualStyleBackColor = true;
            this.btn_add_part.Click += new System.EventHandler(this.btn_add_part_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 244);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_mod_part_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 244);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_remove_part_Click);
            // 
            // searchbox_parts
            // 
            this.searchbox_parts.Location = new System.Drawing.Point(210, 20);
            this.searchbox_parts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbox_parts.Name = "searchbox_parts";
            this.searchbox_parts.Size = new System.Drawing.Size(120, 23);
            this.searchbox_parts.TabIndex = 2;
            // 
            // btn_search_parts
            // 
            this.btn_search_parts.Location = new System.Drawing.Point(334, 20);
            this.btn_search_parts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_parts.Name = "btn_search_parts";
            this.btn_search_parts.Size = new System.Drawing.Size(82, 22);
            this.btn_search_parts.TabIndex = 1;
            this.btn_search_parts.Text = "Search";
            this.btn_search_parts.UseVisualStyleBackColor = true;
            this.btn_search_parts.Click += new System.EventHandler(this.btn_search_parts_Click);
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToResizeRows = false;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsDataGridView.Location = new System.Drawing.Point(5, 46);
            this.partsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partsDataGridView.MultiSelect = false;
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.RowHeadersWidth = 51;
            this.partsDataGridView.RowTemplate.Height = 29;
            this.partsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsDataGridView.Size = new System.Drawing.Size(411, 194);
            this.partsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventory Management System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.searchbox_product);
            this.groupBox2.Controls.Add(this.btn_search_product);
            this.groupBox2.Controls.Add(this.productDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(438, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(422, 276);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(159, 244);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 22);
            this.button5.TabIndex = 5;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(247, 244);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 22);
            this.button6.TabIndex = 4;
            this.button6.Text = "Modify";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn_mod_product_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(334, 244);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 22);
            this.button7.TabIndex = 3;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn_remove_product_Click);
            // 
            // searchbox_product
            // 
            this.searchbox_product.Location = new System.Drawing.Point(210, 20);
            this.searchbox_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchbox_product.Name = "searchbox_product";
            this.searchbox_product.Size = new System.Drawing.Size(120, 23);
            this.searchbox_product.TabIndex = 2;
            // 
            // btn_search_product
            // 
            this.btn_search_product.Location = new System.Drawing.Point(334, 20);
            this.btn_search_product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search_product.Name = "btn_search_product";
            this.btn_search_product.Size = new System.Drawing.Size(82, 22);
            this.btn_search_product.TabIndex = 1;
            this.btn_search_product.Text = "Search";
            this.btn_search_product.UseVisualStyleBackColor = true;
            this.btn_search_product.Click += new System.EventHandler(this.btn_search_product_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productDataGridView.Location = new System.Drawing.Point(5, 46);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 29;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(411, 194);
            this.productDataGridView.TabIndex = 0;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(772, 317);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(82, 22);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 350);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PartsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "C968 Inventory App";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Enter += new System.EventHandler(this.Main_Activated);
            this.PartsGroupBox.ResumeLayout(false);
            this.PartsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView partsDataGridView;
        private GroupBox PartsGroupBox;
        private Label label1;
        private Button btn_add_part;
        private Button button3;
        private Button button2;
        private TextBox searchbox_parts;
        private Button btn_search_parts;
        private GroupBox groupBox2;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox searchbox_product;
        private Button btn_search_product;
        private DataGridView productDataGridView;
        private Button btn_Exit;
    }
}