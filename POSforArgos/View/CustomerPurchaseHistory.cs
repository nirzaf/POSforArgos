using System;
using System.Windows.Forms;
using POSforArgos.Business;
using Excel = Microsoft.Office.Interop.Excel;

namespace POSforArgos.View
{
    public partial class CustomerPurchaseHistory : Form
    {
        SalesBLL sb = new SalesBLL();
        public CustomerPurchaseHistory()
        {
            InitializeComponent();          
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int cont = Convert.ToInt32(txtInvoiceNo.Text.Trim().ToString());
            dgvCPH.DataSource = sb.InvoiceNo(cont);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cont = txtContactNo.Text.Trim().ToString();
            dgvCPH.DataSource = sb.ContNo(cont);
        }

        //Class to copy all the data gird view data to clip board

        private void copyAlltoClipboard()
        {
            dgvCPH.SelectAll();
            DataObject dataObj = dgvCPH.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        //This class will copy all the data from data grid view to excell 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Excel.Application xlexcel;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
