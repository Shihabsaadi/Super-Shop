using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.com.admin.userControl;

using LoginForm.com.supplier;
using LoginForm.com.product;

namespace LoginForm.com.admin {
    public partial class AdminControllPage : Form {
        string currentUserControl;
        int adminID;
        CashierControl cashier;
        ProfitCalculationControl profit;
        TransactionControl transaction;
        //InventoryControl inventory;
        SupplierControl supplier;
        StockUserControl stock;
        public AdminControllPage() {
            InitializeComponent();
        }
        public AdminControllPage(string name) {
            InitializeComponent();
            this.currentUserControl = name;

        }
        public AdminControllPage(string name, int adminID)
            : this(name) {
                try {
                    // InitializeComponent();
                    //this.currentUserControl = name;
                    this.adminID = adminID;
                    cashier = new CashierControl(this, adminID);
                    cashier.Dock = DockStyle.Fill;
                    profit = new ProfitCalculationControl(this, adminID);
                    profit.Dock = DockStyle.Fill;
                    transaction = new TransactionControl(this, adminID);
                    transaction.Dock = DockStyle.Fill;
                    //inventory = new InventoryControl(this);
                    //inventory.Dock = DockStyle.Fill;
                    supplier = new SupplierControl(this, adminID);
                    supplier.Dock = DockStyle.Fill;
                    stock = new StockUserControl(this, adminID);
                    stock.Dock = DockStyle.Fill;

                    if (currentUserControl == "Cashier") {
                        mainPanel.Controls.Add(cashier);
                        cashier.BringToFront();

                    } else if (currentUserControl == "Profit") {
                        mainPanel.Controls.Add(profit);
                        profit.BringToFront();
                    } else if (currentUserControl == "Transaction") {
                        mainPanel.Controls.Add(transaction);
                        transaction.BringToFront();
                    }
                        //} else if (currentUserControl == "Inventory") {
                        //    mainPanel.Controls.Add(inventory);
                        //    inventory.BringToFront();
                        //} 
                        else if (currentUserControl == "Supplier") {
                        mainPanel.Controls.Add(supplier);
                        supplier.BringToFront();
                    } else if (currentUserControl == "Stock") {
                        mainPanel.Controls.Add(stock);
                        stock.BringToFront();
                    }
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

        private void minimizeLabel_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeLabel_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are You Sure?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void AdminControllPage_Load(object sender, EventArgs e) {

        }
    }
}
