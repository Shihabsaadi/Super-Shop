using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.com;
using LoginForm.com.database;
using System.Web;
using System.Net.Mail;

namespace LoginForm.com.admin.userControl {
    public partial class CashierControl : UserControl {
        AdminControllPage adminPage;
        int adminID;
        public CashierControl(AdminControllPage adminPage, int adminID) {
            InitializeComponent();
            this.adminPage = adminPage;
            this.adminID = adminID;
        
           updateCashierDataGridView();
           passWord();
        }

        public CashierControl(AdminControllPage adminPage) {
            InitializeComponent();
            this.adminPage = adminPage;
            updateCashierDataGridView();
            passWord();
        }

        public CashierControl() {
            InitializeComponent();
            updateCashierDataGridView();
            passWord();
        }
        private void buttonBackCashierForm_Click(object sender, EventArgs e) {
            adminPage.Hide();
            new AdminPage(adminID).Show();
        }

       

        private void CashierControl_Load(object sender, EventArgs e) {

        }

        private void cashierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
           // if (MessageBox.Show("Sure? Remove the chashier", "Remove cashier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                int cashierID = int.Parse(cashierDataGridView.CurrentRow.Cells[0].Value.ToString());
                using (DatabaseDataContext DB = new com.database.DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                    var cashier = DB.CASHIERs.FirstOrDefault(x => x.CASHIER_ID == cashierID);
                    cashierIDTextBox.Text = cashier.CASHIER_ID.ToString();
                    cashierNameTextbox.Text = cashier.NAME;
                    cashierAddressTextbox.Text = cashier.ADDRESS;
                    cashierEmailTextbox.Text = cashier.EMAIL;
                    cashierPhoneTextbox.Text = cashier.PHONE_NO;
                    cashierSalaryTextbox.Text = cashier.SALARY.ToString();
                    cashierPasswordTextbox.Text = cashier.PASSWORD;
                   
                }
          //  }
            //MessageBox.Show(cashierID+"");
        }

        private void updateCashierDataGridView() {
          //  MessageBox.Show("Update cashier before grid");
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var result = from cashier in DB.CASHIERs
                             select new { cashier.CASHIER_ID, cashier.NAME , cashier.EMAIL, cashier.PASSWORD, cashier.SALARY,cashier.ADDRESS };
                cashierDataGridView.DataSource = result;
            }
        }




        private void addButton_Click(object sender, EventArgs e) {
         
        }

        private void buttonBackRemoveCashierForm_Click(object sender, EventArgs e) {
            adminPage.Hide();
            new AdminPage(adminID).Show();
        }

        private void removeButton_Click(object sender, EventArgs e) 
        {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                var cashier = DB.CASHIERs.FirstOrDefault(x=>x.CASHIER_ID == int.Parse(cashierIDTextBox.Text));
                DB.CASHIERs.DeleteOnSubmit(cashier);
                DB.SubmitChanges();
                MessageBox.Show("Cashier Removed");
                updateCashierDataGridView();
                clearTextBox();
                passWord();
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {

                string date = DateTime.Now.ToShortDateString();

                CASHIER cs = new CASHIER();
                cs.NAME = cashierNameTextbox.Text;
                cs.PHONE_NO = cashierPhoneTextbox.Text;
                cs.ADMIN_ID = adminID;
                cs.ADDRESS = cashierAddressTextbox.Text;
                cs.SALARY = int.Parse(cashierSalaryTextbox.Text);
                cs.EMAIL = cashierEmailTextbox.Text;
                cs.PASSWORD = cashierPasswordTextbox.Text;
                cs.DATE = date;
                DB.CASHIERs.InsertOnSubmit(cs);
                DB.SubmitChanges();
                MessageBox.Show("Add Cashier");
                //try {
                //    MailMessage mail = new MailMessage(fromText.Text, cashierEmailTextbox.Text, subject.Text , box.Text);
                //    SmtpClient client = new SmtpClient(smtp.Text);
                //    client.Port = 465;
                //    client.Credentials = new System.Net.NetworkCredential(userText.Text, fromPassText.Text);
                //    client.EnableSsl = true;
                //    client.Send(mail);
                //    MessageBox.Show("Mail sent");
                //} catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                updateCashierDataGridView();
                clearTextBox();
                passWord();
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {

                string date = DateTime.Now.ToShortDateString();
                try {

                    CASHIER cs = DB.CASHIERs.FirstOrDefault(x => x.CASHIER_ID == int.Parse(cashierIDTextBox.Text));
                    cs.PHONE_NO = cashierPhoneTextbox.Text;
                    cs.ADMIN_ID = adminID;
                    cs.ADDRESS = cashierAddressTextbox.Text;
                    cs.SALARY = int.Parse(cashierSalaryTextbox.Text);
                    cs.EMAIL = cashierEmailTextbox.Text;
                        cs.PASSWORD = cashierPasswordTextbox.Text;
                        cs.DATE = date;
                        DB.SubmitChanges();
                        MessageBox.Show("Update Cashier");
                        updateCashierDataGridView();
                        clearTextBox();
                        passWord();
                } catch (Exception ex) {
                    MessageBox.Show("Some Fields are empty");
                }
            }
        }

        private void clearTextBox() {
            cashierIDTextBox.Clear();
             cashierNameTextbox.Clear();
             cashierPhoneTextbox.Clear();
            cashierAddressTextbox.Clear();
            cashierSalaryTextbox.Clear();
            cashierEmailTextbox.Clear();
            cashierPasswordTextbox.Clear();
        }

        private void cashierDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void passWord() 
        {
            Random r = new Random();
            cashierPasswordTextbox.Text= (r.Next(1000, 9999).ToString());
        }
    }
}
