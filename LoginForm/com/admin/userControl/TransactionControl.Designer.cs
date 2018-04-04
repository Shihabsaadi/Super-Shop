namespace LoginForm.com.admin.userControl {
    partial class TransactionControl {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.transactiondataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBackTransactionForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiondataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.GreenYellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 54);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GreenYellow;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRANSACTION";
            // 
            // transactiondataGridView
            // 
            this.transactiondataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.transactiondataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactiondataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.transactiondataGridView.Location = new System.Drawing.Point(255, 118);
            this.transactiondataGridView.Name = "transactiondataGridView";
            this.transactiondataGridView.Size = new System.Drawing.Size(603, 284);
            this.transactiondataGridView.TabIndex = 6;
            // 
            // buttonBackTransactionForm
            // 
            this.buttonBackTransactionForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBackTransactionForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackTransactionForm.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackTransactionForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackTransactionForm.Location = new System.Drawing.Point(718, 61);
            this.buttonBackTransactionForm.Name = "buttonBackTransactionForm";
            this.buttonBackTransactionForm.Size = new System.Drawing.Size(140, 39);
            this.buttonBackTransactionForm.TabIndex = 5;
            this.buttonBackTransactionForm.Text = "< BACK";
            this.buttonBackTransactionForm.UseVisualStyleBackColor = false;
            this.buttonBackTransactionForm.Click += new System.EventHandler(this.buttonBackTransactionForm_Click);
            // 
            // TransactionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.transactiondataGridView);
            this.Controls.Add(this.buttonBackTransactionForm);
            this.Name = "TransactionControl";
            this.Size = new System.Drawing.Size(1066, 522);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactiondataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView transactiondataGridView;
        private System.Windows.Forms.Button buttonBackTransactionForm;
    }
}
