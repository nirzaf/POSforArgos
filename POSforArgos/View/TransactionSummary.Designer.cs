namespace POSforArgos.View
{
    partial class TransactionSummary
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
            this.dgvTS = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyCustomerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPosDbDataSet1 = new POSforArgos.myPosDbDataSet1();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sales_TransactionTableAdapter = new POSforArgos.myPosDbDataSet1TableAdapters.Sales_TransactionTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTS
            // 
            this.dgvTS.AllowUserToAddRows = false;
            this.dgvTS.AllowUserToDeleteRows = false;
            this.dgvTS.AutoGenerateColumns = false;
            this.dgvTS.BackgroundColor = System.Drawing.Color.White;
            this.dgvTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.grossTotalDataGridViewTextBoxColumn,
            this.cashierNameDataGridViewTextBoxColumn,
            this.loyaltyCustomerIDDataGridViewTextBoxColumn});
            this.dgvTS.DataSource = this.salesTransactionBindingSource;
            this.dgvTS.Location = new System.Drawing.Point(12, 77);
            this.dgvTS.Name = "dgvTS";
            this.dgvTS.ReadOnly = true;
            this.dgvTS.Size = new System.Drawing.Size(809, 252);
            this.dgvTS.TabIndex = 0;
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
            this.salesTransactionBindingSource.DataSource = this.myPosDbDataSet1;
            // 
            // myPosDbDataSet1
            // 
            this.myPosDbDataSet1.DataSetName = "myPosDbDataSet1";
            this.myPosDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDate.Location = new System.Drawing.Point(119, 18);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(212, 26);
            this.dtDate.TabIndex = 1;
            this.dtDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Date";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(340, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sales_TransactionTableAdapter
            // 
            this.sales_TransactionTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Quantity Sold";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(292, 332);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(0, 24);
            this.lblQty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Sales Value";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(538, 332);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(173, 24);
            this.lblSales.TabIndex = 7;
            this.lblSales.Text = "Total Sales Value";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSforArgos.Properties.Resources.Excel_icon;
            this.pictureBox1.Location = new System.Drawing.Point(728, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TransactionSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.dgvTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransactionSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Transaction Summary";
            this.Load += new System.EventHandler(this.TransactionSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTS;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}