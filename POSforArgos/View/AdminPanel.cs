using POSforArgos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POSforArgos
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            TransactionSummary ts = new TransactionSummary();
            ts.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View.ManageCategory Cat = new View.ManageCategory();
            Cat.Show();
            Hide();
        }

        private void btnManageCashiers_Click(object sender, EventArgs e)
        {
            ManageCashiers mc = new ManageCashiers();
            mc.Show();
            Hide();
        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {
            ManageItemView miv = new ManageItemView();
            miv.Show();
            Hide();
        }

        private void btnReceiveStock_Click(object sender, EventArgs e)
        {
            ReceiveGoods rg = new ReceiveGoods();
            Hide();
            rg.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            lblUsername.Text = loginForm.SetValueForText1; 
        }

        private void btnLoyaltyCustomerDetails_Click(object sender, EventArgs e)
        {
            LoyaltyCustomerReport lcr = new LoyaltyCustomerReport();
            lcr.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerPurchaseHistory cph = new CustomerPurchaseHistory();
            cph.Show();
            Hide();
        }

        private void btnIncomeReport_Click(object sender, EventArgs e)
        {
            IncomeReport ir = new IncomeReport();
            ir.Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
