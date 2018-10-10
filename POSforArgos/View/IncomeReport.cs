using System;
using System.Windows.Forms;
using POSforArgos.Business;
using Excel = Microsoft.Office.Interop.Excel;

namespace POSforArgos.View
{
    public partial class IncomeReport : Form
    {
        SalesBLL sb = new SalesBLL();
        public IncomeReport()
        {
            InitializeComponent();
        }

        private void IncomeReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myPosDbDataSet1.Sales_Transaction' table. You can move, or remove it, as needed.
            this.sales_TransactionTableAdapter.Fill(this.myPosDbDataSet1.Sales_Transaction);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtFrom.CustomFormat = "dd/MM/yyyy";
            string FromDate = dtFrom.Value.ToShortDateString();

            dtTo.CustomFormat = "dd/MM/yyyy";
            string ToDate = dtTo.Value.ToShortDateString();
            dgvIR.DataSource = sb.IncomeReport(FromDate, ToDate);

            int sum = 0;
            for (int i = 0; i < dgvIR.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvIR.Rows[i].Cells[4].Value);
            }
            lblTotal.Text = "Rs. " + sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            Hide();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtFrom.CustomFormat = "dd/MM/yyyy";
            string FromDate = dtFrom.Value.ToShortDateString();
            lblFrom.Text = FromDate;
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            dtTo.CustomFormat = "dd/MM/yyyy";
            string ToDate = dtTo.Value.ToShortDateString();
            lblTo.Text = ToDate;
        }

        //Class to copy all the data gird view data to clip board

        private void copyAlltoClipboard()
        {
            dgvIR.SelectAll();
            DataObject dataObj = dgvIR.GetClipboardContent();
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
