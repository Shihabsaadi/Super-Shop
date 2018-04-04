namespace LoginForm.com.cashier {
    partial class cashierControlPage {
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
            this.cashierMainpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cashierMainpanel
            // 
            this.cashierMainpanel.Location = new System.Drawing.Point(12, 37);
            this.cashierMainpanel.Name = "cashierMainpanel";
            this.cashierMainpanel.Size = new System.Drawing.Size(1026, 434);
            this.cashierMainpanel.TabIndex = 0;
            // 
            // cashierControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 483);
            this.Controls.Add(this.cashierMainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cashierControlPage";
            this.Text = "cashierControlPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel cashierMainpanel;
    }
}