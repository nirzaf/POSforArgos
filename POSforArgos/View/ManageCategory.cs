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
    public partial class ManageCategory : Form
    {
        public string Cat_ID;
        public string CategoryName;
        CategoryManagement obj = new CategoryManagement();

        public ManageCategory()
        {
            InitializeComponent();
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridCategory.DataSource = obj.GetCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);     
            }
        }

        private void dataGridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridCategory.SelectedRows.Count > 0)
                {
                    Cat_ID = dataGridCategory.SelectedRows[0].Cells[0].Value + string.Empty;
                    CategoryName = dataGridCategory.SelectedRows[0].Cells[1].Value + string.Empty;

                    txtCategoryUpdate.Text = CategoryName;
                    lblID.Text = Cat_ID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int catID = int.Parse(lblID.Text);

            try
            {
                if (txtCategoryUpdate.Text == "")
                {
                    lblMessage.Text = "Category cannot be empty";
                }
                else
                {
                    switch (MessageBox.Show("Do you want to update the category?",
                    "Update Category",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            obj.UpdateCategory(catID, txtCategoryUpdate.Text);
                            lblMessage.Text = "Succesfully Updated";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
              switch (MessageBox.Show("Do you want to delete the selected category?",
              "Delete Category",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        int catID = int.Parse(lblID.Text);
                        obj.DeleteCategory(catID);
                        lblMessage.Text = "Succesfully deleted";
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

        private void ManageCategory_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            try
            {
                dataGridCategory.DataSource = obj.GetCategory();
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
                if (txtCategoryUpdate.Text == "")
                {
                   lblMessage.Text = "Category cannot be empty";
                }
                else
                {
                    switch (MessageBox.Show("Do you want to add the category?",
                    "Add Category",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            obj.InsertCategory(txtCategoryUpdate.Text);
                            lblMessage.Text = "Succesfully Added";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }
    }
}
