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
    public partial class ReceiveGoods : Form
    {
        GRNBusinessLayer bl = new GRNBusinessLayer();
        ManageItems mi = new ManageItems();
        public DateTime MaxDate { get; set; }


        public ReceiveGoods()
        {
            InitializeComponent();    
        }
        private void ReceiveGoods_Load(object sender, EventArgs e)
        {
            try
            {
                cmbItemCode.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbItemCode.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbItemCode.DataSource = bl.cmbItemCode();
                cmbItemCode.DisplayMember = "Item_Code";
                cmbItemCode.ValueMember = "Item_Code";
                dtPickerReceivedDate.MaxDate = DateTime.Today;
                dataGridItems.DataSource = mi.GetItems();
                cmbItemCode.DataSource = mi.GetItems();
                // load the view GRN Notes 
                dataGRNNotes.DataSource = bl.GetGRN();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtReceivedQty_KeyPress(object sender, KeyPressEventArgs e)
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
            (txtReceivedQty.Text.IndexOf("") == NOT_FOUND)) return;
            e.Handled = true;
        }

        private void btnAddStockNow_Click(object sender, EventArgs e)
        {
            try
            {
                string Invoice_No = txtInvoiceNumber.Text;
                string ItemCode = cmbItemCode.Text.ToString();
                int Received_Quantity = int.Parse(txtReceivedQty.Text);
                dtPickerReceivedDate.CustomFormat = "dd/MM/yyyy";
                string ReceivedDate = dtPickerReceivedDate.Value.ToString();
                string AddedBy = loginForm.SetValueForText1;
                string Message = bl.AddStock(Invoice_No, ItemCode, Received_Quantity, ReceivedDate, AddedBy);
                lblMessage.Text = Message;
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }

        private void btnFilterByInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                // dataGRNNotes.DataSource = bl.SearchGRN(txtInvoiceNo.Text);
                (dataGRNNotes.DataSource as DataTable).DefaultView.RowFilter = string.Format("Invoice_Number LIKE '{0}%' OR Invoice_Number LIKE '% {0}%'", txtInvoiceNo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            try
            {
               dataGRNNotes.DataSource = bl.GetGRN();             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void txtInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            (dataGRNNotes.DataSource as DataTable).DefaultView.RowFilter = string.Format("Invoice_Number LIKE '{0}%' OR Invoice_Number LIKE '% {0}%'", txtInvoiceNo.Text);
        }

        private void txtInvoiceNo_KeyUp(object sender, KeyEventArgs e)
        {
            (dataGRNNotes.DataSource as DataTable).DefaultView.RowFilter = string.Format("Invoice_Number LIKE '{0}%' OR Invoice_Number LIKE '% {0}%'", txtInvoiceNo.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGRNNotes.DataSource = bl.GetGRN();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
