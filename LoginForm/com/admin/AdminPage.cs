using LoginForm.com.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm {
    
    public partial class AdminPage : Form {
        
        int adminID;
        public AdminPage() {
            try {
                InitializeComponent();
                StartPosition = FormStartPosition.CenterScreen;
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        public AdminPage(int adminID) {
            try {
                InitializeComponent();
                StartPosition = FormStartPosition.CenterScreen;
                this.adminID = adminID;
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool mouseDown;
        private Point lastLocation;
        private void Form_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        //private void buttonCashierAdminShowPAgeForm_Click(object sender, EventArgs e)
        //{
        //    Cashier c = new Cashier();
        //    this.Hide();
        //    c.ShowDialog();
        //}

        //private void buttonTransactionAdminShowPageForm_Click(object sender, EventArgs e) 
        //{
        //    TRANSACTION trans = new TRANSACTION();
        //    this.Hide();
        //    trans.ShowDialog();
        //}

        //private void buttonInventoryAdminShowPageForm_Click(object sender, EventArgs e)
        //{
        //    Inventory Invent = new Inventory();
        //    this.Hide();
        //    Invent.ShowDialog();
        //}

        //private void buttonUpdateStockAdminShowPageForm_Click(object sender, EventArgs e)
        //{
        //    UpdateStock US = new UpdateStock();
        //    this.Hide();
        //    US.ShowDialog();
        //}

        //private void buttonBillingAdminSHowPageForm_Click(object sender, EventArgs e) 
        //{
        //    Billing bil = new Billing();
        //    this.Hide();
        //    bil.ShowDialog();
        //}

        //private void buttonLogOutAdminShowPageForm_Click(object sender, EventArgs e) 
        //{
        //    Login f = new Login();

          
        //    this.Hide();
            
        //    f.ShowDialog();
        //}

        //private void panel1_Paint(object sender, PaintEventArgs e) {

        //}

        //private void buttonSupplierAdminShowPage_Click(object sender, EventArgs e) {

        //}

        private void minimizeLabel_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeLabel_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are You Sure?","Close Window",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void cashierButton_Click(object sender, EventArgs e) {
            this.Hide();
            new AdminControllPage("Cashier", adminID).Show();
        }

        private void profitButton_Click(object sender, EventArgs e) {
            this.Hide();
            new AdminControllPage("Profit", adminID).Show();
        }

        private void transactionButton_Click(object sender, EventArgs e) {
            this.Hide();
            new AdminControllPage("Transaction", adminID).Show();
        }

        //private void inventoryButton_Click(object sender, EventArgs e) {
        //    this.Hide();
        //    new AdminControllPage("Inventory", adminID).Show();
        //}

        private void logoutButton_Click(object sender, EventArgs e) {
            this.Hide();
            new Login().Show();
        }

        private void suplierButton_Click(object sender, EventArgs e) {
            this.Hide();
            new AdminControllPage("Supplier", adminID).Show();
        }

        private void updateStockButton_Click(object sender, EventArgs e) {
            this.Hide();
            new AdminControllPage("Stock", adminID).Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e) {

        }
    }
}


