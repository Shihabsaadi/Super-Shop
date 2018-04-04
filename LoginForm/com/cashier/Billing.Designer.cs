namespace LoginForm {
    partial class Billing {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.sellNoTextBox = new System.Windows.Forms.TextBox();
            this.producIdTextBox = new System.Windows.Forms.TextBox();
            this.productNametextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.discounttextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalAmounttextBox = new System.Windows.Forms.TextBox();
            this.paidAmounttextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.changeAmounttextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.billdataGridView = new System.Windows.Forms.DataGridView();
            this.PRODUCTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInventoryBillForm = new System.Windows.Forms.Button();
            this.buttonLogOutBillForm = new System.Windows.Forms.Button();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.finalamounttextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.quantityremaillabel = new System.Windows.Forms.Label();
            this.productQuantitylabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILL";
            // 
            // sellNoTextBox
            // 
            this.sellNoTextBox.BackColor = System.Drawing.Color.White;
            this.sellNoTextBox.Enabled = false;
            this.sellNoTextBox.Location = new System.Drawing.Point(81, 243);
            this.sellNoTextBox.Name = "sellNoTextBox";
            this.sellNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.sellNoTextBox.TabIndex = 1;
            // 
            // producIdTextBox
            // 
            this.producIdTextBox.Enabled = false;
            this.producIdTextBox.Location = new System.Drawing.Point(266, 243);
            this.producIdTextBox.Name = "producIdTextBox";
            this.producIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.producIdTextBox.TabIndex = 1;
            this.producIdTextBox.TextChanged += new System.EventHandler(this.producIdTextBox_TextChanged);
            // 
            // productNametextBox
            // 
            this.productNametextBox.Enabled = false;
            this.productNametextBox.Location = new System.Drawing.Point(81, 301);
            this.productNametextBox.Name = "productNametextBox";
            this.productNametextBox.Size = new System.Drawing.Size(100, 20);
            this.productNametextBox.TabIndex = 1;
            this.productNametextBox.TextChanged += new System.EventHandler(this.productNametextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(266, 298);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 1;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Enabled = false;
            this.priceTextBox.Location = new System.Drawing.Point(81, 352);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // vatTextBox
            // 
            this.vatTextBox.Enabled = false;
            this.vatTextBox.Location = new System.Drawing.Point(266, 352);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(100, 20);
            this.vatTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(55, 451);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 36);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.BackColor = System.Drawing.Color.Yellow;
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.clearbutton.Location = new System.Drawing.Point(185, 451);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(99, 36);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = false;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Vat%";
            // 
            // discounttextBox
            // 
            this.discounttextBox.Location = new System.Drawing.Point(81, 405);
            this.discounttextBox.Name = "discounttextBox";
            this.discounttextBox.Size = new System.Drawing.Size(100, 20);
            this.discounttextBox.TabIndex = 6;
            this.discounttextBox.TextChanged += new System.EventHandler(this.discounttextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 408);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Discount%";
            // 
            // totalAmounttextBox
            // 
            this.totalAmounttextBox.Enabled = false;
            this.totalAmounttextBox.Location = new System.Drawing.Point(895, 298);
            this.totalAmounttextBox.Name = "totalAmounttextBox";
            this.totalAmounttextBox.Size = new System.Drawing.Size(138, 20);
            this.totalAmounttextBox.TabIndex = 7;
            // 
            // paidAmounttextBox
            // 
            this.paidAmounttextBox.Location = new System.Drawing.Point(895, 334);
            this.paidAmounttextBox.Name = "paidAmounttextBox";
            this.paidAmounttextBox.Size = new System.Drawing.Size(138, 20);
            this.paidAmounttextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(814, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(814, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Amount Paid";
            // 
            // changeAmounttextBox
            // 
            this.changeAmounttextBox.Enabled = false;
            this.changeAmounttextBox.Location = new System.Drawing.Point(895, 368);
            this.changeAmounttextBox.Name = "changeAmounttextBox";
            this.changeAmounttextBox.Size = new System.Drawing.Size(138, 20);
            this.changeAmounttextBox.TabIndex = 7;
            this.changeAmounttextBox.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(814, 375);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Change";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(653, 359);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(117, 39);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.GreenYellow;
            this.totalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalButton.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(653, 302);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(117, 39);
            this.totalButton.TabIndex = 9;
            this.totalButton.Text = "Total Amount";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(653, 409);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(117, 37);
            this.printButton.TabIndex = 9;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // billdataGridView
            // 
            this.billdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCTNAME,
            this.SELLNO,
            this.QUANTITY,
            this.PRICE,
            this.PRODUCTID});
            this.billdataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.billdataGridView.Location = new System.Drawing.Point(490, 71);
            this.billdataGridView.Name = "billdataGridView";
            this.billdataGridView.Size = new System.Drawing.Size(543, 202);
            this.billdataGridView.TabIndex = 10;
            this.billdataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.billdataGridView_RowsRemoved);
            // 
            // PRODUCTNAME
            // 
            this.PRODUCTNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRODUCTNAME.HeaderText = "PRODUCT NAME";
            this.PRODUCTNAME.Name = "PRODUCTNAME";
            // 
            // SELLNO
            // 
            this.SELLNO.HeaderText = "SELL NO";
            this.SELLNO.Name = "SELLNO";
            // 
            // QUANTITY
            // 
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.Name = "PRICE";
            // 
            // PRODUCTID
            // 
            this.PRODUCTID.HeaderText = "PRODUCT ID";
            this.PRODUCTID.Name = "PRODUCTID";
            // 
            // buttonInventoryBillForm
            // 
            this.buttonInventoryBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonInventoryBillForm.FlatAppearance.BorderSize = 0;
            this.buttonInventoryBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryBillForm.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventoryBillForm.ForeColor = System.Drawing.Color.Yellow;
            this.buttonInventoryBillForm.Location = new System.Drawing.Point(820, 12);
            this.buttonInventoryBillForm.Name = "buttonInventoryBillForm";
            this.buttonInventoryBillForm.Size = new System.Drawing.Size(91, 39);
            this.buttonInventoryBillForm.TabIndex = 11;
            this.buttonInventoryBillForm.Text = "Stock";
            this.buttonInventoryBillForm.UseVisualStyleBackColor = false;
            this.buttonInventoryBillForm.Click += new System.EventHandler(this.buttonInventoryBillForm_Click);
            // 
            // buttonLogOutBillForm
            // 
            this.buttonLogOutBillForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonLogOutBillForm.FlatAppearance.BorderSize = 0;
            this.buttonLogOutBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOutBillForm.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOutBillForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogOutBillForm.Location = new System.Drawing.Point(940, 12);
            this.buttonLogOutBillForm.Name = "buttonLogOutBillForm";
            this.buttonLogOutBillForm.Size = new System.Drawing.Size(93, 39);
            this.buttonLogOutBillForm.TabIndex = 11;
            this.buttonLogOutBillForm.Text = "Log Out";
            this.buttonLogOutBillForm.UseVisualStyleBackColor = false;
            this.buttonLogOutBillForm.Click += new System.EventHandler(this.buttonLogOutBillForm_Click);
            // 
            // searchGridView
            // 
            this.searchGridView.BackgroundColor = System.Drawing.Color.White;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Location = new System.Drawing.Point(31, 71);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.Size = new System.Drawing.Size(335, 150);
            this.searchGridView.TabIndex = 12;
            this.searchGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchGridView_CellClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.White;
            this.searchTextBox.Location = new System.Drawing.Point(60, 39);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 13;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Search";
            // 
            // finalamounttextBox
            // 
            this.finalamounttextBox.Location = new System.Drawing.Point(266, 405);
            this.finalamounttextBox.Name = "finalamounttextBox";
            this.finalamounttextBox.Size = new System.Drawing.Size(100, 20);
            this.finalamounttextBox.TabIndex = 15;
            this.finalamounttextBox.TextChanged += new System.EventHandler(this.finalamounttextBox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Location = new System.Drawing.Point(895, 468);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 42);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(13, 26);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 16);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "label14";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(47, -2);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(52, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label13";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Amount";
            // 
            // quantityremaillabel
            // 
            this.quantityremaillabel.AutoSize = true;
            this.quantityremaillabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.quantityremaillabel.Location = new System.Drawing.Point(410, 408);
            this.quantityremaillabel.Name = "quantityremaillabel";
            this.quantityremaillabel.Size = new System.Drawing.Size(43, 13);
            this.quantityremaillabel.TabIndex = 17;
            this.quantityremaillabel.Text = "Remain";
            this.quantityremaillabel.Click += new System.EventHandler(this.quantityremaillabel_Click);
            // 
            // productQuantitylabel
            // 
            this.productQuantitylabel.AutoSize = true;
            this.productQuantitylabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.productQuantitylabel.Location = new System.Drawing.Point(413, 451);
            this.productQuantitylabel.Name = "productQuantitylabel";
            this.productQuantitylabel.Size = new System.Drawing.Size(46, 13);
            this.productQuantitylabel.TabIndex = 18;
            this.productQuantitylabel.Text = "Quantity";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.newLabel.Location = new System.Drawing.Point(416, 482);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(41, 13);
            this.newLabel.TabIndex = 19;
            this.newLabel.Text = "label14";
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.removeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeItemButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.removeItemButton.Location = new System.Drawing.Point(490, 302);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(124, 39);
            this.removeItemButton.TabIndex = 20;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 522);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.productQuantitylabel);
            this.Controls.Add(this.quantityremaillabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.finalamounttextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchGridView);
            this.Controls.Add(this.buttonLogOutBillForm);
            this.Controls.Add(this.buttonInventoryBillForm);
            this.Controls.Add(this.billdataGridView);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.changeAmounttextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.paidAmounttextBox);
            this.Controls.Add(this.totalAmounttextBox);
            this.Controls.Add(this.discounttextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.vatTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.productNametextBox);
            this.Controls.Add(this.producIdTextBox);
            this.Controls.Add(this.sellNoTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sellNoTextBox;
        private System.Windows.Forms.TextBox producIdTextBox;
        private System.Windows.Forms.TextBox productNametextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discounttextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalAmounttextBox;
        private System.Windows.Forms.TextBox paidAmounttextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox changeAmounttextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataGridView billdataGridView;
        private System.Windows.Forms.Button buttonInventoryBillForm;
        private System.Windows.Forms.Button buttonLogOutBillForm;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox finalamounttextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SELLNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label quantityremaillabel;
        private System.Windows.Forms.Label productQuantitylabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.Button removeItemButton;
    }
}