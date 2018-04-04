using LoginForm.com.cashier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.com.database;
namespace LoginForm {
    public partial class Billing : Form {
        public static int cashierID;
        //Cashier ID
        private int cashier_ID;
        public Billing(int id) {
           
            InitializeComponent();
            timer.Start();
            cashier_ID = id;
            buttonInventoryBillForm.Hide();
            updatestockdataGridView();
        }

        public Billing() {

            InitializeComponent();
            timer.Start();
        }
       

        private void label11_Click(object sender, EventArgs e) {

        }

        private void textBox11_TextChanged(object sender, EventArgs e) {

        }

        private void buttonLogOutBillForm_Click(object sender, EventArgs e) {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
        }

        private void buttonInventoryBillForm_Click(object sender, EventArgs e) {
            cashierControlPage cp = new cashierControlPage();
            this.Hide();
            cp.Show();


        }

        private void searchID_Click(object sender, EventArgs e) {

        }

        private void producIdTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var searchResult = from product in DB.PRODUCTs
                                   where product.PRODUCT_ID.ToString().Contains(searchTextBox.Text) || product.NAME.Contains(searchTextBox.Text)
                                   select new { ID = product.PRODUCT_ID, Name = product.NAME, Quantity = product.QUANTITY };
                searchGridView.DataSource = searchResult;
            }
        }

        private void productNametextBox_TextChanged(object sender, EventArgs e) {



        }


        private void addButton_Click(object sender, EventArgs e) {
            try {
                int productID = int.Parse(searchGridView.CurrentRow.Cells[0].Value.ToString());
                using (DatabaseDataContext DB = new com.database.DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                    var product = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == productID);
                    if (quantityTextBox.Text != "") {
                        float valuequantity = float.Parse(quantityTextBox.Text);

                        if (product.QUANTITY >= valuequantity) {
                            
                            product.QUANTITY -= valuequantity;
                            if (!available()) {

                                int row = 0;
                                billdataGridView.Rows.Add();
                                row = billdataGridView.Rows.Count - 2;
                                billdataGridView["PRODUCTNAME", row].Value = productNametextBox.Text;
                                billdataGridView["PRODUCTID", row].Value = producIdTextBox.Text;
                                billdataGridView["QUANTITY", row].Value = quantityTextBox.Text;
                                billdataGridView["PRICE", row].Value = finalamounttextBox.Text;
                                billdataGridView["SELLNO", row].Value = sellNoTextBox.Text;
                            }
                            //  quantityTextBox.Text = productQuantitylabel.Text;
                        } else {
                            MessageBox.Show(product.NAME + " is Not Available in Stock");
                        }
                    } else {
                        MessageBox.Show("Quantity not definded");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        public bool available() {
            int productID = int.Parse(searchGridView.CurrentRow.Cells[0].Value.ToString());
            //  MessageBox.Show(productID.ToString());
            int y = 1;
            while (y < billdataGridView.Rows.Count) {
                // MessageBox.Show(billdataGridView.Rows.Count.ToString());
                if (billdataGridView.Rows.Count > 1) {
                    if (billdataGridView.Rows[y - 1].Cells[4].Value.ToString().Equals(productID.ToString())) {
                        float price = float.Parse(billdataGridView.Rows[y - 1].Cells[3].Value.ToString());
                        float quantity = float.Parse(billdataGridView.Rows[y - 1].Cells[2].Value.ToString());
                      //  using (DatabaseDataContext DB = new com.database.DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                           // var product = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == productID);
                           // if (quantity < product.QUANTITY) {
                                price += float.Parse(finalamounttextBox.Text);
                                quantity += float.Parse(quantityTextBox.Text);
                                billdataGridView["QUANTITY", y - 1].Value = quantity;
                                billdataGridView["PRICE", y - 1].Value = price;
                                return true;
                            } else {
                                MessageBox.Show("Quantity is not enough man");
                                break;
                                y++;
                                return false;
//                            }

                           // }
                        }
                    } else {
                        break;
                    }

                    y++;
                }
                
                return false;
            }
        
        
        private void searchGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            int productID = int.Parse(searchGridView.CurrentRow.Cells[0].Value.ToString());

            using (DatabaseDataContext DB = new com.database.DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var product = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == productID);
                float vat = 5;


                newLabel.Text = product.QUANTITY.ToString();
                producIdTextBox.Text = product.PRODUCT_ID.ToString();
                productNametextBox.Text = product.NAME;
                priceTextBox.Text = product.SELLING_PRICE.ToString();
                vatTextBox.Text = vat.ToString();
              


                //  sellingtextBox.Text = product.SELLING_PRICE.ToString();
            }

          
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
            
        {
           
            
            if (!quantityTextBox.Text.Equals(""))
            {
                float finalamount;
                finalamount = float.Parse(quantityTextBox.Text) * float.Parse(priceTextBox.Text);
                finalamounttextBox.Text = finalamount.ToString();

                float vatt, aftervat;
                vatt = float.Parse(finalamounttextBox.Text) * float.Parse(vatTextBox.Text) / 100;
                aftervat = float.Parse(finalamounttextBox.Text) + vatt;
                finalamounttextBox.Text = aftervat.ToString();
            } 

            else 
            {
              
                finalamounttextBox.Text = "";
                quantityTextBox.Text = "";
        //        finalamounttextBox.Text = "";
          
            }         

            }

        private void discounttextBox_TextChanged(object sender, EventArgs e) {
            try {
                if (quantityTextBox.Text != ""&&discounttextBox.Text!="") {
                    if (discounttextBox.Text != null && !clearbutton.Enabled) {
                        discounttextBox.Clear();
                    } else if (discounttextBox.Text != null) {
                        float discount;
                        float p, q, a;
                        p = float.Parse(priceTextBox.Text);
                        q = float.Parse(quantityTextBox.Text);
                        a = p * q;
                        float vat = a * float.Parse(vatTextBox.Text)/100;
                        float totalPrice = a + vat;
                        discount = totalPrice * float.Parse(discounttextBox.Text)/100;
                        totalPrice -= discount;
                        //afterdiscount = float.Parse(finalamounttextBox.Text) - discount;

                        finalamounttextBox.Text = totalPrice.ToString();

                    } 

                } else {
                    MessageBox.Show("Define Quantity first");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());

            }
            if(discounttextBox.Text == "")
             {

                        discounttextBox.Text = null;
                        float p, q, a;
                        p = float.Parse(priceTextBox.Text);
                        q = float.Parse(quantityTextBox.Text);
                        a = p * q;
                        float vat = a * float.Parse(vatTextBox.Text) / 100;
                        float totalPrice = a + vat;
                        finalamounttextBox.Text = totalPrice.ToString();


                    }
        }

        private void totalButton_Click(object sender, EventArgs e) 
        {
            if (billdataGridView.CurrentRow != null) {
                totalAmounttextBox.Text = "0";
                for (int i = 0; i < billdataGridView.Rows.Count - 1; i++) {
                    totalAmounttextBox.Text = Convert.ToString(float.Parse(totalAmounttextBox.Text) + float.Parse(billdataGridView.Rows[i].Cells[3].Value.ToString()));
                }

                float minus;
                minus = float.Parse(newLabel.Text) - float.Parse(quantityTextBox.Text);
                productQuantitylabel.Text = minus.ToString();
            } 
            else 
            {
                MessageBox.Show("gridview ");
            }


        }
        
        private void calculateButton_Click(object sender, EventArgs e)
        {
            try {
                if (totalAmounttextBox.Text != null && paidAmounttextBox.Text != null) {

                    if (float.Parse(paidAmounttextBox.Text) >= float.Parse(totalAmounttextBox.Text)) {
                        changeAmounttextBox.Text = Convert.ToString(float.Parse(paidAmounttextBox.Text) - float.Parse(totalAmounttextBox.Text));



                    } else {
                        MessageBox.Show("Payment is lower than purchase amount");
                    }
                } else {
                    MessageBox.Show("Selling calculation incomplete");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {
       

        }

        private void timer_Tick(object sender, EventArgs e) {
            labelDate.Text = DateTime.Now.ToLongDateString();
            labelTime.Text = DateTime.Now.ToLongTimeString();

        }

        private void printButton_Click(object sender, EventArgs e) {
            
            try {
                if (totalAmounttextBox.Text != "" && paidAmounttextBox.Text != "") {

                    using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
            
                        SELL_ITEM sell = new SELL_ITEM();
                        CASHIER cs = new CASHIER();
                        PRODUCT pr = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == int.Parse(producIdTextBox.Text));
                        sell.PRODUCT_ID = int.Parse(producIdTextBox.Text);
                        sell.QUNATITY = float.Parse(quantityTextBox.Text);
                        sell.CASHIER_ID = cashier_ID;
                      //  MessageBox.Show("4");
                        sell.DATE = DateTime.Now.ToString();
                      //  MessageBox.Show("11");
                        sell.PURCHASE = float.Parse(pr.PURCHASE_PRICE.ToString());
                       // MessageBox.Show("12"); 
                        sell.SELLING_PRICE = float.Parse(finalamounttextBox.Text);
                        
                        sell.PROFIT = float.Parse(finalamounttextBox.Text) - float.Parse(pr.PURCHASE_PRICE.ToString());
            //            MessageBox.Show("5");
                        DB.SELL_ITEMs.InsertOnSubmit(sell);
                       MessageBox.Show("Done");
                        //  DB.SubmitChanges();
                        //
                        //PRODUCT pr = DB.PRODUCTs.FirstOrDefault(x => x.PRODUCT_ID == int.Parse(producIdTextBox.Text));
                        //pr.QUANTITY = float.Parse(productQuantitylabel.Text);
                       

                        pr.QUANTITY = float.Parse(productQuantitylabel.Text);
                        DB.SubmitChanges();
                       // MessageBox.Show("6");
                        updatestockdataGridView();
                    
                        MessageBox.Show("Product Sold Successfully , Thank you");
                        billdataGridView.DataSource = null;
                        clearTextBox();
                    }
                } else {
                    MessageBox.Show("Selling process incomplete");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        //private void label14_Click(object sender, EventArgs e) {

        //}

        private void Billing_Load(object sender, EventArgs e) {

        }

        private void quantityremaillabel_Click(object sender, EventArgs e) {

        }

        private void updatestockdataGridView() {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var result = from product in DB.PRODUCTs
                             select new { product.PRODUCT_ID, product.NAME, product.SELLING_PRICE,  product.QUANTITY, Supplier_Name = product.SUPPLIER.NAME };
                searchGridView.DataSource = result;
            }
        }

        private void billdataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) {

        }

        private void removeItemButton_Click(object sender, EventArgs e) {
            try {
                if (this.billdataGridView.Rows.Count > 0)
                    this.billdataGridView.Rows.RemoveAt(this.billdataGridView.SelectedRows[0].Index);
            } catch (Exception ex) {
                try {
                    if (this.billdataGridView.CurrentCell.RowIndex > 0) {
                        MessageBox.Show("Updated");
                        this.billdataGridView.Rows.RemoveAt(this.billdataGridView.CurrentCell.RowIndex+1);

                    }
                } catch (Exception ex2) {
                    MessageBox.Show("Removed");
                }
            }
        }

        private void clearTextBox() 
        {
            producIdTextBox.Clear();
            productNametextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            discounttextBox.Clear();
            finalamounttextBox.Clear();
            totalAmounttextBox.Clear();
            paidAmounttextBox.Clear();
            changeAmounttextBox.Clear();
            
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            clearbutton.Enabled = false;
            try {   
                clearTextBox();
            } catch (Exception ex) {
               // MessageBox.Show(ex.ToString());
            }
            clearbutton.Enabled = true;
        }

        private void finalamounttextBox_TextChanged(object sender, EventArgs e) {

        }
        }

        //private void discounttextBox_TextChanged(object sender, EventArgs e) 
        //{


            
        }

      //  private void discounttextBox_TextChanged(object sender, EventArgs e)
      //  {
      //  }


    

