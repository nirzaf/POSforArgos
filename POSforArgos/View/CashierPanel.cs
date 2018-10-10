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
    public partial class CashierPanel : Form
    {
        public CashierPanel()
        {
            InitializeComponent();
        }

        private void CashierPanel_Load(object sender, EventArgs e)
        {
            lblCashierName.Text = loginForm.SetValueForText1;
        }

        private void btnManageCutomers_Click(object sender, EventArgs e)
        {
            ManageCustomerView mcv = new ManageCustomerView();
            mcv.Show();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            ManageSales ms = new ManageSales();
            ms.Show();
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
