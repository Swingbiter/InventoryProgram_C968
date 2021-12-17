namespace InventoryProgram_C968
{
    partial class AddModPart
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
            this.input_inventory = new System.Windows.Forms.TextBox();
            this.input_price = new System.Windows.Forms.TextBox();
            this.input_min = new System.Windows.Forms.TextBox();
            this.input_max = new System.Windows.Forms.TextBox();
            this.input_source = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_source = new System.Windows.Forms.Label();
            this.rad_btn_in_house = new System.Windows.Forms.RadioButton();
            this.rad_btn_outsourced = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(11, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(214, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add/Modify Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // input_id
            // 
            this.input_id.Enabled = false;
            this.input_id.Location = new System.Drawing.Point(134, 79);
            this.input_id.Name = "input_id";
            this.input_id.ReadOnly = true;
            this.input_id.Size = new System.Drawing.Size(125, 27);
            this.input_id.TabIndex = 2;
            this.input_id.Text = "AUTO_ID";
            // 
            // input_name
            // 
            this.input_name.Location = new System.Drawing.Point(134, 112);
            this.input_name.Name = "input_name";
            this.input_name.Size = new System.Drawing.Size(125, 27);
            this.input_name.TabIndex = 3;
            this.input_name.Validating += new System.ComponentModel.CancelEventHandler(this.string_validate);
            // 
            // input_inventory
            // 
            this.input_inventory.Location = new System.Drawing.Point(134, 145);
            this.input_inventory.Name = "input_inventory";
            this.input_inventory.Size = new System.Drawing.Size(125, 27);
            this.input_inventory.TabIndex = 4;
            this.input_inventory.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // input_price
            // 
            this.input_price.Location = new System.Drawing.Point(134, 179);
            this.input_price.Name = "input_price";
            this.input_price.Size = new System.Drawing.Size(125, 27);
            this.input_price.TabIndex = 5;
            this.input_price.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // input_min
            // 
            this.input_min.Location = new System.Drawing.Point(134, 211);
            this.input_min.Name = "input_min";
            this.input_min.Size = new System.Drawing.Size(125, 27);
            this.input_min.TabIndex = 6;
            this.input_min.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // input_max
            // 
            this.input_max.Location = new System.Drawing.Point(134, 244);
            this.input_max.Name = "input_max";
            this.input_max.Size = new System.Drawing.Size(125, 27);
            this.input_max.TabIndex = 7;
            this.input_max.Validating += new System.ComponentModel.CancelEventHandler(this.num_validate);
            // 
            // input_source
            // 
            this.input_source.Location = new System.Drawing.Point(134, 277);
            this.input_source.Name = "input_source";
            this.input_source.Size = new System.Drawing.Size(125, 27);
            this.input_source.TabIndex = 8;
            this.input_source.Validating += new System.ComponentModel.CancelEventHandler(this.source_validate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price/Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max";
            // 
            // lbl_source
            // 
            this.lbl_source.AutoSize = true;
            this.lbl_source.Location = new System.Drawing.Point(11, 284);
            this.lbl_source.Name = "lbl_source";
            this.lbl_source.Size = new System.Drawing.Size(84, 20);
            this.lbl_source.TabIndex = 14;
            this.lbl_source.Text = "Machine ID";
            // 
            // rad_btn_in_house
            // 
            this.rad_btn_in_house.AutoSize = true;
            this.rad_btn_in_house.Checked = true;
            this.rad_btn_in_house.Location = new System.Drawing.Point(3, 3);
            this.rad_btn_in_house.Name = "rad_btn_in_house";
            this.rad_btn_in_house.Size = new System.Drawing.Size(88, 24);
            this.rad_btn_in_house.TabIndex = 15;
            this.rad_btn_in_house.TabStop = true;
            this.rad_btn_in_house.Text = "In House";
            this.rad_btn_in_house.UseVisualStyleBackColor = true;
            this.rad_btn_in_house.Click += new System.EventHandler(this.radio_in_house);
            // 
            // rad_btn_outsourced
            // 
            this.rad_btn_outsourced.AutoSize = true;
            this.rad_btn_outsourced.Location = new System.Drawing.Point(97, 3);
            this.rad_btn_outsourced.Name = "rad_btn_outsourced";
            this.rad_btn_outsourced.Size = new System.Drawing.Size(106, 24);
            this.rad_btn_outsourced.TabIndex = 16;
            this.rad_btn_outsourced.Text = "Outsourced";
            this.rad_btn_outsourced.UseVisualStyleBackColor = true;
            this.rad_btn_outsourced.Click += new System.EventHandler(this.radio_outsourced);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rad_btn_in_house);
            this.panel1.Controls.Add(this.rad_btn_outsourced);
            this.panel1.Location = new System.Drawing.Point(11, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 29);
            this.panel1.TabIndex = 17;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(89, 315);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 31);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(182, 315);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 31);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "C&ancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddModPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 357);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_source);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_source);
            this.Controls.Add(this.input_max);
            this.Controls.Add(this.input_min);
            this.Controls.Add(this.input_price);
            this.Controls.Add(this.input_inventory);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_title);
            this.Name = "AddModPart";
            this.Text = "Add Part";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Label label1;
        private TextBox input_id;
        private TextBox input_name;
        private TextBox input_inventory;
        private TextBox input_price;
        private TextBox input_min;
        private TextBox input_max;
        private TextBox input_source;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbl_source;
        private RadioButton rad_btn_in_house;
        private RadioButton rad_btn_outsourced;
        private Panel panel1;
        private Button btn_save;
        private Button btn_cancel;
    }
}