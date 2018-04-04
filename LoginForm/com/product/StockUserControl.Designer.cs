namespace LoginForm.com.product {
    partial class StockUserControl {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.stockdataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBackAddProductForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.supplierNamecomboBox = new System.Windows.Forms.ComboBox();
            this.quantitytextBox = new System.Windows.Forms.TextBox();
            this.sellingtextBox = new System.Windows.Forms.TextBox();
            this.purchasetextBox = new System.Windows.Forms.TextBox();
            this.productNametextBox = new System.Windows.Forms.TextBox();
            this.productIDtextBox = new System.Windows.Forms.TextBox();
            this.backButtoncashier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // stockdataGridView
            // 
            this.stockdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockdataGridView.Location = new System.Drawing.Point(19, 73);
            this.stockdataGridView.Name = "stockdataGridView";
            this.stockdataGridView.Size = new System.Drawing.Size(658, 335);
            this.stockdataGridView.TabIndex = 12;
            this.stockdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockdataGridView_CellClick);
            this.stockdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stockdataGridView_CellContentClick);
            // 
            // buttonBackAddProductForm
            // 
            this.buttonBackAddProductForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBackAddProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackAddProductForm.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackAddProductForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackAddProductForm.Location = new System.Drawing.Point(868, 60);
            this.buttonBackAddProductForm.Name = "buttonBackAddProductForm";
            this.buttonBackAddProductForm.Size = new System.Drawing.Size(111, 45);
            this.buttonBackAddProductForm.TabIndex = 11;
            this.buttonBackAddProductForm.Text = "< Back";
            this.buttonBackAddProductForm.UseVisualStyleBackColor = false;
            this.buttonBackAddProductForm.Click += new System.EventHandler(this.buttonBackAddProductForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 54);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(455, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.removeButton);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Controls.Add(this.updateButton);
            this.panel2.Controls.Add(this.supplierNamecomboBox);
            this.panel2.Controls.Add(this.quantitytextBox);
            this.panel2.Controls.Add(this.sellingtextBox);
            this.panel2.Controls.Add(this.purchasetextBox);
            this.panel2.Controls.Add(this.productNametextBox);
            this.panel2.Controls.Add(this.productIDtextBox);
            this.panel2.Location = new System.Drawing.Point(711, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 341);
            this.panel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Selling Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Purchase Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Product ID";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Teal;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(217, 231);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(89, 36);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Lime;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(117, 231);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 36);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateButton.Location = new System.Drawing.Point(18, 231);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(93, 36);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // supplierNamecomboBox
            // 
            this.supplierNamecomboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.supplierNamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierNamecomboBox.FormattingEnabled = true;
            this.supplierNamecomboBox.Location = new System.Drawing.Point(102, 76);
            this.supplierNamecomboBox.Name = "supplierNamecomboBox";
            this.supplierNamecomboBox.Size = new System.Drawing.Size(204, 21);
            this.supplierNamecomboBox.TabIndex = 17;
            this.supplierNamecomboBox.Text = "Supplier Type";
            this.supplierNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.supplierNamecomboBox_SelectedIndexChanged);
            // 
            // quantitytextBox
            // 
            this.quantitytextBox.BackColor = System.Drawing.Color.LightGray;
            this.quantitytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytextBox.Location = new System.Drawing.Point(102, 115);
            this.quantitytextBox.Name = "quantitytextBox";
            this.quantitytextBox.Size = new System.Drawing.Size(204, 20);
            this.quantitytextBox.TabIndex = 16;
            // 
            // sellingtextBox
            // 
            this.sellingtextBox.BackColor = System.Drawing.Color.LightGray;
            this.sellingtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingtextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sellingtextBox.Location = new System.Drawing.Point(102, 190);
            this.sellingtextBox.Name = "sellingtextBox";
            this.sellingtextBox.Size = new System.Drawing.Size(204, 20);
            this.sellingtextBox.TabIndex = 12;
            // 
            // purchasetextBox
            // 
            this.purchasetextBox.BackColor = System.Drawing.Color.LightGray;
            this.purchasetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasetextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.purchasetextBox.Location = new System.Drawing.Point(102, 152);
            this.purchasetextBox.Name = "purchasetextBox";
            this.purchasetextBox.Size = new System.Drawing.Size(204, 20);
            this.purchasetextBox.TabIndex = 13;
            // 
            // productNametextBox
            // 
            this.productNametextBox.BackColor = System.Drawing.Color.LightGray;
            this.productNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNametextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productNametextBox.Location = new System.Drawing.Point(102, 39);
            this.productNametextBox.Name = "productNametextBox";
            this.productNametextBox.Size = new System.Drawing.Size(204, 20);
            this.productNametextBox.TabIndex = 14;
            // 
            // productIDtextBox
            // 
            this.productIDtextBox.BackColor = System.Drawing.Color.LightGray;
            this.productIDtextBox.Enabled = false;
            this.productIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDtextBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productIDtextBox.Location = new System.Drawing.Point(102, 3);
            this.productIDtextBox.Name = "productIDtextBox";
            this.productIDtextBox.Size = new System.Drawing.Size(204, 20);
            this.productIDtextBox.TabIndex = 15;
            // 
            // backButtoncashier
            // 
            this.backButtoncashier.BackColor = System.Drawing.Color.Maroon;
            this.backButtoncashier.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtoncashier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backButtoncashier.Location = new System.Drawing.Point(743, 61);
            this.backButtoncashier.Name = "backButtoncashier";
            this.backButtoncashier.Size = new System.Drawing.Size(119, 44);
            this.backButtoncashier.TabIndex = 14;
            this.backButtoncashier.Text = "< BACK";
            this.backButtoncashier.UseVisualStyleBackColor = false;
            this.backButtoncashier.Click += new System.EventHandler(this.backButtoncashier_Click);
            // 
            // StockUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButtoncashier);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.stockdataGridView);
            this.Controls.Add(this.buttonBackAddProductForm);
            this.Controls.Add(this.panel1);
            this.Name = "StockUserControl";
            this.Size = new System.Drawing.Size(1066, 522);
            ((System.ComponentModel.ISupportInitialize)(this.stockdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stockdataGridView;
        private System.Windows.Forms.Button buttonBackAddProductForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ComboBox supplierNamecomboBox;
        private System.Windows.Forms.TextBox quantitytextBox;
        private System.Windows.Forms.TextBox sellingtextBox;
        private System.Windows.Forms.TextBox purchasetextBox;
        private System.Windows.Forms.TextBox productNametextBox;
        private System.Windows.Forms.TextBox productIDtextBox;
        private System.Windows.Forms.Button backButtoncashier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
