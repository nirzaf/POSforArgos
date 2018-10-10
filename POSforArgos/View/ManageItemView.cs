using System;
using System.Data;
using System.Windows.Forms;
using POSforArgos.Business;
using POSforArgos.DLL;

namespace POSforArgos.View
{
    public partial class ManageItemView : Form
    {
        GRNBusinessLayer bl = new GRNBusinessLayer();
        ManageItems obj = new ManageItems();
        DataCon newCon = new DataCon();

        public ManageItemView()
        {
            InitializeComponent();
        }

        private void ManageItemView_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridItems.DataSource = obj.GetItems();
                cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;              
                cmbCategory.DataSource = bl.cmbCatLoad();
                cmbCategory.ValueMember = "Cat_ID";
                cmbCategory.DisplayMember = "Category";
                lblMessage.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridItems.DataSource = obj.GetItems();
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
                if(txtItemCode.Text != "" || txtItemName.Text != "" || txtUnitPrice.Text != "")
                {
                    string ItemCode = txtItemCode.Text;
                    string ItemName = txtItemName.Text;
                    float UnitPrice = float.Parse(txtUnitPrice.Text);
                    int Category = int.Parse(cmbCategory.SelectedValue.ToString());
            
                    switch (MessageBox.Show("Do you want to add this product?",
                    "Add Item",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            //string message = obj.AddStock(ItemCode);
                            string Message = obj.AddItems(ItemCode, ItemName, UnitPrice, Category);
                            lblMessage.Text = Message;
                            //MessageBox.Show(Message);
                            try
                            {
                                dataGridItems.DataSource = obj.GetItems();
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
                else
                {
                    lblMessage.Text = "Do not leave any blank field";
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
                if (txtItemCode.Text != "" || txtItemName.Text != "" || txtUnitPrice.Text != "")
                {
                    string ItemCode = txtItemCode.Text;
                    string ItemName = txtItemName.Text;
                    float UnitPrice = float.Parse(txtUnitPrice.Text);
                    int Cat_ID;
                    bool parseOK = Int32.TryParse(cmbCategory.SelectedValue.ToString(), out Cat_ID);

                    switch (MessageBox.Show("Do you want to update this product?",
                    "Update Products",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            string Message = obj.UpdateItem(ItemCode, ItemName, UnitPrice,Cat_ID);
                            lblMessage.Text = Message;
                            try
                            {
                                dataGridItems.DataSource = obj.GetItems();
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
                else
                {
                    lblMessage.Text = "Do not leave any blank field";
                }

            }
            catch (Exception xx)
            {
                MessageBox.Show(xx.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string ItemCode = txtItemCode.Text;
            String Message = null;
            try
            {
                switch (MessageBox.Show("Do you want to delete the selected Item?",
                "Delete the Product",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        lblMessage.Text = Message;
                        try
                        {
                            obj.DeleteItem(ItemCode);
                            dataGridItems.DataSource = obj.GetItems();
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

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = (int)e.KeyChar; 

            if ((keyvalue == BACKSPACE) ||
            ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            // Allow the first (but only the first) decimal point
            if ((keyvalue == DECIMAL_POINT) &&
            (txtUnitPrice.Text.IndexOf(".") == NOT_FOUND)) return;
            // Allow nothing else
            e.Handled = true;
        }

        private void dataGridItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridItems.SelectedRows.Count > 0)
                {
                    string ItemCode = dataGridItems.SelectedRows[0].Cells[0].Value + string.Empty;
                    string ItemName = dataGridItems.SelectedRows[0].Cells[1].Value + string.Empty;
                    string UnitPrice = dataGridItems.SelectedRows[0].Cells[2].Value + string.Empty;
                    string Category = dataGridItems.SelectedRows[0].Cells[3].Value + string.Empty;
                    DataCon newCon = new DataCon();
                    if (ConnectionState.Closed == newCon.Con.State)
                    {
                        newCon.Con.Open();
                    }
                    txtItemCode.Text = ItemCode;
                    txtItemName.Text = ItemName;
                    txtUnitPrice.Text = UnitPrice;
                   // cmbCategory.SelectedValue = Category;
                    newCon.Con.Close();


                }
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
                dataGridItems.DataSource = obj.SearchItems(Search);
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
                dataGridItems.DataSource = obj.SearchItems(Search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void btnAdd_MouseUp(object sender, MouseEventArgs e)
        {
 
        }
    }
}
