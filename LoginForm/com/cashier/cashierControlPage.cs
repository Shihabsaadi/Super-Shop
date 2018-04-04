using LoginForm.com.product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.com.cashier {
    public partial class cashierControlPage : Form {
        string currentUserControl;
        StockUserControl stock;

        public cashierControlPage() {
            InitializeComponent();
            stock = new StockUserControl(this);
            cashierMainpanel.Controls.Add(stock);
            stock.GetPanel.Visible = false;
           
        }

        public cashierControlPage(string name) {
            InitializeComponent();
            this.currentUserControl = name;
           

            
        }


      

    }
}
