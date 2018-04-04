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
using System.Diagnostics;
using LoginForm.com.cashier;

namespace LoginForm.com.product
{
    public partial class StockUserControl : UserControl
    {
        AdminControllPage adminPage;
        cashierControlPage cashierPage;
        string supplyType;
        int adminID;
        int cashier_ID;
        public StockUserControl(int cashier_ID)
        {
            InitializeComponent();
            updatestockdataGridView();
            buttonBackAddProductForm.Hide();
            this.cashier_ID = cashier_ID;


        }

        public StockUserControl(AdminControllPage adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        public StockUserControl(AdminControllPage adminPage, int adminID)
            : this(adminPage)
        {
            this.adminID = adminID;
            updatestockdataGridView();
            backButtoncashier.Hide();
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                var result = from combo in DB.SUPPLIERs
                             select combo;
                foreach (var item in result)
                {
                    supplierNamecomboBox.Items.Add(item.TYPE.ToString());
                }
            }

        }

        public StockUserControl(cashierControlPage cashierPage){
            InitializeComponent();
            this.cashierPage = cashierPage;
            updatestockdataGridView();
            buttonBackAddProductForm.Hide();
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var result = from combo in DB.SUPPLIERs
                             select combo;
                foreach (var item in result) {
                    supplierNamecomboBox.Items.Add(item.TYPE.ToString());
                }
            }

        }


        private void stockdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void updatestockdataGridView()
        {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                var result = from product in DB.PRODUCTs
                             select new { product.PRODUCT_ID, product.NAME, product.PURCHASE_PRICE, product.SELLING_PRICE, product.SUPPLIER_ID, Supplier_Name = product.SUPPLIER.NAME, product.QUANTITY };
                stockdataGridView.DataSource = result;
            }
        }

        private void stockdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productID = int.Parse(stockdataGridView.CurrentRow.Cells[0].Value.ToString());
               int supplierID = int.Parse(stockdataGridView.CurrentRow.Cells[0].Value.ToString());
            using (DatabaseDataContext DB = new com.database.DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                var product = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == productID);
                var supply = DB.SUPPLIERs.FirstOrDefault(x=> x.SUPPLIER_ID== supplierID);
                productIDtextBox.Text = product.PRODUCT_ID.ToString();
                productNametextBox.Text = product.NAME;
                quantitytextBox.Text = product.QUANTITY.ToString();
                purchasetextBox.Text = product.PURCHASE_PRICE.ToString();
                sellingtextBox.Text = product.SELLING_PRICE.ToString();
                supplierNamecomboBox.Text = supply.TYPE.ToString();
                //supplierNamecomboBox.SelectedValue 
            }
        }



        private void supplierNamecomboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30"))
	        {
                supplyType = supplierNamecomboBox.SelectedItem.ToString();
                int id = DB.SUPPLIERs.FirstOrDefault(x => x.TYPE == supplyType).SUPPLIER_ID;
               // MessageBox.Show(id + "");
		 
	        }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    PRODUCT pd = new PRODUCT();
                    pd.NAME = productNametextBox.Text;
                    pd.QUANTITY = float.Parse(quantitytextBox.Text);
                    pd.PURCHASE_PRICE = float.Parse(purchasetextBox.Text);
                    pd.SELLING_PRICE = float.Parse(sellingtextBox.Text);
                    pd.DATE = DateTime.Now.ToShortDateString();
                    pd.SUPPLIER_ID = DB.SUPPLIERs.FirstOrDefault(x => x.TYPE == supplyType).SUPPLIER_ID;
                    pd.ADMIN_ID = adminID;
                    DB.PRODUCTs.InsertOnSubmit(pd);
                    DB.SubmitChanges();
                    updatestockdataGridView();
                    MessageBox.Show("product added" + adminID);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void removeButton_Click(object sender, EventArgs e)
        {

            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                var product = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == int.Parse(productIDtextBox.Text));
                DB.PRODUCTs.DeleteOnSubmit(product);
                DB.SubmitChanges();
                MessageBox.Show("Product Removed");
                updatestockdataGridView();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30"))
            {

                

                PRODUCT pd = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == int.Parse(productIDtextBox.Text));
                pd.NAME = productNametextBox.Text;
                pd.QUANTITY = float.Parse(quantitytextBox.Text);
                pd.PURCHASE_PRICE = float.Parse(purchasetextBox.Text);
                pd.SELLING_PRICE = float.Parse(sellingtextBox.Text);
                pd.DATE = DateTime.Now.ToShortDateString();
                pd.SUPPLIER_ID = DB.SUPPLIERs.FirstOrDefault(x => x.TYPE == supplyType).SUPPLIER_ID;
                pd.ADMIN_ID = adminID;
                 DB.SubmitChanges();
                updatestockdataGridView();
                MessageBox.Show("product Updated" + adminID);
            }
        }

        private void buttonBackAddProductForm_Click(object sender, EventArgs e)
        {
            adminPage.Hide();
           
            AdminPage page = new AdminPage(adminID);
            page.Show();

            
        }

        public Panel GetPanel {
            get { return this.panel2; }
            
        }

        private void backButtoncashier_Click(object sender, EventArgs e) {
            cashierPage.Hide();
            Billing bl = new Billing(cashier_ID);
            bl.Show();  
            
        }

        
    }
}