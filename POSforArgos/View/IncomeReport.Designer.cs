namespace POSforArgos.View
{
    partial class IncomeReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvIR = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyCustomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPosDbDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPosDbDataSet1 = new POSforArgos.myPosDbDataSet1();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.sales_TransactionTableAdapter = new POSforArgos.myPosDbDataSet1TableAdapters.Sales_TransactionTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIR
            // 
            this.dgvIR.AllowUserToAddRows = false;
            this.dgvIR.AllowUserToDeleteRows = false;
            this.dgvIR.AutoGenerateColumns = false;
            this.dgvIR.BackgroundColor = System.Drawing.Color.White;
            this.dgvIR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.grossTotalDataGridViewTextBoxColumn,
            this.cashierNameDataGridViewTextBoxColumn,
            this.loyaltyCustomerIDDataGridViewTextBoxColumn});
            this.dgvIR.DataSource = this.salesTransactionBindingSource;
            this.dgvIR.Location = new System.Drawing.Point(12, 84);
            this.dgvIR.Name = "dgvIR";
            this.dgvIR.ReadOnly = true;
            this.dgvIR.Size = new System.Drawing.Size(774, 269);
            this.dgvIR.TabIndex = 0;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "Transaction_ID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "Transaction_ID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grossTotalDataGridViewTextBoxColumn
            // 
            this.grossTotalDataGridViewTextBoxColumn.DataPropertyName = "Gross_Total";
            this.grossTotalDataGridViewTextBoxColumn.HeaderText = "Gross_Total";
            this.grossTotalDataGridViewTextBoxColumn.Name = "grossTotalDataGridViewTextBoxColumn";
            this.grossTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashierNameDataGridViewTextBoxColumn
            // 
            this.cashierNameDataGridViewTextBoxColumn.DataPropertyName = "Cashier_Name";
            this.cashierNameDataGridViewTextBoxColumn.HeaderText = "Cashier_Name";
            this.cashierNameDataGridViewTextBoxColumn.Name = "cashierNameDataGridViewTextBoxColumn";
            this.cashierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loyaltyCustomerIDDataGridViewTextBoxColumn
            // 
            this.loyaltyCustomerIDDataGridViewTextBoxColumn.DataPropertyName = "LoyaltyCustomerID";
            this.loyaltyCustomerIDDataGridViewTextBoxColumn.HeaderText = "LoyaltyCustomerID";
            this.loyaltyCustomerIDDataGridViewTextBoxColumn.Name = "loyaltyCustomerIDDataGridViewTextBoxColumn";
            this.loyaltyCustomerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesTransactionBindingSource
            // 
            this.salesTransactionBindingSource.DataMember = "Sales_Transaction";
            this.salesTransactionBindingSource.DataSource = this.myPosDbDataSet1BindingSource;
            // 
            // myPosDbDataSet1BindingSource
            // 
            this.myPosDbDataSet1BindingSource.DataSource = this.myPosDbDataSet1;
            this.myPosDbDataSet1BindingSource.Position = 0;
            // 
            // myPosDbDataSet1
            // 
            this.myPosDbDataSet1.DataSetName = "myPosDbDataSet1";
            this.myPosDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(75, 13);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 20);
            this.dtFrom.TabIndex = 1;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(349, 15);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 20);
            this.dtTo.TabIndex = 3;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sales_TransactionTableAdapter
            // 
            this.sales_TransactionTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(703, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Income Between ";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(211, 384);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(124, 20);
            this.lblFrom.TabIndex = 8;
            this.lblFrom.Text = "Selected Date";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(356, 384);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(124, 20);
            this.lblTo.TabIndex = 9;
            this.lblTo.Text = "Selected Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "=";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(539, 384);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSforArgos.Properties.Resources.Excel_icon;
            this.pictureBox1.InitialImage = global::POSforArgos.Properties.Resources.Excel_icon;
            this.pictureBox1.Location = new System.Drawing.Point(566, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.dgvIR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "IncomeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Report (Date wise)";
            this.Load += new System.EventHandler(this.IncomeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIR;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource myPosDbDataSet1BindingSource;
        private myPosDbDataSet1 myPosDbDataSet1;
        private System.Windows.Forms.BindingSource salesTransactionBindingSource;
        private myPosDbDataSet1TableAdapters.Sales_TransactionTableAdapter sales_TransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltyCustomerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}