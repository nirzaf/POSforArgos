using POSforArgos.Business;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace POSforArgos.View
{
    public partial class TransactionSummary : Form
    {
        SalesBLL sb = new SalesBLL();

        public TransactionSummary()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtDate.CustomFormat = "dd/MM/yyyy";
            string SelectedDate = dtDate.Value.ToShortDateString();
            dgvTS.DataSource = sb.DailyTransactionSummary(SelectedDate);

            int sum = 0;
            int SalesSum = 0;
            for (int i = 0; i < dgvTS.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvTS.Rows[i].Cells[3].Value);
                SalesSum += Convert.ToInt32(dgvTS.Rows[i].Cells[4].Value);
            }
            lblQty.Text = sum.ToString();
            lblSales.Text = "Rs. " +SalesSum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void TransactionSummary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myPosDbDataSet1.Sales_Transaction' table. You can move, or remove it, as needed.
            this.sales_TransactionTableAdapter.Fill(this.myPosDbDataSet1.Sales_Transaction);
            int sum = 0;
            int SalesSum = 0;
            for (int i = 0; i < dgvTS.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvTS.Rows[i].Cells[3].Value);
                SalesSum += Convert.ToInt32(dgvTS.Rows[i].Cells[4].Value);
            }
            lblQty.Text = sum.ToString();
            lblSales.Text = "Rs. " + SalesSum.ToString();

        }


        //Class to copy all the data gird view data to clip board

        private void copyAlltoClipboard()
        {
            dgvTS.SelectAll();
            DataObject dataObj = dgvTS.GetClipboardContent();
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
