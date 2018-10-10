namespace POSforArgos.View
{
    partial class LoyaltyCustomerReport
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
            this.dgvLoyaltyCustomers = new System.Windows.Forms.DataGridView();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myPosDbDataLoyaltyCustomer = new POSforArgos.myPosDbDataLoyaltyCustomer();
            this.btnMain = new System.Windows.Forms.Button();
            this.myPosDbDataSet = new POSforArgos.View.myPosDbDataSet();
            this.itemStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_StockTableAdapter = new POSforArgos.View.myPosDbDataSetTableAdapters.Item_StockTableAdapter();
            this.customerTableAdapter = new POSforArgos.myPosDbDataLoyaltyCustomerTableAdapters.CustomerTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataLoyaltyCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoyaltyCustomers
            // 
            this.dgvLoyaltyCustomers.AutoGenerateColumns = false;
            this.dgvLoyaltyCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoyaltyCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoyaltyCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactNoDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.loyaltyPointsDataGridViewTextBoxColumn});
            this.dgvLoyaltyCustomers.DataSource = this.customerBindingSource;
            this.dgvLoyaltyCustomers.Location = new System.Drawing.Point(12, 12);
            this.dgvLoyaltyCustomers.Name = "dgvLoyaltyCustomers";
            this.dgvLoyaltyCustomers.ReadOnly = true;
            this.dgvLoyaltyCustomers.Size = new System.Drawing.Size(503, 351);
            this.dgvLoyaltyCustomers.TabIndex = 0;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loyaltyPointsDataGridViewTextBoxColumn
            // 
            this.loyaltyPointsDataGridViewTextBoxColumn.DataPropertyName = "Loyalty_Points";
            this.loyaltyPointsDataGridViewTextBoxColumn.HeaderText = "Loyalty_Points";
            this.loyaltyPointsDataGridViewTextBoxColumn.Name = "loyaltyPointsDataGridViewTextBoxColumn";
            this.loyaltyPointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.myPosDbDataLoyaltyCustomer;
            // 
            // myPosDbDataLoyaltyCustomer
            // 
            this.myPosDbDataLoyaltyCustomer.DataSetName = "myPosDbDataLoyaltyCustomer";
            this.myPosDbDataLoyaltyCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(386, 384);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(129, 47);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Back to Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // myPosDbDataSet
            // 
            this.myPosDbDataSet.DataSetName = "myPosDbDataSet";
            this.myPosDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemStockBindingSource
            // 
            this.itemStockBindingSource.DataMember = "Item_Stock";
            this.itemStockBindingSource.DataSource = this.myPosDbDataSet;
            // 
            // item_StockTableAdapter
            // 
            this.item_StockTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POSforArgos.Properties.Resources.Excel_icon;
            this.pictureBox1.Location = new System.Drawing.Point(299, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoyaltyCustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.dgvLoyaltyCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoyaltyCustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loyalty Customer Report";
            this.Load += new System.EventHandler(this.LoyaltyCustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoyaltyCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataLoyaltyCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPosDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoyaltyCustomers;
        private System.Windows.Forms.Button btnMain;
        private myPosDbDataSet myPosDbDataSet;
        private System.Windows.Forms.BindingSource itemStockBindingSource;
        private myPosDbDataSetTableAdapters.Item_StockTableAdapter item_StockTableAdapter;
        private myPosDbDataLoyaltyCustomer myPosDbDataLoyaltyCustomer;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private myPosDbDataLoyaltyCustomerTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltyPointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}