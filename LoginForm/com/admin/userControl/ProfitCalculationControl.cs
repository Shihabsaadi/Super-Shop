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
    public partial class ProfitCalculationControl : UserControl {
        int adminID;
        AdminControllPage adminpage;
        public ProfitCalculationControl(AdminControllPage adminpage, int adminID) {
            InitializeComponent();
            this.adminpage = adminpage;
            this.adminID = adminID;
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\SuperShopDB.mdf;Integrated Security=True;Connect Timeout=30")) 
            {
                //SELL_ITEM sell = new SELL_ITEM();
                //PRODUCT pr = new PRODUCT();
                updateDataGridView();
                //sell.QUANTITY = float.Parse(quantityTextBox.Text);
                //pr.SELLING_PRICE = float.Parse(totalPricetextBox.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e) {
            adminpage.Hide();
            new AdminPage(adminID).Show();
        }
        //SELL_ITEM sell = new SELL_ITEM();

        private void showProfitButton_Click(object sender, EventArgs e) {
            try {
                //int d1, d2;
                //d1 = dateTimePicker1.Value.Date.DayOfYear;
                //d2 = dateTimePicker2.Value.Date.DayOfYear;
                //using (DatabaseDataContext db = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\SuperShopDB.mdf;Integrated Security=True;Connect Timeout=30")) {
                //    var r = from item in db.SELL_ITEMs
                //            //where item.DATE.DayOfYear >= d1 && item.DATE.DayOfYear <= d2
                //            select new { item.SELLING_ID, item.QUANTITY, item.PRODUCT_ID, item.DATE, item.PURCHASE, item.SELLING_PRICE, item.PROFIT };
                //    MessageBox.Show(r.ToString());
                //    DataTable table = r.CopyToDataTable();
                //    dataGridView1.DataSource = table;
                //}
                //dataGridView1.Refresh();
                updateDataGridView();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        private void updateDataGridView() {
            int d1, d2;
            d1 = dateTimePicker1.Value.Date.DayOfYear;
            d2 = dateTimePicker2.Value.Date.DayOfYear;
            using (DatabaseDataContext DB = new DatabaseDataContext()) {
                var result = from item in DB.SELL_ITEMs
                //             where item.DATE.DayOfYear >= d1 && item.DATE.DayOfYear <= d2
                             select new {item.PROFIT};
               // MessageBox.Show(result.ToString());
                dataGridView1.DataSource = result;
            }
        }
       


            }
        }
 
