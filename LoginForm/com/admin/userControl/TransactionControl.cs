using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.com.database;

namespace LoginForm.com.admin.userControl {
    public partial class TransactionControl : UserControl {
        int adminID;
        AdminControllPage adminpage;
        public TransactionControl(AdminControllPage adminpage, int adminID) {
            InitializeComponent();
            this.adminpage = adminpage;
            this.adminID = adminID;
            updatetransactionDataGridView();


        }

        private void buttonBackTransactionForm_Click(object sender, EventArgs e) {
            adminpage.Hide();
            new AdminPage(adminID).Show();

        }
        private void updatetransactionDataGridView() {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var result = from item in DB.SELL_ITEMs
                             select new { item.SELLING_ID, item.QUNATITY, item.PRODUCT_ID, item.DATE, item.CASHIER_ID ,item.PROFIT};
                //MessageBox.Show(result.ToString());
                transactiondataGridView.DataSource = result;
            }
        }
    }
}
