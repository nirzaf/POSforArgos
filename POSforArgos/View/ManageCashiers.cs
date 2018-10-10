using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSforArgos.Business;

namespace POSforArgos.View
{
    public partial class ManageCashiers : Form
    {
        CashierManagement obj = new CashierManagement();
        public ManageCashiers()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
               dataGridCashiers.DataSource = obj.GetCashier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text =="")
                {
                    lblMessage.Text = "Username or Password cannot be empty";
                }
                else
                {
                    switch (MessageBox.Show("Do you want to add new cashier?",
                    "Add Cashier",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            string Message = obj.AddCashier(txtUsername.Text,txtPassword.Text);
                            lblMessage.Text = Message;
                            try
                            {
                                dataGridCashiers.DataSource = obj.GetCashier();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            break;

                        case DialogResult.No:
                            break;
                    }
                }

            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    lblMessage.Text = "Username or Password cannot be empty";
                }
                else
                {
                    switch (MessageBox.Show("Do you want to update password?",
                                        "Update password",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            string Message = obj.UpdateCashier(txtUsername.Text, txtPassword.Text);
                            lblMessage.Text = Message;
                            try
                            {
                                dataGridCashiers.DataSource = obj.GetCashier();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            break;

                        case DialogResult.No:
                            break;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                switch (MessageBox.Show("Do you want to delete the selected cashier?",
                "Delete Cashier",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        string user = txtUsername.Text;
                        string Message = obj.DeleteCashier(user);
                        lblMessage.Text = Message;
                        try
                        {
                            dataGridCashiers.DataSource = obj.GetCashier();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;

                    case DialogResult.No:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Search = txtSearch.Text;
            try
            {
                dataGridCashiers.DataSource = obj.SearchCashier(Search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Search = txtSearch.Text;
            try
            {
                dataGridCashiers.DataSource = obj.SearchCashier(Search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridCashiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridCashiers.SelectedRows.Count > 0)
                {
                   string username = dataGridCashiers.SelectedRows[0].Cells[0].Value + string.Empty;
                   string password = dataGridCashiers.SelectedRows[0].Cells[1].Value + string.Empty;

                    txtUsername.Text = username;
                    txtPassword.Text = password;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageCashiers_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridCashiers.DataSource = obj.GetCashier();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            lblMessage.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }
    }
}
