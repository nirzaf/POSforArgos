using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using POSforArgos.Business;
using POSforArgos.DLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace POSforArgos.View
{
    public partial class ManageSales : Form
    {
        ReceiptPrint rp = new ReceiptPrint();
        ManageItems mi = new ManageItems();
        ManageCustomerBL mc = new ManageCustomerBL();
        DataCon data = new DataCon();
        SalesBLL sb = new SalesBLL();
        public float GrossTotal = 0, Price,Total;
        public int Quantity = 0;
        public string Product_Name;
        DataTable newDataTable= new DataTable();

        public int Stock = 0;

        public ManageSales()
        {
            InitializeComponent();
        }

        //Generate transaction in data grid view 
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                try
                {
                    var ItemCode = txtItemCode.Text.Trim();
                    int Qty = Convert.ToInt32(txtQty.Text.Trim());
                    var QtyDt = sb.ItemQty(ItemCode);
                    newDataTable = sb.SalesItems(ItemCode);

                    foreach (DataRow dtr in QtyDt.Rows)
                    {
                        if (Stock == 0 )
                        {
                            Stock = Convert.ToInt32(dtr[1].ToString());
                            if (Stock < Qty)
                            {
                                MessageBox.Show("Insuffiecient stock on hand to complete the transaction");
                            }
                            else
                            {
                                foreach (DataRow dr in newDataTable.Rows)
                                {
                                    int qty = Convert.ToInt32(txtQty.Text);
                                    float UnitPrice = Convert.ToSingle(dr["Unit_Price"].ToString());
                                    float total = qty * UnitPrice;
                                    GrossTotal = GrossTotal + total;
                                    dataGridSales.Rows.Add(dataGridSales.RowCount, dr[0], dr[1], dr[2], txtQty.Text.Trim(), dr[3], total);
                                    lblTotalItems.Text = "  " + (dataGridSales.RowCount - 1) + " ";
                                    lblTotalValue.Text = "  " + GrossTotal + " ";
                                    Stock = Stock - Qty;
                                }
                            }
                        }
                        else
                        {
                            if (Stock < Qty)
                            {
                                MessageBox.Show("Insuffiecient stock on hand to complete the transaction");
                            }
                            else
                            {
                                foreach (DataRow dr in newDataTable.Rows)
                                {
                                    float UnitPrice = Convert.ToSingle(dr["Unit_Price"].ToString());
                                    int qty = Convert.ToInt32(txtQty.Text);
                                    float total = qty * UnitPrice;
                                    GrossTotal = GrossTotal + total;
                                    dataGridSales.Rows.Add(dataGridSales.RowCount, dr[0], dr[1], dr[2], txtQty.Text.Trim(), dr[3], total);
                                    lblTotalItems.Text = "  " + (dataGridSales.RowCount - 1) + " ";
                                    lblTotalValue.Text = "  " + GrossTotal + " ";
                                    Stock = Stock - Qty;
                                }
                            }
                        }
                    }

                    data.Con.Close();
                   // dt.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtItemCode.Clear();
                txtItemCode.Focus();
                txtQty.Clear();
                txtQty.Enabled = false;
            }
        }


        //Function pop ups while press enter button 
        private void txtItemCode_KeyPress(object sender, KeyPressEventArgs ergs)
        {
            if (ergs.KeyChar == 13)
            {
                txtQty.Enabled = true;
                txtQty.Focus();
            }
        }


        //Functions to load form initialization components
        public void FormLoad()
        {
            try
            {
                int Invoice = Convert.ToInt32(sb.Invoice());
                Invoice++;
                lblReceiptID.Text = Invoice.ToString();
                lblTotalItems.Text = "0";
                lblTotalValue.Text = "0";
                dataGridSales.DataSource = null;
                dataGridSales.Columns.Add("Row_Count", "Item Count");
                dataGridSales.Columns.Add("Item_Code", "Item Code");
                dataGridSales.Columns.Add("Item_Name", "Item Name");
                dataGridSales.Columns.Add("Unit_Price", "Unit Price");
                dataGridSales.Columns.Add("Quantity", "Quantity");
                dataGridSales.Columns.Add("Category", "Category");
                dataGridSales.Columns.Add("Total", "Total Price");
                lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                lblTime.Text = DateTime.Now.ToShortTimeString();
                lblLoyalCustomer.Text = "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ManageSales_Load(object sender, EventArgs e)
        {
            try
            {
                FormLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     

      // Sales transaction function 
        public string Sales_Transaction(bool result)
        {
            try
            {
                int Sales_ID, Transaction_ID, TransactionQty;
                string Date, Time, LoyaltyCustomerID, Cashier_Name;
                float Gross_Total;

                DataTable data = (DataTable)(dataGridSales.DataSource);
                Sales_ID = int.Parse(lblReceiptID.Text);
                Transaction_ID = int.Parse(lblReceiptID.Text);
                Gross_Total = float.Parse(lblTotalValue.Text);
                Date = lblDate.Text;
                Time = lblTime.Text;
                LoyaltyCustomerID = "0772049123";
                TransactionQty = int.Parse(lblTotalItems.Text);
                Cashier_Name = loginForm.SetValueForText1;
                string msg = sb.AddSalesProduct(data, Transaction_ID);
                return msg;
            }
            catch (Exception)
            {
                throw;
            }
        }

       //Function to Convert double to float
        public static float ToSingle(double value)
        {
            return (float)value;
        }


       // Check out function for Check out Button 
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                int Sales_ID, Transaction_ID, TransactionQty;
                string Date, Time, LoyaltyCustomerID, Cashier_Name;
                float Gross_Total;
                string msg,msg1;

                DataTable dt = new DataTable();
                DataTable dTable = new DataTable();
                foreach (DataGridViewColumn col in dataGridSales.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                int count = dt.Rows.Count;
                foreach (DataGridViewRow row in dataGridSales.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (row.IsNewRow) continue;
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                    dTable = dt.Rows.Cast<DataRow>().Where(DR => !DR.ItemArray.All(field => field is DBNull || string.IsNullOrWhiteSpace(field as string))).CopyToDataTable();
                }

                Sales_ID = int.Parse(lblReceiptID.Text);
                Transaction_ID = int.Parse(lblReceiptID.Text);
                Gross_Total = Convert.ToSingle(lblTotalValue.Text);
                Date = lblDate.Text;
                Time = lblTime.Text;
                if (lblLoyalCustomer.Text == "Valid")
                {
                    LoyaltyCustomerID = txtLoyalty.Text.Trim().ToString();
                    double points = Gross_Total * 0.01;
                    float Points = ToSingle(points);
                    string msg2 = mc.UpdatePoints(LoyaltyCustomerID, Points);
                }
                else
                    LoyaltyCustomerID = "00000000";

                float GT = ToSingle(Gross_Total);
                TransactionQty = int.Parse(lblTotalItems.Text);
                Cashier_Name = loginForm.SetValueForText1;
                msg = sb.AddSalesProduct(dTable, Transaction_ID);
                msg1 = sb.AddSalesTransaction(Transaction_ID, GT, Date, Time, LoyaltyCustomerID, TransactionQty, Cashier_Name);
                DataTable dataTable = new DataTable();
                dataTable = rp.Receipt(Transaction_ID);
                ExportToPdf(dataTable);
                MessageBox.Show("Added");
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Refresh button to realod the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        //Open the Manage Customer View Form 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageCustomerView mcv = new ManageCustomerView();
            mcv.Show();
        }

        private void dataGridSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        //Check out function 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                int Sales_ID, Transaction_ID, TransactionQty;
                string Date, Time, LoyaltyCustomerID, Cashier_Name;
                float Gross_Total;
                string msg, msg1;

                DataTable dt = new DataTable();
                DataTable dTable = new DataTable();
                foreach (DataGridViewColumn col in dataGridSales.Columns)
                {
                    dt.Columns.Add(col.Name);
                }

                int count = dt.Rows.Count;
                foreach (DataGridViewRow row in dataGridSales.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (row.IsNewRow) continue;
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                    dTable = dt.Rows.Cast<DataRow>().Where(DR => !DR.ItemArray.All(field => field is DBNull || string.IsNullOrWhiteSpace(field as string))).CopyToDataTable();
                }

                Sales_ID = int.Parse(lblReceiptID.Text);
                Transaction_ID = int.Parse(lblReceiptID.Text);
                Gross_Total = Convert.ToSingle(lblTotalValue.Text);
                Date = lblDate.Text;
                Time = lblTime.Text;
                if (lblLoyalCustomer.Text == "Valid")
                {
                    LoyaltyCustomerID = txtLoyalty.Text.Trim().ToString();
                    double points = Gross_Total * 0.01;
                    float Points = ToSingle(points);
                    string msg2 = mc.UpdatePoints(LoyaltyCustomerID, Points);
                }
                else
                    LoyaltyCustomerID = "00000000";

                float GT = ToSingle(Gross_Total);
                TransactionQty = int.Parse(lblTotalItems.Text);
                Cashier_Name = loginForm.SetValueForText1;
                msg = sb.AddSalesProduct(dTable, Transaction_ID);
                msg1 = sb.AddSalesTransaction(Transaction_ID, GT, Date, Time, LoyaltyCustomerID, TransactionQty, Cashier_Name);
                DataTable dataTable = new DataTable();
                dataTable = rp.Receipt(Transaction_ID);
                ExportToPdf(dataTable);
                MessageBox.Show("Transaction Completed");
                Hide();
                ManageSales ms = new ManageSales();
                ms.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // print function to export data grid as PDF
        private void btnPrint_Click(object sender, EventArgs e)
        {
            int Transaction_ID = int.Parse(lblReceiptID.Text);
            DataTable dataTable = new DataTable();
            dataTable = rp.Receipt(Transaction_ID);
            ExportToPdf(dataTable);
        }

        // print fucntion to export data grid as PDF
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int Transaction_ID = int.Parse(lblReceiptID.Text);
            DataTable dataTable = rp.Receipt(Transaction_ID);
            ExportToPdf(dataTable);
        }

        //Class to Export file as PDF
        public void ExportToPdf(DataTable dt)
        {
            Document document = new Document();
            string filename = "Receipt.PDF".AppendTimeStamp();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
            document.Open();
            iTextSharp.text.Font font5 = FontFactory.GetFont(FontFactory.HELVETICA, 5);

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            PdfPRow row = null;
            float[] widths = new float[] { 4f, 4f, 4f, 4f, 4f, 4f };

            table.SetWidths(widths);

            table.WidthPercentage = 100;
            int iCol = 0;
            string colname = "";
            PdfPCell cell = new PdfPCell(new Phrase("Products"));

            cell.Colspan = dt.Columns.Count;

            foreach (DataColumn c in dt.Columns)
            {
                table.AddCell(new Phrase(c.ColumnName, font5));
            }

            foreach (DataRow r in dt.Rows)
            {
                if (dt.Rows.Count > 0)
                {
                    table.AddCell(new Phrase(r[0].ToString(), font5));
                    table.AddCell(new Phrase(r[1].ToString(), font5));
                    table.AddCell(new Phrase(r[2].ToString(), font5));
                    table.AddCell(new Phrase(r[3].ToString(), font5));
                    table.AddCell(new Phrase(r[4].ToString(), font5));
                    table.AddCell(new Phrase(r[5].ToString(), font5));
                }
            }
            document.Add(table);
            document.Close();
        }

   
      //Function to check loyalty customer existing or not
        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool valid = mc.SelectCustomer(txtLoyalty.Text);
            if (valid == true)
                lblLoyalCustomer.Text = "Valid";
            else
                lblLoyalCustomer.Text = "Invalid";
        }
    }

    public static class MyExtensions
    {
        public static string AppendTimeStamp(this string fileName)
        {
            return string.Concat(
                Path.GetFileNameWithoutExtension(fileName),
                DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                Path.GetExtension(fileName)
                );
        }
    }
}
