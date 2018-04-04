using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.com.database;

namespace LoginForm {
    public partial class Login : Form {



        public Login() {
            InitializeComponent();

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

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }



        //private void buttonLoginLoginForm_Click_1(object sender, EventArgs e) {


        //    AdminPage asp = new AdminPage();
        //    this.Hide();
        //    asp.ShowDialog();
        //}

        private void buttonExitLoginForm_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void buttonLoginLoginForm_Click(object sender, EventArgs e) {
            //AdminPage admin = new AdminPage();
            //this.Hide();
            try {   //admin.ShowDialog();
                using (DatabaseDataContext DB = new DatabaseDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\FinalPart\FinalPart\FinalPart\LoginForm\shopdb.mdf;Integrated Security=True;Connect Timeout=30")) {
                    var loginResult = DB.ADMINs.FirstOrDefault(x => x.NAME == userNameTextBox.Text && x.PASSWORD == passwordTextBox.Text);
                    var userResult = DB.CASHIERs.FirstOrDefault(x => x.NAME == userNameTextBox.Text && x.PASSWORD == passwordTextBox.Text);
                    if (loginResult != null) {
                        AdminPage asp = new AdminPage(loginResult.ADMIN_ID);
                        this.Hide();
                        asp.ShowDialog();
                    } else if (userResult != null) {

                        Billing bl = new Billing(userResult.CASHIER_ID);
                        this.Hide();
                        bl.ShowDialog();
                    } else {
                        MessageBox.Show("Username OR Passowrd Invalid");
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void userNameTextBox_MouseClick(object sender, MouseEventArgs e) {
            userNameTextBox.Text = "";
        }

        private void passwordTextBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            passwordTextBox.Text = "";
        }

        private void passwordTextBox_MouseClick(object sender, MouseEventArgs e) {
            passwordTextBox.Text = "";
        }

        private void userNameTextBox_MouseLeave(object sender, EventArgs e) {

        }

        private void userNameTextBox_Leave(object sender, EventArgs e) {
            if (userNameTextBox.Text == "") {
                userNameTextBox.Text = "User Name";
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e) {


        }

        private void passwordTextBox_Leave(object sender, EventArgs e) {
            if (passwordTextBox.Text == "") {
                passwordTextBox.Text = "********";
            }
        }

    }
}
