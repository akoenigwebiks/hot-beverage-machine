namespace hot_beverage_machine
{
    partial class Form1
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
            this.comboboxSugar = new System.Windows.Forms.ComboBox();
            this.comboboxCoffee = new System.Windows.Forms.ComboBox();
            this.comboboxMilk = new System.Windows.Forms.ComboBox();
            this.comboboxCocoa = new System.Windows.Forms.ComboBox();
            this.label_SugarAdd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.button_PriceAdd = new System.Windows.Forms.Button();
            this.button_PriceReduce = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_drinkName = new System.Windows.Forms.TextBox();
            this.button_DrinkAdd = new System.Windows.Forms.Button();
            this.button_saveData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_DrinkUpdate = new System.Windows.Forms.Button();
            this.button_DrinkRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboboxSugar
            // 
            this.comboboxSugar.FormattingEnabled = true;
            this.comboboxSugar.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboboxSugar.Location = new System.Drawing.Point(902, 151);
            this.comboboxSugar.Name = "comboboxSugar";
            this.comboboxSugar.Size = new System.Drawing.Size(121, 24);
            this.comboboxSugar.TabIndex = 0;
            this.comboboxSugar.Text = "1";
            // 
            // comboboxCoffee
            // 
            this.comboboxCoffee.FormattingEnabled = true;
            this.comboboxCoffee.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboboxCoffee.Location = new System.Drawing.Point(775, 151);
            this.comboboxCoffee.Name = "comboboxCoffee";
            this.comboboxCoffee.Size = new System.Drawing.Size(121, 24);
            this.comboboxCoffee.TabIndex = 1;
            this.comboboxCoffee.Text = "1";
            // 
            // comboboxMilk
            // 
            this.comboboxMilk.FormattingEnabled = true;
            this.comboboxMilk.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboboxMilk.Location = new System.Drawing.Point(521, 151);
            this.comboboxMilk.Name = "comboboxMilk";
            this.comboboxMilk.Size = new System.Drawing.Size(121, 24);
            this.comboboxMilk.TabIndex = 2;
            this.comboboxMilk.Text = "1";
            // 
            // comboboxCocoa
            // 
            this.comboboxCocoa.FormattingEnabled = true;
            this.comboboxCocoa.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1",
            "1.5",
            "2",
            "2.5"});
            this.comboboxCocoa.Location = new System.Drawing.Point(648, 151);
            this.comboboxCocoa.Name = "comboboxCocoa";
            this.comboboxCocoa.Size = new System.Drawing.Size(121, 24);
            this.comboboxCocoa.TabIndex = 3;
            this.comboboxCocoa.Text = "1";
            // 
            // label_SugarAdd
            // 
            this.label_SugarAdd.AutoSize = true;
            this.label_SugarAdd.Location = new System.Drawing.Point(945, 123);
            this.label_SugarAdd.Name = "label_SugarAdd";
            this.label_SugarAdd.Size = new System.Drawing.Size(34, 16);
            this.label_SugarAdd.TabIndex = 4;
            this.label_SugarAdd.Text = "סוכר";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "קפה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(689, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "קקאו";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "חלב";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "מחיר";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(432, 151);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(67, 22);
            this.textBox_price.TabIndex = 9;
            // 
            // button_PriceAdd
            // 
            this.button_PriceAdd.BackColor = System.Drawing.Color.Lime;
            this.button_PriceAdd.Location = new System.Drawing.Point(399, 152);
            this.button_PriceAdd.Name = "button_PriceAdd";
            this.button_PriceAdd.Size = new System.Drawing.Size(27, 23);
            this.button_PriceAdd.TabIndex = 10;
            this.button_PriceAdd.Text = "+";
            this.button_PriceAdd.UseVisualStyleBackColor = false;
            // 
            // button_PriceReduce
            // 
            this.button_PriceReduce.BackColor = System.Drawing.Color.Red;
            this.button_PriceReduce.Location = new System.Drawing.Point(366, 152);
            this.button_PriceReduce.Name = "button_PriceReduce";
            this.button_PriceReduce.Size = new System.Drawing.Size(27, 23);
            this.button_PriceReduce.TabIndex = 11;
            this.button_PriceReduce.Text = "-";
            this.button_PriceReduce.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(915, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "שם סוג שתיה חדש";
            // 
            // textBox_drinkName
            // 
            this.textBox_drinkName.Location = new System.Drawing.Point(775, 65);
            this.textBox_drinkName.Name = "textBox_drinkName";
            this.textBox_drinkName.Size = new System.Drawing.Size(121, 22);
            this.textBox_drinkName.TabIndex = 13;
            this.textBox_drinkName.TextChanged += new System.EventHandler(this.textBox_drinkName_TextChanged);
            // 
            // button_DrinkAdd
            // 
            this.button_DrinkAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_DrinkAdd.Location = new System.Drawing.Point(71, 133);
            this.button_DrinkAdd.Name = "button_DrinkAdd";
            this.button_DrinkAdd.Size = new System.Drawing.Size(75, 78);
            this.button_DrinkAdd.TabIndex = 14;
            this.button_DrinkAdd.Text = "הוסף סוג שתיה";
            this.button_DrinkAdd.UseVisualStyleBackColor = false;
            this.button_DrinkAdd.Click += new System.EventHandler(this.button_DrinkAdd_Click);
            // 
            // button_saveData
            // 
            this.button_saveData.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_saveData.Location = new System.Drawing.Point(149, 229);
            this.button_saveData.Name = "button_saveData";
            this.button_saveData.Size = new System.Drawing.Size(107, 78);
            this.button_saveData.TabIndex = 15;
            this.button_saveData.Text = "שמירה";
            this.button_saveData.UseVisualStyleBackColor = false;
            this.button_saveData.Click += new System.EventHandler(this.button_saveData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sugar,
            this.coffee,
            this.cocoa,
            this.milk,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(366, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 191);
            this.dataGridView1.TabIndex = 16;
            // 
            // sugar
            // 
            this.sugar.HeaderText = "סוכר";
            this.sugar.MinimumWidth = 6;
            this.sugar.Name = "sugar";
            this.sugar.ReadOnly = true;
            // 
            // coffee
            // 
            this.coffee.HeaderText = "קפה";
            this.coffee.MinimumWidth = 6;
            this.coffee.Name = "coffee";
            this.coffee.ReadOnly = true;
            // 
            // cocoa
            // 
            this.cocoa.HeaderText = "קקאו";
            this.cocoa.MinimumWidth = 6;
            this.cocoa.Name = "cocoa";
            this.cocoa.ReadOnly = true;
            // 
            // milk
            // 
            this.milk.HeaderText = "חלב";
            this.milk.MinimumWidth = 6;
            this.milk.Name = "milk";
            this.milk.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "מחיר";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // button_DrinkUpdate
            // 
            this.button_DrinkUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_DrinkUpdate.Location = new System.Drawing.Point(162, 133);
            this.button_DrinkUpdate.Name = "button_DrinkUpdate";
            this.button_DrinkUpdate.Size = new System.Drawing.Size(75, 78);
            this.button_DrinkUpdate.TabIndex = 17;
            this.button_DrinkUpdate.Text = "עדכון סוג שתיה";
            this.button_DrinkUpdate.UseVisualStyleBackColor = false;
            this.button_DrinkUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_DrinkRemove
            // 
            this.button_DrinkRemove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_DrinkRemove.Location = new System.Drawing.Point(257, 133);
            this.button_DrinkRemove.Name = "button_DrinkRemove";
            this.button_DrinkRemove.Size = new System.Drawing.Size(75, 78);
            this.button_DrinkRemove.TabIndex = 18;
            this.button_DrinkRemove.Text = "מחיקת סוג שתיה";
            this.button_DrinkRemove.UseVisualStyleBackColor = false;
            this.button_DrinkRemove.Click += new System.EventHandler(this.button_DrinkRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 435);
            this.Controls.Add(this.button_DrinkRemove);
            this.Controls.Add(this.button_DrinkUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_saveData);
            this.Controls.Add(this.button_DrinkAdd);
            this.Controls.Add(this.textBox_drinkName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_PriceReduce);
            this.Controls.Add(this.button_PriceAdd);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_SugarAdd);
            this.Controls.Add(this.comboboxCocoa);
            this.Controls.Add(this.comboboxMilk);
            this.Controls.Add(this.comboboxCoffee);
            this.Controls.Add(this.comboboxSugar);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxSugar;
        private System.Windows.Forms.ComboBox comboboxCoffee;
        private System.Windows.Forms.ComboBox comboboxMilk;
        private System.Windows.Forms.ComboBox comboboxCocoa;
        private System.Windows.Forms.Label label_SugarAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_PriceAdd;
        private System.Windows.Forms.Button button_PriceReduce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_drinkName;
        private System.Windows.Forms.Button button_DrinkAdd;
        private System.Windows.Forms.Button button_saveData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button button_DrinkUpdate;
        private System.Windows.Forms.Button button_DrinkRemove;
    }
}

