using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.com.admin;
using LoginForm.com.database;
namespace LoginForm.com.supplier {
    public partial class SupplierControl : UserControl {
        AdminControllPage adminPage;
        int adminID;
        public SupplierControl(AdminControllPage adminPage) {
            InitializeComponent();
            this.adminPage = adminPage;
            updateCashierDataGridView();
        }

        public SupplierControl(AdminControllPage adminPage,int adminID)
        {
            InitializeComponent();
            this.adminPage = adminPage;
            this.adminID = adminID;
            updateCashierDataGridView();
        }

        private void backButton_Click(object sender, EventArgs e) {
            adminPage.Hide();
            new AdminPage(adminID).Visible = true;
        }

        private void addButton_Click(object sender, EventArgs e) 
        {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) 
            {
                if (suppleirNameTextBox.Text != "" && productTypeTextBox.Text != "")
                {
                    SUPPLIER sp = new SUPPLIER();
                    sp.NAME = suppleirNameTextBox.Text;
                    sp.TYPE = productTypeTextBox.Text;
                    DB.SUPPLIERs.InsertOnSubmit(sp);
                    DB.SubmitChanges();
                    updateCashierDataGridView();
                    MessageBox.Show("Supplier added");
                }
                else 
                {
                    MessageBox.Show("Some Fields are empty");
                }
            }
        }

        private void updateCashierDataGridView() {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var result = from supplier in DB.SUPPLIERs
                             select new { supplier.SUPPLIER_ID, supplier.NAME,supplier.TYPE };
                supplierdataGridView.DataSource = result;
            }
        }

        private void removeButton_Click(object sender, EventArgs e) 
        {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var supplier = DB.SUPPLIERs.FirstOrDefault(x => x.SUPPLIER_ID == int.Parse(supplierIDtextBox.Text));
                DB.SUPPLIERs.DeleteOnSubmit(supplier);
               
                DB.SubmitChanges();
                MessageBox.Show("Supplier Removed");
                updateCashierDataGridView();
              
            }
        }

        private void supplierdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             int supplierID = int.Parse(supplierdataGridView.CurrentRow.Cells[0].Value.ToString());
             using (DatabaseDataContext DB = new com.database.DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                 var supplier = DB.SUPPLIERs.FirstOrDefault(x => x.SUPPLIER_ID == supplierID);
                 supplierIDtextBox.Text = supplier.SUPPLIER_ID.ToString();
                 suppleirNameTextBox.Text = supplier.NAME;
                 productTypeTextBox.Text = supplier.TYPE;
             }
        }
    }
}
