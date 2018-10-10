using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using POSforArgos.DLL;
using POSforArgos.Business;

namespace POSforArgos
{
    public partial class ManageCustomerView : Form
    {
        DataCon dataCon = new DataCon();
        ManageCustomerBL mcb = new ManageCustomerBL();
        public ManageCustomerView()
        {
            InitializeComponent();
        }

        private void ManageCustomerView_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridCustomers.DataSource = mcb.GetCustomers();
                dataGC.DataSource = mcb.GetCustomers();
                lblMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridCustomers.SelectedRows.Count > 0)
                {
                    string Contact = dataGridCustomers.SelectedRows[0].Cells[0].Value + string.Empty;
                    string FullName = dataGridCustomers.SelectedRows[0].Cells[1].Value + string.Empty;
                    string Address = dataGridCustomers.SelectedRows[0].Cells[2].Value + string.Empty;
                    DataCon newCon = new DataCon();
                    if (ConnectionState.Closed == newCon.Con.State)
                    {
                        newCon.Con.Open();
                    }
                    newCon.Con.Close();
                    lblContactNo.Text = Contact;
                    lblFullName.Text = FullName;
                }
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
                string Contact = txtContactNo.Text;
                string FullName = txtFullName.Text;
                string Address = txtAddress.Text;

                if (Contact != "" && FullName != "" && Address != "")
                {
                    switch (MessageBox.Show("Do you want to add this customer as loyalty customer?",
                    "Add Loyalty Customer",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            string Message = mcb.AddCustomer(Contact, FullName, Address);
                            lblMessage.Text = Message;
                            try
                            {
                                dataGridCustomers.DataSource = mcb.GetCustomers();
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
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (lblContactNo.Text != "")
            //{
            //    try
            //    {
            //        string Contact = lblContactNo.Text;
            //        String Message = null;
            //        try
            //        {
            //            switch (MessageBox.Show("Do you want to delete the selected Customer Data?",
            //            "Delete the Loyalty Customer",
            //            MessageBoxButtons.YesNo,
            //            MessageBoxIcon.Question))
            //            {
            //                case DialogResult.Yes:

            //                    lblMessage.Text = Message;
            //                    try
            //                    {
            //                        mcb.DeleteCustomer(Contact);
            //                        dataGridCustomers.DataSource = mcb.GetCustomers();
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        MessageBox.Show(ex.Message);
            //                    }
            //                    break;

            //                case DialogResult.No:
            //                    break;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            lblMessage.Text = ex.Message;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        lblMessage.Text = "Please select a row to delete";
            //    }
            //    catch (Exception ex)
            //    {
            //        lblMessage.Text = ex.Message;
            //    }
            //}
           
        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)e.KeyChar;

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            if ((keyvalue == DECIMAL_POINT) &&
            (txtContactNo.Text.IndexOf("") == NOT_FOUND)) return;
            e.Handled = true;
        }

        private void dataGC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGC.SelectedRows.Count > 0)
                {
                        string Contact = dataGC.SelectedRows[0].Cells[0].Value + string.Empty;
                        string FullName = dataGC.SelectedRows[0].Cells[1].Value + string.Empty;
                        string Address = dataGC.SelectedRows[0].Cells[2].Value + string.Empty;
                        DataCon newCon = new DataCon();
                        if (ConnectionState.Closed == newCon.Con.State)
                        {
                            newCon.Con.Open();
                        }
                        newCon.Con.Close();
                        lblContactNo.Text = Contact;
                        lblFullName.Text = FullName;
                        txtUpdateFullName.Text = FullName;
                        txtUpdateAddress.Text = Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (lblContactNo.Text != "")
            {
                try
                {
                    string Contact = lblContactNo.Text;
                    string Message = null;
                    string FullName = txtUpdateFullName.Text;
                    string Address = txtUpdateAddress.Text;
                    try
                    {
                        switch (MessageBox.Show("Do you want to update the selected customer Data?",
                        "Update the Loyalty Customer",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                        {
                            case DialogResult.Yes:
                                Message = mcb.UpdateCustomer(Contact, FullName, Address);
                                lblMessage.Text = Message;
                                try
                                {                                  
                                    dataGridCustomers.DataSource = mcb.GetCustomers();
                                    dataGC.DataSource = mcb.GetCustomers();
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
                        lblMessage.Text = ex.Message;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    lblMessage.Text = "Please select a row to Update";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message;
                }
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CashierPanel cp = new CashierPanel();
            cp.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 } 
