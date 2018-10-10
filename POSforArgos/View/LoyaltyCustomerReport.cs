using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace POSforArgos.View
{
    public partial class LoyaltyCustomerReport : Form
    {
        public LoyaltyCustomerReport()
        {
            InitializeComponent();
        }

        private void LoyaltyCustomerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myPosDbDataLoyaltyCustomer.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.myPosDbDataLoyaltyCustomer.Customer);
            // TODO: This line of code loads data into the 'myPosDbDataSet.Item_Stock' table. You can move, or remove it, as needed.
            this.item_StockTableAdapter.Fill(this.myPosDbDataSet.Item_Stock);

        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        //Class to copy all the data gird view data to clip board

        private void copyAlltoClipboard()
        {
            dgvLoyaltyCustomers.SelectAll();
            DataObject dataObj = dgvLoyaltyCustomers.GetClipboardContent();
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
